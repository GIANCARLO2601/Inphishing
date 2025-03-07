using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public enum TiposDeItem{
    Pociones,
    Llaves,
    Medallas,
    Ingredientes
}
public class InventarioItem : ScriptableObject
{
  [Header("Parametros")]
  public string ID;
  public string Nombre;
  public Sprite Icono;
  
  [TextArea]public string Descripcion;

  [Header("Informacion")]
  public TiposDeItem Tipo;
  public bool EsConsumible;
  public bool EsAcumulable;
  public int AcumulacionMax;
  [HideInInspector]public int Cantidad;

  public InventarioItem CopiarItem(){
    InventarioItem nuevaInstancia=Instantiate(this);
    return nuevaInstancia;
  }

  
}