
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_104

	''' <summary>
	'''     Converts the specified Unicode character to its equivalent string representation.
	''' </summary>
	''' <param name="c">The Unicode character to convert.</param>
	''' <returns>The string representation of the value of .</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToString(c As [Char]) As [String]
		Return [Char].ToString(c)
	End Function
End Module


