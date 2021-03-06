﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NHN.DtoContracts.Common.en
{
    /// <summary>
    /// En tidsperiode.
    /// </summary>
    [DataContract(Namespace = CommonXmlNamespaces.XmlNsCommonEnglish)]
    [Serializable]
    public class Period
    {
        /// <summary>
        /// From
        /// </summary>
        [DataMember]
        public DateTime From { get; set; }

        /// <summary>
        /// To. Can be null if no expire time
        /// </summary>
        [DataMember]
        public DateTime? To { get; set; }

        /// <summary>
        /// Oppretter et ny Period objekt
        /// </summary>
        public Period()
        {
            From = DateTime.Now;
            To = null;
        }

        /// <summary>
        /// Oppretter et ny Period objekt med fra/til satt til spesifiserte verdier.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public Period(DateTime from, DateTime? to = null)
        {
            From = from;
            To = to;
        }

        /// <summary>
        /// Oppretter et nytt Period objekt med fra/Til satt til spesifiserte verdier.
        /// </summary>
        public Period(int fromYear, int fromMonth, int fromDay, int toYear = 0, int toMonth = 0, int toDay = 0)
        {
            From = new DateTime(fromYear, fromMonth, fromDay);
            if (toYear > 0)
                To = new DateTime(toYear, toMonth, toDay);
        }

        /// <summary>
        /// Hvorvidt nåtid er mellom From og To
        /// </summary>
        public bool IsActiveNow
        {
            get { return Overlaps(DateTime.Now); }
        }

        /// <summary>
        /// Gir Periode objektet mening? Sjekker at T > From.
        /// </summary>
        public bool Sane
        {
            get
            {
                if (From > new DateTime(9000, 1, 1))
                    return false;
                if (To != null)
                    return To.Value > From;
                return true;
            }
        }

        /// <summary>
        /// Sjekker om to perioder overlapper hverandre.
        /// </summary>
        /// <param name="other"></param>
        /// <returns>true hvis periodene overlapper, false ellers.</returns>
        public bool Overlaps(Period other)
        {
            if (object.ReferenceEquals(this, other))
                throw new InvalidOperationException("Period overlaps self, should not be tested..");

            if (this.From == other.From || this.To == other.To)
                return true;

            if (this.From > other.From)
                return other.To == null || other.To > this.From;
            else
                return this.To == null || other.From < this.To.Value;
        }

        /// <summary>
        /// Sjekker om et tidspunkt er innenfor en Periode
        /// </summary>
        /// <param name="pointInTime"></param>
        /// <returns></returns>
        public bool Overlaps(DateTime pointInTime)
        {
            if (this.From > pointInTime)
                return false;
            return (this.To == null || this.To.Value > pointInTime);
        }

        /// <summary>
        /// Sjekker om periodene er like
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            var po = obj as Period;
            if (po == null)
                return false;
            return To == po.To && From == po.From;
        }

        /// <summary>
        /// Hash code
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return From.GetHashCode() + (To ?? default(DateTime)).GetHashCode();
        }

        /// <summary>
        /// For en grei stringrepresentasjon av Periode for debugging.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Period: {From.ToShortDateString()}, To: {To?.ToShortDateString() ?? " (null)"}";
        }
    }
}