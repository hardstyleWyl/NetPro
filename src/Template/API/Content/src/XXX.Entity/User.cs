﻿namespace XXX.Entity
{
    [JsonObject(MemberSerialization.OptIn), Table(Name = "_user")]
    public class User
    {
        //[JsonProperty, Column(Name = "unionid", DbType = "bigint", IsPrimary = true, IsIdentity = true)]
        [Column(IsIdentity = true, IsPrimary = true)]
        public int Id { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Pwd { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public uint Age { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public long CreateTime { get; set; }
    }
}