package controller;

import javax.annotation.PostConstruct;
import javax.faces.bean.ManagedBean;
import model.MateModel;

@ManagedBean
public class MateController {

  private MateModel mateModel;
  private int num1;
  private int num2;
  private int suma;

  @PostConstruct
  public void initBean(){
    mateModel = new MateModel();
  }
  
  public int getNum1() {
    return num1;
  }

  public void setNum1(int num1) {
    this.num1 = num1;
  }

  public int getNum2() {
    return num2;
  }

  public void setNum2(int num2) {
    this.num2 = num2;
  }

  public int getSuma() {
    return suma;
  }

  public void setSuma(int suma) {
    this.suma = suma;
  }
  
  public void doProcesar(){
    this.suma = mateModel.sumar(num1, num2);
  }
  
}
