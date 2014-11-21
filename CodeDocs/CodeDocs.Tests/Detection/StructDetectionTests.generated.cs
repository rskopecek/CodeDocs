﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CodeDocs.Tests.Detection
{
	// Automated Tests
	public class StructDetectionAutomatedTests
	{

		[Fact]
		public void Detection_Of_publicInstanceDetectionExampleStruct_FromType() { typeof(publicInstanceDetectionExampleStruct).GetCodeDocs().AssertExpectations(publicInstanceDetectionExampleStruct.DetectionCount); }

		[Fact]
		public void Detection_Of_publicInstanceDetectionExampleStruct_FromInstance() { (new publicInstanceDetectionExampleStruct(1)).GetCodeDocs().AssertExpectations(publicInstanceDetectionExampleStruct.DetectionCount); }

		[Fact]
		public void Detection_Of_internalInstanceDetectionExampleStruct_FromType() { typeof(internalInstanceDetectionExampleStruct).GetCodeDocs().AssertExpectations(internalInstanceDetectionExampleStruct.DetectionCount); }

		[Fact]
		public void Detection_Of_internalInstanceDetectionExampleStruct_FromInstance() { (new internalInstanceDetectionExampleStruct(1)).GetCodeDocs().AssertExpectations(internalInstanceDetectionExampleStruct.DetectionCount); }


	}




	// Instance Classes

    [Bug("1")]
    public class publicInstanceDetectionExampleStruct
    {
		
		#region ***** Style = Static


		
		#region Protection = public

        [Bug("2")] public interface I2 { };
        [Bug("3")] public struct lc3 { };
        [Bug("4")] public class lc4 { };
        [Bug("5")] public static class lc5 { };
        [Bug("6")] public enum E6 { A };
        [Bug("7")] public static string P7 { get; set; }
        [Bug("8")] public static string F8;
        [Bug("9")] public delegate string D9();
        [Bug("10")] public static event D9 Ev10;
        [Bug("11")] public static void M11() { }
		#endregion

		
		#region Protection = private

        [Bug("12")] private interface I12 { };
        [Bug("13")] private struct lc13 { };
        [Bug("14")] private class lc14 { };
        [Bug("15")] private static class lc15 { };
        [Bug("16")] private enum E16 { A };
        [Bug("17")] private static string P17 { get; set; }
        [Bug("18")] private static string F18;
        [Bug("19")] private delegate string D19();
        [Bug("20")] private static event D19 Ev20;
        [Bug("21")] private static void M21() { }
		#endregion

		
		#region Protection = protected

        [Bug("22")] protected interface I22 { };
        [Bug("23")] protected struct lc23 { };
        [Bug("24")] protected class lc24 { };
        [Bug("25")] protected static class lc25 { };
        [Bug("26")] protected enum E26 { A };
        [Bug("27")] protected static string P27 { get; set; }
        [Bug("28")] protected static string F28;
        [Bug("29")] protected delegate string D29();
        [Bug("30")] protected static event D29 Ev30;
        [Bug("31")] protected static void M31() { }
		#endregion

		
		#region Protection = internal

        [Bug("32")] internal interface I32 { };
        [Bug("33")] internal struct lc33 { };
        [Bug("34")] internal class lc34 { };
        [Bug("35")] internal static class lc35 { };
        [Bug("36")] internal enum E36 { A };
        [Bug("37")] internal static string P37 { get; set; }
        [Bug("38")] internal static string F38;
        [Bug("39")] internal delegate string D39();
        [Bug("40")] internal static event D39 Ev40;
        [Bug("41")] internal static void M41() { }
		#endregion

		
		#region Protection = protected internal

        [Bug("42")] protected internal interface I42 { };
        [Bug("43")] protected internal struct lc43 { };
        [Bug("44")] protected internal class lc44 { };
        [Bug("45")] protected internal static class lc45 { };
        [Bug("46")] protected internal enum E46 { A };
        [Bug("47")] protected internal static string P47 { get; set; }
        [Bug("48")] protected internal static string F48;
        [Bug("49")] protected internal delegate string D49();
        [Bug("50")] protected internal static event D49 Ev50;
        [Bug("51")] protected internal static void M51() { }
		#endregion

		#endregion
		
		#region ***** Style = Instance


		
		#region Protection = public

        [Bug("52")] public  publicInstanceDetectionExampleStruct(int p1) {}
        [Bug("53")] public interface I53 { };
        [Bug("54")] public struct lc54 { };
        [Bug("55")] public class lc55 { };
        [Bug("56")] public static class lc56 { };
        [Bug("57")] public enum E57 { A };
        [Bug("58")] public  string P58 { get; set; }
        [Bug("59")] public  string F59;
        [Bug("60")] public delegate string D60();
        [Bug("61")] public  event D60 Ev61;
        [Bug("62")] public  void M62() { }
		#endregion

		
		#region Protection = private

        [Bug("63")] private  publicInstanceDetectionExampleStruct(int p1, int p2) {}
        [Bug("64")] private interface I64 { };
        [Bug("65")] private struct lc65 { };
        [Bug("66")] private class lc66 { };
        [Bug("67")] private static class lc67 { };
        [Bug("68")] private enum E68 { A };
        [Bug("69")] private  string P69 { get; set; }
        [Bug("70")] private  string F70;
        [Bug("71")] private delegate string D71();
        [Bug("72")] private  event D71 Ev72;
        [Bug("73")] private  void M73() { }
		#endregion

		
		#region Protection = protected

        [Bug("74")] protected  publicInstanceDetectionExampleStruct(int p1, int p2, int p3) {}
        [Bug("75")] protected interface I75 { };
        [Bug("76")] protected struct lc76 { };
        [Bug("77")] protected class lc77 { };
        [Bug("78")] protected static class lc78 { };
        [Bug("79")] protected enum E79 { A };
        [Bug("80")] protected  string P80 { get; set; }
        [Bug("81")] protected  string F81;
        [Bug("82")] protected delegate string D82();
        [Bug("83")] protected  event D82 Ev83;
        [Bug("84")] protected  void M84() { }
		#endregion

		
		#region Protection = internal

        [Bug("85")] internal  publicInstanceDetectionExampleStruct(int p1, int p2, int p3, int p4) {}
        [Bug("86")] internal interface I86 { };
        [Bug("87")] internal struct lc87 { };
        [Bug("88")] internal class lc88 { };
        [Bug("89")] internal static class lc89 { };
        [Bug("90")] internal enum E90 { A };
        [Bug("91")] internal  string P91 { get; set; }
        [Bug("92")] internal  string F92;
        [Bug("93")] internal delegate string D93();
        [Bug("94")] internal  event D93 Ev94;
        [Bug("95")] internal  void M95() { }
		#endregion

		
		#region Protection = protected internal

        [Bug("96")] protected internal  publicInstanceDetectionExampleStruct(int p1, int p2, int p3, int p4, int p5) {}
        [Bug("97")] protected internal interface I97 { };
        [Bug("98")] protected internal struct lc98 { };
        [Bug("99")] protected internal class lc99 { };
        [Bug("100")] protected internal static class lc100 { };
        [Bug("101")] protected internal enum E101 { A };
        [Bug("102")] protected internal  string P102 { get; set; }
        [Bug("103")] protected internal  string F103;
        [Bug("104")] protected internal delegate string D104();
        [Bug("105")] protected internal  event D104 Ev105;
        [Bug("106")] protected internal  void M106() { }
		#endregion

		#endregion

		public readonly static int DetectionCount = 106;

    }
    [Bug("1")]
    internal class internalInstanceDetectionExampleStruct
    {
		
		#region ***** Style = Static


		
		#region Protection = public

        [Bug("2")] public interface I2 { };
        [Bug("3")] public struct lc3 { };
        [Bug("4")] public class lc4 { };
        [Bug("5")] public static class lc5 { };
        [Bug("6")] public enum E6 { A };
        [Bug("7")] public static string P7 { get; set; }
        [Bug("8")] public static string F8;
        [Bug("9")] public delegate string D9();
        [Bug("10")] public static event D9 Ev10;
        [Bug("11")] public static void M11() { }
		#endregion

		
		#region Protection = private

        [Bug("12")] private interface I12 { };
        [Bug("13")] private struct lc13 { };
        [Bug("14")] private class lc14 { };
        [Bug("15")] private static class lc15 { };
        [Bug("16")] private enum E16 { A };
        [Bug("17")] private static string P17 { get; set; }
        [Bug("18")] private static string F18;
        [Bug("19")] private delegate string D19();
        [Bug("20")] private static event D19 Ev20;
        [Bug("21")] private static void M21() { }
		#endregion

		
		#region Protection = protected

        [Bug("22")] protected interface I22 { };
        [Bug("23")] protected struct lc23 { };
        [Bug("24")] protected class lc24 { };
        [Bug("25")] protected static class lc25 { };
        [Bug("26")] protected enum E26 { A };
        [Bug("27")] protected static string P27 { get; set; }
        [Bug("28")] protected static string F28;
        [Bug("29")] protected delegate string D29();
        [Bug("30")] protected static event D29 Ev30;
        [Bug("31")] protected static void M31() { }
		#endregion

		
		#region Protection = internal

        [Bug("32")] internal interface I32 { };
        [Bug("33")] internal struct lc33 { };
        [Bug("34")] internal class lc34 { };
        [Bug("35")] internal static class lc35 { };
        [Bug("36")] internal enum E36 { A };
        [Bug("37")] internal static string P37 { get; set; }
        [Bug("38")] internal static string F38;
        [Bug("39")] internal delegate string D39();
        [Bug("40")] internal static event D39 Ev40;
        [Bug("41")] internal static void M41() { }
		#endregion

		
		#region Protection = protected internal

        [Bug("42")] protected internal interface I42 { };
        [Bug("43")] protected internal struct lc43 { };
        [Bug("44")] protected internal class lc44 { };
        [Bug("45")] protected internal static class lc45 { };
        [Bug("46")] protected internal enum E46 { A };
        [Bug("47")] protected internal static string P47 { get; set; }
        [Bug("48")] protected internal static string F48;
        [Bug("49")] protected internal delegate string D49();
        [Bug("50")] protected internal static event D49 Ev50;
        [Bug("51")] protected internal static void M51() { }
		#endregion

		#endregion
		
		#region ***** Style = Instance


		
		#region Protection = public

        [Bug("52")] public  internalInstanceDetectionExampleStruct(int p1) {}
        [Bug("53")] public interface I53 { };
        [Bug("54")] public struct lc54 { };
        [Bug("55")] public class lc55 { };
        [Bug("56")] public static class lc56 { };
        [Bug("57")] public enum E57 { A };
        [Bug("58")] public  string P58 { get; set; }
        [Bug("59")] public  string F59;
        [Bug("60")] public delegate string D60();
        [Bug("61")] public  event D60 Ev61;
        [Bug("62")] public  void M62() { }
		#endregion

		
		#region Protection = private

        [Bug("63")] private  internalInstanceDetectionExampleStruct(int p1, int p2) {}
        [Bug("64")] private interface I64 { };
        [Bug("65")] private struct lc65 { };
        [Bug("66")] private class lc66 { };
        [Bug("67")] private static class lc67 { };
        [Bug("68")] private enum E68 { A };
        [Bug("69")] private  string P69 { get; set; }
        [Bug("70")] private  string F70;
        [Bug("71")] private delegate string D71();
        [Bug("72")] private  event D71 Ev72;
        [Bug("73")] private  void M73() { }
		#endregion

		
		#region Protection = protected

        [Bug("74")] protected  internalInstanceDetectionExampleStruct(int p1, int p2, int p3) {}
        [Bug("75")] protected interface I75 { };
        [Bug("76")] protected struct lc76 { };
        [Bug("77")] protected class lc77 { };
        [Bug("78")] protected static class lc78 { };
        [Bug("79")] protected enum E79 { A };
        [Bug("80")] protected  string P80 { get; set; }
        [Bug("81")] protected  string F81;
        [Bug("82")] protected delegate string D82();
        [Bug("83")] protected  event D82 Ev83;
        [Bug("84")] protected  void M84() { }
		#endregion

		
		#region Protection = internal

        [Bug("85")] internal  internalInstanceDetectionExampleStruct(int p1, int p2, int p3, int p4) {}
        [Bug("86")] internal interface I86 { };
        [Bug("87")] internal struct lc87 { };
        [Bug("88")] internal class lc88 { };
        [Bug("89")] internal static class lc89 { };
        [Bug("90")] internal enum E90 { A };
        [Bug("91")] internal  string P91 { get; set; }
        [Bug("92")] internal  string F92;
        [Bug("93")] internal delegate string D93();
        [Bug("94")] internal  event D93 Ev94;
        [Bug("95")] internal  void M95() { }
		#endregion

		
		#region Protection = protected internal

        [Bug("96")] protected internal  internalInstanceDetectionExampleStruct(int p1, int p2, int p3, int p4, int p5) {}
        [Bug("97")] protected internal interface I97 { };
        [Bug("98")] protected internal struct lc98 { };
        [Bug("99")] protected internal class lc99 { };
        [Bug("100")] protected internal static class lc100 { };
        [Bug("101")] protected internal enum E101 { A };
        [Bug("102")] protected internal  string P102 { get; set; }
        [Bug("103")] protected internal  string F103;
        [Bug("104")] protected internal delegate string D104();
        [Bug("105")] protected internal  event D104 Ev105;
        [Bug("106")] protected internal  void M106() { }
		#endregion

		#endregion

		public readonly static int DetectionCount = 106;

    }

}