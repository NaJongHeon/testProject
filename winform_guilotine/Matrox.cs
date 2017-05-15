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

        public void Initialize()
        {
            MIL_ID MilApplication = MIL.M_NULL;     // Application identifier.
            MIL_ID MilSystem = MIL.M_NULL;          // System identifier.
            MIL_ID MilDisplay = MIL.M_NULL;         // Display identifier.
            MIL_ID MilImage = MIL.M_NULL;           // Image buffer identifier.

            // Allocate a default MIL application, system, display and image.
            MIL.MappAllocDefault(MIL.M_DEFAULT, ref MilApplication, ref MilSystem, ref MilDisplay, MIL.M_NULL, ref MilImage);

            // If no allocation errors.
            if (MIL.MappGetError(MIL.M_DEFAULT, MIL.M_GLOBAL, MIL.M_NULL) == 0)
            {
                // Perform graphic operations in the display image.
                MIL.MgraColor(MIL.M_DEFAULT, 0xF0);
                MIL.MgraFont(MIL.M_DEFAULT, MIL.M_FONT_DEFAULT_LARGE);
                MIL.MgraText(MIL.M_DEFAULT, MilImage, 160L, 230L, " Welcome to MIL !!! ");
                MIL.MgraColor(MIL.M_DEFAULT, 0xC0);
                MIL.MgraRect(MIL.M_DEFAULT, MilImage, 100, 150, 530, 340);
                MIL.MgraRect(MIL.M_DEFAULT, MilImage, 120, 170, 510, 320);
                MIL.MgraRect(MIL.M_DEFAULT, MilImage, 140, 190, 490, 300);
            }

        }
        public void snap()
        {

        }

        public void save()
        {

        }
    }
}
