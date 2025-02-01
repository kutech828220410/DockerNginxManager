using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;
using Basic;
using System.Linq; // Add this using directive
using System.IO;
using System.Text;

namespace NginxManagerLib
{

    using System;
    using System.Collections.Generic;
    using System.Text;
    using static NginxManagerLib.NginxParameters;

    /// <summary>
    /// 表示 NGINX 伺服器的配置參數。
    /// </summary>
    public class NginxParameters
    {
        /// <summary>
        /// SSL 加密套件枚舉。
        /// </summary>
        public enum SslCiphersEnum
        {
            EECDH_AESGCM_EECDH_CHACHA20_EDH_AESGCM,
            EECDH_AES128GCM_SHA256_EECDH_CHACHA20,
            TLS_AES_256_GCM_SHA384_EECDH_AESGCM,
            DHE_RSA_AES256_SHA_DHE_RSA_AES128_SHA
        }
        /// <summary>
        /// 大客戶端標頭緩衝區枚舉。
        /// </summary>
        public enum LargeClientHeaderBuffersEnum
        {
            Small,
            Medium,
            Large
        }
        /// <summary>
        /// SSL 緩衝區大小枚舉。
        /// </summary>
        public enum SslBufferSizeEnum
        {
            Tiny,
            Small,
            Medium,
            Large
        }
        public enum SslSessionTimeoutEnum
        {
            Tiny,
            Small,
            Medium,
            Large
        }
        /// <summary>是否使用 HTTP 無 SSL 連線。</summary>
        public bool UseHttp { get; set; } = false;

        /// <summary>監聽的端口號。</summary>
        public int ListenPort { get; set; } = 4443;

        /// <summary>是否啟用 SSL。</summary>
        public bool Ssl { get; set; } = true;

        /// <summary>是否啟用 HTTP/2。</summary>
        public bool Http2 { get; set; } = true;

        /// <summary>伺服器名稱（域名）。</summary>
        public string ServerName { get; set; } = "www.kutech.tw";

        /// <summary>SSL 憑證的檔案路徑。</summary>
        public string SslCertificate { get; set; } = "/etc/nginx/ssl/full_chain.crt";

        /// <summary>SSL 私鑰的檔案路徑。</summary>
        public string SslCertificateKey { get; set; } = "/etc/nginx/ssl/cert.key";

        /// <summary>是否支援 TLSv1.2 協議。</summary>
        public bool SslProtocolTls12 { get; set; } = true;

        /// <summary>是否支援 TLSv1.3 協議。</summary>
        public bool SslProtocolTls13 { get; set; } = true;

        /// <summary>SSL 使用的加密套件。</summary>
        public SslCiphersEnum SslCiphers { get; set; } = SslCiphersEnum.EECDH_AESGCM_EECDH_CHACHA20_EDH_AESGCM;

        /// <summary>是否優先使用伺服器端的加密套件。</summary>
        public bool SslPreferServerCiphers { get; set; } = true;

        /// <summary>SSL 會話快取設置。</summary>
        public string SslSessionCache { get; set; } = "shared:SSL:200m";

        /// <summary>SSL 會話超時時間。</summary>
        public SslSessionTimeoutEnum SslSessionTimeout { get; set; } = SslSessionTimeoutEnum.Small;

        /// <summary>是否啟用 SSL 會話票據。</summary>
        public bool SslSessionTickets { get; set; } = true;

        /// <summary>SSL buffer 大小。</summary>
        public SslBufferSizeEnum SslBufferSize { get; set; } = SslBufferSizeEnum.Medium;

        /// <summary>是否啟用 OCSP Stapling。</summary>
        public bool SslStapling { get; set; } = true;

        /// <summary>是否驗證 OCSP Stapling。</summary>
        public bool SslStaplingVerify { get; set; } = true;

        /// <summary>DNS 解析器地址列表。</summary>
        public List<string> DNS { get; set; } = new List<string> { "8.8.8.8", "1.1.1.1" };

        /// <summary>DNS 解析超時時間。</summary>
        public string DNSResolverTimeout { get; set; } = "5s";

        /// <summary>HTTP 嚴格傳輸安全策略（HSTS）。</summary>
        public string StrictTransportSecurity { get; set; } = "max-age=31536000; includeSubDomains; preload";

