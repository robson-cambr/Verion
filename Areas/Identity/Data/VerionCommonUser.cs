using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Verion.Areas.Identity.Data;

// Add profile data for application users by adding properties to the VerionCommonUser class
public class VerionCommonUser : IdentityUser
{
        [PersonalData]
        [Column(TypeName = "nvarchar(256)")]
        public string FirstName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(256)")]
        public string LastName { get; set; }
}

