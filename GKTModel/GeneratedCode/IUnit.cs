﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

public interface IUnit 
{   
    [Key]
    int Id { get; set; }
    string Name { get; set; }

	NoiseQuencher InflowNoiseQuencher { get;set; }

	NoiseQuencher ExtractNoiseQuencher { get;set; }

	IFan IFan { get;set; }

	IHeater IHeater { get;set; }

	ICooler ICooler { get;set; }

	FilterType FilterType { get;set; }

}

