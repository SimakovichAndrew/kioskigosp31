using kioskigospDALL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kioskigospDALL
{
    public static class KioskData
    {
        public static void Initialize(KioskContext context)
        {
            if (!context.Kiosks.Any())
            {
                context.Kiosks.AddRange(
                    new Kiosk
                    {
                        Nomer = "1",
                        ModelKioska = "C",
                        Arenda = DateTime.Now.Date,
                        Town = Towns.Гомель,
                        Adress = "Ленина",
                        Area = 10
                    },
                    new Kiosk
                     {
                         Nomer = "2",
                         ModelKioska = "X",
                         Arenda = DateTime.Now.Date,
                         Town = Towns.Брагин,
                         Adress = "Победы",
                         Area = 15
                     },
                    new Kiosk
                      {
                          Nomer = "3",
                          ModelKioska = "C",
                          Arenda = DateTime.Now.Date,
                          Town = Towns.Добруш,
                          Adress = "Ильича",
                          Area = 8
                      },
                    new Kiosk
                       {
                           Nomer = "4",
                           ModelKioska = "X",
                           Arenda = DateTime.Now.Date,
                           Town = Towns.Гомель,
                           Adress = "Советская",
                           Area = 5
                       },
                    new Kiosk
                        {
                            Nomer = "5",
                            ModelKioska = "Павильон",
                            Arenda = DateTime.Now.Date,
                            Town = Towns.Гомель,
                            Adress = "Рогачевская",
                            Area = 20
                        }
                    );

                context.SaveChanges();
            }

        }
    }
}
