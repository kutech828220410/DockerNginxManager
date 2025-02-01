using System;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;

namespace CertificateConverter
{
    public class PfxConverter
    {   
        /// <summary>
        /// 檢查 PFX 憑證的密碼是否正確
        /// </summary>
        /// <param name="pfxPath">PFX 檔案路徑</param>
        /// <param name="password">PFX 密碼</param>
        /// <returns>如果密碼正確則返回 true，否則返回 false</returns>
        public static bool IsPfxPasswordCorrect(string pfxPath, string password)
        {
            try
            {
                // 嘗試載入 PFX 憑證
                var cert = new X509Certificate2(pfxPath, password, X509KeyStorageFlags.Exportable);
                return true;
            }
            catch (CryptographicException)
            {
                return false;
            }
        }
        /// <summary>
        /// 將 PFX 憑證轉換為 .key 和 .crt 格式
        /// </summary>
        /// <param name="pfxPath">PFX 檔案路徑</param>
        /// <param name="password">PFX 密碼</param>
        /// <param name="keyFile">輸出的私鑰檔案名稱 (.key)</param>
        /// <param name="certFile">輸出的憑證檔案名稱 (.crt)</param>
        public static void ConvertPfxToPem(string pfxPath, string password, string keyFile, string certFile)
        {
            try
            {
                // 讀取 PFX 憑證
                var cert = new X509Certificate2(pfxPath, password, X509KeyStorageFlags.Exportable);

                // 轉換證書 (.crt)
                using (var certWriter = new StreamWriter(certFile))
                {
                    var pemWriter = new PemWriter(certWriter);
                    pemWriter.WriteObject(DotNetUtilities.FromX509Certificate(cert));
                }

                // 轉換私鑰 (.key)
                var rsa = cert.GetRSAPrivateKey();
                if (rsa != null)
                {
                    using (var keyWriter = new StreamWriter(keyFile))
                    {
                        var pemWriter = new PemWriter(keyWriter);
                        var keyParams = DotNetUtilities.GetRsaKeyPair(rsa);
                        pemWriter.WriteObject(keyParams.Private);
                    }
                }
            }
            catch (CryptographicException ex)
            {
                Console.WriteLine($"錯誤: 無法載入 PFX 檔案，可能是密碼錯誤或文件損壞。詳細資訊: {ex.Message}");
                throw new Exception("PFX 憑證加載失敗，請確認密碼是否正確。");
            }
        }

        /// <summary>
        /// 將證書、私鑰及中繼憑證轉換為 PFX
        /// </summary>
        /// <param name="certPath">主憑證 (.crt)</param>
        /// <param name="keyPath">私鑰 (.key)</param>
        /// <param name="intermediatePath">中繼憑證 (.crt)</param>
        /// <param name="pfxPath">輸出的 PFX 檔案</param>
        /// <param name="password">PFX 密碼</param>
        public static void ConvertPemToPfx(string certPath, string keyPath, string intermediatePath, string pfxPath, string password)
        {
            var certParser = new X509CertificateParser();
            var keyReader = new StreamReader(keyPath);
            var pemReader = new PemReader(keyReader);
            var keyPair = pemReader.ReadObject() as AsymmetricCipherKeyPair;
            keyReader.Close();

            var certReader = new StreamReader(certPath);
            var cert = certParser.ReadCertificate(certReader.BaseStream);
            certReader.Close();

            var intermediateReader = new StreamReader(intermediatePath);
            var intermediateCert = certParser.ReadCertificate(intermediateReader.BaseStream);
            intermediateReader.Close();

            var store = new Pkcs12StoreBuilder().Build();
            var certEntry = new X509CertificateEntry(cert);
            store.SetCertificateEntry("certificate", certEntry);
            store.SetKeyEntry("privateKey", new AsymmetricKeyEntry(keyPair.Private), new[] { certEntry, new X509CertificateEntry(intermediateCert) });

            using (var pfxStream = File.Create(pfxPath))
            {
                store.Save(pfxStream, password.ToCharArray(), new SecureRandom());
            }
        }
        /// <summary>
        /// 將證書、私鑰及中繼憑證轉換為 PEM
        /// </summary>
        public static void ConvertToPem(string certPath, string keyPath, string intermediatePath, string outputPemPath)
        {
            using (var pemWriter = new StreamWriter(outputPemPath))
            {
                var certReader = new StreamReader(certPath);
                var cert = certReader.ReadToEnd();
                certReader.Close();
                pemWriter.WriteLine(cert);

                var keyReader = new StreamReader(keyPath);
                var key = keyReader.ReadToEnd();
                keyReader.Close();
                pemWriter.WriteLine(key);

                var intermediateReader = new StreamReader(intermediatePath);
                var intermediateCert = intermediateReader.ReadToEnd();
                intermediateReader.Close();
                pemWriter.WriteLine(intermediateCert);
            }
        }
     
    }
}
