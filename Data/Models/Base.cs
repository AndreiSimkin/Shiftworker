using Newtonsoft.Json;
using Samokat.Data.Interfaces;
using Samokat.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Text.Json.Serialization;
using System.Windows.Input;

namespace Samokat.Data.Models
{
    public class Base : IBase
    {
        [Newtonsoft.Json.JsonIgnore]
        public string Path { get; private set; }

        public ObservableCollection<Models.ShiftPreset> ShiftPresets { get; protected set; }
        public ObservableCollection<Models.Courier> Couriers { get; protected set; }
        public ObservableCollection<Models.Month> Months { get; protected set; }
        
        public Models.Month GetMonthByDate(int month, int year)
        {
            foreach (Models.Month m in Months)
                if (m.Date.Year == year && m.Date.Month == month)
                    return m;
            return null;
        }

        public Base(string path)
        {
            if (File.Exists(path))
                Load(path);
            else
                CreateNew(path);
            Path = path;
        }

        public void AcceptСhanges()
        {
            File.WriteAllText(Path, JsonConvert.SerializeObject(this, Formatting.Indented));
        }

        void CreateNew(string path)
        {
            Couriers = new ObservableCollection<Models.Courier>();
            Months = new ObservableCollection<Models.Month>();
            ShiftPresets = new ObservableCollection<ShiftPreset>();
            Directory.CreateDirectory("Data");
        }

        void Load(string path)
        {
            var @base = JsonConvert.DeserializeObject<Base>(File.ReadAllText(path));
            Couriers = @base.Couriers;
            Months = @base.Months;
            ShiftPresets = @base.ShiftPresets;
        }
    }
}
