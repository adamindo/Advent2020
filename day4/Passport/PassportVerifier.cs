using System;
using System.Collections.Generic;
using System.Linq;

namespace Passport{
    internal class PassportVerifier{

        private List<Passport> passports;
        internal PassportVerifier(List<Passport> passports){
            this.passports = passports;
        }

        internal int CountValidPassports()
        {
            return passports.Count(pass => pass.IsValid());
        }

    }
}