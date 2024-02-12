using System.ComponentModel.DataAnnotations.Schema;

namespace ValorantWebsite.Models
{
    public class Weapon
    {
        public int WeaponID { get; set; }
        public string WeaponName { get; set; } = string.Empty;
        public string WeaponType { get; set; } = string.Empty;
        private int? _creditCost;
        public int? CreditCost 
        { 
            get => _creditCost; 
            set => _creditCost = value;
        }
        public string WeaponImage { get; set; } = string.Empty;
        public string? FireMode { get; set; }
        public double? FireRatePerSec { get; set; }
        public double RunSpeedPerSec { get; set; }
        public double? ReloadSpeedPerSec { get; set; }
        public int? MagazineSize { get; set; } = 0;
        public int? ReserveSize { get; set; } = 0;
        public int Damage { get; set; } = 0;
        public string? DisplayCreditCost => _creditCost == 0 ? "Free" : _creditCost?.ToString();
    }
}
