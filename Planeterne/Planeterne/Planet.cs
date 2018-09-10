using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeterne
{
    class Planet
    {
        //Her oprettes private properties. Der laves med private access så de kun kan tilgås fra classen.
        private string planetName;
        private double mass;
        private double diameter;       
        private int density;
        private double gravity;
        private double rotatePeriod;
        private double lengthDay;
        private double distenceSun;
        private double orbitalPeriod;
        private double orbitalVelocity;
        private int meanTemp;
        private byte numberOfMoons;
        private bool ringSystem;

        //Her gives de private properties en accessor method
        public string PlanetName
        {
            get
            {
                return this.planetName;
            }
            set
            {
                this.planetName = value;
            }
        }
        public double Mass
        {
            get
            {
                return this.mass;
            }
            set
            {
                this.mass = value;
            }
        }
        public double Diameter
        {
            get
            {
                return this.diameter;
            }
            set
            {
                this.diameter = value;
            }
        }
        public int Density
        {
            get
            {
                return this.density;
            }
            set
            {
                this.density = value;
            }
        }
        public double Gravity
        {
            get
            {
                return this.gravity;
            }
            set
            {
                this.gravity = value;
            }
        }
        public double RotatePeriod
        {
            get
            {
                return this.rotatePeriod;
            }
            set
            {
                this.rotatePeriod = value;
            }
        }
        public double LengthDay
        {
            get
            {
                return this.lengthDay;
            }
            set
            {
                this.lengthDay = value;
            }
        }
        public double DistenceSun
        {
            get
            {
                return this.distenceSun;
            }
            set
            {
                this.distenceSun = value;
            }
        }
        public double OrbitalPeriod
        {
            get
            {
                return this.orbitalPeriod;
            }
            set
            {
                this.orbitalPeriod = value;
            }
        }
        public double OrbitalVelocity
        {
            get
            {
                return this.orbitalVelocity;
            }
            set
            {
                this.orbitalVelocity = value;
            }
        }
        public int MeanTemp
        {
            get
            {
                return this.meanTemp;
            }
            set
            {
                this.meanTemp = value;
            }
        }
        public byte NumberOfMoons
        {
            get
            {
                return this.numberOfMoons;
            }
            set
            {
                this.numberOfMoons = value;
            }
        }
        public bool RingSystem
        {
            get
            {
                return this.ringSystem;
            }
            set
            {
                this.ringSystem = value;
            }
        }

        public Planet(string PlanetNameCon,  double MassCon, double DiameterCon, int DensityCon, double GravityCon, double RotatePeriodCon, double LengthDayCon, double DistenceSunCon, double OrbitalPeriodCon, double OrbitalVelocityCon, int MeanTempCon, byte NumberOfMoonsCon, bool RingSystemCon)
        {
            this.planetName = PlanetNameCon;
            this.mass = MassCon;
            this.diameter = DiameterCon;
            this.density = DensityCon;
            this.gravity = GravityCon;
            this.rotatePeriod = RotatePeriodCon;
            this.lengthDay = LengthDayCon;
            this.distenceSun = DistenceSunCon;
            this.orbitalPeriod = OrbitalPeriodCon;
            this.orbitalVelocity = OrbitalVelocityCon;
            this.meanTemp = MeanTempCon;
            this.numberOfMoons = NumberOfMoonsCon;
            this.ringSystem = RingSystemCon;
           
        }




    }
}
