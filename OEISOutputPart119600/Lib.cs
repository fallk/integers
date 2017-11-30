using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A153564
{
public static readonly long[] Value={ 1L,2L,7L,22L,56L,121L,603L,4292L,34905L,284158L,2388099L,29265021L,473031984L,9304582753L,212580151667L,5654131835907L,189056293870086L,7909530731661434L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153564Inst : IEnumerable<long>
{
public static readonly long[] Value=A153564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153564.Bytes);
public long this[int i]=>Value[i];

public static A153564Inst Instance=new A153564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153565
{
public static readonly long[] Value={ 1L,2L,8L,42L,176L,576L,5196L,73620L,1358751L,28558756L,692751617L,26643595004L,1466710451867L,108327240281718L,10438694555033407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153565Inst : IEnumerable<long>
{
public static readonly long[] Value=A153565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153565.Bytes);
public long this[int i]=>Value[i];

public static A153565Inst Instance=new A153565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153566
{
public static readonly long[] Value={ 1L,2L,8L,57L,386L,1941L,28361L,697630L,24981538L,1168812802L,71029483178L,7171360955838L,1116266181380655L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153566Inst : IEnumerable<long>
{
public static readonly long[] Value=A153566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153566.Bytes);
public long this[int i]=>Value[i];

public static A153566Inst Instance=new A153566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153567
{
public static readonly long[] Value={ 1L,2L,8L,63L,638L,4944L,107290L,4122772L,252553968L,22777499394L,2983659891399L,672402701915613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153567Inst : IEnumerable<long>
{
public static readonly long[] Value=A153567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153567.Bytes);
public long this[int i]=>Value[i];

public static A153567Inst Instance=new A153567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153568
{
public static readonly long[] Value={ 1L,2L,8L,64L,848L,9949L,298247L,16406435L,1545911495L,236576023548L,58010755690276L,25220215282781623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153568Inst : IEnumerable<long>
{
public static readonly long[] Value=A153568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153568.Bytes);
public long this[int i]=>Value[i];

public static A153568Inst Instance=new A153568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153569
{
public static readonly long[] Value={ 1L,2L,8L,64L,968L,16384L,636160L,46471081L,6138372476L,1420652208666L,570274649107959L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153569Inst : IEnumerable<long>
{
public static readonly long[] Value=A153569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153569.Bytes);
public long this[int i]=>Value[i];

public static A153569Inst Instance=new A153569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153570
{
public static readonly long[] Value={ 1L,2L,8L,64L,1013L,22819L,1080723L,98064835L,16728055591L,5280106993017L,3064935209805679L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153570Inst : IEnumerable<long>
{
public static readonly long[] Value=A153570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153570.Bytes);
public long this[int i]=>Value[i];

public static A153570Inst Instance=new A153570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153571
{
public static readonly long[] Value={ 1L,2L,8L,64L,1023L,27824L,1518130L,161027087L,32975856442L,12956875592101L,9739126432448652L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153571Inst : IEnumerable<long>
{
public static readonly long[] Value=A153571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153571.Bytes);
public long this[int i]=>Value[i];

public static A153571Inst Instance=new A153571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153572
{
public static readonly long[] Value={ 1L,2L,8L,64L,1024L,30827L,1838745L,215817763L,49765842909L,22507324505644L,19944752831429061L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153572Inst : IEnumerable<long>
{
public static readonly long[] Value=A153572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153572.Bytes);
public long this[int i]=>Value[i];

public static A153572Inst Instance=new A153572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153573
{
public static readonly BigInteger[] Value={ 1L,2L,8L,64L,1024L,32192L,2011220L,249506561L,61452941714L,30042205745855L,29145013835098643L,BigInteger.Parse("56117516926934448546") };
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
public class A153573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153573Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153573.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153573Inst Instance=new A153573Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153574
{
public static readonly BigInteger[] Value={ 1L,2L,8L,64L,1024L,32647L,2077283L,263780971L,66847941821L,33808278361085L,34122529738063477L,BigInteger.Parse("68729763733145691579"),BigInteger.Parse("276270363504278466732083") };
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
public class A153574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153574Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153574.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153574Inst Instance=new A153574Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153575
{
public static readonly BigInteger[] Value={ 1L,2L,8L,64L,1024L,32752L,2094318L,267741217L,68431511177L,34967557296519L,35722557457038015L,BigInteger.Parse("72960515669384007174"),BigInteger.Parse("297921161289491832202122"),BigInteger.Parse("2432108336354772545286908394"),BigInteger.Parse("39694705789611428794588557667852") };
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
public class A153575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153575Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153575.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153575Inst Instance=new A153575Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153576
{
public static readonly BigInteger[] Value={ 1L,2L,8L,64L,1024L,32767L,2096965L,268388252L,68699511776L,35169130417570L,36007041542255125L,BigInteger.Parse("73727766794557011289"),BigInteger.Parse("301920463144265115604918"),BigInteger.Parse("2472702390678435639706449295"),BigInteger.Parse("40501301413934096271908637456659") };
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
public class A153576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153576Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153576.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153576Inst Instance=new A153576Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153577
{
public static readonly long[] Value={ -1L,1L,-7L,24L,-121L,720L,-5040L,40319L,-362880L,3628800L,-39916801L,479001600L,-6227020801L,87178291199L,-1307674368000L,20922789887999L,-355687428096000L,6402373705728000L,-121645100408832001L,2432902008176640000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153577Inst : IEnumerable<long>
{
public static readonly long[] Value=A153577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153577.Bytes);
public long this[int i]=>Value[i];

public static A153577Inst Instance=new A153577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153578
{
public static readonly long[] Value={ 3L,7L,16L,3L,5L,2L,2L,2L,2L,3L,2L,15L,3L,14L,3L,2L,6L,3L,6L,9L,4L,3L,2L,9L,8L,3L,4L,4L,17L,24L,6L,4L,4L,3L,2L,9L,6L,8L,3L,4L,59L,10L,20L,4L,7L,31L,4L,3L,4L,2L,3L,3L,14L,6L,2L,3L,3L,29L,3L,3L,8L,121L,3L,25L,4L,8L,4L,2L,2L,10L,4L,13L,7L,10L,3L,2L,4L,2L,2L,3L,3L,2L,10L,4L,4L,6L,2L,8L,12L,4L,6L,5L,5L,3L,3L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153578Inst : IEnumerable<long>
{
public static readonly long[] Value=A153578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153578.Bytes);
public long this[int i]=>Value[i];

public static A153578Inst Instance=new A153578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153579
{
public static readonly long[] Value={ -294L,-4L,-15L,-3L,-85L,-3L,-5L,-2L,-6L,-6L,-100L,-2L,-6L,-9L,-3L,-3L,-8L,-2L,-13L,-5L,-2L,-3L,-2L,-5L,-2L,-2L,-4L,-162L,-46L,-3L,-3L,-3L,-25L,-5L,-2L,-10L,-2L,-5L,-5L,-6L,-2L,-2L,-27L,-2L,-8L,-2L,-42L,-3L,-2L,-7L,-2L,-4L,-9L,-7L,-2L,-4L,-20L,-3L,-19L,-3L,-3L,-9L,-17L,-4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153579Inst : IEnumerable<long>
{
public static readonly long[] Value=A153579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153579.Bytes);
public long this[int i]=>Value[i];

public static A153579Inst Instance=new A153579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153580
{
public static readonly long[] Value={ 721801L,873181L,4504501L,8646121L,9006401L,9863461L,10403641L,12322133L,14609401L,15913261L,18595801L,18736381L,20234341L,21397381L,22066201L,22369621L,22885129L,25326001L,25696133L,28312921L,36307981L,42702661L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153580Inst : IEnumerable<long>
{
public static readonly long[] Value=A153580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153580.Bytes);
public long this[int i]=>Value[i];

public static A153580Inst Instance=new A153580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153581
{
public static readonly long[] Value={ 721801L,8646121L,10403641L,22885129L,36307981L,42702661L,46094401L,48064021L,52204237L,79398901L,80918281L,81954133L,114329881L,116151661L,143168581L,170782921L,188985961L,217145881L,220531501L,282707461L,299671921L,303373801L,326695141L,353815801L,361307521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153581Inst : IEnumerable<long>
{
public static readonly long[] Value=A153581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153581.Bytes);
public long this[int i]=>Value[i];

public static A153581Inst Instance=new A153581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153582
{
public static readonly long[] Value={ 1L,1L,3L,9L,24L,65L,177L,481L,1308L,3555L,9664L,26269L,71406L,194103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153582Inst : IEnumerable<long>
{
public static readonly long[] Value=A153582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153582.Bytes);
public long this[int i]=>Value[i];

public static A153582Inst Instance=new A153582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153583
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,3L,4L,3L,6L,9L,5L,4L,9L,18L,24L,6L,5L,12L,27L,48L,65L,7L,6L,15L,36L,72L,130L,177L,8L,7L,18L,45L,96L,195L,354L,481L,9L,8L,21L,54L,120L,260L,531L,962L,1308L,10L,9L,24L,63L,144L,325L,708L,1443L,2616L,3555L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153583Inst : IEnumerable<long>
{
public static readonly long[] Value=A153583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153583.Bytes);
public long this[int i]=>Value[i];

public static A153583Inst Instance=new A153583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153584
{
public static readonly long[] Value={ 1L,10L,13L,186L,192L,5667L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153584Inst : IEnumerable<long>
{
public static readonly long[] Value=A153584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153584.Bytes);
public long this[int i]=>Value[i];

public static A153584Inst Instance=new A153584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153585
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,2L,0L,2L,0L,3L,2L,0L,6L,0L,6L,0L,5L,0L,12L,0L,10L,5L,0L,18L,0L,30L,0L,20L,0L,14L,0L,42L,0L,60L,0L,35L,14L,0L,56L,0L,120L,0L,140L,0L,70L,0L,42L,0L,144L,0L,270L,0L,280L,0L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153585Inst : IEnumerable<long>
{
public static readonly long[] Value=A153585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153585.Bytes);
public long this[int i]=>Value[i];

public static A153585Inst Instance=new A153585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153586
{
public static readonly long[] Value={ 7L,4L,7L,2L,2L,1L,7L,3L,6L,3L,0L,9L,2L,1L,4L,0L,8L,1L,7L,4L,8L,4L,2L,9L,2L,4L,1L,5L,9L,3L,0L,1L,6L,1L,8L,5L,1L,1L,5L,9L,1L,4L,0L,0L,1L,6L,1L,0L,5L,1L,3L,3L,3L,2L,2L,8L,8L,6L,6L,1L,0L,4L,0L,0L,2L,5L,8L,3L,0L,3L,8L,6L,1L,8L,1L,4L,2L,7L,0L,3L,6L,3L,7L,7L,4L,3L,3L,1L,4L,0L,0L,2L,3L,7L,8L,3L,3L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153586Inst : IEnumerable<long>
{
public static readonly long[] Value=A153586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153586.Bytes);
public long this[int i]=>Value[i];

public static A153586Inst Instance=new A153586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153587
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,2L,0L,0L,0L,2L,4L,1L,0L,1L,0L,0L,0L,2L,4L,6L,8L,10L,2L,5L,0L,4L,2L,2L,0L,2L,0L,0L,0L,2L,4L,6L,8L,10L,12L,14L,16L,18L,20L,1L,4L,7L,10L,13L,0L,4L,8L,12L,4L,9L,4L,1L,0L,1L,4L,4L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153587Inst : IEnumerable<long>
{
public static readonly long[] Value=A153587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153587.Bytes);
public long this[int i]=>Value[i];

public static A153587Inst Instance=new A153587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153588
{
public static readonly long[] Value={ 1L,3L,7L,15L,35L,77L,179L,429L,1039L,2525L,6235L,15463L,38513L,96231L,241519L,607339L,1529533L,3857447L,9743247L,24634043L,62335495L,157885967L,400211085L,1015080877L,2576308943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153588Inst : IEnumerable<long>
{
public static readonly long[] Value=A153588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153588.Bytes);
public long this[int i]=>Value[i];

public static A153588Inst Instance=new A153588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153589
{
public static readonly long[] Value={ 7L,2L,1L,0L,5L,7L,0L,5L,4L,3L,4L,8L,8L,7L,0L,1L,5L,6L,8L,0L,8L,9L,5L,5L,9L,1L,8L,9L,6L,2L,1L,1L,4L,3L,9L,6L,8L,9L,5L,2L,0L,5L,6L,6L,2L,4L,0L,3L,5L,2L,6L,9L,3L,2L,0L,2L,7L,3L,0L,3L,9L,9L,6L,5L,9L,1L,7L,2L,3L,4L,9L,4L,7L,5L,9L,5L,3L,2L,4L,4L,0L,9L,1L,9L,3L,0L,2L,7L,8L,2L,6L,4L,9L,6L,3L,6L,8L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153589Inst : IEnumerable<long>
{
public static readonly long[] Value=A153589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153589.Bytes);
public long this[int i]=>Value[i];

public static A153589Inst Instance=new A153589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153590
{
public static readonly long[] Value={ 2L,3L,5L,7L,19L,23L,29L,37L,43L,47L,53L,59L,67L,113L,137L,139L,157L,163L,173L,179L,229L,239L,257L,263L,293L,313L,349L,353L,359L,373L,379L,419L,449L,467L,499L,503L,509L,547L,577L,587L,593L,617L,643L,647L,653L,719L,727L,797L,883L,929L,967L,983L,997L,1013L,1033L,1049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153590Inst : IEnumerable<long>
{
public static readonly long[] Value=A153590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153590.Bytes);
public long this[int i]=>Value[i];

public static A153590Inst Instance=new A153590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153591
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,19L,23L,31L,41L,43L,47L,67L,73L,97L,101L,107L,109L,137L,151L,199L,233L,239L,241L,251L,263L,283L,317L,331L,337L,353L,359L,379L,383L,419L,421L,431L,439L,449L,463L,541L,569L,571L,577L,601L,619L,647L,691L,701L,769L,823L,839L,877L,907L,929L,953L,971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153591Inst : IEnumerable<long>
{
public static readonly long[] Value=A153591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153591.Bytes);
public long this[int i]=>Value[i];

public static A153591Inst Instance=new A153591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153592
{
public static readonly long[] Value={ 2L,3L,3L,2L,20L,2L,2L,58L,58L,2L,2L,100L,516L,100L,2L,2L,162L,2356L,2356L,162L,2L,2L,248L,6718L,26384L,6718L,248L,2L,2L,362L,16038L,165038L,165038L,16038L,362L,2L,2L,508L,34256L,664772L,2229724L,664772L,34256L,508L,2L,2L,690L,67344L,2142448L,17747916L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153592Inst : IEnumerable<long>
{
public static readonly long[] Value=A153592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153592.Bytes);
public long this[int i]=>Value[i];

public static A153592Inst Instance=new A153592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153593
{
public static readonly long[] Value={ 1L,18L,245L,2988L,34429L,383670L,4186169L,45041112L,480032665L,5082340122L,53559541661L,562566880260L,5895000053461L,61667217421758L,644304909368225L,6725778192309168L,70163919621475249L,731614075994130210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153593Inst : IEnumerable<long>
{
public static readonly long[] Value=A153593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153593.Bytes);
public long this[int i]=>Value[i];

public static A153593Inst Instance=new A153593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153594
{
public static readonly long[] Value={ 1L,8L,51L,304L,1769L,10200L,58603L,336224L,1927953L,11052712L,63358307L,363181200L,2081791609L,11932977272L,68400527259L,392075513536L,2247397253921L,12882196355400L,73841406542227L,423262699717616L,2426163312691977L,13906891405206808L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153594Inst : IEnumerable<long>
{
public static readonly long[] Value=A153594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153594.Bytes);
public long this[int i]=>Value[i];

public static A153594Inst Instance=new A153594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153595
{
public static readonly long[] Value={ 6L,3L,5L,2L,4L,3L,2L,4L,1L,3L,3L,2L,1L,4L,1L,2L,2L,3L,1L,2L,3L,1L,2L,1L,3L,2L,1L,2L,2L,2L,1L,1L,3L,0L,2L,1L,2L,2L,1L,1L,3L,2L,1L,2L,1L,3L,1L,1L,1L,2L,1L,2L,0L,2L,3L,1L,1L,2L,1L,2L,1L,1L,0L,3L,1L,1L,1L,1L,2L,2L,0L,1L,2L,2L,1L,2L,1L,1L,3L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,0L,2L,0L,2L,1L,1L,0L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153595Inst : IEnumerable<long>
{
public static readonly long[] Value=A153595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153595.Bytes);
public long this[int i]=>Value[i];

public static A153595Inst Instance=new A153595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153596
{
public static readonly long[] Value={ 1L,10L,78L,560L,3884L,26520L,179752L,1214080L,8186256L,55152800L,371430368L,2500942080L,16837952704L,113358801280L,763153053312L,5137636904960L,34587001876736L,232842006858240L,1567506027294208L,10552536122060800L,71040228620135424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153596Inst : IEnumerable<long>
{
public static readonly long[] Value=A153596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153596.Bytes);
public long this[int i]=>Value[i];

public static A153596Inst Instance=new A153596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153597
{
public static readonly long[] Value={ 1L,12L,111L,936L,7569L,59940L,469503L,3656016L,28378593L,219894588L,1702241487L,13170376440L,101870548209L,787824155988L,6092161780959L,47107744223904L,364251591915201L,2816463543593580L,21777259989921327L,168383822940467784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153597Inst : IEnumerable<long>
{
public static readonly long[] Value=A153597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153597.Bytes);
public long this[int i]=>Value[i];

public static A153597Inst Instance=new A153597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153598
{
public static readonly long[] Value={ 1L,14L,150L,1456L,13484L,121800L,1084936L,9586304L,84301200L,739246816L,6471600224L,56597049600L,494665084096L,4321846895744L,37751262672000L,329712720203776L,2879419999940864L,25145094869798400L,219578008179897856L,1917417750507843584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153598Inst : IEnumerable<long>
{
public static readonly long[] Value=A153598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153598.Bytes);
public long this[int i]=>Value[i];

public static A153598Inst Instance=new A153598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153599
{
public static readonly ulong[] Value={ 1L,16L,195L,2144L,22409L,227760L,2277211L,22542016L,221762385L,2173135184L,21242657459L,207321273120L,2021338264921L,19694814578416L,191815399094475L,1867662696228224L,18181863794888609L,176982396248296080L,1722624648484532131L,16766068204606453216UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153599Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A153599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153599.Bytes);
public ulong this[int i]=>Value[i];

public static A153599Inst Instance=new A153599Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153600
{
public static readonly BigInteger[] Value={ 1L,18L,246L,3024L,35244L,398520L,4424328L,48553344L,528862608L,5732366112L,61931306592L,667638961920L,7186859400384L,77287630177152L,830602309958784L,8922406425440256L,95816335481139456L,1028746337476170240L,11043759907042186752UL,BigInteger.Parse("118545464003618082816") };
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
public class A153600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153600Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153600.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153600Inst Instance=new A153600Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153601
{
public static readonly long[] Value={ 1L,3L,5L,7L,11L,13L,17L,31L,43L,57L,73L,127L,151L,205L,241L,257L,331L,683L,2047L,2359L,2731L,3277L,4033L,5419L,8191L,43691L,61681L,65281L,65537L,80581L,131071L,174763L,261633L,262657L,524287L,599479L,838861L,1016801L,1082401L,1397419L,2796203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153601Inst : IEnumerable<long>
{
public static readonly long[] Value=A153601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153601.Bytes);
public long this[int i]=>Value[i];

public static A153601Inst Instance=new A153601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153602
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,17L,31L,43L,73L,127L,151L,241L,257L,331L,683L,2731L,5419L,8191L,43691L,61681L,65537L,131071L,174763L,262657L,524287L,599479L,2796203L,15790321L,18837001L,22366891L,715827883L,2147483647L,4278255361L,4562284561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153602Inst : IEnumerable<long>
{
public static readonly long[] Value=A153602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153602.Bytes);
public long this[int i]=>Value[i];

public static A153602Inst Instance=new A153602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153603
{
public static readonly long[] Value={ 6L,9L,8L,5L,5L,5L,4L,9L,5L,4L,5L,8L,7L,1L,4L,4L,2L,2L,2L,8L,4L,8L,8L,2L,3L,8L,1L,3L,7L,1L,6L,0L,6L,8L,7L,1L,3L,0L,5L,2L,7L,5L,1L,3L,0L,6L,9L,7L,3L,6L,5L,7L,6L,6L,4L,0L,2L,6L,0L,3L,0L,4L,9L,6L,6L,2L,9L,5L,7L,8L,1L,6L,2L,5L,7L,8L,5L,6L,6L,5L,7L,5L,0L,1L,8L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153603Inst : IEnumerable<long>
{
public static readonly long[] Value=A153603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153603.Bytes);
public long this[int i]=>Value[i];

public static A153603Inst Instance=new A153603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153604
{
public static readonly long[] Value={ 6L,7L,8L,9L,3L,9L,1L,9L,8L,9L,0L,2L,9L,9L,2L,7L,6L,2L,5L,1L,5L,4L,4L,7L,5L,6L,0L,9L,0L,7L,6L,3L,2L,4L,4L,9L,5L,8L,7L,4L,6L,0L,5L,8L,8L,4L,3L,1L,3L,3L,5L,7L,2L,6L,6L,3L,8L,4L,4L,8L,8L,0L,3L,7L,7L,1L,7L,9L,5L,7L,9L,5L,1L,7L,4L,6L,2L,7L,4L,3L,0L,1L,8L,5L,7L,5L,4L,4L,4L,8L,0L,1L,9L,8L,5L,3L,8L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153604Inst : IEnumerable<long>
{
public static readonly long[] Value=A153604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153604.Bytes);
public long this[int i]=>Value[i];

public static A153604Inst Instance=new A153604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153605
{
public static readonly long[] Value={ 6L,6L,1L,6L,4L,1L,8L,9L,5L,8L,9L,2L,0L,2L,8L,3L,8L,3L,7L,7L,0L,5L,8L,2L,6L,7L,5L,4L,6L,6L,1L,9L,4L,7L,9L,9L,9L,0L,4L,8L,0L,9L,6L,5L,8L,0L,2L,5L,1L,8L,1L,5L,6L,9L,6L,9L,4L,8L,6L,2L,4L,5L,7L,1L,1L,0L,7L,9L,0L,3L,9L,3L,0L,6L,1L,2L,4L,5L,2L,9L,0L,8L,9L,5L,3L,4L,2L,3L,7L,4L,9L,6L,6L,5L,0L,7L,0L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153605Inst : IEnumerable<long>
{
public static readonly long[] Value=A153605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153605.Bytes);
public long this[int i]=>Value[i];

public static A153605Inst Instance=new A153605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153606
{
public static readonly long[] Value={ 6L,4L,6L,2L,4L,0L,6L,2L,5L,1L,8L,0L,2L,8L,9L,0L,4L,5L,3L,6L,3L,4L,3L,4L,7L,3L,5L,9L,8L,6L,9L,5L,4L,1L,2L,7L,1L,8L,9L,9L,5L,3L,6L,0L,1L,9L,2L,3L,1L,2L,0L,2L,6L,5L,1L,1L,3L,9L,3L,8L,1L,6L,3L,6L,3L,5L,2L,7L,4L,5L,5L,6L,9L,4L,8L,5L,8L,9L,6L,4L,0L,6L,3L,0L,5L,7L,0L,1L,1L,8L,7L,2L,9L,5L,2L,2L,0L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153606Inst : IEnumerable<long>
{
public static readonly long[] Value=A153606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153606.Bytes);
public long this[int i]=>Value[i];

public static A153606Inst Instance=new A153606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153607
{
public static readonly long[] Value={ 6L,3L,2L,4L,1L,2L,4L,7L,7L,1L,5L,6L,7L,1L,6L,1L,0L,5L,8L,2L,5L,9L,6L,0L,8L,5L,1L,9L,6L,6L,3L,9L,6L,4L,5L,4L,2L,2L,4L,9L,3L,4L,5L,9L,5L,0L,5L,2L,2L,3L,9L,9L,4L,0L,1L,3L,3L,1L,0L,8L,6L,0L,7L,8L,1L,8L,0L,0L,6L,6L,2L,3L,9L,5L,0L,4L,0L,5L,7L,4L,3L,0L,0L,3L,6L,6L,7L,3L,4L,6L,0L,0L,2L,6L,8L,1L,7L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153607Inst : IEnumerable<long>
{
public static readonly long[] Value=A153607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153607.Bytes);
public long this[int i]=>Value[i];

public static A153607Inst Instance=new A153607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153608
{
public static readonly long[] Value={ 6L,1L,9L,9L,0L,6L,2L,3L,3L,2L,8L,4L,0L,6L,5L,7L,2L,2L,3L,6L,7L,8L,4L,2L,0L,8L,2L,4L,5L,5L,2L,6L,1L,5L,3L,0L,8L,8L,4L,0L,8L,8L,9L,6L,5L,0L,0L,9L,5L,3L,5L,2L,8L,2L,9L,8L,9L,3L,2L,2L,4L,5L,0L,3L,5L,7L,4L,5L,6L,4L,5L,2L,8L,7L,1L,5L,9L,4L,7L,7L,2L,4L,2L,5L,3L,2L,7L,8L,2L,0L,7L,4L,0L,0L,7L,0L,5L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153608Inst : IEnumerable<long>
{
public static readonly long[] Value=A153608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153608.Bytes);
public long this[int i]=>Value[i];

public static A153608Inst Instance=new A153608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153609
{
public static readonly long[] Value={ 6L,0L,8L,5L,2L,3L,2L,1L,3L,3L,8L,8L,2L,7L,5L,1L,8L,5L,3L,2L,5L,1L,9L,7L,8L,2L,8L,1L,4L,2L,0L,3L,4L,8L,9L,0L,0L,6L,1L,0L,2L,3L,5L,2L,4L,8L,7L,9L,9L,5L,2L,4L,0L,5L,2L,7L,6L,9L,9L,8L,6L,1L,0L,4L,4L,9L,7L,3L,7L,4L,9L,3L,8L,5L,5L,1L,0L,1L,7L,9L,8L,7L,7L,6L,4L,7L,0L,0L,9L,5L,7L,9L,1L,4L,7L,3L,8L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153609Inst : IEnumerable<long>
{
public static readonly long[] Value=A153609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153609.Bytes);
public long this[int i]=>Value[i];

public static A153609Inst Instance=new A153609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153610
{
public static readonly long[] Value={ 5L,9L,8L,1L,0L,4L,0L,0L,4L,5L,0L,1L,8L,4L,3L,8L,0L,3L,1L,7L,6L,5L,0L,4L,8L,4L,3L,7L,5L,6L,9L,7L,3L,1L,4L,9L,4L,8L,6L,7L,3L,3L,9L,3L,8L,3L,0L,5L,8L,9L,7L,9L,3L,0L,1L,2L,8L,6L,0L,5L,3L,7L,1L,3L,8L,8L,4L,7L,1L,2L,5L,0L,9L,6L,1L,7L,2L,7L,4L,9L,4L,0L,9L,2L,7L,7L,1L,5L,2L,1L,8L,2L,9L,1L,6L,0L,3L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153610Inst : IEnumerable<long>
{
public static readonly long[] Value=A153610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153610.Bytes);
public long this[int i]=>Value[i];

public static A153610Inst Instance=new A153610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153611
{
public static readonly long[] Value={ 5L,8L,8L,5L,1L,9L,0L,5L,5L,4L,1L,1L,4L,8L,3L,1L,7L,1L,2L,2L,7L,1L,5L,9L,7L,6L,8L,6L,0L,5L,1L,9L,6L,2L,5L,5L,7L,0L,5L,4L,5L,2L,0L,7L,0L,9L,9L,0L,0L,8L,0L,9L,4L,3L,8L,2L,6L,6L,6L,3L,0L,9L,3L,7L,7L,7L,0L,7L,8L,6L,3L,2L,4L,3L,8L,1L,3L,0L,7L,4L,6L,4L,8L,3L,2L,7L,7L,5L,7L,0L,3L,9L,3L,8L,2L,7L,3L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153611Inst : IEnumerable<long>
{
public static readonly long[] Value=A153611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153611.Bytes);
public long this[int i]=>Value[i];

public static A153611Inst Instance=new A153611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153612
{
public static readonly long[] Value={ 5L,7L,9L,6L,6L,1L,8L,7L,6L,6L,2L,0L,7L,3L,9L,1L,7L,1L,9L,5L,7L,8L,4L,8L,4L,0L,9L,1L,8L,5L,6L,4L,4L,8L,5L,8L,4L,1L,8L,0L,9L,1L,2L,2L,4L,2L,7L,3L,4L,3L,8L,7L,4L,6L,0L,3L,1L,9L,7L,4L,9L,3L,8L,9L,5L,5L,7L,7L,3L,2L,4L,8L,0L,3L,8L,4L,9L,4L,5L,3L,5L,2L,9L,3L,1L,8L,5L,1L,6L,8L,6L,8L,5L,8L,1L,8L,4L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153612Inst : IEnumerable<long>
{
public static readonly long[] Value=A153612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153612.Bytes);
public long this[int i]=>Value[i];

public static A153612Inst Instance=new A153612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153613
{
public static readonly long[] Value={ 5L,7L,1L,4L,4L,4L,0L,3L,5L,8L,7L,9L,7L,1L,4L,7L,2L,3L,5L,5L,6L,4L,1L,9L,4L,6L,2L,7L,3L,9L,4L,0L,4L,9L,4L,6L,7L,0L,3L,2L,3L,8L,9L,5L,6L,1L,9L,1L,6L,9L,4L,9L,9L,6L,0L,2L,2L,1L,8L,4L,9L,0L,4L,2L,9L,9L,6L,7L,6L,6L,3L,1L,6L,1L,6L,3L,9L,9L,3L,3L,8L,0L,5L,7L,7L,9L,5L,7L,7L,0L,4L,7L,3L,7L,9L,2L,9L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153613Inst : IEnumerable<long>
{
public static readonly long[] Value=A153613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153613.Bytes);
public long this[int i]=>Value[i];

public static A153613Inst Instance=new A153613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153614
{
public static readonly long[] Value={ 5L,6L,3L,7L,9L,1L,4L,1L,6L,0L,2L,8L,9L,3L,6L,8L,8L,1L,5L,4L,1L,3L,2L,4L,3L,8L,7L,1L,1L,3L,2L,2L,3L,2L,2L,2L,7L,4L,4L,6L,7L,9L,1L,4L,9L,0L,0L,1L,0L,0L,0L,4L,6L,4L,7L,7L,0L,5L,2L,3L,6L,8L,7L,0L,7L,1L,6L,3L,1L,5L,2L,3L,6L,9L,9L,8L,0L,1L,5L,2L,9L,8L,0L,4L,0L,1L,6L,4L,5L,7L,1L,6L,2L,3L,5L,5L,5L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153614Inst : IEnumerable<long>
{
public static readonly long[] Value=A153614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153614.Bytes);
public long this[int i]=>Value[i];

public static A153614Inst Instance=new A153614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153615
{
public static readonly long[] Value={ 1L,4L,0L,3L,6L,7L,7L,4L,6L,1L,0L,2L,8L,8L,0L,2L,0L,5L,3L,7L,2L,0L,9L,8L,4L,6L,5L,8L,6L,1L,5L,9L,1L,5L,4L,0L,4L,3L,2L,0L,5L,1L,3L,3L,1L,2L,9L,8L,3L,0L,7L,0L,3L,9L,1L,8L,3L,8L,6L,4L,5L,8L,6L,2L,0L,3L,5L,1L,6L,0L,4L,2L,4L,4L,3L,1L,0L,9L,6L,4L,9L,3L,2L,4L,8L,9L,3L,0L,4L,9L,9L,5L,8L,5L,1L,0L,5L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153615Inst : IEnumerable<long>
{
public static readonly long[] Value=A153615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153615.Bytes);
public long this[int i]=>Value[i];

public static A153615Inst Instance=new A153615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153616
{
public static readonly long[] Value={ 1L,2L,0L,9L,0L,6L,1L,9L,5L,5L,1L,2L,2L,1L,6L,7L,5L,5L,6L,7L,6L,3L,3L,1L,6L,3L,4L,5L,5L,4L,7L,3L,6L,0L,0L,7L,1L,1L,1L,6L,5L,5L,5L,9L,2L,9L,7L,1L,0L,8L,3L,3L,1L,2L,8L,7L,0L,6L,2L,3L,6L,2L,0L,0L,8L,5L,2L,8L,7L,8L,2L,0L,0L,9L,9L,7L,4L,9L,9L,9L,8L,6L,5L,9L,9L,0L,1L,7L,3L,1L,8L,9L,7L,1L,6L,7L,5L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153616Inst : IEnumerable<long>
{
public static readonly long[] Value=A153616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153616.Bytes);
public long this[int i]=>Value[i];

public static A153616Inst Instance=new A153616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153617
{
public static readonly long[] Value={ 1L,0L,8L,6L,0L,3L,3L,1L,3L,2L,5L,0L,1L,6L,9L,1L,8L,4L,2L,9L,8L,6L,0L,4L,2L,0L,5L,0L,9L,2L,7L,8L,2L,1L,3L,3L,2L,9L,1L,8L,7L,8L,0L,9L,5L,5L,2L,0L,1L,1L,9L,2L,9L,9L,4L,8L,8L,7L,1L,0L,2L,4L,6L,0L,2L,7L,6L,5L,9L,4L,6L,4L,5L,8L,7L,2L,1L,4L,5L,6L,5L,0L,9L,9L,0L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153617Inst : IEnumerable<long>
{
public static readonly long[] Value=A153617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153617.Bytes);
public long this[int i]=>Value[i];

public static A153617Inst Instance=new A153617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153618
{
public static readonly long[] Value={ 9L,3L,5L,7L,8L,4L,9L,7L,4L,0L,1L,9L,2L,0L,1L,3L,6L,9L,1L,4L,7L,3L,2L,3L,1L,0L,5L,7L,4L,3L,9L,4L,3L,6L,0L,2L,8L,8L,0L,3L,4L,2L,2L,0L,8L,6L,5L,5L,3L,8L,0L,2L,6L,1L,2L,2L,5L,7L,6L,3L,9L,0L,8L,0L,2L,3L,4L,4L,0L,2L,8L,2L,9L,5L,4L,0L,6L,4L,3L,2L,8L,8L,3L,2L,6L,2L,0L,3L,3L,3L,0L,5L,6L,7L,3L,6L,9L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153618Inst : IEnumerable<long>
{
public static readonly long[] Value=A153618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153618.Bytes);
public long this[int i]=>Value[i];

public static A153618Inst Instance=new A153618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153619
{
public static readonly long[] Value={ 8L,8L,5L,6L,2L,1L,8L,7L,4L,5L,8L,0L,7L,1L,1L,1L,3L,0L,0L,3L,3L,9L,6L,4L,1L,5L,3L,5L,4L,1L,2L,2L,8L,8L,5L,9L,0L,3L,3L,2L,3L,5L,6L,6L,7L,2L,9L,7L,1L,2L,1L,7L,3L,9L,6L,8L,4L,4L,9L,6L,2L,8L,8L,6L,3L,9L,9L,4L,3L,0L,9L,9L,3L,5L,1L,4L,0L,6L,1L,0L,5L,4L,1L,7L,1L,5L,0L,4L,9L,4L,6L,6L,8L,7L,5L,4L,4L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153619Inst : IEnumerable<long>
{
public static readonly long[] Value=A153619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153619.Bytes);
public long this[int i]=>Value[i];

public static A153619Inst Instance=new A153619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153620
{
public static readonly long[] Value={ 8L,4L,5L,0L,9L,8L,0L,4L,0L,0L,1L,4L,2L,5L,6L,8L,3L,0L,7L,1L,2L,2L,1L,6L,2L,5L,8L,5L,9L,2L,6L,3L,6L,1L,9L,3L,4L,8L,3L,5L,7L,2L,3L,9L,6L,3L,2L,3L,9L,6L,5L,4L,0L,6L,5L,0L,3L,6L,3L,4L,9L,5L,3L,7L,1L,8L,2L,5L,3L,4L,3L,9L,9L,0L,2L,0L,7L,9L,1L,6L,6L,0L,6L,6L,1L,1L,1L,5L,2L,7L,8L,4L,7L,4L,8L,8L,5L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153620Inst : IEnumerable<long>
{
public static readonly long[] Value=A153620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153620.Bytes);
public long this[int i]=>Value[i];

public static A153620Inst Instance=new A153620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153621
{
public static readonly long[] Value={ 8L,1L,1L,5L,0L,7L,5L,6L,2L,9L,5L,7L,2L,4L,8L,9L,3L,9L,6L,6L,7L,9L,5L,0L,5L,9L,2L,9L,4L,0L,5L,4L,1L,2L,3L,8L,0L,9L,3L,9L,8L,0L,7L,9L,7L,9L,5L,2L,9L,1L,5L,8L,3L,8L,3L,7L,3L,2L,9L,9L,5L,0L,6L,0L,5L,7L,3L,6L,3L,1L,6L,9L,1L,1L,6L,1L,3L,2L,5L,0L,3L,4L,4L,1L,7L,6L,6L,6L,9L,1L,3L,0L,7L,1L,8L,7L,7L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153621Inst : IEnumerable<long>
{
public static readonly long[] Value=A153621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153621.Bytes);
public long this[int i]=>Value[i];

public static A153621Inst Instance=new A153621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153622
{
public static readonly long[] Value={ 7L,8L,3L,0L,9L,1L,8L,5L,1L,4L,4L,6L,9L,4L,6L,1L,1L,9L,5L,5L,4L,9L,3L,2L,8L,7L,8L,6L,1L,4L,8L,1L,0L,6L,8L,6L,7L,6L,3L,4L,8L,0L,1L,2L,4L,7L,4L,5L,0L,9L,6L,7L,6L,8L,1L,7L,8L,6L,4L,8L,5L,7L,2L,6L,0L,6L,9L,1L,6L,0L,7L,0L,7L,0L,3L,0L,2L,4L,2L,8L,2L,5L,4L,0L,8L,8L,9L,3L,9L,5L,5L,7L,9L,2L,4L,4L,7L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153622Inst : IEnumerable<long>
{
public static readonly long[] Value=A153622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153622.Bytes);
public long this[int i]=>Value[i];

public static A153622Inst Instance=new A153622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153623
{
public static readonly long[] Value={ 7L,5L,8L,6L,5L,4L,4L,1L,2L,9L,5L,9L,2L,9L,8L,9L,9L,4L,6L,7L,2L,3L,3L,1L,5L,7L,5L,7L,8L,9L,7L,0L,4L,3L,0L,7L,2L,0L,8L,6L,5L,1L,7L,7L,5L,0L,8L,5L,0L,8L,1L,2L,9L,0L,0L,0L,0L,9L,8L,7L,4L,5L,1L,9L,6L,5L,0L,5L,4L,7L,6L,0L,1L,3L,1L,4L,4L,3L,7L,4L,2L,6L,6L,3L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153623Inst : IEnumerable<long>
{
public static readonly long[] Value=A153623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153623.Bytes);
public long this[int i]=>Value[i];

public static A153623Inst Instance=new A153623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153624
{
public static readonly long[] Value={ 7L,3L,7L,3L,5L,0L,4L,6L,4L,9L,6L,2L,8L,0L,6L,4L,5L,2L,0L,2L,1L,0L,9L,3L,1L,3L,1L,4L,3L,4L,9L,1L,9L,2L,7L,9L,3L,9L,9L,3L,3L,8L,4L,0L,5L,2L,9L,3L,0L,8L,0L,1L,9L,0L,1L,0L,7L,9L,5L,7L,4L,3L,3L,8L,9L,2L,3L,0L,3L,9L,5L,0L,0L,0L,2L,4L,8L,2L,4L,5L,3L,7L,1L,2L,4L,8L,4L,1L,4L,0L,9L,8L,1L,8L,4L,1L,5L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153624Inst : IEnumerable<long>
{
public static readonly long[] Value=A153624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153624.Bytes);
public long this[int i]=>Value[i];

public static A153624Inst Instance=new A153624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153625
{
public static readonly long[] Value={ 7L,1L,8L,5L,6L,5L,0L,2L,0L,7L,8L,9L,9L,7L,7L,8L,6L,1L,6L,0L,6L,1L,1L,4L,5L,5L,7L,4L,7L,6L,7L,8L,5L,3L,3L,8L,4L,8L,3L,4L,4L,0L,3L,5L,9L,9L,9L,5L,8L,0L,9L,0L,1L,3L,4L,6L,8L,2L,1L,8L,1L,7L,9L,3L,7L,0L,9L,7L,6L,1L,8L,7L,9L,3L,1L,1L,8L,9L,8L,4L,9L,1L,4L,3L,1L,2L,6L,2L,8L,3L,3L,2L,9L,4L,7L,1L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153625Inst : IEnumerable<long>
{
public static readonly long[] Value=A153625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153625.Bytes);
public long this[int i]=>Value[i];

public static A153625Inst Instance=new A153625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153626
{
public static readonly long[] Value={ 7L,0L,1L,8L,3L,8L,7L,3L,0L,5L,1L,4L,4L,0L,1L,0L,2L,6L,8L,6L,0L,4L,9L,2L,3L,2L,9L,3L,0L,7L,9L,5L,7L,7L,0L,2L,1L,6L,0L,2L,5L,6L,6L,5L,6L,4L,9L,1L,5L,3L,5L,1L,9L,5L,9L,1L,9L,3L,2L,2L,9L,3L,1L,0L,1L,7L,5L,8L,0L,2L,1L,2L,2L,1L,5L,5L,4L,8L,2L,4L,6L,6L,2L,4L,4L,6L,5L,2L,4L,9L,7L,9L,2L,5L,5L,2L,6L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153626Inst : IEnumerable<long>
{
public static readonly long[] Value=A153626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153626.Bytes);
public long this[int i]=>Value[i];

public static A153626Inst Instance=new A153626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153627
{
public static readonly long[] Value={ 6L,8L,6L,8L,2L,0L,9L,0L,3L,5L,9L,9L,6L,6L,3L,0L,2L,8L,4L,3L,7L,1L,3L,2L,8L,3L,2L,7L,8L,1L,2L,9L,9L,4L,3L,8L,9L,4L,5L,1L,7L,0L,9L,4L,1L,5L,7L,1L,3L,0L,0L,2L,8L,2L,4L,6L,5L,3L,2L,5L,5L,8L,6L,9L,5L,3L,1L,6L,8L,6L,1L,0L,7L,2L,2L,2L,8L,2L,0L,3L,9L,0L,0L,1L,5L,4L,7L,4L,4L,9L,7L,1L,4L,6L,2L,7L,4L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153627Inst : IEnumerable<long>
{
public static readonly long[] Value=A153627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153627.Bytes);
public long this[int i]=>Value[i];

public static A153627Inst Instance=new A153627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153628
{
public static readonly long[] Value={ 6L,7L,3L,2L,3L,8L,7L,0L,8L,3L,9L,0L,8L,1L,8L,4L,4L,2L,8L,1L,1L,8L,0L,8L,2L,4L,8L,0L,4L,4L,4L,3L,3L,8L,5L,1L,0L,4L,5L,8L,5L,8L,4L,0L,2L,7L,7L,2L,1L,5L,8L,5L,2L,5L,0L,0L,8L,7L,8L,2L,2L,5L,6L,1L,1L,0L,6L,2L,6L,5L,7L,6L,8L,1L,7L,4L,5L,0L,2L,0L,3L,1L,1L,4L,5L,8L,7L,2L,9L,5L,7L,6L,0L,5L,3L,9L,2L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153628Inst : IEnumerable<long>
{
public static readonly long[] Value=A153628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153628.Bytes);
public long this[int i]=>Value[i];

public static A153628Inst Instance=new A153628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153629
{
public static readonly long[] Value={ 6L,6L,0L,8L,7L,6L,3L,7L,1L,6L,3L,6L,0L,6L,3L,9L,6L,4L,0L,2L,1L,1L,5L,7L,3L,5L,2L,1L,1L,1L,9L,4L,4L,8L,8L,8L,5L,8L,1L,3L,4L,3L,2L,0L,9L,4L,8L,0L,7L,0L,7L,5L,6L,3L,8L,8L,9L,6L,1L,2L,0L,9L,2L,8L,6L,7L,7L,7L,5L,1L,9L,5L,2L,6L,7L,3L,0L,0L,9L,6L,9L,5L,8L,0L,9L,4L,0L,1L,8L,2L,7L,3L,6L,8L,8L,1L,6L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153629Inst : IEnumerable<long>
{
public static readonly long[] Value=A153629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153629.Bytes);
public long this[int i]=>Value[i];

public static A153629Inst Instance=new A153629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153630
{
public static readonly long[] Value={ 6L,4L,9L,5L,6L,0L,7L,6L,5L,5L,7L,0L,9L,4L,3L,4L,2L,5L,6L,5L,4L,4L,3L,3L,1L,1L,3L,5L,5L,7L,6L,0L,3L,3L,0L,9L,7L,0L,8L,2L,5L,8L,5L,4L,1L,6L,3L,7L,6L,7L,8L,7L,5L,3L,2L,1L,9L,4L,2L,5L,1L,5L,9L,5L,7L,3L,4L,4L,4L,0L,4L,3L,9L,3L,9L,5L,2L,9L,7L,6L,7L,0L,7L,2L,4L,0L,4L,7L,0L,0L,7L,4L,5L,0L,5L,6L,6L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153630Inst : IEnumerable<long>
{
public static readonly long[] Value=A153630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153630.Bytes);
public long this[int i]=>Value[i];

public static A153630Inst Instance=new A153630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153631
{
public static readonly long[] Value={ 23L,29L,33L,39L,43L,49L,53L,59L,63L,69L,73L,79L,83L,89L,93L,99L,133L,136L,137L,192L,194L,195L,222L,223L,226L,229L,261L,263L,267L,313L,316L,331L,332L,333L,334L,336L,339L,391L,392L,397L,441L,443L,449L,621L,623L,661L,662L,663L,666L,669L,912L,914L,915L,931L,932L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153631Inst : IEnumerable<long>
{
public static readonly long[] Value=A153631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153631.Bytes);
public long this[int i]=>Value[i];

public static A153631Inst Instance=new A153631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153632
{
public static readonly long[] Value={ 6L,3L,9L,1L,5L,1L,1L,9L,3L,2L,8L,5L,4L,6L,9L,8L,2L,6L,7L,5L,4L,9L,1L,6L,2L,0L,3L,4L,9L,5L,6L,9L,4L,7L,3L,9L,9L,3L,5L,6L,1L,3L,5L,2L,0L,2L,5L,1L,2L,4L,2L,3L,5L,2L,3L,4L,0L,4L,1L,1L,8L,6L,2L,9L,3L,8L,5L,3L,0L,0L,5L,1L,8L,1L,8L,7L,2L,4L,0L,2L,1L,0L,9L,9L,6L,0L,6L,9L,1L,1L,1L,3L,2L,9L,0L,6L,7L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153632Inst : IEnumerable<long>
{
public static readonly long[] Value=A153632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153632.Bytes);
public long this[int i]=>Value[i];

public static A153632Inst Instance=new A153632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153633
{
public static readonly long[] Value={ 6L,2L,9L,5L,3L,2L,0L,0L,3L,6L,5L,8L,2L,3L,0L,5L,7L,4L,2L,6L,7L,0L,7L,5L,0L,3L,6L,0L,5L,7L,9L,7L,4L,5L,5L,0L,4L,2L,9L,6L,8L,7L,5L,9L,5L,7L,6L,5L,4L,7L,7L,3L,6L,2L,0L,2L,0L,8L,2L,1L,1L,6L,1L,4L,7L,1L,5L,1L,8L,5L,3L,8L,8L,6L,3L,3L,8L,6L,8L,2L,8L,9L,3L,4L,0L,0L,5L,8L,2L,2L,7L,1L,5L,3L,3L,6L,3L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153633Inst : IEnumerable<long>
{
public static readonly long[] Value=A153633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153633.Bytes);
public long this[int i]=>Value[i];

public static A153633Inst Instance=new A153633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153634
{
public static readonly long[] Value={ 2L,3L,6L,2L,3L,6L,6L,2L,5L,2L,4L,1L,4L,7L,5L,9L,7L,6L,8L,11L,7L,3L,3L,6L,7L,7L,3L,7L,7L,3L,6L,3L,9L,2L,7L,2L,9L,3L,3L,9L,2L,6L,3L,9L,4L,12L,3L,3L,6L,6L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153634Inst : IEnumerable<long>
{
public static readonly long[] Value=A153634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153634.Bytes);
public long this[int i]=>Value[i];

public static A153634Inst Instance=new A153634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153635
{
public static readonly long[] Value={ 23L,31L,59L,139L,211L,239L,283L,419L,491L,499L,563L,643L,743L,751L,823L,1291L,1319L,1327L,1399L,1427L,1579L,1823L,1931L,2039L,2687L,2767L,3011L,3119L,3163L,3191L,3271L,3299L,3307L,3371L,3559L,3767L,3803L,3919L,4027L,4091L,4099L,4243L,4423L,4567L,4639L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153635Inst : IEnumerable<long>
{
public static readonly long[] Value=A153635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153635.Bytes);
public long this[int i]=>Value[i];

public static A153635Inst Instance=new A153635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153636
{
public static readonly long[] Value={ 31L,59L,283L,499L,743L,1327L,1399L,1579L,1823L,2687L,3271L,3299L,3371L,3559L,3767L,4027L,4243L,4567L,4639L,5323L,5351L,6079L,8059L,8123L,8563L,9463L,9851L,9887L,10111L,10247L,11003L,11119L,11399L,11939L,12163L,13127L,13163L,14243L,14783L,15907L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153636Inst : IEnumerable<long>
{
public static readonly long[] Value=A153636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153636.Bytes);
public long this[int i]=>Value[i];

public static A153636Inst Instance=new A153636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153637
{
public static readonly long[] Value={ 2L,9L,9L,2L,212L,2L,2L,1618L,1618L,2L,2L,2100L,54116L,2100L,2L,2L,2786L,609572L,609572L,2786L,2L,2L,3712L,1582558L,26220736L,1582558L,3712L,2L,2L,4914L,3257870L,393546494L,393546494L,3257870L,4914L,2L,2L,6428L,6069056L,1593218212L,20609969404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153637Inst : IEnumerable<long>
{
public static readonly long[] Value=A153637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153637.Bytes);
public long this[int i]=>Value[i];

public static A153637Inst Instance=new A153637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153638
{
public static readonly long[] Value={ 0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153638Inst : IEnumerable<long>
{
public static readonly long[] Value=A153638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153638.Bytes);
public long this[int i]=>Value[i];

public static A153638Inst Instance=new A153638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153639
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153639Inst : IEnumerable<long>
{
public static readonly long[] Value=A153639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153639.Bytes);
public long this[int i]=>Value[i];

public static A153639Inst Instance=new A153639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153640
{
public static readonly long[] Value={ 1009L,1019L,1049L,1061L,1069L,1091L,1109L,1181L,1409L,1481L,1489L,1499L,1601L,1609L,1619L,1669L,1699L,1801L,1811L,1861L,1889L,1901L,1949L,1999L,4001L,4019L,4049L,4091L,4099L,4111L,4409L,4441L,4481L,4649L,4691L,4801L,4861L,4889L,4909L,4919L,4969L,4999L,6011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153640Inst : IEnumerable<long>
{
public static readonly long[] Value=A153640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153640.Bytes);
public long this[int i]=>Value[i];

public static A153640Inst Instance=new A153640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153641
{
public static readonly long[] Value={ 1L,1L,1L,-1L,1L,-3L,1L,-6L,5L,1L,-10L,25L,1L,-15L,75L,-61L,1L,-21L,175L,-427L,1L,-28L,350L,-1708L,1385L,1L,-36L,630L,-5124L,12465L,1L,-45L,1050L,-12810L,62325L,-50521L,1L,-55L,1650L,-28182L,228525L,-555731L,1L,-66L,2475L,-56364L,685575L,-3334386L,2702765L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153641Inst : IEnumerable<long>
{
public static readonly long[] Value=A153641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153641.Bytes);
public long this[int i]=>Value[i];

public static A153641Inst Instance=new A153641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153642
{
public static readonly long[] Value={ 36L,72L,116L,168L,228L,296L,372L,456L,548L,648L,756L,872L,996L,1128L,1268L,1416L,1572L,1736L,1908L,2088L,2276L,2472L,2676L,2888L,3108L,3336L,3572L,3816L,4068L,4328L,4596L,4872L,5156L,5448L,5748L,6056L,6372L,6696L,7028L,7368L,7716L,8072L,8436L,8808L,9188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153642Inst : IEnumerable<long>
{
public static readonly long[] Value=A153642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153642.Bytes);
public long this[int i]=>Value[i];

public static A153642Inst Instance=new A153642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153643
{
public static readonly long[] Value={ 2L,3L,3L,5L,7L,13L,23L,45L,87L,173L,343L,685L,1367L,2733L,5463L,10925L,21847L,43693L,87383L,174765L,349527L,699053L,1398103L,2796205L,5592407L,11184813L,22369623L,44739245L,89478487L,178956973L,357913943L,715827885L,1431655767L,2863311533L,5726623063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153643Inst : IEnumerable<long>
{
public static readonly long[] Value=A153643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153643.Bytes);
public long this[int i]=>Value[i];

public static A153643Inst Instance=new A153643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153644
{
public static readonly long[] Value={ 42L,82L,130L,186L,250L,322L,402L,490L,586L,690L,802L,922L,1050L,1186L,1330L,1482L,1642L,1810L,1986L,2170L,2362L,2562L,2770L,2986L,3210L,3442L,3682L,3930L,4186L,4450L,4722L,5002L,5290L,5586L,5890L,6202L,6522L,6850L,7186L,7530L,7882L,8242L,8610L,8986L,9370L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153644Inst : IEnumerable<long>
{
public static readonly long[] Value=A153644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153644.Bytes);
public long this[int i]=>Value[i];

public static A153644Inst Instance=new A153644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153645
{
public static readonly long[] Value={ 3L,5L,7L,13L,17L,47L,67L,73L,137L,167L,277L,307L,313L,487L,503L,593L,607L,613L,787L,823L,1117L,1123L,1237L,1523L,1543L,1637L,1987L,2777L,2887L,3037L,3163L,3433L,3457L,3463L,3797L,3853L,4093L,4283L,4583L,5113L,5297L,5323L,5683L,5953L,6047L,6577L,6803L,6823L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153645Inst : IEnumerable<long>
{
public static readonly long[] Value=A153645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153645.Bytes);
public long this[int i]=>Value[i];

public static A153645Inst Instance=new A153645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153646
{
public static readonly long[] Value={ 73L,55L,64L,55L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153646Inst : IEnumerable<long>
{
public static readonly long[] Value=A153646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153646.Bytes);
public long this[int i]=>Value[i];

public static A153646Inst Instance=new A153646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153647
{
public static readonly BigInteger[] Value={ 2L,18L,216L,3240L,58320L,1224720L,29393280L,793618560L,23808556800L,785682374400L,28284565478400L,1103098053657600L,46330118253619200L,2084855321412864000L,BigInteger.Parse("100073055427817472000"),BigInteger.Parse("5103725826818691072000"),BigInteger.Parse("275601194648209317888000") };
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
public class A153647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153647Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153647.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153647Inst Instance=new A153647Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153648
{
public static readonly long[] Value={ 2L,5L,5L,2L,46L,2L,2L,123L,123L,2L,2L,155L,936L,155L,2L,2L,187L,2936L,2936L,187L,2L,2L,219L,5448L,19912L,5448L,219L,2L,2L,251L,8472L,69400L,69400L,8472L,251L,2L,2L,283L,12008L,159592L,437480L,159592L,12008L,283L,2L,2L,315L,16056L,298680L,1638072L,1638072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153648Inst : IEnumerable<long>
{
public static readonly long[] Value=A153648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153648.Bytes);
public long this[int i]=>Value[i];

public static A153648Inst Instance=new A153648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153649
{
public static readonly long[] Value={ 2L,7L,7L,2L,94L,2L,2L,341L,341L,2L,2L,413L,3972L,413L,2L,2L,485L,16320L,16320L,485L,2L,2L,557L,31260L,171660L,31260L,557L,2L,2L,629L,48792L,774120L,774120L,48792L,629L,2L,2L,701L,68916L,1917012L,7556340L,1917012L,68916L,701L,2L,2L,773L,91632L,3693648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153649Inst : IEnumerable<long>
{
public static readonly long[] Value=A153649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153649.Bytes);
public long this[int i]=>Value[i];

public static A153649Inst Instance=new A153649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153650
{
public static readonly long[] Value={ 2L,11L,11L,2L,238L,2L,2L,1329L,1329L,2L,2L,1529L,26220L,1529L,2L,2L,1729L,159320L,159320L,1729L,2L,2L,1929L,312420L,2914420L,312420L,1929L,2L,2L,2129L,485520L,18999520L,18999520L,485520L,2129L,2L,2L,2329L,678620L,50414620L,326526620L,50414620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153650Inst : IEnumerable<long>
{
public static readonly long[] Value=A153650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153650.Bytes);
public long this[int i]=>Value[i];

public static A153650Inst Instance=new A153650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153651
{
public static readonly long[] Value={ 2L,13L,13L,2L,334L,2L,2L,2195L,2195L,2L,2L,2483L,52152L,2483L,2L,2L,2771L,368520L,368520L,2771L,2L,2L,3059L,726360L,8194776L,726360L,3059L,2L,2L,3347L,1125672L,61619496L,61619496L,1125672L,3347L,2L,2L,3635L,1566456L,166614648L,1295091960L,166614648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153651Inst : IEnumerable<long>
{
public static readonly long[] Value=A153651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153651.Bytes);
public long this[int i]=>Value[i];

public static A153651Inst Instance=new A153651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153652
{
public static readonly long[] Value={ 2L,17L,17L,2L,574L,2L,2L,4911L,4911L,2L,2L,5423L,156192L,5423L,2L,2L,5935L,1413920L,1413920L,5935L,2L,2L,6447L,2802720L,42656800L,2802720L,6447L,2L,2L,6959L,4322592L,406009120L,406009120L,4322592L,6959L,2L,2L,7471L,5973536L,1125025312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153652Inst : IEnumerable<long>
{
public static readonly long[] Value=A153652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153652.Bytes);
public long this[int i]=>Value[i];

public static A153652Inst Instance=new A153652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153653
{
public static readonly long[] Value={ 2L,19L,19L,2L,718L,2L,2L,6857L,6857L,2L,2L,7505L,245628L,7505L,2L,2L,8153L,2467944L,2467944L,8153L,2L,2L,8801L,4900212L,84273732L,4900212L,8801L,2L,2L,9449L,7542432L,886319856L,886319856L,7542432L,9449L,2L,2L,10097L,10394604L,2476630764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153653Inst : IEnumerable<long>
{
public static readonly long[] Value=A153653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153653.Bytes);
public long this[int i]=>Value[i];

public static A153653Inst Instance=new A153653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153654
{
public static readonly long[] Value={ 2L,23L,23L,2L,1054L,2L,2L,12165L,12165L,2L,2L,13041L,484928L,13041L,2L,2L,13917L,5814074L,5814074L,13917L,2L,2L,14793L,11526908L,223541684L,11526908L,14793L,2L,2L,15669L,17623430L,2775818930L,2775818930L,17623430L,15669L,2L,2L,16545L,24103640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153654Inst : IEnumerable<long>
{
public static readonly long[] Value=A153654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153654.Bytes);
public long this[int i]=>Value[i];

public static A153654Inst Instance=new A153654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153655
{
public static readonly long[] Value={ 2L,29L,29L,2L,1678L,2L,2L,24387L,24387L,2L,2L,25607L,1070676L,25607L,2L,2L,26827L,15947966L,15947966L,26827L,2L,2L,28047L,31569456L,683937616L,31569456L,28047L,2L,2L,29267L,47935146L,10427818366L,10427818366L,47935146L,29267L,2L,2L,30487L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153655Inst : IEnumerable<long>
{
public static readonly long[] Value=A153655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153655.Bytes);
public long this[int i]=>Value[i];

public static A153655Inst Instance=new A153655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153656
{
public static readonly long[] Value={ 2L,23L,23L,2L,1054L,2L,2L,12165L,12165L,2L,2L,13133L,533412L,13133L,2L,2L,14101L,6422240L,6422240L,14101L,2L,2L,15069L,12779580L,270482476L,12779580L,15069L,2L,2L,16037L,19605432L,3385203976L,3385203976L,19605432L,16037L,2L,2L,17005L,26899796L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153656Inst : IEnumerable<long>
{
public static readonly long[] Value=A153656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153656.Bytes);
public long this[int i]=>Value[i];

public static A153656Inst Instance=new A153656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153657
{
public static readonly long[] Value={ 2L,29L,29L,2L,1678L,2L,2L,24387L,24387L,2L,2L,25955L,1362648L,25955L,2L,2L,27523L,20483624L,20483624L,27523L,2L,2L,29091L,40833912L,1107920632L,40833912L,29091L,2L,2L,30659L,62413512L,17187432136L,17187432136L,62413512L,30659L,2L,2L,32227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153657Inst : IEnumerable<long>
{
public static readonly long[] Value=A153657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153657.Bytes);
public long this[int i]=>Value[i];

public static A153657Inst Instance=new A153657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153658
{
public static readonly long[] Value={ 2L,120L,120L,2L,1436L,2L,2L,5038L,5038L,2L,2L,5124L,70388L,5124L,2L,2L,5238L,357640L,357640L,5238L,2L,2L,5384L,731806L,5783216L,731806L,5384L,2L,2L,5566L,1208610L,38702622L,38702622L,1208610L,5566L,2L,2L,5788L,1806416L,120409892L,713559004L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153658Inst : IEnumerable<long>
{
public static readonly long[] Value=A153658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153658.Bytes);
public long this[int i]=>Value[i];

public static A153658Inst Instance=new A153658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153659
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,2L,1L,0L,1L,1L,0L,0L,0L,1L,3L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,4L,2L,0L,1L,0L,0L,0L,1L,2L,0L,1L,0L,0L,0L,0L,0L,1L,3L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,8L,3L,2L,1L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,3L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153659Inst : IEnumerable<long>
{
public static readonly long[] Value=A153659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153659.Bytes);
public long this[int i]=>Value[i];

public static A153659Inst Instance=new A153659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153660
{
public static readonly long[] Value={ 527L,529L,899L,901L,1079L,1081L,1157L,1159L,1271L,1273L,1649L,1651L,1679L,1681L,1817L,1819L,1919L,1921L,1961L,1963L,2117L,2119L,2171L,2173L,2327L,2329L,2489L,2491L,2507L,2509L,2771L,2773L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153660Inst : IEnumerable<long>
{
public static readonly long[] Value=A153660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153660.Bytes);
public long this[int i]=>Value[i];

public static A153660Inst Instance=new A153660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153661
{
public static readonly long[] Value={ 1L,4L,1L,0L,4L,1L,5L,8L,2L,1L,4L,6L,4L,2L,1L,4L,4L,4L,8L,4L,1L,2L,4L,8L,4L,2L,4L,1L,8L,2L,8L,4L,2L,8L,2L,1L,0L,0L,0L,0L,0L,0L,4L,2L,1L,4L,10L,16L,8L,4L,10L,16L,8L,4L,1L,16L,4L,16L,8L,4L,16L,4L,12L,16L,4L,1L,11L,8L,2L,1L,11L,8L,2L,1L,11L,8L,2L,1L,14L,20L,16L,8L,4L,12L,14L,18L,20L,16L,4L,2L,1L,16L,16L,16L,8L,16L,16L,16L,8L,16L,16L,16L,8L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153661Inst : IEnumerable<long>
{
public static readonly long[] Value=A153661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153661.Bytes);
public long this[int i]=>Value[i];

public static A153661Inst Instance=new A153661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153662
{
public static readonly long[] Value={ 1L,2L,4L,7L,3328L,3329L,4097L,12429L,12430L,12431L,18587L,44257L,112896L,129638L,4264691L,144941960L,144941961L,144941962L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153662Inst : IEnumerable<long>
{
public static readonly long[] Value=A153662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153662.Bytes);
public long this[int i]=>Value[i];

public static A153662Inst Instance=new A153662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153663
{
public static readonly long[] Value={ 1L,5L,8L,10L,12L,14L,46L,58L,105L,157L,163L,455L,1060L,1256L,2677L,8093L,28277L,33327L,49304L,158643L,164000L,835999L,2242294L,25380333L,92600006L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153663Inst : IEnumerable<long>
{
public static readonly long[] Value=A153663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153663.Bytes);
public long this[int i]=>Value[i];

public static A153663Inst Instance=new A153663Inst();

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