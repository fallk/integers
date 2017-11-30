using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A010805
{
public static readonly long[] Value={ 0L,1L,131072L,129140163L,17179869184L,762939453125L,16926659444736L,232630513987207L,2251799813685248L,16677181699666569L,100000000000000000L,505447028499293771L,2218611106740436992L,8650415919381337933L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010805Inst : IEnumerable<long>
{
public static readonly long[] Value=A010805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010805.Bytes);
public long this[int i]=>Value[i];

public static A010805Inst Instance=new A010805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010806
{
public static readonly BigInteger[] Value={ 0L,1L,262144L,387420489L,68719476736L,3814697265625L,101559956668416L,1628413597910449L,18014398509481984L,150094635296999121L,1000000000000000000L,5559917313492231481L,BigInteger.Parse("26623333280885243904") };
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
public class A010806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010806Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A010806.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A010806.Bytes);
public BigInteger this[int i]=>Value[i];

public static A010806Inst Instance=new A010806Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010807
{
public static readonly BigInteger[] Value={ 0L,1L,524288L,1162261467L,274877906944L,19073486328125L,609359740010496L,11398895185373143L,144115188075855872L,1350851717672992089L,10000000000000000000UL,BigInteger.Parse("61159090448414546291"),BigInteger.Parse("319479999370622926848"),BigInteger.Parse("1461920290375446110677"),BigInteger.Parse("5976303958948914397184") };
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
public class A010807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010807Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A010807.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A010807.Bytes);
public BigInteger this[int i]=>Value[i];

public static A010807Inst Instance=new A010807Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010808
{
public static readonly BigInteger[] Value={ 0L,1L,1048576L,3486784401L,1099511627776L,95367431640625L,3656158440062976L,79792266297612001L,1152921504606846976L,12157665459056928801UL,BigInteger.Parse("100000000000000000000"),BigInteger.Parse("672749994932560009201"),BigInteger.Parse("3833759992447475122176") };
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
public class A010808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010808Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A010808.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A010808.Bytes);
public BigInteger this[int i]=>Value[i];

public static A010808Inst Instance=new A010808Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010809
{
public static readonly BigInteger[] Value={ 0L,1L,2097152L,10460353203L,4398046511104L,476837158203125L,21936950640377856L,558545864083284007L,9223372036854775808UL,BigInteger.Parse("109418989131512359209"),BigInteger.Parse("1000000000000000000000"),BigInteger.Parse("7400249944258160101211") };
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
public class A010809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010809Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A010809.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A010809.Bytes);
public BigInteger this[int i]=>Value[i];

public static A010809Inst Instance=new A010809Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010810
{
public static readonly BigInteger[] Value={ 0L,1L,4194304L,31381059609L,17592186044416L,2384185791015625L,131621703842267136L,3909821048582988049L,BigInteger.Parse("73786976294838206464"),BigInteger.Parse("984770902183611232881"),BigInteger.Parse("10000000000000000000000"),BigInteger.Parse("81402749386839761113321") };
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
public class A010810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010810Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A010810.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A010810.Bytes);
public BigInteger this[int i]=>Value[i];

public static A010810Inst Instance=new A010810Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010811
{
public static readonly BigInteger[] Value={ 0L,1L,8388608L,94143178827L,70368744177664L,11920928955078125L,789730223053602816L,BigInteger.Parse("27368747340080916343"),BigInteger.Parse("590295810358705651712"),BigInteger.Parse("8862938119652501095929"),BigInteger.Parse("100000000000000000000000") };
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
public class A010811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010811Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A010811.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A010811.Bytes);
public BigInteger this[int i]=>Value[i];

public static A010811Inst Instance=new A010811Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010812
{
public static readonly BigInteger[] Value={ 0L,1L,16777216L,282429536481L,281474976710656L,59604644775390625L,4738381338321616896L,BigInteger.Parse("191581231380566414401"),BigInteger.Parse("4722366482869645213696"),BigInteger.Parse("79766443076872509863361"),BigInteger.Parse("1000000000000000000000000") };
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
public class A010812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010812Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A010812.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A010812.Bytes);
public BigInteger this[int i]=>Value[i];

public static A010812Inst Instance=new A010812Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010813
{
public static readonly BigInteger[] Value={ 0L,1L,33554432L,847288609443L,1125899906842624L,298023223876953125L,BigInteger.Parse("28430288029929701376"),BigInteger.Parse("1341068619663964900807"),BigInteger.Parse("37778931862957161709568"),BigInteger.Parse("717897987691852588770249"),BigInteger.Parse("10000000000000000000000000") };
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
public class A010813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010813Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A010813.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A010813.Bytes);
public BigInteger this[int i]=>Value[i];

public static A010813Inst Instance=new A010813Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010830
{
public static readonly long[] Value={ 1L,-25L,275L,-1700L,6050L,-9405L,-15550L,107525L,-182875L,-81675L,756655L,-801550L,-662975L,1220175L,1361350L,-209440L,-9601900L,8608900L,14889050L,-19948500L,-6262465L,-7057550L,38788925L,19716425L,-69119875L,23579969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010830Inst : IEnumerable<long>
{
public static readonly long[] Value=A010830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010830.Bytes);
public long this[int i]=>Value[i];

public static A010830Inst Instance=new A010830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010831
{
public static readonly long[] Value={ 1L,-26L,299L,-1950L,7475L,-13754L,-12220L,132756L,-276575L,0L,1010100L,-1486030L,-519961L,2486300L,829725L,-2215486L,-11643060L,18523050L,16317925L,-42861650L,0L,11010090L,59644221L,-5743400L,-138219900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010831Inst : IEnumerable<long>
{
public static readonly long[] Value=A010831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010831.Bytes);
public long this[int i]=>Value[i];

public static A010831Inst Instance=new A010831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010832
{
public static readonly long[] Value={ 1L,-27L,324L,-2223L,9126L,-19278L,-5967L,159030L,-399087L,151593L,1270971L,-2500875L,74970L,4203522L,-1004157L,-4796037L,-11750778L,32885190L,10452375L,-77533092L,27104868L,43070625L,63798840L,-69960267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010832Inst : IEnumerable<long>
{
public static readonly long[] Value=A010832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010832.Bytes);
public long this[int i]=>Value[i];

public static A010832Inst Instance=new A010832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010833
{
public static readonly long[] Value={ 1L,-28L,350L,-2520L,11025L,-26180L,4158L,184600L,-554400L,401100L,1496964L,-3920280L,1444625L,6224400L,-4972350L,-7121296L,-8308965L,50796900L,-8971200L,-121968000L,94011435L,80598288L,20282500L,-175228200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010833Inst : IEnumerable<long>
{
public static readonly long[] Value=A010833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010833.Bytes);
public long this[int i]=>Value[i];

public static A010833Inst Instance=new A010833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010834
{
public static readonly long[] Value={ 1L,-29L,377L,-2842L,13195L,-34684L,19285L,206973L,-745706L,782275L,1621564L,-5803161L,4026360L,8149841L,-12056025L,-7428263L,254504L,69194580L,-49156653L,-167517050L,224634319L,94868280L,-112333182L,-288914501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010834Inst : IEnumerable<long>
{
public static readonly long[] Value=A010834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010834.Bytes);
public long this[int i]=>Value[i];

public static A010834Inst Instance=new A010834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010835
{
public static readonly long[] Value={ 1L,-30L,405L,-3190L,15660L,-45036L,40745L,222750L,-974835L,1334580L,1547469L,-8174520L,8380245L,9200250L,-23243355L,-2643380L,14704740L,82050570L,-116275500L,-195804810L,442809990L,25147930L,-371898000L,-313802910L,125394405L,1688931000L,-1364323095L,-737497840L,158838945L,-1653918750L,6309965146L,-1076120370L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010835Inst : IEnumerable<long>
{
public static readonly long[] Value=A010835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010835.Bytes);
public long this[int i]=>Value[i];

public static A010835Inst Instance=new A010835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010836
{
public static readonly long[] Value={ 1L,-31L,434L,-3565L,18445L,-57505L,70091L,227447L,-1241550L,2102730L,1139498L,-11000164L,15185009L,8060465L,-39266925L,11975548L,33735905L,79961555L,-212042635L,-176681400L,762467041L,-231771190L,-762218948L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010836Inst : IEnumerable<long>
{
public static readonly long[] Value=A010836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010836.Bytes);
public long this[int i]=>Value[i];

public static A010836Inst Instance=new A010836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010837
{
public static readonly long[] Value={ 1L,-32L,464L,-3968L,21576L,-72384L,109120L,215296L,-1542684L,3135712L,217248L,-14153856L,25215616L,2704192L,-60182656L,43083520L,52111434L,50631680L,-328746320L,-68928128L,1172526144L,-825260672L,-1202344640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010837Inst : IEnumerable<long>
{
public static readonly long[] Value=A010837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010837.Bytes);
public long this[int i]=>Value[i];

public static A010837Inst Instance=new A010837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010838
{
public static readonly long[] Value={ 1L,-44L,902L,-11352L,96965L,-582692L,2428382L,-6245448L,3684670L,43828180L,-195750104L,340202584L,211248851L,-2418539816L,4734800950L,-43313600L,-16560186918L,26632794760L,4021681554L,-50231748600L,12519655368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010838Inst : IEnumerable<long>
{
public static readonly long[] Value=A010838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010838.Bytes);
public long this[int i]=>Value[i];

public static A010838Inst Instance=new A010838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010839
{
public static readonly long[] Value={ 1L,-48L,1080L,-15040L,143820L,-985824L,4857920L,-16295040L,28412910L,38671600L,-424520544L,1268350272L,-1211937160L,-4306546080L,18293091840L,-23522231424L,-26299018683L,137218594320L,-150999182320L,-134713340160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010839Inst : IEnumerable<long>
{
public static readonly long[] Value=A010839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010839.Bytes);
public long this[int i]=>Value[i];

public static A010839Inst Instance=new A010839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010840
{
public static readonly long[] Value={ 1L,-40L,740L,-8320L,62530L,-322048L,1085240L,-1799680L,-2821065L,26012480L,-66837420L,35093760L,268749870L,-783902720L,526221400L,1691816960L,-3960854625L,1042577120L,5103133240L,-380798080L,-10159511430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010840Inst : IEnumerable<long>
{
public static readonly long[] Value=A010840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010840.Bytes);
public long this[int i]=>Value[i];

public static A010840Inst Instance=new A010840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010841
{
public static readonly long[] Value={ 1L,-64L,1952L,-37632L,512400L,-5207936L,40618368L,-244952576L,1124362248L,-3684692800L,6607738816L,8603838208L,-109557823168L,389162471040L,-599467398400L,-815811136000L,6834665221028L,-15689583552384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010841Inst : IEnumerable<long>
{
public static readonly long[] Value=A010841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010841.Bytes);
public long this[int i]=>Value[i];

public static A010841Inst Instance=new A010841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010842
{
public static readonly BigInteger[] Value={ 1L,3L,10L,38L,168L,872L,5296L,37200L,297856L,2681216L,26813184L,294947072L,3539368960L,46011804672L,644165281792L,9662479259648L,154599668219904L,2628194359869440L,47307498477912064L,898842471080853504L,17976849421618118656UL,BigInteger.Parse("377513837853982588928") };
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
public class A010842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010842Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A010842.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A010842.Bytes);
public BigInteger this[int i]=>Value[i];

public static A010842Inst Instance=new A010842Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010843
{
public static readonly long[] Value={ 1L,-2L,5L,-12L,33L,-78L,261L,-360L,3681L,13446L,193509L,1951452L,23948865L,309740922L,4341155877L,65102989248L,1041690874689L,17708615729550L,318755470552389L,6056352778233924L,121127059051462881L,2543668229620367298L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010843Inst : IEnumerable<long>
{
public static readonly long[] Value=A010843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010843.Bytes);
public long this[int i]=>Value[i];

public static A010843Inst Instance=new A010843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010844
{
public static readonly BigInteger[] Value={ 1L,3L,13L,79L,633L,6331L,75973L,1063623L,17017969L,306323443L,6126468861L,134782314943L,3234775558633L,84104164524459L,2354916606684853L,70647498200545591L,2260719942417458913L,BigInteger.Parse("76864478042193603043") };
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
public class A010844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010844Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A010844.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A010844.Bytes);
public BigInteger this[int i]=>Value[i];

public static A010844Inst Instance=new A010844Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010845
{
public static readonly BigInteger[] Value={ 1L,4L,25L,226L,2713L,40696L,732529L,15383110L,369194641L,9968255308L,299047659241L,9868572754954L,355268619178345L,13855476147955456L,581929998214129153L,BigInteger.Parse("26186849919635811886"),BigInteger.Parse("1256968796142518970529") };
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
public class A010845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010845Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A010845.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A010845.Bytes);
public BigInteger this[int i]=>Value[i];

public static A010845Inst Instance=new A010845Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010878
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,0L,1L,2L,3L,4L,5L,6L,7L,8L,0L,1L,2L,3L,4L,5L,6L,7L,8L,0L,1L,2L,3L,4L,5L,6L,7L,8L,0L,1L,2L,3L,4L,5L,6L,7L,8L,0L,1L,2L,3L,4L,5L,6L,7L,8L,0L,1L,2L,3L,4L,5L,6L,7L,8L,0L,1L,2L,3L,4L,5L,6L,7L,8L,0L,1L,2L,3L,4L,5L,6L,7L,8L,0L,1L,2L,3L,4L,5L,6L,7L,8L,0L,1L,2L,3L,4L,5L,6L,7L,8L,0L,1L,2L,3L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010878Inst : IEnumerable<long>
{
public static readonly long[] Value=A010878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010878.Bytes);
public long this[int i]=>Value[i];

public static A010878Inst Instance=new A010878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010879
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010879Inst : IEnumerable<long>
{
public static readonly long[] Value=A010879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010879.Bytes);
public long this[int i]=>Value[i];

public static A010879Inst Instance=new A010879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010880
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010880Inst : IEnumerable<long>
{
public static readonly long[] Value=A010880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010880.Bytes);
public long this[int i]=>Value[i];

public static A010880Inst Instance=new A010880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010881
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,0L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010881Inst : IEnumerable<long>
{
public static readonly long[] Value=A010881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010881.Bytes);
public long this[int i]=>Value[i];

public static A010881Inst Instance=new A010881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010882
{
public static readonly long[] Value={ 1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010882Inst : IEnumerable<long>
{
public static readonly long[] Value=A010882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010882.Bytes);
public long this[int i]=>Value[i];

public static A010882Inst Instance=new A010882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010883
{
public static readonly long[] Value={ 1L,2L,3L,4L,1L,2L,3L,4L,1L,2L,3L,4L,1L,2L,3L,4L,1L,2L,3L,4L,1L,2L,3L,4L,1L,2L,3L,4L,1L,2L,3L,4L,1L,2L,3L,4L,1L,2L,3L,4L,1L,2L,3L,4L,1L,2L,3L,4L,1L,2L,3L,4L,1L,2L,3L,4L,1L,2L,3L,4L,1L,2L,3L,4L,1L,2L,3L,4L,1L,2L,3L,4L,1L,2L,3L,4L,1L,2L,3L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010883Inst : IEnumerable<long>
{
public static readonly long[] Value=A010883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010883.Bytes);
public long this[int i]=>Value[i];

public static A010883Inst Instance=new A010883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010884
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010884Inst : IEnumerable<long>
{
public static readonly long[] Value=A010884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010884.Bytes);
public long this[int i]=>Value[i];

public static A010884Inst Instance=new A010884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010885
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,1L,2L,3L,4L,5L,6L,1L,2L,3L,4L,5L,6L,1L,2L,3L,4L,5L,6L,1L,2L,3L,4L,5L,6L,1L,2L,3L,4L,5L,6L,1L,2L,3L,4L,5L,6L,1L,2L,3L,4L,5L,6L,1L,2L,3L,4L,5L,6L,1L,2L,3L,4L,5L,6L,1L,2L,3L,4L,5L,6L,1L,2L,3L,4L,5L,6L,1L,2L,3L,4L,5L,6L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010885Inst : IEnumerable<long>
{
public static readonly long[] Value=A010885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010885.Bytes);
public long this[int i]=>Value[i];

public static A010885Inst Instance=new A010885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010886
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,1L,2L,3L,4L,5L,6L,7L,1L,2L,3L,4L,5L,6L,7L,1L,2L,3L,4L,5L,6L,7L,1L,2L,3L,4L,5L,6L,7L,1L,2L,3L,4L,5L,6L,7L,1L,2L,3L,4L,5L,6L,7L,1L,2L,3L,4L,5L,6L,7L,1L,2L,3L,4L,5L,6L,7L,1L,2L,3L,4L,5L,6L,7L,1L,2L,3L,4L,5L,6L,7L,1L,2L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010886Inst : IEnumerable<long>
{
public static readonly long[] Value=A010886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010886.Bytes);
public long this[int i]=>Value[i];

public static A010886Inst Instance=new A010886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010887
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,1L,2L,3L,4L,5L,6L,7L,8L,1L,2L,3L,4L,5L,6L,7L,8L,1L,2L,3L,4L,5L,6L,7L,8L,1L,2L,3L,4L,5L,6L,7L,8L,1L,2L,3L,4L,5L,6L,7L,8L,1L,2L,3L,4L,5L,6L,7L,8L,1L,2L,3L,4L,5L,6L,7L,8L,1L,2L,3L,4L,5L,6L,7L,8L,1L,2L,3L,4L,5L,6L,7L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010887Inst : IEnumerable<long>
{
public static readonly long[] Value=A010887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010887.Bytes);
public long this[int i]=>Value[i];

public static A010887Inst Instance=new A010887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010888
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,2L,3L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010888Inst : IEnumerable<long>
{
public static readonly long[] Value=A010888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010888.Bytes);
public long this[int i]=>Value[i];

public static A010888Inst Instance=new A010888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010889
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010889Inst : IEnumerable<long>
{
public static readonly long[] Value=A010889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010889.Bytes);
public long this[int i]=>Value[i];

public static A010889Inst Instance=new A010889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010890
{
public static readonly long[] Value={ 1L,-1L,0L,1L,-1L,1L,0L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010890Inst : IEnumerable<long>
{
public static readonly long[] Value=A010890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010890.Bytes);
public long this[int i]=>Value[i];

public static A010890Inst Instance=new A010890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010891
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010891Inst : IEnumerable<long>
{
public static readonly long[] Value=A010891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010891.Bytes);
public long this[int i]=>Value[i];

public static A010891Inst Instance=new A010891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010892
{
public static readonly long[] Value={ 1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010892Inst : IEnumerable<long>
{
public static readonly long[] Value=A010892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010892.Bytes);
public long this[int i]=>Value[i];

public static A010892Inst Instance=new A010892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010893
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,10L,0L,0L,0L,0L,0L,0L,0L,0L,224L,0L,0L,206L,0L,0L,0L,0L,0L,0L,0L,0L,18132L,0L,0L,12048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010893Inst : IEnumerable<long>
{
public static readonly long[] Value=A010893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010893.Bytes);
public long this[int i]=>Value[i];

public static A010893Inst Instance=new A010893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010910
{
public static readonly long[] Value={ 4L,27L,182L,1227L,8272L,55767L,375962L,2534607L,17087452L,115197747L,776623742L,5235731187L,35297505832L,237963690927L,1604269674722L,10815436502967L,72913967391412L,491560986863307L,3313935758136902L,22341419483137947L,150618195689512192L,1015416271552762887L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010910Inst : IEnumerable<long>
{
public static readonly long[] Value=A010910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010910.Bytes);
public long this[int i]=>Value[i];

public static A010910Inst Instance=new A010910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010911
{
public static readonly long[] Value={ 3L,11L,40L,145L,526L,1908L,6921L,25105L,91065L,330326L,1198213L,4346356L,15765820L,57188385L,207443151L,752472043L,2729490816L,9900859685L,35914032730L,130273308376L,472548850273L,1714107200301L,6217692609825L,22553841080350L,81811015661001L,296758421753528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010911Inst : IEnumerable<long>
{
public static readonly long[] Value=A010911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010911.Bytes);
public long this[int i]=>Value[i];

public static A010911Inst Instance=new A010911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010912
{
public static readonly long[] Value={ 3L,7L,16L,37L,86L,200L,465L,1081L,2513L,5842L,13581L,31572L,73396L,170625L,396655L,922111L,2143648L,4983377L,11584946L,26931732L,62608681L,145547525L,338356945L,786584466L,1828587033L,4250949112L,9882257736L,22973462017L,53406819691L,124155792775L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010912Inst : IEnumerable<long>
{
public static readonly long[] Value=A010912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010912.Bytes);
public long this[int i]=>Value[i];

public static A010912Inst Instance=new A010912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010913
{
public static readonly long[] Value={ 3L,17L,96L,542L,3060L,17276L,97536L,550664L,3108912L,17552144L,99095040L,559465952L,3158605632L,17832701888L,100679000064L,568408596608L,3209093579520L,18117744283904L,102288278544384L,577494182698496L,3260388539102208L,18407342869216256L,103923280137093120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010913Inst : IEnumerable<long>
{
public static readonly long[] Value=A010913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010913.Bytes);
public long this[int i]=>Value[i];

public static A010913Inst Instance=new A010913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010914
{
public static readonly long[] Value={ 5L,17L,58L,198L,676L,2308L,7880L,26904L,91856L,313616L,1070752L,3655776L,12481600L,42614848L,145496192L,496755072L,1696027904L,5790601472L,19770350080L,67500197376L,230460089344L,786839962624L,2686439671808L,9172078761984L,31315435704320L,106917585293312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010914Inst : IEnumerable<long>
{
public static readonly long[] Value=A010914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010914.Bytes);
public long this[int i]=>Value[i];

public static A010914Inst Instance=new A010914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010915
{
public static readonly long[] Value={ 6L,16L,43L,116L,313L,845L,2281L,6157L,16619L,44858L,121081L,326823L,882164L,2381146L,6427213L,17348397L,46826965L,126395808L,341168818L,920886256L,2485665312L,6709332453L,18109896673L,48882412640L,131943892815L,356144263570L,961308127021L,2594772426806L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010915Inst : IEnumerable<long>
{
public static readonly long[] Value=A010915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010915.Bytes);
public long this[int i]=>Value[i];

public static A010915Inst Instance=new A010915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010916
{
public static readonly long[] Value={ 8L,10L,13L,17L,22L,28L,36L,46L,59L,76L,98L,126L,162L,208L,267L,343L,441L,567L,729L,937L,1204L,1547L,1988L,2555L,3284L,4221L,5425L,6972L,8960L,11515L,14799L,19020L,24445L,31417L,40377L,51892L,66691L,85711L,110155L,141570L,181944L,233832L,300518L,386222L,496368L,637926L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010916Inst : IEnumerable<long>
{
public static readonly long[] Value=A010916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010916.Bytes);
public long this[int i]=>Value[i];

public static A010916Inst Instance=new A010916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010917
{
public static readonly long[] Value={ 5L,21L,88L,369L,1547L,6486L,27193L,114009L,477993L,2004029L,8402073L,35226452L,147690090L,619204077L,2596069167L,10884255079L,45633225081L,191321428631L,802132415328L,3363012791217L,14099735676764L,59114418676555L,247842553617931L,1039102350307282L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010917Inst : IEnumerable<long>
{
public static readonly long[] Value=A010917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010917.Bytes);
public long this[int i]=>Value[i];

public static A010917Inst Instance=new A010917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010918
{
public static readonly long[] Value={ 8L,55L,379L,2612L,18002L,124071L,855106L,5893451L,40618081L,279942687L,1929384798L,13297456486L,91647010581L,631637678776L,4353291555505L,30003193292641L,206784130187015L,1425170850320396L,9822378297435246L,67696525926163327L,466569244606302614L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010918Inst : IEnumerable<long>
{
public static readonly long[] Value=A010918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010918.Bytes);
public long this[int i]=>Value[i];

public static A010918Inst Instance=new A010918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010919
{
public static readonly long[] Value={ 4L,13L,42L,135L,433L,1388L,4449L,14260L,45706L,146496L,469546L,1504979L,4823727L,15460908L,49554976L,158832563L,509086778L,1631714194L,5229935889L,16762880107L,53728029453L,172207945799L,551957272549L,1769121798104L,5670351840955L,18174492018967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010919Inst : IEnumerable<long>
{
public static readonly long[] Value=A010919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010919.Bytes);
public long this[int i]=>Value[i];

public static A010919Inst Instance=new A010919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010920
{
public static readonly long[] Value={ 3L,13L,56L,241L,1037L,4462L,19199L,82609L,355448L,1529413L,6580721L,28315366L,121834667L,524227237L,2255632184L,9705479209L,41760499493L,179686059838L,773148800711L,3326685824041L,14313982718072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010920Inst : IEnumerable<long>
{
public static readonly long[] Value=A010920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010920.Bytes);
public long this[int i]=>Value[i];

public static A010920Inst Instance=new A010920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010921
{
public static readonly long[] Value={ 3L,13L,57L,250L,1097L,4814L,21126L,92711L,406861L,1785505L,7835669L,34386747L,150905861L,662248712L,2906271193L,12754139184L,55971399613L,245629871954L,1077943993063L,4730545364606L,20759946333583L,91104796287932L,399812397069577L,1754572309731352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010921Inst : IEnumerable<long>
{
public static readonly long[] Value=A010921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010921.Bytes);
public long this[int i]=>Value[i];

public static A010921Inst Instance=new A010921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010922
{
public static readonly long[] Value={ 14L,23L,37L,59L,94L,149L,236L,373L,589L,930L,1468L,2317L,3657L,5771L,9107L,14371L,22677L,35783L,56463L,89094L,140583L,221828L,350025L,552308L,871492L,1375135L,2169837L,3423803L,5402445L,8524559L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010922Inst : IEnumerable<long>
{
public static readonly long[] Value=A010922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010922.Bytes);
public long this[int i]=>Value[i];

public static A010922Inst Instance=new A010922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010923
{
public static readonly long[] Value={ 14L,23L,38L,63L,105L,176L,296L,498L,838L,1411L,2376L,4001L,6738L,11348L,19113L,32192L,54221L,91325L,153820L,259082L,436377L,734999L,1237975L,2085149L,3512064L,5915450L,9963529L,16781802L,28265977L,47609039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010923Inst : IEnumerable<long>
{
public static readonly long[] Value=A010923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010923.Bytes);
public long this[int i]=>Value[i];

public static A010923Inst Instance=new A010923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010924
{
public static readonly long[] Value={ 8L,55L,378L,2598L,17856L,122724L,843480L,5797224L,39844224L,273848688L,1882157472L,12936036960L,88909166592L,611071221312L,4199882327424L,28865721292416L,198393621719040L,1363556058068736L,9371698078726656L,64411524820772352L,442699337396994048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010924Inst : IEnumerable<long>
{
public static readonly long[] Value=A010924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010924.Bytes);
public long this[int i]=>Value[i];

public static A010924Inst Instance=new A010924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010925
{
public static readonly long[] Value={ 5L,21L,88L,368L,1538L,6427L,26857L,112229L,468978L,1959746L,8189306L,34221135L,143001871L,597570335L,2497102330L,10434788478L,43604464772L,182212543365L,761422279419L,3181800093939L,13295975323332L,55560674643076L,232174661258332L,970201922073653L,4054239874815929L,16941690784755705L,70795240417122019L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010925Inst : IEnumerable<long>
{
public static readonly long[] Value=A010925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010925.Bytes);
public long this[int i]=>Value[i];

public static A010925Inst Instance=new A010925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010942
{
public static readonly long[] Value={ 1L,26L,325L,2600L,14950L,65780L,230230L,657800L,1562275L,3124550L,5311735L,7726160L,9657700L,10400600L,9657700L,7726160L,5311735L,3124550L,1562275L,657800L,230230L,65780L,14950L,2600L,325L,26L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010942Inst : IEnumerable<long>
{
public static readonly long[] Value=A010942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010942.Bytes);
public long this[int i]=>Value[i];

public static A010942Inst Instance=new A010942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010943
{
public static readonly long[] Value={ 1L,27L,351L,2925L,17550L,80730L,296010L,888030L,2220075L,4686825L,8436285L,13037895L,17383860L,20058300L,20058300L,17383860L,13037895L,8436285L,4686825L,2220075L,888030L,296010L,80730L,17550L,2925L,351L,27L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010943Inst : IEnumerable<long>
{
public static readonly long[] Value=A010943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010943.Bytes);
public long this[int i]=>Value[i];

public static A010943Inst Instance=new A010943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010944
{
public static readonly long[] Value={ 1L,28L,378L,3276L,20475L,98280L,376740L,1184040L,3108105L,6906900L,13123110L,21474180L,30421755L,37442160L,40116600L,37442160L,30421755L,21474180L,13123110L,6906900L,3108105L,1184040L,376740L,98280L,20475L,3276L,378L,28L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010944Inst : IEnumerable<long>
{
public static readonly long[] Value=A010944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010944.Bytes);
public long this[int i]=>Value[i];

public static A010944Inst Instance=new A010944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010945
{
public static readonly long[] Value={ 1L,29L,406L,3654L,23751L,118755L,475020L,1560780L,4292145L,10015005L,20030010L,34597290L,51895935L,67863915L,77558760L,77558760L,67863915L,51895935L,34597290L,20030010L,10015005L,4292145L,1560780L,475020L,118755L,23751L,3654L,406L,29L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010945Inst : IEnumerable<long>
{
public static readonly long[] Value=A010945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010945.Bytes);
public long this[int i]=>Value[i];

public static A010945Inst Instance=new A010945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010946
{
public static readonly long[] Value={ 1L,30L,435L,4060L,27405L,142506L,593775L,2035800L,5852925L,14307150L,30045015L,54627300L,86493225L,119759850L,145422675L,155117520L,145422675L,119759850L,86493225L,54627300L,30045015L,14307150L,5852925L,2035800L,593775L,142506L,27405L,4060L,435L,30L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010946Inst : IEnumerable<long>
{
public static readonly long[] Value=A010946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010946.Bytes);
public long this[int i]=>Value[i];

public static A010946Inst Instance=new A010946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010947
{
public static readonly long[] Value={ 1L,31L,465L,4495L,31465L,169911L,736281L,2629575L,7888725L,20160075L,44352165L,84672315L,141120525L,206253075L,265182525L,300540195L,300540195L,265182525L,206253075L,141120525L,84672315L,44352165L,20160075L,7888725L,2629575L,736281L,169911L,31465L,4495L,465L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010947Inst : IEnumerable<long>
{
public static readonly long[] Value=A010947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010947.Bytes);
public long this[int i]=>Value[i];

public static A010947Inst Instance=new A010947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010948
{
public static readonly long[] Value={ 1L,32L,496L,4960L,35960L,201376L,906192L,3365856L,10518300L,28048800L,64512240L,129024480L,225792840L,347373600L,471435600L,565722720L,601080390L,565722720L,471435600L,347373600L,225792840L,129024480L,64512240L,28048800L,10518300L,3365856L,906192L,201376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010948Inst : IEnumerable<long>
{
public static readonly long[] Value=A010948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010948.Bytes);
public long this[int i]=>Value[i];

public static A010948Inst Instance=new A010948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010949
{
public static readonly long[] Value={ 1L,33L,528L,5456L,40920L,237336L,1107568L,4272048L,13884156L,38567100L,92561040L,193536720L,354817320L,573166440L,818809200L,1037158320L,1166803110L,1166803110L,1037158320L,818809200L,573166440L,354817320L,193536720L,92561040L,38567100L,13884156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010949Inst : IEnumerable<long>
{
public static readonly long[] Value=A010949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010949.Bytes);
public long this[int i]=>Value[i];

public static A010949Inst Instance=new A010949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010950
{
public static readonly long[] Value={ 1L,34L,561L,5984L,46376L,278256L,1344904L,5379616L,18156204L,52451256L,131128140L,286097760L,548354040L,927983760L,1391975640L,1855967520L,2203961430L,2333606220L,2203961430L,1855967520L,1391975640L,927983760L,548354040L,286097760L,131128140L,52451256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010950Inst : IEnumerable<long>
{
public static readonly long[] Value=A010950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010950.Bytes);
public long this[int i]=>Value[i];

public static A010950Inst Instance=new A010950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010951
{
public static readonly long[] Value={ 1L,35L,595L,6545L,52360L,324632L,1623160L,6724520L,23535820L,70607460L,183579396L,417225900L,834451800L,1476337800L,2319959400L,3247943160L,4059928950L,4537567650L,4537567650L,4059928950L,3247943160L,2319959400L,1476337800L,834451800L,417225900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010951Inst : IEnumerable<long>
{
public static readonly long[] Value=A010951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010951.Bytes);
public long this[int i]=>Value[i];

public static A010951Inst Instance=new A010951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010952
{
public static readonly long[] Value={ 1L,36L,630L,7140L,58905L,376992L,1947792L,8347680L,30260340L,94143280L,254186856L,600805296L,1251677700L,2310789600L,3796297200L,5567902560L,7307872110L,8597496600L,9075135300L,8597496600L,7307872110L,5567902560L,3796297200L,2310789600L,1251677700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010952Inst : IEnumerable<long>
{
public static readonly long[] Value=A010952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010952.Bytes);
public long this[int i]=>Value[i];

public static A010952Inst Instance=new A010952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010953
{
public static readonly long[] Value={ 1L,37L,666L,7770L,66045L,435897L,2324784L,10295472L,38608020L,124403620L,348330136L,854992152L,1852482996L,3562467300L,6107086800L,9364199760L,12875774670L,15905368710L,17672631900L,17672631900L,15905368710L,12875774670L,9364199760L,6107086800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010953Inst : IEnumerable<long>
{
public static readonly long[] Value=A010953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010953.Bytes);
public long this[int i]=>Value[i];

public static A010953Inst Instance=new A010953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010954
{
public static readonly long[] Value={ 1L,38L,703L,8436L,73815L,501942L,2760681L,12620256L,48903492L,163011640L,472733756L,1203322288L,2707475148L,5414950296L,9669554100L,15471286560L,22239974430L,28781143380L,33578000610L,35345263800L,33578000610L,28781143380L,22239974430L,15471286560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010954Inst : IEnumerable<long>
{
public static readonly long[] Value=A010954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010954.Bytes);
public long this[int i]=>Value[i];

public static A010954Inst Instance=new A010954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010955
{
public static readonly long[] Value={ 1L,39L,741L,9139L,82251L,575757L,3262623L,15380937L,61523748L,211915132L,635745396L,1676056044L,3910797436L,8122425444L,15084504396L,25140840660L,37711260990L,51021117810L,62359143990L,68923264410L,68923264410L,62359143990L,51021117810L,37711260990L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010955Inst : IEnumerable<long>
{
public static readonly long[] Value=A010955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010955.Bytes);
public long this[int i]=>Value[i];

public static A010955Inst Instance=new A010955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010956
{
public static readonly long[] Value={ 1L,40L,780L,9880L,91390L,658008L,3838380L,18643560L,76904685L,273438880L,847660528L,2311801440L,5586853480L,12033222880L,23206929840L,40225345056L,62852101650L,88732378800L,113380261800L,131282408400L,137846528820L,131282408400L,113380261800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010956Inst : IEnumerable<long>
{
public static readonly long[] Value=A010956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010956.Bytes);
public long this[int i]=>Value[i];

public static A010956Inst Instance=new A010956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010957
{
public static readonly long[] Value={ 1L,41L,820L,10660L,101270L,749398L,4496388L,22481940L,95548245L,350343565L,1121099408L,3159461968L,7898654920L,17620076360L,35240152720L,63432274896L,103077446706L,151584480450L,202112640600L,244662670200L,269128937220L,269128937220L,244662670200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010957Inst : IEnumerable<long>
{
public static readonly long[] Value=A010957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010957.Bytes);
public long this[int i]=>Value[i];

public static A010957Inst Instance=new A010957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011022
{
public static readonly long[] Value={ 2L,2L,7L,9L,5L,0L,7L,0L,5L,6L,9L,5L,4L,7L,7L,7L,6L,4L,1L,9L,9L,3L,5L,6L,3L,2L,5L,1L,9L,6L,3L,6L,3L,6L,0L,0L,6L,1L,9L,0L,3L,2L,0L,3L,4L,6L,6L,6L,1L,9L,3L,0L,9L,5L,5L,8L,3L,3L,8L,6L,5L,9L,6L,1L,1L,0L,0L,9L,6L,6L,6L,9L,9L,5L,1L,3L,1L,4L,1L,8L,1L,4L,7L,8L,3L,2L,3L,1L,8L,4L,2L,4L,9L,5L,1L,1L,1L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011022Inst : IEnumerable<long>
{
public static readonly long[] Value=A011022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011022.Bytes);
public long this[int i]=>Value[i];

public static A011022Inst Instance=new A011022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011023
{
public static readonly long[] Value={ 2L,3L,0L,0L,3L,2L,6L,6L,3L,3L,7L,9L,1L,2L,0L,6L,0L,0L,5L,0L,8L,5L,8L,9L,2L,6L,3L,5L,6L,6L,4L,3L,5L,0L,7L,3L,4L,8L,7L,3L,9L,4L,5L,5L,9L,2L,7L,4L,8L,9L,3L,0L,7L,3L,9L,1L,0L,6L,4L,3L,4L,3L,1L,2L,9L,8L,2L,7L,8L,2L,0L,9L,8L,5L,1L,3L,0L,5L,0L,6L,5L,3L,9L,8L,1L,0L,5L,9L,0L,8L,1L,9L,3L,2L,0L,0L,5L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011023Inst : IEnumerable<long>
{
public static readonly long[] Value=A011023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011023.Bytes);
public long this[int i]=>Value[i];

public static A011023Inst Instance=new A011023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011024
{
public static readonly long[] Value={ 2L,3L,2L,0L,5L,9L,5L,7L,8L,7L,1L,0L,6L,0L,8L,3L,6L,7L,5L,7L,9L,5L,1L,6L,2L,6L,7L,2L,4L,3L,6L,1L,7L,9L,0L,7L,4L,5L,6L,6L,4L,9L,5L,0L,0L,6L,6L,6L,1L,9L,9L,3L,2L,5L,7L,4L,0L,9L,3L,0L,2L,1L,4L,9L,9L,2L,2L,5L,3L,3L,1L,7L,6L,2L,4L,6L,4L,2L,0L,2L,1L,3L,0L,8L,0L,9L,9L,9L,1L,4L,7L,8L,8L,0L,7L,5L,6L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011024Inst : IEnumerable<long>
{
public static readonly long[] Value=A011024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011024.Bytes);
public long this[int i]=>Value[i];

public static A011024Inst Instance=new A011024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011025
{
public static readonly long[] Value={ 2L,3L,4L,0L,3L,4L,7L,3L,1L,9L,3L,2L,0L,7L,1L,5L,9L,3L,8L,4L,5L,9L,1L,4L,0L,9L,6L,8L,8L,1L,6L,6L,6L,6L,0L,1L,9L,4L,6L,3L,6L,0L,6L,1L,4L,8L,5L,8L,0L,3L,6L,2L,1L,5L,6L,6L,1L,6L,8L,2L,9L,6L,4L,4L,8L,9L,9L,4L,6L,8L,0L,5L,4L,0L,1L,1L,2L,3L,5L,7L,9L,7L,0L,8L,6L,2L,0L,4L,5L,4L,2L,9L,8L,9L,0L,8L,9L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011025Inst : IEnumerable<long>
{
public static readonly long[] Value=A011025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011025.Bytes);
public long this[int i]=>Value[i];

public static A011025Inst Instance=new A011025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011026
{
public static readonly long[] Value={ 2L,3L,5L,9L,6L,1L,1L,0L,6L,1L,7L,7L,0L,5L,6L,6L,8L,6L,6L,0L,0L,3L,8L,7L,5L,2L,8L,9L,4L,9L,9L,5L,6L,7L,9L,1L,7L,3L,7L,2L,8L,3L,0L,2L,9L,3L,4L,9L,5L,0L,2L,0L,0L,3L,7L,3L,2L,8L,1L,6L,3L,1L,3L,7L,4L,1L,6L,8L,5L,2L,3L,2L,6L,2L,8L,2L,7L,4L,3L,4L,5L,5L,0L,7L,6L,2L,9L,6L,1L,6L,6L,6L,0L,0L,1L,7L,3L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011026Inst : IEnumerable<long>
{
public static readonly long[] Value=A011026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011026.Bytes);
public long this[int i]=>Value[i];

public static A011026Inst Instance=new A011026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011027
{
public static readonly long[] Value={ 2L,3L,7L,8L,4L,1L,4L,2L,3L,0L,0L,0L,5L,4L,4L,2L,1L,3L,3L,4L,3L,4L,9L,9L,9L,9L,4L,1L,1L,2L,0L,9L,5L,1L,8L,3L,0L,5L,8L,5L,9L,4L,4L,1L,8L,4L,9L,2L,7L,6L,3L,4L,8L,2L,6L,0L,3L,8L,0L,0L,4L,4L,4L,9L,4L,3L,8L,9L,3L,3L,3L,3L,6L,4L,5L,3L,8L,3L,4L,3L,1L,9L,7L,4L,1L,5L,6L,2L,6L,8L,9L,0L,7L,6L,2L,7L,5L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011027Inst : IEnumerable<long>
{
public static readonly long[] Value=A011027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011027.Bytes);
public long this[int i]=>Value[i];

public static A011027Inst Instance=new A011027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011028
{
public static readonly long[] Value={ 2L,3L,9L,6L,7L,8L,1L,7L,2L,6L,9L,2L,8L,4L,3L,0L,3L,0L,6L,0L,8L,7L,1L,6L,9L,4L,5L,6L,9L,4L,8L,2L,4L,9L,0L,6L,0L,3L,3L,9L,3L,4L,6L,1L,7L,4L,8L,3L,1L,4L,4L,0L,7L,1L,1L,5L,5L,9L,9L,7L,0L,6L,5L,3L,4L,7L,9L,3L,1L,6L,8L,7L,2L,7L,9L,9L,3L,1L,1L,9L,7L,4L,1L,5L,2L,1L,8L,4L,0L,8L,6L,9L,0L,5L,2L,8L,0L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011028Inst : IEnumerable<long>
{
public static readonly long[] Value=A011028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011028.Bytes);
public long this[int i]=>Value[i];

public static A011028Inst Instance=new A011028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011029
{
public static readonly long[] Value={ 2L,4L,1L,4L,7L,3L,6L,4L,0L,2L,7L,6L,6L,4L,1L,7L,9L,9L,5L,6L,0L,8L,3L,5L,7L,9L,8L,7L,0L,4L,9L,8L,1L,1L,7L,4L,8L,7L,2L,7L,1L,3L,7L,7L,7L,9L,5L,9L,2L,9L,0L,4L,7L,2L,4L,1L,8L,8L,1L,2L,0L,9L,1L,1L,2L,9L,2L,4L,1L,2L,1L,3L,3L,7L,5L,1L,1L,7L,3L,5L,2L,1L,5L,4L,6L,9L,6L,9L,4L,4L,9L,0L,7L,9L,7L,7L,0L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011029Inst : IEnumerable<long>
{
public static readonly long[] Value=A011029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011029.Bytes);
public long this[int i]=>Value[i];

public static A011029Inst Instance=new A011029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011030
{
public static readonly long[] Value={ 2L,4L,3L,2L,2L,9L,9L,2L,7L,9L,0L,9L,7L,7L,8L,7L,3L,4L,9L,9L,5L,0L,0L,7L,2L,8L,8L,4L,4L,6L,2L,5L,3L,7L,1L,9L,1L,9L,6L,5L,3L,7L,1L,0L,3L,8L,8L,1L,8L,4L,0L,5L,8L,8L,8L,9L,8L,9L,1L,4L,8L,4L,4L,9L,4L,1L,0L,5L,6L,6L,9L,7L,4L,9L,4L,8L,8L,1L,5L,2L,5L,5L,9L,6L,7L,7L,2L,3L,4L,2L,1L,2L,9L,5L,6L,8L,4L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011030Inst : IEnumerable<long>
{
public static readonly long[] Value=A011030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011030.Bytes);
public long this[int i]=>Value[i];

public static A011030Inst Instance=new A011030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011031
{
public static readonly long[] Value={ 2L,4L,6L,6L,3L,2L,5L,7L,1L,4L,5L,5L,9L,6L,6L,0L,4L,4L,4L,8L,9L,0L,9L,5L,0L,9L,3L,4L,5L,5L,8L,2L,1L,8L,2L,7L,7L,1L,7L,7L,8L,5L,4L,0L,8L,3L,9L,7L,3L,5L,3L,7L,7L,4L,4L,9L,9L,1L,6L,3L,7L,1L,0L,2L,9L,2L,9L,1L,9L,7L,4L,1L,8L,7L,8L,5L,7L,5L,5L,8L,4L,6L,7L,2L,3L,3L,7L,0L,1L,4L,3L,1L,9L,7L,1L,1L,1L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011031Inst : IEnumerable<long>
{
public static readonly long[] Value=A011031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011031.Bytes);
public long this[int i]=>Value[i];

public static A011031Inst Instance=new A011031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011032
{
public static readonly long[] Value={ 2L,4L,8L,2L,8L,2L,3L,7L,9L,6L,1L,9L,8L,3L,8L,8L,3L,9L,0L,6L,2L,9L,6L,4L,1L,4L,4L,9L,5L,7L,7L,4L,4L,4L,1L,6L,1L,4L,7L,0L,6L,7L,2L,6L,8L,8L,3L,2L,4L,8L,4L,9L,5L,7L,6L,3L,8L,6L,0L,6L,5L,1L,0L,6L,6L,0L,6L,5L,0L,9L,4L,7L,1L,3L,5L,8L,4L,3L,6L,4L,4L,9L,8L,1L,4L,7L,5L,1L,2L,5L,5L,9L,4L,5L,8L,3L,6L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011032Inst : IEnumerable<long>
{
public static readonly long[] Value=A011032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011032.Bytes);
public long this[int i]=>Value[i];

public static A011032Inst Instance=new A011032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011033
{
public static readonly long[] Value={ 2L,4L,9L,8L,9L,9L,9L,3L,9L,9L,4L,3L,9L,3L,8L,3L,2L,5L,9L,8L,6L,2L,4L,4L,7L,7L,4L,4L,4L,0L,8L,6L,8L,9L,8L,6L,7L,3L,9L,9L,6L,3L,7L,0L,7L,8L,1L,9L,1L,9L,0L,2L,0L,9L,3L,0L,4L,0L,5L,9L,9L,5L,4L,5L,9L,3L,5L,6L,1L,7L,7L,7L,9L,7L,7L,7L,8L,3L,7L,4L,5L,8L,8L,7L,3L,7L,8L,4L,6L,7L,7L,6L,3L,7L,2L,1L,6L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011033Inst : IEnumerable<long>
{
public static readonly long[] Value=A011033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011033.Bytes);
public long this[int i]=>Value[i];

public static A011033Inst Instance=new A011033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011034
{
public static readonly long[] Value={ 2L,5L,1L,4L,8L,6L,6L,8L,5L,9L,3L,6L,5L,8L,7L,0L,8L,1L,6L,6L,3L,5L,5L,3L,1L,0L,0L,9L,3L,1L,7L,7L,1L,5L,6L,7L,6L,5L,5L,1L,9L,3L,6L,7L,2L,8L,0L,2L,9L,7L,7L,2L,1L,9L,7L,4L,7L,4L,5L,0L,6L,7L,0L,5L,6L,3L,5L,5L,5L,9L,2L,0L,8L,5L,6L,0L,9L,6L,4L,8L,4L,8L,6L,6L,0L,8L,7L,1L,8L,0L,4L,5L,6L,5L,3L,8L,5L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011034Inst : IEnumerable<long>
{
public static readonly long[] Value=A011034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011034.Bytes);
public long this[int i]=>Value[i];

public static A011034Inst Instance=new A011034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011035
{
public static readonly long[] Value={ 2L,5L,3L,0L,4L,3L,9L,5L,3L,4L,4L,3L,5L,2L,4L,2L,8L,7L,0L,0L,0L,3L,8L,6L,0L,2L,3L,0L,3L,0L,1L,9L,1L,4L,0L,4L,0L,7L,3L,4L,6L,8L,6L,2L,8L,5L,5L,4L,8L,2L,3L,0L,6L,7L,6L,5L,1L,6L,9L,0L,5L,6L,8L,6L,4L,0L,4L,9L,1L,2L,5L,2L,8L,2L,3L,2L,5L,3L,2L,4L,1L,3L,4L,5L,1L,6L,4L,7L,6L,3L,9L,6L,6L,7L,4L,7L,0L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011035Inst : IEnumerable<long>
{
public static readonly long[] Value=A011035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011035.Bytes);
public long this[int i]=>Value[i];

public static A011035Inst Instance=new A011035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011036
{
public static readonly long[] Value={ 2L,5L,4L,5L,7L,2L,9L,8L,9L,5L,0L,2L,1L,8L,3L,0L,5L,1L,8L,2L,6L,9L,7L,8L,8L,9L,6L,0L,5L,7L,6L,2L,8L,8L,6L,8L,5L,1L,9L,6L,9L,6L,0L,8L,3L,1L,3L,0L,1L,9L,2L,7L,0L,8L,9L,4L,3L,2L,0L,6L,0L,7L,9L,3L,6L,9L,3L,7L,3L,6L,0L,0L,0L,0L,4L,3L,1L,6L,3L,6L,2L,8L,0L,9L,1L,1L,6L,0L,7L,7L,5L,8L,5L,9L,6L,3L,2L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011036Inst : IEnumerable<long>
{
public static readonly long[] Value=A011036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011036.Bytes);
public long this[int i]=>Value[i];

public static A011036Inst Instance=new A011036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011037
{
public static readonly long[] Value={ 2L,5L,6L,0L,7L,4L,9L,6L,0L,2L,0L,3L,1L,0L,1L,4L,7L,9L,5L,0L,8L,5L,6L,0L,4L,7L,9L,7L,0L,8L,3L,5L,1L,4L,2L,1L,4L,7L,6L,7L,5L,1L,5L,2L,8L,0L,8L,8L,2L,7L,5L,7L,5L,4L,9L,6L,5L,1L,0L,8L,4L,1L,7L,8L,3L,2L,2L,2L,5L,6L,5L,3L,7L,0L,0L,4L,9L,5L,1L,7L,7L,5L,5L,3L,2L,5L,4L,1L,9L,7L,5L,9L,9L,0L,8L,8L,9L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011037Inst : IEnumerable<long>
{
public static readonly long[] Value=A011037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011037.Bytes);
public long this[int i]=>Value[i];

public static A011037Inst Instance=new A011037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011086
{
public static readonly long[] Value={ 3L,1L,2L,1L,9L,8L,5L,6L,4L,1L,3L,5L,2L,1L,4L,4L,9L,6L,1L,3L,4L,1L,0L,3L,2L,4L,9L,8L,0L,5L,7L,8L,1L,5L,8L,6L,3L,3L,9L,4L,5L,6L,1L,4L,0L,5L,3L,0L,1L,0L,6L,5L,9L,8L,0L,1L,4L,1L,3L,4L,8L,3L,0L,4L,5L,9L,6L,6L,6L,9L,5L,8L,6L,9L,9L,4L,5L,1L,5L,8L,0L,3L,6L,8L,0L,8L,6L,3L,2L,8L,3L,7L,9L,8L,5L,3L,9L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011086Inst : IEnumerable<long>
{
public static readonly long[] Value=A011086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011086.Bytes);
public long this[int i]=>Value[i];

public static A011086Inst Instance=new A011086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011087
{
public static readonly long[] Value={ 3L,1L,3L,0L,1L,6L,9L,1L,6L,0L,1L,4L,6L,5L,7L,4L,6L,3L,3L,1L,6L,8L,9L,7L,0L,9L,9L,8L,3L,1L,7L,3L,7L,9L,6L,1L,9L,6L,2L,1L,4L,5L,3L,8L,8L,5L,5L,4L,9L,5L,7L,8L,4L,4L,5L,6L,3L,9L,6L,1L,8L,1L,8L,4L,0L,2L,1L,6L,4L,6L,8L,8L,2L,1L,0L,5L,7L,6L,4L,0L,1L,7L,4L,8L,4L,0L,7L,0L,5L,4L,3L,8L,2L,0L,9L,1L,7L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011087Inst : IEnumerable<long>
{
public static readonly long[] Value=A011087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011087.Bytes);
public long this[int i]=>Value[i];

public static A011087Inst Instance=new A011087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011088
{
public static readonly long[] Value={ 3L,1L,3L,8L,2L,8L,8L,9L,9L,2L,7L,1L,4L,9L,9L,6L,0L,8L,0L,4L,5L,5L,7L,7L,2L,1L,2L,7L,2L,8L,7L,0L,1L,2L,3L,7L,3L,5L,1L,2L,0L,7L,2L,3L,8L,5L,2L,5L,1L,7L,9L,4L,6L,1L,6L,5L,0L,9L,9L,9L,8L,7L,5L,7L,5L,2L,3L,5L,3L,1L,9L,0L,5L,9L,5L,3L,8L,4L,6L,3L,3L,2L,3L,2L,3L,0L,2L,5L,0L,5L,2L,4L,4L,6L,6L,0L,6L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011088Inst : IEnumerable<long>
{
public static readonly long[] Value=A011088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011088.Bytes);
public long this[int i]=>Value[i];

public static A011088Inst Instance=new A011088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011089
{
public static readonly long[] Value={ 3L,1L,4L,6L,3L,4L,6L,2L,8L,3L,6L,4L,5L,7L,8L,8L,6L,2L,0L,6L,2L,1L,8L,9L,2L,6L,4L,2L,2L,8L,2L,8L,1L,3L,8L,1L,5L,6L,1L,8L,5L,6L,0L,2L,3L,8L,0L,6L,6L,2L,4L,4L,6L,2L,4L,0L,2L,2L,3L,9L,2L,8L,9L,0L,8L,2L,0L,3L,3L,7L,3L,9L,6L,0L,5L,3L,5L,4L,9L,5L,3L,5L,5L,4L,2L,0L,0L,5L,6L,3L,1L,0L,5L,6L,2L,1L,9L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011089Inst : IEnumerable<long>
{
public static readonly long[] Value=A011089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011089.Bytes);
public long this[int i]=>Value[i];

public static A011089Inst Instance=new A011089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011090
{
public static readonly long[] Value={ 3L,1L,5L,4L,3L,4L,2L,1L,4L,5L,5L,2L,9L,9L,0L,4L,2L,3L,4L,9L,2L,3L,1L,2L,6L,8L,4L,9L,2L,9L,4L,6L,8L,7L,9L,8L,0L,4L,9L,6L,2L,3L,6L,2L,9L,3L,3L,0L,9L,8L,3L,5L,7L,8L,9L,9L,5L,4L,1L,0L,1L,7L,5L,8L,1L,9L,9L,1L,8L,5L,5L,2L,6L,8L,7L,2L,4L,9L,1L,2L,1L,5L,0L,8L,2L,8L,2L,5L,4L,3L,8L,9L,2L,2L,8L,0L,2L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011090Inst : IEnumerable<long>
{
public static readonly long[] Value=A011090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011090.Bytes);
public long this[int i]=>Value[i];

public static A011090Inst Instance=new A011090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011091
{
public static readonly long[] Value={ 1L,4L,3L,0L,9L,6L,9L,0L,8L,1L,1L,0L,5L,2L,5L,5L,5L,0L,1L,0L,4L,5L,2L,2L,4L,4L,1L,3L,1L,4L,3L,1L,1L,6L,9L,0L,4L,9L,7L,2L,6L,4L,9L,9L,3L,9L,6L,6L,1L,2L,8L,1L,7L,3L,9L,9L,8L,8L,3L,6L,8L,5L,7L,9L,7L,5L,8L,2L,8L,2L,5L,0L,2L,7L,8L,3L,2L,3L,3L,4L,9L,9L,8L,5L,6L,0L,8L,8L,1L,6L,0L,4L,6L,8L,1L,3L,3L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011091Inst : IEnumerable<long>
{
public static readonly long[] Value=A011091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011091.Bytes);
public long this[int i]=>Value[i];

public static A011091Inst Instance=new A011091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011092
{
public static readonly long[] Value={ 1L,4L,7L,5L,7L,7L,3L,1L,6L,1L,5L,9L,4L,5L,5L,2L,0L,6L,9L,2L,7L,6L,9L,1L,6L,6L,9L,5L,6L,3L,2L,2L,4L,4L,1L,0L,6L,5L,4L,4L,0L,9L,3L,6L,1L,3L,7L,4L,0L,2L,0L,3L,5L,6L,7L,7L,7L,0L,9L,0L,4L,1L,6L,8L,8L,8L,4L,5L,2L,1L,7L,6L,7L,4L,9L,9L,2L,0L,8L,3L,6L,0L,7L,1L,4L,4L,1L,1L,0L,8L,2L,3L,5L,1L,2L,9L,8L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011092Inst : IEnumerable<long>
{
public static readonly long[] Value=A011092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011092.Bytes);
public long this[int i]=>Value[i];

public static A011092Inst Instance=new A011092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011093
{
public static readonly long[] Value={ 1L,5L,1L,5L,7L,1L,6L,5L,6L,6L,5L,1L,0L,3L,9L,8L,0L,8L,2L,3L,4L,7L,2L,5L,9L,8L,0L,1L,3L,0L,6L,4L,4L,5L,2L,3L,8L,6L,8L,1L,2L,8L,3L,5L,4L,2L,9L,7L,8L,1L,4L,1L,6L,4L,2L,0L,3L,7L,5L,0L,5L,2L,4L,2L,0L,9L,7L,4L,5L,3L,6L,7L,7L,2L,0L,2L,0L,5L,8L,2L,7L,7L,6L,4L,1L,1L,7L,6L,1L,3L,4L,8L,4L,9L,4L,3L,1L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011093Inst : IEnumerable<long>
{
public static readonly long[] Value=A011093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011093.Bytes);
public long this[int i]=>Value[i];

public static A011093Inst Instance=new A011093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011094
{
public static readonly long[] Value={ 1L,5L,5L,1L,8L,4L,5L,5L,7L,3L,9L,1L,5L,3L,5L,9L,6L,7L,4L,2L,7L,3L,3L,4L,5L,1L,3L,5L,5L,1L,6L,6L,9L,9L,3L,2L,3L,2L,6L,2L,3L,4L,6L,2L,9L,3L,8L,0L,9L,6L,6L,7L,8L,3L,7L,7L,3L,6L,3L,4L,0L,4L,9L,9L,7L,8L,2L,9L,0L,6L,3L,5L,7L,1L,7L,0L,7L,0L,8L,0L,7L,2L,4L,8L,2L,2L,6L,6L,8L,7L,3L,0L,9L,3L,2L,5L,9L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011094Inst : IEnumerable<long>
{
public static readonly long[] Value=A011094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011094.Bytes);
public long this[int i]=>Value[i];

public static A011094Inst Instance=new A011094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011095
{
public static readonly long[] Value={ 1L,5L,8L,4L,8L,9L,3L,1L,9L,2L,4L,6L,1L,1L,1L,3L,4L,8L,5L,2L,0L,2L,1L,0L,1L,3L,7L,3L,3L,9L,1L,5L,0L,7L,0L,1L,3L,2L,6L,9L,4L,4L,2L,1L,3L,3L,8L,2L,5L,0L,3L,9L,0L,6L,8L,3L,1L,6L,2L,9L,6L,8L,1L,2L,3L,1L,6L,6L,5L,6L,8L,6L,3L,6L,6L,8L,4L,5L,3L,9L,8L,0L,1L,1L,0L,2L,0L,2L,7L,2L,3L,8L,4L,6L,1L,1L,1L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011095Inst : IEnumerable<long>
{
public static readonly long[] Value=A011095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011095.Bytes);
public long this[int i]=>Value[i];

public static A011095Inst Instance=new A011095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011096
{
public static readonly long[] Value={ 1L,6L,1L,5L,3L,9L,4L,2L,6L,6L,2L,0L,2L,1L,7L,8L,0L,0L,1L,5L,0L,8L,1L,4L,7L,8L,8L,2L,0L,6L,3L,8L,3L,5L,8L,4L,5L,4L,1L,6L,5L,3L,5L,2L,0L,5L,4L,6L,9L,2L,9L,0L,7L,8L,7L,1L,0L,7L,6L,8L,6L,9L,0L,2L,1L,6L,9L,9L,6L,8L,2L,4L,6L,9L,2L,5L,7L,8L,4L,3L,3L,4L,6L,8L,1L,1L,4L,3L,6L,6L,9L,6L,5L,8L,6L,1L,6L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011096Inst : IEnumerable<long>
{
public static readonly long[] Value=A011096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011096.Bytes);
public long this[int i]=>Value[i];

public static A011096Inst Instance=new A011096Inst();

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