using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPlayground.Processing
{
    public class MessageProcessor
    {

        #region Handle EquipmentActivity
        //
        //  If message Body contains "ActivityId":
        //      Check if BookingNumber Exists on Storage
        //      Y: Publish EquipmentActivity
        //      N: Store EquipmentActivity
        //
        #endregion


        #region Handle Booking
        //
        //  If message Body contains "BookingNumber":
        //      Check if booking Exists on Storage:
        //  Y: Ignore
        //  N: Store BookingNumber
        //
        #endregion
    }
}
