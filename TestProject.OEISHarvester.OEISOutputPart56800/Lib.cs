using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A064345
{
public static readonly BigInteger[] Value={ 1L,1L,14L,833L,83006L,10213854L,1404124008L,206635997673L,31844571309110L,5073749573133710L,829012595472718580L,BigInteger.Parse("138151786440502006186"),BigInteger.Parse("23390450962161609522028"),BigInteger.Parse("4012173837912126230070832") };
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
public class A064345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064345Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A064345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064345.Bytes);
public BigInteger this[int i]=>Value[i];

public static A064345Inst Instance=new A064345Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064346
{
public static readonly BigInteger[] Value={ 1L,1L,16L,1216L,157696L,25317376L,4543676416L,873117515776L,175715349692416L,36562356662173696L,7802094251017240576L,BigInteger.Parse("1698089607837490610176"),BigInteger.Parse("375493988522687218057216"),BigInteger.Parse("84121868091432283370684416") };
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
public class A064346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064346Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A064346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064346.Bytes);
public BigInteger this[int i]=>Value[i];

public static A064346Inst Instance=new A064346Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064347
{
public static readonly BigInteger[] Value={ 1L,1L,18L,1701L,278478L,56542698L,12838905972L,3121895416077L,795077021525526L,209364566760439038L,BigInteger.Parse("56540432581528153788"),BigInteger.Parse("15573764062988183490786"),BigInteger.Parse("4358381303784085630372620"),BigInteger.Parse("1235729432868053981694246324") };
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
public class A064347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064347Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A064347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064347.Bytes);
public BigInteger this[int i]=>Value[i];