        /// <summary>用於代理的 HTTP 標頭設置。</summary>
        public Dictionary<string, string> ProxyHeaders { get; set; } = new Dictionary<string, string>
                {
                    { "Host", "$host" },
                    { "X-Real-IP", "$remote_addr" },
                    { "X-Forwarded-For", "$proxy_add_x_forwarded_for" },
                    { "X-Forwarded-Proto", "$scheme" }
                };

        /// <summary>Keep-Alive 連線超時。</summary>
        public string KeepaliveTimeout { get; set; } = "75";

        /// <summary>是否啟用 sendfile。</summary>
        public bool Sendfile { get; set; } = true;

        /// <summary>是否啟用 TCP_NODELAY。</summary>
        public bool TcpNodelay { get; set; } = true;

        /// <summary>是否啟用 TCP_NOPUSH。</summary>
        public bool TcpNopush { get; set; } = true;

        /// <summary>是否保持與 FastCGI 的連線。</summary>
        public bool FastcgiKeepConn { get; set; } = true;

        /// <summary>客戶端最大請求體大小。</summary>
        public string ClientMaxBodySize { get; set; } = "20M";

        /// <summary>客戶端請求體超時。</summary>
        public string ClientBodyTimeout { get; set; } = "10s";

        /// <summary>客戶端請求標頭超時。</summary>
        public string ClientHeaderTimeout { get; set; } = "10s";

        /// <summary>大請求標頭 buffer 設置。</summary>
        public LargeClientHeaderBuffersEnum LargeClientHeaderBuffers { get; set; } = LargeClientHeaderBuffersEnum.Large;

        /// <summary>是否啟用 Gzip 壓縮。</summary>
        public bool Gzip { get; set; } = true;

        /// <summary>Gzip 壓縮的 MIME 類型。</summary>
        public List<string> GzipTypes { get; set; } = new List<string>
                {
                    "text/plain", "text/css", "application/json", "application/javascript",
                    "text/xml", "application/xml", "application/xml+rss", "text/javascript"
                };

        /// <summary>Gzip 壓縮等級。</summary>
        public int GzipCompLevel { get; set; } = 6;

        /// <summary>Gzip 壓縮的最小長度。</summary>
        public int GzipMinLength { get; set; } = 1024;

        /// <summary>代理請求是否進行 Gzip 壓縮。</summary>
        public string GzipProxied { get; set; } = "any";

        /// <summary>Gzip buffer 設置。</summary>
        public string GzipBuffers { get; set; } = "16 8k";

        /// <summary>是否啟用 Gzip vary。</summary>
        public bool GzipVary { get; set; } = true;

        /// <summary>Location 設定列表。</summary>
        public List<Location> Locations { get; set; } = new List<Location>
                {
                    new Location
                    {
                        Path = "~ ^/(api|swagger)",
                        ProxyPass = "http://127.0.0.1:4433",
                        ProxyHttpVersion = "1.1",
                        ProxySetHeaderConnection = "",
                        ProxySetHeaderUpgrade = "$http_upgrade",
                        ProxySetHeaderXForwardedHost = "$host",
                        ProxyCacheBypass = "$http_upgrade",
                        ProxyRedirect = "default",
                        ProxyBuffering = "off",
                        ProxyBuffers = "32 16k",
                        ProxyBufferSize = "64k",
                        ProxyConnectTimeout = "15s",
                        ProxySendTimeout = "15s",
                        ProxyReadTimeout = "30s",
                        ProxyMaxTempFileSize = "100M"
                    },
                    new Location
                    {
                        Path = "~ ^/",
                        ProxyPass = "https://127.0.0.1:450",
                        ProxyHttpVersion = "1.1",
                        ProxySetHeaderConnection = "",
                        ProxySetHeaderUpgrade = "$http_upgrade",
                        ProxySetHeaderXForwardedHost = "$host",
                        ProxyCacheBypass = "$http_upgrade",
                        ProxyRedirect = "default",
                        ProxyBuffering = "off",
                        ProxyBuffers = "32 16k",
                        ProxyBufferSize = "64k",
                        ProxyConnectTimeout = "15s",
                        ProxySendTimeout = "15s",
                        ProxyReadTimeout = "30s",
                        ProxyMaxTempFileSize = "100M"
                    }
                };

