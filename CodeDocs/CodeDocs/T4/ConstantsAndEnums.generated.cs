
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs
{

	public enum Risk
	{
		None = 0,
		Low = 3,
		Moderate = 21,
		High = 89,
		Extreme = 144
	}

	public enum Effort
	{
		None = 0,
		VerySmall = 1,
		Small = 8,
		Medium = 34,
		Large = 55,
		VeryLarge = 89,
		Unknown = 144
	}

	public enum Tag
	{
		Degredation,
		Change,
		Major,
		Fix,
		Minor,
		Performance,
		Work,
		Consequence,
		DeadCode,
		Security,
		InSecure,
		Toxic,
		Meaning,
		Feature,
		Review,
		Standards,
		Future,
		YAGNI,
		SRP,
		Principles,
		SOLID,
		DIP,
		DRY,
		ISP,
		LoD,
		LSP,
		OCP,
		SoC
	}

	public static partial class Constants
	{
		public const AttributeTargets Scope = AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Delegate | AttributeTargets.Event | AttributeTargets.Constructor | AttributeTargets.Method;
	
		#region Enum.ToName()

		public static string ToName(this Risk risk)
		{
			switch(risk)
			{
				case Risk.None: return "None";
				case Risk.Low: return "Low";
				case Risk.Moderate: return "Moderate";
				case Risk.High: return "High";
				case Risk.Extreme: return "Extreme";
				default: return string.Empty;
			}
		}

		public static string ToName(this Effort effort)
		{
			switch(effort)
			{
				case Effort.None: return "None";
				case Effort.VerySmall: return "VerySmall";
				case Effort.Small: return "Small";
				case Effort.Medium: return "Medium";
				case Effort.Large: return "Large";
				case Effort.VeryLarge: return "VeryLarge";
				case Effort.Unknown: return "Unknown";
				default: return string.Empty;
			}
		}

		public static string ToName(this Tag tag)
		{
			switch(tag)
			{
				case Tag.Degredation: return "Degredation";
				case Tag.Change: return "Change";
				case Tag.Major: return "Major";
				case Tag.Fix: return "Fix";
				case Tag.Minor: return "Minor";
				case Tag.Performance: return "Performance";
				case Tag.Work: return "Work";
				case Tag.Consequence: return "Consequence";
				case Tag.DeadCode: return "DeadCode";
				case Tag.Security: return "Security";
				case Tag.InSecure: return "InSecure";
				case Tag.Toxic: return "Toxic";
				case Tag.Meaning: return "Meaning";
				case Tag.Feature: return "Feature";
				case Tag.Review: return "Review";
				case Tag.Standards: return "Standards";
				case Tag.Future: return "Future";
				case Tag.YAGNI: return "YAGNI";
				case Tag.SRP: return "SRP";
				case Tag.Principles: return "Principles";
				case Tag.SOLID: return "SOLID";
				case Tag.DIP: return "DIP";
				case Tag.DRY: return "DRY";
				case Tag.ISP: return "ISP";
				case Tag.LoD: return "LoD";
				case Tag.LSP: return "LSP";
				case Tag.OCP: return "OCP";
				case Tag.SoC: return "SoC";
				default: return string.Empty;
			}
		}
	
		#endregion
	}
}