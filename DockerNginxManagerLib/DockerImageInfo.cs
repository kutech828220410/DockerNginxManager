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
    /// 表示 Docker 映像的資訊。
    /// </summary>
    public class DockerImageInfo
    {
        /// <summary>
        /// 表示 Docker 映像的屬性。
        /// </summary>
        [EnumDescription("DockerImageAttributes")]
        public enum DockerImageAttributes
        {
            [Description("GUID,VARCHAR,100,INDEX")]
            GUID,
            [Description("Repository,VARCHAR,100,INDEX")]
            Repository,
            [Description("Tag,VARCHAR,50,NONE")]
            Tag,
            [Description("ImageId,VARCHAR,64,NONE")]
            ImageId,
            [Description("Created,VARCHAR,50,NONE")]
            Created,
            [Description("Size,VARCHAR,20,NONE")]
            Size,
        }
        /// <summary>
        /// 獲取或設置 Docker 映像的儲存庫名稱。
        /// </summary>
        public string GUID { get; set; }
        /// <summary>
        /// 獲取或設置 Docker 映像的儲存庫名稱。
        /// </summary>
        public string Repository { get; set; }

        /// <summary>
        /// 獲取或設置 Docker 映像的標籤。
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// 獲取或設置 Docker 映像的 ID。
        /// </summary>
        public string ImageId { get; set; }

        /// <summary>
        /// 獲取或設置 Docker 映像的建立時間。
        /// </summary>
        public string Created { get; set; }

        /// <summary>
        /// 獲取或設置 Docker 映像的大小。
        /// </summary>
        public string Size { get; set; }

    }
}
