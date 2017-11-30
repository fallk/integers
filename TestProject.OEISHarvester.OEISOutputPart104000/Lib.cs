using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A123641
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,2L,0L,1L,0L,4L,1L,0L,2L,0L,8L,0L,1L,0L,4L,0L,16L,1L,0L,2L,0L,8L,0L,32L,0L,1L,0L,4L,0L,16L,0L,64L,1L,0L,2L,0L,8L,0L,32L,0L,128L,0L,1L,0L,4L,0L,16L,0L,64L,0L,256L,1L,0L,2L,0L,8L,0L,32L,0L,128L,0L,512L,0L,1L,0L,4L,0L,16L,0L,64L,0L,256L,0L,1024L,1L };
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
public class A123641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123641Inst : IEnumerable<long>
{
public static readonly long[] Value=A123641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123641.Bytes);
public long this[int i]=>Value[i];

public static A123641Inst Instance=new A123641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123642
{
public static readonly BigInteger[] Value={ 0L,-1L,-2L,-2L,8L,88L,656L,4912L,40064L,362368L,3627776L,39914752L,478997504L,6227012608L,87178274816L,1307674335232L,20922789822464L,355687427964928L,6402373705465856L,121645100408307712L,2432902008175591424L,BigInteger.Parse("51090942171707342848"),BigInteger.Parse("1124000727777603485696") };
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
public class A123642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123642Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A123642.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A123642.Bytes);
public BigInteger this[int i]=>Value[i];

public static A123642Inst Instance=new A123642Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123643
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,12L,24L,25L,27L,32L,59L,60L,69L,74L,86L,111L,126L,135L,139L,163L,222L,226L,365L,371L,372L,478L,540L,609L,795L,917L,965L,989L,1645L,2311L,2639L,2695L,2771L,2794L,3034L,3096L,3773L,4134L,4645L,4987L,5263L,5845L,6468L,8373L,11225L,11471L,12989L };
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
public class A123643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123643Inst : IEnumerable<long>
{
public static readonly long[] Value=A123643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123643.Bytes);
public long this[int i]=>Value[i];