        /// <summary>
        /// 轉換 NGINX 參數為配置文件格式的字串。
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            if(UseHttp)
            {
                sb.AppendLine("server {");
                sb.AppendLine($"    listen {ListenPort};");
                sb.AppendLine($"    server_name {ServerName};");
            }
            else
            {
                sb.AppendLine("server {");
                sb.AppendLine($"    listen {ListenPort} {(Ssl ? "ssl" : "")} {(Http2 ? "http2" : "")};");
                sb.AppendLine($"    server_name {ServerName};");

                AppendIfNotEmpty(sb, "ssl_certificate", SslCertificate);
                AppendIfNotEmpty(sb, "ssl_certificate_key", SslCertificateKey);
                AppendIfNotEmpty(sb, "ssl_protocols", GetSslProtocols());
                AppendIfNotEmpty(sb, "ssl_ciphers", GetSslCiphersString());
                AppendIfNotEmpty(sb, "ssl_prefer_server_ciphers", SslPreferServerCiphers ? "on" : "off");
                AppendIfNotEmpty(sb, "ssl_session_cache", SslSessionCache);
                AppendIfNotEmpty(sb, "ssl_session_timeout", GetSslSessionTimeoutString());
                AppendIfNotEmpty(sb, "ssl_session_tickets", SslSessionTickets ? "on" : "off");
                AppendIfNotEmpty(sb, "ssl_buffer_size", GetSslBufferSizeString());
                AppendIfNotEmpty(sb, "ssl_stapling", SslStapling ? "on" : "off");
                AppendIfNotEmpty(sb, "ssl_stapling_verify", SslStaplingVerify ? "on" : "off");
            }
           

            AppendIfNotEmpty(sb, "resolver", string.Join(" ", DNS));
            AppendIfNotEmpty(sb, "resolver_timeout", DNSResolverTimeout);
            AppendIfNotEmpty(sb, "add_header Strict-Transport-Security", $"\"{StrictTransportSecurity}\" always");

            foreach (var header in ProxyHeaders)
            {
                AppendIfNotEmpty(sb, $"proxy_set_header {header.Key}", header.Value);
            }

            AppendIfNotEmpty(sb, "keepalive_timeout", KeepaliveTimeout);
            AppendIfNotEmpty(sb, "sendfile", Sendfile ? "on" : "off");
            AppendIfNotEmpty(sb, "tcp_nodelay", TcpNodelay ? "on" : "off");
            AppendIfNotEmpty(sb, "tcp_nopush", TcpNopush ? "on" : "off");
            AppendIfNotEmpty(sb, "fastcgi_keep_conn", FastcgiKeepConn ? "on" : "off");
            AppendIfNotEmpty(sb, "client_max_body_size", ClientMaxBodySize);
            AppendIfNotEmpty(sb, "client_body_timeout", ClientBodyTimeout);
            AppendIfNotEmpty(sb, "client_header_timeout", ClientHeaderTimeout);
            AppendIfNotEmpty(sb, "large_client_header_buffers", GetLargeClientHeaderBuffersString());
            AppendIfNotEmpty(sb, "gzip", Gzip ? "on" : "off");
            AppendIfNotEmpty(sb, "gzip_types", string.Join(" ", GzipTypes));
            AppendIfNotEmpty(sb, "gzip_comp_level", GzipCompLevel.ToString());
            AppendIfNotEmpty(sb, "gzip_min_length", GzipMinLength.ToString());
            AppendIfNotEmpty(sb, "gzip_proxied", GzipProxied);
            AppendIfNotEmpty(sb, "gzip_buffers", GzipBuffers);
            AppendIfNotEmpty(sb, "gzip_vary", GzipVary ? "on" : "off");

            foreach (var location in Locations)
            {
                sb.AppendLine(location.ToString());
            }

