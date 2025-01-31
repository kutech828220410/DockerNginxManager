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

    /// <summary>
    /// 表示 NGINX 伺服器的配置參數。
    /// </summary>
    public class NginxParameters
    {
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
        public string SslCiphers { get; set; } = "EECDH+AESGCM:EECDH+CHACHA20:EDH+AESGCM";

        /// <summary>是否優先使用伺服器端的加密套件。</summary>
        public bool SslPreferServerCiphers { get; set; } = true;

        /// <summary>SSL 會話快取設置。</summary>
        public string SslSessionCache { get; set; } = "shared:SSL:200m";

        /// <summary>SSL 會話超時時間。</summary>
        public string SslSessionTimeout { get; set; } = "4h";

        /// <summary>是否啟用 SSL 會話票據。</summary>
        public bool SslSessionTickets { get; set; } = true;

        /// <summary>SSL buffer 大小。</summary>
        public string SslBufferSize { get; set; } = "16k";

        /// <summary>是否啟用 OCSP Stapling。</summary>
        public bool SslStapling { get; set; } = true;

        /// <summary>是否驗證 OCSP Stapling。</summary>
        public bool SslStaplingVerify { get; set; } = true;

        /// <summary>DNS 解析器地址列表。</summary>
        public List<string> Resolver { get; set; } = new List<string> { "8.8.8.8", "1.1.1.1" };

        /// <summary>DNS 解析超時時間。</summary>
        public string ResolverTimeout { get; set; } = "5s";

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
        public string LargeClientHeaderBuffers { get; set; } = "4 32k";

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
                        ProxyRedirect = "off",
                        ProxyBuffering = false,
                        ProxyBuffers = "32 16k",
                        ProxyBufferSize = "64k",
                        ProxyConnectTimeout = "15s",
                        ProxySendTimeout = "15s",
                        ProxyReadTimeout = "30s"
                    },
                    new Location
                    {
                        Path = "/",
                        ProxyPass = "https://127.0.0.1:450",
                        ProxyHttpVersion = "1.1",
                        ProxySetHeaderConnection = "",
                        ProxySetHeaderUpgrade = "$http_upgrade",
                        ProxySetHeaderXForwardedHost = "$host",
                        ProxyCacheBypass = "$http_upgrade",
                        ProxyRedirect = "off",
                        ProxyBuffering = false,
                        ProxyBuffers = "32 16k",
                        ProxyBufferSize = "64k",
                        ProxyConnectTimeout = "15s",
                        ProxySendTimeout = "15s",
                        ProxyReadTimeout = "30s"
                    }
                };

        /// <summary>
        /// 轉換 NGINX 參數為配置文件格式的字串。
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("server {");
            sb.AppendLine($"    listen {ListenPort} {(Ssl ? "ssl" : "")} {(Http2 ? "http2" : "")};");
            sb.AppendLine($"    server_name {ServerName};");

            AppendIfNotEmpty(sb, "ssl_certificate", SslCertificate);
            AppendIfNotEmpty(sb, "ssl_certificate_key", SslCertificateKey);
            AppendIfNotEmpty(sb, "ssl_protocols", GetSslProtocols());
            AppendIfNotEmpty(sb, "ssl_ciphers", SslCiphers);
            AppendIfNotEmpty(sb, "ssl_prefer_server_ciphers", SslPreferServerCiphers ? "on" : "off");
            AppendIfNotEmpty(sb, "ssl_session_cache", SslSessionCache);
            AppendIfNotEmpty(sb, "ssl_session_timeout", SslSessionTimeout);
            AppendIfNotEmpty(sb, "ssl_session_tickets", SslSessionTickets ? "on" : "off");
            AppendIfNotEmpty(sb, "ssl_buffer_size", SslBufferSize);
            AppendIfNotEmpty(sb, "ssl_stapling", SslStapling ? "on" : "off");
            AppendIfNotEmpty(sb, "ssl_stapling_verify", SslStaplingVerify ? "on" : "off");
            AppendIfNotEmpty(sb, "resolver", string.Join(" ", Resolver));
            AppendIfNotEmpty(sb, "resolver_timeout", ResolverTimeout);
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
            AppendIfNotEmpty(sb, "large_client_header_buffers", LargeClientHeaderBuffers);
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
    }

    /// <summary>
    /// 表示 NGINX 配置中的一個 `location` 設置。
    /// </summary>
    public class Location
    {
        /// <summary>路徑匹配規則（如 `/api` 或 `~ ^/(api|swagger)`）。</summary>
        public string Path { get; set; }

        /// <summary>代理轉發的目標地址（如 `http://127.0.0.1:4433`）。</summary>
        public string ProxyPass { get; set; }

        /// <summary>代理的 HTTP 版本（如 `1.1`）。</summary>
        public string ProxyHttpVersion { get; set; } = "1.1";

        /// <summary>代理連接設置（如 `""` 代表不設置）。</summary>
        public string ProxySetHeaderConnection { get; set; }

        /// <summary>代理升級設置（如 `$http_upgrade`）。</summary>
        public string ProxySetHeaderUpgrade { get; set; }

        /// <summary>代理 X-Forwarded-Host 設置（如 `$host`）。</summary>
        public string ProxySetHeaderXForwardedHost { get; set; }

        /// <summary>代理快取繞過設置（如 `$http_upgrade`）。</summary>
        public string ProxyCacheBypass { get; set; }

        /// <summary>代理重定向設置（如 `off`）。</summary>
        public string ProxyRedirect { get; set; }

        /// <summary>是否啟用代理緩衝（`true`/`false`）。</summary>
        public bool ProxyBuffering { get; set; } = false;

        /// <summary>代理緩衝設置（如 `32 16k`）。</summary>
        public string ProxyBuffers { get; set; }

        /// <summary>代理緩衝大小（如 `64k`）。</summary>
        public string ProxyBufferSize { get; set; }

        /// <summary>代理連接超時（如 `15s`）。</summary>
        public string ProxyConnectTimeout { get; set; }

        /// <summary>代理傳送超時（如 `15s`）。</summary>
        public string ProxySendTimeout { get; set; }

        /// <summary>代理讀取超時（如 `30s`）。</summary>
        public string ProxyReadTimeout { get; set; }

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

            sb.AppendLine($"        proxy_buffering {(ProxyBuffering ? "on" : "off")};");

            AppendIfNotEmpty(sb, "proxy_buffers", ProxyBuffers);
            AppendIfNotEmpty(sb, "proxy_buffer_size", ProxyBufferSize);
            AppendIfNotEmpty(sb, "proxy_connect_timeout", ProxyConnectTimeout);
            AppendIfNotEmpty(sb, "proxy_send_timeout", ProxySendTimeout);
            AppendIfNotEmpty(sb, "proxy_read_timeout", ProxyReadTimeout);

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



}
