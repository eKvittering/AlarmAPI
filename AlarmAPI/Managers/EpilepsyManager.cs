using AlarmAPI.Models;

namespace AlarmAPI.Managers
{
    public class EpilepsyManager
    {
        private static int _nextId = 1;

        private static readonly List<EpilepsyAlarm> EpilepsyAlarms = new List<EpilepsyAlarm>
        {
            new EpilepsyAlarm(product: "Alert IT Epi Mini", code: "003-132", serialNumber: "246801", receiveEmployee: "Sune Leisner", receiveDate: "24-08-2023", customer: "Shiva Leisner", saleId: 647, deviceId: 2992, isAvalible: false, isMedicalDevice: true),
            new EpilepsyAlarm(product: "Alert IT Epi Mini", code: "003-132", serialNumber: "246802", receiveEmployee: "Michael Beck", receiveDate: "11-02-2015", customer: "Dorthe Hansen", saleId: 648, deviceId: 2997, isAvalible: true, isMedicalDevice: false),
            new EpilepsyAlarm(product: "Alert IT Epi Mini", code: "003-132", serialNumber: "246803", receiveEmployee: "Oscar Almasen", receiveDate: "11-02-2015", customer: "Frellsen Kaffe", saleId: 649, deviceId: 9001, isAvalible: true, isMedicalDevice: true)
        };

        public List<EpilepsyAlarm> GetAll()
        {
            List<EpilepsyAlarm> epilepsyAlarms = new List<EpilepsyAlarm>(EpilepsyAlarms);
            return epilepsyAlarms;
        } 
    }
}