public static A064347Inst Instance=new A064347Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064348
{
public static readonly long[] Value={ 14L,44L,1334L,1634L,2295L,2685L,3195L,17255L,33998L,42818L,45716L,79316L,84134L,122073L,124676L,125811L,166934L,239499L,289454L,294151L,383594L,440013L,544334L,605985L,649154L,655005L,736515L,1163624L,1325511L,1364104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064348Inst : IEnumerable<long>
{
public static readonly long[] Value=A064348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064348.Bytes);
public long this[int i]=>Value[i];

public static A064348Inst Instance=new A064348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064349
{
public static readonly long[] Value={ 1L,1L,3L,6L,13L,19L,37L,58L,97L,143L,227L,328L,492L,688L,992L,1364L,1903L,2551L,3473L,4586L,6097L,7911L,10333L,13226L,16988L,21454L,27172L,33938L,42437L,52423L,64833L,79354L,97130L,117824L,142930L,172018L,206925L,247179L,295105L,350154L,415124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064349Inst : IEnumerable<long>
{
public static readonly long[] Value=A064349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064349.Bytes);
public long this[int i]=>Value[i];

public static A064349Inst Instance=new A064349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064350
{
public static readonly BigInteger[] Value={ 1L,6L,360L,60480L,19958400L,10897286400L,8892185702400L,10137091700736000L,15388105201717248000UL,BigInteger.Parse("30006805143348633600000"),BigInteger.Parse("73096577329197271449600000"),BigInteger.Parse("217535414131691079834009600000") };
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
public class A064350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064350Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A064350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064350.Bytes);
public BigInteger this[int i]=>Value[i];

public static A064350Inst Instance=new A064350Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064351
{
public static readonly long[] Value={ 6867L,57075L,113283L,155708L,230124L,244035L,250995L,351075L,437715L,508563L,667628L,742508L,1065843L,1095315L,1166067L,1302092L,1379907L,1431212L,1496780L,2373452L,2519343L,2978787L,2992220L,3164524L,3583772L,4799011L,4826835L,5103875L,5140316L,5535404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064351Inst : IEnumerable<long>
{
public static readonly long[] Value=A064351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064351.Bytes);
public long this[int i]=>Value[i];

public static A064351Inst Instance=new A064351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064352
{
public static readonly BigInteger[] Value={ 1L,3L,30L,504L,11880L,360360L,13366080L,586051200L,29654190720L,1700755056000L,109027350432000L,7725366544896000L,599555620984320000L,BigInteger.Parse("50578512186237235200"),BigInteger.Parse("4608264443634948096000"),BigInteger.Parse("450974292794344230912000") };
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
public class A064352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064352Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A064352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064352.Bytes);
public BigInteger this[int i]=>Value[i];

public static A064352Inst Instance=new A064352Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064353
{
public static readonly long[] Value={ 1L,3L,3L,3L,1L,1L,1L,3L,3L,3L,1L,3L,1L,3L,3L,3L,1L,1L,1L,3L,3L,3L,1L,3L,3L,3L,1L,3L,3L,3L,1L,1L,1L,3L,3L,3L,1L,3L,1L,3L,3L,3L,1L,1L,1L,3L,3L,3L,1L,3L,3L,3L,1L,1L,1L,3L,3L,3L,1L,3L,3L,3L,1L,1L,1L,3L,3L,3L,1L,3L,1L,3L,3L,3L,1L,1L,1L,3L,3L,3L,1L,3L,3L,3L,1L,3L,3L,3L,1L,1L,1L,3L,3L,3L,1L,3L,1L,3L,3L,3L,1L,1L,1L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064353Inst : IEnumerable<long>
{
public static readonly long[] Value=A064353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064353.Bytes);
public long this[int i]=>Value[i];

public static A064353Inst Instance=new A064353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064354
{
public static readonly long[] Value={ 1L,4L,12L,24L,72L,360L,2520L,5040L,55440L,277200L,3603600L,10810800L,21621600L,367567200L,6983776800L,160626866400L,1124388064800L,32607253879200L,1010824870255200L,2021649740510400L,74801040398884800L,224403121196654400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064354Inst : IEnumerable<long>
{
public static readonly long[] Value=A064354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064354.Bytes);
public long this[int i]=>Value[i];

public static A064354Inst Instance=new A064354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064355
{
public static readonly long[] Value={ 2L,2L,2L,4L,6L,10L,18L,32L,56L,102L,186L,340L,630L,1170L,2182L,4096L,7710L,14560L,27594L,52428L,99858L,190650L,364722L,699040L,1342176L,2581110L,4971008L,9586980L,18512790L,35791358L,69273666L,134217728L,260300986L,505290270L,981706806L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064355Inst : IEnumerable<long>
{
public static readonly long[] Value=A064355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064355.Bytes);
public long this[int i]=>Value[i];

public static A064355Inst Instance=new A064355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064356
{
public static readonly long[] Value={ 3L,8L,15L,23L,34L,47L,62L,79L,97L,118L,141L,166L,192L,221L,253L,285L,320L,357L,395L,436L,479L,524L,570L,621L,670L,724L,778L,835L,892L,955L,1018L,1082L,1149L,1217L,1289L,1363L,1436L,1513L,1591L,1673L,1754L,1842L,1927L,2016L,2107L,2200L,2294L,2394L,2491L,2591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064356Inst : IEnumerable<long>
{
public static readonly long[] Value=A064356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064356.Bytes);
public long this[int i]=>Value[i];

public static A064356Inst Instance=new A064356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064357
{
public static readonly long[] Value={ 1L,2L,4L,3L,7L,5L,6L,11L,10L,8L,9L,15L,16L,21L,14L,12L,28L,13L,20L,36L,22L,45L,27L,19L,55L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064357Inst : IEnumerable<long>
{
public static readonly long[] Value=A064357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064357.Bytes);
public long this[int i]=>Value[i];

public static A064357Inst Instance=new A064357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064358
{
public static readonly long[] Value={ 1L,2L,3L,5L,9L,4L,17L,6L,33L,10L,65L,7L,129L,18L,11L,257L,513L,34L,1025L,13L,19L,66L,2049L,8L,4097L,130L,35L,21L,8193L,12L,16385L,258L,67L,514L,25L,37L,32769L,1026L,131L,14L,65537L,20L,131073L,69L,41L,2050L,262145L,259L,524289L,4098L,515L,133L,1048577L,36L,73L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064358Inst : IEnumerable<long>
{
public static readonly long[] Value=A064358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064358.Bytes);
public long this[int i]=>Value[i];

public static A064358Inst Instance=new A064358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064359
{
public static readonly long[] Value={ 1L,2L,5L,3L,7L,11L,23L,4L,9L,14L,29L,19L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064359Inst : IEnumerable<long>
{
public static readonly long[] Value=A064359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064359.Bytes);
public long this[int i]=>Value[i];

public static A064359Inst Instance=new A064359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064360
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,10L,6L,20L,7L,34L,11L,52L,15L,9L,21L,8L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064360Inst : IEnumerable<long>
{
public static readonly long[] Value=A064360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064360.Bytes);
public long this[int i]=>Value[i];

public static A064360Inst Instance=new A064360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064361
{
public static readonly long[] Value={ 1L,2L,4L,12L,18L,22L,30L,42L,52L,82L,84L,126L,142L,174L,178L,180L,186L,192L,198L,216L,220L,240L,252L,262L,298L,316L,348L,382L,400L,406L,412L,438L,478L,480L,492L,520L,522L,532L,546L,576L,604L,610L,630L,700L,730L,744L,784L,790L,832L,840L,852L,862L,904L,916L,940L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064361Inst : IEnumerable<long>
{
public static readonly long[] Value=A064361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064361.Bytes);
public long this[int i]=>Value[i];

public static A064361Inst Instance=new A064361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064362
{
public static readonly long[] Value={ 5L,8L,10L,12L,13L,15L,16L,17L,20L,21L,24L,25L,26L,28L,30L,32L,33L,34L,35L,36L,37L,39L,40L,42L,45L,48L,50L,51L,52L,53L,55L,56L,57L,60L,61L,63L,64L,65L,66L,68L,69L,70L,72L,73L,74L,75L,77L,78L,80L,84L,85L,87L,88L,89L,90L,91L,92L,93L,95L,96L,97L,99L,100L,102L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064362Inst : IEnumerable<long>
{
public static readonly long[] Value=A064362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064362.Bytes);
public long this[int i]=>Value[i];

public static A064362Inst Instance=new A064362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064363
{
public static readonly long[] Value={ 0L,2L,14L,51L,133L,289L,547L,954L,1546L,2380L,3508L,5005L,6915L,9347L,12353L,16028L,20468L,25790L,32054L,39427L,47965L,57833L,69155L,82082L,96682L,113192L,131720L,152429L,175467L,201075L,229305L,260492L,294700L,332182L,373138L,417751L,466201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064363Inst : IEnumerable<long>
{
public static readonly long[] Value=A064363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064363.Bytes);
public long this[int i]=>Value[i];

public static A064363Inst Instance=new A064363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064364
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,9L,7L,10L,12L,15L,16L,18L,14L,20L,24L,27L,21L,25L,30L,32L,36L,11L,28L,40L,45L,48L,54L,35L,42L,50L,60L,64L,72L,81L,13L,22L,56L,63L,75L,80L,90L,96L,108L,33L,49L,70L,84L,100L,120L,128L,135L,144L,162L,26L,44L,105L,112L,125L,126L,150L,160L,180L,192L,216L,243L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064364Inst : IEnumerable<long>
{
public static readonly long[] Value=A064364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064364.Bytes);
public long this[int i]=>Value[i];

public static A064364Inst Instance=new A064364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064365
{
public static readonly long[] Value={ 0L,2L,5L,10L,3L,14L,1L,18L,37L,60L,31L,62L,25L,66L,23L,70L,17L,76L,15L,82L,11L,84L,163L,80L,169L,72L,173L,276L,383L,274L,161L,34L,165L,28L,167L,316L,467L,310L,147L,314L,141L,320L,139L,330L,137L,334L,135L,346L,123L,350L,121L,354L,115L,356L,105L,362L,99L,368L,97L,374L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064365Inst : IEnumerable<long>
{
public static readonly long[] Value=A064365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064365.Bytes);
public long this[int i]=>Value[i];

public static A064365Inst Instance=new A064365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064366
{
public static readonly long[] Value={ 1L,3L,6L,21L,15L,66L,28L,1365L,1716L,3060L,66L,20475L,91L,134596L,735471L,7888725L,153L,3262623L,190L,118030185L,225792840L,254186856L,276L,2558620845L,84672315L,11058116888L,113380261800L,558383307300L,435L,11969016345L,496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064366Inst : IEnumerable<long>
{
public static readonly long[] Value=A064366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064366.Bytes);
public long this[int i]=>Value[i];

public static A064366Inst Instance=new A064366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064367
{
public static readonly long[] Value={ 0L,1L,3L,2L,10L,12L,9L,9L,6L,9L,2L,26L,33L,1L,9L,28L,33L,27L,13L,48L,8L,36L,47L,4L,95L,20L,76L,62L,23L,4L,8L,117L,68L,25L,138L,64L,150L,43L,61L,10L,72L,156L,40L,12L,73L,51L,48L,41L,24L,26L,71L,48L,32L,16L,128L,173L,74L,110L,118L,59L,30L,247L,202L,208L,284L,53L,128L,32L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064367Inst : IEnumerable<long>
{
public static readonly long[] Value=A064367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064367.Bytes);
public long this[int i]=>Value[i];

public static A064367Inst Instance=new A064367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064368
{
public static readonly long[] Value={ 1L,4L,7L,10L,15L,18L,21L,24L,29L,36L,39L,42L,47L,50L,53L,56L,65L,68L,75L,78L,83L,86L,89L,92L,97L,108L,111L,118L,123L,126L,129L,132L,141L,144L,147L,150L,163L,166L,169L,172L,177L,180L,183L,186L,191L,198L,201L,204L,213L,228L,239L,242L,247L,250L,257L,260L,265L,268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064368Inst : IEnumerable<long>
{
public static readonly long[] Value=A064368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064368.Bytes);
public long this[int i]=>Value[i];

public static A064368Inst Instance=new A064368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064369
{
public static readonly long[] Value={ 42L,261L,490L,494L,5447L,10023L,18519L,33543L,34292L,62263L,62267L,113405L,113406L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064369Inst : IEnumerable<long>
{
public static readonly long[] Value=A064369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064369.Bytes);
public long this[int i]=>Value[i];

public static A064369Inst Instance=new A064369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064370
{
public static readonly long[] Value={ 0L,1L,2L,12L,100L,118L,152L,190L,212L,258L,352L,462L,690L,741L,1285L,1396L,1417L,2119L,2318L,2603L,3370L,3777L,4073L,4155L,4485L,4522L,4600L,4719L,5317L,5446L,6697L,6748L,6985L,7144L,7595L,9492L,9551L,12010L,12985L,13438L,13850L,14672L,14739L,16510L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064370Inst : IEnumerable<long>
{
public static readonly long[] Value=A064370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064370.Bytes);
public long this[int i]=>Value[i];

public static A064370Inst Instance=new A064370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064371
{
public static readonly long[] Value={ 0L,5L,12L,86L,105L,176L,214L,230L,241L,412L,503L,696L,1065L,1147L,1170L,1273L,1334L,2021L,2455L,2600L,2660L,2772L,3299L,3332L,3365L,4417L,4861L,6478L,6572L,8115L,8858L,8905L,9229L,9380L,9590L,9692L,9749L,10501L,10829L,11338L,11633L,11690L,12099L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064371Inst : IEnumerable<long>
{
public static readonly long[] Value=A064371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064371.Bytes);
public long this[int i]=>Value[i];

public static A064371Inst Instance=new A064371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064372
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,2L,1L,1L,2L,1L,2L,2L,2L,1L,2L,1L,2L,1L,2L,1L,3L,1L,1L,2L,2L,2L,2L,1L,2L,2L,2L,1L,3L,1L,2L,2L,2L,1L,2L,1L,2L,2L,2L,1L,2L,2L,2L,2L,2L,1L,3L,1L,2L,2L,2L,2L,3L,1L,2L,2L,3L,1L,2L,1L,2L,2L,2L,2L,3L,1L,2L,1L,2L,1L,3L,2L,2L,2L,2L,1L,3L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,1L,3L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064372Inst : IEnumerable<long>
{
public static readonly long[] Value=A064372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064372.Bytes);
public long this[int i]=>Value[i];

public static A064372Inst Instance=new A064372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064373
{
public static readonly long[] Value={ 6L,0L,6L,0L,8L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064373Inst : IEnumerable<long>
{
public static readonly long[] Value=A064373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064373.Bytes);
public long this[int i]=>Value[i];

public static A064373Inst Instance=new A064373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064374
{
public static readonly long[] Value={ 2L,4L,6L,10L,12L,18L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064374Inst : IEnumerable<long>
{
public static readonly long[] Value=A064374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064374.Bytes);
public long this[int i]=>Value[i];

public static A064374Inst Instance=new A064374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064375
{
public static readonly long[] Value={ 2L,3L,4L,6L,8L,10L,12L,14L,18L,20L,24L,30L,36L,42L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064375Inst : IEnumerable<long>
{
public static readonly long[] Value=A064375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064375.Bytes);
public long this[int i]=>Value[i];

public static A064375Inst Instance=new A064375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064376
{
public static readonly long[] Value={ 2L,3L,4L,6L,8L,10L,12L,14L,16L,18L,20L,22L,24L,28L,30L,36L,40L,42L,48L,54L,60L,66L,70L,72L,78L,84L,90L,102L,114L,120L,126L,132L,150L,168L,180L,210L,330L,420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064376Inst : IEnumerable<long>
{
public static readonly long[] Value=A064376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064376.Bytes);
public long this[int i]=>Value[i];

public static A064376Inst Instance=new A064376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064377
{
public static readonly long[] Value={ 2L,3L,4L,6L,8L,10L,12L,14L,15L,16L,18L,20L,22L,24L,26L,28L,30L,32L,34L,36L,38L,40L,42L,44L,48L,50L,54L,56L,60L,66L,70L,72L,78L,80L,84L,90L,96L,100L,102L,108L,110L,114L,120L,126L,130L,132L,138L,140L,144L,150L,156L,162L,168L,174L,180L,186L,192L,198L,204L,210L,216L,222L,228L,234L,240L,246L,252L,258L,264L,270L,276L,282L,294L,300L,306L,312L,330L,336L,342L,360L,378L,390L,396L,420L,450L,462L,480L,504L,510L,540L,546L,570L,600L,630L,660L,690L,714L,720L,750L,780L,840L,870L,930L,990L,1020L,1050L,1170L,1260L,1470L,1680L,2310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064377Inst : IEnumerable<long>
{
public static readonly long[] Value=A064377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064377.Bytes);
public long this[int i]=>Value[i];

public static A064377Inst Instance=new A064377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064378
{
public static readonly BigInteger[] Value={ 2L,4L,8L,32L,192L,1536L,15360L,184320L,2580480L,41287680L,743178240L,14863564800L,326998425600L,7847962214400L,204047017574400L,5713316492083200L,171399494762496000L,5484783832399872000L,BigInteger.Parse("186482650301595648000"),BigInteger.Parse("6713375410857443328000") };
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
public class A064378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064378Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A064378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064378.Bytes);
public BigInteger this[int i]=>Value[i];

public static A064378Inst Instance=new A064378Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064379
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,2L,3L,4L,1L,4L,5L,1L,2L,3L,4L,5L,6L,1L,3L,5L,7L,1L,2L,3L,4L,5L,6L,7L,8L,1L,3L,4L,7L,9L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,1L,2L,5L,7L,9L,10L,11L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,1L,3L,4L,5L,9L,11L,12L,13L,1L,2L,4L,7L,8L,9L,11L,13L,14L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064379Inst : IEnumerable<long>
{
public static readonly long[] Value=A064379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064379.Bytes);
public long this[int i]=>Value[i];

public static A064379Inst Instance=new A064379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064380
{
public static readonly long[] Value={ 1L,2L,3L,4L,3L,6L,4L,8L,5L,10L,7L,12L,8L,9L,15L,16L,11L,18L,13L,14L,14L,22L,10L,24L,16L,18L,19L,28L,13L,30L,20L,22L,21L,25L,26L,36L,24L,27L,18L,40L,17L,42L,32L,33L,29L,46L,34L,48L,32L,36L,39L,52L,24L,42L,27L,40L,37L,58L,30L,60L,40L,49L,48L,50L,30L,66L,51L,49L,35L,70L,34L,72L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064380Inst : IEnumerable<long>
{
public static readonly long[] Value=A064380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064380.Bytes);
public long this[int i]=>Value[i];

public static A064380Inst Instance=new A064380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064381
{
public static readonly long[] Value={ 0L,0L,0L,6L,0L,24L,32L,120L,0L,792L,0L,2016L,5760L,13056L,0L,55136L,0L,226944L,387072L,523776L,0L,4112000L,5767168L,8386560L,30408704L,58669056L,0L,259541376L,0L,1062731776L,1609039872L,2147450880L,7927234560L,17103136768L,0L,34359607296L,103054049280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064381Inst : IEnumerable<long>
{
public static readonly long[] Value=A064381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064381.Bytes);
public long this[int i]=>Value[i];

public static A064381Inst Instance=new A064381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064382
{
public static readonly BigInteger[] Value={ 1L,6L,240L,100800L,605404800L,65703372134400L,BigInteger.Parse("155590841484029952000"),BigInteger.Parse("9416463528385701835407360000"),BigInteger.Parse("16689045681854870055279680279347200000"),BigInteger.Parse("976264092939656812770160178186221444104192000000"),BigInteger.Parse("2097176933095579995533106263090939623313258344938995712000000") };
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
public class A064382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064382Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A064382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064382.Bytes);
public BigInteger this[int i]=>Value[i];

public static A064382Inst Instance=new A064382Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064383
{
public static readonly long[] Value={ 1L,2L,4L,5L,10L,13L,20L,26L,37L,52L,65L,74L,130L,148L,185L,260L,370L,463L,481L,740L,926L,962L,1852L,1924L,2315L,2405L,4630L,4810L,6019L,9260L,9620L,12038L,17131L,24076L,30095L,34262L,60190L,68524L,85655L,120380L,171310L,222703L,342620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064383Inst : IEnumerable<long>
{
public static readonly long[] Value=A064383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064383.Bytes);
public long this[int i]=>Value[i];

public static A064383Inst Instance=new A064383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064384
{
public static readonly long[] Value={ 2L,5L,13L,37L,463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064384Inst : IEnumerable<long>
{
public static readonly long[] Value=A064384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064384.Bytes);
public long this[int i]=>Value[i];

public static A064384Inst Instance=new A064384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064385
{
public static readonly long[] Value={ 7L,47L,247L,1247L,6247L,31247L,156247L,781247L,3906247L,19531247L,97656247L,488281247L,2441406247L,12207031247L,61035156247L,305175781247L,1525878906247L,7629394531247L,38146972656247L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064385Inst : IEnumerable<long>
{
public static readonly long[] Value=A064385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064385.Bytes);
public long this[int i]=>Value[i];

public static A064385Inst Instance=new A064385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064386
{
public static readonly long[] Value={ 1L,2L,3L,5L,9L,13L,17L,33L,57L,65L,129L,241L,257L,513L,993L,1025L,2049L,4033L,4097L,8193L,16257L,16385L,32769L,65281L,65537L,131073L,261633L,262145L,524289L,1047553L,1048577L,2097153L,4192257L,4194305L,8388609L,16773121L,16777217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064386Inst : IEnumerable<long>
{
public static readonly long[] Value=A064386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064386.Bytes);
public long this[int i]=>Value[i];

public static A064386Inst Instance=new A064386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064387
{
public static readonly long[] Value={ 1L,3L,6L,2L,7L,13L,20L,12L,21L,11L,22L,10L,23L,9L,24L,8L,25L,43L,62L,42L,63L,41L,18L,44L,19L,45L,72L,100L,71L,101L,70L,38L,5L,39L,4L,40L,77L,115L,76L,36L,78L,120L,163L,119L,74L,28L,75L,27L,79L,29L,80L,132L,185L,131L,186L,130L,73L,15L,81L,141L,202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064387Inst : IEnumerable<long>
{
public static readonly long[] Value=A064387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064387.Bytes);
public long this[int i]=>Value[i];

public static A064387Inst Instance=new A064387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064388
{
public static readonly long[] Value={ 1L,3L,6L,2L,7L,13L,20L,12L,21L,11L,22L,10L,23L,9L,24L,8L,25L,43L,62L,42L,63L,41L,18L,44L,17L,45L,16L,46L,15L,47L,14L,48L,83L,119L,82L,120L,81L,121L,80L,38L,84L,37L,85L,36L,86L,35L,87L,34L,88L,33L,89L,32L,90L,31L,91L,30L,92L,29L,93L,28L,94L,27L,95L,26L,96L,167L,239L,166L,240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064388Inst : IEnumerable<long>
{
public static readonly long[] Value=A064388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064388.Bytes);
public long this[int i]=>Value[i];

public static A064388Inst Instance=new A064388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064389
{
public static readonly long[] Value={ 1L,3L,6L,2L,7L,13L,20L,12L,21L,11L,22L,10L,23L,9L,24L,8L,25L,43L,62L,42L,63L,41L,18L,44L,19L,45L,72L,100L,71L,101L,70L,38L,5L,39L,4L,40L,77L,115L,76L,36L,78L,120L,163L,119L,74L,28L,75L,27L,79L,29L,80L,132L,185L,131L,186L,130L,73L,15L,81L,141L,202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064389Inst : IEnumerable<long>
{
public static readonly long[] Value=A064389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064389.Bytes);
public long this[int i]=>Value[i];

public static A064389Inst Instance=new A064389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064390
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,9L,10L,12L,13L,16L,17L,18L,20L,24L,26L,32L,33L,34L,36L,40L,48L,52L,57L,64L,65L,66L,68L,72L,80L,96L,104L,114L,128L,129L,130L,132L,136L,144L,160L,192L,208L,228L,241L,256L,257L,258L,260L,264L,272L,288L,320L,384L,416L,456L,482L,512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064390Inst : IEnumerable<long>
{
public static readonly long[] Value=A064390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064390.Bytes);
public long this[int i]=>Value[i];

public static A064390Inst Instance=new A064390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064391
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,2L,1L,2L,2L,2L,2L,2L,1L,2L,1L,1L,0L,1L,1L,0L,1L,1L,2L,1L,3L,2L,3L,2L,3L,2L,3L,1L,2L,1L,1L,0L,1L,1L,0L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064391Inst : IEnumerable<long>
{
public static readonly long[] Value=A064391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064391.Bytes);
public long this[int i]=>Value[i];

public static A064391Inst Instance=new A064391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064392
{
public static readonly long[] Value={ 1L,2L,5L,10L,13L,26L,37L,65L,74L,130L,185L,370L,463L,481L,926L,962L,2315L,2405L,4630L,4810L,6019L,12038L,17131L,30095L,34262L,60190L,85655L,171310L,222703L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064392Inst : IEnumerable<long>
{
public static readonly long[] Value=A064392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064392.Bytes);
public long this[int i]=>Value[i];

public static A064392Inst Instance=new A064392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064393
{
public static readonly long[] Value={ 4L,8L,9L,22L,26L,27L,32L,33L,50L,51L,56L,57L,70L,76L,77L,82L,94L,95L,100L,112L,118L,119L,128L,129L,134L,135L,176L,177L,186L,187L,196L,266L,267L,274L,275L,280L,296L,297L,342L,343L,352L,358L,364L,365L,372L,386L,387L,392L,393L,400L,406L,407L,426L,427L,454L,455L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064393Inst : IEnumerable<long>
{
public static readonly long[] Value=A064393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064393.Bytes);
public long this[int i]=>Value[i];

public static A064393Inst Instance=new A064393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064394
{
public static readonly long[] Value={ 4L,5L,8L,9L,22L,23L,26L,27L,32L,33L,50L,51L,56L,57L,70L,71L,76L,77L,82L,83L,94L,95L,100L,101L,112L,113L,118L,119L,128L,129L,134L,135L,176L,177L,186L,187L,196L,197L,266L,267L,274L,275L,280L,281L,296L,297L,342L,343L,352L,353L,358L,359L,364L,365L,372L,373L,386L,387L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064394Inst : IEnumerable<long>
{
public static readonly long[] Value=A064394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064394.Bytes);
public long this[int i]=>Value[i];

public static A064394Inst Instance=new A064394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064395
{
public static readonly long[] Value={ 5L,23L,71L,83L,101L,113L,197L,281L,353L,359L,373L,401L,599L,683L,739L,751L,773L,977L,1091L,1097L,1103L,1217L,1223L,1229L,1237L,1283L,1553L,1559L,1601L,1607L,1619L,2039L,2347L,2357L,2389L,2417L,2473L,2539L,2671L,2699L,2749L,2857L,3019L,3049L,3499L,3581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064395Inst : IEnumerable<long>
{
public static readonly long[] Value=A064395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064395.Bytes);
public long this[int i]=>Value[i];

public static A064395Inst Instance=new A064395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064396
{
public static readonly long[] Value={ 317L,467L,619L,1303L,1307L,1429L,1433L,1489L,1613L,1699L,1873L,2713L,2719L,2797L,2971L,3307L,3541L,3769L,4937L,5087L,5233L,5443L,5479L,5507L,5527L,5653L,5657L,5749L,6047L,6143L,6571L,7487L,7547L,7583L,8017L,8431L,8867L,9007L,9931L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064396Inst : IEnumerable<long>
{
public static readonly long[] Value=A064396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064396.Bytes);
public long this[int i]=>Value[i];

public static A064396Inst Instance=new A064396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064397
{
public static readonly long[] Value={ 7L,15L,20L,61L,152L,190L,293L,377L,492L,558L,789L,919L,942L,1768L,2343L,2429L,2693L,2952L,3136L,3720L,4837L,5421L,5722L,6870L,7347L,8126L,8193L,9465L,9857L,9927L,10410L,10483L,10653L,12685L,13763L,13955L,16033L,16342L,17859L,18367L,18474L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064397Inst : IEnumerable<long>
{
public static readonly long[] Value=A064397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064397.Bytes);
public long this[int i]=>Value[i];

public static A064397Inst Instance=new A064397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064398
{
public static readonly long[] Value={ 7L,61L,293L,919L,2693L,9857L,13763L,16033L,18367L,39419L,44789L,64433L,132511L,157307L,195407L,213289L,241513L,243589L,258331L,293989L,332573L,436673L,462067L,478637L,523777L,583367L,976933L,983557L,1329673L,1481099L,1582069L,1753963L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064398Inst : IEnumerable<long>
{
public static readonly long[] Value=A064398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064398.Bytes);
public long this[int i]=>Value[i];

public static A064398Inst Instance=new A064398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064399
{
public static readonly long[] Value={ 39L,48L,49L,79L,149L,179L,249L,318L,348L,349L,389L,390L,399L,448L,449L,480L,489L,490L,498L,499L,548L,549L,579L,649L,679L,749L,789L,790L,795L,799L,849L,889L,895L,898L,899L,949L,1049L,1096L,1149L,1249L,1429L,1488L,1489L,1490L,1497L,1498L,1499L,1735L,1739L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064399Inst : IEnumerable<long>
{
public static readonly long[] Value=A064399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064399.Bytes);
public long this[int i]=>Value[i];

public static A064399Inst Instance=new A064399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064400
{
public static readonly long[] Value={ 3L,6L,18L,24L,60L,36L,126L,96L,162L,120L,330L,144L,468L,252L,360L,384L,816L,324L,1026L,480L,756L,660L,1518L,576L,1500L,936L,1458L,1008L,2436L,720L,2790L,1536L,1980L,1632L,2520L,1296L,3996L,2052L,2808L,1920L,4920L,1512L,5418L,2640L,3240L,3036L,6486L,2304L,6174L,3000L,4896L,3744L,8268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064400Inst : IEnumerable<long>
{
public static readonly long[] Value=A064400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064400.Bytes);
public long this[int i]=>Value[i];

public static A064400Inst Instance=new A064400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064401
{
public static readonly long[] Value={ 4L,5L,7L,12L,14L,15L,16L,17L,18L,20L,30L,37L,39L,49L,52L,66L,86L,162L,165L,202L,235L,250L,366L,419L,1169L,1311L,1916L,3032L,3211L,3335L,4650L,6199L,7762L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064401Inst : IEnumerable<long>
{
public static readonly long[] Value=A064401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064401.Bytes);
public long this[int i]=>Value[i];

public static A064401Inst Instance=new A064401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064402
{
public static readonly long[] Value={ 1L,2L,4L,6L,18L,22L,24L,26L,32L,34L,42L,48L,66L,70L,72L,82L,92L,96L,98L,100L,102L,104L,106L,108L,114L,116L,126L,130L,144L,150L,152L,158L,172L,180L,200L,202L,204L,206L,218L,222L,228L,236L,270L,282L,290L,300L,312L,322L,324L,328L,330L,350L,352L,356L,362L,378L,384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064402Inst : IEnumerable<long>
{
public static readonly long[] Value=A064402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064402.Bytes);
public long this[int i]=>Value[i];

public static A064402Inst Instance=new A064402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064403
{
public static readonly long[] Value={ 4L,6L,18L,42L,66L,144L,282L,384L,408L,450L,522L,564L,618L,672L,720L,732L,744L,828L,858L,1122L,1308L,1374L,1560L,1644L,1698L,1776L,1848L,1920L,2022L,2304L,2412L,2616L,2766L,2778L,2874L,2958L,2970L,3036L,3042L,3240L,3258L,3354L,3360L,3432L,3540L,3594L,3732L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064403Inst : IEnumerable<long>
{
public static readonly long[] Value=A064403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064403.Bytes);
public long this[int i]=>Value[i];

public static A064403Inst Instance=new A064403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064404
{
public static readonly long[] Value={ 3L,4L,6L,7L,10L,19L,20L,26L,30L,31L,33L,40L,63L,85L,92L,100L,126L,131L,185L,196L,200L,204L,242L,246L,272L,274L,282L,379L,553L,572L,654L,777L,902L,1100L,1216L,1225L,1236L,1316L,1413L,1658L,1943L,2077L,2086L,2744L,2746L,2856L,2860L,3518L,3718L,4184L,4189L,4363L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064404Inst : IEnumerable<long>
{
public static readonly long[] Value=A064404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064404.Bytes);
public long this[int i]=>Value[i];

public static A064404Inst Instance=new A064404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064405
{
public static readonly long[] Value={ -1L,-2L,-1L,-4L,1L,-2L,-1L,-8L,5L,2L,3L,-4L,5L,-2L,-1L,-16L,13L,10L,11L,4L,13L,6L,7L,-8L,17L,10L,11L,-4L,13L,-2L,-1L,-32L,29L,26L,27L,20L,29L,22L,23L,8L,33L,26L,27L,12L,29L,14L,15L,-16L,41L,34L,35L,20L,37L,22L,23L,-8L,41L,26L,27L,-4L,29L,-2L,-1L,-64L,61L,58L,59L,52L,61L,54L,55L,40L,65L,58L,59L,44L,61L,46L,47L,16L,73L,66L,67L,52L,69L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064405Inst : IEnumerable<long>
{
public static readonly long[] Value=A064405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064405.Bytes);
public long this[int i]=>Value[i];

public static A064405Inst Instance=new A064405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064406
{
public static readonly long[] Value={ -1L,-3L,-4L,-8L,-7L,-9L,-10L,-18L,-13L,-11L,-8L,-12L,-7L,-9L,-10L,-26L,-13L,-3L,8L,12L,25L,31L,38L,30L,47L,57L,68L,64L,77L,75L,74L,42L,71L,97L,124L,144L,173L,195L,218L,226L,259L,285L,312L,324L,353L,367L,382L,366L,407L,441L,476L,496L,533L,555L,578L,570L,611L,637L,664L,660L,689L,687L,686L,622L,683L,741L,800L,852L,913L,967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064406Inst : IEnumerable<long>
{
public static readonly long[] Value=A064406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064406.Bytes);
public long this[int i]=>Value[i];

public static A064406Inst Instance=new A064406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064407
{
public static readonly long[] Value={ 2L,4L,12L,18L,24L,26L,30L,36L,38L,42L,48L,50L,54L,56L,60L,66L,68L,72L,78L,80L,84L,86L,90L,92L,94L,96L,98L,102L,108L,114L,116L,120L,122L,126L,128L,132L,134L,138L,144L,146L,150L,156L,158L,162L,164L,168L,170L,174L,176L,180L,186L,188L,192L,198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064407Inst : IEnumerable<long>
{
public static readonly long[] Value=A064407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064407.Bytes);
public long this[int i]=>Value[i];

public static A064407Inst Instance=new A064407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064408
{
public static readonly long[] Value={ 2L,4L,6L,8L,16L,22L,28L,30L,34L,40L,42L,46L,52L,54L,58L,60L,64L,70L,72L,76L,82L,84L,88L,90L,94L,96L,98L,100L,102L,106L,112L,118L,120L,124L,126L,130L,132L,136L,138L,142L,148L,150L,154L,160L,162L,166L,168L,172L,174L,178L,180L,184L,190L,192L,196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064408Inst : IEnumerable<long>
{
public static readonly long[] Value=A064408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064408.Bytes);
public long this[int i]=>Value[i];

public static A064408Inst Instance=new A064408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064409
{
public static readonly long[] Value={ 2L,4L,6L,14L,20L,26L,28L,32L,38L,40L,44L,50L,52L,56L,58L,62L,68L,70L,74L,80L,82L,86L,88L,92L,94L,96L,98L,100L,104L,110L,116L,118L,122L,124L,128L,130L,134L,136L,140L,146L,148L,152L,158L,160L,164L,166L,170L,172L,176L,178L,182L,188L,190L,194L,200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064409Inst : IEnumerable<long>
{
public static readonly long[] Value=A064409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064409.Bytes);
public long this[int i]=>Value[i];

public static A064409Inst Instance=new A064409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064410
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,1L,2L,2L,4L,4L,7L,7L,11L,12L,17L,19L,27L,30L,41L,48L,62L,73L,95L,110L,140L,166L,206L,243L,302L,354L,435L,513L,622L,733L,887L,1039L,1249L,1467L,1750L,2049L,2438L,2847L,3371L,3934L,4634L,5398L,6343L,7367L,8626L,10009L,11677L,13521L,15737L,18184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064410Inst : IEnumerable<long>
{
public static readonly long[] Value=A064410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064410.Bytes);
public long this[int i]=>Value[i];

public static A064410Inst Instance=new A064410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064411
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,16L,59L,100L,129L,314L,2294L,1568705L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064411Inst : IEnumerable<long>
{
public static readonly long[] Value=A064411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064411.Bytes);
public long this[int i]=>Value[i];

public static A064411Inst Instance=new A064411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064412
{
public static readonly long[] Value={ 1L,5L,14L,32L,60L,103L,160L,238L,335L,459L,606L,786L,994L,1241L,1520L,1844L,2205L,2617L,3070L,3580L,4136L,4755L,5424L,6162L,6955L,7823L,8750L,9758L,10830L,11989L,13216L,14536L,15929L,17421L,18990L,20664L,22420L,24287L,26240L,28310L,30471L,32755L,35134L,37642L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064412Inst : IEnumerable<long>
{
public static readonly long[] Value=A064412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064412.Bytes);
public long this[int i]=>Value[i];

public static A064412Inst Instance=new A064412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064413
{
public static readonly long[] Value={ 1L,2L,4L,6L,3L,9L,12L,8L,10L,5L,15L,18L,14L,7L,21L,24L,16L,20L,22L,11L,33L,27L,30L,25L,35L,28L,26L,13L,39L,36L,32L,34L,17L,51L,42L,38L,19L,57L,45L,40L,44L,46L,23L,69L,48L,50L,52L,54L,56L,49L,63L,60L,55L,65L,70L,58L,29L,87L,66L,62L,31L,93L,72L,64L,68L,74L,37L,111L,75L,78L,76L,80L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064413Inst : IEnumerable<long>
{
public static readonly long[] Value=A064413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064413.Bytes);
public long this[int i]=>Value[i];

public static A064413Inst Instance=new A064413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064414
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,9L,14L,23L,27L,43L,49L,67L,81L,83L,86L,98L,103L,127L,134L,163L,167L,206L,223L,227L,243L,254L,283L,326L,343L,367L,383L,443L,446L,463L,467L,487L,503L,523L,529L,547L,566L,587L,607L,643L,647L,683L,686L,727L,729L,734L,787L,823L,827L,863L,883L,887L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064414Inst : IEnumerable<long>
{
public static readonly long[] Value=A064414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064414.Bytes);
public long this[int i]=>Value[i];

public static A064414Inst Instance=new A064414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064415
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,2L,2L,3L,2L,3L,3L,3L,3L,3L,3L,4L,4L,3L,3L,4L,3L,4L,4L,4L,4L,4L,3L,4L,4L,4L,4L,5L,4L,5L,4L,4L,4L,4L,4L,5L,5L,4L,4L,5L,4L,5L,5L,5L,4L,5L,5L,5L,5L,4L,5L,5L,4L,5L,5L,5L,5L,5L,4L,6L,5L,5L,5L,6L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,4L,6L,6L,5L,6L,5L,5L,6L,6L,5L,5L,6L,5L,6L,5L,6L,6L,5L,5L,6L,6L,6L,6L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064415Inst : IEnumerable<long>
{
public static readonly long[] Value=A064415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064415.Bytes);
public long this[int i]=>Value[i];

public static A064415Inst Instance=new A064415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064416
{
public static readonly long[] Value={ 1L,2L,5L,11L,26L,59L,137L,312L,719L,1651L,3816L,8757L,20202L,46440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064416Inst : IEnumerable<long>
{
public static readonly long[] Value=A064416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064416.Bytes);
public long this[int i]=>Value[i];

public static A064416Inst Instance=new A064416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064417
{
public static readonly long[] Value={ 1L,2L,3L,6L,9L,12L,4L,8L,16L,20L,5L,10L,15L,18L,21L,7L,14L,28L,24L,27L,30L,25L,35L,40L,32L,36L,33L,11L,22L,44L,48L,39L,13L,26L,52L,56L,42L,45L,50L,55L,60L,51L,17L,34L,68L,64L,72L,54L,57L,19L,38L,76L,80L,65L,70L,49L,63L,66L,69L,23L,46L,92L,84L,75L,78L,81L,87L,29L,58L,116L,88L,77L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064417Inst : IEnumerable<long>
{
public static readonly long[] Value=A064417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064417.Bytes);
public long this[int i]=>Value[i];

public static A064417Inst Instance=new A064417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064418
{
public static readonly long[] Value={ 1L,2L,3L,4L,8L,12L,6L,18L,9L,27L,36L,16L,20L,5L,10L,15L,25L,30L,24L,28L,7L,14L,21L,35L,40L,32L,44L,11L,22L,33L,55L,45L,50L,60L,42L,48L,52L,13L,26L,39L,65L,70L,49L,56L,63L,54L,66L,72L,64L,68L,17L,34L,51L,85L,75L,80L,76L,19L,38L,57L,95L,90L,78L,84L,77L,88L,92L,23L,46L,69L,115L,100L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064418Inst : IEnumerable<long>
{
public static readonly long[] Value=A064418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064418.Bytes);
public long this[int i]=>Value[i];

public static A064418Inst Instance=new A064418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064419
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,10L,15L,20L,25L,30L,6L,12L,18L,9L,27L,36L,24L,8L,16L,32L,40L,35L,7L,14L,21L,28L,42L,48L,54L,45L,50L,55L,11L,22L,33L,44L,66L,60L,65L,13L,26L,39L,52L,78L,72L,56L,49L,63L,70L,75L,80L,64L,88L,77L,84L,90L,81L,99L,108L,96L,102L,17L,34L,51L,68L,85L,95L,19L,38L,57L,76L,114L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064419Inst : IEnumerable<long>
{
public static readonly long[] Value=A064419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064419.Bytes);
public long this[int i]=>Value[i];

public static A064419Inst Instance=new A064419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064420
{
public static readonly long[] Value={ 16L,26L,49L,77L,289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064420Inst : IEnumerable<long>
{
public static readonly long[] Value=A064420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064420.Bytes);
public long this[int i]=>Value[i];

public static A064420Inst Instance=new A064420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064421
{
public static readonly long[] Value={ 0L,1L,4L,2L,9L,3L,13L,7L,5L,8L,19L,6L,27L,12L,10L,16L,32L,11L,36L,17L,14L,18L,42L,15L,23L,26L,21L,25L,56L,22L,60L,30L,20L,31L,24L,29L,66L,35L,28L,39L,73L,34L,80L,40L,38L,41L,88L,44L,49L,45L,33L,46L,99L,47L,52L,48L,37L,55L,106L,51L,114L,59L,50L,63L,53L,58L,127L,64L,43L,54L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064421Inst : IEnumerable<long>
{
public static readonly long[] Value=A064421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064421.Bytes);
public long this[int i]=>Value[i];

public static A064421Inst Instance=new A064421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064422
{
public static readonly long[] Value={ 1L,4L,40L,748L,13744L,238568L,4054190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064422Inst : IEnumerable<long>
{
public static readonly long[] Value=A064422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064422.Bytes);
public long this[int i]=>Value[i];

public static A064422Inst Instance=new A064422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064423
{
public static readonly long[] Value={ 1L,4L,9L,13L,19L,27L,32L,36L,42L,56L,60L,66L,73L,80L,88L,99L,106L,114L,127L,133L,137L,150L,159L,166L,181L,188L,196L,202L,206L,215L,235L,252L,258L,263L,278L,286L,296L,304L,313L,327L,335L,343L,362L,370L,376L,380L,400L,419L,429L,437L,443L,457L,461L,473L,486L,500L,509L,516L,529L,539L,548L,556L,580L,586L,598L,605L,628L,638L,654L,663L,669L,680L,698L,706L,723L,729L,735L,755L,765L,780L,797L,801L,813L,818L,832L,847L,856L,873L,881L,888L,897L,910L,926L,941L,952L,960L,970L,996L,1003L,1028L,1040L,1058L,1071L,1079L,1086L,1098L,1117L,1134L,1141L,1149L,1155L,1174L,1180L,1189L,1202L,1222L,1231L,1241L,1248L,1257L,1265L,1286L,1297L,1305L,1323L,1349L,1356L,1377L,1390L,1397L,1409L,1424L,1432L,1441L,1455L,1469L,1477L,1503L,1515L,1541L,1545L,1563L,1567L,1577L,1585L,1609L,1625L,1637L,1645L,1651L,1679L,1685L,1692L,1701L,1733L,1738L,1759L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064423Inst : IEnumerable<long>
{
public static readonly long[] Value=A064423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064423.Bytes);
public long this[int i]=>Value[i];

public static A064423Inst Instance=new A064423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064424
{
public static readonly long[] Value={ 1L,2L,4L,6L,9L,12L,15L,18L,21L,24L,33L,35L,39L,51L,57L,69L,70L,87L,93L,111L,123L,129L,141L,159L,177L,183L,201L,213L,219L,237L,249L,267L,291L,303L,309L,321L,327L,339L,381L,393L,411L,417L,447L,453L,471L,489L,501L,519L,537L,543L,573L,579L,591L,597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064424Inst : IEnumerable<long>
{
public static readonly long[] Value=A064424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064424.Bytes);
public long this[int i]=>Value[i];

public static A064424Inst Instance=new A064424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064425
{
public static readonly long[] Value={ 3L,5L,4L,6L,8L,5L,4L,6L,14L,4L,6L,7L,7L,8L,11L,7L,8L,13L,6L,4L,13L,9L,7L,15L,7L,8L,6L,4L,9L,20L,17L,6L,5L,15L,8L,10L,8L,9L,14L,8L,8L,19L,8L,6L,4L,20L,19L,10L,8L,6L,14L,4L,12L,13L,14L,9L,7L,13L,10L,9L,8L,24L,6L,12L,7L,23L,10L,16L,9L,6L,11L,18L,8L,17L,6L,6L,20L,10L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064425Inst : IEnumerable<long>
{
public static readonly long[] Value=A064425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064425.Bytes);
public long this[int i]=>Value[i];

public static A064425Inst Instance=new A064425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064426
{
public static readonly long[] Value={ 1L,2L,2L,-3L,6L,3L,-4L,2L,-5L,10L,3L,-4L,-7L,14L,3L,-8L,4L,2L,-11L,22L,-6L,3L,-5L,10L,-7L,-2L,-13L,26L,-3L,-4L,2L,-17L,34L,-9L,-4L,-19L,38L,-12L,-5L,4L,2L,-23L,46L,-21L,2L,2L,2L,2L,-7L,14L,-3L,-5L,10L,5L,-12L,-29L,58L,-21L,-4L,-31L,62L,-21L,-8L,4L,6L,-37L,74L,-36L,3L,-2L,4L,2L,-41L,82L,-42L,3L,-7L,11L,-2L,-43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064426Inst : IEnumerable<long>
{
public static readonly long[] Value=A064426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064426.Bytes);
public long this[int i]=>Value[i];

public static A064426Inst Instance=new A064426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064427
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,9L,10L,12L,13L,14L,15L,17L,18L,20L,21L,22L,23L,25L,26L,28L,29L,30L,31L,33L,34L,35L,36L,37L,38L,40L,41L,43L,44L,45L,46L,47L,48L,50L,51L,52L,53L,55L,56L,58L,59L,60L,61L,63L,64L,65L,66L,67L,68L,70L,71L,72L,73L,74L,75L,77L,78L,80L,81L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064427Inst : IEnumerable<long>
{
public static readonly long[] Value=A064427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064427.Bytes);
public long this[int i]=>Value[i];

public static A064427Inst Instance=new A064427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064428
{
public static readonly long[] Value={ 1L,0L,1L,2L,3L,4L,6L,8L,12L,16L,23L,30L,42L,54L,73L,94L,124L,158L,206L,260L,334L,420L,532L,664L,835L,1034L,1288L,1588L,1962L,2404L,2953L,3598L,4392L,5328L,6466L,7808L,9432L,11338L,13632L,16326L,19544L,23316L,27806L,33054L,39273L,46534L,55096L,65076L,76808L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064428Inst : IEnumerable<long>
{
public static readonly long[] Value=A064428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064428.Bytes);
public long this[int i]=>Value[i];

public static A064428Inst Instance=new A064428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064429
{
public static readonly long[] Value={ 0L,2L,1L,3L,5L,4L,6L,8L,7L,9L,11L,10L,12L,14L,13L,15L,17L,16L,18L,20L,19L,21L,23L,22L,24L,26L,25L,27L,29L,28L,30L,32L,31L,33L,35L,34L,36L,38L,37L,39L,41L,40L,42L,44L,43L,45L,47L,46L,48L,50L,49L,51L,53L,52L,54L,56L,55L,57L,59L,58L,60L,62L,61L,63L,65L,64L,66L,68L,67L,69L,71L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064429Inst : IEnumerable<long>
{
public static readonly long[] Value=A064429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064429.Bytes);
public long this[int i]=>Value[i];

public static A064429Inst Instance=new A064429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064430
{
public static readonly BigInteger[] Value={ 1L,1L,6L,864L,43200000L,272097792000000000L,BigInteger.Parse("3416681839784939886182400000000000"),BigInteger.Parse("1847600699255039694224318542233446367734016245760000000000000000") };
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
public class A064430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064430Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A064430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064430.Bytes);
public BigInteger this[int i]=>Value[i];

public static A064430Inst Instance=new A064430Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064431
{
public static readonly long[] Value={ 6L,21L,38L,44L,45L,81L,164L,261L,278L,4388L,9009L,114302L,41623514L,440169957L,19033618221L,175036435525L,341846222877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064431Inst : IEnumerable<long>
{
public static readonly long[] Value=A064431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064431.Bytes);
public long this[int i]=>Value[i];

public static A064431Inst Instance=new A064431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064432
{
public static readonly long[] Value={ 14L,2L,2L,248L,1856L,7190L,719L,15308L,13415L,18434L,13532L,26975L,6935L,61763L,17786L,60140L,6014L,297974L,103199L,56321L,80009L,428186L,303476L,32558L,1361063L,444275L,634451L,116573L,303593L,293822L,1068491L,651464L,1855937L,3217754L,364985L,569129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064432Inst : IEnumerable<long>
{
public static readonly long[] Value=A064432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064432.Bytes);
public long this[int i]=>Value[i];

public static A064432Inst Instance=new A064432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064433
{
public static readonly long[] Value={ 1L,1L,2L,6L,3L,5L,7L,12L,4L,14L,6L,11L,8L,8L,13L,13L,5L,10L,15L,15L,7L,7L,12L,12L,9L,17L,9L,71L,14L,14L,14L,68L,6L,19L,11L,11L,16L,16L,16L,24L,8L,70L,8L,21L,13L,13L,13L,67L,10L,18L,18L,18L,10L,10L,72L,72L,15L,23L,15L,23L,15L,15L,69L,69L,7L,20L,20L,20L,12L,12L,12L,66L,17L,74L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064433Inst : IEnumerable<long>
{
public static readonly long[] Value=A064433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064433.Bytes);
public long this[int i]=>Value[i];

public static A064433Inst Instance=new A064433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064434
{
public static readonly long[] Value={ 0L,1L,0L,1L,3L,1L,3L,7L,6L,3L,7L,3L,7L,1L,3L,7L,15L,13L,8L,17L,14L,7L,15L,7L,15L,5L,11L,23L,18L,7L,15L,31L,30L,27L,20L,5L,11L,23L,8L,17L,35L,29L,16L,33L,22L,45L,44L,41L,34L,19L,39L,27L,2L,5L,11L,23L,47L,37L,16L,33L,6L,13L,27L,55L,46L,27L,55L,43L,18L,37L,4L,9L,19L,39L,4L,9L,19L,39L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064434Inst : IEnumerable<long>
{
public static readonly long[] Value=A064434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064434.Bytes);
public long this[int i]=>Value[i];

public static A064434Inst Instance=new A064434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064435
{
public static readonly long[] Value={ 1L,3L,8L,10L,18L,24L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064435Inst : IEnumerable<long>
{
public static readonly long[] Value=A064435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064435.Bytes);
public long this[int i]=>Value[i];

public static A064435Inst Instance=new A064435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064436
{
public static readonly BigInteger[] Value={ 0L,0L,2L,152L,63654L,4294872724L,18446744073694523482UL,BigInteger.Parse("340282366920938463463374607423390140592"),BigInteger.Parse("115792089237316195423570985008687907853269984665640564039457583990351590086990") };
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
public class A064436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064436Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A064436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064436.Bytes);
public BigInteger this[int i]=>Value[i];

public static A064436Inst Instance=new A064436Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064437
{
public static readonly long[] Value={ 1L,3L,6L,8L,10L,13L,15L,18L,20L,23L,25L,27L,30L,32L,35L,37L,39L,42L,44L,47L,49L,51L,54L,56L,59L,61L,64L,66L,68L,71L,73L,76L,78L,80L,83L,85L,88L,90L,93L,95L,97L,100L,102L,105L,107L,109L,112L,114L,117L,119L,122L,124L,126L,129L,131L,134L,136L,138L,141L,143L,146L,148L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064437Inst : IEnumerable<long>
{
public static readonly long[] Value=A064437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064437.Bytes);
public long this[int i]=>Value[i];

public static A064437Inst Instance=new A064437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064438
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,9L,12L,16L,18L,20L,21L,24L,28L,30L,32L,33L,35L,36L,40L,42L,48L,50L,52L,54L,60L,63L,64L,66L,68L,69L,72L,76L,78L,80L,81L,84L,88L,90L,91L,96L,100L,102L,108L,112L,114L,120L,126L,128L,129L,132L,136L,138L,140L,144L,148L,150L,154L,156L,160L,162L,168L,171L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064438Inst : IEnumerable<long>
{
public static readonly long[] Value=A064438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064438.Bytes);
public long this[int i]=>Value[i];

public static A064438Inst Instance=new A064438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064439
{
public static readonly long[] Value={ 4L,55L,65L,95L,125L,145L,155L,185L,205L,2779L,2863L,55297L,174691L,174779L,487903L,1301989L,1302457L,5254751L,6383483L,23140961L,48267437L,59651051L,70111213L,70111247L,92514491L,199445641L,212210443L,514269523L,514269599L,21881358361L,1602278990111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064439Inst : IEnumerable<long>
{
public static readonly long[] Value=A064439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064439.Bytes);
public long this[int i]=>Value[i];

public static A064439Inst Instance=new A064439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064440
{
public static readonly long[] Value={ 6L,21L,31L,79L,121L,265L,271L,379L,541L,631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064440Inst : IEnumerable<long>
{
public static readonly long[] Value=A064440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064440.Bytes);
public long this[int i]=>Value[i];

public static A064440Inst Instance=new A064440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064441
{
public static readonly long[] Value={ 1L,2L,7L,11L,124L,146L,205L,1121L,2101L,3333L,20899L,45415L,54103L,67629L,148987L,319183L,757657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064441Inst : IEnumerable<long>
{
public static readonly long[] Value=A064441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064441.Bytes);
public long this[int i]=>Value[i];

public static A064441Inst Instance=new A064441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064442
{
public static readonly long[] Value={ 2L,3L,1L,3L,0L,3L,6L,7L,3L,6L,4L,3L,3L,5L,8L,2L,9L,0L,6L,3L,8L,3L,9L,5L,1L,6L,0L,2L,6L,4L,1L,7L,8L,2L,4L,7L,6L,3L,9L,6L,6L,8L,9L,7L,7L,1L,8L,0L,3L,2L,5L,6L,3L,4L,0L,2L,1L,0L,1L,2L,4L,4L,4L,2L,1L,4L,4L,5L,6L,4L,7L,3L,1L,7L,7L,6L,2L,7L,2L,2L,4L,3L,6L,9L,5L,3L,2L,2L,0L,1L,7L,2L,3L,8L,3L,2L,8L,1L,7L,4L,5L,3L,0L,1L,5L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064442Inst : IEnumerable<long>
{
public static readonly long[] Value=A064442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064442.Bytes);
public long this[int i]=>Value[i];

public static A064442Inst Instance=new A064442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064443
{
public static readonly long[] Value={ 1L,3L,8L,22L,66L,170L,210L,490L,510L,930L,1470L,2130L,2910L,3810L,5406L,5970L,7230L,7590L,10110L,12306L,13470L,14322L,17310L,17490L,23142L,26430L,29010L,32430L,37470L,42546L,44814L,49170L,58674L,69330L,73830L,86610L,87780L,96690L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064443Inst : IEnumerable<long>
{
public static readonly long[] Value=A064443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064443.Bytes);
public long this[int i]=>Value[i];

public static A064443Inst Instance=new A064443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064444
{
public static readonly long[] Value={ 1L,4L,12L,28L,30L,52L,55L,65L,68L,76L,95L,145L,155L,185L,205L,822L,894L,2779L,2863L,8392L,23481L,24093L,24237L,64270L,174691L,174779L,1301989L,1302457L,3523478L,9554955L,9555045L,9556455L,70111213L,70111247L,189960426L,514269523L,514269599L,10246934786L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064444Inst : IEnumerable<long>
{
public static readonly long[] Value=A064444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064444.Bytes);
public long this[int i]=>Value[i];

public static A064444Inst Instance=new A064444Inst();

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