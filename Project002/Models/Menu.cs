using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Project002.Models
{
    public class Menu
    {
        [DisplayName("メニューID")]
        public int MenuId { get; set; }

        [DisplayName("メニュー項目")]
        public string MenuName { get; set; }
    }
}
