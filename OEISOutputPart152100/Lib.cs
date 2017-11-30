using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A195205
{
public static readonly long[] Value={ 3L,6L,9L,30L,54L,27L,222L,468L,324L,81L,2190L,5130L,4320L,1620L,243L,27006L,68400L,65610L,30780L,7290L,729L,399630L,1076166L,1135890L,618030L,187110L,30618L,2187L,6899262L,19532268L,22212792L,13471920L,4796820L,1020600L,122472L,6561L };
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
public class A195205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195205Inst : IEnumerable<long>
{
public static readonly long[] Value=A195205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195205.Bytes);
public long this[int i]=>Value[i];

public static A195205Inst Instance=new A195205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195206
{
public static readonly long[] Value={ 1L,5L,49L,502L,4996L,49972L,499986L,5000046L,50000675L,500001223L,4999997671L,50000001587L,500000050701L,5000000008159L,50000000316237L,500000000977421L,4999999994637728L,49999999977479348L,499999999944465105L,4999999999725703450L };
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
public class A195206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195206Inst : IEnumerable<long>
{
public static readonly long[] Value=A195206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195206.Bytes);
public long this[int i]=>Value[i];

public static A195206Inst Instance=new A195206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195207
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,4L,0L,6L,0L,24L,0L,4L,0L,24L,0L,4L,0L,16L,0L,24L,0L,32L,0L,96L,0L,144L,0L,16L,0L,64L,0L,144L,0L,40L,0L,128L,0L,160L,0L,16L,0L,96L,0L,96L,0L,32L,0L,128L,0L,96L,0L,48L,0L,128L,0L,96L,0L,96L,0L,32L,0L };
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
public class A195207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195207Inst : IEnumerable<long>
{
public static readonly long[] Value=A195207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195207.Bytes);
public long this[int i]=>Value[i];

public static A195207Inst Instance=new A195207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195208
{
public static readonly long[] Value={ 1L,0L,1L,1L,3L,2L,4L,6L,8L,8L,10L,4L,6L,12L,8L,4L,24L,4L,8L,24L,32L,16L,24L,96L,32L,48L,24L,16L,384L,32L,64L,144L,16L,8L,36L,128L,16L,80L,24L,16L,96L,32L,16L,96L,4L,16L,448L,128L,64L,24L,192L,48L,192L,64L,16L,96L,768L,32L,96L,32L,64L };
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
public class A195208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195208Inst : IEnumerable<long>
{
public static readonly long[] Value=A195208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195208.Bytes);
public long this[int i]=>Value[i];

public static A195208Inst Instance=new A195208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195209
{
public static readonly BigInteger[] Value={ 0L,0L,0L,2L,0L,72L,0L,2704L,0L,268128L,0L,17621496L,0L,4974281208L,0L,549790303712L,0L,245357774621280L,0L,67684833350266496L,0L,BigInteger.Parse("36434223374991414336"),0L,BigInteger.Parse("10781900341537812480000"),0L,BigInteger.Parse("14585451990785851336761600") };
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
public class A195209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195209Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195209.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195209.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195209Inst Instance=new A195209Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195210
{
public static readonly long[] Value={ 1L,0L,1L,1L,13L,12L,324L,1352L,18368L,19152L,1994322L,8810748L,193690826L,829046868L,34563283272L,274895151856L,14554448767872L,8178592487376L,2493850026398472L,33842416675133248L,1037660717168380800L,6072370562498569056L };
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
public class A195210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195210Inst : IEnumerable<long>
{
public static readonly long[] Value=A195210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195210.Bytes);
public long this[int i]=>Value[i];

public static A195210Inst Instance=new A195210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195211
{
public static readonly long[] Value={ 1L,5L,51L,502L,4995L,49999L,499980L,4999995L,50000202L,499999731L,5000005565L,50000013114L,499999997503L,4999999971938L,49999999974390L,499999999976909L,4999999999414101L,50000000022964476L,500000000029433861L,4999999999986496894L };
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
public class A195211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195211Inst : IEnumerable<long>
{
public static readonly long[] Value=A195211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195211.Bytes);
public long this[int i]=>Value[i];

public static A195211Inst Instance=new A195211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195212
{
public static readonly long[] Value={ 4L,9L,16L,18L,25L,36L,49L,50L,64L,72L,75L,81L,98L,100L,121L,144L,147L,150L,162L,169L,196L,200L,225L,242L,245L,256L,288L,289L,294L,300L,324L,338L,361L,363L,392L,400L,441L,450L,484L,490L,507L,529L,576L,578L,588L,600L,605L,625L,648L,675L,676L,722L,726L,729L,735L };
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
public class A195212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195212Inst : IEnumerable<long>
{
public static readonly long[] Value=A195212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195212.Bytes);
public long this[int i]=>Value[i];

public static A195212Inst Instance=new A195212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195213
{
public static readonly BigInteger[] Value={ 1L,7L,91L,2277L,111031L,10654607L,2021888119L,761408842173L,570411420721871L,851650667866314005L,BigInteger.Parse("2537743716708476573853"),BigInteger.Parse("15108768742290768272235707"),BigInteger.Parse("179885152873727967922701202921"),BigInteger.Parse("4286156683596201247493358770260469") };
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
public class A195213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195213Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195213.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195213.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195213Inst Instance=new A195213Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195214
{
public static readonly BigInteger[] Value={ 1L,19L,1047L,176471L,92031109L,149824887097L,764465228592699L,12257873230432791803UL,BigInteger.Parse("618761146282316127586145"),BigInteger.Parse("98449515559059678433241253935"),BigInteger.Parse("49416410864494101822050533251357921") };
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
public class A195214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195214Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195214.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195214.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195214Inst Instance=new A195214Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195215
{
public static readonly BigInteger[] Value={ 1L,37L,5453L,3395245L,9032683465L,103565705397639L,5137554141710397313L,BigInteger.Parse("1105495964728300359472149"),BigInteger.Parse("1033611648181176182212080096433"),BigInteger.Parse("4204060119607140359160709072654583501") };
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
public class A195215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195215Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195215.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195215.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195215Inst Instance=new A195215Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195216
{
public static readonly BigInteger[] Value={ 1L,61L,18903L,31640829L,289301569283L,14572563308953245L,BigInteger.Parse("4059527861103273129317"),BigInteger.Parse("6270118871204192400242141667"),BigInteger.Parse("53785756580019628016324622812810239") };
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
public class A195216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195216Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195216.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195216.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195216Inst Instance=new A195216Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195217
{
public static readonly BigInteger[] Value={ 1L,91L,51205L,189677411L,4677360495205L,774355028021195459L,BigInteger.Parse("863969905606597340602967"),BigInteger.Parse("6512935591253221256126051469607") };
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
public class A195217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195217Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195217.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195217.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195217Inst Instance=new A195217Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195218
{
public static readonly BigInteger[] Value={ 1L,127L,117585L,845613769L,47764170577925L,BigInteger.Parse("21369796486647028143"),BigInteger.Parse("76019997788404353762724447"),BigInteger.Parse("2155668406192527252815282495516543") };
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
public class A195218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195218Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195218.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195218.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195218Inst Instance=new A195218Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195219
{
public static readonly BigInteger[] Value={ 1L,169L,239891L,3048698613L,350767341744137L,BigInteger.Parse("368448539594713382337"),BigInteger.Parse("3546881146489163009435488735") };
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
public class A195219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195219Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195219.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195219.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195219Inst Instance=new A195219Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195220
{
public static readonly long[] Value={ 1L,1L,7L,1L,19L,91L,1L,37L,1047L,2277L,1L,61L,5453L,176471L,111031L,1L,91L,18903L,3395245L,92031109L,10654607L,1L,127L,51205L,31640829L,9032683465L,149824887097L,2021888119L,1L,169L,117585L,189677411L,289301569283L,103565705397639L };
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
public class A195220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195220Inst : IEnumerable<long>
{
public static readonly long[] Value=A195220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195220.Bytes);
public long this[int i]=>Value[i];

public static A195220Inst Instance=new A195220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195221
{
public static readonly long[] Value={ 91L,1047L,5453L,18903L,51205L,117585L,239891L,447797L,780007L,1285459L,2024529L,3070235L,4509441L,6444061L,8992263L,12289673L,16490579L,21769135L,28320565L,36362367L,46135517L,57905673L,71964379L,88630269L,108250271L,131200811L };
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
public class A195221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195221Inst : IEnumerable<long>
{
public static readonly long[] Value=A195221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195221.Bytes);
public long this[int i]=>Value[i];

public static A195221Inst Instance=new A195221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195222
{
public static readonly long[] Value={ 2277L,176471L,3395245L,31640829L,189677411L,845613769L,3048698613L,9369900047L,25430520379L,62478288201L,141479051231L,299315365855L,597820942629L,1136532061199L,2070203713171L,3632319367413L,6166018879097L,10164079181491L };
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
public class A195222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195222Inst : IEnumerable<long>
{
public static readonly long[] Value=A195222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195222.Bytes);
public long this[int i]=>Value[i];

public static A195222Inst Instance=new A195222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195223
{
public static readonly long[] Value={ 111031L,92031109L,9032683465L,289301569283L,4677360495205L,47764170577925L,350767341744137L,2010235691940497L,9496465116615081L,38429133040711965L,136997589911672127L,439401533118090493L,1288688520518224397L };
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
public class A195223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195223Inst : IEnumerable<long>
{
public static readonly long[] Value=A195223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195223.Bytes);
public long this[int i]=>Value[i];

public static A195223Inst Instance=new A195223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195224
{
public static readonly BigInteger[] Value={ 10654607L,149824887097L,103565705397639L,14572563308953245L,774355028021195459L,BigInteger.Parse("21369796486647028143"),BigInteger.Parse("368448539594713382337"),BigInteger.Parse("4459232627488479738855"),BigInteger.Parse("40959753617162679435381"),BigInteger.Parse("301639473232633417395629") };
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
public class A195224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195224Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195224.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195224.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195224Inst Instance=new A195224Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195225
{
public static readonly BigInteger[] Value={ 2021888119L,764465228592699L,5137554141710397313L,BigInteger.Parse("4059527861103273129317"),BigInteger.Parse("863969905606597340602967"),BigInteger.Parse("76019997788404353762724447"),BigInteger.Parse("3546881146489163009435488735"),BigInteger.Parse("102667264655001518661047239817") };
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
public class A195225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195225Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195225.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195225.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195225Inst Instance=new A195225Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195226
{
public static readonly BigInteger[] Value={ 3L,15L,155L,3151L,127785L,10322065L,1663418313L,535153390177L,343932423395227L,441776066934784687L,BigInteger.Parse("1134608168927438377475"),BigInteger.Parse("5828490619001307113164495"),BigInteger.Parse("59904949456032239303490933489"),BigInteger.Parse("1232191818850202836476827846621041") };
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
public class A195226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195226Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195226.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195226.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195226Inst Instance=new A195226Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195227
{
public static readonly BigInteger[] Value={ 4L,22L,246L,5428L,237818L,20729610L,3601738548L,1249159521262L,865793424024974L,1200356073563114252L,BigInteger.Parse("3331551471246807302142"),BigInteger.Parse("18523112376180844925948966"),BigInteger.Parse("206425939461681776649215679048"),BigInteger.Parse("4613382950875473008207859661034814") };
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
public class A195227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195227Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195227.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195227.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195227Inst Instance=new A195227Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195228
{
public static readonly BigInteger[] Value={ 5L,29L,337L,7705L,348849L,31374671L,5618308863L,2006626824777L,1431393426377379L,2041526404394580503L,BigInteger.Parse("5826929219460553056125"),BigInteger.Parse("33306813274969071019847237"),BigInteger.Parse("381509343842237775318179191165"),BigInteger.Parse("8761682347863104757428803661222769") };
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
public class A195228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195228Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195228.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195228.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195228Inst Instance=new A195228Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195229
{
public static readonly BigInteger[] Value={ 6L,36L,428L,9982L,459880L,42029278L,7640055854L,2767861764930L,2001526172413328L,2892451174381411040L,BigInteger.Parse("8361331814456905846790"),BigInteger.Parse("48387254396810574882721328"),BigInteger.Parse("560941284568012233398098984786"),BigInteger.Parse("13033945031291662448750033149621602") };
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
public class A195229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195229Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195229.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195229.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195229Inst Instance=new A195229Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195230
{
public static readonly BigInteger[] Value={ 7L,43L,519L,12259L,570911L,52683885L,9661943973L,3529267255201L,2571928557261907L,3744070741500225585L,BigInteger.Parse("10898903552323266521821"),BigInteger.Parse("63494356952926436300329797"),BigInteger.Parse("740796894931520786982829942993") };
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
public class A195230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195230Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195230.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195230.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195230Inst Instance=new A195230Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195231
{
public static readonly BigInteger[] Value={ 8L,50L,610L,14536L,681942L,63338492L,11683832092L,4290676097374L,3142339851746238L,4595720660886942892L,BigInteger.Parse("13436641716584454488144"),BigInteger.Parse("78603060373509486868646762"),BigInteger.Parse("920680713893261032002755485080") };
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
public class A195231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195231Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195231.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195231.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195231Inst Instance=new A195231Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195232
{
public static readonly long[] Value={ 2L,3L,8L,4L,15L,64L,5L,22L,155L,1024L,6L,29L,246L,3151L,32768L,7L,36L,337L,5428L,127785L,2097152L,8L,43L,428L,7705L,237818L,10322065L,268435456L,9L,50L,519L,9982L,348849L,20729610L,1663418313L,68719476736L,10L,57L,610L,12259L,459880L,31374671L };
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
public class A195232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195232Inst : IEnumerable<long>
{
public static readonly long[] Value=A195232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195232.Bytes);
public long this[int i]=>Value[i];

public static A195232Inst Instance=new A195232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195233
{
public static readonly long[] Value={ 64L,155L,246L,337L,428L,519L,610L,701L,792L,883L,974L,1065L,1156L,1247L,1338L,1429L,1520L,1611L,1702L,1793L,1884L,1975L,2066L,2157L,2248L,2339L,2430L,2521L,2612L,2703L,2794L,2885L,2976L,3067L,3158L,3249L,3340L,3431L,3522L,3613L,3704L,3795L,3886L,3977L };
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
public class A195233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195233Inst : IEnumerable<long>
{
public static readonly long[] Value=A195233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195233.Bytes);
public long this[int i]=>Value[i];

public static A195233Inst Instance=new A195233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195234
{
public static readonly long[] Value={ 1024L,3151L,5428L,7705L,9982L,12259L,14536L,16813L,19090L,21367L,23644L,25921L,28198L,30475L,32752L,35029L,37306L,39583L,41860L,44137L,46414L,48691L,50968L,53245L,55522L,57799L,60076L,62353L,64630L,66907L,69184L,71461L,73738L,76015L,78292L,80569L };
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
public class A195234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195234Inst : IEnumerable<long>
{
public static readonly long[] Value=A195234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195234.Bytes);
public long this[int i]=>Value[i];

public static A195234Inst Instance=new A195234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195235
{
public static readonly long[] Value={ 32768L,127785L,237818L,348849L,459880L,570911L,681942L,792973L,904004L,1015035L,1126066L,1237097L,1348128L,1459159L,1570190L,1681221L,1792252L,1903283L,2014314L,2125345L,2236376L,2347407L,2458438L,2569469L,2680500L,2791531L,2902562L,3013593L };
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
public class A195235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195235Inst : IEnumerable<long>
{
public static readonly long[] Value=A195235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195235.Bytes);
public long this[int i]=>Value[i];

public static A195235Inst Instance=new A195235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195236
{
public static readonly long[] Value={ 2097152L,10322065L,20729610L,31374671L,42029278L,52683885L,63338492L,73993099L,84647706L,95302313L,105956920L,116611527L,127266134L,137920741L,148575348L,159229955L,169884562L,180539169L,191193776L,201848383L,212502990L,223157597L };
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
public class A195236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195236Inst : IEnumerable<long>
{
public static readonly long[] Value=A195236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195236.Bytes);
public long this[int i]=>Value[i];

public static A195236Inst Instance=new A195236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195237
{
public static readonly long[] Value={ 268435456L,1663418313L,3601738548L,5618308863L,7640055854L,9661943973L,11683832092L,13705720211L,15727608330L,17749496449L,19771384568L,21793272687L,23815160806L,25837048925L,27858937044L,29880825163L,31902713282L,33924601401L };
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
public class A195237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195237Inst : IEnumerable<long>
{
public static readonly long[] Value=A195237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195237.Bytes);
public long this[int i]=>Value[i];

public static A195237Inst Instance=new A195237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195238
{
public static readonly long[] Value={ 14L,15L,21L,28L,30L,35L,42L,45L,56L,60L,63L,70L,75L,84L,90L,98L,105L,112L,120L,126L,135L,140L,147L,150L,168L,175L,180L,189L,196L,224L,225L,240L,245L,252L,270L,280L,294L,300L,315L,336L,350L,360L,375L,378L,392L,405L,441L,448L,450L,480L,490L,504L,525L,540L,560L };
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
public class A195238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195238Inst : IEnumerable<long>
{
public static readonly long[] Value=A195238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195238.Bytes);
public long this[int i]=>Value[i];

public static A195238Inst Instance=new A195238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195239
{
public static readonly long[] Value={ 147L,55L,47L,47L,39L,23L,89L,47L,45L,43L,39L,77L,0L,31L,23L,53L,179L,43L,71L,103L,75L,29L,117L,197L,59L,23L,89L,77L,39L,31L,89L,55L,147L,71L,143L,169L,59L,109L,47L,103L,51L,205L,209L,139L,89L,29L,47L,29L,167L,205L,107L,47L,0L,61L,53L,103L,87L,53L,83L,85L,71L,143L,51L,43L };
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
public class A195239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195239Inst : IEnumerable<long>
{
public static readonly long[] Value=A195239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195239.Bytes);
public long this[int i]=>Value[i];

public static A195239Inst Instance=new A195239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195240
{
public static readonly long[] Value={ 0L,1L,1L,7L,8L,11L,10L,7L,8L,19L,14L,337L,1028L,5L,-2L,-1681L,1936L,22133L,-21734L,-87223L,87388L,427291L,-427222L,-118181363L,118182728L,4276553L,-4276550L,-11874730297L,11874730732L,4307920641583L };
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
public class A195240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195240Inst : IEnumerable<long>
{
public static readonly long[] Value=A195240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195240.Bytes);
public long this[int i]=>Value[i];

public static A195240Inst Instance=new A195240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195241
{
public static readonly long[] Value={ 1L,2L,3L,23L,59L,111L,179L,263L,363L,479L,611L,759L,923L,1103L,1299L,1511L,1739L,1983L,2243L,2519L,2811L,3119L,3443L,3783L,4139L,4511L,4899L,5303L,5723L,6159L,6611L,7079L,7563L,8063L,8579L,9111L,9659L,10223L,10803L,11399L,12011L,12639L,13283L,13943L };
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
public class A195241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195241Inst : IEnumerable<long>
{
public static readonly long[] Value=A195241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195241.Bytes);
public long this[int i]=>Value[i];

public static A195241Inst Instance=new A195241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195242
{
public static readonly BigInteger[] Value={ 1L,1L,5L,44L,548L,8808L,173352L,4036288L,108507968L,3307368320L,112703108480L,4245680193024L,175200825481728L,7859411394860032L,380810598813553664L,BigInteger.Parse("19819617775693512704"),BigInteger.Parse("1102737068471914938368"),BigInteger.Parse("65316500202537025634304"),BigInteger.Parse("4103422475123595857854464") };
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
public class A195242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195242Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195242.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195242.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195242Inst Instance=new A195242Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195243
{
public static readonly BigInteger[] Value={ 4L,46L,1682L,190514L,67379894L,74236765958L,254948725307650L,2728873272983950594L,BigInteger.Parse("91038149737139587502854"),BigInteger.Parse("9466106148769015848820814134"),BigInteger.Parse("3067809430979519600024270636572850") };
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
public class A195243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195243Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195243.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195243.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195243Inst Instance=new A195243Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195244
{
public static readonly BigInteger[] Value={ 5L,65L,2729L,357847L,147824001L,192172956591L,786909681200387L,10151817642632605643UL,BigInteger.Parse("412697709382902984293947"),BigInteger.Parse("52873327059079066189496492173"),BigInteger.Parse("21349480944940442832764307444766199") };
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
public class A195244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195244Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195244.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195244.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195244Inst Instance=new A195244Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195245
{
public static readonly BigInteger[] Value={ 6L,84L,3776L,533142L,237368212L,333437946202L,1479091549959182L,BigInteger.Parse("20728220266936919766"),BigInteger.Parse("918037571811526229736636"),BigInteger.Parse("128523191925989407344147529338"),BigInteger.Parse("56883358880979630186940014533369490") };
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
public class A195245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195245Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195245.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195245.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195245Inst Instance=new A195245Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195246
{
public static readonly BigInteger[] Value={ 7L,103L,4823L,709613L,329060365L,481573562101L,2226347741716207L,BigInteger.Parse("32533092875899015419"),BigInteger.Parse("1503300467938958707014579"),BigInteger.Parse("219724247440207348239797551059"),BigInteger.Parse("101603289677502667519178169906161081") };
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
public class A195246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195246Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195246.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195246.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195246Inst Instance=new A195246Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195247
{
public static readonly BigInteger[] Value={ 8L,122L,5870L,886084L,421064386L,631149414120L,2987571816007840L,BigInteger.Parse("44691981426014450274"),BigInteger.Parse("2113939963847059814381026"),BigInteger.Parse("316271939439306387096992492956"),BigInteger.Parse("149706956331711946010383809151524932") };
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
public class A195247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195247Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195247.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195247.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195247Inst Instance=new A195247Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195248
{
public static readonly long[] Value={ 2L,3L,8L,4L,27L,64L,5L,46L,729L,1024L,6L,65L,1682L,59049L,32768L,7L,84L,2729L,190514L,14348907L,2097152L,8L,103L,3776L,357847L,67379894L,10460353203L,268435456L,9L,122L,4823L,533142L,147824001L,74236765958L,22876792454961L,68719476736L,10L,141L };
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
public class A195248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195248Inst : IEnumerable<long>
{
public static readonly long[] Value=A195248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195248.Bytes);
public long this[int i]=>Value[i];

public static A195248Inst Instance=new A195248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195249
{
public static readonly long[] Value={ 64L,729L,1682L,2729L,3776L,4823L,5870L,6917L,7964L,9011L,10058L,11105L,12152L,13199L,14246L,15293L,16340L,17387L,18434L,19481L,20528L,21575L,22622L,23669L,24716L,25763L,26810L,27857L,28904L,29951L,30998L,32045L,33092L,34139L,35186L,36233L,37280L,38327L };
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
public class A195249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195249Inst : IEnumerable<long>
{
public static readonly long[] Value=A195249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195249.Bytes);
public long this[int i]=>Value[i];

public static A195249Inst Instance=new A195249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195250
{
public static readonly long[] Value={ 1024L,59049L,190514L,357847L,533142L,709613L,886084L,1062555L,1239026L,1415497L,1591968L,1768439L,1944910L,2121381L,2297852L,2474323L,2650794L,2827265L,3003736L,3180207L,3356678L,3533149L,3709620L,3886091L,4062562L,4239033L,4415504L,4591975L };
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
public class A195250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195250Inst : IEnumerable<long>
{
public static readonly long[] Value=A195250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195250.Bytes);
public long this[int i]=>Value[i];

public static A195250Inst Instance=new A195250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195251
{
public static readonly long[] Value={ 32768L,14348907L,67379894L,147824001L,237368212L,329060365L,421064386L,513095495L,605126604L,697157713L,789188822L,881219931L,973251040L,1065282149L,1157313258L,1249344367L,1341375476L,1433406585L,1525437694L,1617468803L };
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
public class A195251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195251Inst : IEnumerable<long>
{
public static readonly long[] Value=A195251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195251.Bytes);
public long this[int i]=>Value[i];

public static A195251Inst Instance=new A195251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195252
{
public static readonly long[] Value={ 2097152L,10460353203L,74236765958L,192172956591L,333437946202L,481573562101L,631149414120L,780949393809L,930772855532L,1080597742629L,1230422629726L,1380247516823L,1530072403920L,1679897291017L,1829722178114L,1979547065211L };
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
public class A195252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195252Inst : IEnumerable<long>
{
public static readonly long[] Value=A195252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195252.Bytes);
public long this[int i]=>Value[i];

public static A195252Inst Instance=new A195252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195253
{
public static readonly long[] Value={ 268435456L,22876792454961L,254948725307650L,786909681200387L,1479091549959182L,2226347741716207L,2987571816007840L,3751562406061261L,4515974674903982L,5280435818615649L,6044900876514412L,6809366105107111L };
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
public class A195253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195253Inst : IEnumerable<long>
{
public static readonly long[] Value=A195253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195253.Bytes);
public long this[int i]=>Value[i];

public static A195253Inst Instance=new A195253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195254
{
public static readonly BigInteger[] Value={ 1L,2L,6L,20L,76L,336L,1744L,10592L,74400L,595712L,5362432L,53626368L,589894144L,7078737920L,92023609344L,1288330563584L,19324958519296L,309199336439808L,5256388719738880L,94614996955824128L,1797684942161707008L,BigInteger.Parse("35953698843236237312"),BigInteger.Parse("755027675707965177856") };
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
public class A195254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195254Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195254.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195254.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195254Inst Instance=new A195254Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195255
{
public static readonly BigInteger[] Value={ 1L,3L,12L,51L,234L,1179L,6624L,41931L,300078L,2420307L,21841812L,218595267L,2405079378L,28862546859L,375217892136L,5253064838811L,78796015628886L,1260736379202339L,21432518833860252L,385785340171746003L,7329921466749958458L,BigInteger.Parse("146598429345459522363") };
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
public class A195255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195255Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195255.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195255.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195255Inst Instance=new A195255Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195256
{
public static readonly BigInteger[] Value={ 1L,4L,20L,104L,568L,3296L,20576L,139840L,1044416L,8617472L,78605824L,790252544L,8709555200L,104581771264L,1359831461888L,19038714208256L,285585008091136L,4569377309327360L,77679482978041856L,1398230968482660352L,BigInteger.Parse("26566389500682174464") };
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
public class A195256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195256Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195256.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195256.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195256Inst Instance=new A195256Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195257
{
public static readonly BigInteger[] Value={ 1L,5L,30L,185L,1180L,7845L,54850L,407225L,3241200L,27882725L,260710150L,2655929625L,29459366500L,354733101125L,4617633830250L,64677391201625L,970313455915000L,15525778234093125L,263942044676848750L,4750975877669605625L,BigInteger.Parse("90268637043154147500") };
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
public class A195257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195257Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195257.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195257.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195257Inst Instance=new A195257Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195258
{
public static readonly long[] Value={ 3L,2L,3L,293L,307L,317L,1373L,1451L,1481L,1487L,6947L,7109L,7331L,7349L,7411L,7173L,8423L,8467L,8681L,8693L,8713L,6221L,6269L,6311L,6379L,6521L,6529L,6551L,44221L,48497L,49307L,50111L,50177L,50497L,50527L,50543L,14813L,14891L,14957L,15053L,15161L,15187L,15227L };
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
public class A195258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195258Inst : IEnumerable<long>
{
public static readonly long[] Value=A195258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195258.Bytes);
public long this[int i]=>Value[i];

public static A195258Inst Instance=new A195258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195259
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,25L,138L,1036L,11270L,194105L,5600367L,275058868L,22805688464L,3173290832407L,739292604671606L,288039050041591288L,BigInteger.Parse("188101949731185856592"),BigInteger.Parse("205677982188934721693289"),BigInteger.Parse("377993929252274297946197815"),BigInteger.Parse("1165828413037318706712871579130") };
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
public class A195259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195259Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195259.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195259.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195259Inst Instance=new A195259Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195260
{
public static readonly BigInteger[] Value={ 1L,1L,4L,25L,200L,1948L,23293L,366698L,8669713L,354287410L,26296911212L,3452678049185L,778932197922145L,297680194679224221L,BigInteger.Parse("192063113715788790619"),BigInteger.Parse("208413189299565620902495"),BigInteger.Parse("381159431868835826320370849"),BigInteger.Parse("1171978295935406653806412222411") };
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
public class A195260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195260Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195260.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195260.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195260Inst Instance=new A195260Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195261
{
public static readonly long[] Value={ 1L,1L,3L,12L,56L,284L,1520L,8449L,48303L,282207L,1677489L,10112546L,61678702L,379919672L,2359991520L,14767164162L,92993252612L,588904075546L,3748029131834L,23960546501520L,153790930664222L,990690415079898L,6402865318618654L,41506375396111624L };
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
public class A195261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195261Inst : IEnumerable<long>
{
public static readonly long[] Value=A195261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195261.Bytes);
public long this[int i]=>Value[i];

public static A195261Inst Instance=new A195261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195262
{
public static readonly long[] Value={ 1L,1L,4L,21L,125L,805L,5459L,38403L,277667L,2050771L,15405655L,117344350L,904175038L,7035182178L,55197856415L,436221495843L,3469249248383L,27744896161177L,222987118478532L,1800106801933350L,14589674016207940L,118674224290447850L,968474133792224994L };
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
public class A195262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195262Inst : IEnumerable<long>
{
public static readonly long[] Value=A195262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195262.Bytes);
public long this[int i]=>Value[i];

public static A195262Inst Instance=new A195262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195263
{
public static readonly BigInteger[] Value={ 1L,3L,75L,4809L,578415L,112024353L,31851411375L,12493267169169L,6464106627329055L,4265281191267407073L,BigInteger.Parse("3495556570494504442575"),BigInteger.Parse("3483310917470882398369329"),BigInteger.Parse("4147647341931988462919773695"),BigInteger.Parse("5815857702618060221437908948993"),BigInteger.Parse("9485411994735540168549266106329775") };
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
public class A195263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195263Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195263.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195263.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195263Inst Instance=new A195263Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195264
{
public static readonly long[] Value={ 1L,2L,3L,211L,5L,23L,7L,23L,2213L,2213L,11L,223L,13L,311L,1129L,233L,17L,17137L,19L };
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
public class A195264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195264Inst : IEnumerable<long>
{
public static readonly long[] Value=A195264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195264.Bytes);
public long this[int i]=>Value[i];

public static A195264Inst Instance=new A195264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195265
{
public static readonly BigInteger[] Value={ 20L,225L,3252L,223271L,297699L,399233L,715623L,3263907L,32347303L,160720129L,1153139393L,72171972859L,736728093411L,3245576031137L,11295052366467L,310807934835791L,1789205424940407L,31745337977379983L,1122916740775279751L,7251536377635958081L,BigInteger.Parse("151243563319717018007") };
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
public class A195265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195265Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195265.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195265.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195265Inst Instance=new A195265Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195266
{
public static readonly BigInteger[] Value={ 105L,357L,3717L,32759L,174147L,358049L,379677L,3196661L,13245897L,373120347L,31961239449L,364811643843L,3474632755849L,7148938489519L,19530970872089L,731453184134581L,1069684240583849L,11451757737372871L,18163269379764491L,99042547183388553L,344278174560973471L,BigInteger.Parse("71388716692555572127"),BigInteger.Parse("148872380947952962303"),BigInteger.Parse("1453102458624189919451"),BigInteger.Parse("11245912921175349453489") };
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
public class A195266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195266Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195266.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195266.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195266Inst Instance=new A195266Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195267
{
public static readonly BigInteger[] Value={ 14L,89L,3104L,265832L,42711550L,11454711984L,4840928618302L,3108267243405312L,2924919606477510504L,BigInteger.Parse("3870562086323220000000"),BigInteger.Parse("6908112063470228210507358"),BigInteger.Parse("16038451894952529045493383168"),BigInteger.Parse("47076979725683125083464370176990"),BigInteger.Parse("170928617514191160703263296201650176") };
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
public class A195267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195267Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195267.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195267.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195267Inst Instance=new A195267Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195268
{
public static readonly long[] Value={ 9L,18L,25L,36L,50L,72L,100L,144L,200L,288L,289L,400L,576L,578L,729L,800L,1152L,1156L,1458L,1600L,1681L,2304L,2312L,2401L,2916L,3200L,3362L,3481L,4608L,4624L,4802L,5041L,5832L,6400L,6724L,6962L,7921L,9216L,9248L,9604L,10082L,10201L,11664L,12800L };
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
public class A195268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195268Inst : IEnumerable<long>
{
public static readonly long[] Value=A195268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195268.Bytes);
public long this[int i]=>Value[i];

public static A195268Inst Instance=new A195268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195269
{
public static readonly long[] Value={ 10L,35L,148L,332L,540L,540L,7722L,22793L,107189L,107189L,513335L,1847534L,5756981L,32023025L };
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
public class A195269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195269Inst : IEnumerable<long>
{
public static readonly long[] Value=A195269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195269.Bytes);
public long this[int i]=>Value[i];

public static A195269Inst Instance=new A195269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195270
{
public static readonly long[] Value={ 71L,107L,137L,281L,347L,379L,443L,461L,557L,617L,641L,727L,809L,827L,853L,857L,991L,1031L,1049L,1091L,1093L,1289L,1297L,1319L,1433L,1489L,1579L,1607L,1613L,1697L,1747L,1787L,1867L,1871L,1877L,1931L,1987L,1997L,2027L,2237L,2269L,2309L,2377L,2381L,2473L,2591L };
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
public class A195270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195270Inst : IEnumerable<long>
{
public static readonly long[] Value=A195270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195270.Bytes);
public long this[int i]=>Value[i];

public static A195270Inst Instance=new A195270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195271
{
public static readonly long[] Value={ 2L,5L,17L,29L,41L,79L,101L,137L,149L,163L,191L,197L,227L,269L,281L,313L,349L,353L,461L,463L,521L,541L,569L,593L,599L,613L,617L,641L,757L,769L,809L,821L,827L,857L,881L,887L,941L,1009L,1049L,1061L,1087L,1093L,1097L,1117L,1151L,1223L,1229L,1277L,1279L,1289L };
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
public class A195271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195271Inst : IEnumerable<long>
{
public static readonly long[] Value=A195271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195271.Bytes);
public long this[int i]=>Value[i];

public static A195271Inst Instance=new A195271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195272
{
public static readonly BigInteger[] Value={ 1L,25L,2125L,626525L,649112125L,2375645170875L,30812488814662125L,BigInteger.Parse("1419187229961716246975"),BigInteger.Parse("232443697109891957009442125"),BigInteger.Parse("135513533218801266004475511024825") };
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
public class A195272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195272Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195272.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195272.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195272Inst Instance=new A195272Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195273
{
public static readonly BigInteger[] Value={ 1L,49L,11319L,12608631L,68604760497L,1833160598134397L,BigInteger.Parse("241338657495589799523"),BigInteger.Parse("156865927758847103008175635"),BigInteger.Parse("504091149328239931994947830412175") };
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
public class A195273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195273Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195273.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195273.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195273Inst Instance=new A195273Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195274
{
public static readonly BigInteger[] Value={ 1L,81L,39609L,119743353L,2266745635377L,270149651796118149L,BigInteger.Parse("203368493873412168605037"),BigInteger.Parse("969036564714736790447759054277") };
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
public class A195274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195274Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195274.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195274.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195274Inst Instance=new A195274Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195275
{
public static readonly BigInteger[] Value={ 1L,121L,107811L,724789395L,37235577669213L,14698398557250127027UL,BigInteger.Parse("44727914263743356875711779"),BigInteger.Parse("1051443054205968885835418306282537") };
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
public class A195275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195275Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195275.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195275.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195275Inst Instance=new A195275Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195276
{
public static readonly BigInteger[] Value={ 1L,169L,248261L,3249312469L,383752106451389L,BigInteger.Parse("411207789366962687359"),BigInteger.Parse("4011033701337366560359871745") };
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
public class A195276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195276Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195276.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195276.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195276Inst Instance=new A195276Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195277
{
public static readonly BigInteger[] Value={ 1L,225L,507375L,11755976175L,2834518121474625L,BigInteger.Parse("7151051711514319493625"),BigInteger.Parse("189393562987102056163761489375") };
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
public class A195277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195277Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195277.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195277.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195277Inst Instance=new A195277Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195278
{
public static readonly long[] Value={ 1L,1L,9L,1L,25L,171L,1L,49L,2125L,6939L,1L,81L,11319L,626525L,609309L,1L,121L,39609L,12608631L,649112125L,116330103L,1L,169L,107811L,119743353L,68604760497L,2375645170875L,48439766655L,1L,225L,248261L,724789395L,2266745635377L };
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
public class A195278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195278Inst : IEnumerable<long>
{
public static readonly long[] Value=A195278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195278.Bytes);
public long this[int i]=>Value[i];

public static A195278Inst Instance=new A195278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195279
{
public static readonly long[] Value={ 171L,2125L,11319L,39609L,107811L,248261L,507375L,948209L,1653019L,2725821L,4294951L,6515625L,9572499L,13682229L,19096031L,26102241L,35028875L,46246189L,60169239L,77260441L,98032131L,123049125L,152931279L,188356049L,230061051L };
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
public class A195279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195279Inst : IEnumerable<long>
{
public static readonly long[] Value=A195279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195279.Bytes);
public long this[int i]=>Value[i];

public static A195279Inst Instance=new A195279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195280
{
public static readonly long[] Value={ 6939L,626525L,12608631L,119743353L,724789395L,3249312469L,11755976175L,36215968241L,98454861067L,242177297229L,548894457959L,1162058315625L,2322243189891L,4416808121541L,8048123047903L,14125147709409L,23983914638075L };
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
public class A195280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195280Inst : IEnumerable<long>
{
public static readonly long[] Value=A195280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195280.Bytes);
public long this[int i]=>Value[i];

public static A195280Inst Instance=new A195280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195281
{
public static readonly long[] Value={ 609309L,649112125L,68604760497L,2266745635377L,37235577669213L,383752106451389L,2834518121474625L,16307551677812033L,77247504140304381L,313215736935324573L,1118258748766971057L,3590779676071640625L };
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
public class A195281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195281Inst : IEnumerable<long>
{
public static readonly long[] Value=A195281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195281.Bytes);
public long this[int i]=>Value[i];

public static A195281Inst Instance=new A195281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195282
{
public static readonly BigInteger[] Value={ 116330103L,2375645170875L,1833160598134397L,270149651796118149L,14698398557250127027UL,BigInteger.Parse("411207789366962687359"),BigInteger.Parse("7151051711514319493625"),BigInteger.Parse("87046671186871404342793"),BigInteger.Parse("802793502537221468366191") };
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
public class A195282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195282Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195282.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195282.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195282Inst Instance=new A195282Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195283
{
public static readonly BigInteger[] Value={ 48439766655L,30812488814662125L,BigInteger.Parse("241338657495589799523"),BigInteger.Parse("203368493873412168605037"),BigInteger.Parse("44727914263743356875711779"),BigInteger.Parse("4011033701337366560359871745"),BigInteger.Parse("189393562987102056163761489375") };
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
public class A195283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195283Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195283.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195283.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195283Inst Instance=new A195283Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195284
{
public static readonly long[] Value={ 2L,1L,0L,8L,1L,8L,5L,1L,0L,6L,7L,7L,8L,9L,1L,9L,5L,5L,4L,6L,6L,5L,9L,2L,9L,0L,2L,9L,6L,2L,1L,8L,1L,2L,3L,5L,5L,8L,1L,3L,0L,3L,6L,7L,5L,9L,5L,5L,0L,1L,4L,4L,5L,5L,1L,2L,3L,8L,3L,3L,6L,5L,6L,8L,5L,2L,8L,3L,9L,6L,2L,9L,2L,4L,2L,6L,1L,5L,8L,8L,1L,4L,2L,2L,9L,4L,9L,8L,7L,3L,8L,9L,1L,9L,5L,3L,3L,5L,3L,0L };
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
public class A195284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195284Inst : IEnumerable<long>
{
public static readonly long[] Value=A195284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195284.Bytes);
public long this[int i]=>Value[i];

public static A195284Inst Instance=new A195284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195285
{
public static readonly long[] Value={ 5L,9L,7L,7L,2L,3L,3L,5L,0L,7L,5L,2L,0L,7L,4L,9L,4L,5L,7L,2L,3L,2L,0L,6L,6L,7L,8L,8L,9L,7L,7L,0L,7L,0L,6L,2L,3L,6L,6L,0L,8L,3L,2L,3L,9L,1L,5L,9L,6L,3L,0L,5L,3L,5L,1L,5L,5L,2L,1L,6L,1L,0L,7L,4L,9L,3L,3L,6L,5L,1L,8L,1L,2L,4L,9L,0L,1L,4L,8L,1L,5L,9L,4L,5L,3L,9L,0L,6L,8L,4L,6L,6L,2L,7L,9L,9L,9L,1L,2L,5L };
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
public class A195285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195285Inst : IEnumerable<long>
{
public static readonly long[] Value=A195285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195285.Bytes);
public long this[int i]=>Value[i];

public static A195285Inst Instance=new A195285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195286
{
public static readonly long[] Value={ 4L,0L,7L,9L,2L,1L,5L,6L,1L,0L,8L,7L,4L,2L,2L,7L,8L,6L,4L,0L,2L,2L,5L,7L,9L,2L,8L,7L,2L,1L,8L,2L,2L,5L,5L,9L,1L,6L,5L,1L,0L,1L,6L,7L,5L,6L,8L,7L,9L,6L,7L,7L,1L,2L,6L,0L,6L,7L,9L,7L,6L,6L,4L,3L,5L,4L,0L,7L,4L,6L,9L,0L,5L,6L,4L,9L,7L,7L,9L,3L,5L,6L,4L,7L,0L,6L,7L,9L,0L,8L,0L,8L,7L,5L,1L,4L,5L,6L,0L,6L };
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
public class A195286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195286Inst : IEnumerable<long>
{
public static readonly long[] Value=A195286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195286.Bytes);
public long this[int i]=>Value[i];

public static A195286Inst Instance=new A195286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195287
{
public static readonly ulong[] Value={ 2L,0L,4L,8L,232L,448L,18224L,35424L,1036064L,2025472L,130960832L,257072000L,689908475264L,1358275350528L,8031885897472L,15847920983552L,7981032500085248L,15774370258485248L,12448755354530366464UL };
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
public class A195287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195287Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A195287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195287.Bytes);
public ulong this[int i]=>Value[i];

public static A195287Inst Instance=new A195287Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195288
{
public static readonly long[] Value={ 4L,8L,0L,7L,4L,0L,1L,7L,0L,0L,6L,1L,8L,6L,5L,2L,3L,9L,0L,8L,2L,5L,6L,2L,8L,3L,5L,6L,6L,2L,7L,3L,2L,7L,9L,2L,8L,3L,3L,5L,0L,6L,2L,0L,9L,8L,4L,6L,0L,3L,2L,8L,2L,8L,3L,6L,1L,3L,9L,3L,7L,4L,0L,8L,3L,0L,2L,8L,8L,9L,2L,6L,4L,3L,9L,0L,6L,8L,0L,5L,9L,3L,6L,0L,6L,1L,5L,8L,7L,7L,6L,0L,2L,4L,6L,5L,4L,2L,9L,0L };
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
public class A195288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195288Inst : IEnumerable<long>
{
public static readonly long[] Value=A195288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195288.Bytes);
public long this[int i]=>Value[i];

public static A195288Inst Instance=new A195288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195289
{
public static readonly long[] Value={ 4L,8L,4L,7L,8L,2L,3L,8L,5L,3L,6L,6L,1L,7L,5L,3L,4L,8L,3L,3L,5L,1L,6L,5L,4L,1L,8L,0L,2L,2L,8L,1L,1L,5L,2L,7L,8L,0L,8L,8L,2L,5L,5L,4L,5L,2L,2L,8L,2L,5L,9L,9L,2L,3L,4L,1L,2L,9L,5L,4L,4L,3L,3L,4L,6L,0L,2L,1L,8L,8L,6L,9L,4L,6L,2L,9L,6L,2L,9L,3L,6L,8L,4L,9L,2L,7L,9L,5L,9L,9L,8L,0L,7L,0L,1L,2L,2L,0L,6L,2L };
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
public class A195289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195289Inst : IEnumerable<long>
{
public static readonly long[] Value=A195289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195289.Bytes);
public long this[int i]=>Value[i];

public static A195289Inst Instance=new A195289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195290
{
public static readonly long[] Value={ 6L,0L,6L,0L,9L,1L,5L,2L,6L,7L,3L,1L,3L,2L,6L,4L,4L,9L,4L,8L,6L,4L,3L,8L,0L,2L,4L,6L,6L,1L,2L,9L,9L,1L,7L,6L,5L,2L,9L,8L,5L,9L,3L,7L,5L,1L,6L,1L,5L,4L,9L,1L,7L,4L,2L,1L,8L,5L,7L,7L,0L,3L,0L,5L,6L,7L,4L,5L,6L,7L,7L,6L,4L,8L,3L,7L,6L,0L,1L,5L,9L,5L,0L,7L,3L,0L,8L,9L,4L,3L,2L,8L,3L,2L,7L,4L,9L,5L,9L,7L };
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
public class A195290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195290Inst : IEnumerable<long>
{
public static readonly long[] Value=A195290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195290.Bytes);
public long this[int i]=>Value[i];

public static A195290Inst Instance=new A195290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195291
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,9L,10L,11L,13L,14L,15L,17L,18L,19L,21L,22L,23L,25L,26L,27L,29L,30L,31L,33L,34L,35L,37L,38L,39L,41L,42L,43L,45L,46L,47L,49L,50L,51L,53L,54L,55L,57L,58L,59L,61L,62L,63L,65L,66L,67L,69L,70L,71L,73L,74L,75L,77L,78L,79L,81L,82L,83L,85L,86L,87L,89L,90L,91L,93L,94L,95L,97L,98L,99L,100L };
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
public class A195291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195291Inst : IEnumerable<long>
{
public static readonly long[] Value=A195291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195291.Bytes);
public long this[int i]=>Value[i];

public static A195291Inst Instance=new A195291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195292
{
public static readonly long[] Value={ 3L,9L,3L,6L,8L,2L,0L,8L,2L,8L,8L,4L,8L,5L,4L,1L,9L,2L,6L,3L,7L,0L,4L,4L,8L,6L,7L,7L,1L,1L,9L,8L,5L,3L,6L,1L,3L,6L,9L,9L,3L,9L,7L,3L,2L,2L,1L,2L,0L,9L,2L,5L,0L,3L,2L,3L,6L,5L,3L,3L,0L,1L,3L,1L,0L,0L,3L,3L,8L,6L,1L,8L,4L,9L,3L,0L,4L,0L,0L,6L,8L,3L,6L,0L,2L,7L,5L,2L,6L,1L,4L,0L,7L,1L,1L,7L,8L,3L,9L,8L };
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
public class A195292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195292Inst : IEnumerable<long>
{
public static readonly long[] Value=A195292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195292.Bytes);
public long this[int i]=>Value[i];

public static A195292Inst Instance=new A195292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195293
{
public static readonly long[] Value={ 6L,1L,8L,4L,6L,5L,8L,4L,3L,8L,4L,2L,6L,4L,9L,0L,8L,2L,4L,7L,3L,2L,1L,1L,4L,7L,8L,3L,9L,6L,1L,1L,1L,5L,5L,3L,7L,7L,2L,0L,7L,9L,8L,8L,3L,8L,0L,6L,0L,4L,3L,0L,6L,5L,1L,5L,9L,7L,9L,5L,0L,3L,5L,9L,6L,4L,2L,4L,3L,1L,5L,1L,9L,5L,0L,6L,4L,3L,2L,3L,9L,0L,3L,8L,1L,7L,9L,5L,4L,7L,6L,2L,1L,6L,0L,2L,6L,4L,4L };
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
public class A195293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195293Inst : IEnumerable<long>
{
public static readonly long[] Value=A195293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195293.Bytes);
public long this[int i]=>Value[i];

public static A195293Inst Instance=new A195293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195294
{
public static readonly long[] Value={ 101L,313L,2L,3L,11411L,5L,10601L,7L,181L,191L,11L,0L,0L,0L,0L,0L,0L,0L,0L,101L,1311131L,1212121L,131L,11411L,151L,1616161L,1117111L,181L,191L,1120211L,1221221L,72227L,32323L,12421L,3425243L,1126211L,12721L,12821L,1129211L,73037L,313L,73237L,13331L,1134311L,353L };
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
public class A195294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195294Inst : IEnumerable<long>
{
public static readonly long[] Value=A195294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195294.Bytes);
public long this[int i]=>Value[i];

public static A195294Inst Instance=new A195294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195295
{
public static readonly long[] Value={ 0L,1L,2L,5L,8L,22L,53L,151L,435L,1314L,4239L,13705L,45746L,153850L,525236L,1817111L,6341424L,22336060L,79287664L,283277225L,1018369893L };
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
public class A195295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195295Inst : IEnumerable<long>
{
public static readonly long[] Value=A195295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195295.Bytes);
public long this[int i]=>Value[i];

public static A195295Inst Instance=new A195295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195296
{
public static readonly long[] Value={ 6L,9L,9L,7L,1L,4L,2L,2L,7L,3L,8L,1L,4L,3L,6L,0L,5L,6L,5L,0L,4L,8L,9L,8L,3L,4L,5L,3L,0L,5L,4L,6L,9L,9L,6L,9L,1L,8L,2L,5L,6L,7L,8L,0L,0L,1L,8L,6L,3L,1L,6L,6L,3L,4L,5L,3L,4L,0L,0L,0L,8L,0L,9L,3L,8L,4L,1L,3L,7L,2L,0L,7L,4L,3L,9L,6L,0L,5L,5L,1L,5L,3L,1L,9L,8L,2L,8L,8L,3L,9L,1L,7L,4L,3L,6L,4L,2L,4L,7L };
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
public class A195296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195296Inst : IEnumerable<long>
{
public static readonly long[] Value=A195296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195296.Bytes);
public long this[int i]=>Value[i];

public static A195296Inst Instance=new A195296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195297
{
public static readonly long[] Value={ 5L,4L,1L,6L,7L,7L,0L,5L,2L,1L,6L,1L,9L,8L,5L,5L,4L,2L,0L,6L,4L,7L,8L,0L,7L,6L,4L,5L,5L,6L,8L,5L,0L,0L,9L,2L,5L,2L,4L,1L,1L,2L,7L,0L,2L,3L,0L,4L,6L,3L,2L,1L,3L,5L,8L,9L,9L,9L,5L,0L,9L,2L,2L,0L,3L,5L,7L,0L,4L,9L,6L,1L,6L,1L,6L,8L,7L,8L,2L,4L,4L,4L,1L,7L,0L,6L,0L,2L,2L,6L,8L,4L,8L,1L,3L,7L,9L,5L,8L,9L };
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
public class A195297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195297Inst : IEnumerable<long>
{
public static readonly long[] Value=A195297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195297.Bytes);
public long this[int i]=>Value[i];

public static A195297Inst Instance=new A195297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195298
{
public static readonly long[] Value={ 2L,0L,8L,0L,0L,3L,1L,3L,9L,6L,9L,3L,7L,2L,9L,0L,9L,3L,4L,5L,9L,9L,2L,2L,9L,2L,8L,3L,2L,9L,3L,4L,3L,7L,9L,4L,1L,0L,7L,9L,3L,3L,4L,1L,9L,5L,0L,2L,1L,8L,5L,0L,6L,9L,6L,6L,7L,9L,4L,8L,0L,5L,1L,1L,7L,9L,5L,4L,6L,1L,6L,3L,9L,6L,0L,7L,1L,1L,5L,7L,6L,6L,6L,6L,5L,5L,9L,4L,1L,1L,6L,8L,8L,0L,2L,6L,4L,7L,8L };
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
public class A195298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195298Inst : IEnumerable<long>
{
public static readonly long[] Value=A195298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195298.Bytes);
public long this[int i]=>Value[i];

public static A195298Inst Instance=new A195298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195299
{
public static readonly long[] Value={ 2L,2L,8L,7L,9L,1L,7L,8L,0L,9L,1L,0L,8L,2L,2L,2L,2L,9L,2L,3L,9L,9L,4L,1L,5L,4L,3L,6L,4L,8L,8L,3L,4L,4L,4L,3L,9L,7L,1L,0L,8L,4L,4L,7L,6L,0L,7L,7L,5L,9L,9L,0L,4L,2L,7L,1L,6L,5L,4L,6L,8L,0L,0L,9L,1L,9L,9L,5L,6L,9L,3L,6L,1L,7L,7L,7L,2L,8L,6L,3L,9L,4L,2L,2L,8L,7L,8L,9L,5L,5L,8L,5L,2L,3L,9L,0L,3L,4L,6L };
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
public class A195299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195299Inst : IEnumerable<long>
{
public static readonly long[] Value=A195299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195299.Bytes);
public long this[int i]=>Value[i];

public static A195299Inst Instance=new A195299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195300
{
public static readonly long[] Value={ 5L,7L,1L,1L,4L,0L,9L,7L,8L,6L,3L,4L,2L,6L,2L,1L,6L,8L,6L,1L,9L,2L,0L,8L,1L,0L,8L,5L,8L,7L,3L,9L,5L,1L,2L,2L,0L,5L,7L,8L,9L,8L,6L,2L,7L,5L,0L,4L,1L,0L,6L,1L,3L,2L,5L,5L,5L,4L,2L,1L,2L,6L,9L,6L,0L,1L,3L,0L,9L,2L,0L,3L,0L,4L,0L,3L,6L,6L,3L,6L,8L,1L,4L,2L,4L,7L,2L,9L,1L,6L,1L,9L,5L,1L,9L,4L,5L,5L,5L };
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
public class A195300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195300Inst : IEnumerable<long>
{
public static readonly long[] Value=A195300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195300.Bytes);
public long this[int i]=>Value[i];

public static A195300Inst Instance=new A195300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195301
{
public static readonly long[] Value={ 6L,3L,4L,0L,5L,0L,6L,7L,1L,1L,2L,4L,4L,2L,8L,8L,5L,0L,6L,8L,5L,0L,5L,2L,8L,8L,5L,3L,4L,3L,9L,6L,2L,2L,1L,3L,1L,9L,8L,9L,1L,0L,0L,0L,3L,5L,6L,9L,5L,5L,3L,6L,1L,2L,9L,8L,9L,9L,8L,5L,8L,4L,0L,1L,0L,1L,7L,7L,1L,7L,5L,8L,3L,2L,3L,6L,9L,1L,8L,9L,6L,9L,6L,3L,2L,4L,9L,4L,5L,6L,6L,6L,3L,1L,1L,0L,0L,0L };
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
public class A195301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195301Inst : IEnumerable<long>
{
public static readonly long[] Value=A195301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195301.Bytes);
public long this[int i]=>Value[i];

public static A195301Inst Instance=new A195301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195302
{
public static readonly long[] Value={ 2L,3L,5L,7L,211L,223L,229L,241L,271L,283L,311L,313L,317L,331L,337L,347L,353L,359L,367L,373L,379L,383L,389L,397L,523L,541L,547L,571L,719L,743L,761L,773L,797L,211151L,211193L,211199L,211229L,211241L,211271L,211283L,211313L,211349L,211373L,211433L,211457L,211499L,211571L,211619L,211643L,211661L,211691L,211727L,211811L,211859L,211877L,211997L,213131L };
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
public class A195302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195302Inst : IEnumerable<long>
{
public static readonly long[] Value=A195302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195302.Bytes);
public long this[int i]=>Value[i];

public static A195302Inst Instance=new A195302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195303
{
public static readonly long[] Value={ 6L,1L,4L,0L,5L,8L,9L,7L,1L,0L,3L,2L,2L,1L,2L,6L,1L,1L,5L,4L,6L,3L,8L,4L,8L,9L,2L,5L,3L,9L,3L,8L,5L,4L,0L,8L,2L,6L,0L,3L,6L,7L,3L,8L,6L,8L,9L,6L,9L,9L,6L,8L,9L,2L,7L,6L,4L,7L,9L,4L,1L,9L,1L,7L,6L,7L,3L,2L,8L,5L,7L,4L,5L,1L,7L,0L,3L,8L,0L,3L,8L,4L,9L,2L,8L,5L,5L,8L,3L,1L,6L,0L,3L,1L,2L,0L,5L,5L,1L,2L };
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
public class A195303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195303Inst : IEnumerable<long>
{
public static readonly long[] Value=A195303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195303.Bytes);
public long this[int i]=>Value[i];

public static A195303Inst Instance=new A195303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195304
{
public static readonly long[] Value={ 1L,8L,9L,6L,3L,0L,0L,5L,6L,6L,3L,0L,9L,2L,0L,2L,0L,1L,4L,7L,5L,3L,8L,6L,7L,2L,0L,3L,6L,5L,4L,8L,1L,9L,9L,1L,7L,0L,8L,0L,1L,0L,3L,2L,8L,2L,9L,8L,1L,9L,2L,8L,6L,6L,6L,4L,1L,0L,2L,7L,8L,4L,3L,9L,4L,4L,4L,2L,9L,7L,6L,3L,7L,7L,2L,5L,4L,6L,2L,9L,2L,1L,1L,7L,4L,3L,4L,9L,5L,1L,7L,5L,2L,6L,6L,7L,2L,1L,0L,7L };
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
public class A195304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195304Inst : IEnumerable<long>
{
public static readonly long[] Value=A195304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195304.Bytes);
public long this[int i]=>Value[i];

public static A195304Inst Instance=new A195304Inst();

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