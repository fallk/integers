using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A201605
{
public static readonly long[] Value={ 11L,67L,179L,347L,571L,1187L,1579L,2027L,2531L,5107L,9587L,10651L,15467L,16811L,18211L,21179L,24371L,33331L,35291L,37307L,41507L,43691L,63179L,65867L,68611L,71411L,80147L,89387L,99131L,105907L,109379L,116491L,127579L,147179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201605Inst : IEnumerable<long>
{
public static readonly long[] Value=A201605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201605.Bytes);
public long this[int i]=>Value[i];

public static A201605Inst Instance=new A201605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201606
{
public static readonly long[] Value={ 5L,257L,1013L,2273L,30497L,36293L,90977L,183713L,197573L,326597L,383297L,423617L,533237L,707873L,734837L,790277L,1000193L,1097717L,1199777L,1270337L,1306373L,1379957L,1951493L,1996097L,2086817L,2371073L,2420213L,2570657L,3217793L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201606Inst : IEnumerable<long>
{
public static readonly long[] Value=A201606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201606.Bytes);
public long this[int i]=>Value[i];

public static A201606Inst Instance=new A201606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201607
{
public static readonly long[] Value={ 13L,181L,349L,853L,2029L,3709L,6733L,8581L,24373L,26053L,29581L,37309L,50581L,57973L,71413L,80149L,92581L,99133L,112909L,123829L,155413L,195229L,199933L,214381L,277213L,294181L,311653L,323581L,329629L,399853L,406573L,427069L,491581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201607Inst : IEnumerable<long>
{
public static readonly long[] Value=A201607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201607.Bytes);
public long this[int i]=>Value[i];

public static A201607Inst Instance=new A201607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201608
{
public static readonly long[] Value={ 71L,1583L,22751L,27791L,39383L,127583L,163871L,190583L,219311L,234431L,266183L,299951L,317591L,354383L,393191L,617471L,922391L,984383L,1048391L,1436471L,1513583L,2018591L,2156183L,2250431L,2298311L,2395583L,2545271L,2804831L,3076991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201608Inst : IEnumerable<long>
{
public static readonly long[] Value=A201608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201608.Bytes);
public long this[int i]=>Value[i];

public static A201608Inst Instance=new A201608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201609
{
public static readonly long[] Value={ 37L,457L,709L,1381L,1801L,7177L,8101L,14821L,17509L,21961L,23557L,32377L,44809L,54217L,61861L,70009L,75721L,94201L,107641L,137209L,141157L,153337L,166021L,179209L,188281L,202309L,216841L,221797L,231877L,252709L,268921L,280009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201609Inst : IEnumerable<long>
{
public static readonly long[] Value=A201609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201609.Bytes);
public long this[int i]=>Value[i];

public static A201609Inst Instance=new A201609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201610
{
public static readonly long[] Value={ 17L,73L,353L,577L,857L,1193L,5113L,5897L,6737L,10657L,11777L,12953L,15473L,18217L,27793L,37313L,41513L,55457L,57977L,80153L,83177L,86257L,89393L,99137L,102497L,105913L,112913L,123833L,135257L,139177L,151273L,159617L,172553L,176977L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201610Inst : IEnumerable<long>
{
public static readonly long[] Value=A201610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201610.Bytes);
public long this[int i]=>Value[i];

public static A201610Inst Instance=new A201610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201611
{
public static readonly long[] Value={ 3L,11L,131L,971L,1571L,3203L,5003L,7691L,9803L,13451L,16931L,19211L,24203L,27851L,32771L,51203L,57803L,81611L,86531L,89891L,125003L,143651L,154571L,204803L,207371L,247811L,273803L,288803L,339491L,356171L,387203L,401411L,480203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201611Inst : IEnumerable<long>
{
public static readonly long[] Value=A201611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201611.Bytes);
public long this[int i]=>Value[i];

public static A201611Inst Instance=new A201611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201612
{
public static readonly long[] Value={ 5L,13L,37L,293L,397L,653L,2053L,3533L,3877L,5413L,6277L,6733L,10957L,14797L,15493L,19213L,23333L,25997L,30757L,36997L,48677L,55117L,56453L,69197L,75277L,76837L,86533L,98573L,100357L,109517L,117133L,129037L,139397L,143653L,154573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201612Inst : IEnumerable<long>
{
public static readonly long[] Value=A201612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201612.Bytes);
public long this[int i]=>Value[i];

public static A201612Inst Instance=new A201612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201613
{
public static readonly long[] Value={ 43L,59L,67L,107L,139L,251L,307L,347L,379L,547L,587L,859L,1699L,1867L,1931L,3371L,3499L,3739L,4507L,5059L,5347L,6907L,6971L,7451L,10091L,10627L,10667L,11467L,12491L,18787L,20411L,21227L,22907L,29947L,32059L,32779L,37547L,38651L,39619L,49307L,49747L,53147L,55787L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201613Inst : IEnumerable<long>
{
public static readonly long[] Value=A201613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201613.Bytes);
public long this[int i]=>Value[i];

public static A201613Inst Instance=new A201613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201614
{
public static readonly long[] Value={ 3L,9L,6L,4L,7L,8L,4L,0L,0L,1L,7L,6L,7L,2L,8L,8L,0L,1L,3L,2L,0L,3L,7L,7L,2L,1L,9L,5L,4L,9L,1L,4L,5L,0L,1L,3L,1L,1L,7L,8L,3L,7L,6L,1L,4L,2L,2L,1L,9L,0L,4L,1L,8L,5L,1L,5L,8L,6L,6L,3L,8L,8L,9L,5L,4L,4L,0L,1L,0L,8L,7L,8L,0L,8L,5L,0L,8L,7L,7L,9L,9L,7L,0L,3L,9L,5L,5L,5L,9L,1L,1L,1L,0L,5L,2L,9L,9L,2L,9L,0L,2L,5L,5L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201614Inst : IEnumerable<long>
{
public static readonly long[] Value=A201614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201614.Bytes);
public long this[int i]=>Value[i];

public static A201614Inst Instance=new A201614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201615
{
public static readonly long[] Value={ 2L,1L,3L,7L,6L,6L,9L,5L,0L,9L,6L,7L,2L,6L,9L,8L,4L,3L,3L,3L,1L,7L,1L,4L,9L,8L,1L,6L,9L,0L,3L,2L,6L,1L,9L,4L,1L,9L,0L,3L,9L,6L,6L,6L,3L,1L,7L,4L,4L,2L,0L,9L,7L,5L,8L,4L,7L,2L,1L,2L,1L,4L,7L,1L,0L,5L,2L,3L,8L,7L,1L,0L,1L,1L,6L,3L,4L,5L,5L,0L,5L,2L,5L,3L,9L,6L,5L,8L,8L,6L,2L,6L,3L,0L,5L,3L,3L,3L,6L,6L,0L,8L,6L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201615Inst : IEnumerable<long>
{
public static readonly long[] Value=A201615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201615.Bytes);
public long this[int i]=>Value[i];

public static A201615Inst Instance=new A201615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201616
{
public static readonly long[] Value={ 1L,1L,2L,9L,7L,0L,5L,2L,2L,2L,0L,0L,5L,9L,7L,7L,4L,2L,2L,3L,8L,0L,4L,0L,6L,7L,7L,9L,0L,4L,2L,8L,7L,9L,4L,3L,4L,0L,8L,6L,1L,9L,1L,4L,5L,0L,2L,3L,1L,6L,4L,4L,8L,6L,2L,1L,1L,2L,1L,0L,5L,0L,7L,6L,7L,7L,7L,0L,1L,9L,5L,3L,8L,3L,2L,7L,3L,0L,7L,9L,8L,9L,2L,9L,2L,6L,3L,4L,6L,4L,8L,2L,2L,8L,9L,4L,3L,8L,9L,6L,9L,3L,7L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201616Inst : IEnumerable<long>
{
public static readonly long[] Value=A201616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201616.Bytes);
public long this[int i]=>Value[i];

public static A201616Inst Instance=new A201616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201617
{
public static readonly long[] Value={ 0L,16L,378L,91223L,136175057L,1492809994673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201617Inst : IEnumerable<long>
{
public static readonly long[] Value=A201617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201617.Bytes);
public long this[int i]=>Value[i];

public static A201617Inst Instance=new A201617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201618
{
public static readonly long[] Value={ 0L,4L,4L,10L,16L,26L,40L,59L,84L,116L,156L,205L,264L,334L,416L,511L,620L,744L,884L,1041L,1216L,1410L,1624L,1859L,2116L,2396L,2700L,3029L,3384L,3766L,4176L,4615L,5084L,5584L,6116L,6681L,7280L,7914L,8584L,9291L,10036L,10820L,11644L,12509L,13416L,14366L,15360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201618Inst : IEnumerable<long>
{
public static readonly long[] Value=A201618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201618.Bytes);
public long this[int i]=>Value[i];

public static A201618Inst Instance=new A201618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201619
{
public static readonly long[] Value={ 4L,16L,56L,211L,718L,2271L,6654L,18191L,46767L,113873L,264247L,587571L,1257743L,2602113L,5220668L,10186777L,19378603L,36016206L,65517188L,116838180L,204546828L,351977489L,595974410L,993932688L,1634127635L,2650699891L,4245165105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201619Inst : IEnumerable<long>
{
public static readonly long[] Value=A201619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201619.Bytes);
public long this[int i]=>Value[i];

public static A201619Inst Instance=new A201619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201620
{
public static readonly long[] Value={ 4L,56L,378L,3699L,31802L,256836L,1877283L,12466658L,75830797L,426330762L,2234037739L,10991599638L,51096736814L,225648517165L,951032245643L,3840801817887L,14914920467311L,55860582248737L,202312954584987L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201620Inst : IEnumerable<long>
{
public static readonly long[] Value=A201620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201620.Bytes);
public long this[int i]=>Value[i];

public static A201620Inst Instance=new A201620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201621
{
public static readonly long[] Value={ 10L,211L,3699L,91223L,2111763L,45733593L,891142897L,15644678596L,249289360661L,3639136663173L,49094967861596L,616937242119695L,7271050760251026L,80851029109219123L,852557302953238048L,8562810135696296292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201621Inst : IEnumerable<long>
{
public static readonly long[] Value=A201621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201621.Bytes);
public long this[int i]=>Value[i];

public static A201621Inst Instance=new A201621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201622
{
public static readonly BigInteger[] Value={ 16L,718L,31802L,2111763L,136175057L,8368969235L,464328365996L,23135668030252L,1040850319379231L,42653434489979374L,1606362705401822170L,BigInteger.Parse("56058651943376958129"),BigInteger.Parse("1826011093775518985924"),BigInteger.Parse("55867244848599391254270") };
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
public class A201622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201622Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201622.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201622Inst Instance=new A201622Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201623
{
public static readonly BigInteger[] Value={ 26L,2271L,256836L,45733593L,8368969235L,1492809994673L,242036871702096L,35298906093734951L,4642502137893927659L,BigInteger.Parse("554913226364951538300"),BigInteger.Parse("60802653561518861509758"),BigInteger.Parse("6157866184324500142914732") };
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
public class A201623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201623Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201623.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201623Inst Instance=new A201623Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201624
{
public static readonly long[] Value={ 40L,6654L,1877283L,891142897L,464328365996L,242036871702096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201624Inst : IEnumerable<long>
{
public static readonly long[] Value=A201624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201624.Bytes);
public long this[int i]=>Value[i];

public static A201624Inst Instance=new A201624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201625
{
public static readonly long[] Value={ 0L,4L,4L,4L,16L,4L,10L,56L,56L,10L,16L,211L,378L,211L,16L,26L,718L,3699L,3699L,718L,26L,40L,2271L,31802L,91223L,31802L,2271L,40L,59L,6654L,256836L,2111763L,2111763L,256836L,6654L,59L,84L,18191L,1877283L,45733593L,136175057L,45733593L,1877283L,18191L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201625Inst : IEnumerable<long>
{
public static readonly long[] Value=A201625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201625.Bytes);
public long this[int i]=>Value[i];

public static A201625Inst Instance=new A201625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201626
{
public static readonly BigInteger[] Value={ 1L,2L,6L,228L,6745L,252792L,11281312L,585632520L,34690541994L,2309813476870L,170797663069044L,13888215374348892L,1231730727253607451L,BigInteger.Parse("118329596584708240732"),BigInteger.Parse("12241103359460777972760"),BigInteger.Parse("1356712722052907806912016") };
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
public class A201626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201626Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201626.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201626Inst Instance=new A201626Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201627
{
public static readonly BigInteger[] Value={ 1L,1L,4L,29L,312L,4481L,80768L,1754549L,44647040L,1303097665L,42923116032L,1575332861101L,63754405679104L,2820829737123841L,135469202252333056L,7018336152909163205L,BigInteger.Parse("390175030207597805568"),BigInteger.Parse("23169468447962190613121"),BigInteger.Parse("1463683656780476860989440"),BigInteger.Parse("98016257612539018485477821") };
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
public class A201627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201627Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201627.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201627Inst Instance=new A201627Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201628
{
public static readonly BigInteger[] Value={ 1L,1L,4L,31L,360L,5601L,109568L,2586151L,71555200L,2271961825L,81441188352L,3253620672303L,143361363439616L,6907049546879041L,361245668908466176L,BigInteger.Parse("20383791705206338807"),BigInteger.Parse("1234336634416972726272"),BigInteger.Parse("79843983527411321710401"),BigInteger.Parse("5494767253686351671459840"),BigInteger.Parse("400863405346004202504321343") };
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
public class A201628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201628Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201628.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201628Inst Instance=new A201628Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201629
{
public static readonly long[] Value={ 0L,0L,2L,4L,4L,4L,6L,8L,8L,8L,10L,12L,12L,12L,14L,16L,16L,16L,18L,20L,20L,20L,22L,24L,24L,24L,26L,28L,28L,28L,30L,32L,32L,32L,34L,36L,36L,36L,38L,40L,40L,40L,42L,44L,44L,44L,46L,48L,48L,48L,50L,52L,52L,52L,54L,56L,56L,56L,58L,60L,60L,60L,62L,64L,64L,64L,66L,68L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201629Inst : IEnumerable<long>
{
public static readonly long[] Value=A201629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201629.Bytes);
public long this[int i]=>Value[i];

public static A201629Inst Instance=new A201629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201630
{
public static readonly long[] Value={ 2L,7L,11L,25L,47L,97L,191L,385L,767L,1537L,3071L,6145L,12287L,24577L,49151L,98305L,196607L,393217L,786431L,1572865L,3145727L,6291457L,12582911L,25165825L,50331647L,100663297L,201326591L,402653185L,805306367L,1610612737L,3221225471L,6442450945L,12884901887L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201630Inst : IEnumerable<long>
{
public static readonly long[] Value=A201630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201630.Bytes);
public long this[int i]=>Value[i];

public static A201630Inst Instance=new A201630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201631
{
public static readonly long[] Value={ 1L,3L,6L,13L,30L,70L,167L,405L,992L,2450L,6090L,15214L,38165L,96069L,242530L,613811L,1556856L,3956316L,10070871L,25674210L,65541142L,167517654L,428635032L,1097874434L,2814611701L,7221917871L,18544968768L,47655572191L,122544150258L,315313433594L,811792614547L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201631Inst : IEnumerable<long>
{
public static readonly long[] Value=A201631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201631.Bytes);
public long this[int i]=>Value[i];

public static A201631Inst Instance=new A201631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201632
{
public static readonly long[] Value={ 35L,83L,1203L,2835L,40883L,96323L,1388835L,3272163L,47179523L,111157235L,1602714963L,3776073843L,54445129235L,128275353443L,1849531679043L,4357585943235L,62829631958243L,148029646716563L,2134357954901235L,5028650402419923L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201632Inst : IEnumerable<long>
{
public static readonly long[] Value=A201632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201632.Bytes);
public long this[int i]=>Value[i];

public static A201632Inst Instance=new A201632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201633
{
public static readonly long[] Value={ 11L,28L,424L,1001L,14453L,34054L,491026L,1156883L,16680479L,39300016L,566645308L,1335043709L,19249260041L,45352186138L,653908196134L,1540639285031L,22213629408563L,52336383504964L,754609491695056L,1777896399883793L,25634509088223389L,60396141212544046L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201633Inst : IEnumerable<long>
{
public static readonly long[] Value=A201633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201633.Bytes);
public long this[int i]=>Value[i];

public static A201633Inst Instance=new A201633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201634
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,4L,1L,4L,8L,8L,1L,5L,13L,21L,16L,1L,6L,19L,40L,56L,32L,1L,7L,26L,66L,122L,154L,64L,1L,8L,34L,100L,222L,376L,440L,128L,1L,9L,43L,143L,365L,741L,1181L,1309L,256L,1L,10L,53L,196L,561L,1302L,2483L,3792L,4048L,512L,1L,11L,64L,260L,821L,2123L,4606L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201634Inst : IEnumerable<long>
{
public static readonly long[] Value=A201634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201634.Bytes);
public long this[int i]=>Value[i];

public static A201634Inst Instance=new A201634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201635
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,2L,1L,2L,4L,6L,1L,3L,7L,13L,22L,1L,4L,11L,24L,46L,80L,1L,5L,16L,40L,86L,166L,296L,1L,6L,22L,62L,148L,314L,610L,1106L,1L,7L,29L,91L,239L,553L,1163L,2269L,4166L,1L,8L,37L,128L,367L,920L,2083L,4352L,8518L,15792L,1L,9L,46L,174L,541L,1461L,3544L,7896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201635Inst : IEnumerable<long>
{
public static readonly long[] Value=A201635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201635.Bytes);
public long this[int i]=>Value[i];

public static A201635Inst Instance=new A201635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201636
{
public static readonly long[] Value={ 1L,0L,1L,0L,4L,3L,0L,24L,40L,15L,0L,192L,520L,420L,105L,0L,1920L,7392L,9520L,5040L,945L,0L,23040L,116928L,211456L,176400L,69300L,10395L,0L,322560L,2055168L,4858560L,5642560L,3465000L,1081080L,135135L,0L,5160960L,39896064L,117722880L,177580480L,150870720L,73153080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201636Inst : IEnumerable<long>
{
public static readonly long[] Value=A201636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201636.Bytes);
public long this[int i]=>Value[i];

public static A201636Inst Instance=new A201636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201637
{
public static readonly long[] Value={ 1L,1L,0L,1L,2L,0L,1L,8L,6L,0L,1L,22L,58L,24L,0L,1L,52L,328L,444L,120L,0L,1L,114L,1452L,4400L,3708L,720L,0L,1L,240L,5610L,32120L,58140L,33984L,5040L,0L,1L,494L,19950L,195800L,644020L,785304L,341136L,40320L,0L,1L,1004L,67260L,1062500L,5765500L,12440064L,11026296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201637Inst : IEnumerable<long>
{
public static readonly long[] Value=A201637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201637.Bytes);
public long this[int i]=>Value[i];

public static A201637Inst Instance=new A201637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201638
{
public static readonly long[] Value={ 1L,3L,1L,12L,6L,1L,54L,33L,9L,1L,261L,180L,63L,12L,1L,1323L,990L,405L,102L,15L,1L,6939L,5508L,2511L,756L,150L,18L,1L,37341L,30996L,15309L,5229L,1260L,207L,21L,1L,205011L,176256L,92610L,34776L,9630L,1944L,273L,24L,1L,1143801L,1011609L,558414L,225828L,69498L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201638Inst : IEnumerable<long>
{
public static readonly long[] Value=A201638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201638.Bytes);
public long this[int i]=>Value[i];

public static A201638Inst Instance=new A201638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201639
{
public static readonly long[] Value={ 1L,4L,1L,20L,8L,1L,112L,56L,12L,1L,672L,384L,108L,16L,1L,4224L,2640L,880L,176L,20L,1L,27456L,18304L,6864L,1664L,260L,24L,1L,183040L,128128L,52416L,14560L,2800L,360L,28L,1L,1244672L,905216L,396032L,121856L,27200L,4352L,476L,32L,1L,8599552L,6449664L,2976768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201639Inst : IEnumerable<long>
{
public static readonly long[] Value=A201639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201639.Bytes);
public long this[int i]=>Value[i];

public static A201639Inst Instance=new A201639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201640
{
public static readonly long[] Value={ 1L,8L,54L,368L,2550L,17952L,128086L,924128L,6729858L,49395440L,364979560L,2712343680L,20257516240L,151957919232L,1144281700110L,8646263301056L,65531851263978L,498047725561104L,3794627850238756L,28976634967413920L,221728252767064596L,1699859618636556608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201640Inst : IEnumerable<long>
{
public static readonly long[] Value=A201640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201640.Bytes);
public long this[int i]=>Value[i];

public static A201640Inst Instance=new A201640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201641
{
public static readonly long[] Value={ 1L,2L,1L,8L,4L,1L,32L,20L,6L,1L,144L,96L,36L,8L,1L,672L,480L,200L,56L,10L,1L,3264L,2432L,1104L,352L,80L,12L,1L,16256L,12544L,6048L,2128L,560L,108L,14L,1L,82688L,65536L,33152L,12544L,3680L,832L,140L,16L,1L,427520L,346368L,182016L,72960L,23232L,5904L,1176L,176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201641Inst : IEnumerable<long>
{
public static readonly long[] Value=A201641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201641.Bytes);
public long this[int i]=>Value[i];

public static A201641Inst Instance=new A201641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201642
{
public static readonly BigInteger[] Value={ 1L,12L,1211L,121121L,121121221L,12112122122112L,BigInteger.Parse("1211212212211211221211"),BigInteger.Parse("121121221221121122121121221121121"),BigInteger.Parse("1211212212211211221211212211211212212211212212112"),BigInteger.Parse("12112122122112112212112122112112122122112122121121122122112122122112112122") };
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
public class A201642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201642Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201642.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201642Inst Instance=new A201642Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201643
{
public static readonly long[] Value={ 3L,5L,7L,9L,15L,21L,27L,35L,63L,105L,135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201643Inst : IEnumerable<long>
{
public static readonly long[] Value=A201643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201643.Bytes);
public long this[int i]=>Value[i];

public static A201643Inst Instance=new A201643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201644
{
public static readonly long[] Value={ 3L,5L,7L,9L,11L,15L,35L,45L,231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201644Inst : IEnumerable<long>
{
public static readonly long[] Value=A201644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201644.Bytes);
public long this[int i]=>Value[i];

public static A201644Inst Instance=new A201644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201645
{
public static readonly long[] Value={ 1L,1L,1L,3L,7L,11L,21L,53L,113L,211L,451L,1049L,2223L,4517L,9881L,22203L,47531L,100531L,220933L,489737L,1059137L,2284401L,5025959L,11088703L,24161133L,52644061L,115913011L,255469863L,559494883L,1226060651L,2702052381L,5957474213L,13092891293L,28792397139L,63518607791L,140165690233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201645Inst : IEnumerable<long>
{
public static readonly long[] Value=A201645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201645.Bytes);
public long this[int i]=>Value[i];

public static A201645Inst Instance=new A201645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201646
{
public static readonly long[] Value={ 3L,5L,7L,9L,11L,15L,21L,135L,10395L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201646Inst : IEnumerable<long>
{
public static readonly long[] Value=A201646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201646.Bytes);
public long this[int i]=>Value[i];

public static A201646Inst Instance=new A201646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201647
{
public static readonly long[] Value={ 3L,5L,7L,9L,11L,15L,21L,165L,693L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201647Inst : IEnumerable<long>
{
public static readonly long[] Value=A201647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201647.Bytes);
public long this[int i]=>Value[i];

public static A201647Inst Instance=new A201647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201648
{
public static readonly long[] Value={ 3L,5L,7L,9L,11L,15L,21L,231L,315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201648Inst : IEnumerable<long>
{
public static readonly long[] Value=A201648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201648.Bytes);
public long this[int i]=>Value[i];

public static A201648Inst Instance=new A201648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201649
{
public static readonly long[] Value={ 3L,5L,7L,9L,11L,15L,33L,45L,385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201649Inst : IEnumerable<long>
{
public static readonly long[] Value=A201649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201649.Bytes);
public long this[int i]=>Value[i];

public static A201649Inst Instance=new A201649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201650
{
public static readonly long[] Value={ 6L,10L,14L,15L,21L,22L,26L,33L,34L,35L,38L,39L,46L,51L,55L,57L,58L,62L,65L,69L,77L,82L,85L,86L,87L,91L,93L,95L,115L,119L,123L,133L,155L,187L,203L,209L,215L,221L,247L,265L,287L,299L,319L,323L,391L,689L,731L,901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201650Inst : IEnumerable<long>
{
public static readonly long[] Value=A201650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201650.Bytes);
public long this[int i]=>Value[i];

public static A201650Inst Instance=new A201650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201651
{
public static readonly long[] Value={ 0L,1L,4L,2L,3L,8L,3L,6L,9L,12L,4L,5L,6L,7L,16L,5L,16L,7L,18L,17L,20L,6L,7L,12L,13L,18L,19L,24L,7L,18L,13L,24L,19L,22L,25L,28L,8L,9L,10L,11L,12L,13L,14L,15L,32L,9L,12L,11L,14L,13L,24L,15L,26L,33L,36L,10L,11L,32L,33L,14L,15L,36L,37L,34L,35L,40L,11L,14L,33L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201651Inst : IEnumerable<long>
{
public static readonly long[] Value=A201651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201651.Bytes);
public long this[int i]=>Value[i];

public static A201651Inst Instance=new A201651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201652
{
public static readonly long[] Value={ 0L,1L,0L,2L,3L,5L,2L,6L,9L,2L,7L,9L,10L,8L,15L,16L,15L,10L,14L,17L,16L,20L,23L,27L,23L,24L,32L,31L,33L,20L,34L,33L,36L,45L,34L,35L,42L,46L,45L,50L,45L,40L,49L,51L,44L,44L,54L,54L,53L,63L,58L,63L,56L,67L,68L,75L,58L,71L,73L,72L,73L,68L,78L,79L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201652Inst : IEnumerable<long>
{
public static readonly long[] Value=A201652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201652.Bytes);
public long this[int i]=>Value[i];

public static A201652Inst Instance=new A201652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201653
{
public static readonly long[] Value={ 3L,1L,2L,4L,5L,1L,9L,9L,1L,2L,5L,0L,1L,3L,8L,7L,6L,9L,3L,9L,6L,8L,8L,0L,1L,9L,6L,5L,0L,1L,1L,6L,2L,4L,9L,9L,4L,1L,4L,4L,8L,7L,8L,6L,3L,8L,0L,3L,1L,2L,5L,4L,7L,4L,3L,5L,3L,6L,7L,5L,6L,7L,1L,9L,1L,1L,5L,1L,2L,3L,6L,6L,8L,1L,2L,3L,6L,1L,2L,8L,1L,1L,4L,9L,6L,9L,6L,4L,8L,0L,0L,1L,1L,1L,0L,0L,4L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201653Inst : IEnumerable<long>
{
public static readonly long[] Value=A201653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201653.Bytes);
public long this[int i]=>Value[i];

public static A201653Inst Instance=new A201653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201654
{
public static readonly long[] Value={ 5L,3L,1L,0L,9L,3L,7L,8L,3L,2L,2L,8L,7L,7L,5L,5L,6L,9L,5L,4L,2L,4L,5L,4L,2L,6L,2L,8L,7L,2L,7L,2L,8L,7L,8L,8L,1L,2L,7L,0L,9L,7L,3L,8L,1L,6L,4L,0L,0L,6L,1L,0L,9L,0L,6L,3L,7L,8L,1L,0L,4L,1L,5L,3L,4L,8L,0L,6L,2L,2L,0L,8L,4L,6L,0L,4L,4L,8L,5L,0L,5L,1L,0L,5L,1L,5L,6L,1L,0L,9L,2L,0L,6L,1L,2L,7L,1L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201654Inst : IEnumerable<long>
{
public static readonly long[] Value=A201654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201654.Bytes);
public long this[int i]=>Value[i];

public static A201654Inst Instance=new A201654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201655
{
public static readonly long[] Value={ 3L,1L,2L,6L,9L,8L,2L,1L,0L,1L,7L,1L,4L,1L,9L,1L,0L,1L,6L,0L,1L,3L,9L,3L,9L,9L,9L,2L,7L,3L,0L,1L,6L,3L,7L,1L,7L,9L,8L,9L,7L,9L,7L,5L,8L,0L,5L,9L,7L,5L,5L,5L,6L,2L,5L,6L,1L,1L,3L,4L,3L,6L,3L,8L,0L,1L,0L,7L,5L,2L,7L,1L,7L,5L,3L,0L,4L,3L,9L,4L,9L,2L,1L,5L,2L,4L,6L,1L,1L,6L,8L,1L,9L,2L,6L,7L,8L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201655Inst : IEnumerable<long>
{
public static readonly long[] Value=A201655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201655.Bytes);
public long this[int i]=>Value[i];

public static A201655Inst Instance=new A201655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201656
{
public static readonly long[] Value={ 5L,0L,7L,2L,6L,2L,1L,9L,9L,3L,4L,9L,1L,0L,3L,7L,7L,8L,2L,6L,5L,8L,1L,2L,1L,4L,7L,7L,2L,6L,4L,0L,4L,1L,9L,7L,6L,3L,8L,5L,8L,6L,3L,1L,5L,1L,4L,1L,8L,5L,6L,3L,4L,8L,1L,6L,0L,9L,3L,5L,5L,8L,2L,8L,6L,9L,5L,1L,8L,0L,6L,5L,0L,1L,7L,6L,0L,7L,2L,3L,7L,3L,1L,3L,4L,4L,3L,8L,5L,7L,9L,3L,3L,9L,6L,1L,2L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201656Inst : IEnumerable<long>
{
public static readonly long[] Value=A201656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201656.Bytes);
public long this[int i]=>Value[i];

public static A201656Inst Instance=new A201656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201657
{
public static readonly long[] Value={ 3L,1L,2L,8L,8L,2L,3L,5L,7L,1L,9L,0L,1L,6L,5L,4L,9L,3L,7L,2L,7L,5L,7L,5L,2L,4L,8L,4L,7L,2L,5L,0L,2L,8L,8L,3L,2L,9L,3L,5L,6L,2L,6L,0L,4L,0L,3L,6L,8L,4L,2L,0L,1L,5L,6L,6L,1L,4L,6L,1L,4L,9L,2L,7L,1L,4L,3L,3L,7L,0L,1L,9L,7L,0L,0L,7L,8L,0L,2L,5L,0L,1L,7L,3L,4L,0L,2L,6L,9L,9L,5L,3L,8L,2L,2L,6L,2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201657Inst : IEnumerable<long>
{
public static readonly long[] Value=A201657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201657.Bytes);
public long this[int i]=>Value[i];

public static A201657Inst Instance=new A201657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201658
{
public static readonly long[] Value={ 4L,8L,7L,1L,8L,2L,5L,7L,2L,5L,4L,6L,1L,3L,4L,3L,6L,0L,7L,6L,7L,5L,4L,2L,4L,3L,0L,0L,4L,3L,0L,6L,4L,2L,2L,0L,7L,8L,2L,6L,9L,9L,4L,2L,5L,6L,4L,3L,6L,3L,7L,9L,2L,2L,0L,6L,4L,9L,1L,8L,6L,8L,7L,1L,6L,1L,6L,4L,4L,1L,1L,2L,2L,6L,7L,3L,6L,5L,8L,8L,1L,0L,1L,3L,7L,2L,0L,6L,4L,4L,3L,8L,3L,5L,5L,6L,8L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201658Inst : IEnumerable<long>
{
public static readonly long[] Value=A201658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201658.Bytes);
public long this[int i]=>Value[i];

public static A201658Inst Instance=new A201658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201659
{
public static readonly long[] Value={ 3L,1L,3L,0L,2L,5L,2L,7L,8L,6L,1L,7L,3L,5L,3L,6L,0L,3L,5L,0L,0L,3L,7L,0L,1L,2L,2L,7L,7L,7L,5L,4L,0L,3L,1L,6L,3L,6L,9L,2L,7L,7L,5L,4L,0L,1L,2L,3L,7L,9L,0L,9L,2L,2L,3L,2L,0L,4L,2L,7L,8L,8L,9L,1L,6L,2L,7L,6L,5L,5L,0L,4L,1L,7L,3L,6L,7L,9L,6L,3L,0L,5L,0L,2L,1L,9L,0L,5L,4L,6L,7L,0L,4L,3L,8L,2L,7L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201659Inst : IEnumerable<long>
{
public static readonly long[] Value=A201659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201659.Bytes);
public long this[int i]=>Value[i];

public static A201659Inst Instance=new A201659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201660
{
public static readonly long[] Value={ 4L,6L,9L,9L,3L,1L,6L,0L,6L,0L,0L,0L,5L,8L,8L,9L,2L,2L,8L,6L,8L,6L,5L,3L,5L,3L,5L,0L,6L,1L,8L,9L,1L,3L,0L,6L,3L,8L,8L,3L,0L,0L,1L,3L,8L,0L,3L,5L,1L,8L,7L,1L,7L,7L,1L,9L,5L,5L,5L,3L,2L,2L,0L,6L,5L,8L,3L,1L,9L,3L,9L,2L,9L,8L,6L,4L,9L,6L,1L,7L,2L,5L,3L,0L,5L,5L,7L,6L,3L,7L,9L,3L,3L,3L,7L,8L,9L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201660Inst : IEnumerable<long>
{
public static readonly long[] Value=A201660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201660.Bytes);
public long this[int i]=>Value[i];

public static A201660Inst Instance=new A201660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201661
{
public static readonly long[] Value={ 1L,4L,1L,8L,3L,5L,5L,6L,1L,8L,5L,4L,4L,9L,4L,2L,6L,5L,6L,3L,3L,5L,3L,0L,6L,2L,3L,6L,8L,7L,2L,0L,8L,1L,9L,1L,9L,3L,3L,6L,0L,8L,6L,0L,7L,1L,9L,4L,4L,2L,3L,1L,8L,8L,8L,4L,1L,9L,9L,5L,2L,7L,3L,9L,8L,4L,1L,1L,0L,9L,3L,7L,8L,2L,6L,9L,7L,4L,6L,2L,0L,7L,9L,6L,9L,2L,0L,3L,5L,0L,8L,7L,4L,1L,3L,1L,5L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201661Inst : IEnumerable<long>
{
public static readonly long[] Value=A201661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201661.Bytes);
public long this[int i]=>Value[i];

public static A201661Inst Instance=new A201661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201662
{
public static readonly long[] Value={ 3L,1L,3L,1L,3L,9L,4L,2L,5L,3L,9L,2L,0L,6L,8L,9L,9L,3L,5L,4L,4L,4L,0L,2L,8L,6L,2L,2L,2L,3L,8L,7L,4L,7L,0L,2L,5L,1L,2L,2L,6L,9L,2L,6L,3L,5L,3L,4L,1L,8L,2L,7L,3L,1L,3L,6L,8L,5L,9L,4L,6L,4L,8L,3L,8L,3L,0L,4L,0L,3L,1L,1L,3L,7L,1L,5L,0L,1L,9L,1L,2L,0L,1L,8L,7L,9L,9L,5L,5L,4L,2L,2L,5L,3L,4L,0L,5L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201662Inst : IEnumerable<long>
{
public static readonly long[] Value=A201662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201662.Bytes);
public long this[int i]=>Value[i];

public static A201662Inst Instance=new A201662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201663
{
public static readonly long[] Value={ 3L,0L,1L,7L,9L,4L,2L,4L,7L,4L,5L,3L,6L,1L,5L,1L,2L,2L,7L,8L,5L,2L,5L,7L,2L,0L,8L,3L,2L,7L,7L,1L,6L,7L,2L,5L,2L,8L,9L,4L,2L,8L,4L,3L,4L,1L,4L,3L,6L,2L,0L,0L,3L,3L,1L,9L,5L,6L,9L,9L,8L,3L,6L,0L,1L,0L,5L,7L,5L,6L,1L,5L,5L,3L,1L,4L,4L,6L,0L,8L,3L,8L,7L,2L,3L,6L,5L,8L,4L,5L,3L,2L,1L,8L,4L,8L,5L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201663Inst : IEnumerable<long>
{
public static readonly long[] Value=A201663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201663.Bytes);
public long this[int i]=>Value[i];

public static A201663Inst Instance=new A201663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201664
{
public static readonly long[] Value={ 1L,0L,3L,9L,2L,4L,5L,6L,5L,0L,7L,9L,7L,2L,4L,7L,7L,9L,3L,2L,3L,1L,9L,2L,9L,3L,2L,7L,2L,4L,2L,4L,8L,3L,7L,3L,0L,0L,0L,0L,8L,0L,9L,3L,7L,9L,8L,9L,5L,8L,9L,7L,9L,8L,3L,3L,6L,4L,4L,7L,1L,6L,0L,5L,2L,3L,5L,7L,4L,2L,6L,8L,0L,3L,4L,7L,4L,2L,1L,1L,9L,0L,7L,0L,0L,8L,4L,2L,0L,0L,0L,4L,3L,2L,9L,1L,5L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201664Inst : IEnumerable<long>
{
public static readonly long[] Value=A201664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201664.Bytes);
public long this[int i]=>Value[i];

public static A201664Inst Instance=new A201664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201665
{
public static readonly long[] Value={ 3L,0L,8L,6L,1L,5L,8L,7L,7L,4L,3L,7L,7L,1L,2L,7L,1L,8L,1L,2L,2L,5L,9L,4L,8L,2L,8L,6L,3L,5L,8L,2L,1L,4L,5L,2L,4L,9L,8L,5L,3L,3L,6L,2L,2L,2L,6L,5L,7L,2L,2L,3L,1L,2L,0L,5L,5L,0L,0L,3L,9L,9L,0L,9L,2L,5L,4L,4L,4L,8L,6L,8L,6L,5L,9L,4L,8L,8L,2L,3L,8L,2L,7L,4L,4L,0L,4L,8L,0L,4L,6L,9L,4L,9L,0L,8L,0L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201665Inst : IEnumerable<long>
{
public static readonly long[] Value=A201665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201665.Bytes);
public long this[int i]=>Value[i];

public static A201665Inst Instance=new A201665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201666
{
public static readonly long[] Value={ 8L,7L,5L,9L,4L,3L,7L,3L,8L,7L,2L,4L,3L,5L,6L,4L,4L,1L,5L,4L,9L,4L,6L,2L,8L,6L,7L,9L,5L,5L,3L,0L,3L,8L,7L,6L,3L,2L,3L,3L,7L,0L,6L,0L,9L,4L,6L,0L,1L,1L,0L,6L,5L,5L,1L,5L,3L,7L,4L,4L,6L,4L,2L,5L,8L,2L,0L,8L,7L,3L,4L,0L,1L,5L,9L,7L,0L,3L,5L,4L,4L,2L,8L,6L,7L,8L,8L,9L,5L,6L,9L,7L,2L,2L,4L,6L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201666Inst : IEnumerable<long>
{
public static readonly long[] Value=A201666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201666.Bytes);
public long this[int i]=>Value[i];

public static A201666Inst Instance=new A201666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201667
{
public static readonly long[] Value={ 3L,1L,0L,5L,7L,9L,1L,2L,2L,9L,3L,6L,3L,0L,8L,2L,2L,7L,7L,9L,2L,8L,9L,6L,7L,9L,3L,1L,6L,1L,4L,3L,1L,4L,3L,0L,3L,5L,9L,5L,3L,6L,9L,7L,6L,5L,5L,5L,2L,9L,1L,7L,0L,3L,3L,2L,2L,8L,1L,2L,7L,8L,5L,1L,1L,4L,2L,9L,5L,2L,0L,6L,7L,4L,2L,4L,0L,0L,2L,7L,5L,4L,0L,8L,2L,0L,1L,2L,1L,2L,0L,0L,3L,9L,9L,4L,5L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201667Inst : IEnumerable<long>
{
public static readonly long[] Value=A201667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201667.Bytes);
public long this[int i]=>Value[i];

public static A201667Inst Instance=new A201667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201668
{
public static readonly long[] Value={ 7L,7L,8L,4L,7L,6L,7L,7L,7L,2L,7L,7L,5L,9L,4L,2L,3L,1L,2L,9L,0L,0L,3L,5L,2L,7L,9L,9L,8L,6L,7L,2L,6L,8L,7L,7L,9L,8L,6L,1L,2L,4L,8L,6L,5L,6L,2L,6L,2L,4L,6L,1L,1L,5L,6L,8L,0L,0L,6L,2L,0L,9L,6L,5L,7L,7L,6L,3L,2L,2L,1L,7L,5L,3L,8L,6L,6L,8L,9L,4L,8L,6L,1L,4L,6L,8L,3L,7L,2L,9L,9L,1L,2L,4L,5L,4L,7L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201668Inst : IEnumerable<long>
{
public static readonly long[] Value=A201668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201668.Bytes);
public long this[int i]=>Value[i];

public static A201668Inst Instance=new A201668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201669
{
public static readonly long[] Value={ 3L,1L,1L,5L,1L,4L,6L,1L,1L,6L,0L,4L,0L,3L,6L,1L,2L,6L,7L,1L,5L,1L,9L,3L,1L,5L,4L,7L,4L,5L,0L,3L,2L,5L,8L,9L,2L,0L,0L,2L,1L,8L,5L,9L,2L,8L,9L,5L,2L,8L,0L,5L,4L,1L,6L,1L,9L,3L,4L,0L,5L,8L,9L,2L,4L,4L,2L,1L,3L,9L,6L,5L,0L,1L,1L,7L,1L,2L,4L,8L,6L,6L,3L,9L,9L,7L,8L,0L,0L,3L,8L,5L,3L,4L,9L,5L,9L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201669Inst : IEnumerable<long>
{
public static readonly long[] Value=A201669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201669.Bytes);
public long this[int i]=>Value[i];

public static A201669Inst Instance=new A201669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201670
{
public static readonly long[] Value={ 7L,1L,1L,5L,3L,3L,8L,8L,8L,3L,6L,7L,1L,5L,1L,4L,9L,9L,2L,4L,6L,7L,9L,6L,3L,0L,7L,4L,2L,8L,2L,1L,2L,5L,5L,6L,7L,7L,2L,7L,9L,9L,2L,0L,5L,9L,3L,7L,5L,3L,9L,0L,7L,5L,8L,0L,6L,0L,8L,8L,5L,4L,9L,8L,9L,2L,8L,4L,1L,5L,5L,0L,8L,2L,3L,4L,4L,8L,5L,4L,3L,7L,4L,6L,3L,2L,1L,8L,4L,5L,9L,7L,9L,8L,6L,8L,3L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201670Inst : IEnumerable<long>
{
public static readonly long[] Value=A201670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201670.Bytes);
public long this[int i]=>Value[i];

public static A201670Inst Instance=new A201670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201671
{
public static readonly long[] Value={ 3L,1L,2L,0L,6L,2L,2L,9L,9L,3L,0L,8L,6L,9L,1L,8L,8L,0L,5L,1L,4L,1L,2L,7L,3L,4L,2L,4L,6L,2L,3L,0L,6L,6L,0L,0L,2L,1L,7L,0L,0L,3L,5L,6L,2L,4L,5L,2L,7L,7L,9L,7L,3L,7L,1L,1L,0L,9L,8L,7L,8L,5L,9L,1L,2L,2L,8L,1L,0L,3L,9L,7L,7L,4L,6L,4L,5L,3L,7L,4L,0L,0L,1L,4L,8L,8L,0L,6L,3L,0L,8L,4L,4L,1L,1L,7L,5L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201671Inst : IEnumerable<long>
{
public static readonly long[] Value=A201671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201671.Bytes);
public long this[int i]=>Value[i];

public static A201671Inst Instance=new A201671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201672
{
public static readonly long[] Value={ 6L,6L,1L,7L,3L,6L,5L,5L,7L,1L,6L,9L,7L,4L,4L,2L,2L,6L,2L,4L,1L,8L,2L,9L,8L,3L,7L,0L,9L,4L,0L,0L,2L,6L,0L,7L,7L,4L,7L,4L,7L,9L,8L,8L,1L,3L,8L,2L,5L,3L,8L,4L,1L,0L,2L,5L,2L,2L,4L,5L,7L,7L,6L,0L,7L,8L,5L,2L,8L,6L,9L,1L,9L,6L,5L,1L,3L,1L,9L,6L,9L,6L,0L,3L,3L,1L,1L,1L,0L,9L,3L,6L,1L,5L,6L,2L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201672Inst : IEnumerable<long>
{
public static readonly long[] Value=A201672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201672.Bytes);
public long this[int i]=>Value[i];

public static A201672Inst Instance=new A201672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201673
{
public static readonly long[] Value={ 3L,1L,2L,4L,2L,1L,9L,9L,6L,2L,7L,0L,6L,0L,8L,1L,5L,9L,4L,8L,9L,8L,9L,0L,6L,2L,1L,0L,9L,2L,0L,2L,8L,5L,4L,6L,6L,3L,5L,1L,1L,0L,2L,3L,7L,1L,5L,8L,1L,0L,4L,2L,3L,4L,1L,4L,5L,4L,2L,2L,1L,2L,3L,6L,0L,3L,6L,9L,3L,1L,5L,6L,3L,5L,3L,5L,6L,3L,8L,9L,6L,0L,0L,3L,7L,0L,8L,8L,0L,2L,3L,5L,9L,8L,9L,9L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201673Inst : IEnumerable<long>
{
public static readonly long[] Value=A201673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201673.Bytes);
public long this[int i]=>Value[i];

public static A201673Inst Instance=new A201673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201674
{
public static readonly long[] Value={ 6L,2L,2L,7L,2L,7L,0L,9L,4L,3L,1L,3L,6L,9L,5L,1L,0L,3L,7L,9L,5L,0L,3L,9L,9L,3L,9L,2L,8L,6L,5L,2L,2L,8L,9L,0L,1L,3L,8L,6L,1L,8L,3L,1L,8L,7L,7L,3L,8L,7L,6L,7L,8L,7L,6L,6L,7L,6L,5L,5L,3L,8L,3L,7L,6L,3L,8L,3L,2L,5L,8L,1L,7L,2L,4L,1L,3L,6L,6L,9L,8L,0L,6L,9L,0L,3L,0L,9L,2L,9L,6L,2L,6L,6L,8L,6L,3L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201674Inst : IEnumerable<long>
{
public static readonly long[] Value=A201674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201674.Bytes);
public long this[int i]=>Value[i];

public static A201674Inst Instance=new A201674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201675
{
public static readonly long[] Value={ 3L,1L,2L,6L,7L,6L,3L,3L,5L,4L,8L,1L,7L,8L,4L,3L,9L,5L,8L,3L,2L,4L,7L,1L,0L,5L,4L,3L,0L,4L,1L,3L,9L,3L,5L,0L,0L,8L,6L,9L,5L,6L,0L,6L,7L,8L,0L,4L,2L,4L,0L,6L,1L,3L,9L,9L,3L,3L,0L,3L,2L,1L,0L,4L,5L,3L,3L,0L,3L,9L,5L,9L,0L,7L,3L,7L,1L,4L,3L,9L,0L,9L,5L,1L,1L,5L,5L,1L,5L,2L,7L,8L,9L,8L,4L,2L,3L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201675Inst : IEnumerable<long>
{
public static readonly long[] Value=A201675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201675.Bytes);
public long this[int i]=>Value[i];

public static A201675Inst Instance=new A201675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201676
{
public static readonly long[] Value={ 5L,9L,1L,0L,3L,8L,4L,5L,6L,3L,4L,1L,7L,9L,2L,3L,5L,6L,7L,5L,1L,1L,9L,5L,4L,8L,1L,8L,2L,5L,4L,6L,8L,7L,4L,6L,7L,5L,9L,3L,3L,3L,7L,2L,2L,1L,8L,8L,2L,7L,7L,1L,7L,2L,8L,0L,7L,2L,3L,4L,1L,2L,8L,2L,6L,1L,1L,6L,7L,4L,3L,3L,0L,0L,3L,1L,5L,1L,9L,7L,1L,8L,0L,8L,7L,5L,5L,4L,1L,5L,4L,6L,9L,6L,5L,4L,3L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201676Inst : IEnumerable<long>
{
public static readonly long[] Value=A201676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201676.Bytes);
public long this[int i]=>Value[i];

public static A201676Inst Instance=new A201676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201677
{
public static readonly long[] Value={ 3L,1L,2L,8L,6L,5L,7L,0L,1L,3L,8L,5L,7L,7L,3L,5L,9L,2L,9L,9L,8L,3L,4L,0L,4L,0L,4L,8L,4L,4L,0L,2L,8L,6L,7L,8L,1L,6L,5L,0L,0L,8L,6L,5L,6L,6L,6L,3L,7L,0L,4L,3L,3L,7L,2L,8L,4L,3L,8L,9L,4L,3L,9L,1L,0L,7L,2L,2L,4L,4L,1L,9L,4L,4L,2L,4L,5L,7L,5L,1L,9L,4L,0L,5L,4L,9L,2L,2L,4L,4L,3L,1L,5L,6L,4L,1L,0L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201677Inst : IEnumerable<long>
{
public static readonly long[] Value=A201677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201677.Bytes);
public long this[int i]=>Value[i];

public static A201677Inst Instance=new A201677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201678
{
public static readonly long[] Value={ 5L,6L,4L,5L,9L,4L,5L,2L,3L,3L,9L,4L,6L,0L,4L,5L,6L,0L,3L,4L,5L,4L,1L,7L,0L,5L,0L,8L,7L,9L,3L,5L,2L,6L,3L,2L,1L,6L,2L,2L,5L,7L,5L,4L,9L,8L,7L,9L,6L,9L,6L,8L,8L,2L,2L,4L,7L,1L,9L,5L,3L,0L,8L,7L,5L,9L,4L,9L,2L,5L,6L,3L,9L,7L,7L,8L,6L,7L,4L,0L,3L,4L,1L,3L,0L,6L,8L,3L,8L,6L,8L,7L,2L,9L,9L,0L,0L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201678Inst : IEnumerable<long>
{
public static readonly long[] Value=A201678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201678.Bytes);
public long this[int i]=>Value[i];

public static A201678Inst Instance=new A201678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201679
{
public static readonly long[] Value={ 3L,1L,3L,0L,1L,2L,1L,7L,4L,4L,3L,2L,7L,9L,1L,0L,3L,1L,7L,3L,8L,6L,1L,9L,3L,8L,0L,6L,4L,2L,2L,8L,0L,4L,6L,4L,6L,8L,7L,3L,8L,2L,7L,3L,1L,0L,5L,6L,8L,6L,3L,4L,8L,6L,1L,1L,4L,2L,4L,1L,0L,1L,2L,3L,8L,5L,4L,7L,6L,3L,5L,5L,9L,9L,3L,5L,9L,7L,7L,8L,2L,7L,4L,2L,0L,6L,1L,6L,3L,8L,9L,3L,5L,2L,0L,2L,2L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201679Inst : IEnumerable<long>
{
public static readonly long[] Value=A201679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201679.Bytes);
public long this[int i]=>Value[i];

public static A201679Inst Instance=new A201679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201680
{
public static readonly long[] Value={ 5L,4L,2L,0L,6L,4L,4L,8L,2L,6L,8L,2L,1L,6L,0L,4L,8L,3L,7L,5L,5L,0L,4L,3L,1L,5L,2L,1L,6L,9L,4L,7L,6L,5L,3L,3L,5L,7L,0L,2L,8L,4L,4L,3L,5L,7L,3L,5L,4L,2L,6L,4L,7L,6L,8L,9L,4L,9L,1L,7L,4L,5L,8L,1L,3L,7L,9L,5L,8L,0L,4L,9L,3L,7L,6L,5L,5L,6L,3L,1L,9L,0L,1L,5L,3L,8L,3L,4L,5L,9L,3L,2L,1L,4L,3L,7L,3L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201680Inst : IEnumerable<long>
{
public static readonly long[] Value=A201680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201680.Bytes);
public long this[int i]=>Value[i];

public static A201680Inst Instance=new A201680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201681
{
public static readonly long[] Value={ 3L,1L,3L,1L,2L,8L,8L,4L,6L,9L,6L,9L,3L,5L,6L,2L,4L,9L,3L,8L,0L,4L,5L,8L,5L,0L,5L,2L,0L,4L,7L,5L,3L,5L,8L,7L,7L,4L,0L,4L,4L,0L,0L,2L,4L,9L,2L,7L,1L,8L,5L,5L,6L,9L,0L,5L,3L,8L,6L,1L,2L,3L,0L,1L,6L,4L,4L,7L,2L,9L,1L,9L,2L,1L,8L,1L,3L,4L,8L,1L,9L,0L,2L,4L,9L,1L,8L,9L,9L,5L,3L,7L,0L,9L,1L,6L,8L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201681Inst : IEnumerable<long>
{
public static readonly long[] Value=A201681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201681.Bytes);
public long this[int i]=>Value[i];

public static A201681Inst Instance=new A201681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201682
{
public static readonly long[] Value={ 1L,7L,3L,6L,0L,3L,2L,4L,0L,9L,7L,3L,9L,9L,9L,5L,0L,6L,5L,4L,1L,8L,3L,1L,1L,0L,7L,7L,4L,0L,4L,2L,8L,5L,2L,3L,1L,2L,7L,7L,2L,6L,5L,8L,9L,8L,1L,9L,9L,8L,4L,6L,3L,6L,6L,4L,4L,7L,4L,4L,7L,6L,3L,7L,1L,9L,2L,1L,9L,4L,3L,1L,8L,7L,3L,3L,2L,6L,5L,0L,3L,8L,5L,1L,7L,0L,1L,7L,2L,1L,4L,3L,4L,4L,6L,9L,7L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201682Inst : IEnumerable<long>
{
public static readonly long[] Value=A201682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201682.Bytes);
public long this[int i]=>Value[i];

public static A201682Inst Instance=new A201682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201683
{
public static readonly long[] Value={ 2L,9L,9L,7L,9L,9L,6L,9L,2L,0L,1L,8L,1L,6L,9L,5L,2L,6L,0L,6L,6L,1L,8L,2L,3L,3L,3L,1L,2L,5L,4L,1L,2L,5L,8L,8L,7L,6L,5L,4L,9L,8L,3L,3L,6L,8L,1L,2L,0L,0L,3L,2L,4L,7L,4L,8L,8L,3L,6L,5L,9L,5L,1L,9L,3L,1L,0L,9L,4L,8L,3L,3L,2L,2L,1L,8L,8L,5L,2L,1L,7L,8L,8L,0L,8L,7L,8L,1L,3L,6L,3L,4L,0L,8L,0L,2L,2L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201683Inst : IEnumerable<long>
{
public static readonly long[] Value=A201683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201683.Bytes);
public long this[int i]=>Value[i];

public static A201683Inst Instance=new A201683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201684
{
public static readonly long[] Value={ 1L,-1L,0L,0L,4L,34L,274L,2312L,21034L,207790L,2228892L,25890642L,324477994L,4370180744L,63007469346L,968847653702L,15834053988732L,274170226919434L,5015004366420178L,96645631069563928L,1957433140982004026L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201684Inst : IEnumerable<long>
{
public static readonly long[] Value=A201684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201684.Bytes);
public long this[int i]=>Value[i];

public static A201684Inst Instance=new A201684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201685
{
public static readonly long[] Value={ 1L,2L,1L,9L,6L,2L,64L,48L,24L,6L,625L,500L,300L,120L,24L,7776L,6480L,4320L,2160L,720L,120L,117649L,100842L,72030L,41160L,17640L,5040L,720L,2097152L,1835008L,1376256L,860160L,430080L,161280L,40320L,5040L,43046721L,38263752L,29760696L,19840464L,11022480L,4898880L,1632960L,362880L,40320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201685Inst : IEnumerable<long>
{
public static readonly long[] Value=A201685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201685.Bytes);
public long this[int i]=>Value[i];

public static A201685Inst Instance=new A201685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201686
{
public static readonly long[] Value={ -1L,-1L,0L,1L,4L,8L,18L,33L,68L,124L,250L,460L,922L,1714L,3430L,6433L,12868L,24308L,48618L,92376L,184754L,352714L,705430L,1352076L,2704154L,5200298L,10400598L,20058298L,40116598L,77558758L,155117518L,300540193L,601080388L,1166803108L,2333606218L,4537567648L,9075135298L,17672631898L,35345263798L,68923264408L,137846528818L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201686Inst : IEnumerable<long>
{
public static readonly long[] Value=A201686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201686.Bytes);
public long this[int i]=>Value[i];

public static A201686Inst Instance=new A201686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201687
{
public static readonly long[] Value={ 0L,2L,2L,6L,14L,44L,134L,462L,1616L,6062L,23306L,93996L,389102L,1671158L,7360256L,33418374L,155359922L,741476492L,3617591462L,18065875422L,92087408048L,479382896030L,2543670789962L,13759520646636L,75769638724382L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201687Inst : IEnumerable<long>
{
public static readonly long[] Value=A201687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201687.Bytes);
public long this[int i]=>Value[i];

public static A201687Inst Instance=new A201687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201688
{
public static readonly long[] Value={ 43L,67L,139L,307L,379L,547L,859L,1699L,1867L,3499L,3739L,4507L,5059L,5347L,6907L,10627L,11467L,18787L,29947L,32059L,32779L,39619L,49747L,57139L,58099L,66067L,72379L,73459L,78979L,80107L,96739L,97987L,109579L,120427L,134707L,151339L,157627L,187507L,218107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201688Inst : IEnumerable<long>
{
public static readonly long[] Value=A201688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201688.Bytes);
public long this[int i]=>Value[i];

public static A201688Inst Instance=new A201688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201689
{
public static readonly long[] Value={ 0L,1L,1L,4L,9L,31L,94L,337L,1185L,4540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201689Inst : IEnumerable<long>
{
public static readonly long[] Value=A201689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201689.Bytes);
public long this[int i]=>Value[i];

public static A201689Inst Instance=new A201689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201690
{
public static readonly long[] Value={ 2L,7L,35L,218L,1598L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201690Inst : IEnumerable<long>
{
public static readonly long[] Value=A201690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201690.Bytes);
public long this[int i]=>Value[i];

public static A201690Inst Instance=new A201690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201691
{
public static readonly long[] Value={ 1L,1L,2L,4L,13L,58L,299L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201691Inst : IEnumerable<long>
{
public static readonly long[] Value=A201691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201691.Bytes);
public long this[int i]=>Value[i];

public static A201691Inst Instance=new A201691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201692
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,23L,110L,631L,4218L,32221L,276896L,2643883L,27768955L,318174363L,3949415431L,52794067318L,756137263377L,11551672922816L,187507250145806L,3222662529113641L,58464560588277289L,1116469710152742025L,BigInteger.Parse("22386721651323946628"),BigInteger.Parse("470259350616967829363") };
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
public class A201692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201692Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201692.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201692Inst Instance=new A201692Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201693
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,23L,110L,632L,4237L,32465L,279828L,2679950L,28232972L,324470844L,4039771856L,54165468774L,778128659247L,11923645252411L,194131328012012L,3346615262190736L,60897160676005110L,1166446154857250412L,BigInteger.Parse("23459656378909613446"),BigInteger.Parse("494290181112325561351") };
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
public class A201693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201693Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201693.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201693Inst Instance=new A201693Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201694
{
public static readonly long[] Value={ 3L,10L,116L,4998L,930564L,795339012L,3262897246338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201694Inst : IEnumerable<long>
{
public static readonly long[] Value=A201694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201694.Bytes);
public long this[int i]=>Value[i];

public static A201694Inst Instance=new A201694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201695
{
public static readonly long[] Value={ 3L,18L,116L,395L,989L,2068L,3838L,6541L,10455L,15894L,23208L,32783L,45041L,60440L,79474L,102673L,130603L,163866L,203100L,248979L,302213L,363548L,433766L,513685L,604159L,706078L,820368L,947991L,1089945L,1247264L,1421018L,1612313L,1822291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201695Inst : IEnumerable<long>
{
public static readonly long[] Value=A201695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201695.Bytes);
public long this[int i]=>Value[i];

public static A201695Inst Instance=new A201695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201696
{
public static readonly long[] Value={ 3L,27L,395L,4998L,35390L,167625L,607919L,1826778L,4775228L,11211034L,24167306L,48600665L,92261185L,166831642L,289389192L,484248471L,785251265L,1238574341L,1906133765L,2869671064L,4235613920L,6140811719L,8759254221L,12309889872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201696Inst : IEnumerable<long>
{
public static readonly long[] Value=A201696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201696.Bytes);
public long this[int i]=>Value[i];

public static A201696Inst Instance=new A201696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201697
{
public static readonly long[] Value={ 3L,37L,989L,35390L,930564L,14268351L,142436489L,1034563890L,5898023820L,27803725006L,112491133042L,401503571755L,1290797861479L,3798580774670L,10363168825912L,26478119492263L,63883865534377L,146539437113683L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201697Inst : IEnumerable<long>
{
public static readonly long[] Value=A201697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201697.Bytes);
public long this[int i]=>Value[i];

public static A201697Inst Instance=new A201697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201698
{
public static readonly long[] Value={ 3L,48L,2068L,167625L,14268351L,795339012L,27102769900L,615440785548L,10106227864338L,127441635892627L,1290114077123683L,10846768837607450L,77797729805055016L,486398599750167133L,2697872438447793007L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201698Inst : IEnumerable<long>
{
public static readonly long[] Value=A201698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201698.Bytes);
public long this[int i]=>Value[i];

public static A201698Inst Instance=new A201698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201699
{
public static readonly BigInteger[] Value={ 3L,60L,3838L,607919L,142436489L,27102769900L,3262897246338L,253484699853930L,13657827589827288L,542530203631847499L,16634470482072064655UL,BigInteger.Parse("407700696414920035296"),BigInteger.Parse("8211702473582080609860"),BigInteger.Parse("139013768818199221546289") };
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
public class A201699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201699Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201699.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201699Inst Instance=new A201699Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201700
{
public static readonly long[] Value={ 3L,3L,3L,3L,10L,3L,3L,18L,18L,3L,3L,27L,116L,27L,3L,3L,37L,395L,395L,37L,3L,3L,48L,989L,4998L,989L,48L,3L,3L,60L,2068L,35390L,35390L,2068L,60L,3L,3L,73L,3838L,167625L,930564L,167625L,3838L,73L,3L,3L,87L,6541L,607919L,14268351L,14268351L,607919L,6541L,87L,3L,3L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201700Inst : IEnumerable<long>
{
public static readonly long[] Value=A201700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201700.Bytes);
public long this[int i]=>Value[i];

public static A201700Inst Instance=new A201700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201701
{
public static readonly long[] Value={ 1L,1L,0L,2L,1L,0L,4L,3L,0L,0L,8L,8L,1L,0L,0L,16L,20L,5L,0L,0L,0L,32L,48L,18L,1L,0L,0L,0L,64L,112L,56L,7L,0L,0L,0L,0L,128L,256L,160L,32L,1L,0L,0L,0L,0L,256L,576L,432L,120L,9L,0L,0L,0L,0L,0L,512L,1280L,1120L,400L,50L,1L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201701Inst : IEnumerable<long>
{
public static readonly long[] Value=A201701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201701.Bytes);
public long this[int i]=>Value[i];

public static A201701Inst Instance=new A201701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201702
{
public static readonly ulong[] Value={ 0L,0L,0L,0L,1L,1L,1L,2L,5L,15L,64L,342L,2321L,18578L,168287L,1656209L,17288336L,188006362L,2105867058L,24108331027L,280638347609L,3310098377912L,39462525169310L,474697793413215L,5754095507495584L,70216415130786725L,861924378411516159L,10636562125193377459UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201702Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A201702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201702.Bytes);
public ulong this[int i]=>Value[i];

public static A201702Inst Instance=new A201702Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201703
{
public static readonly long[] Value={ 1L,2L,1L,4L,2L,2L,8L,4L,4L,2L,16L,8L,8L,5L,4L,32L,16L,16L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201703Inst : IEnumerable<long>
{
public static readonly long[] Value=A201703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201703.Bytes);
public long this[int i]=>Value[i];

public static A201703Inst Instance=new A201703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201704
{
public static readonly long[] Value={ 7L,79L,5839L,7207L,8719L,18439L,25999L,28807L,41479L,45007L,48679L,93319L,109519L,121039L,145807L,180007L,209959L,294919L,313639L,342799L,415879L,472399L,583207L,720007L,734479L,778759L,935719L,952207L,1216807L,1331719L,1391119L,1431439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201704Inst : IEnumerable<long>
{
public static readonly long[] Value=A201704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201704.Bytes);
public long this[int i]=>Value[i];

public static A201704Inst Instance=new A201704Inst();

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