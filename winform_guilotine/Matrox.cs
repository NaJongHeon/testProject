using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matrox.MatroxImagingLibrary;




namespace winform_guilotine
{
    
    public class Matrox
    {
        

        // Member variables
        public static MIL_ID MilApplication = MIL.M_NULL;       // Application identifier.
        public static MIL_ID MilSystem = MIL.M_NULL;       // System identifier.     
        public static MIL_ID MilDisplay = MIL.M_NULL;       // Display identifier.    
        public static MIL_ID MilDigitizer = MIL.M_NULL;       // Digitizer identifier.  
        public static MIL_ID MilImage = MIL.M_NULL;       // Image identifier.
        public static MIL_ID MilRecord = MIL.M_NULL;       // 8 bit Pointer only for Video Recording.
        public MIL_INT MilINT = MIL.M_NULL;
        public MIL_INT NbPixelsPtr = MIL.M_NULL;
        MIL_ID MilImageDisp = MIL.M_NULL;
        MIL_ID[] MilGrabBufferList = new MIL_ID[1024];
        public void Initialize()
        {
            string MilSystemDet = "";
            MilSystemDet = Environment.GetEnvironmentVariable("Mil_Path");
            if (MilSystemDet != null)
            {
                string dcfFilePath = "";

                MIL.MdigAlloc(MilSystem, MIL.M_DEFAULT, dcfFilePath, MIL.M_DEFAULT, ref MilDigitizer);
                MIL.MbufAlloc2d(MilSystem, MIL.MdigInquire(MilDigitizer, MIL.M_SIZE_X, MIL.M_NULL),
                MIL.MdigInquire(MilDigitizer, MIL.M_SIZE_Y, MIL.M_NULL), 8 + MIL.M_UNSIGNED, MIL.M_IMAGE + MIL.M_DISP + MIL.M_GRAB, ref MilImage);
                MIL.MdispAlloc(MilSystem, MIL.M_DEFAULT, ("M_DEFAULT"), MIL.M_DEFAULT, ref MilDisplay);
                MIL.MdigHalt(MilDigitizer);
            }
        }
        public void snap()
        {
            MIL.MbufClear(MilImage, 0);
            MIL.MdigGrabContinuous(MilDigitizer, MilImage);
            MIL.MdispControl(MilDisplay, MIL.M_VIEW_MODE, MIL.M_AUTO_SCALE);
            MIL.MdispControl(MilDisplay, MIL.M_SCALE_DISPLAY, MIL.M_ENABLE);
        }

        public void save()
        {
            MIL.MbufSave("D:\test", MilImage);
        }
    }
}
