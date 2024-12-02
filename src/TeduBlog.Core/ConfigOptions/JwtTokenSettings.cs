namespace TeduBlog.Core.ConfigOptions
{
    public class JwtTokenSettings
    {
        public string Key { get; set; } // => để mã hóa
        public string Issuer { get; set; } // => đơn vị mã hóa là ai
        public int ExpireInHours { get; set; } // hết hạn sau bao lâu
    }
}
