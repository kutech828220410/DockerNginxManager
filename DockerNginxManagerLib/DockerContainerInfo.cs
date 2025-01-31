using Basic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DockerManagerLib
{
    /// <summary>
    /// 表示 Docker 容器的資訊。
    /// </summary>
    public class DockerContainerInfo
    {
        [EnumDescription("DockerContainerAttributes")]
        public enum DockerContainerAttributes
        {
            [Description("Name,VARCHAR,100,NONE")]
            Name,
            [Description("ContainerId,VARCHAR,64,INDEX")]
            ContainerId,
            [Description("Image,VARCHAR,100,NONE")]
            Image,
            [Description("Ports,VARCHAR,50,NONE")]
            Ports,
            [Description("Status,VARCHAR,50,NONE")]
            Status,
        }
        /// <summary>
        /// 獲取或設置 Docker 容器的 ID。
        /// </summary>
        public string ContainerId { get; set; }

        /// <summary>
        /// 獲取或設置 Docker 容器的名稱。
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 獲取或設置 Docker 容器的映像。
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// 獲取或設置 Docker 容器的狀態。
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 獲取或設置 Docker 容器的埠。
        /// </summary>
        public string Ports { get; set; }
    }
}
