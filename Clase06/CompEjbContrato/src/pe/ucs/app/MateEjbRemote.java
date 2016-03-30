/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.ucs.app;

import javax.ejb.Remote;

/**
 *
 * @author Docente
 */
@Remote
public interface MateEjbRemote {

    int sumar(int num1, int num2);
    
}
