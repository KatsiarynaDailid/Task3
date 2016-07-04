using Framework.Element;
using System;

namespace Framework.BusinessLogic
{
    class BusinessLogic : Button
    {

        public string Name { get; set; }
        public int Age { get; set; }

        //        i.Содержит метод для сохранения данных о пользователе.Вводит данные в поля Name и Age, нажимает Save
        //ii.Использует классы страниц и элементов на них, а также методы элементов

        public void SaveData() {

            Page page = new Page();
            if (!page.LoadPage()) {

                //smth bad happend
            }

            String id = "Save";            
            Button but = new Button(id);
        
            Elements elem = new Elements();
            elem.Click(but);


        }


    }
}
