
#include <iostream>
#include <stdlib.h>

using namespace std;

int main()
{
  int menu;
  cout << "Seleccione su plato digitando el numero del menu :" << endl;
  cout << "1 Frijolada :" << endl;
  cout << "2 Sancocho :" << endl;
  cout << "3 Ajiaco :" << endl;
  cout << "4 Mojarra :" << endl;
  cin >> menu;
  switch(menu)
    {
    case 1:
      cout << "Usted ha seleccionado FRIJOLADA" << endl;
      cout << "El plato viene con pezuna, arroz y aguacate." <<endl;
      cout << "VALOR $16.000" <<endl;
      break;
    case 2:
      cout << "Usted ha seleccionado SANCOCHO: " << endl;
      cout << "El plato viene con arroz y aguacate." <<endl;
      cout << "VALOR $12.000" <<endl;
      break;
    case 3:
      cout << "Usted ha seleccionado AJIACO:  " <<endl;
      cout << "El plato viene con arroz, aguacate y alcaparras." <<endl;
      break;
     
    case 4:
    cout << "Usted ha seleccionado MOJARRA: " <<endl;
    cout << "El plato viene con arroz, papa francesa, patacon, ensalada y limon" <<endl;
     break;
     
     
    default:
      cout << "ERROR, No tenemos ese menu" << endl;
      break;
    }
   
   
     system("pause");
     
     return 0;
 
   
   
   
}