public static A123643Inst Instance=new A123643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123644
{
public static readonly long[] Value={ 0L,2L,3L,7L,8L,9L,13L,31L,32L,33L,34L,42L,54L,71L,81L,92L,96L,133L,149L,150L,157L,214L,234L,254L,297L,335L,386L,396L,425L,542L,618L,656L,666L,759L,1098L,1294L,1378L,1481L,1487L,1549L,1707L,1771L,2004L,2044L,2303L,2528L,2776L,2852L,3700L,4467L,4580L,5453L,6514L };
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
public class A123644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123644Inst : IEnumerable<long>
{
public static readonly long[] Value=A123644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123644.Bytes);
public long this[int i]=>Value[i];

public static A123644Inst Instance=new A123644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123645
{
public static readonly long[] Value={ 2L,5L,6L,10L,19L,31L,47L,62L,91L,97L,196L,226L,264L,355L,349L,274L };
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
public class A123645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123645Inst : IEnumerable<long>
{
public static readonly long[] Value=A123645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123645.Bytes);
public long this[int i]=>Value[i];

public static A123645Inst Instance=new A123645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123646
{
public static readonly BigInteger[] Value={ 5L,13L,97L,2070241L,4338014017L,BigInteger.Parse("3512911982806776822251393039617"),BigInteger.Parse("4457915690803004131256192897205630962697827851093882159977969339137"),BigInteger.Parse("1638935311392320153195136107636665419978585455388636669548298482694235538906271958706896595665141002450684974003603106305516970574177405212679151205373697500164072550932748470956551681") };
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
public class A123646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123646Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A123646.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A123646.Bytes);
public BigInteger this[int i]=>Value[i];

public static A123646Inst Instance=new A123646Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123647
{
public static readonly long[] Value={ 1L,2L,5L,12L,22L,42L,80L,136L,233L,396L,636L,1020L,1622L,2496L,3822L,5808L,8642L,12786L,18788L,27208L,39184L,56088L,79432L,111912L,156823L,217964L,301517L,415104L,567758L,773244L,1048616L,1414432L,1900524L,2543940L,3389792L,4501164L,5956430L };
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
public class A123647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123647Inst : IEnumerable<long>
{
public static readonly long[] Value=A123647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123647.Bytes);
public long this[int i]=>Value[i];

public static A123647Inst Instance=new A123647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123648
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,6L,9L,13L,17L,24L,32L,42L,56L,73L,96L,123L,158L,201L,254L,320L,402L,504L,624L,774L,955L,1172L,1436L,1755L,2138L,2592L,3140L,3789L,4560L,5478L,6564L,7851L,9362L,11146L,13240L,15696L,18574L,21942L,25880L,30456L,35796L,42000L,49196L,57546L };
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
public class A123648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123648Inst : IEnumerable<long>
{
public static readonly long[] Value=A123648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123648.Bytes);
public long this[int i]=>Value[i];

public static A123648Inst Instance=new A123648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123649
{
public static readonly long[] Value={ 1L,-1L,-1L,3L,-2L,-3L,8L,-5L,-7L,18L,-12L,-15L,38L,-24L,-30L,75L,-46L,-57L,140L,-86L,-104L,252L,-152L,-183L,439L,-262L,-313L,744L,-442L,-522L,1232L,-725L,-852L,1998L,-1168L,-1365L,3182L,-1852L,-2150L,4986L,-2886L,-3336L,7700L,-4436L,-5106L,11736L,-6736L,-7719L,17673L,-10103L,-11538L,26322L };
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
public class A123649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123649Inst : IEnumerable<long>
{
public static readonly long[] Value=A123649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123649.Bytes);
public long this[int i]=>Value[i];

public static A123649Inst Instance=new A123649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123650
{
public static readonly long[] Value={ 4L,45L,280L,1105L,3276L,8029L,17200L,33345L,59860L,101101L,162504L,250705L,373660L,540765L,762976L,1052929L,1425060L,1895725L,2483320L,3208401L,4093804L,5164765L,6449040L,7977025L,9781876L,11899629L,14369320L,17233105L,20536380L,24327901L };
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
public class A123650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123650Inst : IEnumerable<long>
{
public static readonly long[] Value=A123650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123650.Bytes);
public long this[int i]=>Value[i];

public static A123650Inst Instance=new A123650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123651
{
public static readonly long[] Value={ 8L,141485L,130914100L,17251189841L,764209065776L,16940083223773L,232729381165100L,2252358161564225L,16679754951397336L,100010100010101101L,505481836542757988L,2218718842990269265L,8650720586711446400L };
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
public class A123651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123651Inst : IEnumerable<long>
{
public static readonly long[] Value=A123651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123651.Bytes);
public long this[int i]=>Value[i];

public static A123651Inst Instance=new A123651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123652
{
public static readonly BigInteger[] Value={ 14L,2339155617965L,BigInteger.Parse("36923966682271786990"),BigInteger.Parse("4854597644377050732053585"),BigInteger.Parse("45547499507677574921923909526"),BigInteger.Parse("80266855145143309588022024772829"),BigInteger.Parse("44586202603279528645530450127574150") };
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
public class A123652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123652Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A123652.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A123652.Bytes);
public BigInteger this[int i]=>Value[i];

public static A123652Inst Instance=new A123652Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123653
{
public static readonly long[] Value={ 1L,6L,21L,68L,198L,510L,1248L,2904L,6393L,13604L,28044L,55956L,108982L,207552L,386622L,707216L,1271970L,2250582L,3925780L,6757272L,11483232L,19290824L,32057352L,52722744L,85884503L,138644292L,221885805L,352241792L,554892894L };
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
public class A123653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123653Inst : IEnumerable<long>
{
public static readonly long[] Value=A123653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123653.Bytes);
public long this[int i]=>Value[i];

public static A123653Inst Instance=new A123653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123654
{
public static readonly long[] Value={ 0L,264L,1491L,2427L,3811L,10764L,16180L,24220L,64711L,96271L,143127L,379120L,563064L,836160L,2211627L,3283731L,4875451L,12892260L,19140940L,28418164L,75143551L,111563527L,165635151L,437970664L,650241840L,965394360L,2552682051L };
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
public class A123654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123654Inst : IEnumerable<long>
{
public static readonly long[] Value=A123654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123654.Bytes);
public long this[int i]=>Value[i];

public static A123654Inst Instance=new A123654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123655
{
public static readonly long[] Value={ 1L,2L,4L,8L,14L,24L,40L,64L,101L,156L,236L,352L,518L,752L,1080L,1536L,2162L,3018L,4180L,5744L,7840L,10632L,14328L,19200L,25591L,33932L,44776L,58816L,76918L,100176L,129952L,167936L,216240L,277476L,354864L,452392L,574958L,728568L,920600L,1160064L };
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
public class A123655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123655Inst : IEnumerable<long>
{
public static readonly long[] Value=A123655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123655.Bytes);
public long this[int i]=>Value[i];

public static A123655Inst Instance=new A123655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123656
{
public static readonly long[] Value={ 3L,81L,811L,4353L,16251L,47953L,120051L,266241L,538003L,1010001L,1786203L,3006721L,4855371L,7567953L,11441251L,16842753L,24221091L,34117201L,47176203L,64160001L,85960603L,113614161L,148315731L,191434753L,244531251L,309372753L,387951931L };
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
public class A123656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123656Inst : IEnumerable<long>
{
public static readonly long[] Value=A123656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123656.Bytes);
public long this[int i]=>Value[i];

public static A123656Inst Instance=new A123656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123657
{
public static readonly long[] Value={ 4L,593L,20494L,266497L,1969376L,10125649L,40473658L,134483969L,387958492L,1001010001L,2359733894L,5162787073L,10609354744L,20668614737L,38454800626L,68736319489L,118612097588L,198393407569L,322734873982L,512064160001L };
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
public class A123657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123657Inst : IEnumerable<long>
{
public static readonly long[] Value=A123657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123657.Bytes);
public long this[int i]=>Value[i];

public static A123657Inst Instance=new A123657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123658
{
public static readonly long[] Value={ 5L,1617L,79543L,1315073L,11735001L,70591825L,322948907L,1208225793L,3874742893L,11001010001L,28297158495L,67080151297L,148467846593L,309923269713L,615105191251L,1168247947265L,2134605998037L,3768860634193L,6453801131783L,10752064160001L,17474246985385L };
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
public class A123658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123658Inst : IEnumerable<long>
{
public static readonly long[] Value=A123658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123658.Bytes);
public long this[int i]=>Value[i];

public static A123658Inst Instance=new A123658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123659
{
public static readonly long[] Value={ 6L,18001L,4862512L,269750529L,6115250626L,78434755921L,678546021756L,4399254736897L,22880667197854L,100011001010001L,379778130741736L,1283985544700161L,3937524853545882L,11112316748827729L,29193541130581876L };
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
public class A123659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123659Inst : IEnumerable<long>
{
public static readonly long[] Value=A123659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123659.Bytes);
public long this[int i]=>Value[i];

public static A123659Inst Instance=new A123659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123660
{
public static readonly long[] Value={ 4L,25L,132L,473L,1469L,4894L,14744L,39776L,105267L,265094L,591209L,1185497L,2215965L,3569692L,4408744L,3597040L };
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
public class A123660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123660Inst : IEnumerable<long>
{
public static readonly long[] Value=A123660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123660.Bytes);
public long this[int i]=>Value[i];

public static A123660Inst Instance=new A123660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123661
{
public static readonly long[] Value={ 8L,75L,346L,1284L,4408L,13534L,40148L,113583L,299614L,744570L,1718108L,3628442L,6915782L,11810625L,17106283L };
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
public class A123661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123661Inst : IEnumerable<long>
{
public static readonly long[] Value=A123661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123661.Bytes);
public long this[int i]=>Value[i];

public static A123661Inst Instance=new A123661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123662
{
public static readonly long[] Value={ 16L,21L,129L,121L,553L,462L,2001L,1454L,6808L,4111L,21081L,11349L,63181L,29269L,180890L,71268L,481635L,163071L,1217590L,344829L,2848636L,647233L,6121628L,1113172L,11846227L,1677481L,20694386L,2076402L,30600504L };
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
public class A123662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123662Inst : IEnumerable<long>
{
public static readonly long[] Value=A123662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123662.Bytes);
public long this[int i]=>Value[i];

public static A123662Inst Instance=new A123662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123663
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,7L,8L,10L,12L,13L,15L,17L,18L,20L,22L,24L,25L,27L,29L,31L,32L,34L,36L,38L,40L,41L,43L,45L,47L,49L,50L,52L,54L,56L,58L,60L,61L,63L,65L,67L,69L,71L,72L,74L,76L,78L,80L,82L,84L,85L,87L,89L,91L,93L,95L,97L,98L,100L,102L,104L,106L,108L,110L,112L,113L,115L,117L,119L };
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
public class A123663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123663Inst : IEnumerable<long>
{
public static readonly long[] Value=A123663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123663.Bytes);
public long this[int i]=>Value[i];

public static A123663Inst Instance=new A123663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123664
{
public static readonly long[] Value={ 1L,2L,3L,6L,4L,8L,12L,24L,48L,72L,144L,5L,10L,15L,20L,30L,40L,60L,80L,90L,120L,160L,180L,240L,320L,360L,480L,720L,960L,1080L,1440L,1920L,2160L,2880L,3840L,4320L,5760L,6480L,7680L,8640L,11520L,12960L,15360L,17280L,23040L,25920L,34560L,46080L,51840L,69120L,77760L };
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
public class A123664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123664Inst : IEnumerable<long>
{
public static readonly long[] Value=A123664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123664.Bytes);
public long this[int i]=>Value[i];

public static A123664Inst Instance=new A123664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123665
{
public static readonly BigInteger[] Value={ 22L,471260364628084305L,BigInteger.Parse("6457022669043550542502557676"),BigInteger.Parse("105149403852520725445003265581519105"),BigInteger.Parse("41911381174488637014293971538580334000626") };
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
public class A123665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123665Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A123665.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A123665.Bytes);
public BigInteger this[int i]=>Value[i];

public static A123665Inst Instance=new A123665Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123666
{
public static readonly long[] Value={ 1L,4L,6L,10L,14L,16L,22L,24L,26L,34L,36L,38L,40L,46L,56L,58L,60L,62L,64L,74L,82L,84L,86L,88L,94L,96L,100L,104L,106L,118L,122L,132L,134L,136L,140L,142L,144L,146L,152L,156L,158L,160L,166L,178L,184L,194L,196L,202L,204L,206L,214L,216L,218L,220L,224L,226L,228L,232L,240L };
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
public class A123666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123666Inst : IEnumerable<long>
{
public static readonly long[] Value=A123666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123666.Bytes);
public long this[int i]=>Value[i];

public static A123666Inst Instance=new A123666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123667
{
public static readonly long[] Value={ 1L,4L,6L,16L,10L,24L,14L,64L,36L,40L,22L,96L,26L,56L,60L,256L,34L,144L,38L,160L,84L,88L,46L,384L,100L,104L,216L,224L,58L,240L,62L,1024L,132L,136L,140L,576L,74L,152L,156L,640L,82L,336L,86L,352L,360L,184L,94L,1536L,196L,400L,204L,416L,106L,864L,220L,896L,228L,232L,118L };
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
public class A123667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123667Inst : IEnumerable<long>
{
public static readonly long[] Value=A123667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123667.Bytes);
public long this[int i]=>Value[i];

public static A123667Inst Instance=new A123667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123668
{
public static readonly BigInteger[] Value={ 1L,5L,100L,4833L,434176L,64896625L,14555276100L,4566338422401L,1907710008707584L,1023456789876543201L,BigInteger.Parse("685593403921020830500"),BigInteger.Parse("560806213771094855054689"),BigInteger.Parse("550049712286417194431060352") };
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
public class A123668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123668Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A123668.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A123668.Bytes);
public BigInteger this[int i]=>Value[i];

public static A123668Inst Instance=new A123668Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123669
{
public static readonly long[] Value={ 5L,17L,37L,-1L,101L };
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
public class A123669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123669Inst : IEnumerable<long>
{
public static readonly long[] Value=A123669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123669.Bytes);
public long this[int i]=>Value[i];

public static A123669Inst Instance=new A123669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123670
{
public static readonly long[] Value={ 1L,4L,-2L,27L,-27L,6L,256L,-384L,176L,-24L,3125L,-6250L,4375L,-1250L,120L,46656L,-116640L,110160L,-48600L,9864L,-720L,823543L,-2470629L,2941225L,-1764735L,557032L,-86436L,5040L,16777216L,-58720256L,84410368L,-64225280L,27725824L,-6723584L,836352L,-40320L,387420489L,-1549681956L };
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
public class A123670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123670Inst : IEnumerable<long>
{
public static readonly long[] Value=A123670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123670.Bytes);
public long this[int i]=>Value[i];

public static A123670Inst Instance=new A123670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123671
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,2L,0L,1L,0L,1L,0L,1L,0L,0L,0L,2L,0L,1L,1L,1L,0L };
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
public class A123671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123671Inst : IEnumerable<long>
{
public static readonly long[] Value=A123671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123671.Bytes);
public long this[int i]=>Value[i];

public static A123671Inst Instance=new A123671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123672
{
public static readonly BigInteger[] Value={ 1L,4L,27L,406L,12585L,792856L,100692711L,25676641306L,13120763707365L,13422541272634396L,BigInteger.Parse("27475941985082608611"),BigInteger.Parse("112513982428913282262046"),BigInteger.Parse("921602030075228695008418785"),BigInteger.Parse("15098606058722471710322924954656") };
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
public class A123672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123672Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A123672.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A123672.Bytes);
public BigInteger this[int i]=>Value[i];

public static A123672Inst Instance=new A123672Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123673
{
public static readonly long[] Value={ 111L,222L,333L,444L,555L,666L,777L,888L,999L,1110L,1145L,1221L,1332L,1443L,1554L,1665L,1776L,1887L,1998L,2109L,2220L,2290L,2331L,2442L,2553L,2664L,2775L,2886L,2997L,3108L,3219L,3272L,3330L,3435L,3441L,3552L,3663L,3774L,3885L,3996L,4107L,4218L,4329L,4440L };
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
public class A123673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123673Inst : IEnumerable<long>
{
public static readonly long[] Value=A123673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123673.Bytes);
public long this[int i]=>Value[i];

public static A123673Inst Instance=new A123673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123674
{
public static readonly long[] Value={ 0L,1L,2L,2L,4L,2L,3L,2L,4L,2L,2L,2L,3L,3L,1L,2L,4L,0L,3L,4L,4L,3L,3L,3L,0L,1L,1L,0L,2L,1L,1L,1L,3L,2L,3L,2L,2L,0L,1L,2L,2L,3L,0L,0L,4L,4L,3L,2L,5L,4L,4L,0L,0L,0L,1L,1L,4L,5L,2L,4L,3L,3L,0L,1L,1L,2L,5L,0L,1L,1L,4L,3L,1L,0L,1L,1L,3L,2L,3L,0L,2L,4L,2L,1L,2L,2L,3L,0L,7L,2L,4L,4L,2L,2L,2L,3L,5L,0L,3L,1L,1L,1L,3L,3L,2L };
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
public class A123674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123674Inst : IEnumerable<long>
{
public static readonly long[] Value=A123674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123674.Bytes);
public long this[int i]=>Value[i];

public static A123674Inst Instance=new A123674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123675
{
public static readonly long[] Value={ 0L,1L,2L,1L,2L,1L,3L,2L,1L,1L,1L,2L,2L,1L,1L,0L,2L,2L,1L,1L,1L,1L,0L,2L,1L,4L,2L,3L,1L,0L,2L,2L,4L,1L,0L,3L,2L,2L,3L,0L,0L,2L,0L,3L,0L,1L,0L,1L,1L,2L,0L,3L,1L,0L,1L,2L,1L,1L,3L,0L,3L,2L,2L,2L,0L,3L,0L,2L,1L,0L,2L,1L,2L,2L,1L,2L,1L,1L,1L,1L,2L,1L,0L,0L,0L,0L,0L,2L,1L,1L,1L,2L,1L,3L,1L,0L,2L,2L,4L,2L,2L,1L,0L,3L,0L };
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
public class A123675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123675Inst : IEnumerable<long>
{
public static readonly long[] Value=A123675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123675.Bytes);
public long this[int i]=>Value[i];

public static A123675Inst Instance=new A123675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123676
{
public static readonly long[] Value={ 1L,-3L,3L,-2L,3L,-6L,10L,-12L,15L,-22L,30L,-36L,44L,-60L,78L,-96L,117L,-150L,190L,-228L,276L,-340L,420L,-504L,603L,-732L,885L,-1052L,1245L,-1488L,1770L,-2088L,2454L,-2902L,3420L,-3996L,4666L,-5460L,6378L,-7400L,8583L,-9972L,11566L,-13344L,15378L,-17752L,20448L,-23472L,26904L,-30876L };
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
public class A123676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123676Inst : IEnumerable<long>
{
public static readonly long[] Value=A123676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123676.Bytes);
public long this[int i]=>Value[i];

public static A123676Inst Instance=new A123676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123677
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,71L,113L,643L,769L,13681L,51929L };
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
public class A123677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123677Inst : IEnumerable<long>
{
public static readonly long[] Value=A123677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123677.Bytes);
public long this[int i]=>Value[i];

public static A123677Inst Instance=new A123677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123678
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,20L,30L,117L,136L,1616L,5313L };
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
public class A123678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123678Inst : IEnumerable<long>
{
public static readonly long[] Value=A123678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123678.Bytes);
public long this[int i]=>Value[i];

public static A123678Inst Instance=new A123678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123679
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,2L,0L,0L,1L,2L,3L,0L,0L,0L,1L,0L,1L,2L,3L,4L,0L,0L,0L,0L,1L,0L,1L,0L,1L,2L,0L,0L,1L,2L,3L,4L,5L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,2L,0L,0L,1L,2L,0L,0L,1L,2L,3L,0L,0L,0L,1L,0L,1L,2L,3L,4L,5L,6L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,2L,0L,0L,1L,2L,0L,0L,1L,2L,0L,0L,1L,2L,3L,0L,0L,0L,1L,0L };
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
public class A123679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123679Inst : IEnumerable<long>
{
public static readonly long[] Value=A123679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123679.Bytes);
public long this[int i]=>Value[i];

public static A123679Inst Instance=new A123679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123680
{
public static readonly BigInteger[] Value={ 1L,2L,9L,76L,985L,17046L,366289L,9374968L,278095761L,9375293170L,353906211241L,14785127222724L,677150215857193L,33734100501544366L,1816008001717251105L,BigInteger.Parse("105048613959883117936"),BigInteger.Parse("6497985798745934394529"),BigInteger.Parse("427999600108502895779658") };
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
public class A123680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123680Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A123680.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A123680.Bytes);
public BigInteger this[int i]=>Value[i];

public static A123680Inst Instance=new A123680Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123681
{
public static readonly BigInteger[] Value={ 1L,1L,3L,19L,197L,2841L,52327L,1171871L,30899529L,937529317L,32173291931L,1232093935227L,52088478142861L,2409578607253169L,121067200114483407L,6565538372492694871L,BigInteger.Parse("382234458749760846737"),BigInteger.Parse("23777755561583494209981") };
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
public class A123681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123681Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A123681.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A123681.Bytes);
public BigInteger this[int i]=>Value[i];

public static A123681Inst Instance=new A123681Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123682
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,0L,2L,2L,1L,1L,1L,3L,3L,1L,0L,2L,2L,4L,4L,1L,1L,1L,3L,3L,5L,5L,1L,0L,2L,2L,4L,4L,6L,6L,1L,1L,1L,3L,3L,5L,5L,7L,7L,1L };
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
public class A123682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123682Inst : IEnumerable<long>
{
public static readonly long[] Value=A123682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123682.Bytes);
public long this[int i]=>Value[i];

public static A123682Inst Instance=new A123682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123683
{
public static readonly long[] Value={ 0L,1L,1L,0L,4L,3L,1L,2L,9L,6L,0L,4L,6L,16L,10L,1L,2L,9L,12L,25L,15L,0L,4L,6L,16L,20L,36L,21L,1L,2L,9L,12L,25L,30L,49L,28L };
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
public class A123683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123683Inst : IEnumerable<long>
{
public static readonly long[] Value=A123683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123683.Bytes);
public long this[int i]=>Value[i];

public static A123683Inst Instance=new A123683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123684
{
public static readonly long[] Value={ 1L,1L,4L,2L,7L,3L,10L,4L,13L,5L,16L,6L,19L,7L,22L,8L,25L,9L,28L,10L,31L,11L,34L,12L,37L,13L,40L,14L,43L,15L,46L,16L,49L,17L,52L,18L,55L,19L,58L,20L,61L,21L,64L,22L,67L,23L,70L,24L,73L,25L,76L,26L,79L,27L,82L,28L,85L,29L,88L,30L,91L,31L,94L,32L,97L,33L,100L,34L,103L,35L,106L,36L };
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
public class A123684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123684Inst : IEnumerable<long>
{
public static readonly long[] Value=A123684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123684.Bytes);
public long this[int i]=>Value[i];

public static A123684Inst Instance=new A123684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123685
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,1L,3L,4L,0L,1L,7L,14L,2L,1L,1L,15L,46L,14L,7L,0L,1L,31L,146L,74L,43L,3L,1L,1L,63L,454L,350L,247L,33L,10L,0L,1L,127L,1394L,1562L,1363L,273L,88L,4L,1L,1L,255L,4246L,6734L,7327L,2013L,724L,60L,13L,0L,1L,511L,12866L,28394L,38683L,13953L,5716L,676L,149L,5L,1L,1L };
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
public class A123685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123685Inst : IEnumerable<long>
{
public static readonly long[] Value=A123685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123685.Bytes);
public long this[int i]=>Value[i];

public static A123685Inst Instance=new A123685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123686
{
public static readonly BigInteger[] Value={ 1L,2L,54L,2460L,239190L,33124140L,6896500380L,1879519201560L,674900483206950L,300426422192196300L,BigInteger.Parse("164868151446145847700"),BigInteger.Parse("108046627817926248851400"),BigInteger.Parse("83890281074290204071858300"),BigInteger.Parse("75722368306901033144261835000") };
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
public class A123686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123686Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A123686.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A123686.Bytes);
public BigInteger this[int i]=>Value[i];

public static A123686Inst Instance=new A123686Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123687
{
public static readonly BigInteger[] Value={ 1L,3L,63L,3225L,297675L,42805665L,8790957945L,2433297161295L,870928551367875L,390718610250593625L,BigInteger.Parse("214426984078881899325"),BigInteger.Parse("141173178618822867992475"),BigInteger.Parse("109729771971447612972712725"),BigInteger.Parse("99352716603692210781106359375") };
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
public class A123687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123687Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A123687.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A123687.Bytes);
public BigInteger this[int i]=>Value[i];

public static A123687Inst Instance=new A123687Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123688
{
public static readonly long[] Value={ 1L,3L,6L,5L,8L,7L,7L,11L,8L,9L,9L,12L,7L,11L,12L,11L,16L,8L,13L,12L,13L,16L,8L,7L,8L,8L,12L,6L,8L,14L,13L,5L,16L,13L,11L,19L,16L,8L,20L,19L,15L,11L,12L,13L,7L,9L,8L,9L,14L,6L,12L,11L,13L,20L,18L,13L,9L,12L,14L,13L,14L,11L,13L,14L,13L,13L,16L,13L,10L,10L,17L,20L,10L,13L,10L,20L,11L,19L,17L };
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
public class A123688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123688Inst : IEnumerable<long>
{
public static readonly long[] Value=A123688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123688.Bytes);
public long this[int i]=>Value[i];

public static A123688Inst Instance=new A123688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123689
{
public static readonly long[] Value={ 0L,2L,4L,10L,16L,26L,32L,46L,60L,74L,88L,108L,124L,146L,172L,194L,216L,248L,276L,308L };
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
public class A123689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123689Inst : IEnumerable<long>
{
public static readonly long[] Value=A123689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123689.Bytes);
public long this[int i]=>Value[i];

public static A123689Inst Instance=new A123689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123690
{
public static readonly long[] Value={ 2L,5L,9L,14L,22L,32L,41L,52L,69L,81L,97L,116L,137L,157L,180L,208L,231L,258L,293L,319L };
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
public class A123690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123690Inst : IEnumerable<long>
{
public static readonly long[] Value=A123690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123690.Bytes);
public long this[int i]=>Value[i];

public static A123690Inst Instance=new A123690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123691
{
public static readonly BigInteger[] Value={ 1L,3L,21L,210L,2574L,36036L,554268L,9145422L,159352050L,2900207310L,54698315490L,1062710129520L,21172455657360L,431010704453400L,8939669081780520L,188478023140872630L,4031562420682009290L,BigInteger.Parse("87350519114776867950"),BigInteger.Parse("1914486941500560677250"),BigInteger.Parse("42397183540866961907100") };
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
public class A123691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123691Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A123691.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A123691.Bytes);
public BigInteger this[int i]=>Value[i];

public static A123691Inst Instance=new A123691Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123692
{
public static readonly long[] Value={ 2L,20771L,40487L,53471161L,1645333507L,6692367337L,188748146801L };
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
public class A123692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123692Inst : IEnumerable<long>
{
public static readonly long[] Value=A123692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123692.Bytes);
public long this[int i]=>Value[i];

public static A123692Inst Instance=new A123692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123693
{
public static readonly long[] Value={ 5L,491531L };
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
public class A123693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123693Inst : IEnumerable<long>
{
public static readonly long[] Value=A123693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123693.Bytes);
public long this[int i]=>Value[i];

public static A123693Inst Instance=new A123693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123694
{
public static readonly long[] Value={ 0L,7L,91L,92L,93L,94L,95L,114L,115L,116L,117L,118L,4207L,4209L,4211L,4214L,4216L,4299L,4301L,4303L,4305L,4307L,1228L,1229L,1230L,1231L,1232L,1233L,1234L,1235L,1236L,1237L,1238L,1239L,1240L,1241L,1242L,1243L,1244L,1245L,1246L,1247L,1248L,1249L,1250L,1347L };
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
public class A123694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123694Inst : IEnumerable<long>
{
public static readonly long[] Value=A123694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123694.Bytes);
public long this[int i]=>Value[i];

public static A123694Inst Instance=new A123694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123695
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,7L,8L,5L,4L,14L,15L,16L,17L,18L,19L,20L,21L,11L,12L,22L,13L,9L,10L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,28L,29L,59L,30L,31L,32L,60L,61L,62L,33L,34L,63L,35L,23L,24L,64L,36L,25L,26L,27L,107L,108L,109L,110L,111L };
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
public class A123695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123695Inst : IEnumerable<long>
{
public static readonly long[] Value=A123695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123695.Bytes);
public long this[int i]=>Value[i];

public static A123695Inst Instance=new A123695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123696
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,7L,4L,5L,6L,21L,22L,17L,18L,20L,9L,10L,11L,12L,13L,14L,15L,16L,19L,58L,59L,62L,63L,64L,45L,46L,48L,49L,50L,54L,55L,57L,61L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,47L,51L,52L,53L,56L,60L,170L,171L,174L,175L,176L };
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
public class A123696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123696Inst : IEnumerable<long>
{
public static readonly long[] Value=A123696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123696.Bytes);
public long this[int i]=>Value[i];

public static A123696Inst Instance=new A123696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123697
{
public static readonly long[] Value={ 1145L,2290L,3272L,3435L,4580L,5551L,5725L,6544L,6870L,8015L,9160L,9816L,10305L,11102L,11450L,12595L,13088L,13740L,14885L,16030L,16360L,17175L,18320L,19465L,19632L,20610L,22904L,25220L,26176L };
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
public class A123697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123697Inst : IEnumerable<long>
{
public static readonly long[] Value=A123697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123697.Bytes);
public long this[int i]=>Value[i];

public static A123697Inst Instance=new A123697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123698
{
public static readonly long[] Value={ 1L,111L,1L,111L,11011L,111L,1L,111L,11011L,1100011L,11011L,111L,1L,111L,11011L,1100011L,110000011L,1100011L,11011L,111L,1L };
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
public class A123698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123698Inst : IEnumerable<long>
{
public static readonly long[] Value=A123698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123698.Bytes);
public long this[int i]=>Value[i];

public static A123698Inst Instance=new A123698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123699
{
public static readonly long[] Value={ 1L,2L,3L,4L,3L,3L,3L,4L,4L,5L,3L,4L,4L,4L,3L,5L,5L,4L,3L,5L,3L,5L,5L,4L,6L,6L,4L,4L,5L,4L,6L,6L,4L,6L,4L,4L,7L,5L,4L,5L,6L,5L,7L,4L,4L,7L,5L,5L,4L,4L,5L,4L,5L,4L,5L,4L,4L,5L,5L,6L,8L,6L,6L,9L,5L,5L,7L,6L,5L,5L,5L,7L,5L,7L,4L,5L,5L,4L,5L,5L,6L,5L,6L,5L,5L,5L,7L,7L,5L,6L,6L,8L,7L,6L,5L,5L,5L,8L,4L,11L,5L,5L,5L,7L,5L };
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
public class A123699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123699Inst : IEnumerable<long>
{
public static readonly long[] Value=A123699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123699.Bytes);
public long this[int i]=>Value[i];

public static A123699Inst Instance=new A123699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123700
{
public static readonly long[] Value={ 1L,2L,3L,4L,10L,25L,37L,61L,64L,173L,100L,1020L,1565L,1595L,2323L,3013L,3771L,11838L,9266L,30407L,56267L,46865L,117612L,143083L,216156L,412555L,413711L,818330L,1846411L,2432526L,2094521L,6909827L,15457515L,12960133L,40274514L,30277528L };
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
public class A123700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123700Inst : IEnumerable<long>
{
public static readonly long[] Value=A123700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123700.Bytes);
public long this[int i]=>Value[i];

public static A123700Inst Instance=new A123700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123701
{
public static readonly long[] Value={ 3L,5L,1L,1L,2L,1L,2L,1L,2L,3L,8L,1L,6L,1L,68L,-1L,2L,1L,2L,1L,32L };
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
public class A123701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123701Inst : IEnumerable<long>
{
public static readonly long[] Value=A123701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123701.Bytes);
public long this[int i]=>Value[i];

public static A123701Inst Instance=new A123701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123702
{
public static readonly BigInteger[] Value={ 1L,1L,-1L,-2L,3L,4L,18L,408L,175824L,30989858688L,BigInteger.Parse("960376803619751958528"),BigInteger.Parse("922323604960653729254933704147036248735744"),BigInteger.Parse("850680832267616036448642743307003648114050501920269009809993262836200003241653567488") };
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
public class A123702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123702Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A123702.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A123702.Bytes);
public BigInteger this[int i]=>Value[i];

public static A123702Inst Instance=new A123702Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123703
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2L,3L,2L,2L,12L,264L,75744L,5758891776L,BigInteger.Parse("33165272341980979200"),BigInteger.Parse("1099935289708766240667530888404210286592"),BigInteger.Parse("1209857641546707521062997518664689369471121315619387834957574646785625397657600") };
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
public class A123703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123703Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A123703.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A123703.Bytes);
public BigInteger this[int i]=>Value[i];

public static A123703Inst Instance=new A123703Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123704
{
public static readonly long[] Value={ 6L,8L,9L,11L,15L,31L,48L,60L,314L,701L,940L,942L };
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
public class A123704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123704Inst : IEnumerable<long>
{
public static readonly long[] Value=A123704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123704.Bytes);
public long this[int i]=>Value[i];

public static A123704Inst Instance=new A123704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123705
{
public static readonly BigInteger[] Value={ 609554401L,9536162033329L,5960417405949649L,BigInteger.Parse("2328306127701998147089"),BigInteger.Parse("355271367866755685756083382145169"),BigInteger.Parse("29387358770557187699218413428591111182510208390715375894150039546014062887655539136439569") };
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
public class A123705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123705Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A123705.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A123705.Bytes);
public BigInteger this[int i]=>Value[i];

public static A123705Inst Instance=new A123705Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123706
{
public static readonly long[] Value={ 1L,-2L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,-1L,0L,0L,-1L,1L,2L,0L,-1L,0L,-1L,1L,-1L,0L,0L,0L,0L,-1L,1L,0L,0L,1L,-1L,0L,0L,-1L,1L,0L,1L,-1L,0L,0L,0L,0L,-1L,1L,2L,-1L,0L,1L,-1L,0L,0L,0L,-1L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,0L,0L,0L,0L,-1L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,1L,2L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,-1L,1L,1L,1L,-1L,1L,-1L,0L,0L,0L };
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
public class A123706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123706Inst : IEnumerable<long>
{
public static readonly long[] Value=A123706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123706.Bytes);
public long this[int i]=>Value[i];

public static A123706Inst Instance=new A123706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123707
{
public static readonly long[] Value={ 1L,0L,1L,3L,7L,14L,31L,60L,126L,248L,511L,1005L,2047L,4064L,8183L,16320L,32767L,65394L,131071L,261885L,524255L,1048064L,2097151L,4193220L,8388600L,16775168L,33554304L,67104765L,134217727L,268427002L,536870911L,1073725440L,2147483135L };
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
public class A123707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123707Inst : IEnumerable<long>
{
public static readonly long[] Value=A123707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123707.Bytes);
public long this[int i]=>Value[i];

public static A123707Inst Instance=new A123707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123708
{
public static readonly long[] Value={ 1L,3L,3L,4L,3L,5L,3L,4L,4L,7L,3L,8L,3L,7L,7L,4L,3L,8L,3L,8L,7L,7L,3L,8L,4L,7L,4L,8L,3L,13L,3L,4L,7L,7L,7L,8L,3L,7L,7L,8L,3L,13L,3L,8L,8L,7L,3L,8L,4L,8L,7L,8L,3L,8L,7L,8L,7L,7L,3L,16L,3L,7L,8L,4L,7L,13L,3L,8L,7L,15L,3L,8L,3L,7L,8L,8L,7L,13L,3L,8L,4L,7L,3L,16L,7L,7L,7L,8L,3L,16L,7L,8L,7L,7L,7L,8L,3L,8L,8L,8L,3L,13L };
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
public class A123708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123708Inst : IEnumerable<long>
{
public static readonly long[] Value=A123708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123708.Bytes);
public long this[int i]=>Value[i];

public static A123708Inst Instance=new A123708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123709
{
public static readonly long[] Value={ 1L,2L,3L,4L,3L,4L,3L,4L,4L,6L,3L,8L,3L,6L,7L,4L,3L,8L,3L,8L,7L,6L,3L,8L,4L,6L,4L,8L,3L,11L,3L,4L,7L,6L,7L,8L,3L,6L,7L,8L,3L,11L,3L,8L,8L,6L,3L,8L,4L,8L,7L,8L,3L,8L,7L,8L,7L,6L,3L,16L,3L,6L,8L,4L,7L,12L,3L,8L,7L,14L,3L,8L,3L,6L,8L,8L };
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
public class A123709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123709Inst : IEnumerable<long>
{
public static readonly long[] Value=A123709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123709.Bytes);
public long this[int i]=>Value[i];

public static A123709Inst Instance=new A123709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123710
{
public static readonly long[] Value={ 4L,6L,8L,9L,16L,25L,27L,32L,49L,64L,81L,121L,125L,128L,169L,243L,256L,289L,343L,361L,512L,529L,625L,729L,841L,961L,1024L };
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
public class A123710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123710Inst : IEnumerable<long>
{
public static readonly long[] Value=A123710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123710.Bytes);
public long this[int i]=>Value[i];

public static A123710Inst Instance=new A123710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123711
{
public static readonly long[] Value={ 12L,18L,20L,24L,28L,36L,40L,44L,45L,48L,50L,52L,54L,56L,63L,68L,72L,75L,76L,80L,88L,92L,96L,98L,99L,100L,104L,108L,112L,116L,117L,124L,135L,136L,144L,147L,148L,152L,153L,160L,162L,164L,171L,172L,175L,176L,184L,188L,189L,192L,196L,200L,207L,208L,212L,216L,224L,225L };
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
public class A123711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123711Inst : IEnumerable<long>
{
public static readonly long[] Value=A123711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123711.Bytes);
public long this[int i]=>Value[i];

public static A123711Inst Instance=new A123711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123712
{
public static readonly long[] Value={ 60L,84L,90L,120L,126L,132L,140L,150L,156L,168L,180L,198L,204L,220L,228L,234L,240L,252L,260L,264L,270L,276L,280L,294L,300L,306L,308L,312L,315L,336L,340L,342L,348L,350L,360L,364L,372L,378L,380L,396L,408L,414L,440L,444L,450L,456L,460L,468L,476L,480L,490L,492L };
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
public class A123712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123712Inst : IEnumerable<long>
{
public static readonly long[] Value=A123712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123712.Bytes);
public long this[int i]=>Value[i];

public static A123712Inst Instance=new A123712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123713
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,8L,6L,9L,10L,11L,12L,13L,17L,18L,20L,21L,22L,16L,19L,14L,15L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,45L,46L,48L,49L,50L,54L,55L,57L,58L,59L,61L,62L,63L,64L,44L,47L,53L,56L,60L,42L,51L,37L,38L,43L,52L,39L,40L,41L,65L,66L,67L,68L,69L,70L,71L };
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
public class A123713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123713Inst : IEnumerable<long>
{
public static readonly long[] Value=A123713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123713.Bytes);
public long this[int i]=>Value[i];

public static A123713Inst Instance=new A123713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123714
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,8L,6L,7L,9L,10L,11L,12L,13L,21L,22L,19L,14L,15L,20L,16L,17L,18L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,58L,59L,62L,63L,64L,56L,60L,51L,37L,38L,52L,39L,40L,41L,57L,61L,53L,42L,43L,54L,44L,45L,46L,55L,47L,48L,49L,50L,65L,66L,67L,68L,69L,70L,71L };
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
public class A123714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123714Inst : IEnumerable<long>
{
public static readonly long[] Value=A123714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123714.Bytes);
public long this[int i]=>Value[i];

public static A123714Inst Instance=new A123714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123715
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,8L,6L,7L,5L,9L,13L,20L,21L,22L,14L,19L,16L,17L,18L,15L,11L,12L,10L,23L,27L,34L,35L,36L,54L,55L,57L,58L,59L,61L,62L,63L,64L,37L,41L,53L,56L,60L,42L,51L,44L,45L,46L,47L,48L,49L,50L,43L,52L,39L,28L,33L,40L,30L,31L,32L,38L,29L,25L,26L,24L,65L,69L,76L,77L,78L,96L,97L };
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
public class A123715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123715Inst : IEnumerable<long>
{
public static readonly long[] Value=A123715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123715.Bytes);
public long this[int i]=>Value[i];

public static A123715Inst Instance=new A123715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123716
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,8L,6L,7L,5L,9L,22L,20L,21L,10L,14L,19L,16L,17L,18L,15L,11L,12L,13L,23L,64L,62L,63L,24L,54L,61L,57L,58L,59L,55L,25L,26L,27L,37L,60L,53L,56L,38L,42L,51L,44L,45L,46L,47L,48L,49L,50L,43L,52L,39L,28L,29L,40L,30L,31L,32L,41L,33L,34L,35L,36L,65L,196L,194L,195L,66L };
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
public class A123716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123716Inst : IEnumerable<long>
{
public static readonly long[] Value=A123716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123716.Bytes);
public long this[int i]=>Value[i];

public static A123716Inst Instance=new A123716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123717
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,5L,8L,7L,9L,11L,14L,16L,19L,10L,15L,13L,21L,22L,12L,20L,17L,18L,23L,25L,28L,30L,33L,37L,39L,42L,44L,47L,51L,53L,56L,60L,24L,29L,38L,43L,52L,27L,41L,35L,58L,59L,36L,62L,63L,64L,26L,40L,34L,57L,61L,31L,54L,45L,46L,32L,55L,48L,49L,50L,65L,67L,70L,72L,75L,79L,81L };
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
public class A123717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123717Inst : IEnumerable<long>
{
public static readonly long[] Value=A123717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123717.Bytes);
public long this[int i]=>Value[i];

public static A123717Inst Instance=new A123717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123718
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,5L,8L,7L,9L,14L,10L,19L,16L,11L,15L,12L,21L,22L,13L,20L,17L,18L,23L,37L,24L,51L,42L,25L,38L,26L,56L,60L,27L,53L,44L,47L,28L,39L,29L,52L,43L,30L,40L,31L,58L,59L,32L,62L,63L,64L,33L,41L,34L,57L,61L,35L,54L,45L,46L,36L,55L,48L,49L,50L,65L,107L,66L,149L,121L,67L };
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
public class A123718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123718Inst : IEnumerable<long>
{
public static readonly long[] Value=A123718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123718.Bytes);
public long this[int i]=>Value[i];

public static A123718Inst Instance=new A123718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123719
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,21L,19L,20L,18L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,35L,33L,34L,32L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,58L,56L,54L,49L,63L,51L,52L,53L,48L,62L,47L,57L,46L,59L,60L,61L,55L,50L,64L,65L,66L,67L,68L,69L,70L,71L };
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
public class A123719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123719Inst : IEnumerable<long>
{
public static readonly long[] Value=A123719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123719.Bytes);
public long this[int i]=>Value[i];

public static A123719Inst Instance=new A123719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123720
{
public static readonly long[] Value={ 2L,4L,9L,20L,43L,90L,185L,376L,759L,1526L,3061L,6132L,12275L,24562L,49137L,98288L,196591L,393198L,786413L,1572844L,3145707L,6291434L,12582889L,25165800L,50331623L,100663270L,201326565L,402653156L,805306339L,1610612706L,3221225441L };
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
public class A123720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123720Inst : IEnumerable<long>
{
public static readonly long[] Value=A123720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123720.Bytes);
public long this[int i]=>Value[i];

public static A123720Inst Instance=new A123720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123721
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,0L,0L,2L,1L,0L,0L,2L,1L,0L,1L,0L,0L,0L,3L,2L,1L,0L,1L,0L,0L,0L,3L,2L,1L,0L,0L,2L,1L,0L,1L,0L,1L,0L,0L,0L,0L,4L,3L,2L,1L,0L,0L,2L,1L,0L,1L,0L,1L,0L,0L,0L,0L,4L,3L,2L,1L,0L,1L,0L,0L,0L,3L,2L,1L,0L,0L,2L,1L,0L,0L,2L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,5L,4L,3L,2L,1L,0L,1L,0L,0L,0L,3L,2L,1L,0L,0L,2L };
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
public class A123721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123721Inst : IEnumerable<long>
{
public static readonly long[] Value=A123721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123721.Bytes);
public long this[int i]=>Value[i];

public static A123721Inst Instance=new A123721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123722
{
public static readonly long[] Value={ 1L,3L,4L,8L,9L,15L,21L,33L,35L,39L,51L,57L,69L,70L,87L,93L,111L,123L,129L,141L,159L,177L,183L,201L,213L,219L,237L,249L,267L,291L,303L,309L,321L,327L,339L,381L,393L,411L,417L,447L,453L,471L,489L,501L,519L,537L,543L,573L,579L,591L,597L,633L,669L,681L,687L,699L,717L };
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
public class A123722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123722Inst : IEnumerable<long>
{
public static readonly long[] Value=A123722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123722.Bytes);
public long this[int i]=>Value[i];

public static A123722Inst Instance=new A123722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123723
{
public static readonly long[] Value={ 1L,4L,8L,12L,20L,28L,44L,45L,52L,63L,68L,76L,92L,116L,124L,126L,148L,164L,172L,175L,188L,212L,236L,244L,268L,284L,292L,316L,332L,350L,356L,388L,404L,412L,428L,436L,452L,508L,524L,548L,556L,596L,604L,628L,652L,668L,692L,716L,724L,764L,772L,788L,796L,844L,892L };
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
public class A123723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123723Inst : IEnumerable<long>
{
public static readonly long[] Value=A123723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123723.Bytes);
public long this[int i]=>Value[i];

public static A123723Inst Instance=new A123723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123724
{
public static readonly long[] Value={ -1L,0L,-1L,-2L,-1L,-2L,-1L,0L,-1L,0L,-1L,-2L,-1L,-2L,-1L,0L,-1L,0L,-1L,-2L,-1L,-2L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,2L,1L,2L,1L,0L,1L,0L,1L,2L,1L,2L,1L,0L,1L,0L,1L,2L,1L,2L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L };
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
public class A123724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123724Inst : IEnumerable<long>
{
public static readonly long[] Value=A123724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123724.Bytes);
public long this[int i]=>Value[i];

public static A123724Inst Instance=new A123724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123725
{
public static readonly long[] Value={ 1L,2L,-3L,-2L,-4L,2L,3L,-2L,-5L,2L,-3L,-2L,4L,2L,3L,-2L,-6L,2L,-3L,-2L,-4L,2L,3L,-2L,5L,2L,-3L,-2L,4L,2L,3L,-2L,-7L,2L,-3L,-2L,-4L,2L,3L,-2L,-5L,2L,-3L,-2L,4L,2L,3L,-2L,6L,2L,-3L,-2L,-4L,2L,3L,-2L,5L,2L,-3L,-2L,4L,2L,3L,-2L,-8L,2L,-3L,-2L,-4L,2L,3L,-2L,-5L,2L,-3L,-2L,4L,2L,3L,-2L,-6L,2L,-3L,-2L,-4L,2L,3L,-2L,5L,2L,-3L,-2L,4L,2L,3L,-2L,7L,2L,-3L,-2L,-4L,2L };
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
public class A123725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123725Inst : IEnumerable<long>
{
public static readonly long[] Value=A123725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123725.Bytes);
public long this[int i]=>Value[i];

public static A123725Inst Instance=new A123725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123726
{
public static readonly long[] Value={ 1L,1L,4L,1L,9L,1L,4L,1L,16L,1L,4L,1L,9L,1L,4L,1L,25L,1L,4L,1L,9L,1L,4L,1L,16L,1L,4L,1L,9L,1L,4L,1L,36L,1L,4L,1L,9L,1L,4L,1L,16L,1L,4L,1L,9L,1L,4L,1L,25L,1L,4L,1L,9L,1L,4L,1L,16L,1L,4L,1L,9L,1L,4L,1L,49L,1L,4L,1L,9L,1L,4L,1L,16L,1L,4L,1L,9L,1L,4L,1L,25L,1L,4L,1L,9L,1L,4L,1L,16L,1L,4L,1L,9L,1L,4L,1L,36L,1L,4L };
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
public class A123726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123726Inst : IEnumerable<long>
{
public static readonly long[] Value=A123726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123726.Bytes);
public long this[int i]=>Value[i];

public static A123726Inst Instance=new A123726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123727
{
public static readonly long[] Value={ 1L,111L,1L,111L,11211L,111L,1L,111L,11211L,1123211L,11211L,111L,1L,111L,11211L,1123211L,112343211L,1123211L,11211L,111L,1L };
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
public class A123727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123727Inst : IEnumerable<long>
{
public static readonly long[] Value=A123727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123727.Bytes);
public long this[int i]=>Value[i];

public static A123727Inst Instance=new A123727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123728
{
public static readonly long[] Value={ 6L,140L,1316L,1560L,14384L,18018L,23562L,40992L,94188L,141128L,168730L,187652L };
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
public class A123728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123728Inst : IEnumerable<long>
{
public static readonly long[] Value=A123728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123728.Bytes);
public long this[int i]=>Value[i];

public static A123728Inst Instance=new A123728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123729
{
public static readonly long[] Value={ 6L,140L,924L,1560L,14383L,18018L,22770L,40992L,93972L,139672L,142310L,92628L };
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
public class A123729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123729Inst : IEnumerable<long>
{
public static readonly long[] Value=A123729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123729.Bytes);
public long this[int i]=>Value[i];

public static A123729Inst Instance=new A123729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123730
{
public static readonly long[] Value={ 1L,0L,-1L,-1L,0L,-1L,1L,1L,0L,-1L,3L,-1L,4L,0L,-1L,-7L,-1L,-4L,8L,0L,-1L,-11L,2L,-21L,-8L,13L,0L,-1L,57L,-10L,46L,-69L,-13L,19L,0L,-1L,35L,37L,113L,150L,-160L,-19L,26L,0L,-1L,-533L,129L,-478L,609L,345L,-312L,-26L,34L,0L,-1L,141L,-946L,-520L,-2380L,1945L,668L,-546L,-34L,43L,0L,-1L };
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
public class A123730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123730Inst : IEnumerable<long>
{
public static readonly long[] Value=A123730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123730.Bytes);
public long this[int i]=>Value[i];

public static A123730Inst Instance=new A123730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123731
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,5L,6L,7L,8L,9L,9L,10L,11L,12L,12L,13L,14L,14L,15L,15L,15L,16L,17L,18L,19L,19L,20L,21L,22L,22L,23L,24L,24L,25L,25L,25L,26L,27L,28L,28L,29L,30L,30L,31L,31L,31L,32L,33L,33L,34L,34L,34L,35L,35L,35L,35L,36L,37L,38L,39L,39L,40L,41L,42L,42L,43L,44L,44L,45L,45L,45L,46L };
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
public class A123731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123731Inst : IEnumerable<long>
{
public static readonly long[] Value=A123731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123731.Bytes);
public long this[int i]=>Value[i];

public static A123731Inst Instance=new A123731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123732
{
public static readonly long[] Value={ 1L,4L,6L,4L,0L,0L,3L,5L,4L,3L,6L,0L,3L,1L,8L,2L,0L,2L,5L,9L,3L,8L,4L,2L,4L,8L,9L,4L,3L,4L,5L,4L,2L,7L,0L,8L,9L,8L,3L,9L,6L,1L,9L,9L,5L,7L };
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
public class A123732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123732Inst : IEnumerable<long>
{
public static readonly long[] Value=A123732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123732.Bytes);
public long this[int i]=>Value[i];

public static A123732Inst Instance=new A123732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123733
{
public static readonly long[] Value={ 1L,1L,2L,6L,3L,4L,2L,8L,6L,4L,3L,1L,4L,5L,5L,0L,7L,0L,5L,7L,2L,4L,9L,7L,8L,4L,8L,7L,2L,9L,9L,9L,2L,6L,8L,3L,2L,5L,8L,4L,6L,4L,2L,0L,6L,3L,5L,0L,2L,6L,2L,9L,7L,4L,9L,2L,5L,1L };
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
public class A123733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123733Inst : IEnumerable<long>
{
public static readonly long[] Value=A123733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123733.Bytes);
public long this[int i]=>Value[i];

public static A123733Inst Instance=new A123733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123734
{
public static readonly long[] Value={ 1L,0L,4L,7L,1L,2L,7L,6L,4L,6L,9L,6L,3L,2L,8L,0L,1L,1L,7L,1L,3L,1L,6L,1L,9L,9L,1L,5L,9L,7L,8L,7L,9L,8L,3L,8L,4L,2L,2L,1L,3L,4L,9L,5L,2L,6L,3L,4L,2L,4L,3L,1L,6L,9L,8L,3L,4L,0L,6L,8L,2L,5L,2L,8L,4L };
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
public class A123734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123734Inst : IEnumerable<long>
{
public static readonly long[] Value=A123734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123734.Bytes);
public long this[int i]=>Value[i];

public static A123734Inst Instance=new A123734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123735
{
public static readonly long[] Value={ 0L,0L,-1L,-1L,0L,1L,-2L,3L,0L,-1L,0L,4L,-5L,0L,1L,2L,-3L,-6L,7L,0L,-1L,3L,-12L,10L,8L,-9L,0L,1L,0L,-9L,30L,-21L,-10L,11L,0L,-1L,-3L,12L,11L,-56L,36L,12L,-13L,0L,1L,-4L,30L,-60L,-1L,90L,-55L,-14L,15L,0L,-1L,0L,16L,-100L,168L,-29L,-132L,78L,16L,-17L,0L,1L };
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
public class A123735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123735Inst : IEnumerable<long>
{
public static readonly long[] Value=A123735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123735.Bytes);
public long this[int i]=>Value[i];

public static A123735Inst Instance=new A123735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123736
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,0L,1L,2L,2L,1L,1L,0L,1L,3L,4L,3L,2L,1L,1L,0L,1L,4L,7L,7L,5L,3L,2L,1L,1L,0L,1L,5L,11L,14L,12L,8L,5L,3L,2L,1L,1L,0L,1L,6L,16L,25L,26L,20L,13L,8L,5L,3L,2L,1L,1L,0L,1L,7L,22L,41L,51L,46L,33L,21L,13L,8L,5L,3L,2L,1L,1L,0L,1L,8L,29L,63L,92L,97L,79L,54L,34L,21L,13L,8L,5L,3L,2L,1L,1L,0L,1L };
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
public class A123736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123736Inst : IEnumerable<long>
{
public static readonly long[] Value=A123736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123736.Bytes);
public long this[int i]=>Value[i];

public static A123736Inst Instance=new A123736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123737
{
public static readonly long[] Value={ -1L,0L,1L,0L,-1L,0L,-1L,-2L,-1L,0L,-1L,0L,1L,0L,-1L,0L,1L,0L,1L,2L,1L,0L,1L,0L,-1L,0L,1L,0L,-1L,0L,-1L,-2L,-1L,0L,-1L,0L,1L,0L,-1L,0L,-1L,-2L,-1L,0L,-1L,-2L,-1L,-2L,-3L,-2L,-1L,-2L,-1L,0L,-1L,-2L,-1L,0L,-1L,0L,1L,0L,-1L,0L,-1L,-2L,-1L,0L,-1L,0L,1L,0L,-1L,0L,1L,0L,1L,2L,1L,0L,1L,0L,-1L,0L,1L,0L,-1L,0L,-1L,-2L,-1L,0L,-1L,0L,1L,0L,-1L,0L,1L,0L };
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
public class A123737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123737Inst : IEnumerable<long>
{
public static readonly long[] Value=A123737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123737.Bytes);
public long this[int i]=>Value[i];

public static A123737Inst Instance=new A123737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123738
{
public static readonly long[] Value={ -1L,0L,-1L,0L,-1L,0L,-1L,-2L,-1L,-2L,-1L,-2L,-1L,-2L,-3L,-2L,-3L,-2L,-3L,-2L,-3L,-4L,-3L,-4L,-3L,-4L,-3L,-4L,-5L,-4L,-5L,-4L,-5L,-4L,-5L,-6L,-5L,-6L,-5L,-6L,-5L,-6L,-7L,-6L,-7L,-6L,-7L,-6L,-7L,-8L,-7L,-8L,-7L,-8L,-7L,-8L,-9L,-8L,-9L,-8L,-9L,-8L,-9L,-10L,-9L,-10L,-9L,-10L,-9L,-10L,-11L,-10L,-11L,-10L,-11L,-10L,-11L,-12L,-11L,-12L };
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
public class A123738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123738Inst : IEnumerable<long>
{
public static readonly long[] Value=A123738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123738.Bytes);
public long this[int i]=>Value[i];

public static A123738Inst Instance=new A123738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123739
{
public static readonly long[] Value={ 1L,0L,1L,2L,1L,2L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,2L,1L,2L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,2L,1L,2L,1L,0L,1L,0L,1L,2L,1L,2L,3L,2L,3L,2L,1L,2L,1L,0L,1L,0L,1L,2L,1L,2L,3L,2L,3L,2L,1L,2L,1L,0L,1L,0L,1L,2L,1L,2L,3L,2L,3L,2L,1L,2L,1L,2L,3L,2L,3L,4L,3L,4L,3L,2L,3L,2L,1L,2L,1L,2L,3L,2L,3L,4L,3L,4L,3L,2L,3L,2L,1L,2L,1L,2L,3L,2L,3L,2L,1L,2L,1L,0L,1L,0L,1L,2L,1L,2L,3L,2L,3L,2L,1L,2L,1L };
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
public class A123739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123739Inst : IEnumerable<long>
{
public static readonly long[] Value=A123739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123739.Bytes);
public long this[int i]=>Value[i];

public static A123739Inst Instance=new A123739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123740
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L };
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
public class A123740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123740Inst : IEnumerable<long>
{
public static readonly long[] Value=A123740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123740.Bytes);
public long this[int i]=>Value[i];

public static A123740Inst Instance=new A123740Inst();

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