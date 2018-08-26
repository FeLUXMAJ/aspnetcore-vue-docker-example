using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IdentityApi.Models
{
    public class SuccessRes
    {

        // [Display(Name = "code")]
        public byte Code { get; set; } = 0;

        // [Display(Name = "msg")]
        public string Msg { get; set; } = "request:success";

        // [Display(Name = "tag")]
        public object Tag { get; set; }

        public SuccessRes(string msg, object tag)
        {
            Msg = msg;
            Tag = tag;
        }

        public SuccessRes(object tag)
        {
            Tag = tag;
        }
    }
}