            sb.AppendLine("}");
            return sb.ToString();
        }
        /// <summary>
        /// 獲取 SSL 會話超時時間字串。
        /// </summary>
        private string GetSslSessionTimeoutString()
        {
            switch (SslSessionTimeout)
            {
                case SslSessionTimeoutEnum.Tiny:
                    return "10m";
                case SslSessionTimeoutEnum.Small:
                    return "1h";
                case SslSessionTimeoutEnum.Medium:
                    return "4h";
                case SslSessionTimeoutEnum.Large:
                    return "1d";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        /// <summary>
        /// 獲取 SSL buffer 大小字串。
        /// </summary>
        private string GetSslBufferSizeString()
        {
            switch (SslBufferSize)
            {
                case SslBufferSizeEnum.Tiny:
                    return "4k";
                case SslBufferSizeEnum.Small:
                    return "8k";
                case SslBufferSizeEnum.Medium:
                    return "16k";
                case SslBufferSizeEnum.Large:
                    return "32k";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        /// <summary>
        /// 獲取大請求標頭 buffer 設置字串。
        /// </summary>
        private string GetLargeClientHeaderBuffersString()
        {
            switch (LargeClientHeaderBuffers)
            {
                case LargeClientHeaderBuffersEnum.Small:
                    return "4 8k";
                case LargeClientHeaderBuffersEnum.Medium:
                    return "8 32k";
                case LargeClientHeaderBuffersEnum.Large:
                    return "8 64k";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        /// <summary>
        /// 獲取 SSL 加密套件字串。
        /// </summary>
        private string GetSslCiphersString()
        {
            switch (SslCiphers)
            {
                case SslCiphersEnum.EECDH_AESGCM_EECDH_CHACHA20_EDH_AESGCM:
                    return "EECDH+AESGCM:EECDH+CHACHA20:EDH+AESGCM";
                case SslCiphersEnum.EECDH_AES128GCM_SHA256_EECDH_CHACHA20:
                    return "EECDH+AES128GCM-SHA256:EECDH+CHACHA20";
                case SslCiphersEnum.TLS_AES_256_GCM_SHA384_EECDH_AESGCM:
                    return "TLS_AES_256_GCM_SHA384:EECDH+AESGCM";
                case SslCiphersEnum.DHE_RSA_AES256_SHA_DHE_RSA_AES128_SHA:
                    return "DHE-RSA-AES256-SHA:DHE-RSA-AES128-SHA";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        /// <summary>
        /// 如果值不是空白，則加入 NGINX 配置行。
        /// </summary>
        private void AppendIfNotEmpty(StringBuilder sb, string key, string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                sb.AppendLine($"        {key} {value};");
            }
        }

        /// <summary>
        /// 獲取 SSL 協議字串。
        /// </summary>
        private string GetSslProtocols()
        {
            var protocols = new List<string>();
            if (SslProtocolTls12) protocols.Add("TLSv1.2");
            if (SslProtocolTls13) protocols.Add("TLSv1.3");
            return string.Join(" ", protocols);
        }

        public static NginxParameters FromString(string config)
        {
            var parameters = new NginxParameters();
            parameters.Locations.Clear();
            var lines = config.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            Location currentLocation = null;

            foreach (var line in lines)
            {
                var trimmedLine = line.Trim();

                if (trimmedLine.StartsWith("listen"))
                {
                    parameters.ListenPort = int.Parse(trimmedLine.Split(' ')[1]);
                    parameters.Ssl = trimmedLine.Contains("ssl");
                    parameters.Http2 = trimmedLine.Contains("http2");
                }
                else if (trimmedLine.StartsWith("server_name"))
                {
                    parameters.ServerName = trimmedLine.Split(' ')[1].TrimEnd(';');
                }
                else if (trimmedLine.StartsWith("ssl_certificate "))
                {
                    parameters.SslCertificate = trimmedLine.Split(' ')[1].TrimEnd(';');
                }
                else if (trimmedLine.StartsWith("ssl_certificate_key"))
                {
                    parameters.SslCertificateKey = trimmedLine.Split(' ')[1].TrimEnd(';');
                }
                else if (trimmedLine.StartsWith("ssl_protocols"))
                {
                    var protocols = trimmedLine.Split(' ').Skip(1).Select(p => p.TrimEnd(';')).ToList();
                    parameters.SslProtocolTls12 = protocols.Contains("TLSv1.2");
                    parameters.SslProtocolTls13 = protocols.Contains("TLSv1.3");
                }
                else if (trimmedLine.StartsWith("ssl_ciphers"))
                {
                    var cipher = trimmedLine.Split(' ')[1].TrimEnd(';');
                    switch (cipher)
                    {
                        case "EECDH+AESGCM:EECDH+CHACHA20:EDH+AESGCM":
                            parameters.SslCiphers = SslCiphersEnum.EECDH_AESGCM_EECDH_CHACHA20_EDH_AESGCM;
                            break;
                        case "EECDH+AES128GCM-SHA256:EECDH+CHACHA20":
                            parameters.SslCiphers = SslCiphersEnum.EECDH_AES128GCM_SHA256_EECDH_CHACHA20;
                            break;
                        case "TLS_AES_256_GCM_SHA384:EECDH+AESGCM":
                            parameters.SslCiphers = SslCiphersEnum.TLS_AES_256_GCM_SHA384_EECDH_AESGCM;
                            break;
                        case "DHE-RSA-AES256-SHA:DHE-RSA-AES128-SHA":
                            parameters.SslCiphers = SslCiphersEnum.DHE_RSA_AES256_SHA_DHE_RSA_AES128_SHA;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
                else if (trimmedLine.StartsWith("ssl_prefer_server_ciphers"))
                {
                    parameters.SslPreferServerCiphers = trimmedLine.Split(' ')[1].TrimEnd(';') == "on";
                }
                else if (trimmedLine.StartsWith("ssl_session_cache"))
                {
                    parameters.SslSessionCache = trimmedLine.Split(' ')[1].TrimEnd(';');
                }
                else if (trimmedLine.StartsWith("ssl_session_timeout"))
                {
                    var timeout = trimmedLine.Split(' ')[1].TrimEnd(';');
                    switch (timeout)
                    {
                        case "10m":
                            parameters.SslSessionTimeout = SslSessionTimeoutEnum.Tiny;
                            break;
                        case "1h":
                            parameters.SslSessionTimeout = SslSessionTimeoutEnum.Small;
                            break;
                        case "4h":
                            parameters.SslSessionTimeout = SslSessionTimeoutEnum.Medium;
                            break;
                        case "1d":
                            parameters.SslSessionTimeout = SslSessionTimeoutEnum.Large;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
                else if (trimmedLine.StartsWith("ssl_session_tickets"))
                {
                    parameters.SslSessionTickets = trimmedLine.Split(' ')[1].TrimEnd(';') == "on";
                }
                else if (trimmedLine.StartsWith("ssl_buffer_size"))
                {
                    var bufferSize = trimmedLine.Split(' ')[1].TrimEnd(';');
                    switch (bufferSize)
                    {
                        case "4k":
                            parameters.SslBufferSize = SslBufferSizeEnum.Tiny;
                            break;
                        case "8k":
                            parameters.SslBufferSize = SslBufferSizeEnum.Small;
                            break;
                        case "16k":
                            parameters.SslBufferSize = SslBufferSizeEnum.Medium;
                            break;
                        case "32k":
                            parameters.SslBufferSize = SslBufferSizeEnum.Large;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
                else if (trimmedLine.StartsWith("ssl_stapling"))
                {
                    parameters.SslStapling = trimmedLine.Split(' ')[1].TrimEnd(';') == "on";
                }
                else if (trimmedLine.StartsWith("ssl_stapling_verify"))
                {
                    parameters.SslStaplingVerify = trimmedLine.Split(' ')[1].TrimEnd(';') == "on";
                }
                else if (trimmedLine.StartsWith("resolver "))
                {
                    List<string> strings = trimmedLine.Split(' ').Skip(1).Select(d => d.TrimEnd(';')).ToList();
                    strings = (from s in strings where s.Check_IP_Adress() select s).ToList();
                    parameters.DNS = strings;
                }
                else if (trimmedLine.StartsWith("resolver_timeout"))
                {
                    parameters.DNSResolverTimeout = trimmedLine.Split(' ')[1].TrimEnd(';');
                }
                else if (trimmedLine.StartsWith("add_header Strict-Transport-Security"))
                {
                    parameters.StrictTransportSecurity = trimmedLine.Split(' ')[2].Trim('"', ';');
                }
                else if (trimmedLine.StartsWith("proxy_set_header"))
                {
                    var parts = trimmedLine.Split(' ');
                    parameters.ProxyHeaders[parts[1]] = parts[2].TrimEnd(';');
                }
                else if (trimmedLine.StartsWith("keepalive_timeout"))
                {
                    parameters.KeepaliveTimeout = trimmedLine.Split(' ')[1].TrimEnd(';');
                }
                else if (trimmedLine.StartsWith("sendfile"))
                {
                    parameters.Sendfile = trimmedLine.Split(' ')[1].TrimEnd(';') == "on";
                }
                else if (trimmedLine.StartsWith("tcp_nodelay"))
                {
                    parameters.TcpNodelay = trimmedLine.Split(' ')[1].TrimEnd(';') == "on";
                }
                else if (trimmedLine.StartsWith("tcp_nopush"))
                {
                    parameters.TcpNopush = trimmedLine.Split(' ')[1].TrimEnd(';') == "on";
                }
                else if (trimmedLine.StartsWith("fastcgi_keep_conn"))
                {
                    parameters.FastcgiKeepConn = trimmedLine.Split(' ')[1].TrimEnd(';') == "on";
                }
                else if (trimmedLine.StartsWith("client_max_body_size"))
                {
                    parameters.ClientMaxBodySize = trimmedLine.Split(' ')[1].TrimEnd(';');
                }
                else if (trimmedLine.StartsWith("client_body_timeout"))
                {
                    parameters.ClientBodyTimeout = trimmedLine.Split(' ')[1].TrimEnd(';');
                }
                else if (trimmedLine.StartsWith("client_header_timeout"))
                {
                    parameters.ClientHeaderTimeout = trimmedLine.Split(' ')[1].TrimEnd(';');
                }
                else if (trimmedLine.StartsWith("large_client_header_buffers"))
                {
                    var bufferParts = trimmedLine.Split(' ');
                    switch (bufferParts[1])
                    {
                        case "4" when bufferParts[2] == "8k;":
                            parameters.LargeClientHeaderBuffers = LargeClientHeaderBuffersEnum.Small;
                            break;
                        case "8" when bufferParts[2] == "32k;":
                            parameters.LargeClientHeaderBuffers = LargeClientHeaderBuffersEnum.Medium;
                            break;
                        case "8" when bufferParts[2] == "64k;":
                            parameters.LargeClientHeaderBuffers = LargeClientHeaderBuffersEnum.Large;
                            break;
                        default:
                            parameters.LargeClientHeaderBuffers = LargeClientHeaderBuffersEnum.Medium;
                            break;
                    }
                }
                else if (trimmedLine.StartsWith("gzip "))
                {
                    parameters.Gzip = trimmedLine.Split(' ')[1].TrimEnd(';') == "on";
                }
                else if (trimmedLine.StartsWith("gzip_types"))
                {
                    parameters.GzipTypes = trimmedLine.Split(' ').Skip(1).Select(t => t.TrimEnd(';')).ToList();
                }
                else if (trimmedLine.StartsWith("gzip_comp_level"))
                {
                    parameters.GzipCompLevel = int.Parse(trimmedLine.Split(' ')[1].TrimEnd(';'));
                }
                else if (trimmedLine.StartsWith("gzip_min_length"))
                {
                    parameters.GzipMinLength = int.Parse(trimmedLine.Split(' ')[1].TrimEnd(';'));
                }
                else if (trimmedLine.StartsWith("gzip_proxied"))
                {
                    parameters.GzipProxied = trimmedLine.Split(' ')[1].TrimEnd(';');
                }
                else if (trimmedLine.StartsWith("gzip_buffers"))
                {
                    parameters.GzipBuffers = trimmedLine.Split(' ')[1] + " " + trimmedLine.Split(' ')[2].TrimEnd(';');
                }
                else if (trimmedLine.StartsWith("gzip_vary"))
                {
                    parameters.GzipVary = trimmedLine.Split(' ')[1].TrimEnd(';') == "on";
                }
                else if (trimmedLine.StartsWith("location "))
                {
                    if (currentLocation != null)
                    {
                        parameters.Locations.Add(currentLocation);
                    }
                    currentLocation = new Location();
                    currentLocation.Path = trimmedLine.Substring(trimmedLine.IndexOf(" ")).TrimEnd('{').Trim();
                }
                else if (currentLocation != null)
                {
                    if (trimmedLine.StartsWith("proxy_pass"))
                    {
                        currentLocation.ProxyPass = trimmedLine.Split(' ')[1].TrimEnd(';');
                    }
                    else if (trimmedLine.StartsWith("proxy_http_version"))
                    {
                        currentLocation.ProxyHttpVersion = trimmedLine.Split(' ')[1].TrimEnd(';');
                    }
                    else if (trimmedLine.StartsWith("proxy_set_header Connection"))
                    {
                        currentLocation.ProxySetHeaderConnection = trimmedLine.Split(' ')[2].TrimEnd(';');
                    }
                    else if (trimmedLine.StartsWith("proxy_set_header Upgrade"))
                    {
                        currentLocation.ProxySetHeaderUpgrade = trimmedLine.Split(' ')[2].TrimEnd(';');
                    }
                    else if (trimmedLine.StartsWith("proxy_set_header X-Forwarded-Host"))
                    {
                        currentLocation.ProxySetHeaderXForwardedHost = trimmedLine.Split(' ')[2].TrimEnd(';');
                    }
                    else if (trimmedLine.StartsWith("proxy_cache_bypass"))
                    {
                        currentLocation.ProxyCacheBypass = trimmedLine.Split(' ')[1].TrimEnd(';');
                    }
                    else if (trimmedLine.StartsWith("proxy_redirect"))
                    {
                        currentLocation.ProxyRedirect = trimmedLine.Split(' ')[1].TrimEnd(';');
                    }
                    else if (trimmedLine.StartsWith("proxy_buffering"))
                    {
                        currentLocation.ProxyBuffering = trimmedLine.Split(' ')[1].TrimEnd(';');
                    }
                    else if (trimmedLine.StartsWith("proxy_buffers"))
                    {
                        currentLocation.ProxyBuffers = trimmedLine.Split(' ')[1] + " " + trimmedLine.Split(' ')[2].TrimEnd(';');
                    }
                    else if (trimmedLine.StartsWith("proxy_buffer_size"))
                    {
                        currentLocation.ProxyBufferSize = trimmedLine.Split(' ')[1].TrimEnd(';');
                    }
                    else if (trimmedLine.StartsWith("proxy_connect_timeout"))
                    {
                        currentLocation.ProxyConnectTimeout = trimmedLine.Split(' ')[1].TrimEnd(';');
                    }
                    else if (trimmedLine.StartsWith("proxy_send_timeout"))
                    {
                        currentLocation.ProxySendTimeout = trimmedLine.Split(' ')[1].TrimEnd(';');
                    }
                    else if (trimmedLine.StartsWith("proxy_read_timeout"))
                    {
                        currentLocation.ProxyReadTimeout = trimmedLine.Split(' ')[1].TrimEnd(';');
                    }
                    else if (trimmedLine.StartsWith("proxy_max_temp_file_size"))
                    {
                        currentLocation.ProxyMaxTempFileSize = trimmedLine.Split(' ')[1].TrimEnd(';');
                    }                
                    else if (trimmedLine.StartsWith("}"))
                    {
                        parameters.Locations.Add(currentLocation);
                        currentLocation = null;
                    }
                }
            }

            if (currentLocation != null)
            {
                parameters.Locations.Add(currentLocation);
            }

            return parameters;
        }
        /// <summary>
        /// 根據 GUID 移除 Location。
        /// </summary>
        /// <param name="guid">要移除的 Location 的 GUID。</param>
        public void RemoveLocationsByGUID(string guid)
        {
            Locations.RemoveAll(location => location.GUID == guid);
        }



    }

    /// <summary>
    /// 表示 NGINX 配置中的一個 `location` 設置。
    /// </summary>
    public class Location
    {
        public string GUID { get; set; } = Guid.NewGuid().ToString();
        /// <summary>路徑匹配規則（如 `/api` 或 `~ ^/(api|swagger)`）。</summary>
        public string Path { get; set; } = "~ ^/";

        /// <summary>代理轉發的目標地址（如 `http://127.0.0.1:4433`）。</summary>
        public string ProxyPass { get; set; } = "https://";

        /// <summary>代理的 HTTP 版本（如 `1.1`）。</summary>
        public string ProxyHttpVersion { get; set; } = "1.1";

        /// <summary>代理連接設置（如 `""` 代表不設置）。</summary>
        public string ProxySetHeaderConnection { get; set; }

        /// <summary>代理升級設置（如 `$http_upgrade`）。</summary>
        public string ProxySetHeaderUpgrade { get; set; } = "$http_upgrade";

        /// <summary>代理 X-Forwarded-Host 設置（如 `$host`）。</summary>
        public string ProxySetHeaderXForwardedHost { get; set; } = "$host";

        /// <summary>代理快取繞過設置（如 `$http_upgrade`）。</summary>
        public string ProxyCacheBypass { get; set; } = "$http_upgrade";

        /// <summary>代理重定向設置（如 `off`）。</summary>
        public string ProxyRedirect { get; set; } = "default";

        /// <summary>是否啟用代理緩衝（`on`/`off`）。</summary>
        public string ProxyBuffering { get; set; } = "off";

        /// <summary>代理緩衝設置（如 `32 16k`）。</summary>
        public string ProxyBuffers { get; set; } = "32 16k";

        /// <summary>代理緩衝大小（如 `64k`）。</summary>
        public string ProxyBufferSize { get; set; } = "64k";

        /// <summary>代理連接超時（如 `15s`）。</summary>
        public string ProxyConnectTimeout { get; set; } = "15s";

        /// <summary>代理傳送超時（如 `15s`）。</summary>
        public string ProxySendTimeout { get; set; } = "15s";

        /// <summary>代理讀取超時（如 `30s`）。</summary>
        public string ProxyReadTimeout { get; set; } = "30s";

        public string ProxyMaxTempFileSize { get; set; } = "100M";
        /// <summary>
        /// 轉換為 NGINX 配置格式的字串，並排除空值。
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"    location {Path} {{");

            AppendIfNotEmpty(sb, "proxy_pass", ProxyPass);
            AppendIfNotEmpty(sb, "proxy_http_version", ProxyHttpVersion);
            AppendIfNotEmpty(sb, "proxy_set_header Connection", ProxySetHeaderConnection);
            AppendIfNotEmpty(sb, "proxy_set_header Upgrade", ProxySetHeaderUpgrade);
            AppendIfNotEmpty(sb, "proxy_set_header X-Forwarded-Host", ProxySetHeaderXForwardedHost);
            AppendIfNotEmpty(sb, "proxy_cache_bypass", ProxyCacheBypass);
            AppendIfNotEmpty(sb, "proxy_redirect", ProxyRedirect);

            sb.AppendLine($"        proxy_buffering {ProxyBuffering};");

            AppendIfNotEmpty(sb, "proxy_buffers", ProxyBuffers);
            AppendIfNotEmpty(sb, "proxy_buffer_size", ProxyBufferSize);
            AppendIfNotEmpty(sb, "proxy_connect_timeout", ProxyConnectTimeout);
            AppendIfNotEmpty(sb, "proxy_send_timeout", ProxySendTimeout);
            AppendIfNotEmpty(sb, "proxy_read_timeout", ProxyReadTimeout);
            AppendIfNotEmpty(sb, "proxy_max_temp_file_size", ProxyMaxTempFileSize);

            sb.AppendLine("    }");
            return sb.ToString();
        }

        /// <summary>
        /// 如果值不是空白，則加入 NGINX 配置行。
        /// </summary>
        private void AppendIfNotEmpty(StringBuilder sb, string key, string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                sb.AppendLine($"        {key} {value};");
            }
        }

        
    }
    [EnumDescription("LocationAttributes")]
    public enum LocationAttributes
    {
        [Description("GUID,VARCHAR,255,INDEX")]
        GUID,
        [Description("Path,VARCHAR,255,INDEX")]
        Path,
        [Description("ProxyPass,VARCHAR,255,NONE")]
        ProxyPass,
        [Description("ProxyHttpVersion,VARCHAR,10,NONE")]
        ProxyHttpVersion,
        [Description("ProxySetHeaderConnection,VARCHAR,255,NONE")]
        ProxySetHeaderConnection,
        [Description("ProxySetHeaderUpgrade,VARCHAR,255,NONE")]
        ProxySetHeaderUpgrade,
        [Description("ProxySetHeaderXForwardedHost,VARCHAR,255,NONE")]
        ProxySetHeaderXForwardedHost,
        [Description("ProxyCacheBypass,VARCHAR,255,NONE")]
        ProxyCacheBypass,
        [Description("ProxyRedirect,VARCHAR,255,NONE")]
        ProxyRedirect,
        [Description("ProxyBuffering,VARCHAR,255,NONE")]
        ProxyBuffering,
        [Description("ProxyBuffers,VARCHAR,255,NONE")]
        ProxyBuffers,
        [Description("ProxyBufferSize,VARCHAR,255,NONE")]
        ProxyBufferSize,
        [Description("ProxyConnectTimeout,VARCHAR,255,NONE")]
        ProxyConnectTimeout,
        [Description("ProxySendTimeout,VARCHAR,255,NONE")]
        ProxySendTimeout,
        [Description("ProxyReadTimeout,VARCHAR,255,NONE")]
        ProxyReadTimeout,
        [Description("ProxyMaxTempFileSize,VARCHAR,255,NONE")]
        ProxyMaxTempFileSize
    }



}
