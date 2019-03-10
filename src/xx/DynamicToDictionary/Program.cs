using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace DynamicToDictionary {
    static class DynamicExtensions {
        public static IDictionary<string, Object> ToDictionary(this object obj) {
            var dict = TypeDescriptor
                .GetProperties(obj.GetType())
                .OfType<PropertyDescriptor>()
                .ToDictionary(p => p.Name, p => p.GetValue(obj));
            return dict;
        }

    }
    class Program {
        static void Main(string[] args) {
            var a = new {
                A = 100,
                B = 200,
                C = 300
            };

            var dict = a.ToDictionary();
            foreach (var item in dict) {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }
    }
}
