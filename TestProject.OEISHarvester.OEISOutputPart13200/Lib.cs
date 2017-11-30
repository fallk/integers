using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A091784
{
public static readonly long[] Value={ 1L,11L,22L,111L,122L,236L,244L,333L,1111L,1122L,1236L,1244L,1333L,2222L,2488L,2666L,3366L,3446L,4444L,11111L,11122L,11236L,11244L,11333L,12222L,12488L,12666L,13366L,13446L,14444L,22236L,22244L,22333L,26999L,28888L,33999L,34688L,36666L,44488L,44666L,55555L,111111L,111122L };
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
public class A091784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091784Inst : IEnumerable<long>
{
public static readonly long[] Value=A091784.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091784.Bytes);
public long this[int i]=>Value[i];

public static A091784Inst Instance=new A091784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091783
{
public static readonly long[] Value={ 1L,22L,236L,244L,333L,2488L,2666L,3366L,3446L,4444L,26999L,28888L,33999L,34688L,36666L,44488L,44666L,55555L,366999L,368888L,446999L,448888L,466688L,666666L,3999999L,4688999L,4888888L,6666999L,6668888L,7777777L,66999999L,68888999L,88888888L,999999999L };
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
public class A091783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091783Inst : IEnumerable<long>
{
public static readonly long[] Value=A091783.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091783.Bytes);
public long this[int i]=>Value[i];

public static A091783Inst Instance=new A091783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091782
{
public static readonly BigInteger[] Value={ 1L,1L,12L,1124L,11122248L,1112112422244496L,BigInteger.Parse("11121124111222482224224844488992"),BigInteger.Parse("1112112411122248111211242224449622242248222444964448449688977984") };
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
public class A091782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091782Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A091782.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091782.Bytes);
public BigInteger this[int i]=>Value[i];

public static A091782Inst Instance=new A091782Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091781
{
public static readonly BigInteger[] Value={ 1L,1L,13L,1252L,12396260L,1239500874377560L,BigInteger.Parse("12395008619813008676506120642920"),BigInteger.Parse("1239500861981300743700524626536099160068958504069412048965143360"),BigInteger.Parse("12395008619813007437005246265360867650603386910607355428445004411155507757831706693304721638824892440620626536624708440686290240") };
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
public class A091781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091781Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A091781.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091781.Bytes);
public BigInteger this[int i]=>Value[i];

public static A091781Inst Instance=new A091781Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091780
{
public static readonly long[] Value={ 3L,6L,9L,12L,15L,10L,5L,20L,25L,30L,21L,14L,7L,28L,35L,40L,45L,18L,27L,24L,33L,22L,11L,44L,55L,50L,65L,26L,13L,52L,39L,36L,51L,34L,17L,68L,85L,60L,57L,38L,19L,76L,95L,70L,49L,42L,63L,48L,69L,46L,23L,92L,115L,80L,75L,54L,81L,66L,77L,56L,91L,78L,87L,58L,29L,116L,145L,90L,93L,62L };
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
public class A091780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091780Inst : IEnumerable<long>
{
public static readonly long[] Value=A091780.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091780.Bytes);
public long this[int i]=>Value[i];

public static A091780Inst Instance=new A091780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091747
{
public static readonly long[] Value={ 1L,42L,14L,1L,5544L,3192L,588L,42L,1L,1507968L,1165248L,321552L,41496L,2688L,84L,1L,696681216L,655966080L,232606080L,41497344L,4143552L,240240L,7980L,140L,1L,489070213632L,533531142144L,226306918656L,50249808000L,6575950080L };
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
public class A091747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091747Inst : IEnumerable<long>
{
public static readonly long[] Value=A091747.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091747.Bytes);
public long this[int i]=>Value[i];

public static A091747Inst Instance=new A091747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091746
{
public static readonly long[] Value={ 1L,30L,12L,1L,2700L,1920L,426L,36L,1L,491400L,478800L,162540L,25344L,1956L,72L,1L,150368400L,181440000L,80451000L,17624880L,2130660L,147840L,5820L,120L,1L,69470200800L,98424849600L,52905560400L,14618016000L,2346624000L,232202880L };
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
public class A091746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091746Inst : IEnumerable<long>
{
public static readonly long[] Value=A091746.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091746.Bytes);
public long this[int i]=>Value[i];

public static A091746Inst Instance=new A091746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091745
{
public static readonly BigInteger[] Value={ 1L,0L,-12L,240L,7056L,-1472640L,60785472L,24634471680L,-6666732039936L,-266945607045120L,818181307311879168L,BigInteger.Parse("-225753930347735961600"),BigInteger.Parse("-114700401016766429097984"),BigInteger.Parse("133755245359458345703342080") };
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
public class A091745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091745Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A091745.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091745.Bytes);
public BigInteger this[int i]=>Value[i];

public static A091745Inst Instance=new A091745Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091744
{
public static readonly BigInteger[] Value={ 25L,9684L,2263474L,490886452L,111812888083L,27999019489624L,7844432790401028L,2473024180429410040L,BigInteger.Parse("877529810239038245325"),BigInteger.Parse("349669921564112871530060"),BigInteger.Parse("155914953071171948587819830"),BigInteger.Parse("77481281483613804213513143564") };
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
public class A091744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091744Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A091744.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091744.Bytes);
public BigInteger this[int i]=>Value[i];

public static A091744Inst Instance=new A091744Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091743
{
public static readonly BigInteger[] Value={ 1L,131L,12702L,1331426L,163594663L,23979017805L,4187448766444L,864808560876788L,209300424292684605L,BigInteger.Parse("58811116750666789895"),BigInteger.Parse("19017126570296402361706"),BigInteger.Parse("7018937700334256743262646") };
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
public class A091743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091743Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A091743.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091743.Bytes);
public BigInteger this[int i]=>Value[i];

public static A091743Inst Instance=new A091743Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091742
{
public static readonly BigInteger[] Value={ 1L,26L,775L,32516L,1894429L,148008446L,15005570563L,1920091871816L,303034557325177L,57867367557774626L,13156672434190398271UL,BigInteger.Parse("3513034745241511676876"),BigInteger.Parse("1088776741031904909773845") };
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
public class A091742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091742Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A091742.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091742.Bytes);
public BigInteger this[int i]=>Value[i];

public static A091742Inst Instance=new A091742Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091741
{
public static readonly long[] Value={ 1L,4L,1L,-36L,8L,9L,1L,-288L,18L,83L,18L,1L,7200L,-2352L,-2366L,165L,205L,27L,1L,86400L,-18000L,-31936L,-926L,2735L,565L,41L,1L,-4233600L,1647360L,1541304L,-286084L,-187614L,-1491L,7056L,1014L,54L,1L,-67737600L,19968480L,27275064L,-2562556L,-3442594L,-254583L,115605L,24906L };
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
public class A091741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091741Inst : IEnumerable<long>
{
public static readonly long[] Value=A091741.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091741.Bytes);
public long this[int i]=>Value[i];

public static A091741Inst Instance=new A091741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091740
{
public static readonly BigInteger[] Value={ 1L,290L,71320L,22097600L,8928102400L,4644244774400L,3046988353024000L,2470747704449024000L,BigInteger.Parse("2431736840968314880000"),BigInteger.Parse("2859398101389251502080000"),BigInteger.Parse("3962371103307529193881600000"),BigInteger.Parse("6394280010754055221811609600000") };
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
public class A091740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091740Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A091740.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091740.Bytes);
public BigInteger this[int i]=>Value[i];

public static A091740Inst Instance=new A091740Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091739
{
public static readonly BigInteger[] Value={ 1L,4440L,12715200L,33158592000L,84365452800000L,213181366579200000L,BigInteger.Parse("537634980016128000000"),BigInteger.Parse("1355141067314135040000000"),BigInteger.Parse("3415172150786516582400000000"),BigInteger.Parse("8606389816065144913920000000000") };
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
public class A091739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091739Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A091739.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091739.Bytes);
public BigInteger this[int i]=>Value[i];

public static A091739Inst Instance=new A091739Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091738
{
public static readonly long[] Value={ 3L,7L,19L,29L,43L,53L,71L,79L,101L,107L,131L,139L,163L,173L,193L,199L,229L,239L,263L,271L,293L,311L,337L,349L,373L,383L,409L,421L,443L,457L,479L,491L,521L,541L,569L,577L,601L,613L,641L,647L,673L,683L,719L,733L,757L,769L,809L,821L,839L,857L,881L,887L,929L,941L };
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
public class A091738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091738Inst : IEnumerable<long>
{
public static readonly long[] Value=A091738.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091738.Bytes);
public long this[int i]=>Value[i];

public static A091738Inst Instance=new A091738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091737
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,24L,6L,8L,3L,1920L,40L,1920L,40L,322560L,5040L,322560L,2520L,92897280L,72576L,2064384L,72576L,40874803200L,492800L,40874803200L,369600L };
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
public class A091737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091737Inst : IEnumerable<long>
{
public static readonly long[] Value=A091737.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091737.Bytes);
public long this[int i]=>Value[i];

public static A091737Inst Instance=new A091737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091736
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,1L,-25L,7L,-11L,5L,-4001L,107L,-6721L,187L,-2048761L,44143L,-3951137L,43663L,-2300524417L,2591885L,-107137061L,5512427L,-4571262603161L,81607991L,-10073849103649L,136193843L };
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
public class A091736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091736Inst : IEnumerable<long>
{
public static readonly long[] Value=A091736.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091736.Bytes);
public long this[int i]=>Value[i];

public static A091736Inst Instance=new A091736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091735
{
public static readonly long[] Value={ 2L,11L,17L,31L,41L,59L,67L,83L,97L,109L,127L,149L,157L,179L,191L };
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
public class A091735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091735Inst : IEnumerable<long>
{
public static readonly long[] Value=A091735.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091735.Bytes);
public long this[int i]=>Value[i];

public static A091735Inst Instance=new A091735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091734
{
public static readonly long[] Value={ 2L,3L,11L,17L,7L,5L,31L,19L,13L,41L,29L,23L,59L,43L,37L,67L,53L,47L,83L,71L,61L,97L,79L,73L,109L,101L,89L,127L,107L,103L,149L,131L,113L,157L,139L,137L,179L,163L,151L,191L,173L,167L };
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
public class A091734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091734Inst : IEnumerable<long>
{
public static readonly long[] Value=A091734.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091734.Bytes);
public long this[int i]=>Value[i];

public static A091734Inst Instance=new A091734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091733
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,2L,9L,4L,11L,12L,13L,3L,9L,16L,17L,18L,7L,7L,21L,4L,23L,24L,25L,26L,3L,10L,9L,30L,31L,5L,33L,34L,35L,11L,13L,10L,7L,16L,41L,42L,25L,6L,45L,16L,47L,48L,49L,18L,51L,52L,9L,54L,19L,56L,9L,7L,59L,60L,61L,13L,5L,4L,65L,16L,67L,29L,69L,70L,11L,72L,25L,8L,47L,76L,45L,23L,55L,23L };
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
public class A091733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091733Inst : IEnumerable<long>
{
public static readonly long[] Value=A091733.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091733.Bytes);
public long this[int i]=>Value[i];

public static A091733Inst Instance=new A091733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091732
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,2L,6L,3L,8L,4L,10L,6L,12L,6L,8L,15L,16L,8L,18L,12L,12L,10L,22L,6L,24L,12L,16L,18L,28L,8L,30L,15L,20L,16L,24L,24L,36L,18L,24L,12L,40L,12L,42L,30L,32L,22L,46L,30L,48L,24L,32L,36L,52L,16L,40L,18L,36L,28L,58L,24L,60L,30L,48L,45L,48L,20L,66L,48L,44L,24L,70L,24L,72L,36L,48L };
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
public class A091732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091732Inst : IEnumerable<long>
{
public static readonly long[] Value=A091732.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091732.Bytes);
public long this[int i]=>Value[i];

public static A091732Inst Instance=new A091732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091667
{
public static readonly long[] Value={ 9L,9L,8L,1L,3L,6L,0L,4L,4L,5L,9L,8L,5L,0L,9L,3L,3L,2L,1L,5L,0L,0L,2L,4L,4L,5L,9L,0L,4L,7L,0L,7L,4L,7L,3L,5L,3L,1L,1L,3L,8L,2L,9L,9L,4L,7L,6L,3L,0L,4L,3L,9L,8L,2L,1L,8L,5L,5L,8L,3L,8L,7L,4L,0L,7L,0L,3L,5L,0L,3L,2L,4L,6L,8L,9L,4L,6L,4L,4L,1L,3L,3L,5L,7L,7L,1L,7L,7L,2L,7L,0L,8L,6L,7L,5L,0L,5L,8L,2L,6L,1L,7L,9L,4L,8L };
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
public class A091667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091667Inst : IEnumerable<long>
{
public static readonly long[] Value=A091667.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091667.Bytes);
public long this[int i]=>Value[i];

public static A091667Inst Instance=new A091667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091666
{
public static readonly long[] Value={ 1L,2L,4L,4L,6L,4L,4L,6L,12L,12L,6L,4L,12L,12L,4L,10L,10L,6L,4L,10L,4L,6L,10L,6L,4L,10L,4L,18L,6L,12L,10L,6L,4L,12L,28L,6L,10L,4L,4L,18L,10L,10L,12L,4L,12L,6L,10L,10L,10L,12L,4L,10L,18L,28L,18L,22L,6L,12L,4L,16L,18L,4L,4L,10L,4L,4L,6L,22L,4L,42L,24L,22L,10L,4L };
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
public class A091666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091666Inst : IEnumerable<long>
{
public static readonly long[] Value=A091666.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091666.Bytes);
public long this[int i]=>Value[i];

public static A091666Inst Instance=new A091666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091665
{
public static readonly long[] Value={ 1L,2L,2L,7L,8L,3L,30L,34L,21L,4L,143L,160L,114L,44L,5L,728L,806L,609L,308L,80L,6L,3876L,4256L,3315L,1908L,715L,132L,7L,21318L,23256L,18444L,11420L,5185L,1482L,203L,8L,120175L,130416L,104652L,67856L,34520L,12600L,2814L,296L,9L,690690L,746350L,603801L,404016L };
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
public class A091665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091665Inst : IEnumerable<long>
{
public static readonly long[] Value=A091665.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091665.Bytes);
public long this[int i]=>Value[i];

public static A091665Inst Instance=new A091665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091664
{
public static readonly long[] Value={ 4L,2L,6L,0L,9L,8L,2L,1L,2L,8L,1L,9L,9L,5L,2L,6L,5L,2L,2L,9L,3L,7L,7L,9L,9L,1L,6L,6L,0L,1L,4L,0L,0L,9L,0L,1L,6L,9L,8L,0L,3L,2L,3L,2L,4L,3L,2L,4L,7L,5L,5L,0L,0L,0L,1L,1L,8L,3L,6L,8L,0L,8L,5L,9L,0L,5L,6L,6L,1L,2L,6L,0L,0L,9L,8L,9L,0L,5L,8L,3L,9L,2L,0L,8L,9L,6L,1L,8L,0L,1L,9L,1L,3L,7L,0L,0L,3L,5L,9L,3L };
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
public class A091664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091664Inst : IEnumerable<long>
{
public static readonly long[] Value=A091664.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091664.Bytes);
public long this[int i]=>Value[i];

public static A091664Inst Instance=new A091664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091663
{
public static readonly long[] Value={ 5L,7L,3L,9L,0L,1L,7L,8L,7L,1L,8L,0L,0L,4L,7L,3L,4L,7L,7L,0L,6L,2L,2L,0L,0L,8L,3L,3L,9L,8L,5L,9L,9L,0L,9L,8L,3L,0L,1L,9L,6L,7L,6L,7L,5L,6L,7L,5L,2L,4L,4L,9L,9L,9L,8L,8L,1L,6L,3L,1L,9L,1L,4L,0L,9L,4L,3L,3L,8L,7L,3L,9L,9L,0L,1L,0L,9L,4L,1L,6L,0L,7L,9L,1L,0L,3L,8L,1L,9L,8L,0L,8L,6L,2L,9L,9L,6L,4L,0L,6L };
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
public class A091663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091663Inst : IEnumerable<long>
{
public static readonly long[] Value=A091663.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091663.Bytes);
public long this[int i]=>Value[i];

public static A091663Inst Instance=new A091663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091662
{
public static readonly long[] Value={ 1L,5L,7L,8L,1L,2L,4L,7L,5L,3L,6L,1L,0L,8L,4L,7L,8L,4L,5L,1L,2L,5L,4L,0L,0L,6L,7L,6L,8L,7L,1L,9L,9L,1L,8L };
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
public class A091662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091662Inst : IEnumerable<long>
{
public static readonly long[] Value=A091662.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091662.Bytes);
public long this[int i]=>Value[i];

public static A091662Inst Instance=new A091662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091661
{
public static readonly long[] Value={ 9L,4L,2L,1L,8L,7L,5L,2L,4L,6L,3L,8L,9L,1L,5L,2L,1L,5L,4L,8L,7L,4L,5L,9L,9L,3L,2L,3L,1L,2L,8L,0L,0L,8L,1L,2L,2L,9L,7L,1L,6L,4L,6L,4L,8L,6L,4L,8L,4L,1L,1L,1L,0L,0L,2L,2L,6L,7L,2L,7L,1L,6L,1L,9L,1L,0L,3L,3L,3L,4L,2L,1L,0L,8L,7L,9L,1L,0L,7L,7L,8L,5L,0L,6L,9L,3L,3L,6L,1L,2L,8L,3L,6L,4L,1L,0L,6L,0L,9L,7L };
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
public class A091661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091661Inst : IEnumerable<long>
{
public static readonly long[] Value=A091661.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091661.Bytes);
public long this[int i]=>Value[i];

public static A091661Inst Instance=new A091661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091660
{
public static readonly long[] Value={ 5L,2L,6L,9L,3L,9L,1L,1L,3L,5L,4L,1L,2L,6L,3L,6L,1L,9L,2L,1L,7L,2L,1L,8L,7L,3L,3L,8L,8L,4L,0L,3L,7L,0L,9L,1L,9L,6L,3L,8L,5L,0L,9L,0L,0L,3L,0L,6L,4L,6L,9L,9L,1L,8L,9L,0L,3L,7L,3L,8L,5L,0L,3L,7L,4L,4L,7L,2L,8L,9L,1L,3L,5L,8L,8L,5L,0L,3L,7L,0L,5L,8L,0L,9L,2L,3L,2L,0L,1L,4L,6L,3L,1L,7L,8L,4L,4L,4L,0L,6L,7L,3L };
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
public class A091660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091660Inst : IEnumerable<long>
{
public static readonly long[] Value=A091660.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091660.Bytes);
public long this[int i]=>Value[i];

public static A091660Inst Instance=new A091660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091659
{
public static readonly long[] Value={ 5L,6L,8L,3L,0L,0L,0L,0L,3L,1L,4L,6L,2L,3L,5L,1L,7L,8L,7L,6L,0L,3L,3L,0L,4L,1L,1L,0L,3L,3L,1L,7L,5L,1L,5L,1L,4L,0L,7L,5L,2L,6L,6L,7L,4L,7L,8L,2L,5L,4L,0L,6L,1L,2L,2L,7L,2L,9L,5L,6L,7L,0L,5L,1L,8L,7L,7L,9L,2L,0L,8L,9L,7L,2L,4L,5L,9L,4L,0L,0L,2L,8L,0L,8L,2L,5L,7L,1L,4L,5L,4L,1L,5L,5L,2L,8L,5L,3L,2L,2L,7L,4L };
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
public class A091659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091659Inst : IEnumerable<long>
{
public static readonly long[] Value=A091659.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091659.Bytes);
public long this[int i]=>Value[i];

public static A091659Inst Instance=new A091659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091658
{
public static readonly long[] Value={ 4L,9L,30L,40L,44L,130L,276L,647L,791L,878L,1008L,3041L,3200L,3384L,5606L,9721L,17899L,22640L,34070L,34152L,37648L,91193L,134943L,152617L,158172L,190950L,258992L,315679L,525765L,558041L,734305L,1500708L,1669873L,1873804L,1936902L,4278672L,5227319L,7385934L,7876549L,10765774L,11396841L,11466234L,12994613L,19147251L,31403937L,43166470L };
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
public class A091658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091658Inst : IEnumerable<long>
{
public static readonly long[] Value=A091658.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091658.Bytes);
public long this[int i]=>Value[i];

public static A091658Inst Instance=new A091658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091657
{
public static readonly long[] Value={ 4L,9L,9L,30L,40L,40L,40L,44L,130L,130L,276L,276L,276L,276L,276L,276L,647L,647L,647L,647L,647L,647L,647L,647L,791L,791L,791L,791L,791L,791L,878L,878L,878L,878L,1008L,1008L,1008L,3041L,3041L,3041L,3041L,3041L,3041L,3041L,3041L,3200L,3200L,3200L,3200L,3200L,3200L };
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
public class A091657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091657Inst : IEnumerable<long>
{
public static readonly long[] Value=A091657.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091657.Bytes);
public long this[int i]=>Value[i];

public static A091657Inst Instance=new A091657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091656
{
public static readonly long[] Value={ 1L,2L,5L,9L,9L,13L,26L,63L,68L,68L,68L,87L,121L,121L,165L,207L,207L,221L,221L,287L,289L,325L,428L,440L,483L,544L,544L,544L,544L,544L,558L,558L,558L,966L,1035L,1035L,1146L,1146L,1332L,1332L,1332L,1665L,1665L,1665L,1665L,1665L,1727L,1727L,2052L,2157L,2331L,2331L };
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
public class A091656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091656Inst : IEnumerable<long>
{
public static readonly long[] Value=A091656.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091656.Bytes);
public long this[int i]=>Value[i];

public static A091656Inst Instance=new A091656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091655
{
public static readonly long[] Value={ 2L,5L,6L,3L,11L,8L,5L,12L,30L,17L,4L,10L,17L,12L,31L,15L,25L,46L,63L,66L,51L,35L,30L,48L,46L,44L,31L,39L,21L,42L,53L,14L,44L,45L,53L,15L,70L,28L,78L,87L,131L,74L,11L,108L,52L,75L,71L,50L,80L,78L,83L,44L,73L,18L,52L,73L,58L,142L,86L,77L,27L,138L,148L,84L,144L,81L,114L,73L,139L,132L };
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
public class A091655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091655Inst : IEnumerable<long>
{
public static readonly long[] Value=A091655.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091655.Bytes);
public long this[int i]=>Value[i];

public static A091655Inst Instance=new A091655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091654
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,2L,1L,1L,2L,2L,1L,2L,1L,1L,2L,2L,6L,1L,5L,1L,2L,3L,4L,2L,1L,5L,1L,1L,2L,2L,3L,3L,1L,2L,6L,6L,4L,2L,3L,1L,2L,1L,4L,2L,2L,4L,2L,1L,1L,2L,2L,3L,3L,3L,3L,7L,5L,3L,4L,1L,2L,2L,1L,2L,1L,5L,1L,1L,6L,2L,1L,3L,2L,2L,3L,1L,2L,1L,1L,3L,2L,4L,3L,2L,5L,1L,1L,5L,2L,3L,9L,1L,1L,3L,2L,2L,6L,3L,3L,4L,2L,4L,5L,1L,8L };
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
public class A091654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091654Inst : IEnumerable<long>
{
public static readonly long[] Value=A091654.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091654.Bytes);
public long this[int i]=>Value[i];

public static A091654Inst Instance=new A091654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091653
{
public static readonly long[] Value={ 2L,5L,11L,17L,19L,29L,41L,59L,71L,101L,103L,107L,109L,131L,137L,149L,163L,173L,179L,191L,197L,229L,239L,257L,269L,281L,283L,307L,311L,313L,331L,347L,353L,383L,397L,419L,431L,461L,463L,487L,499L,509L,521L,541L,557L,569L,571L,599L,617L,641L,653L,659L,673L,757L };
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
public class A091653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091653Inst : IEnumerable<long>
{
public static readonly long[] Value=A091653.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091653.Bytes);
public long this[int i]=>Value[i];

public static A091653Inst Instance=new A091653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091652
{
public static readonly long[] Value={ 3L,7L,13L,23L,31L,37L,43L,47L,53L,61L,67L,73L,79L,83L,89L,97L,113L,127L,139L,151L,157L,167L,181L,193L,199L,211L,223L,227L,233L,241L,251L,263L,271L,277L,293L,317L,337L,349L,359L,367L,373L,379L,389L,401L,409L,421L,433L,439L,443L,449L,457L,467L,479L,491L,503L,523L };
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
public class A091652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091652Inst : IEnumerable<long>
{
public static readonly long[] Value=A091652.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091652.Bytes);
public long this[int i]=>Value[i];

public static A091652Inst Instance=new A091652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091619
{
public static readonly long[] Value={ 1L,0L,2L,4L,9L,21L,46L,98L,213L,459L,979L,2082L,4408L,9294L,19535L,40937L,85561L,178392L,371131L,770556L,1596936L,3303986L,6825163L,14078718L,29002331L,59670920L,122627798L,251735331L,516247636L,1057687986L,2165046327L,4428017780L,9049083763L,18478717262L };
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
public class A091619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091619Inst : IEnumerable<long>
{
public static readonly long[] Value=A091619.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091619.Bytes);
public long this[int i]=>Value[i];

public static A091619Inst Instance=new A091619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091618
{
public static readonly long[] Value={ 1L,0L,2L,4L,10L,22L,46L,101L,218L,466L,991L,2093L,4405L,9232L,19288L,40169L,83416L,172806L,357170L,736710L,1516714L,3117133L,6396116L,13105012L,26814264L,54795330L,111842771L,228030558L,464439943L,945029466L,1921169854L,3902239742L,7919743405L,16061152291L };
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
public class A091618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091618Inst : IEnumerable<long>
{
public static readonly long[] Value=A091618.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091618.Bytes);
public long this[int i]=>Value[i];

public static A091618Inst Instance=new A091618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091617
{
public static readonly long[] Value={ 1L,0L,2L,5L,11L,22L,48L,105L,223L,468L,979L,2037L,4224L,8710L,17906L,36693L,74973L,152795L,310669L,630353L,1276544L,2580614L,5208522L,10496954L,21126102L,42464498L,85255651L,170980512L,342553389L,685641724L,1371134291L,2739685107L,5469923466L,10912945300L };
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
public class A091617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091617Inst : IEnumerable<long>
{
public static readonly long[] Value=A091617.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091617.Bytes);
public long this[int i]=>Value[i];

public static A091617Inst Instance=new A091617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091616
{
public static readonly long[] Value={ 1L,0L,3L,6L,10L,23L,50L,99L,200L,404L,805L,1599L,3166L,6225L,12223L,23934L,46713L,90995L,176935L,343395L,665474L,1287918L,2489467L,4806805L,9272272L,17870317L,34414163L,66226890L,127365537L,244803475L,470278815L,902997083L,1733124564L,3325087228L,6377076320L };
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
public class A091616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091616Inst : IEnumerable<long>
{
public static readonly long[] Value=A091616.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091616.Bytes);
public long this[int i]=>Value[i];

public static A091616Inst Instance=new A091616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091615
{
public static readonly long[] Value={ 1L,2L,1L,6L,0L,1L,11L,6L,0L,1L,26L,12L,4L,0L,1L,61L,26L,10L,4L,0L,1L,132L,70L,26L,8L,4L,0L,1L,290L,174L,62L,24L,8L,4L,0L,1L,638L,404L,156L,60L,22L,8L,4L,0L,1L,1390L,946L,385L,146L,58L,22L,8L,4L,0L,1L,3012L,2192L,921L,362L,144L,56L,22L,8L,4L,0L,1L,6496L,5008L,2177L,876L,350L,142L };
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
public class A091615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091615Inst : IEnumerable<long>
{
public static readonly long[] Value=A091615.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091615.Bytes);
public long this[int i]=>Value[i];

public static A091615Inst Instance=new A091615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091614
{
public static readonly long[] Value={ 1L,-1L,1L,-3L,0L,1L,-1L,-3L,0L,1L,5L,-6L,-2L,0L,1L,13L,-4L,-5L,-2L,0L,1L,27L,1L,-7L,-4L,-2L,0L,1L,41L,12L,-4L,-6L,-4L,-2L,0L,1L,43L,35L,4L,-6L,-5L,-4L,-2L,0L,1L,25L,72L,18L,0L,-5L,-5L,-4L,-2L,0L,1L,-23L,128L,40L,11L,-2L,-4L,-5L,-4L,-2L,0L,1L,-157L,205L,77L,30L,8L,-1L,-4L,-5L,-4L,-2L };
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
public class A091614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091614Inst : IEnumerable<long>
{
public static readonly long[] Value=A091614.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091614.Bytes);
public long this[int i]=>Value[i];

public static A091614Inst Instance=new A091614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091613
{
public static readonly long[] Value={ 1L,1L,1L,3L,0L,1L,4L,3L,0L,1L,7L,6L,2L,0L,1L,14L,10L,5L,2L,0L,1L,23L,23L,11L,4L,2L,0L,1L,39L,50L,22L,10L,4L,2L,0L,1L,71L,99L,48L,22L,9L,4L,2L,0L,1L,124L,200L,105L,46L,21L,9L,4L,2L,0L,1L,214L,404L,223L,101L,46L,20L,9L,4L,2L,0L,1L,378L,805L,468L,218L,98L,45L,20L,9L,4L,2L,0L,1L,661L,1599L };
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
public class A091613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091613Inst : IEnumerable<long>
{
public static readonly long[] Value=A091613.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091613.Bytes);
public long this[int i]=>Value[i];

public static A091613Inst Instance=new A091613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091612
{
public static readonly long[] Value={ 1L,-1L,-2L,0L,1L,3L,4L,3L,3L,0L,0L,-3L,-4L,-7L,-9L,-9L,-9L,-9L,-9L,-4L,-5L,-4L,-3L,2L,3L,5L,6L,11L,11L,17L,17L,17L,17L,17L,18L,18L,18L,18L,18L,11L,10L,13L,13L,10L,11L,10L,10L,3L,4L,0L,1L,-2L,-2L,-3L,-3L,-9L,-8L,-7L,-7L,-19L,-19L,-19L,-19L,-19L,-20L,-21L,-21L,-21L,-21L,-27L };
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
public class A091612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091612Inst : IEnumerable<long>
{
public static readonly long[] Value=A091612.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091612.Bytes);
public long this[int i]=>Value[i];

public static A091612Inst Instance=new A091612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091611
{
public static readonly long[] Value={ 1L,2L,4L,6L,10L,17L,25L,38L,57L,84L,120L,174L,243L,342L,472L,650L,882L,1200L,1605L,2150L,2848L,3767L,4937L,6467L,8396L,10891L,14032L,18046L,23073L,29458L,37405L,47421L,59850L,75396L,94601L,118501L,147888L,184254L,228823L,283677L,350655L,432737L };
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
public class A091611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091611Inst : IEnumerable<long>
{
public static readonly long[] Value=A091611.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091611.Bytes);
public long this[int i]=>Value[i];

public static A091611Inst Instance=new A091611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091610
{
public static readonly long[] Value={ 1L,3L,5L,11L,17L,32L,49L,84L,127L,202L,300L,462L,671L,997L,1428L,2072L,2922L,4156L,5784L,8089L,11127L,15340L,20875L,28437L,38316L,51629L,68962L,92037L,121934L,161346L,212164L,278571L,363797L,474283L,615431L,797165L,1028270L,1323932L,1698335L };
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
public class A091610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091610Inst : IEnumerable<long>
{
public static readonly long[] Value=A091610.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091610.Bytes);
public long this[int i]=>Value[i];

public static A091610Inst Instance=new A091610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091609
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,2L,5L,5L,8L,10L,15L,18L,27L,32L,45L,56L,75L,92L,123L,150L,195L,240L,306L,374L,473L,575L,718L,873L,1078L,1304L,1602L,1928L,2349L,2821L,3414L,4083L,4917L,5857L,7016L,8334L,9934L,11758L,13963L,16472L,19480L,22918L,27003L,31673L,37200L,43509L };
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
public class A091609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091609Inst : IEnumerable<long>
{
public static readonly long[] Value=A091609.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091609.Bytes);
public long this[int i]=>Value[i];

public static A091609Inst Instance=new A091609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091608
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,3L,5L,5L,9L,11L,16L,20L,29L,35L,49L,61L,81L,101L,133L,163L,211L,260L,329L,404L,508L,619L,770L,936L,1152L,1395L,1706L,2053L,2495L,2994L,3612L,4318L,5185L,6171L,7374L,8748L,10403L,12300L,14570L,17165L,20257L,23797L,27977L,32769L,38405L,44850L };
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
public class A091608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091608Inst : IEnumerable<long>
{
public static readonly long[] Value=A091608.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091608.Bytes);
public long this[int i]=>Value[i];

public static A091608Inst Instance=new A091608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091607
{
public static readonly long[] Value={ 1L,0L,1L,1L,3L,3L,5L,6L,10L,12L,18L,22L,32L,39L,54L,67L,89L,110L,144L,177L,228L,280L,354L,433L,542L,659L,816L,989L,1214L,1464L,1784L,2142L,2593L,3101L,3730L,4444L,5318L,6310L,7514L,8886L,10534L,12413L,14656L,17214L,20249L,23711L,27790L,32447L,37908L,44134L };
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
public class A091607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091607Inst : IEnumerable<long>
{
public static readonly long[] Value=A091607.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091607.Bytes);
public long this[int i]=>Value[i];

public static A091607Inst Instance=new A091607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091606
{
public static readonly long[] Value={ 1L,0L,1L,2L,3L,3L,6L,7L,11L,14L,20L,25L,35L,43L,58L,73L,95L,118L,152L,187L,237L,291L,363L,443L,549L,665L,815L,985L,1197L,1437L,1737L,2075L,2491L,2966L,3539L,4195L,4984L,5882L,6955L,8183L,9633L,11291L,13246L,15474L,18085L,21066L,24536L,28495L,33092L,38321L };
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
public class A091606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091606Inst : IEnumerable<long>
{
public static readonly long[] Value=A091606.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091606.Bytes);
public long this[int i]=>Value[i];

public static A091606Inst Instance=new A091606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091605
{
public static readonly long[] Value={ 1L,0L,2L,2L,3L,4L,7L,8L,12L,15L,21L,26L,35L,43L,57L,70L,89L,109L,138L,167L,208L,251L,309L,371L,452L,539L,652L,775L,929L,1099L,1311L,1543L,1829L,2146L,2529L,2957L,3469L,4040L,4721L,5481L,6377L,7381L,8559L,9875L,11412L,13133L,15128L,17364L,19945L,22833L };
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
public class A091605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091605Inst : IEnumerable<long>
{
public static readonly long[] Value=A091605.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091605.Bytes);
public long this[int i]=>Value[i];

public static A091605Inst Instance=new A091605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091604
{
public static readonly long[] Value={ 1L,2L,1L,4L,0L,1L,6L,4L,0L,1L,10L,4L,2L,0L,1L,17L,8L,4L,2L,0L,1L,25L,12L,7L,2L,2L,0L,1L,38L,25L,9L,7L,2L,2L,0L,1L,57L,33L,19L,8L,5L,2L,2L,0L,1L,84L,57L,27L,16L,8L,5L,2L,2L,0L,1L,120L,81L,46L,22L,15L,6L,5L,2L,2L,0L,1L,174L,129L,68L,41L,19L,15L,6L,5L,2L,2L,0L,1L,243L,182L,107L,56L,36L,18L,13L,6L };
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
public class A091604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091604Inst : IEnumerable<long>
{
public static readonly long[] Value=A091604.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091604.Bytes);
public long this[int i]=>Value[i];

public static A091604Inst Instance=new A091604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091587
{
public static readonly long[] Value={ 1L,3L,9L,24L,67L,196L,581L,1731L,5180L,15534L,46578L,139713L,419116L };
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
public class A091587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091587Inst : IEnumerable<long>
{
public static readonly long[] Value=A091587.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091587.Bytes);
public long this[int i]=>Value[i];

public static A091587Inst Instance=new A091587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091586
{
public static readonly long[] Value={ 0L,1L,-1L,0L,1L,0L,0L,1L,-2L,0L,1L,-1L,0L,1L,0L,0L,1L,-1L,-1L,0L,1L,-1L,0L,1L,0L,0L,1L,-2L,0L,1L,-1L,0L,1L,0L,0L,1L,-1L,0L,0L,1L,-1L,0L,0L,1L,0L,-1L,-1L,0L,1L,-1L,0L,1L,0L,0L,1L,-2L,0L,1L,-1L,0L,1L,0L,0L,1L,-1L,-1L,0L,1L,-1L,0L,1L,0L,0L,1L,-2L,0L,1L,-1L,0L,1L,0L,0L,1L,-1L,0L,0L,1L,-1L,0L,0L,1L,0L,-1L,0L,0L,1L,-1L,-1L };
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
public class A091586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091586Inst : IEnumerable<long>
{
public static readonly long[] Value=A091586.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091586.Bytes);
public long this[int i]=>Value[i];

public static A091586Inst Instance=new A091586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091585
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,5L,6L,8L,11L,34L,47L,58L,82L,105L,140L,186L,234L,238L,307L,401L,491L,603L,723L,891L,1058L,1302L,1543L,1858L,2228L,2626L,3113L,3666L,4274L,5026L,5823L,6815L,7879L,9251L,10727L,12347L,14219L,16340L,18740L,21465L,24473L,27960L,31819L };
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
public class A091585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091585Inst : IEnumerable<long>
{
public static readonly long[] Value=A091585.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091585.Bytes);
public long this[int i]=>Value[i];

public static A091585Inst Instance=new A091585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091584
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,11L,15L,22L,30L,55L,788L,5747L,28915L,114064L,378823L,1105429L,2916219L,7093435L,8275126L,17341313L,34721974L };
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
public class A091584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091584Inst : IEnumerable<long>
{
public static readonly long[] Value=A091584.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091584.Bytes);
public long this[int i]=>Value[i];

public static A091584Inst Instance=new A091584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091583
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,5L,6L,8L,12L,89L,448L,1816L,6378L,20132L,58499L,159046L,409174L,483330L,1087744L,2368800L,5010688L,10327156L,20792120L,40982540L };
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
public class A091583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091583Inst : IEnumerable<long>
{
public static readonly long[] Value=A091583.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091583.Bytes);
public long this[int i]=>Value[i];

public static A091583Inst Instance=new A091583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091582
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,11L,15L,22L,30L,56L,1002L,10143L,75175L,451276L,2323520L,10619863L,44108109L,169229875L,214481126L,679903203L };
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
public class A091582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091582Inst : IEnumerable<long>
{
public static readonly long[] Value=A091582.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091582.Bytes);
public long this[int i]=>Value[i];

public static A091582Inst Instance=new A091582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091581
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,5L,6L,8L,9L,11L,13L,14L,17L,19L,21L,23L,26L,27L,30L,32L,34L,36L,37L,39L,40L,42L,42L,44L,44L,45L,45L,47L,47L,47L,49L,48L,50L,50L,52L,52L,55L,55L,58L,60L,60L,64L,65L,68L,69L,73L,73L,77L,78L,82L,84L,84L,88L,88L,92L,92L,96L,96L,100L,100L,105L,107L,107L,113L };
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
public class A091581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091581Inst : IEnumerable<long>
{
public static readonly long[] Value=A091581.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091581.Bytes);
public long this[int i]=>Value[i];

public static A091581Inst Instance=new A091581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091580
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,11L,15L,22L,30L,41L,55L,74L,96L,126L,162L,208L,263L,333L,415L,518L,639L,788L,962L,1174L,1420L,1716L,2060L,2468L,2940L,3497L,4137L,4886L,5747L,6744L,7885L,9203L,10702L,12424L,14379L,16611L,19136L,22009L,25245L,28915L,33037L,37688L };
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
public class A091580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091580Inst : IEnumerable<long>
{
public static readonly long[] Value=A091580.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091580.Bytes);
public long this[int i]=>Value[i];

public static A091580Inst Instance=new A091580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091579
{
public static readonly long[] Value={ 1L,3L,1L,9L,4L,24L,1L,3L,1L,9L,4L,67L,1L,3L,1L,9L,4L,24L,1L,3L,1L,9L,4L,196L,3L,1L,9L,4L,24L,1L,3L,1L,9L,4L,68L,3L,1L,9L,4L,24L,1L,3L,1L,9L,4L,581L,3L,1L,9L,4L,25L,3L,1L,9L,4L,67L,1L,3L,1L,9L,4L,24L,1L,3L,1L,9L,4L,196L,3L,1L,9L,4L,24L,1L,3L,1L,9L,4L,68L,3L,1L,9L,4L,24L,1L,3L,1L,9L,4L,1731L,3L,1L,9L,4L,24L };
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
public class A091579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091579Inst : IEnumerable<long>
{
public static readonly long[] Value=A091579.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091579.Bytes);
public long this[int i]=>Value[i];

public static A091579Inst Instance=new A091579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091578
{
public static readonly long[] Value={ 2L,7L,3L,11L,5L,19L,13L,23L,17L,37L,29L,41L,31L,53L,43L,59L,47L,71L,61L,73L,67L,89L,79L,97L,83L,107L,101L,109L,103L,131L,113L,137L,127L,151L,139L,157L,149L,173L,163L,179L,167L,193L,181L,197L,191L,223L,199L,227L,211L,239L,229L,241L,233L,263L,251L,257L };
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
public class A091578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091578Inst : IEnumerable<long>
{
public static readonly long[] Value=A091578.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091578.Bytes);
public long this[int i]=>Value[i];

public static A091578Inst Instance=new A091578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091577
{
public static readonly long[] Value={ 6L,10L,14L,18L,20L,20L,20L,18L,14L,10L,6L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
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
public class A091577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091577Inst : IEnumerable<long>
{
public static readonly long[] Value=A091577.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091577.Bytes);
public long this[int i]=>Value[i];

public static A091577Inst Instance=new A091577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091576
{
public static readonly long[] Value={ 7L,12L,17L,22L,27L,30L,33L,34L,35L,34L,33L,30L,27L,22L,17L,12L,7L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
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
public class A091576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091576Inst : IEnumerable<long>
{
public static readonly long[] Value=A091576.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091576.Bytes);
public long this[int i]=>Value[i];

public static A091576Inst Instance=new A091576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091575
{
public static readonly long[] Value={ 8L,14L,20L,26L,32L,38L,44L,48L,52L,56L,60L,62L,64L,64L,64L,64L,64L,62L,60L,56L,52L,48L,44L,38L,32L,26L,20L,14L,8L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
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
public class A091575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091575Inst : IEnumerable<long>
{
public static readonly long[] Value=A091575.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091575.Bytes);
public long this[int i]=>Value[i];

public static A091575Inst Instance=new A091575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091574
{
public static readonly long[] Value={ 5L,8L,15L,16L,25L,24L,35L,32L,45L,40L,55L,48L,65L,56L,75L,64L,85L,72L,95L,80L,105L,88L,115L,96L,125L,104L,135L,112L,145L,120L,155L,128L,165L,136L,175L,144L,185L,152L,195L,160L,205L,168L,215L,176L,225L,184L,235L,192L,245L,200L,255L,208L };
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
public class A091574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091574Inst : IEnumerable<long>
{
public static readonly long[] Value=A091574.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091574.Bytes);
public long this[int i]=>Value[i];

public static A091574Inst Instance=new A091574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091573
{
public static readonly long[] Value={ 7L,12L,17L,24L,31L,36L,41L,48L,55L,60L,65L,72L,79L,84L,89L,96L,103L,108L,113L,120L,127L,132L,137L,144L,151L,156L,161L,168L,175L,180L,185L,192L,199L,204L,209L,216L,223L,228L,233L,240L,247L,252L,257L,264L,271L,276L,281L,288L,295L,300L,305L,312L,319L,324L,329L };
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
public class A091573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091573Inst : IEnumerable<long>
{
public static readonly long[] Value=A091573.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091573.Bytes);
public long this[int i]=>Value[i];

public static A091573Inst Instance=new A091573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091572
{
public static readonly long[] Value={ 8L,14L,20L,26L,34L,40L,48L,54L,62L,66L,74L,80L,90L,94L,102L,106L,116L,120L,130L,134L,144L,146L,156L,160L,172L,174L,184L,186L,198L,200L,212L,214L,226L,226L,238L,240L,254L,254L,266L,266L,280L,280L,294L,294L,308L,306L,320L,320L,336L,334L,348L,346L,362L,360L,376L };
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
public class A091572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091572Inst : IEnumerable<long>
{
public static readonly long[] Value=A091572.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091572.Bytes);
public long this[int i]=>Value[i];

public static A091572Inst Instance=new A091572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091539
{
public static readonly BigInteger[] Value={ 1L,104L,16192L,3745280L,1222291840L,537758144000L,307503360102400L,221965373351321600L,BigInteger.Parse("197530935371241472000"),BigInteger.Parse("212553938009841139712000"),BigInteger.Parse("272115940122123843665920000"),BigInteger.Parse("408828811133790954169303040000") };
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
public class A091539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091539Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A091539.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091539.Bytes);
public BigInteger this[int i]=>Value[i];

public static A091539Inst Instance=new A091539Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091538
{
public static readonly long[] Value={ 1L,0L,2L,0L,3L,4L,0L,5L,6L,8L,0L,7L,9L,12L,16L,0L,11L,10L,18L,24L,32L,0L,13L,14L,20L,36L,48L,64L,0L,17L,15L,27L,40L,72L,96L,128L,0L,19L,21L,28L,54L,80L,144L,192L,256L,0L,23L,22L,30L,56L,108L,160L,288L,384L,512L,0L,29L,25L,42L,60L,112L,216L,320L,576L,768L,1024L };
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
public class A091538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091538Inst : IEnumerable<long>
{
public static readonly long[] Value=A091538.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091538.Bytes);
public long this[int i]=>Value[i];

public static A091538Inst Instance=new A091538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091537
{
public static readonly BigInteger[] Value={ 1L,11L,341L,19841L,1683981L,143771891L,-15351301839L,-27396364105599L,-24059921739904039L,BigInteger.Parse("-21285850978489377989"),BigInteger.Parse("-20814945866103868804819"),BigInteger.Parse("-22980130985849165090290239"),BigInteger.Parse("-28698856680135265507625861339"),BigInteger.Parse("-40335646598356375740067161474269") };
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
public class A091537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091537Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A091537.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091537.Bytes);
public BigInteger this[int i]=>Value[i];

public static A091537Inst Instance=new A091537Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091536
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,54824L,219296L,626560L,2192960L,7462917L,23067198L,66429244L,182680421L,476804328L,1173672192L,2739870518L,6066856147L,12753805999L,25507611998L,48541216592L };
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
public class A091536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091536Inst : IEnumerable<long>
{
public static readonly long[] Value=A091536.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091536.Bytes);
public long this[int i]=>Value[i];

public static A091536Inst Instance=new A091536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091535
{
public static readonly BigInteger[] Value={ 1L,20L,1120L,123200L,22422400L,6098892800L,2317579264000L,1172695107584000L,762251819929600000L,BigInteger.Parse("618948477782835200000"),BigInteger.Parse("613996889960572518400000"),BigInteger.Parse("730656299053081296896000000"),BigInteger.Parse("1027302756468632303435776000000"),BigInteger.Parse("1684776520608556977634672640000000") };
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
public class A091535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091535Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A091535.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091535.Bytes);
public BigInteger this[int i]=>Value[i];

public static A091535Inst Instance=new A091535Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091534
{
public static readonly long[] Value={ 1L,20L,10L,1L,1120L,1040L,290L,30L,1L,123200L,161920L,71320L,14040L,1340L,60L,1L,22422400L,37452800L,22097600L,6263040L,958720L,82800L,4000L,100L,1L,6098892800L,12222918400L,8928102400L,3257116800L,675281600L,84782880L,6625920L,322000L };
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
public class A091534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091534Inst : IEnumerable<long>
{
public static readonly long[] Value=A091534.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091534.Bytes);
public long this[int i]=>Value[i];

public static A091534Inst Instance=new A091534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091533
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,2L,3L,7L,7L,3L,5L,15L,21L,15L,5L,8L,30L,53L,53L,30L,8L,13L,58L,124L,157L,124L,58L,13L,21L,109L,273L,417L,417L,273L,109L,21L,34L,201L,577L,1029L,1239L,1029L,577L,201L,34L,55L,365L,1181L,2405L,3375L,3375L,2405L,1181L,365L,55L,89L,655L,2358L,5393L,8625L };
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
public class A091533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091533Inst : IEnumerable<long>
{
public static readonly long[] Value=A091533.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091533.Bytes);
public long this[int i]=>Value[i];

public static A091533Inst Instance=new A091533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091532
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,8L,9L,13L,16L,17L,19L,23L,25L,26L,28L,29L,35L,36L,43L,45L,48L,49L,54L,57L,62L,72L,73L,79L,88L,90L,91L,99L,103L,108L,110L,113L,115L,116L,118L,125L,128L,148L,149L,157L,163L,168L,171L,172L,184L,193L,199L,205L,209L,234L,240L,243L,259L,265L,269L,270L,281L,283L };
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
public class A091532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091532Inst : IEnumerable<long>
{
public static readonly long[] Value=A091532.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091532.Bytes);
public long this[int i]=>Value[i];

public static A091532Inst Instance=new A091532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091531
{
public static readonly long[] Value={ 7L,23L,31L,43L,59L,67L,71L,73L,101L,103L,107L,127L,131L,137L,139L,179L,199L,211L,223L,227L,239L,269L,281L,283L,307L,311L,331L,347L,359L,367L,379L,383L,431L,439L,463L,467L,479L,487L,491L,503L,523L,547L,563L,571L,607L,619L,631L,643L,659L,661L,683L,691L,719L,727L };
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
public class A091531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091531Inst : IEnumerable<long>
{
public static readonly long[] Value=A091531.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091531.Bytes);
public long this[int i]=>Value[i];

public static A091531Inst Instance=new A091531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091530
{
public static readonly ulong[] Value={ 1L,4L,16L,73L,388L,2396L,17024L,137544L,1248816L,12603288L,140018688L,1698063552L,22318009344L,315942698880L,4791898275840L,77510315197440L,1331759355586560L,24220225133061120L,464796175236710400L,9385769913543475200UL };
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
public class A091530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091530Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A091530.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091530.Bytes);
public ulong this[int i]=>Value[i];

public static A091530Inst Instance=new A091530Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091529
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,8L,9L,10L,12L,13L,16L,18L,21L,22L,25L,28L,30L,33L,36L,37L,40L,42L,45L,46L,52L,57L,58L,60L,61L,66L,70L,72L,73L,78L,81L,82L,85L,88L,93L,96L,100L,102L,105L,106L,108L,112L,117L,121L,126L,130L,133L,136L,138L,141L,145L,148L,150L,156L,157L,162L,165L,166L,172L,177L };
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
public class A091529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091529Inst : IEnumerable<long>
{
public static readonly long[] Value=A091529.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091529.Bytes);
public long this[int i]=>Value[i];

public static A091529Inst Instance=new A091529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091528
{
public static readonly long[] Value={ 1L,1L,0L,3L,4L,2L,0L,6L,6L,5L,0L,3L,8L,0L,0L,13L,0L,3L,0L,0L,12L,17L,0L,0L,14L,0L,0L,1L,0L,6L,0L,0L,18L,0L,0L,1L,20L,0L,0L,23L,0L,25L,0L,0L,24L,44L,0L,0L,0L,0L,0L,36L,0L,0L,0L,0L,30L,8L,0L,36L,32L,0L,0L,0L,0L,10L,0L,0L,0L,2L,0L,56L,38L,0L,0L,0L,0L,19L,0L,0L,42L,48L,0L,0L,44L,0L,0L,6L,0L,0L,0L,0L,48L,0L,0L };
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
public class A091528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091528Inst : IEnumerable<long>
{
public static readonly long[] Value=A091528.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091528.Bytes);
public long this[int i]=>Value[i];

public static A091528Inst Instance=new A091528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091527
{
public static readonly long[] Value={ 1L,4L,30L,256L,2310L,21504L,204204L,1966080L,19122246L,187432960L,1848483780L,18320719872L,182327718300L,1820797698048L,18236779032600L,183120225632256L,1842826521244230L,18581317012684800L,187679234340049620L };
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
public class A091527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091527Inst : IEnumerable<long>
{
public static readonly long[] Value=A091527.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091527.Bytes);
public long this[int i]=>Value[i];

public static A091527Inst Instance=new A091527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091526
{
public static readonly long[] Value={ 1L,-1L,1L,2L,9L,34L,130L,496L,1897L,7274L,27966L,107788L,416394L,1611908L,6251596L,24287212L,94499689L,368202778L,1436458486L,5610483532L,21936442894L,85852554748L,336300861436L,1318441228432L,5172792817834L,20309402206084L };
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
public class A091526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091526Inst : IEnumerable<long>
{
public static readonly long[] Value=A091526.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091526.Bytes);
public long this[int i]=>Value[i];

public static A091526Inst Instance=new A091526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091525
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,3L,5L,4L,6L,7L,5L,8L,6L,9L,7L,10L,11L,8L,12L,9L,13L,14L,10L,15L,11L,16L,12L,17L };
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
public class A091525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091525Inst : IEnumerable<long>
{
public static readonly long[] Value=A091525.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091525.Bytes);
public long this[int i]=>Value[i];

public static A091525Inst Instance=new A091525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091524
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,3L,5L,4L,6L,7L,5L,8L,6L,9L,7L,10L,11L,8L,12L,9L,13L,14L,10L,15L,11L,16L,12L,17L,18L,13L,19L,14L,20L,21L,15L,22L,16L,23L,24L,17L,25L,18L,26L,19L,27L,28L,20L,29L,21L,30L,31L,22L,32L,23L,33L,24L,34L,35L,25L,36L,26L,37L,38L,27L,39L,28L,40L,41L,29L,42L,30L,43L,31L,44L };
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
public class A091524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091524Inst : IEnumerable<long>
{
public static readonly long[] Value=A091524.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091524.Bytes);
public long this[int i]=>Value[i];

public static A091524Inst Instance=new A091524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091363
{
public static readonly BigInteger[] Value={ 0L,1L,16L,162L,1536L,15000L,155520L,1728720L,20643840L,264539520L,3628800000L,53129260800L,827714764800L,13680764697600L,239217231052800L,4413400992000000L,85699747381248000L,1747492334235648000L,BigInteger.Parse("37338643451805696000"),BigInteger.Parse("834363743704178688000") };
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
public class A091363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091363Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A091363.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091363.Bytes);
public BigInteger this[int i]=>Value[i];

public static A091363Inst Instance=new A091363Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091362
{
public static readonly long[] Value={ 997L,1699L,2887L,5569L,5659L,5839L,5857L,6199L,6883L,6991L,7477L,8287L,8539L,8863L,8999L,9619L,9907L,11779L,11887L,13399L,13669L,14479L,14767L,14947L,15559L,16369L,16477L,16693L,16747L,16963L,17377L,17449L,17467L,17737L,17791L,17827L,17881L };
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
public class A091362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091362Inst : IEnumerable<long>
{
public static readonly long[] Value=A091362.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091362.Bytes);
public long this[int i]=>Value[i];

public static A091362Inst Instance=new A091362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091361
{
public static readonly long[] Value={ 1L,2L,3L,9L,15L,21L,27L,33L,39L,45L,51L,57L,63L,69L,75L,81L,87L,93L,99L,105L,111L,117L,123L,129L,135L,141L,147L,153L,159L,165L,171L,177L,183L,189L,195L,201L,207L,213L,219L,225L,231L,237L,243L,249L,255L,261L,267L,273L,279L,285L,291L,297L,303L,309L,315L,321L,327L };
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
public class A091361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091361Inst : IEnumerable<long>
{
public static readonly long[] Value=A091361.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091361.Bytes);
public long this[int i]=>Value[i];

public static A091361Inst Instance=new A091361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091360
{
public static readonly long[] Value={ 1L,2L,5L,11L,24L,48L,96L,182L,342L,624L,1124L,1983L,3462L,5947L,10114L,16993L,28290L,46624L,76225L,123555L,198833L,317627L,504102L,794885L,1246079L,1942112L,3010857L,4643515L,7126749L,10886361L,16555324L,25067633L,37801062L,56776035L,84951990L,126643036L,188127997L,278507781L,410949776L,604437277L,886284200L,1295668181L };
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
public class A091360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091360Inst : IEnumerable<long>
{
public static readonly long[] Value=A091360.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091360.Bytes);
public long this[int i]=>Value[i];

public static A091360Inst Instance=new A091360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091359
{
public static readonly long[] Value={ 1L,2L,5L,11L,24L,48L,94L,176L,324L,580L,1020L,1757L,2985L,4990L,8237L,13428L,21651L,34540L,54583L,85473L,132730L,204484L,312695L,474814L,716217L,1073558L,1599568L,2369781L,3491812L,5118490L,7465789L,10837964L,15661666L,22533586L,32284480L };
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
public class A091359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091359Inst : IEnumerable<long>
{
public static readonly long[] Value=A091359.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091359.Bytes);
public long this[int i]=>Value[i];

public static A091359Inst Instance=new A091359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091358
{
public static readonly long[] Value={ 1L,2L,5L,11L,24L,46L,90L,164L,298L,520L,899L,1512L,2521L,4116L,6659L,10609L,16753L,26126L,40419L,61889L,94067L,141736L,212123L,315087L,465162L,682188L,994857L,1442340L,2080332L,2984724L,4262018L,6056849L,8569913L,12072770L,16938556L };
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
public class A091358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091358Inst : IEnumerable<long>
{
public static readonly long[] Value=A091358.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091358.Bytes);
public long this[int i]=>Value[i];

public static A091358Inst Instance=new A091358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091357
{
public static readonly long[] Value={ 1L,2L,5L,11L,22L,42L,78L,138L,239L,405L,669L,1088L,1741L,2744L,4267L,6564L,9975L,15019L,22394L,33111L,48549L,70678L,102127L,146636L,209186L,296697L,418401L,586985L,819218L,1137962L,1573336L,2165888L,2968914L,4053563L,5512820L,7469989L };
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
public class A091357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091357Inst : IEnumerable<long>
{
public static readonly long[] Value=A091357.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091357.Bytes);
public long this[int i]=>Value[i];

public static A091357Inst Instance=new A091357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091356
{
public static readonly long[] Value={ 1L,2L,5L,9L,18L,30L,53L,85L,139L,215L,336L,504L,760L,1115L,1635L,2351L,3375L,4770L,6725L,9368L,13006L,17885L,24510L,33319L,45139L,60743L,81457L,108610L,144334L,190844L,251542L,330082L,431825L,562710L,731154L,946644L,1222305L,1573155L,2019471L };
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
public class A091356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091356Inst : IEnumerable<long>
{
public static readonly long[] Value=A091356.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091356.Bytes);
public long this[int i]=>Value[i];

public static A091356Inst Instance=new A091356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091355
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,5L,5L,2L,1L,7L,9L,5L,2L,1L,11L,18L,11L,5L,2L,1L,15L,30L,22L,11L,5L,2L,1L,22L,53L,42L,24L,11L,5L,2L,1L,30L,85L,78L,46L,24L,11L,5L,2L,1L,42L,139L,138L,90L,48L,24L,11L,5L,2L,1L,56L,215L,239L,164L,94L,48L,24L,11L,5L,2L,1L,77L,336L,405L,298L,176L,96L,48L,24L,11L,5L,2L,1L,101L,504L,669L,520L,324L,180L,96L,48L,24L,11L,5L,2L,1L };
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
public class A091355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091355Inst : IEnumerable<long>
{
public static readonly long[] Value=A091355.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091355.Bytes);
public long this[int i]=>Value[i];

public static A091355Inst Instance=new A091355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091354
{
public static readonly long[] Value={ 1L,4L,16L,70L,344L,1908L,11904L,83028L,642960L,5490560L,51373420L,523581128L,5781166688L,68819889018L,879350377816L,12012238559559L,174794145558664L,2700485871440464L,44163954923956850L,762460145368056070L };
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
public class A091354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091354Inst : IEnumerable<long>
{
public static readonly long[] Value=A091354.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091354.Bytes);
public long this[int i]=>Value[i];

public static A091354Inst Instance=new A091354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091353
{
public static readonly long[] Value={ 1L,3L,9L,30L,115L,510L,2602L,15133L,99367L,729962L,5949393L,53392902L,524077321L,5592200388L,64520858034L,801031071955L,10654883235991L,151253483735767L,2283450321888155L,36544617881242655L,618220383026770560L };
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
public class A091353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091353Inst : IEnumerable<long>
{
public static readonly long[] Value=A091353.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091353.Bytes);
public long this[int i]=>Value[i];

public static A091353Inst Instance=new A091353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091352
{
public static readonly long[] Value={ 1L,2L,4L,9L,24L,77L,295L,1329L,6934L,41351L,278680L,2101434L,17574552L,161740316L,1626733108L,17771416521L,209739328924L,2661301094008L,36148700652163L,523597247829867L,8059284921781892L,131408547139817541L };
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
public class A091352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091352Inst : IEnumerable<long>
{
public static readonly long[] Value=A091352.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091352.Bytes);
public long this[int i]=>Value[i];

public static A091352Inst Instance=new A091352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091351
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,4L,3L,1L,1L,9L,9L,4L,1L,1L,24L,30L,16L,5L,1L,1L,77L,115L,70L,25L,6L,1L,1L,295L,510L,344L,135L,36L,7L,1L,1L,1329L,2602L,1908L,805L,231L,49L,8L,1L,1L,6934L,15133L,11904L,5325L,1616L,364L,64L,9L,1L,1L,41351L,99367L,83028L,39001L,12381L,2919L,540L,81L,10L,1L };
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
public class A091351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091351Inst : IEnumerable<long>
{
public static readonly long[] Value=A091351.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091351.Bytes);
public long this[int i]=>Value[i];

public static A091351Inst Instance=new A091351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091350
{
public static readonly long[] Value={ 8L,2L,6L,90L,30L,390L,690L,420L,210L,4290L,3990L,8778L,2310L,3570L,4830L,11550L,38850L,84630L,66990L,79170L,39270L,30030L,51870L,46410L,43890L,111930L,163020L,221340L,419430L,131670L,1902810L,1385670L,1009470L,1452990L,746130L,903210L,570570L,1067430L,1531530L };
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
public class A091350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091350Inst : IEnumerable<long>
{
public static readonly long[] Value=A091350.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091350.Bytes);
public long this[int i]=>Value[i];

public static A091350Inst Instance=new A091350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091349
{
public static readonly long[] Value={ 1L,0L,0L,4L,4L,5L,7L,1L,9L,8L,2L,0L,1L,5L,7L,4L,0L,2L,7L,5L,5L,4L,1L,4L,0L,2L,5L,6L,6L,9L,4L,0L,2L,6L,0L,0L,2L,9L,1L,6L,6L,9L,3L,4L,9L,4L,2L,1L,7L,1L,9L,6L,6L,6L,4L,6L,2L,5L,7L,5L,6L,5L,9L,2L,0L,3L,2L,1L,6L,8L,6L,0L,0L,6L,2L,3L,3L,9L,2L,3L,7L,0L,8L,2L,5L,2L,0L,6L,1L,1L,1L,0L,5L,3L,5L,8L,1L,6L,0L,4L };
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
public class A091349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091349Inst : IEnumerable<long>
{
public static readonly long[] Value=A091349.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091349.Bytes);
public long this[int i]=>Value[i];

public static A091349Inst Instance=new A091349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}