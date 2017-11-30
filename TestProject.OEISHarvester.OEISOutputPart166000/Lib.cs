using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A196457
{
public static readonly BigInteger[] Value={ 1L,3L,31L,729L,96895L,35927793L,81108563671L,567783612614529L,BigInteger.Parse("19581520178825073535"),BigInteger.Parse("2420011073132910603900513"),BigInteger.Parse("1292280969200128366004695992151"),BigInteger.Parse("2658679109878459106807828064662797809") };
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
public class A196457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196457Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196457.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196457.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196457Inst Instance=new A196457Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196458
{
public static readonly BigInteger[] Value={ 1L,4L,112L,20608L,47100160L,848654393344L,152543949079048192L,BigInteger.Parse("239308785705492230176768"),BigInteger.Parse("3442046584639832610980531077120"),BigInteger.Parse("443426848780270385458655031044167696384"),BigInteger.Parse("515552048984399455145742768443316759297510080512") };
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
public class A196458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196458Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196458.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196458.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196458Inst Instance=new A196458Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196459
{
public static readonly BigInteger[] Value={ 1L,12L,378L,66324L,106198818L,1683766925772L,254853525616593498L,BigInteger.Parse("359442643592845468030044"),BigInteger.Parse("4678184388343291088594901552738"),BigInteger.Parse("559325487076698590861626663741490993292"),BigInteger.Parse("612293179823760898820162678475549198446848819338") };
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
public class A196459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196459Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196459.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196459.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196459Inst Instance=new A196459Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196460
{
public static readonly BigInteger[] Value={ 1L,5L,47L,1193L,113855L,46857665L,83540629607L,629692415941433L,BigInteger.Parse("19653639560140008575"),BigInteger.Parse("2505063418700072099312705"),BigInteger.Parse("1292764583816731772891346438887"),BigInteger.Parse("2687238342732260436646020885678131993"),BigInteger.Parse("22431974111110989403331425804893720873764255") };
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
public class A196460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196460Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196460.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196460.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196460Inst Instance=new A196460Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196461
{
public static readonly long[] Value={ 1L,13L,14L,7L,45L,36L,10L,4L,21L,2L,17L,38L,200L,76L,234L,396L,84L,138L,690L,371L,278L,11L,164L,142L,967L,15L,514L,1214L,1612L,248L,1589L,2193L,53L,1159L,648L,2268L,288L,686L,809L,458L,803L,1235L,573L,707L,5455L,830L,1974L,1728L,3091L,2847L,441L,339L,741L,1778L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196461Inst : IEnumerable<long>
{
public static readonly long[] Value=A196461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196461.Bytes);
public long this[int i]=>Value[i];

public static A196461Inst Instance=new A196461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196462
{
public static readonly long[] Value={ 1L,6L,9L,6L,1L,0L,7L,1L,3L,6L,3L,6L,7L,3L,4L,8L,2L,1L,7L,3L,3L,3L,1L,9L,8L,7L,1L,3L,9L,9L,3L,4L,0L,9L,4L,4L,0L,6L,4L,0L,2L,3L,1L,1L,9L,6L,0L,5L,7L,7L,2L,1L,7L,9L,4L,9L,0L,5L,1L,4L,3L,5L,7L,7L,6L,8L,8L,8L,0L,9L,3L,8L,6L,5L,4L,4L,8L,2L,0L,7L,3L,2L,3L,4L,2L,0L,0L,1L,8L,6L,7L,5L,9L,0L,8L,5L,9L,0L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196462Inst : IEnumerable<long>
{
public static readonly long[] Value=A196462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196462.Bytes);
public long this[int i]=>Value[i];

public static A196462Inst Instance=new A196462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196463
{
public static readonly long[] Value={ 1L,4L,4L,7L,1L,5L,9L,3L,6L,6L,5L,1L,7L,2L,5L,9L,5L,1L,9L,2L,9L,1L,0L,9L,5L,3L,4L,3L,1L,9L,4L,4L,9L,2L,0L,1L,9L,9L,7L,3L,1L,8L,2L,8L,6L,8L,8L,5L,8L,0L,0L,7L,9L,6L,8L,0L,1L,7L,0L,0L,2L,6L,0L,6L,2L,0L,8L,4L,3L,4L,7L,2L,3L,4L,2L,4L,5L,5L,5L,0L,4L,8L,6L,5L,3L,9L,5L,0L,5L,9L,4L,2L,2L,3L,8L,1L,2L,2L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196463Inst : IEnumerable<long>
{
public static readonly long[] Value=A196463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196463.Bytes);
public long this[int i]=>Value[i];

public static A196463Inst Instance=new A196463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196464
{
public static readonly BigInteger[] Value={ 30L,1530L,1088250L,975996780L,1073087762700L,1329027103924410L,1781966623841748930L,BigInteger.Parse("2528247216911976589500"),BigInteger.Parse("3742056692258356444651980"),BigInteger.Parse("5723452081398475208950800270"),BigInteger.Parse("8986460098015260183028517362890"),BigInteger.Parse("14415044640432226873354788580437780"),BigInteger.Parse("23538467987973866346057268850924917500"),BigInteger.Parse("39018964507836157678862657579522297754750"),BigInteger.Parse("65519043282275380577599387116954298241167170") };
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
public class A196464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196464Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196464.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196464.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196464Inst Instance=new A196464Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196465
{
public static readonly BigInteger[] Value={ 15L,765L,544125L,487998390L,536543881350L,664513551962205L,890983311920874465L,BigInteger.Parse("1264123608455988294750"),BigInteger.Parse("1871028346129178222325990"),BigInteger.Parse("2861726040699237604475400135"),BigInteger.Parse("4493230049007630091514258681445"),BigInteger.Parse("7207522320216113436677394290218890"),BigInteger.Parse("11769233993986933173028634425462458750"),BigInteger.Parse("19509482253918078839431328789761148877375"),BigInteger.Parse("32759521641137690288799693558477149120583585") };
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
public class A196465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196465Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196465.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196465.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196465Inst Instance=new A196465Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196466
{
public static readonly BigInteger[] Value={ 30L,4600L,5441256L,47823842250L,28973369597500L,160812279574853640L,BigInteger.Parse("301152359429255569200"),BigInteger.Parse("2528247216911976710478"),BigInteger.Parse("1081454384062665012504422250"),BigInteger.Parse("2066166201384849550431238897500"),BigInteger.Parse("440336544802747748968402664543390"),BigInteger.Parse("7625558614788648016004683159051585650"),BigInteger.Parse("2942308498496733293257158606365620128756"),BigInteger.Parse("9481608375404186315963625791852891724001750"),BigInteger.Parse("55101515400393595065761084565358564820821590000") };
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
public class A196466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196466Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196466.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196466.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196466Inst Instance=new A196466Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196467
{
public static readonly long[] Value={ 1L,3L,5L,49L,27L,121L,169L,1L,289L,361L,49L,529L,125L,243L,841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196467Inst : IEnumerable<long>
{
public static readonly long[] Value=A196467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196467.Bytes);
public long this[int i]=>Value[i];

public static A196467Inst Instance=new A196467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196468
{
public static readonly long[] Value={ 11L,53L,255L,1231L,5943L,28695L,138551L,668983L,3230135L,15596471L,75306423L,363611575L,1755671991L,8477134263L,40931225015L,197633437111L,954258648503L,4607568342455L,22247307963831L,107419505225143L,518667252755895L,2504347031924151L,12092057138720183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196468Inst : IEnumerable<long>
{
public static readonly long[] Value=A196468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196468.Bytes);
public long this[int i]=>Value[i];

public static A196468Inst Instance=new A196468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196469
{
public static readonly long[] Value={ 0L,1L,1L,3L,10L,38L,143L,577L,2325L,9697L,40853L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196469Inst : IEnumerable<long>
{
public static readonly long[] Value=A196469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196469.Bytes);
public long this[int i]=>Value[i];

public static A196469Inst Instance=new A196469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196470
{
public static readonly long[] Value={ 0L,1L,2L,7L,24L,91L,341L,1370L,5504L,22914L,96457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196470Inst : IEnumerable<long>
{
public static readonly long[] Value=A196470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196470.Bytes);
public long this[int i]=>Value[i];

public static A196470Inst Instance=new A196470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196471
{
public static readonly long[] Value={ 0L,1L,1L,5L,30L,196L,1267L,8615L,58613L,411209L,2909597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196471Inst : IEnumerable<long>
{
public static readonly long[] Value=A196471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196471.Bytes);
public long this[int i]=>Value[i];

public static A196471Inst Instance=new A196471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196472
{
public static readonly long[] Value={ 1L,3L,11L,41L,155L,587L,2225L,8435L,31979L,121241L,459659L,1742699L,6607073L,25049315L,94969163L,360055433L,1365073787L,5175387659L,19621384337L,74390315987L,282035100971L,1069276250873L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196472Inst : IEnumerable<long>
{
public static readonly long[] Value=A196472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196472.Bytes);
public long this[int i]=>Value[i];

public static A196472Inst Instance=new A196472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196473
{
public static readonly long[] Value={ 1L,5L,7L,35L,151L,5955L,299659L,8943355L,528624118L,48720477449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196473Inst : IEnumerable<long>
{
public static readonly long[] Value=A196473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196473.Bytes);
public long this[int i]=>Value[i];

public static A196473Inst Instance=new A196473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196474
{
public static readonly long[] Value={ 8L,18L,17L,70L,151L,557L,2351L,6926L,16083L,43523L,126887L,366749L,1196290L,3904083L,12242778L,35866180L,101052064L,296050389L,899499517L,2807496039L,8933240984L,27433666911L,81672960692L,242780272113L,727008678986L,2224880992862L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196474Inst : IEnumerable<long>
{
public static readonly long[] Value=A196474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196474.Bytes);
public long this[int i]=>Value[i];

public static A196474Inst Instance=new A196474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196475
{
public static readonly long[] Value={ 12L,28L,27L,136L,557L,5955L,38826L,128960L,351238L,1374515L,5837922L,30814351L,167525199L,704218824L,2677605502L,10721905782L,44470299831L,200591500952L,939099305213L,4163383808755L,17808261939750L,75069877372742L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196475Inst : IEnumerable<long>
{
public static readonly long[] Value=A196475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196475.Bytes);
public long this[int i]=>Value[i];

public static A196475Inst Instance=new A196475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196476
{
public static readonly long[] Value={ 17L,43L,42L,305L,2351L,38826L,299659L,1231691L,5238322L,26129353L,141788701L,1086218484L,7344638998L,38637965991L,209973350431L,1159411392373L,6436583617125L,39481503993996L,240320932969724L,1381481638118489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196476Inst : IEnumerable<long>
{
public static readonly long[] Value=A196476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196476.Bytes);
public long this[int i]=>Value[i];

public static A196476Inst Instance=new A196476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196477
{
public static readonly long[] Value={ 1L,3L,3L,4L,5L,4L,5L,8L,8L,5L,8L,11L,7L,11L,8L,12L,18L,14L,14L,18L,12L,17L,28L,17L,35L,17L,28L,17L,25L,43L,27L,70L,70L,27L,43L,25L,37L,67L,42L,136L,151L,136L,42L,67L,37L,54L,105L,58L,305L,557L,557L,305L,58L,105L,54L,79L,164L,94L,611L,2351L,5955L,2351L,611L,94L,164L,79L,116L,257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196477Inst : IEnumerable<long>
{
public static readonly long[] Value=A196477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196477.Bytes);
public long this[int i]=>Value[i];

public static A196477Inst Instance=new A196477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196478
{
public static readonly long[] Value={ 1L,6L,40L,826L,40221L,5627727L,1740363958L,1318320614894L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196478Inst : IEnumerable<long>
{
public static readonly long[] Value=A196478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196478.Bytes);
public long this[int i]=>Value[i];

public static A196478Inst Instance=new A196478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196479
{
public static readonly long[] Value={ 3L,6L,14L,36L,83L,192L,468L,1112L,2624L,6267L,14941L,35493L,84487L,201229L,478826L,1139543L,2712764L,6456865L,15367802L,36579318L,87067091L,207234557L,493260338L,1174064036L,2794503372L,6651474771L,15831865426L,37683024434L,89693152856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196479Inst : IEnumerable<long>
{
public static readonly long[] Value=A196479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196479.Bytes);
public long this[int i]=>Value[i];

public static A196479Inst Instance=new A196479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196480
{
public static readonly long[] Value={ 4L,14L,40L,147L,457L,1554L,5370L,17678L,58836L,199055L,666719L,2226571L,7472355L,25062544L,83919602L,281223942L,942759343L,3159073709L,10585785571L,35477873281L,118895583561L,398433388350L,1335248565663L,4474760498199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196480Inst : IEnumerable<long>
{
public static readonly long[] Value=A196480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196480.Bytes);
public long this[int i]=>Value[i];

public static A196480Inst Instance=new A196480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196481
{
public static readonly long[] Value={ 5L,36L,147L,826L,4344L,23930L,131650L,705342L,3801448L,20598890L,111440744L,603129471L,3265314697L,17669434957L,95611160941L,517439229137L,2800320468761L,15154923134842L,82016941366524L,443863716501084L,2402118373132479L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196481Inst : IEnumerable<long>
{
public static readonly long[] Value=A196481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196481.Bytes);
public long this[int i]=>Value[i];

public static A196481Inst Instance=new A196481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196482
{
public static readonly long[] Value={ 8L,83L,457L,4344L,40221L,374645L,3307716L,28430880L,248312071L,2192473876L,19348789798L,170510755795L,1500864452926L,13204967160428L,116225998484492L,1023302267971920L,9009586965300230L,79318454402499047L,698273303070427478L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196482Inst : IEnumerable<long>
{
public static readonly long[] Value=A196482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196482.Bytes);
public long this[int i]=>Value[i];

public static A196482Inst Instance=new A196482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196483
{
public static readonly long[] Value={ 12L,192L,1554L,23930L,374645L,5627727L,78510820L,1084830372L,15273876227L,215684786758L,3040422731042L,42895265549152L,605251738703146L,8536098569421046L,120369552083787125L,1697424555170278400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196483Inst : IEnumerable<long>
{
public static readonly long[] Value=A196483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196483.Bytes);
public long this[int i]=>Value[i];

public static A196483Inst Instance=new A196483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196484
{
public static readonly BigInteger[] Value={ 17L,468L,5370L,131650L,3307716L,78510820L,1740363958L,38249638826L,844387380911L,18649094172670L,413597303215047L,9198603912775814L,204434933733971755L,4539111860110138352L,BigInteger.Parse("100762741109236752675"),BigInteger.Parse("2236881797334686400439") };
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
public class A196484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196484Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196484.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196484.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196484Inst Instance=new A196484Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196485
{
public static readonly long[] Value={ 1L,3L,3L,4L,6L,4L,5L,14L,14L,5L,8L,36L,40L,36L,8L,12L,83L,147L,147L,83L,12L,17L,192L,457L,826L,457L,192L,17L,25L,468L,1554L,4344L,4344L,1554L,468L,25L,37L,1112L,5370L,23930L,40221L,23930L,5370L,1112L,37L,54L,2624L,17678L,131650L,374645L,374645L,131650L,17678L,2624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196485Inst : IEnumerable<long>
{
public static readonly long[] Value=A196485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196485.Bytes);
public long this[int i]=>Value[i];

public static A196485Inst Instance=new A196485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196486
{
public static readonly long[] Value={ 1L,7L,5L,1L,25L,23L,19L,11L,79L,77L,73L,65L,49L,17L,241L,239L,235L,227L,211L,179L,115L,727L,725L,721L,713L,697L,665L,601L,473L,217L,2185L,2183L,2179L,2171L,2155L,2123L,2059L,1931L,1675L,1163L,139L,6559L,6557L,6553L,6545L,6529L,6497L,6433L,6305L,6049L,5537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196486Inst : IEnumerable<long>
{
public static readonly long[] Value=A196486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196486.Bytes);
public long this[int i]=>Value[i];

public static A196486Inst Instance=new A196486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196487
{
public static readonly BigInteger[] Value={ 1L,1L,9L,99L,2862L,188603L,28338246L,10179007465L,8440119388684L,16385876855589022L,BigInteger.Parse("74005549246712939357"),BigInteger.Parse("780142920501811666245635") };
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
public class A196487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196487Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196487.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196487.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196487Inst Instance=new A196487Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196488
{
public static readonly long[] Value={ 1L,3L,9L,23L,69L,199L,553L,1563L,4439L,12591L,35645L,100885L,285753L,809481L,2292615L,6492777L,18388691L,52081399L,147506079L,417765845L,1183196095L,3351057703L,9490892585L,26880156625L,76130113051L,215616141961L,610669320471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196488Inst : IEnumerable<long>
{
public static readonly long[] Value=A196488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196488.Bytes);
public long this[int i]=>Value[i];

public static A196488Inst Instance=new A196488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196489
{
public static readonly long[] Value={ 1L,5L,23L,99L,435L,1821L,7761L,33445L,142899L,610111L,2610127L,11166323L,47747117L,204171367L,873175939L,3734216551L,15969151905L,68291795495L,292051077171L,1248957218645L,5341159082973L,22841464889713L,97681553556621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196489Inst : IEnumerable<long>
{
public static readonly long[] Value=A196489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196489.Bytes);
public long this[int i]=>Value[i];

public static A196489Inst Instance=new A196489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196490
{
public static readonly long[] Value={ 1L,9L,69L,435L,2862L,18661L,123151L,806609L,5276054L,34627688L,227088449L,1488439691L,9758458572L,63980053571L,419459699173L,2750044671305L,18029789774081L,118205954690054L,774976155585421L,5080869712707658L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196490Inst : IEnumerable<long>
{
public static readonly long[] Value=A196490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196490.Bytes);
public long this[int i]=>Value[i];

public static A196490Inst Instance=new A196490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196491
{
public static readonly long[] Value={ 1L,17L,199L,1821L,18661L,188603L,1875863L,18685389L,187248247L,1876363069L,18755173019L,187535974669L,1876305125439L,18771074346899L,187768965127635L,1878237376211187L,18788431542792943L,187947977420652363L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196491Inst : IEnumerable<long>
{
public static readonly long[] Value=A196491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196491.Bytes);
public long this[int i]=>Value[i];

public static A196491Inst Instance=new A196491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196492
{
public static readonly BigInteger[] Value={ 1L,31L,553L,7761L,123151L,1875863L,28338246L,434666223L,6656162368L,101518856651L,1549818281847L,23688276304457L,361894920969682L,5527193051141256L,84429912619066523L,1289786041484393709L,BigInteger.Parse("19702421130556030141") };
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
public class A196492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196492Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196492.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196492.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196492Inst Instance=new A196492Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196493
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,3L,3L,1L,1L,5L,9L,5L,1L,1L,9L,23L,23L,9L,1L,1L,17L,69L,99L,69L,17L,1L,1L,31L,199L,435L,435L,199L,31L,1L,1L,57L,553L,1821L,2862L,1821L,553L,57L,1L,1L,105L,1563L,7761L,18661L,18661L,7761L,1563L,105L,1L,1L,193L,4439L,33445L,123151L,188603L,123151L,33445L,4439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196493Inst : IEnumerable<long>
{
public static readonly long[] Value=A196493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196493.Bytes);
public long this[int i]=>Value[i];

public static A196493Inst Instance=new A196493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196494
{
public static readonly long[] Value={ 1L,4156L,524962L,321895111L,358542860L,362349816L,422820435L,560670367L,565390537L,4192653610L,593651537079L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196494Inst : IEnumerable<long>
{
public static readonly long[] Value=A196494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196494.Bytes);
public long this[int i]=>Value[i];

public static A196494Inst Instance=new A196494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196495
{
public static readonly long[] Value={ 15151L,181L,141L,919L,22L,121L,55L,11L,111L,121L,131L,141L,151L,161L,171L,55L,191L,121L,22L,189949981L,484L,505L,151L,11311L,757L,16661L,88L,181L,72727L,33L,1111111L,10201L,10501L,757L,2636362L,17671L,51715L,121L,616L,36163L,44L,1856581L,676L,12256565221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196495Inst : IEnumerable<long>
{
public static readonly long[] Value=A196495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196495.Bytes);
public long this[int i]=>Value[i];

public static A196495Inst Instance=new A196495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196496
{
public static readonly long[] Value={ 1L,2636362L,106515601L,3066863686603L,148749979947841L,219339595933912L,853637858736358L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196496Inst : IEnumerable<long>
{
public static readonly long[] Value=A196496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196496.Bytes);
public long this[int i]=>Value[i];

public static A196496Inst Instance=new A196496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196497
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,30L,170L,1242L,9534L,86118L,797778L,8327410L,88438966L,1032534190L,12233231738L,156832510922L,2038914853870L,28368720701302L,400233587440290L,5994141844357346L,91033137985948774L,1458360235236325182L,BigInteger.Parse("23691777860254217802"),BigInteger.Parse("403933868741833240506") };
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
public class A196497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196497Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196497.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196497.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196497Inst Instance=new A196497Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196498
{
public static readonly long[] Value={ 9L,9L,9L,9L,9L,9L,7L,2L,4L,4L,2L,6L,8L,0L,7L,7L,6L,0L,5L,5L,2L,1L,2L,5L,2L,3L,6L,7L,5L,8L,0L,2L,0L,4L,7L,6L,0L,0L,1L,2L,6L,3L,7L,2L,0L,3L,6L,6L,0L,0L,3L,5L,6L,2L,1L,1L,9L,7L,3L,3L,1L,6L,3L,7L,2L,8L,9L,9L,3L,3L,6L,5L,8L,4L,7L,2L,1L,1L,6L,8L,9L,6L,7L,4L,0L,0L,2L,7L,4L,8L,2L,1L,1L,9L,7L,3L,8L,4L,2L,5L,9L,3L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196498Inst : IEnumerable<long>
{
public static readonly long[] Value=A196498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196498.Bytes);
public long this[int i]=>Value[i];

public static A196498Inst Instance=new A196498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196499
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,9L,10L,11L,13L,15L,17L,19L,21L,23L,25L,26L,27L,29L,31L,33L,34L,35L,37L,39L,41L,43L,45L,47L,49L,50L,51L,53L,55L,57L,58L,59L,61L,63L,65L,67L,69L,71L,73L,74L,75L,77L,79L,81L,82L,83L,85L,87L,89L,91L,93L,95L,97L,99L,101L,103L,105L,106L,107L,109L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196499Inst : IEnumerable<long>
{
public static readonly long[] Value=A196499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196499.Bytes);
public long this[int i]=>Value[i];

public static A196499Inst Instance=new A196499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196500
{
public static readonly long[] Value={ 3L,6L,4L,4L,7L,0L,3L,6L,8L,5L,9L,1L,0L,4L,0L,5L,3L,8L,0L,0L,4L,4L,0L,0L,2L,1L,4L,6L,3L,7L,8L,1L,6L,0L,8L,4L,9L,1L,2L,4L,1L,0L,3L,6L,4L,1L,3L,0L,3L,0L,2L,5L,8L,1L,7L,2L,1L,0L,1L,5L,4L,1L,0L,7L,7L,8L,0L,5L,3L,6L,0L,0L,5L,4L,7L,1L,6L,8L,2L,3L,2L,2L,3L,8L,5L,7L,5L,3L,1L,0L,4L,5L,2L,4L,5L,1L,7L,2L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196500Inst : IEnumerable<long>
{
public static readonly long[] Value=A196500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196500.Bytes);
public long this[int i]=>Value[i];

public static A196500Inst Instance=new A196500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196501
{
public static readonly long[] Value={ 2L,7L,4L,3L,7L,0L,7L,2L,6L,9L,9L,9L,2L,2L,6L,9L,3L,8L,2L,5L,6L,1L,1L,2L,2L,0L,8L,1L,1L,2L,0L,3L,0L,7L,1L,3L,7L,2L,0L,4L,2L,7L,9L,6L,7L,5L,5L,5L,8L,2L,8L,9L,3L,1L,4L,1L,6L,6L,3L,9L,0L,5L,7L,1L,3L,4L,9L,9L,2L,7L,6L,7L,3L,1L,1L,1L,9L,1L,7L,6L,8L,9L,9L,0L,1L,2L,6L,0L,8L,6L,7L,8L,7L,3L,2L,6L,1L,3L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196501Inst : IEnumerable<long>
{
public static readonly long[] Value=A196501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196501.Bytes);
public long this[int i]=>Value[i];

public static A196501Inst Instance=new A196501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196502
{
public static readonly long[] Value={ 4L,9L,1L,3L,1L,8L,0L,4L,3L,9L,4L,3L,4L,8L,8L,3L,6L,8L,8L,8L,3L,7L,8L,2L,0L,6L,6L,8L,5L,9L,4L,5L,3L,5L,5L,6L,6L,8L,4L,7L,6L,1L,1L,8L,4L,5L,0L,6L,6L,1L,5L,5L,0L,5L,6L,1L,4L,2L,1L,8L,5L,2L,0L,5L,5L,1L,2L,7L,3L,3L,9L,7L,8L,7L,6L,1L,0L,9L,6L,1L,7L,0L,3L,6L,7L,9L,9L,7L,6L,6L,3L,4L,6L,8L,3L,8L,2L,6L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196502Inst : IEnumerable<long>
{
public static readonly long[] Value=A196502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196502.Bytes);
public long this[int i]=>Value[i];

public static A196502Inst Instance=new A196502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196503
{
public static readonly long[] Value={ 2L,0L,3L,5L,3L,4L,1L,4L,9L,0L,7L,6L,5L,6L,4L,4L,3L,9L,6L,9L,7L,5L,7L,4L,2L,2L,2L,3L,9L,7L,3L,9L,5L,2L,9L,0L,2L,8L,9L,9L,9L,6L,9L,4L,1L,3L,1L,7L,8L,0L,3L,3L,8L,0L,9L,8L,1L,7L,6L,3L,5L,9L,4L,1L,3L,1L,0L,1L,4L,6L,0L,9L,4L,3L,1L,2L,7L,3L,6L,8L,5L,8L,3L,7L,8L,4L,9L,4L,3L,1L,4L,3L,2L,4L,1L,7L,7L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196503Inst : IEnumerable<long>
{
public static readonly long[] Value=A196503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196503.Bytes);
public long this[int i]=>Value[i];

public static A196503Inst Instance=new A196503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196504
{
public static readonly long[] Value={ 2L,0L,2L,8L,7L,5L,7L,8L,3L,8L,1L,1L,0L,4L,3L,4L,2L,2L,3L,5L,7L,6L,9L,7L,1L,1L,2L,4L,7L,3L,4L,7L,1L,4L,3L,7L,6L,1L,0L,8L,3L,8L,0L,0L,2L,8L,7L,5L,9L,3L,9L,4L,0L,8L,8L,8L,1L,7L,1L,6L,6L,0L,7L,4L,4L,4L,9L,8L,6L,6L,5L,0L,3L,1L,0L,4L,2L,7L,6L,2L,3L,4L,5L,9L,2L,2L,7L,9L,5L,1L,5L,0L,4L,2L,5L,6L,3L,0L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196504Inst : IEnumerable<long>
{
public static readonly long[] Value=A196504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196504.Bytes);
public long this[int i]=>Value[i];

public static A196504Inst Instance=new A196504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196505
{
public static readonly long[] Value={ 4L,9L,2L,9L,1L,2L,4L,5L,1L,7L,5L,4L,9L,0L,7L,5L,7L,4L,1L,8L,7L,7L,8L,0L,1L,8L,9L,8L,2L,2L,2L,3L,2L,9L,7L,6L,9L,1L,5L,6L,9L,7L,0L,1L,3L,2L,5L,7L,1L,1L,5L,0L,0L,7L,0L,2L,5L,9L,2L,6L,5L,3L,6L,0L,0L,4L,0L,4L,4L,9L,2L,5L,9L,1L,0L,6L,8L,6L,4L,1L,8L,3L,4L,8L,9L,2L,0L,2L,5L,0L,0L,7L,1L,0L,6L,4L,7L,4L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196505Inst : IEnumerable<long>
{
public static readonly long[] Value=A196505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196505.Bytes);
public long this[int i]=>Value[i];

public static A196505Inst Instance=new A196505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196506
{
public static readonly long[] Value={ 0L,15L,120L,435L,1128L,2415L,4560L,7875L,12720L,19503L,28680L,40755L,56280L,75855L,100128L,129795L,165600L,208335L,258840L,318003L,386760L,466095L,557040L,660675L,778128L,910575L,1059240L,1225395L,1410360L,1615503L,1842240L,2092035L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196506Inst : IEnumerable<long>
{
public static readonly long[] Value=A196506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196506.Bytes);
public long this[int i]=>Value[i];

public static A196506Inst Instance=new A196506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196507
{
public static readonly long[] Value={ 0L,10L,50L,138L,292L,530L,870L,1330L,1928L,2682L,3610L,4730L,6060L,7618L,9422L,11490L,13840L,16490L,19458L,22762L,26420L,30450L,34870L,39698L,44952L,50650L,56810L,63450L,70588L,78242L,86430L,95170L,104480L,114378L,124882L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196507Inst : IEnumerable<long>
{
public static readonly long[] Value=A196507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196507.Bytes);
public long this[int i]=>Value[i];

public static A196507Inst Instance=new A196507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196508
{
public static readonly long[] Value={ 0L,4L,20L,76L,252L,764L,2172L,5884L,15356L,38908L,96252L,233468L,557052L,1310716L,3047420L,7012348L,15990780L,36175868L,81264636L,181403644L,402653180L,889192444L,1954545660L,4278190076L,9328132092L,20266876924L,43889197052L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196508Inst : IEnumerable<long>
{
public static readonly long[] Value=A196508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196508.Bytes);
public long this[int i]=>Value[i];

public static A196508Inst Instance=new A196508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196509
{
public static readonly long[] Value={ 9L,11L,343L,747L,6556L,65856L,405504L,4251524L,8847488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196509Inst : IEnumerable<long>
{
public static readonly long[] Value=A196509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196509.Bytes);
public long this[int i]=>Value[i];

public static A196509Inst Instance=new A196509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196510
{
public static readonly long[] Value={ 6643L,4L,10L,26L,28L,8L,121L,10L,121L,244L,13L,28L,1210L,16L,68L,784L,1733L,20L,1604L,242L,23L,2096L,100L,26L,937L,28L,203L,3280L,1952L,160L,1249L,68L,280L,1366L,14483L,608L,11293L,40L,82L,5948L,7102L,484L,2069L,644L,1222L,4372L,784L,100L,6452L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196510Inst : IEnumerable<long>
{
public static readonly long[] Value=A196510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196510.Bytes);
public long this[int i]=>Value[i];

public static A196510Inst Instance=new A196510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196511
{
public static readonly long[] Value={ 555383L,1767407L,2103107L,2452757L,7400567L,12836987L,14668163L,15404867L,16238303L,19572647L,22796069L,25003799L,26978663L,27370727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196511Inst : IEnumerable<long>
{
public static readonly long[] Value=A196511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196511.Bytes);
public long this[int i]=>Value[i];

public static A196511Inst Instance=new A196511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196512
{
public static readonly BigInteger[] Value={ 1L,19L,532L,14896L,417088L,11678464L,326996992L,9155915776L,256365641728L,7178237968384L,200990663114752L,5627738567213056L,157576679881965568L,4412147036695035904L,BigInteger.Parse("123540117027461005312") };
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
public class A196512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196512Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196512.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196512.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196512Inst Instance=new A196512Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196513
{
public static readonly long[] Value={ 0L,28L,308L,1218L,3298L,7250L,13938L,24388L,39788L,61488L,91000L,129998L,180318L,243958L,323078L,420000L,537208L,677348L,843228L,1037818L,1264250L,1525818L,1825978L,2168348L,2556708L,2995000L,3487328L,4037958L,4651318L,5331998L,6084750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196513Inst : IEnumerable<long>
{
public static readonly long[] Value=A196513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196513.Bytes);
public long this[int i]=>Value[i];

public static A196513Inst Instance=new A196513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196514
{
public static readonly long[] Value={ 0L,4L,28L,124L,444L,1404L,4092L,11260L,29692L,75772L,188412L,458748L,1097724L,2588668L,6029308L,13893628L,31719420L,71827452L,161480700L,360710140L,801112060L,1769996284L,3892314108L,8522825724L,18589155324L,40399536124L,87509958652L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196514Inst : IEnumerable<long>
{
public static readonly long[] Value=A196514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196514.Bytes);
public long this[int i]=>Value[i];

public static A196514Inst Instance=new A196514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196515
{
public static readonly long[] Value={ 8L,5L,2L,6L,0L,5L,5L,0L,2L,0L,1L,3L,7L,2L,5L,4L,9L,1L,3L,4L,6L,4L,7L,2L,4L,1L,4L,6L,9L,5L,3L,1L,7L,4L,6L,6L,8L,9L,8L,4L,5L,3L,3L,0L,0L,1L,5L,1L,4L,0L,3L,5L,0L,8L,7L,7L,2L,1L,0L,7L,3L,9L,4L,6L,5L,2L,5L,1L,5L,0L,6L,5L,6L,7L,4L,2L,6L,3L,0L,4L,4L,8L,9L,6L,5L,7L,7L,3L,7L,8L,3L,5L,0L,2L,4L,9L,4L,8L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196515Inst : IEnumerable<long>
{
public static readonly long[] Value=A196515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196515.Bytes);
public long this[int i]=>Value[i];

public static A196515Inst Instance=new A196515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196516
{
public static readonly long[] Value={ 1L,0L,4L,9L,9L,0L,8L,8L,9L,4L,9L,6L,4L,0L,3L,9L,9L,5L,9L,9L,8L,8L,6L,9L,7L,0L,7L,0L,5L,5L,2L,8L,9L,7L,9L,0L,4L,5L,8L,9L,4L,6L,6L,9L,4L,3L,7L,0L,6L,3L,4L,1L,4L,5L,2L,9L,3L,2L,8L,7L,1L,5L,8L,3L,3L,1L,6L,6L,4L,9L,0L,5L,0L,4L,4L,4L,4L,4L,2L,9L,5L,7L,8L,8L,5L,6L,7L,8L,6L,6L,6L,8L,2L,2L,4L,3L,4L,6L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196516Inst : IEnumerable<long>
{
public static readonly long[] Value=A196516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196516.Bytes);
public long this[int i]=>Value[i];

public static A196516Inst Instance=new A196516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196517
{
public static readonly long[] Value={ 1L,2L,0L,2L,1L,6L,7L,8L,7L,3L,1L,9L,7L,0L,4L,2L,9L,3L,9L,2L,1L,2L,0L,7L,4L,1L,6L,5L,4L,9L,5L,1L,5L,3L,4L,4L,7L,5L,0L,1L,5L,1L,2L,5L,2L,1L,8L,2L,9L,6L,2L,5L,9L,8L,1L,7L,3L,9L,2L,0L,3L,5L,9L,0L,7L,0L,0L,6L,3L,4L,1L,3L,2L,9L,8L,1L,7L,7L,2L,6L,7L,7L,2L,2L,7L,8L,2L,6L,1L,0L,4L,9L,7L,6L,5L,6L,8L,3L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196517Inst : IEnumerable<long>
{
public static readonly long[] Value=A196517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196517.Bytes);
public long this[int i]=>Value[i];

public static A196517Inst Instance=new A196517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196518
{
public static readonly long[] Value={ 1L,3L,2L,6L,7L,2L,4L,6L,6L,5L,2L,4L,2L,2L,0L,0L,2L,2L,3L,6L,3L,5L,0L,9L,9L,2L,9L,7L,7L,5L,8L,0L,7L,9L,6L,6L,0L,1L,2L,8L,7L,9L,3L,5L,5L,4L,6L,3L,8L,0L,4L,7L,4L,7L,9L,7L,8L,9L,2L,9L,0L,3L,9L,3L,0L,2L,5L,3L,4L,2L,6L,7L,9L,9L,2L,0L,5L,3L,6L,2L,2L,6L,7L,7L,4L,4L,6L,9L,9L,1L,6L,6L,0L,8L,4L,2L,6L,7L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196518Inst : IEnumerable<long>
{
public static readonly long[] Value=A196518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196518.Bytes);
public long this[int i]=>Value[i];

public static A196518Inst Instance=new A196518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196519
{
public static readonly long[] Value={ 1L,4L,3L,2L,4L,0L,4L,7L,7L,5L,8L,9L,8L,3L,0L,0L,3L,1L,1L,2L,3L,4L,0L,7L,8L,0L,0L,7L,2L,1L,2L,0L,5L,8L,6L,9L,4L,7L,8L,6L,4L,3L,4L,6L,0L,8L,8L,0L,4L,3L,0L,2L,0L,2L,5L,6L,5L,5L,9L,4L,8L,4L,9L,6L,3L,4L,3L,3L,9L,9L,5L,9L,3L,2L,5L,9L,8L,3L,1L,1L,1L,6L,8L,5L,7L,6L,3L,8L,4L,2L,2L,2L,9L,9L,5L,4L,9L,8L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196519Inst : IEnumerable<long>
{
public static readonly long[] Value=A196519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196519.Bytes);
public long this[int i]=>Value[i];

public static A196519Inst Instance=new A196519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196520
{
public static readonly BigInteger[] Value={ 25L,279936L,31381059609L,1125899906842624L,1152921504606846976L,BigInteger.Parse("4722366482869645213696"),BigInteger.Parse("42391158275216203514294433201"),BigInteger.Parse("324518553658426726783156020576256") };
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
public class A196520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196520Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196520.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196520.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196520Inst Instance=new A196520Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196521
{
public static readonly long[] Value={ 4L,3L,8L,8L,2L,4L,5L,7L,3L,1L,1L,7L,4L,7L,5L,6L,5L,4L,9L,0L,7L,0L,4L,4L,7L,8L,5L,0L,9L,0L,7L,8L,7L,4L,3L,7L,0L,1L,1L,5L,4L,2L,2L,8L,2L,6L,6L,3L,6L,4L,8L,8L,2L,8L,1L,8L,3L,3L,9L,6L,1L,4L,3L,3L,3L,0L,2L,5L,7L,2L,9L,0L,5L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196521Inst : IEnumerable<long>
{
public static readonly long[] Value=A196521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196521.Bytes);
public long this[int i]=>Value[i];

public static A196521Inst Instance=new A196521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196522
{
public static readonly long[] Value={ 9L,4L,8L,0L,5L,9L,4L,4L,8L,9L,6L,8L,5L,1L,9L,9L,3L,5L,6L,8L,4L,8L,1L,5L,5L,4L,6L,6L,6L,7L,5L,2L,4L,5L,7L,2L,8L,5L,1L,4L,7L,3L,8L,8L,6L,0L,9L,3L,8L,4L,9L,5L,0L,5L,5L,0L,7L,5L,4L,2L,5L,2L,4L,9L,0L,8L,0L,3L,1L,3L,9L,9L,9L,2L,3L,2L,1L,0L,3L,6L,3L,6L,5L,0L,4L,2L,0L,2L,2L,0L,0L,1L,3L,3L,6L,0L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196522Inst : IEnumerable<long>
{
public static readonly long[] Value=A196522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196522.Bytes);
public long this[int i]=>Value[i];

public static A196522Inst Instance=new A196522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196523
{
public static readonly BigInteger[] Value={ 1L,1L,4L,28L,262L,2944L,37666L,532276L,8151322L,133562194L,2320621222L,42475263136L,814932467836L,16326188799508L,340479903535258L,7373196169450312L,165453350568966163L,3840489521467649158L,BigInteger.Parse("92072430090995120044"),BigInteger.Parse("2276807696679096394552") };
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
public class A196523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196523Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196523.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196523.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196523Inst Instance=new A196523Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196524
{
public static readonly long[] Value={ 1L,3L,6L,10L,12L,18L,18L,28L,30L,36L,30L,60L,36L,54L,72L,72L,48L,90L,54L,120L,108L,90L,66L,168L,100L,108L,126L,180L,84L,216L,90L,176L,180L,144L,216L,300L,108L,162L,216L,336L,120L,324L,126L,300L,360L,198L,138L,432L,210L,300L,288L,360L,156L,378L,360L,504L,324L,252L,174L,720L,180L,270L,540L,416L,432L,540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196524Inst : IEnumerable<long>
{
public static readonly long[] Value=A196524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196524.Bytes);
public long this[int i]=>Value[i];

public static A196524Inst Instance=new A196524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196525
{
public static readonly long[] Value={ 6L,2L,3L,2L,2L,5L,2L,4L,0L,1L,4L,0L,2L,3L,0L,5L,1L,3L,3L,9L,4L,0L,2L,0L,0L,8L,0L,2L,5L,0L,5L,6L,8L,0L,0L,2L,6L,5L,0L,6L,9L,5L,3L,1L,2L,3L,4L,6L,5L,6L,7L,2L,5L,2L,8L,9L,8L,7L,1L,4L,7L,7L,6L,0L,9L,6L,1L,7L,0L,0L,0L,4L,5L,4L,7L,0L,1L,4L,1L,8L,0L,4L,6L,7L,6L,6L,9L,0L,7L,3L,2L,3L,5L,6L,2L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196525Inst : IEnumerable<long>
{
public static readonly long[] Value=A196525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196525.Bytes);
public long this[int i]=>Value[i];

public static A196525Inst Instance=new A196525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196526
{
public static readonly long[] Value={ 2L,1L,1L,3L,2L,3L,2L,1L,5L,5L,4L,4L,3L,4L,8L,8L,7L,7L,7L,7L,8L,7L,8L,7L,6L,6L,7L,7L,7L,12L,13L,12L,11L,12L,10L,10L,11L,11L,16L,18L,18L,18L,17L,18L,18L,17L,16L,15L,16L,17L,15L,18L,18L,18L,18L,17L,16L,18L,17L,16L,24L,24L,23L,23L,23L,23L,24L,23L,24L,24L,25L,32L,33L,34L,33L,36L,34L,35L,33L,35L,33L,32L,35L,34L,33L,33L,34L,33L,35L,34L,31L,32L,30L,35L,35L,34L,32L,32L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196526Inst : IEnumerable<long>
{
public static readonly long[] Value=A196526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196526.Bytes);
public long this[int i]=>Value[i];

public static A196526Inst Instance=new A196526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196527
{
public static readonly long[] Value={ 2L,5L,2L,1L,1L,1L,1L,1L,2L,1L,4L,1L,7L,1L,8L,1L,1L,1L,1L,1L,8L,7L,1L,1L,1L,3L,2L,1L,4L,3L,1L,1L,28L,1L,1L,1L,1L,1L,2L,1L,1L,3L,1L,1L,2L,1L,1L,1L,26L,1L,2L,1L,1L,1L,2L,1L,6L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,4L,1L,1L,1L,1L,1L,10L,1L,2L,1L,1L,1L,1L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196527Inst : IEnumerable<long>
{
public static readonly long[] Value=A196527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196527.Bytes);
public long this[int i]=>Value[i];

public static A196527Inst Instance=new A196527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196528
{
public static readonly long[] Value={ 4L,1L,26L,11L,2L,57L,13L,15L,179L,77L,382L,161L,92L,635L,376L,513L,222L,331L,420L,1961L,4080L,933L,685L,103L,386L,49L,1233L,33L,3520L,1317L,196L,1301L,562L,3765L,902L,1769L,7549L,547L,1938L,3349L,1124L,3345L,545L,275L,6606L,21277L,88L,3247L,1411L,955L,6921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196528Inst : IEnumerable<long>
{
public static readonly long[] Value=A196528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196528.Bytes);
public long this[int i]=>Value[i];

public static A196528Inst Instance=new A196528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196529
{
public static readonly long[] Value={ 1L,3L,3L,3L,15L,15L,105L,105L,105L,105L,105L,105L,1155L,1155L,1155L,15015L,15015L,15015L,15015L,15015L,15015L,255255L,255255L,255255L,4849845L,4849845L,4849845L,4849845L,4849845L,4849845L,111546435L,111546435L,111546435L,111546435L,111546435L,111546435L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196529Inst : IEnumerable<long>
{
public static readonly long[] Value=A196529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196529.Bytes);
public long this[int i]=>Value[i];

public static A196529Inst Instance=new A196529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196530
{
public static readonly long[] Value={ 7L,6L,0L,3L,4L,5L,9L,9L,6L,3L,0L,0L,9L,4L,6L,3L,4L,7L,5L,3L,1L,0L,9L,4L,2L,5L,4L,8L,8L,0L,4L,0L,5L,8L,2L,4L,2L,0L,1L,6L,2L,7L,7L,3L,0L,9L,4L,7L,1L,7L,6L,4L,2L,7L,0L,2L,0L,5L,7L,0L,6L,7L,0L,2L,6L,0L,0L,5L,5L,1L,2L,2L,6L,5L,4L,9L,1L,0L,7L,5L,3L,0L,2L,8L,4L,5L,8L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196530Inst : IEnumerable<long>
{
public static readonly long[] Value=A196530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196530.Bytes);
public long this[int i]=>Value[i];

public static A196530Inst Instance=new A196530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196531
{
public static readonly BigInteger[] Value={ 1L,1L,5L,52L,853L,19291L,557719L,19657667L,817847321L,39236975668L,2132767035851L,129548751144077L,8696909403827077L,639445475893738749L,BigInteger.Parse("51105213341360790655"),BigInteger.Parse("4411321463887034379616"),BigInteger.Parse("409004744372281965629617"),BigInteger.Parse("40539225718259037965353203") };
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
public class A196531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196531Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196531.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196531.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196531Inst Instance=new A196531Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196532
{
public static readonly long[] Value={ 1L,5L,20L,94L,524L,3408L,25416L,214128L,2012832L,20894400L,237458880L,2932968960L,39126516480L,560704273920L,8591147712000L,140160890419200L,2425888391270400L,44398288688947200L,856727919929548800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196532Inst : IEnumerable<long>
{
public static readonly long[] Value=A196532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196532.Bytes);
public long this[int i]=>Value[i];

public static A196532Inst Instance=new A196532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196533
{
public static readonly long[] Value={ 4L,0L,7L,7L,4L,2L,2L,7L,4L,2L,6L,8L,8L,5L,6L,7L,8L,5L,3L,0L,4L,0L,4L,3L,1L,2L,0L,7L,0L,2L,8L,9L,9L,3L,7L,4L,6L,6L,3L,5L,8L,7L,0L,6L,4L,0L,5L,4L,9L,9L,3L,9L,3L,6L,2L,4L,5L,0L,4L,5L,1L,4L,4L,1L,5L,8L,6L,1L,1L,4L,9L,4L,5L,5L,3L,0L,3L,2L,1L,3L,9L,1L,8L,5L,7L,0L,7L,3L,2L,6L,7L,7L,8L,7L,7L,4L,9L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196533Inst : IEnumerable<long>
{
public static readonly long[] Value=A196533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196533.Bytes);
public long this[int i]=>Value[i];

public static A196533Inst Instance=new A196533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196534
{
public static readonly long[] Value={ 1L,3L,8L,18L,39L,83L,179L,388L,857L,1914L,4494L,10844L,26923L,70645L,192297L,538646L,1579602L,4793718L,15010425L,48941642L,164010913L,566065123L,2025354291L,7450901462L,27986863322L,107940691328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196534Inst : IEnumerable<long>
{
public static readonly long[] Value=A196534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196534.Bytes);
public long this[int i]=>Value[i];

public static A196534Inst Instance=new A196534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196535
{
public static readonly long[] Value={ 0L,4L,3L,2L,1L,3L,9L,1L,8L,2L,6L,4L,2L,9L,7L,7L,9L,8L,2L,9L,2L,0L,1L,8L,3L,8L,2L,0L,2L,7L,2L,5L,0L,3L,4L,1L,8L,4L,2L,0L,6L,0L,4L,4L,7L,7L,1L,2L,9L,3L,7L,4L,6L,3L,1L,2L,5L,2L,7L,3L,4L,4L,6L,1L,7L,8L,9L,8L,7L,1L,8L,0L,7L,2L,3L,7L,7L,5L,1L,7L,0L,4L,9L,9L,3L,1L,8L,1L,5L,8L,7L,8L,2L,5L,2L,4L,9L,0L,6L,2L,8L,4L,7L,1L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196535Inst : IEnumerable<long>
{
public static readonly long[] Value=A196535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196535.Bytes);
public long this[int i]=>Value[i];

public static A196535Inst Instance=new A196535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196536
{
public static readonly ulong[] Value={ 1L,23L,555L,340286L,1202209625L,40385639042743L,11727457709816827017UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196536Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A196536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196536.Bytes);
public ulong this[int i]=>Value[i];

public static A196536Inst Instance=new A196536Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196537
{
public static readonly long[] Value={ 1L,3L,2L,7L,19L,35L,77L,176L,377L,819L,1801L,3927L,8562L,18711L,40855L,89179L,194729L,425184L,928305L,2026855L,4425441L,9662395L,21096706L,46062279L,100571611L,219586403L,479441557L,1046805072L,2285577449L,4990293595L,10895727817L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196537Inst : IEnumerable<long>
{
public static readonly long[] Value=A196537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196537.Bytes);
public long this[int i]=>Value[i];

public static A196537Inst Instance=new A196537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196538
{
public static readonly long[] Value={ 3L,23L,56L,461L,2897L,17967L,116911L,757146L,4893755L,31718101L,205477601L,1331145835L,8624488786L,55876739813L,362017883823L,2345474974395L,15196064614313L,98453588371088L,637869800997933L,4132686977034097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196538Inst : IEnumerable<long>
{
public static readonly long[] Value=A196538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196538.Bytes);
public long this[int i]=>Value[i];

public static A196538Inst Instance=new A196538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196539
{
public static readonly long[] Value={ 2L,56L,555L,11200L,112723L,1231014L,18047775L,249080912L,3224160693L,42170084169L,562089504718L,7496675641466L,99355372063480L,1315111559086294L,17446330077786508L,231599788865925152L,3072162248942709113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196539Inst : IEnumerable<long>
{
public static readonly long[] Value=A196539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196539.Bytes);
public long this[int i]=>Value[i];

public static A196539Inst Instance=new A196539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196540
{
public static readonly BigInteger[] Value={ 7L,461L,11200L,340286L,11955804L,492164626L,19551716726L,762304199460L,30102052972401L,1191511814763748L,47012897542283671L,1854609910206450722L,BigInteger.Parse("73234604023710412911"),BigInteger.Parse("2891416319601153583732"),BigInteger.Parse("114129499568282696605287") };
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
public class A196540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196540Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196540.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196540.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196540Inst Instance=new A196540Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196541
{
public static readonly BigInteger[] Value={ 19L,2897L,112723L,11955804L,1202209625L,134252759220L,15090629432544L,1674551042811491L,186974407177541859L,BigInteger.Parse("20855281833499454493"),BigInteger.Parse("2324984932736447335502"),BigInteger.Parse("259314439638504588082785") };
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
public class A196541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196541Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196541.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196541.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196541Inst Instance=new A196541Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196542
{
public static readonly BigInteger[] Value={ 35L,17967L,1231014L,492164626L,134252759220L,40385639042743L,12880710896209551L,4028515464320117251L,BigInteger.Parse("1257662709379037323051"),BigInteger.Parse("392183658148156006761193"),BigInteger.Parse("122501552053443938978492943") };
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
public class A196542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196542Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196542.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196542.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196542Inst Instance=new A196542Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196543
{
public static readonly ulong[] Value={ 77L,116911L,18047775L,19551716726L,15090629432544L,12880710896209551L,11727457709816827017UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196543Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A196543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196543.Bytes);
public ulong this[int i]=>Value[i];

public static A196543Inst Instance=new A196543Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196544
{
public static readonly long[] Value={ 1L,3L,3L,2L,23L,2L,7L,56L,56L,7L,19L,461L,555L,461L,19L,35L,2897L,11200L,11200L,2897L,35L,77L,17967L,112723L,340286L,112723L,17967L,77L,176L,116911L,1231014L,11955804L,11955804L,1231014L,116911L,176L,377L,757146L,18047775L,492164626L,1202209625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196544Inst : IEnumerable<long>
{
public static readonly long[] Value=A196544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196544.Bytes);
public long this[int i]=>Value[i];

public static A196544Inst Instance=new A196544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196545
{
public static readonly long[] Value={ 1L,1L,2L,5L,12L,34L,92L,277L,806L,2500L,7578L,24198L,75370L,243800L,776494L,2545777L,8223352L,27221690L,88984144L,296856400L,979829772L,3287985078L,10934749788L,36912408342L,123519937044L,418650924886L,1408867195252L,4794243983204L,16205061000480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196545Inst : IEnumerable<long>
{
public static readonly long[] Value=A196545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196545.Bytes);
public long this[int i]=>Value[i];

public static A196545Inst Instance=new A196545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196546
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,13L,14L,15L,17L,19L,21L,22L,23L,25L,27L,28L,29L,30L,31L,33L,35L,37L,38L,39L,41L,43L,45L,46L,47L,49L,51L,52L,53L,55L,57L,59L,61L,62L,63L,65L,66L,67L,69L,70L,71L,73L,75L,77L,78L,79L,81L,83L,85L,86L,87L,89L,91L,92L,93L,94L,95L,97L,98L,99L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196546Inst : IEnumerable<long>
{
public static readonly long[] Value=A196546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196546.Bytes);
public long this[int i]=>Value[i];

public static A196546Inst Instance=new A196546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196547
{
public static readonly long[] Value={ 1L,9L,14L,15L,21L,22L,25L,27L,28L,30L,33L,35L,38L,39L,45L,46L,49L,51L,52L,55L,57L,62L,63L,65L,66L,69L,70L,75L,77L,78L,81L,85L,86L,87L,91L,92L,93L,94L,95L,98L,99L,102L,105L,111L,115L,116L,117L,118L,119L,121L,123L,124L,125L,129L,132L,133L,134L,135L,138L,141L,142L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196547Inst : IEnumerable<long>
{
public static readonly long[] Value=A196547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196547.Bytes);
public long this[int i]=>Value[i];

public static A196547Inst Instance=new A196547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196548
{
public static readonly long[] Value={ 1L,2L,4L,5L,1L,6L,9L,0L,9L,2L,9L,7L,1L,4L,1L,3L,9L,3L,4L,6L,4L,0L,9L,4L,0L,1L,5L,1L,3L,1L,5L,5L,3L,2L,4L,0L,4L,6L,7L,6L,1L,8L,4L,5L,7L,0L,8L,1L,3L,8L,7L,2L,5L,7L,9L,3L,8L,8L,0L,0L,5L,4L,7L,3L,2L,1L,6L,3L,6L,6L,1L,7L,6L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196548Inst : IEnumerable<long>
{
public static readonly long[] Value=A196548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196548.Bytes);
public long this[int i]=>Value[i];

public static A196548Inst Instance=new A196548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196549
{
public static readonly long[] Value={ 1L,1L,9L,0L,7L,8L,3L,6L,8L,2L,9L,7L,3L,2L,9L,5L,9L,1L,5L,3L,1L,8L,0L,0L,2L,5L,0L,6L,8L,5L,8L,5L,7L,0L,1L,0L,1L,7L,3L,3L,5L,7L,2L,6L,5L,9L,1L,9L,2L,2L,8L,4L,2L,6L,7L,1L,3L,7L,1L,5L,2L,4L,4L,3L,0L,2L,6L,6L,5L,0L,3L,8L,9L,6L,7L,2L,9L,8L,7L,5L,9L,3L,4L,9L,2L,1L,0L,0L,9L,3L,7L,7L,2L,2L,0L,3L,3L,3L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196549Inst : IEnumerable<long>
{
public static readonly long[] Value=A196549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196549.Bytes);
public long this[int i]=>Value[i];

public static A196549Inst Instance=new A196549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196550
{
public static readonly long[] Value={ 1L,2L,5L,6L,0L,5L,8L,6L,5L,9L,3L,9L,1L,7L,4L,5L,2L,3L,8L,0L,2L,4L,1L,6L,7L,4L,6L,2L,3L,4L,2L,1L,3L,3L,7L,1L,1L,1L,1L,3L,3L,3L,7L,0L,2L,0L,0L,8L,9L,6L,5L,5L,8L,6L,4L,3L,5L,6L,3L,0L,0L,6L,3L,5L,6L,5L,9L,0L,4L,7L,5L,1L,6L,1L,5L,9L,4L,3L,5L,6L,2L,7L,3L,1L,8L,1L,8L,3L,0L,3L,8L,3L,7L,6L,4L,6L,6L,6L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196550Inst : IEnumerable<long>
{
public static readonly long[] Value=A196550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196550.Bytes);
public long this[int i]=>Value[i];

public static A196550Inst Instance=new A196550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196551
{
public static readonly long[] Value={ 1L,4L,5L,6L,9L,9L,9L,5L,5L,9L,1L,3L,4L,5L,9L,1L,8L,2L,6L,2L,5L,3L,2L,2L,3L,0L,2L,5L,6L,9L,4L,2L,5L,5L,4L,0L,8L,6L,4L,9L,8L,5L,9L,7L,2L,5L,5L,8L,1L,9L,9L,6L,4L,3L,4L,9L,8L,1L,1L,3L,5L,9L,6L,7L,4L,0L,4L,5L,5L,9L,4L,7L,0L,1L,8L,8L,1L,5L,9L,0L,6L,9L,7L,5L,2L,4L,0L,6L,0L,3L,9L,2L,7L,6L,8L,6L,8L,8L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196551Inst : IEnumerable<long>
{
public static readonly long[] Value=A196551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196551.Bytes);
public long this[int i]=>Value[i];

public static A196551Inst Instance=new A196551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196552
{
public static readonly long[] Value={ 1L,6L,2L,3L,1L,4L,0L,3L,4L,5L,9L,6L,9L,0L,3L,6L,6L,7L,0L,9L,4L,2L,3L,3L,4L,4L,0L,4L,1L,6L,1L,9L,6L,5L,6L,3L,4L,8L,2L,6L,2L,9L,8L,7L,3L,7L,7L,9L,7L,9L,5L,9L,9L,3L,4L,7L,2L,4L,5L,5L,4L,6L,8L,2L,8L,7L,8L,3L,9L,6L,5L,8L,6L,6L,7L,2L,5L,3L,9L,2L,5L,9L,4L,5L,7L,4L,2L,6L,7L,3L,7L,4L,6L,7L,9L,5L,5L,9L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196552Inst : IEnumerable<long>
{
public static readonly long[] Value=A196552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196552.Bytes);
public long this[int i]=>Value[i];

public static A196552Inst Instance=new A196552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196553
{
public static readonly long[] Value={ 1L,7L,6L,5L,1L,6L,1L,9L,4L,8L,2L,5L,6L,6L,9L,9L,1L,3L,7L,1L,8L,5L,0L,5L,5L,7L,0L,3L,2L,8L,6L,4L,6L,5L,2L,8L,1L,8L,0L,0L,7L,3L,5L,6L,2L,0L,0L,3L,2L,7L,1L,8L,7L,7L,2L,9L,5L,0L,5L,5L,9L,5L,9L,2L,4L,8L,4L,5L,8L,3L,8L,5L,4L,9L,4L,0L,9L,3L,1L,5L,1L,5L,4L,5L,2L,2L,3L,3L,3L,8L,3L,4L,8L,3L,0L,1L,6L,8L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196553Inst : IEnumerable<long>
{
public static readonly long[] Value=A196553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196553.Bytes);
public long this[int i]=>Value[i];

public static A196553Inst Instance=new A196553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196554
{
public static readonly long[] Value={ 2L,1L,6L,7L,4L,3L,2L,4L,6L,8L,3L,4L,9L,7L,7L,7L,5L,9L,3L,9L,3L,4L,9L,8L,7L,9L,0L,9L,7L,0L,7L,1L,7L,6L,7L,8L,4L,1L,3L,0L,4L,3L,8L,4L,1L,8L,3L,6L,3L,1L,1L,2L,2L,6L,0L,8L,3L,7L,5L,7L,9L,5L,9L,7L,2L,9L,4L,0L,9L,8L,3L,7L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196554Inst : IEnumerable<long>
{
public static readonly long[] Value=A196554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196554.Bytes);
public long this[int i]=>Value[i];

public static A196554Inst Instance=new A196554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196555
{
public static readonly BigInteger[] Value={ 1L,2L,6L,28L,186L,1614L,17332L,222254L,3317326L,56532264L,1083571422L,23081180918L,541047188936L,13843339479298L,383952455939662L,11475711580482268L,367729128426998450L,12577206203908139494UL,BigInteger.Parse("457341567152354085700"),BigInteger.Parse("17619050162270848917366") };
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
public class A196555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196555Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196555.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196555.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196555Inst Instance=new A196555Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196556
{
public static readonly BigInteger[] Value={ 1L,3L,12L,66L,483L,4476L,50454L,671649L,10328118L,180341094L,3527385345L,76435691250L,1818255212490L,47118807865863L,1321527658352016L,39889359465259446L,1289471521115731611L,BigInteger.Parse("44450463108654209136"),BigInteger.Parse("1627806562174453037802") };
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
public class A196556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196556Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196556.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196556.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196556Inst Instance=new A196556Inst();

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