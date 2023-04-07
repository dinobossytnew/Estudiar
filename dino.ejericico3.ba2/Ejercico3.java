package dino.ejericico3.ba2;

import java.util.Scanner;

public class Ejercico3 {

	public static void main(String[] args) {
		
		Scanner s = new Scanner(System.in);
		System.out.println("Ingrese 1 Nombre Usuario");
		System.out.println("Ingrese 1 Contraseña");
		//oscomento
		System.out.println("Recuerda el orden de como colocas esto o te dara un mensaje de error!!");
		String user = s.nextLine();
		String contra = s.nextLine();
       
		
		if(user.equals("dino") && contra.equals("1234")) {
			System.out.println("Correcto has dado los datos tu nombre de usuario es: "+user);
			System.out.println("Correcto has dado los datos tu contraseña es: "+contra);
		}else {
			System.out.println("ACCESO DENEGADO!");
		}
	}

}
