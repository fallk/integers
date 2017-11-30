using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A279262
{
public static readonly long[] Value={ 0L,4L,10L,20L,38L,68L,120L,208L,358L,612L,1042L,1768L,2992L,5052L,8514L,14324L,24062L,40364L,67624L,113160L,189150L,315844L,526890L,878160L,1462368L,2433268L,4045690L,6721748L,11160278L,18517652L,30706392L,50888128L,84287062L,139531812L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279262Inst : IEnumerable<long>
{
public static readonly long[] Value=A279262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279262.Bytes);
public long this[int i]=>Value[i];

public static A279262Inst Instance=new A279262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279263
{
public static readonly long[] Value={ 2L,10L,29L,86L,240L,626L,1603L,4030L,9973L,24388L,59068L,141920L,338689L,803630L,1897359L,4460226L,10444904L,24376990L,56720671L,131619998L,304674313L,703690416L,1621976820L,3731637260L,8570604669L,19653441614L,45002040707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279263Inst : IEnumerable<long>
{
public static readonly long[] Value=A279263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279263.Bytes);
public long this[int i]=>Value[i];

public static A279263Inst Instance=new A279263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279264
{
public static readonly long[] Value={ 2L,20L,86L,400L,1592L,5888L,21882L,79112L,281754L,991292L,3452756L,11929580L,40936072L,139644508L,473965068L,1601601800L,5391122062L,18084715096L,60480149694L,201706042464L,671036424848L,2227380695220L,7378205313096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279264Inst : IEnumerable<long>
{
public static readonly long[] Value=A279264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279264.Bytes);
public long this[int i]=>Value[i];

public static A279264Inst Instance=new A279264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279265
{
public static readonly long[] Value={ 5L,38L,240L,1592L,9042L,51568L,283450L,1526492L,8110769L,42557410L,221270081L,1141211474L,5846407067L,29780194244L,150943805823L,761780179606L,3829943970192L,19190669055102L,95869271616912L,477631625489180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279265Inst : IEnumerable<long>
{
public static readonly long[] Value=A279265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279265.Bytes);
public long this[int i]=>Value[i];

public static A279265Inst Instance=new A279265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279266
{
public static readonly long[] Value={ 8L,68L,626L,5888L,51568L,429716L,3490152L,27850092L,218952412L,1701805320L,13104577920L,100123194948L,759950374372L,5735676314072L,43078974827592L,322177736874528L,2400465164552300L,17825755365009616L,131979614009117780L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279266Inst : IEnumerable<long>
{
public static readonly long[] Value=A279266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279266.Bytes);
public long this[int i]=>Value[i];

public static A279266Inst Instance=new A279266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279267
{
public static readonly long[] Value={ 15L,120L,1603L,21882L,283450L,3490152L,42093113L,498160278L,5812405127L,67071788240L,766923320987L,8702848263928L,98122997204330L,1100209100745782L,12277125522368779L,136425808025932376L,1510393582783303438L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279267Inst : IEnumerable<long>
{
public static readonly long[] Value=A279267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279267.Bytes);
public long this[int i]=>Value[i];

public static A279267Inst Instance=new A279267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279268
{
public static readonly long[] Value={ 0L,0L,0L,2L,4L,2L,2L,10L,10L,2L,5L,20L,29L,20L,5L,8L,38L,86L,86L,38L,8L,15L,68L,240L,400L,240L,68L,15L,26L,120L,626L,1592L,1592L,626L,120L,26L,46L,208L,1603L,5888L,9042L,5888L,1603L,208L,46L,80L,358L,4030L,21882L,51568L,51568L,21882L,4030L,358L,80L,139L,612L,9973L,79112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279268Inst : IEnumerable<long>
{
public static readonly long[] Value=A279268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279268.Bytes);
public long this[int i]=>Value[i];

public static A279268Inst Instance=new A279268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279269
{
public static readonly long[] Value={ 1L,7L,53L,391L,2865L,20967L,153413L,1122471L,8212705L,60089287L,439650773L,3216759751L,23535824145L,172202794407L,1259943234533L,9218531904231L,67448539061185L,493495652968327L,3610722528440693L,26418301962683911L,193292803059267825L,1414250914660723047L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279269Inst : IEnumerable<long>
{
public static readonly long[] Value=A279269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279269.Bytes);
public long this[int i]=>Value[i];

public static A279269Inst Instance=new A279269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279270
{
public static readonly long[] Value={ 1L,-4L,5L,-4L,10L,-16L,12L,-8L,14L,-28L,21L,-8L,30L,-40L,28L,-16L,21L,-52L,34L,-20L,50L,-56L,48L,-24L,38L,-72L,44L,-28L,70L,-88L,56L,-24L,43L,-100L,70L,-36L,80L,-112L,84L,-32L,62L,-104L,85L,-44L,110L,-136L,56L,-56L,74L,-148L,102L,-40L,130L,-144L,120L,-56L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279270Inst : IEnumerable<long>
{
public static readonly long[] Value=A279270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279270.Bytes);
public long this[int i]=>Value[i];

public static A279270Inst Instance=new A279270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279271
{
public static readonly BigInteger[] Value={ 1L,1L,3L,12L,57L,320L,2065L,14954L,119585L,1044184L,9867633L,100185294L,1086173121L,12510549116L,152422123321L,1956974934290L,26391647743937L,372769201632784L,5500416368181921L,84594395013757398L,1353277808896178145L,BigInteger.Parse("22476374660911200068"),BigInteger.Parse("386925983827921358665"),BigInteger.Parse("6893254434792968631674") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279271Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279271.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279271Inst Instance=new A279271Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279272
{
public static readonly long[] Value={ 72L,282L,9000L,13932L,19212L,22158L,49920L,65538L,72228L,78888L,144408L,169320L,201492L,201828L,218460L,234540L,270030L,296478L,325080L,355008L,365748L,411000L,448872L,461052L,484152L,504618L,555522L,558252L,586362L,622620L,674058L,981810L,1067490L,1095792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279272Inst : IEnumerable<long>
{
public static readonly long[] Value=A279272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279272.Bytes);
public long this[int i]=>Value[i];

public static A279272Inst Instance=new A279272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279273
{
public static readonly long[] Value={ 0L,0L,0L,8L,40L,104L,216L,440L,720L,1160L,1656L,2432L,3216L,4472L,5680L,7280L,9128L,11328L,13504L,16632L,19424L,23216L,27088L,31600L,35832L,41912L,47192L,53544L,60152L,68192L,75168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279273Inst : IEnumerable<long>
{
public static readonly long[] Value=A279273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279273.Bytes);
public long this[int i]=>Value[i];

public static A279273Inst Instance=new A279273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279274
{
public static readonly BigInteger[] Value={ 238L,685382117L,380358424875L,211083026086753L,BigInteger.Parse("606761281164154030532"),BigInteger.Parse("336727147248939746087250"),BigInteger.Parse("186869490875990437334549968"),BigInteger.Parse("537159115995469726115102627401247"),BigInteger.Parse("298100855085679705519137567072187125"),BigInteger.Parse("165433513379232813905174469119753565883") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279274Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279274.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279274Inst Instance=new A279274Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279275
{
public static readonly BigInteger[] Value={ 500L,721525L,1040439075L,1500312425150L,2163449476627750L,3119692644984790875L,BigInteger.Parse("4498594630618591814525"),BigInteger.Parse("6486970337659364411754700"),BigInteger.Parse("9354206728310172863158463400"),BigInteger.Parse("13488759615252931609310092468625"),BigInteger.Parse("19450782010987999070452290181294375") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279275Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279275.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279275Inst Instance=new A279275Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279276
{
public static readonly BigInteger[] Value={ 25L,2093L,2413024782L,199383164500L,16474611689525L,1361262526857873L,BigInteger.Parse("1569151855418042668762"),BigInteger.Parse("129655718749849826609000"),BigInteger.Parse("10713179445632171628299025"),BigInteger.Parse("885207493668292813536022453"),BigInteger.Parse("1020394636386389128112999131619942"),BigInteger.Parse("84313063475888056056234492629533500") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279276Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279276.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279276Inst Instance=new A279276Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279277
{
public static readonly long[] Value={ 1L,4L,12L,37L,110L,327L,968L,2864L,8469L,25040L,74029L,218856L,647008L,1912753L,5654670L,16716883L,49420052L,146100276L,431915561L,1276869920L,3774804441L,11159436284L,32990587972L,97529916957L,288327225550L,852380393407L,2519888066928L,7449533000584L,22023018662909L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279277Inst : IEnumerable<long>
{
public static readonly long[] Value=A279277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279277.Bytes);
public long this[int i]=>Value[i];

public static A279277Inst Instance=new A279277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279278
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,2L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,2L,1L,0L,1L,2L,1L,0L,0L,0L,1L,2L,1L,0L,1L,2L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,2L,1L,0L,1L,2L,1L,0L,1L,1L,0L,1L,1L,0L,1L,2L,1L,0L,1L,1L,0L,1L,1L,0L,1L,2L,1L,0L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279278Inst : IEnumerable<long>
{
public static readonly long[] Value=A279278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279278.Bytes);
public long this[int i]=>Value[i];

public static A279278Inst Instance=new A279278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279279
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,2L,2L,0L,0L,0L,0L,1L,2L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,2L,1L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,1L,1L,1L,2L,1L,0L,1L,1L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279279Inst : IEnumerable<long>
{
public static readonly long[] Value=A279279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279279.Bytes);
public long this[int i]=>Value[i];

public static A279279Inst Instance=new A279279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279280
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,2L,1L,0L,0L,0L,0L,0L,1L,2L,1L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,2L,1L,0L,0L,0L,1L,1L,1L,2L,1L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279280Inst : IEnumerable<long>
{
public static readonly long[] Value=A279280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279280.Bytes);
public long this[int i]=>Value[i];

public static A279280Inst Instance=new A279280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279281
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,2L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279281Inst : IEnumerable<long>
{
public static readonly long[] Value=A279281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279281.Bytes);
public long this[int i]=>Value[i];

public static A279281Inst Instance=new A279281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279282
{
public static readonly long[] Value={ 0L,1L,16L,182L,1720L,14149L,106944L,760463L,5160488L,33756514L,214369376L,1328496947L,8065970016L,48125315989L,282851349184L,1640791635086L,9409099218712L,53408767286521L,300417148670400L,1676056809217283L,9282172245277448L,51062759750186170L,279196558362482192L,1518068927980989575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279282Inst : IEnumerable<long>
{
public static readonly long[] Value=A279282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279282.Bytes);
public long this[int i]=>Value[i];

public static A279282Inst Instance=new A279282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279283
{
public static readonly long[] Value={ 0L,1L,8L,52L,304L,1650L,8492L,42000L,201356L,941367L,4310480L,19395042L,85972228L,376185250L,1627518840L,6971209090L,29595604656L,124648174343L,521225809112L,2165408553994L,8942942384500L,36733935375275L,150138939637144L,610840125062072L,2474686297520984L,9986301300789540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279283Inst : IEnumerable<long>
{
public static readonly long[] Value=A279283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279283.Bytes);
public long this[int i]=>Value[i];

public static A279283Inst Instance=new A279283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279284
{
public static readonly long[] Value={ 0L,1L,10L,74L,469L,2662L,14115L,71360L,348143L,1652200L,7669883L,34969286L,157060011L,696514465L,3055404733L,13277356490L,57222978070L,244831062184L,1040760406476L,4398642943496L,18493603597214L,77388169532299L,322451025667910L,1338291853544522L,5534486308363461L,22812231761335189L,93741611639348947L,384122032722040412L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279284Inst : IEnumerable<long>
{
public static readonly long[] Value=A279284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279284.Bytes);
public long this[int i]=>Value[i];

public static A279284Inst Instance=new A279284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279285
{
public static readonly long[] Value={ 0L,1L,4L,18L,82L,377L,1740L,8045L,37226L,172314L,797744L,3693493L,17101128L,79180525L,366618808L,1697509962L,7859781454L,36392245541L,168502887396L,780199897985L,3612471696230L,16726421117538L,77446465948772L,358591660029577L,1660346632032144L,7687716275234809L,35595568065121900L,164814155562334914L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279285Inst : IEnumerable<long>
{
public static readonly long[] Value=A279285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279285.Bytes);
public long this[int i]=>Value[i];

public static A279285Inst Instance=new A279285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279286
{
public static readonly long[] Value={ 1L,2L,7L,15L,52L,102L,296L,371L,455L,929L,1853L,2034L,4517L,4797L,5829L,6146L,6948L,17577L,18915L,60349L,78369L,85171L,123788L,128596L,415355L,906771L,1308771L,3329668L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279286Inst : IEnumerable<long>
{
public static readonly long[] Value=A279286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279286.Bytes);
public long this[int i]=>Value[i];

public static A279286Inst Instance=new A279286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279287
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,3L,1L,2L,1L,5L,2L,6L,3L,2L,8L,8L,1L,9L,4L,3L,5L,11L,1L,20L,3L,9L,2L,14L,1L,15L,8L,5L,4L,6L,4L,18L,9L,6L,2L,20L,3L,21L,10L,4L,11L,23L,8L,14L,10L,8L,4L,26L,9L,10L,3L,9L,7L,29L,4L,30L,15L,6L,32L,12L,5L,33L,16L,11L,3L,35L,2L,36L,9L,20L,6L,15L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279287Inst : IEnumerable<long>
{
public static readonly long[] Value=A279287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279287.Bytes);
public long this[int i]=>Value[i];

public static A279287Inst Instance=new A279287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279288
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,2L,1L,1L,1L,1L,1L,3L,1L,2L,1L,5L,1L,1L,1L,3L,1L,2L,1L,1L,3L,1L,2L,1L,1L,1L,1L,3L,1L,1L,1L,3L,1L,2L,1L,1L,1L,2L,1L,3L,1L,2L,1L,5L,1L,3L,1L,1L,1L,4L,1L,1L,1L,1L,1L,3L,1L,2L,1L,7L,1L,2L,1L,3L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,5L,5L,1L,1L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279288Inst : IEnumerable<long>
{
public static readonly long[] Value=A279288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279288.Bytes);
public long this[int i]=>Value[i];

public static A279288Inst Instance=new A279288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279289
{
public static readonly long[] Value={ 5L,7L,9L,11L,13L,14L,15L,16L,17L,19L,20L,21L,22L,23L,25L,26L,27L,28L,29L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279289Inst : IEnumerable<long>
{
public static readonly long[] Value=A279289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279289.Bytes);
public long this[int i]=>Value[i];

public static A279289Inst Instance=new A279289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279290
{
public static readonly long[] Value={ 1L,1L,1L,65L,1L,217L,1L,577L,730L,1001L,1L,2009L,1L,2745L,3376L,4673L,1L,6778L,1L,9065L,9262L,10649L,1L,16345L,15626L,17577L,20413L,24761L,1L,31592L,1L,37441L,35938L,39305L,42876L,55226L,1L,54873L,59320L,73577L,1L,86310L,1L,95897L,95230L,97337L,1L,131033L,117650L,141626L,132652L,158249L,1L,183925L,166376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279290Inst : IEnumerable<long>
{
public static readonly long[] Value=A279290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279290.Bytes);
public long this[int i]=>Value[i];

public static A279290Inst Instance=new A279290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279291
{
public static readonly long[] Value={ 1L,1L,0L,2L,1L,0L,1L,2L,0L,0L,0L,1L,0L,0L,1L,0L,0L,2L,1L,0L,2L,1L,0L,1L,2L,1L,0L,0L,1L,1L,2L,0L,0L,0L,0L,2L,1L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,0L,3L,0L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,2L,0L,0L,1L,0L,2L,0L,2L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279291Inst : IEnumerable<long>
{
public static readonly long[] Value=A279291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279291.Bytes);
public long this[int i]=>Value[i];

public static A279291Inst Instance=new A279291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279292
{
public static readonly BigInteger[] Value={ 1L,10L,167L,2064L,28143L,374166L,5227491L,75105984L,1127851278L,17625022976L,287569327286L,4891520843344L,86749331150517L,1602239541108282L,30795187124606301L,615261376037422992L,12764913390565572333UL,BigInteger.Parse("274721686459213597782"),BigInteger.Parse("6126847681304067647287") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279292Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279292.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279292Inst Instance=new A279292Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279293
{
public static readonly BigInteger[] Value={ 1L,12L,316L,4961L,88482L,1456780L,24970807L,430069638L,7646066285L,139512608803L,2630205520242L,51191324887317L,1030225266241718L,21431850533761458L,460916811387051427L,10243049068068285706UL,BigInteger.Parse("235127217600172319772"),BigInteger.Parse("5571780677576178939683") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279293Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279293.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279293Inst Instance=new A279293Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279294
{
public static readonly BigInteger[] Value={ 1L,14L,597L,11486L,265354L,5307274L,110325975L,2250025170L,46909998946L,990648740298L,21419845540563L,473829924582378L,10757656204264520L,250739074393237162L,6005432933786523655L,BigInteger.Parse("147819656394632180730"),BigInteger.Parse("3739797338380838531829"),BigInteger.Parse("97237232835306526768108") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279294Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279294.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279294Inst Instance=new A279294Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279295
{
public static readonly BigInteger[] Value={ 1L,16L,1138L,25999L,775195L,18523314L,463088628L,11068300437L,268537592975L,6514804501312L,160541447975710L,4013204668037233L,102267326625073183L,2658365720541599806L,BigInteger.Parse("70614284743773530148"),BigInteger.Parse("1917874812704472161265"),BigInteger.Parse("53294689741358893762638") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279295Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279295.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279295Inst Instance=new A279295Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279296
{
public static readonly BigInteger[] Value={ 1L,18L,2195L,57980L,2234121L,62821766L,1877987735L,52129260840L,1462714640951L,40503784352590L,1131481211125461L,31802909031355052L,905596491625548929L,BigInteger.Parse("26146644212681105382"),BigInteger.Parse("767446589270204991395"),BigInteger.Parse("22921754812832515642328"),BigInteger.Parse("697455004277912572544814") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279296Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279296.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279296Inst Instance=new A279296Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279297
{
public static readonly BigInteger[] Value={ 1L,20L,4280L,127917L,6402984L,208910728L,7440888001L,237920318012L,7682498246390L,241437687882797L,7610900307811180L,239466123419848086L,7589962647890648579L,BigInteger.Parse("242520044163828141976"),BigInteger.Parse("7839783867491553405462"),BigInteger.Parse("256717246780820798056943"),BigInteger.Parse("8529320594216231644881865") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279297Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279297.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279297Inst Instance=new A279297Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279298
{
public static readonly BigInteger[] Value={ 1L,22L,8417L,279850L,18342412L,685212762L,29029313611L,1061113063498L,39275632545209L,1393699927780248L,49383101195522106L,1732429335364441968L,BigInteger.Parse("60909095747242747307"),BigInteger.Parse("2146854079671345945398"),BigInteger.Parse("76207802610167861527865"),BigInteger.Parse("2728392333397142478341958") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279298Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279298.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279298Inst Instance=new A279298Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279299
{
public static readonly BigInteger[] Value={ 1L,24L,16654L,607995L,52687209L,2225347678L,112136485958L,4652156989635L,196794669764694L,7848158942463262L,311532163358831142L,12142236428089109402UL,BigInteger.Parse("472096448836605015907"),BigInteger.Parse("18301483090810860748890"),BigInteger.Parse("711486425957970444213722"),BigInteger.Parse("27780774432495984165279729") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279299Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279299.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279299Inst Instance=new A279299Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279300
{
public static readonly long[] Value={ 0L,1L,0L,3L,6L,24L,72L,232L,720L,2232L,6848L,20880L,63264L,190656L,571776L,1707264L,5077504L,15046272L,44439552L,130854656L,384228864L,1125285888L,3287672832L,9583835136L,27879174144L,80941029376L,234562535424L,678574706688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279300Inst : IEnumerable<long>
{
public static readonly long[] Value=A279300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279300.Bytes);
public long this[int i]=>Value[i];

public static A279300Inst Instance=new A279300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279301
{
public static readonly long[] Value={ 1L,0L,12L,104L,872L,8064L,71680L,635312L,5554240L,47920384L,408259136L,3437600192L,28638307456L,236298903552L,1932926374400L,15688543703808L,126443222102016L,1012619953508352L,8062922404920320L,63864515531578368L,503439208935970816L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279301Inst : IEnumerable<long>
{
public static readonly long[] Value=A279301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279301.Bytes);
public long this[int i]=>Value[i];

public static A279301Inst Instance=new A279301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279302
{
public static readonly BigInteger[] Value={ 0L,12L,498L,14908L,396904L,10073670L,246262496L,5863622944L,136676490546L,3131550460530L,70733849080300L,1578557580824350L,34866752133128860L,763271052441391984L,16578556739715557822UL,BigInteger.Parse("357612940899237556004") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279302Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279302.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279302Inst Instance=new A279302Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279303
{
public static readonly BigInteger[] Value={ 3L,104L,14908L,1160588L,85082276L,6048938846L,417999641840L,28259741645108L,1876377200689742L,122717260049777256L,7923575567872456696L,BigInteger.Parse("506002930634118251738"),BigInteger.Parse("32006135169381911287878"),BigInteger.Parse("2007600046176079397378614") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279303Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279303.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279303Inst Instance=new A279303Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279304
{
public static readonly BigInteger[] Value={ 6L,872L,396904L,85082276L,17784685668L,3593187600532L,705869301747600L,135694363620306878L,BigInteger.Parse("25624173177871048697"),BigInteger.Parse("4767151315360734509636"),BigInteger.Parse("875740097922120817127250"),BigInteger.Parse("159138454239119621136483037") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279304Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279304.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279304Inst Instance=new A279304Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279305
{
public static readonly long[] Value={ 0L,1L,1L,0L,0L,0L,3L,12L,12L,3L,6L,104L,498L,104L,6L,24L,872L,14908L,14908L,872L,24L,72L,8064L,396904L,1160588L,396904L,8064L,72L,232L,71680L,10073670L,85082276L,85082276L,10073670L,71680L,232L,720L,635312L,246262496L,6048938846L,17784685668L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279305Inst : IEnumerable<long>
{
public static readonly long[] Value=A279305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279305.Bytes);
public long this[int i]=>Value[i];

public static A279305Inst Instance=new A279305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279306
{
public static readonly BigInteger[] Value={ 1L,1L,13L,377L,2551L,97711L,1686481L,447824017L,2522468131L,22174988051L,7129179751261L,1852107834946547L,34648570480339663L,828888380086508653L,BigInteger.Parse("273996480127378324681"),BigInteger.Parse("462007733994120695494433"),BigInteger.Parse("308514276772559961052721"),BigInteger.Parse("38471181499444351991058251") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279306Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279306.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279306Inst Instance=new A279306Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279307
{
public static readonly BigInteger[] Value={ 0L,1L,1L,5L,137L,647L,22951L,328201L,26965819L,135880897L,37044323689L,91760237711L,250120070812867L,235374750708709L,38112363401091809L,1747698886011364219L,BigInteger.Parse("2880212454433162868027"),BigInteger.Parse("1444514603466022486187"),BigInteger.Parse("54349494835431693600323") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279307Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279307.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279307Inst Instance=new A279307Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279308
{
public static readonly BigInteger[] Value={ 2L,-1L,-23L,179L,15961L,-375481L,-77012099L,3667756091L,1363652668561L,-109208405349361L,-64265858394905339L,7770701878340584259L,BigInteger.Parse("6642366922974433027609"),BigInteger.Parse("-102726453588460111393691"),BigInteger.Parse("-1322873751136125749373458099"),BigInteger.Parse("15853417688720458694222368361") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279308Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279308.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279308Inst Instance=new A279308Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279309
{
public static readonly BigInteger[] Value={ 1L,2L,24L,720L,40320L,3628800L,479001600L,87178291200L,20922789888000L,6402373705728000L,2432902008176640000L,BigInteger.Parse("1124000727777607680000"),BigInteger.Parse("620448401733239439360000"),BigInteger.Parse("36662860102418694144000000"),BigInteger.Parse("304888344611713860501504000000"),BigInteger.Parse("13960676832220582033489920000000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279309Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279309.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279309Inst Instance=new A279309Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279310
{
public static readonly BigInteger[] Value={ 1L,1L,3L,5L,97L,157L,7619L,12329L,124121L,1807513L,263214179L,425890349L,90961797697L,29435864753L,1313384366851L,70128321031313L,2475709202997731L,44063598280490161L,BigInteger.Parse("21816698251120351811"),BigInteger.Parse("35300159324950341077"),BigInteger.Parse("7234801959635621099147"),BigInteger.Parse("2065792142493411347453") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279310Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279310.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279310Inst Instance=new A279310Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279311
{
public static readonly BigInteger[] Value={ 1L,1L,2L,2L,24L,24L,720L,720L,4480L,40320L,3628800L,3628800L,479001600L,95800320L,2641766400L,87178291200L,1902071808000L,20922789888000L,6402373705728000L,6402373705728000L,810967336058880000L,143111882833920000L,BigInteger.Parse("66117689869271040000"),13223537973854208000UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279311Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279311.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279311Inst Instance=new A279311Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279312
{
public static readonly long[] Value={ 1L,2L,4L,8L,12L,24L,40L,80L,128L,256L,416L,832L,1344L,2688L,4352L,8704L,14080L,28160L,45568L,91136L,147456L,294912L,477184L,954368L,1544192L,3088384L,4997120L,9994240L,16171008L,32342016L,52330496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279312Inst : IEnumerable<long>
{
public static readonly long[] Value=A279312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279312.Bytes);
public long this[int i]=>Value[i];

public static A279312Inst Instance=new A279312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279313
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,6L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L,6L,7L,6L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L,6L,7L,6L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L,6L,7L,6L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L,6L,7L,6L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L,6L,7L,6L,5L,4L,3L,2L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279313Inst : IEnumerable<long>
{
public static readonly long[] Value=A279313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279313.Bytes);
public long this[int i]=>Value[i];

public static A279313Inst Instance=new A279313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279314
{
public static readonly long[] Value={ 4L,22L,27L,58L,85L,94L,105L,114L,121L,150L,166L,202L,204L,222L,224L,265L,274L,315L,319L,342L,346L,355L,378L,382L,391L,438L,445L,450L,454L,483L,517L,526L,535L,540L,560L,562L,576L,588L,612L,627L,634L,636L,640L,645L,648L,654L,663L,666L,690L,697L,706L,728L,729L,762L,778L,825L,840L,841L,852L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279314Inst : IEnumerable<long>
{
public static readonly long[] Value=A279314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279314.Bytes);
public long this[int i]=>Value[i];

public static A279314Inst Instance=new A279314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279315
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,2L,1L,0L,6L,0L,1L,12L,1L,0L,12L,0L,1L,6L,1L,0L,2L,0L,1L,0L,0L,2L,0L,0L,1L,30L,1L,0L,0L,2L,0L,0L,1L,0L,2L,0L,1L,12L,1L,0L,2L,0L,1L,0L,0L,2L,0L,0L,4L,0L,0L,2L,0L,0L,1L,6L,1L,0L,0L,2L,0L,0L,1L,0L,2L,0L,1L,2L,1L,0L,0L,2L,0L,0L,1L,0L,6L,0L,1L,0L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279315Inst : IEnumerable<long>
{
public static readonly long[] Value=A279315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279315.Bytes);
public long this[int i]=>Value[i];

public static A279315Inst Instance=new A279315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279316
{
public static readonly long[] Value={ 0L,1L,2L,3L,3L,2L,1L,0L,1L,2L,3L,3L,2L,1L,0L,1L,2L,3L,3L,2L,1L,0L,1L,2L,3L,3L,2L,1L,0L,1L,2L,3L,3L,2L,1L,0L,1L,2L,3L,3L,2L,1L,0L,1L,2L,3L,3L,2L,1L,0L,1L,2L,3L,3L,2L,1L,0L,1L,2L,3L,3L,2L,1L,0L,1L,2L,3L,3L,2L,1L,0L,1L,2L,3L,3L,2L,1L,0L,1L,2L,3L,3L,2L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279316Inst : IEnumerable<long>
{
public static readonly long[] Value=A279316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279316.Bytes);
public long this[int i]=>Value[i];

public static A279316Inst Instance=new A279316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279317
{
public static readonly long[] Value={ 2L,3L,4L,5L,5L,5L,7L,7L,6L,6L,7L,7L,7L,7L,7L,8L,8L,7L,9L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,8L,9L,9L,9L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,10L,9L,9L,10L,9L,10L,9L,10L,10L,10L,10L,9L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,11L,10L,10L,10L,10L,10L,10L,10L,11L,11L,10L,10L,10L,10L,10L,10L,11L,10L,11L,10L,11L,10L,11L,11L,11L,11L,10L,11L,11L,11L,11L,11L,11L,11L,11L,10L,11L,11L,11L,11L,11L,11L,11L,11L,12L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,12L,11L,11L,12L,12L,11L,11L,12L,11L,11L,11L,11L,11L,11L,11L,12L,11L,12L,11L,11L,12L,12L,12L,12L,11L,11L,11L,11L,11L,12L,12L,12L,12L,12L,11L,12L,12L,12L,12L,12L,12L,11L,12L,12L,12L,12L,12L,12L,12L,12L,11L,12L,12L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279317Inst : IEnumerable<long>
{
public static readonly long[] Value=A279317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279317.Bytes);
public long this[int i]=>Value[i];

public static A279317Inst Instance=new A279317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279318
{
public static readonly long[] Value={ 3L,2L,1L,0L,5L,4L,9L,8L,7L,6L,11L,10L,15L,14L,13L,12L,17L,16L,21L,20L,19L,18L,23L,22L,27L,26L,25L,24L,29L,28L,33L,32L,31L,30L,35L,34L,39L,38L,37L,36L,41L,40L,45L,44L,43L,42L,47L,46L,51L,50L,49L,48L,53L,52L,57L,56L,55L,54L,59L,58L,63L,62L,61L,60L,65L,64L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279318Inst : IEnumerable<long>
{
public static readonly long[] Value=A279318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279318.Bytes);
public long this[int i]=>Value[i];

public static A279318Inst Instance=new A279318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279319
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,7L,6L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L,6L,7L,8L,7L,6L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L,6L,7L,8L,7L,6L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L,6L,7L,8L,7L,6L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L,6L,7L,8L,7L,6L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279319Inst : IEnumerable<long>
{
public static readonly long[] Value=A279319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279319.Bytes);
public long this[int i]=>Value[i];

public static A279319Inst Instance=new A279319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279320
{
public static readonly long[] Value={ 1L,2L,4L,8L,15L,26L,45L,74L,119L,188L,291L,442L,664L,982L,1435L,2076L,2972L,4214L,5929L,8272L,11457L,15762L,21543L,29264L,39532L,53110L,70988L,94430L,125033L,164826L,216388L,282940L,368552L,478326L,618621L,797376L,1024485L,1312184L,1675657L,2133664L,2709307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279320Inst : IEnumerable<long>
{
public static readonly long[] Value=A279320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279320.Bytes);
public long this[int i]=>Value[i];

public static A279320Inst Instance=new A279320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279321
{
public static readonly long[] Value={ 1L,3L,5L,7L,5L,3L,1L,1L,3L,5L,7L,5L,3L,1L,1L,3L,5L,7L,5L,3L,1L,1L,3L,5L,7L,5L,3L,1L,1L,3L,5L,7L,5L,3L,1L,1L,3L,5L,7L,5L,3L,1L,1L,3L,5L,7L,5L,3L,1L,1L,3L,5L,7L,5L,3L,1L,1L,3L,5L,7L,5L,3L,1L,1L,3L,5L,7L,5L,3L,1L,1L,3L,5L,7L,5L,3L,1L,1L,3L,5L,7L,5L,3L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279321Inst : IEnumerable<long>
{
public static readonly long[] Value=A279321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279321.Bytes);
public long this[int i]=>Value[i];

public static A279321Inst Instance=new A279321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279322
{
public static readonly long[] Value={ 0L,0L,2L,4L,14L,40L,120L,352L,1032L,3008L,8736L,25280L,72928L,209792L,601984L,1723392L,4923520L,14039040L,39961088L,113562624L,322244096L,913131520L,2584180736L,7304519680L,20624050176L,58170228736L,163908034560L,461421658112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279322Inst : IEnumerable<long>
{
public static readonly long[] Value=A279322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279322.Bytes);
public long this[int i]=>Value[i];

public static A279322Inst Instance=new A279322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279323
{
public static readonly long[] Value={ 0L,0L,16L,152L,1536L,13776L,118664L,991616L,8109024L,65252928L,518482400L,4077987584L,31806458880L,246337686272L,1896480302208L,14525403049984L,110754291988992L,841167574029312L,6366346796688896L,48033932904861696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279323Inst : IEnumerable<long>
{
public static readonly long[] Value=A279323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279323.Bytes);
public long this[int i]=>Value[i];

public static A279323Inst Instance=new A279323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279324
{
public static readonly BigInteger[] Value={ 2L,16L,664L,16092L,384180L,8854880L,198179722L,4349449420L,94030021118L,2008611971608L,42492470600304L,891738728583352L,18587655574241802L,385215213233213336L,7943580006341736164L,BigInteger.Parse("163094668708824004640") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279324Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279324.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279324Inst Instance=new A279324Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279325
{
public static readonly BigInteger[] Value={ 4L,152L,16092L,1079496L,73482624L,4808164964L,306703795184L,19222109104916L,1188030883493336L,72617186989640484L,4398603121620447184L,BigInteger.Parse("264429528141568309808"),BigInteger.Parse("15795365086572335762648"),BigInteger.Parse("938361558760361783247456") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279325Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279325.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279325Inst Instance=new A279325Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279326
{
public static readonly BigInteger[] Value={ 14L,1536L,384180L,73482624L,14012963052L,2584102824124L,466109368455794L,82744054801910960L,14503439952632629506UL,BigInteger.Parse("2516357633645951591394"),BigInteger.Parse("432933326123199883041053"),BigInteger.Parse("73961585610555344923223918") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279326Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279326.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279326Inst Instance=new A279326Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279327
{
public static readonly long[] Value={ 0L,0L,0L,2L,0L,2L,4L,16L,16L,4L,14L,152L,664L,152L,14L,40L,1536L,16092L,16092L,1536L,40L,120L,13776L,384180L,1079496L,384180L,13776L,120L,352L,118664L,8854880L,73482624L,73482624L,8854880L,118664L,352L,1032L,991616L,198179722L,4808164964L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279327Inst : IEnumerable<long>
{
public static readonly long[] Value=A279327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279327.Bytes);
public long this[int i]=>Value[i];

public static A279327Inst Instance=new A279327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279328
{
public static readonly long[] Value={ 1L,1L,3L,4L,8L,11L,20L,27L,44L,60L,92L,124L,183L,244L,348L,461L,640L,840L,1144L,1488L,1992L,2572L,3393L,4348L,5668L,7212L,9301L,11760L,15024L,18880L,23924L,29892L,37596L,46728L,58376L,72193L,89644L,110340L,136248L,166968L,205115L,250316L,306056L,372032L,452876L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279328Inst : IEnumerable<long>
{
public static readonly long[] Value=A279328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279328.Bytes);
public long this[int i]=>Value[i];

public static A279328Inst Instance=new A279328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279329
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279329Inst : IEnumerable<long>
{
public static readonly long[] Value=A279329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279329.Bytes);
public long this[int i]=>Value[i];

public static A279329Inst Instance=new A279329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279330
{
public static readonly BigInteger[] Value={ 1L,1L,37L,1469L,28885L,20402009L,4408834189L,1292545686613L,502788842162641L,3827352937332721L,11769223393753084937UL,BigInteger.Parse("6727141824232920032413"),BigInteger.Parse("6008596848623061712518761"),BigInteger.Parse("107427869448375950953038643849"),BigInteger.Parse("26282017131399910370907288078329") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279330Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279330.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279330Inst Instance=new A279330Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279331
{
public static readonly BigInteger[] Value={ 1L,2L,24L,720L,8064L,3628800L,479001600L,87178291200L,20922789888000L,98498057011200L,187146308321280000L,BigInteger.Parse("66117689869271040000"),BigInteger.Parse("36496964807837614080000"),BigInteger.Parse("403291461126605635584000000"),BigInteger.Parse("60977668922342772100300800000"),BigInteger.Parse("13960676832220582033489920000000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279331Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279331.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279331Inst Instance=new A279331Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279332
{
public static readonly BigInteger[] Value={ 0L,1L,1L,11L,17L,187L,901L,61403L,19849L,11566657L,18712297L,1110228313L,5389037609L,1360276717489L,2200966584493L,747861093416219L,1210064076159749L,59172849569407033L,34467722993604601L,BigInteger.Parse("476833062569954186123"),BigInteger.Parse("771532094165273524673"),BigInteger.Parse("524313365828795638534321") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279332Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279332.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279332Inst Instance=new A279332Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279333
{
public static readonly BigInteger[] Value={ 1L,1L,1L,6L,6L,40L,120L,5040L,1008L,362880L,362880L,13305600L,39916800L,6227020800L,6227020800L,1307674368000L,1307674368000L,39520825344000L,14227497123840L,121645100408832000L,121645100408832000L,BigInteger.Parse("51090942171709440000"),BigInteger.Parse("51090942171709440000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279333Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279333.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279333Inst Instance=new A279333Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279334
{
public static readonly BigInteger[] Value={ 1L,2L,7L,17L,221L,893L,17347L,98221L,2542969L,2645039L,599172671L,5332129721L,207061905877L,2177714624677L,98661276360571L,1197279643886453L,8855950704414791L,5962161748599967L,BigInteger.Parse("49662655090649112439"),BigInteger.Parse("69398245985290595843"),BigInteger.Parse("2906296303998501464573") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279334Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279334.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279334Inst Instance=new A279334Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279335
{
public static readonly BigInteger[] Value={ 1L,1L,2L,3L,24L,60L,720L,2520L,40320L,25920L,3628800L,19958400L,479001600L,3113510400L,87178291200L,653837184000L,2988969984000L,1243662336000L,6402373705728000L,5529322745856000L,143111882833920000L,115590366904320000L,BigInteger.Parse("1124000727777607680000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279335Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279335.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279335Inst Instance=new A279335Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279336
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,6L,7L,9L,8L,15L,11L,10L,12L,14L,25L,27L,16L,35L,13L,18L,20L,21L,45L,22L,33L,49L,24L,26L,28L,30L,125L,81L,32L,77L,17L,34L,36L,75L,63L,38L,55L,175L,40L,42L,44L,39L,65L,46L,121L,135L,48L,50L,51L,99L,52L,105L,343L,54L,56L,58L,60L,62L,625L,243L,64L,143L,19L,66L,68L,57L,225L,70L,245L,275L,72L,74L,76L,69L,91L,78L,539L,189L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279336Inst : IEnumerable<long>
{
public static readonly long[] Value=A279336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279336.Bytes);
public long this[int i]=>Value[i];

public static A279336Inst Instance=new A279336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279337
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,6L,7L,9L,8L,12L,11L,13L,19L,14L,10L,17L,35L,20L,67L,21L,22L,24L,131L,27L,15L,28L,16L,29L,259L,30L,515L,33L,25L,36L,18L,37L,1027L,40L,46L,43L,2051L,44L,4099L,45L,23L,48L,8195L,51L,26L,52L,53L,55L,16387L,58L,41L,59L,70L,60L,32771L,61L,65539L,62L,39L,65L,47L,68L,131075L,69L,78L,72L,262147L,75L,524291L,76L,38L,77L,34L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279337Inst : IEnumerable<long>
{
public static readonly long[] Value=A279337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279337.Bytes);
public long this[int i]=>Value[i];

public static A279337Inst Instance=new A279337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279338
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,6L,7L,9L,10L,15L,11L,8L,12L,14L,25L,21L,18L,35L,13L,20L,30L,27L,45L,22L,33L,49L,16L,24L,28L,50L,55L,75L,42L,77L,17L,36L,70L,63L,105L,26L,125L,175L,40L,60L,54L,39L,65L,90L,121L,81L,44L,66L,135L,99L,98L,147L,91L,32L,48L,56L,100L,110L,245L,165L,150L,143L,19L,84L,154L,225L,231L,34L,275L,385L,72L,140L,126L,51L,343L,210L,539L,189L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279338Inst : IEnumerable<long>
{
public static readonly long[] Value=A279338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279338.Bytes);
public long this[int i]=>Value[i];

public static A279338Inst Instance=new A279338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279339
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,6L,7L,12L,8L,9L,11L,13L,19L,14L,10L,27L,35L,17L,67L,20L,16L,24L,131L,28L,15L,40L,22L,29L,259L,21L,515L,58L,25L,72L,18L,36L,1027L,136L,46L,43L,2051L,33L,4099L,51L,23L,264L,8195L,59L,26L,30L,78L,83L,16387L,45L,31L,60L,142L,520L,32771L,44L,65539L,1032L,38L,121L,47L,52L,131075L,147L,270L,37L,262147L,75L,524291L,2056L,32L,275L,34L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279339Inst : IEnumerable<long>
{
public static readonly long[] Value=A279339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279339.Bytes);
public long this[int i]=>Value[i];

public static A279339Inst Instance=new A279339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279340
{
public static readonly long[] Value={ 3L,1L,3L,3L,1L,1L,3L,3L,1L,3L,3L,1L,1L,1L,3L,3L,1L,3L,3L,1L,1L,3L,3L,1L,3L,3L,1L,1L,1L,1L,3L,3L,1L,3L,3L,1L,1L,3L,3L,1L,3L,3L,1L,1L,1L,3L,3L,1L,3L,3L,1L,1L,3L,3L,1L,3L,3L,1L,1L,1L,1L,1L,3L,3L,1L,3L,3L,1L,1L,3L,3L,1L,3L,3L,1L,1L,1L,3L,3L,1L,3L,3L,1L,1L,3L,3L,1L,3L,3L,1L,1L,1L,1L,3L,3L,1L,3L,3L,1L,1L,3L,3L,1L,3L,3L,1L,1L,1L,3L,3L,1L,3L,3L,1L,1L,3L,3L,1L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279340Inst : IEnumerable<long>
{
public static readonly long[] Value=A279340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279340.Bytes);
public long this[int i]=>Value[i];

public static A279340Inst Instance=new A279340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279341
{
public static readonly long[] Value={ 0L,1L,3L,7L,2L,6L,15L,5L,14L,13L,31L,4L,12L,30L,11L,29L,10L,27L,63L,28L,26L,9L,25L,62L,61L,23L,8L,24L,60L,22L,59L,21L,58L,55L,127L,20L,54L,57L,53L,126L,19L,51L,56L,52L,18L,125L,123L,50L,47L,17L,124L,122L,49L,121L,46L,45L,119L,16L,48L,120L,44L,118L,43L,117L,42L,111L,255L,116L,110L,41L,109L,254L,115L,107L,40L,108L,114L,253L,39L,106L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279341Inst : IEnumerable<long>
{
public static readonly long[] Value=A279341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279341.Bytes);
public long this[int i]=>Value[i];

public static A279341Inst Instance=new A279341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279342
{
public static readonly long[] Value={ 1L,2L,5L,3L,12L,8L,6L,4L,27L,22L,17L,15L,13L,10L,9L,7L,58L,50L,45L,41L,36L,32L,30L,26L,28L,23L,21L,18L,20L,16L,14L,11L,121L,112L,103L,97L,92L,86L,84L,79L,75L,70L,65L,63L,61L,56L,55L,49L,59L,53L,48L,42L,44L,39L,37L,34L,43L,38L,33L,31L,29L,25L,24L,19L,248L,237L,227L,221L,210L,201L,196L,191L,187L,180L,175L,168L,171L,165L,160L,153L,154L,146L,141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279342Inst : IEnumerable<long>
{
public static readonly long[] Value=A279342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279342.Bytes);
public long this[int i]=>Value[i];

public static A279342Inst Instance=new A279342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279343
{
public static readonly long[] Value={ 0L,1L,2L,4L,3L,5L,8L,6L,9L,10L,16L,7L,11L,17L,12L,18L,13L,20L,32L,19L,21L,14L,22L,33L,34L,24L,15L,23L,35L,25L,36L,26L,37L,40L,64L,27L,41L,38L,42L,65L,28L,44L,39L,43L,29L,66L,68L,45L,48L,30L,67L,69L,46L,70L,49L,50L,72L,31L,47L,71L,51L,73L,52L,74L,53L,80L,128L,75L,81L,54L,82L,129L,76L,84L,55L,83L,77L,130L,56L,85L,88L,78L,131L,57L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279343Inst : IEnumerable<long>
{
public static readonly long[] Value=A279343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279343.Bytes);
public long this[int i]=>Value[i];

public static A279343Inst Instance=new A279343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279344
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,6L,8L,12L,7L,9L,10L,13L,15L,17L,22L,27L,11L,14L,16L,20L,18L,21L,23L,28L,26L,30L,32L,36L,41L,45L,50L,58L,19L,24L,25L,29L,31L,33L,38L,43L,34L,37L,39L,44L,42L,48L,53L,59L,49L,55L,56L,61L,63L,65L,70L,75L,79L,84L,86L,92L,97L,103L,112L,121L,35L,40L,46L,51L,47L,52L,54L,60L,57L,62L,64L,68L,73L,77L,82L,90L,66L,69L,71L,76L,74L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279344Inst : IEnumerable<long>
{
public static readonly long[] Value=A279344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279344.Bytes);
public long this[int i]=>Value[i];

public static A279344Inst Instance=new A279344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279345
{
public static readonly long[] Value={ 0L,1L,2L,3L,1L,2L,4L,2L,3L,3L,5L,1L,2L,4L,3L,4L,2L,4L,6L,3L,3L,2L,3L,5L,5L,4L,1L,2L,4L,3L,5L,3L,4L,5L,7L,2L,4L,4L,4L,6L,3L,4L,3L,3L,2L,6L,6L,3L,5L,2L,5L,5L,3L,5L,4L,4L,6L,1L,2L,4L,3L,5L,4L,5L,3L,6L,8L,4L,5L,3L,5L,7L,5L,5L,2L,4L,4L,7L,4L,4L,5L,4L,6L,3L,4L,3L,4L,7L,7L,3L,3L,2L,6L,4L,6L,6L,3L,6L,3L,5L,6L,4L,2L,6L,5L,5L,5L,3L,5L,7L,5L,2L,3L,4L,4L,5L,4L,6L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279345Inst : IEnumerable<long>
{
public static readonly long[] Value=A279345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279345.Bytes);
public long this[int i]=>Value[i];

public static A279345Inst Instance=new A279345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279346
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,1L,2L,2L,2L,1L,3L,3L,2L,2L,2L,3L,2L,1L,3L,3L,3L,3L,2L,2L,2L,4L,4L,3L,3L,2L,3L,3L,2L,1L,4L,3L,3L,3L,2L,3L,3L,4L,4L,4L,2L,2L,4L,2L,4L,3L,3L,4L,3L,3L,3L,2L,5L,5L,4L,4L,3L,3L,3L,4L,2L,1L,4L,3L,4L,3L,2L,3L,3L,5L,4L,4L,2L,3L,4L,3L,4L,3L,4L,4L,4L,4L,2L,2L,5L,5L,5L,3L,4L,2L,3L,4L,3L,5L,3L,3L,4L,5L,3L,3L,4L,4L,5L,3L,2L,4L,5L,5L,4L,4L,4L,4L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279346Inst : IEnumerable<long>
{
public static readonly long[] Value=A279346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279346.Bytes);
public long this[int i]=>Value[i];

public static A279346Inst Instance=new A279346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279347
{
public static readonly long[] Value={ 1L,2L,5L,12L,3L,8L,27L,6L,22L,17L,58L,4L,15L,50L,13L,45L,10L,36L,121L,41L,32L,9L,30L,112L,103L,28L,7L,26L,97L,23L,92L,21L,86L,75L,248L,18L,70L,84L,65L,237L,20L,61L,79L,63L,16L,227L,210L,56L,59L,14L,221L,201L,55L,196L,53L,48L,187L,11L,49L,191L,42L,180L,44L,175L,39L,154L,503L,168L,146L,37L,141L,491L,171L,132L,34L,137L,165L,478L,43L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279347Inst : IEnumerable<long>
{
public static readonly long[] Value=A279347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279347.Bytes);
public long this[int i]=>Value[i];

public static A279347Inst Instance=new A279347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279348
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,6L,7L,9L,10L,15L,11L,8L,12L,14L,25L,27L,18L,35L,13L,20L,30L,21L,33L,22L,39L,49L,16L,24L,28L,50L,65L,51L,54L,77L,17L,36L,70L,57L,87L,26L,55L,85L,40L,60L,42L,63L,95L,66L,121L,45L,44L,78L,69L,81L,98L,147L,119L,32L,48L,56L,100L,130L,125L,159L,102L,143L,19L,108L,154L,105L,207L,34L,145L,215L,72L,140L,114L,75L,91L,174L,133L,117L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279348Inst : IEnumerable<long>
{
public static readonly long[] Value=A279348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279348.Bytes);
public long this[int i]=>Value[i];

public static A279348Inst Instance=new A279348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279349
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,6L,7L,12L,8L,9L,11L,13L,19L,14L,10L,27L,35L,17L,67L,20L,22L,24L,131L,28L,15L,40L,16L,29L,259L,21L,515L,58L,23L,72L,18L,36L,1027L,136L,25L,43L,2051L,45L,4099L,51L,50L,264L,8195L,59L,26L,30L,32L,83L,16387L,33L,41L,60L,38L,520L,32771L,44L,65539L,1032L,46L,121L,31L,48L,131075L,147L,53L,37L,262147L,75L,524291L,2056L,78L,275L,34L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279349Inst : IEnumerable<long>
{
public static readonly long[] Value=A279349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279349.Bytes);
public long this[int i]=>Value[i];

public static A279349Inst Instance=new A279349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279350
{
public static readonly long[] Value={ 1L,2L,4L,2L,8L,6L,16L,2L,4L,12L,32L,6L,64L,24L,12L,2L,128L,6L,256L,12L,4L,48L,512L,6L,8L,96L,36L,24L,1024L,30L,2048L,2L,12L,192L,24L,6L,4096L,384L,72L,12L,8192L,60L,16384L,48L,4L,768L,32768L,6L,16L,12L,12L,96L,65536L,6L,8L,24L,36L,1536L,131072L,30L,262144L,3072L,144L,2L,72L,120L,524288L,192L,12L,60L,1048576L,6L,2097152L,6144L,288L,384L,48L,240L,4194304L,12L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279350Inst : IEnumerable<long>
{
public static readonly long[] Value=A279350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279350.Bytes);
public long this[int i]=>Value[i];

public static A279350Inst Instance=new A279350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279351
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,6L,16L,5L,9L,12L,32L,10L,64L,24L,18L,7L,128L,15L,256L,20L,36L,48L,512L,14L,21L,96L,25L,40L,1024L,30L,2048L,11L,72L,192L,54L,27L,4096L,384L,144L,28L,8192L,60L,16384L,80L,50L,768L,32768L,22L,45L,33L,288L,160L,65536L,35L,108L,56L,576L,1536L,131072L,42L,262144L,3072L,100L,13L,216L,120L,524288L,320L,1152L,90L,1048576L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279351Inst : IEnumerable<long>
{
public static readonly long[] Value=A279351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279351.Bytes);
public long this[int i]=>Value[i];

public static A279351Inst Instance=new A279351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279352
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,6L,16L,5L,9L,12L,32L,10L,64L,24L,18L,7L,128L,15L,256L,20L,25L,48L,512L,14L,27L,96L,36L,40L,1024L,30L,2048L,11L,50L,192L,54L,21L,4096L,384L,72L,28L,8192L,60L,16384L,80L,49L,768L,32768L,22L,81L,45L,75L,160L,65536L,35L,125L,56L,100L,1536L,131072L,42L,262144L,3072L,144L,13L,108L,120L,524288L,320L,98L,90L,1048576L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279352Inst : IEnumerable<long>
{
public static readonly long[] Value=A279352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279352.Bytes);
public long this[int i]=>Value[i];

public static A279352Inst Instance=new A279352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279353
{
public static readonly long[] Value={ 7L,3L,15L,5L,1L,3L,31L,5L,1L,13L,3L,7L,1L,3L,63L,5L,1L,13L,3L,7L,1L,29L,3L,7L,3L,13L,1L,7L,1L,3L,127L,5L,1L,13L,3L,7L,1L,29L,3L,7L,3L,13L,1L,7L,1L,61L,3L,7L,3L,13L,1L,7L,3L,29L,1L,5L,15L,3L,1L,7L,1L,3L,255L,5L,1L,13L,3L,7L,1L,29L,3L,7L,3L,13L,1L,7L,1L,61L,3L,7L,3L,13L,1L,7L,3L,29L,1L,5L,15L,3L,1L,7L,1L,125L,3L,7L,3L,13L,1L,7L,3L,29L,1L,5L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279353Inst : IEnumerable<long>
{
public static readonly long[] Value=A279353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279353.Bytes);
public long this[int i]=>Value[i];

public static A279353Inst Instance=new A279353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279354
{
public static readonly long[] Value={ 1L,2L,4L,2L,8L,4L,16L,2L,6L,8L,32L,4L,64L,16L,12L,2L,128L,6L,256L,8L,6L,32L,512L,4L,12L,64L,24L,16L,1024L,12L,2048L,2L,12L,128L,36L,6L,4096L,256L,48L,8L,8192L,24L,16384L,32L,6L,512L,32768L,4L,24L,12L,30L,64L,65536L,6L,12L,16L,24L,1024L,131072L,12L,262144L,2048L,96L,2L,72L,48L,524288L,128L,12L,36L,1048576L,6L,2097152L,4096L,192L,256L,72L,96L,4194304L,8L,48L,8192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279354Inst : IEnumerable<long>
{
public static readonly long[] Value=A279354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279354.Bytes);
public long this[int i]=>Value[i];

public static A279354Inst Instance=new A279354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279355
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,9L,16L,5L,6L,21L,32L,25L,64L,45L,18L,7L,128L,15L,256L,55L,54L,93L,512L,49L,12L,189L,10L,115L,1024L,51L,2048L,11L,162L,381L,36L,35L,4096L,765L,486L,91L,8192L,159L,16384L,235L,50L,1533L,32768L,121L,24L,33L,1458L,475L,65536L,27L,108L,203L,4374L,3069L,131072L,125L,262144L,6141L,250L,13L,324L,483L,524288L,955L,13122L,105L,1048576L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279355Inst : IEnumerable<long>
{
public static readonly long[] Value=A279355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279355.Bytes);
public long this[int i]=>Value[i];

public static A279355Inst Instance=new A279355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279356
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,9L,16L,5L,6L,27L,32L,25L,64L,81L,18L,7L,128L,15L,256L,125L,10L,243L,512L,49L,12L,729L,54L,625L,1024L,75L,2048L,11L,50L,2187L,36L,35L,4096L,6561L,162L,343L,8192L,375L,16384L,3125L,14L,19683L,32768L,121L,24L,45L,30L,15625L,65536L,21L,20L,2401L,250L,59049L,131072L,245L,262144L,177147L,486L,13L,108L,1875L,524288L,78125L,98L,225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279356Inst : IEnumerable<long>
{
public static readonly long[] Value=A279356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279356.Bytes);
public long this[int i]=>Value[i];

public static A279356Inst Instance=new A279356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279357
{
public static readonly long[] Value={ 1L,2L,7L,3L,15L,2L,1L,4L,31L,2L,1L,5L,1L,14L,3L,5L,63L,2L,1L,5L,1L,14L,3L,4L,1L,30L,3L,7L,3L,14L,1L,6L,127L,2L,1L,5L,1L,14L,3L,4L,1L,30L,3L,7L,3L,14L,1L,7L,1L,62L,3L,7L,3L,14L,1L,4L,3L,30L,1L,5L,1L,2L,15L,7L,255L,2L,1L,5L,1L,14L,3L,4L,1L,30L,3L,7L,3L,14L,1L,7L,1L,62L,3L,7L,3L,14L,1L,4L,3L,30L,1L,5L,1L,2L,15L,6L,1L,126L,3L,7L,3L,14L,1L,4L,3L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279357Inst : IEnumerable<long>
{
public static readonly long[] Value=A279357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279357.Bytes);
public long this[int i]=>Value[i];

public static A279357Inst Instance=new A279357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279358
{
public static readonly BigInteger[] Value={ 1L,1L,9L,52L,413L,3916L,41077L,481384L,6198425L,86430160L,1296040841L,20763245944L,353272341061L,6353672109760L,120315348389069L,2390488408994536L,49682962883210033L,1077292416660660736L,BigInteger.Parse("24313317132393295633"),BigInteger.Parse("569937590287796925784"),BigInteger.Parse("13850459183086300341341") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279358Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279358.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279358Inst Instance=new A279358Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279359
{
public static readonly long[] Value={ 2L,4L,10L,18L,36L,62L,90L,902L,1214L,2936L,3436L,325726L,378646L,646840L,5432174L,273222344L,285775216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279359Inst : IEnumerable<long>
{
public static readonly long[] Value=A279359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279359.Bytes);
public long this[int i]=>Value[i];

public static A279359Inst Instance=new A279359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279360
{
public static readonly long[] Value={ 1L,2L,0L,0L,2L,4L,0L,0L,0L,2L,4L,0L,0L,4L,8L,0L,2L,4L,0L,0L,4L,8L,0L,0L,0L,6L,12L,0L,0L,12L,24L,0L,0L,0L,4L,8L,2L,4L,8L,16L,4L,12L,8L,0L,0L,12L,24L,0L,0L,10L,28L,16L,4L,12L,24L,32L,8L,16L,4L,8L,0L,12L,32L,16L,2L,32L,56L,0L,4L,16L,24L,16L,0L,4L,36L,56L,0L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279360Inst : IEnumerable<long>
{
public static readonly long[] Value=A279360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279360.Bytes);
public long this[int i]=>Value[i];

public static A279360Inst Instance=new A279360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279361
{
public static readonly BigInteger[] Value={ 1L,1L,4L,16L,80L,471L,3127L,23059L,186468L,1635265L,15422471L,155388399L,1663294756L,18826525771L,224434810797L,2808247979611L,36770685485408L,502505495269521L,7150461569849395L,105723461155720879L,1621191824611307436L,BigInteger.Parse("25738508587975433251") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279361Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279361.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279361Inst Instance=new A279361Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}