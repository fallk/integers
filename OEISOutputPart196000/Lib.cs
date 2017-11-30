using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A246662
{
public static readonly BigInteger[] Value={ -10L,7L,-3L,1L,0L,1L,5L,31L,222L,1807L,16485L,166657L,1849712L,22363201L,292571325L,4118361751L,62067997590L,997206323191L,17014575491837L,307259565176257L,5854946313840720L,117406185841990657L,2471384848995644517L,BigInteger.Parse("54487872863746170031"),BigInteger.Parse("1255692460715157555230") };
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
public class A246662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246662Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246662.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246662Inst Instance=new A246662Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246663
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,12L,16L,20L,24L,30L,32L,36L,40L,48L,60L,64L,70L,72L,80L,96L,120L,128L,140L,144L,160L,180L,192L,216L,240L,252L,256L,280L,288L,320L,360L,384L,400L,420L,432L,480L,504L,512L,560L,576L,600L,630L,640L,720L,768L,800L,840L,864L,900L,960L,1008L,1024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246663Inst : IEnumerable<long>
{
public static readonly long[] Value=A246663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246663.Bytes);
public long this[int i]=>Value[i];

public static A246663Inst Instance=new A246663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246664
{
public static readonly long[] Value={ 2L,1L,1L,9L,8L,2L,4L,4L,0L,9L,8L,9L,2L,0L,6L,3L,6L,4L,9L,4L,6L,4L,0L,0L,5L,3L,8L,3L,0L,0L,7L,4L,0L,9L,1L,5L,4L,5L,5L,4L,4L,6L,3L,9L,6L,3L,2L,5L,3L,4L,1L,9L,8L,5L,4L,0L,9L,2L,0L,2L,7L,5L,4L,2L,6L,7L,6L,2L,7L,7L,4L,3L,8L,7L,1L,8L,5L,4L,8L,7L,9L,8L,2L,3L,9L,8L,7L,3L,8L,6L,2L,6L,6L,3L,0L,3L,2L,3L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246664Inst : IEnumerable<long>
{
public static readonly long[] Value=A246664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246664.Bytes);
public long this[int i]=>Value[i];

public static A246664Inst Instance=new A246664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246665
{
public static readonly long[] Value={ 4L,3L,5L,1L,7L,0L,8L,0L,5L,5L,8L,0L,1L,2L,7L,6L,5L,8L,0L,5L,9L,1L,8L,9L,9L,1L,2L,8L,4L,7L,8L,5L,8L,4L,1L,0L,4L,2L,7L,9L,6L,2L,5L,9L,4L,7L,5L,3L,4L,7L,0L,2L,4L,7L,0L,2L,9L,7L,9L,1L,2L,3L,0L,4L,4L,3L,9L,0L,6L,6L,5L,8L,7L,5L,4L,4L,3L,0L,3L,3L,5L,7L,8L,4L,9L,9L,7L,6L,6L,2L,8L,6L,8L,5L,0L,2L,6L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246665Inst : IEnumerable<long>
{
public static readonly long[] Value=A246665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246665.Bytes);
public long this[int i]=>Value[i];

public static A246665Inst Instance=new A246665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246666
{
public static readonly long[] Value={ 1L,3L,5L,9L,31L,43L,45L,51L,71L,89L,135L,141L,145L,149L,159L,163L,169L,183L,185L,225L,233L,241L,255L,261L,271L,281L,283L,285L,299L,309L,311L,313L,355L,395L,401L,411L,415L,423L,429L,435L,449L,453L,485L,491L,541L,551L,561L,579L,583L,589L,603L,621L,625L,635L,681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246666Inst : IEnumerable<long>
{
public static readonly long[] Value=A246666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246666.Bytes);
public long this[int i]=>Value[i];

public static A246666Inst Instance=new A246666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246667
{
public static readonly long[] Value={ 1L,3L,4L,5L,0L,1L,6L,6L,1L,7L,0L,2L,1L,9L,9L,6L,9L,8L,4L,4L,9L,0L,5L,7L,9L,9L,1L,9L,9L,9L,8L,6L,9L,1L,5L,0L,1L,5L,3L,8L,7L,5L,8L,4L,2L,0L,6L,0L,6L,3L,6L,7L,5L,4L,1L,6L,2L,8L,7L,2L,6L,1L,0L,5L,7L,9L,1L,3L,1L,4L,6L,4L,9L,5L,5L,9L,7L,2L,0L,5L,8L,8L,3L,9L,0L,5L,8L,1L,8L,7L,3L,7L,8L,3L,8L,9L,8L,6L,5L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246667Inst : IEnumerable<long>
{
public static readonly long[] Value=A246667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246667.Bytes);
public long this[int i]=>Value[i];

public static A246667Inst Instance=new A246667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246668
{
public static readonly long[] Value={ 4L,4L,9L,2L,4L,7L,2L,1L,8L,8L,6L,9L,2L,1L,6L,2L,7L,1L,2L,2L,9L,8L,7L,9L,3L,9L,4L,3L,7L,9L,7L,0L,9L,2L,6L,7L,5L,0L,4L,8L,5L,8L,7L,3L,6L,3L,6L,9L,4L,5L,9L,4L,6L,4L,8L,6L,8L,4L,1L,3L,7L,4L,7L,6L,4L,4L,9L,3L,5L,5L,5L,8L,6L,7L,2L,6L,3L,2L,6L,4L,2L,4L,5L,5L,4L,8L,0L,4L,3L,7L,2L,7L,6L,8L,7L,6L,8L,4L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246668Inst : IEnumerable<long>
{
public static readonly long[] Value=A246668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246668.Bytes);
public long this[int i]=>Value[i];

public static A246668Inst Instance=new A246668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246669
{
public static readonly BigInteger[] Value={ 2L,5L,42L,429L,58786L,742900L,129644790L,1767263190L,343059613650L,1002242216651368L,14544636039226909L,BigInteger.Parse("45950804324621742364"),BigInteger.Parse("10113918591637898134020"),BigInteger.Parse("150853479205085351660700"),BigInteger.Parse("33868773757191046886429490"),BigInteger.Parse("116157871455782434250553845880") };
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
public class A246669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246669Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246669.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246669Inst Instance=new A246669Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246670
{
public static readonly long[] Value={ 2L,2L,3L,11L,43L,181L,743L,2971L,11933L,47129L,185569L,729947L,2868191L,11265517L,44230699L,173632489L,681785497L,2677741049L,10520707411L,41351166313L,162595828093L,639609298351L,2517120334919L,9910036308649L,39032346154387L,153796890460823L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246670Inst : IEnumerable<long>
{
public static readonly long[] Value=A246670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246670.Bytes);
public long this[int i]=>Value[i];

public static A246670Inst Instance=new A246670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246671
{
public static readonly long[] Value={ 8L,3L,9L,9L,2L,3L,6L,7L,5L,6L,9L,2L,3L,7L,2L,6L,8L,9L,6L,0L,3L,7L,7L,6L,9L,7L,7L,4L,2L,1L,8L,1L,5L,5L,6L,9L,3L,6L,1L,6L,2L,0L,6L,9L,8L,7L,0L,3L,9L,1L,2L,8L,5L,0L,4L,1L,5L,8L,2L,7L,2L,1L,6L,3L,6L,0L,9L,0L,8L,9L,6L,8L,6L,3L,9L,5L,3L,4L,6L,3L,8L,0L,6L,3L,8L,8L,0L,2L,0L,9L,6L,4L,6L,8L,0L,9L,7L,9L,9L,9L,9L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246671Inst : IEnumerable<long>
{
public static readonly long[] Value=A246671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246671.Bytes);
public long this[int i]=>Value[i];

public static A246671Inst Instance=new A246671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246672
{
public static readonly long[] Value={ 2L,7L,9L,3L,9L,9L,7L,6L,5L,2L,6L,0L,1L,5L,5L,0L,7L,9L,6L,0L,9L,9L,0L,7L,1L,1L,4L,1L,3L,6L,6L,8L,5L,0L,4L,2L,5L,8L,0L,0L,8L,3L,9L,1L,1L,6L,6L,2L,7L,3L,4L,2L,1L,1L,6L,1L,3L,5L,1L,5L,9L,8L,3L,1L,5L,4L,4L,3L,6L,3L,6L,4L,8L,8L,8L,9L,2L,8L,6L,8L,3L,5L,6L,2L,1L,1L,7L,4L,5L,6L,8L,8L,4L,2L,9L,1L,3L,5L,6L,0L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246672Inst : IEnumerable<long>
{
public static readonly long[] Value=A246672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246672.Bytes);
public long this[int i]=>Value[i];

public static A246672Inst Instance=new A246672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246673
{
public static readonly long[] Value={ 1L,1L,6L,5L,6L,2L,3L,2L,8L,7L,7L,3L,1L,6L,2L,2L,7L,7L,2L,0L,8L,2L,1L,5L,2L,0L,2L,1L,1L,0L,7L,5L,4L,0L,4L,0L,8L,2L,5L,5L,4L,9L,1L,3L,4L,5L,9L,6L,3L,3L,4L,2L,1L,0L,3L,0L,1L,9L,0L,0L,5L,3L,3L,6L,8L,9L,2L,2L,1L,4L,1L,5L,7L,7L,7L,7L,3L,4L,1L,2L,0L,7L,5L,2L,0L,1L,9L,1L,9L,6L,4L,8L,9L,9L,2L,5L,5L,9L,9L,2L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246673Inst : IEnumerable<long>
{
public static readonly long[] Value=A246673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246673.Bytes);
public long this[int i]=>Value[i];

public static A246673Inst Instance=new A246673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246674
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,1L,3L,7L,1L,1L,1L,3L,3L,3L,7L,15L,1L,1L,1L,3L,1L,1L,3L,7L,3L,3L,3L,9L,7L,7L,15L,31L,1L,1L,1L,3L,1L,1L,3L,7L,1L,1L,1L,3L,3L,3L,7L,15L,3L,3L,3L,9L,3L,3L,9L,21L,7L,7L,7L,21L,15L,15L,31L,63L,1L,1L,1L,3L,1L,1L,3L,7L,1L,1L,1L,3L,3L,3L,7L,15L,1L,1L,1L,3L,1L,1L,3L,7L,3L,3L,3L,9L,7L,7L,15L,31L,3L,3L,3L,9L,3L,3L,9L,21L,3L,3L,3L,9L,9L,9L,21L,45L,7L,7L,7L,21L,7L,7L,21L,49L,15L,15L,15L,45L,31L,31L,63L,127L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246674Inst : IEnumerable<long>
{
public static readonly long[] Value=A246674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246674.Bytes);
public long this[int i]=>Value[i];

public static A246674Inst Instance=new A246674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246675
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,8L,7L,6L,9L,16L,11L,32L,13L,10L,15L,64L,17L,128L,19L,18L,21L,256L,23L,12L,25L,14L,27L,512L,29L,1024L,31L,26L,33L,20L,35L,2048L,37L,42L,39L,4096L,41L,8192L,43L,22L,45L,16384L,47L,24L,49L,50L,51L,32768L,53L,36L,55L,66L,57L,65536L,59L,131072L,61L,38L,63L,52L,65L,262144L,67L,74L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246675Inst : IEnumerable<long>
{
public static readonly long[] Value=A246675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246675.Bytes);
public long this[int i]=>Value[i];

public static A246675Inst Instance=new A246675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246676
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,8L,7L,6L,9L,14L,11L,24L,13L,26L,15L,10L,17L,20L,19L,34L,21L,44L,23L,48L,25L,32L,27L,124L,29L,80L,31L,12L,33L,74L,35L,54L,37L,62L,39L,76L,41L,38L,43L,174L,45L,134L,47L,120L,49L,50L,51L,64L,53L,98L,55L,342L,57L,104L,59L,624L,61L,242L,63L,16L,65L,56L,67L,244L,69L,224L,71L,90L,73L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246676Inst : IEnumerable<long>
{
public static readonly long[] Value=A246676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246676.Bytes);
public long this[int i]=>Value[i];

public static A246676Inst Instance=new A246676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246677
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,8L,7L,6L,9L,16L,11L,32L,17L,10L,15L,64L,13L,128L,19L,18L,33L,256L,23L,12L,65L,14L,35L,512L,21L,1024L,31L,26L,129L,20L,27L,2048L,257L,42L,39L,4096L,37L,8192L,67L,22L,513L,16384L,47L,24L,25L,50L,131L,32768L,29L,36L,71L,66L,1025L,65536L,43L,131072L,2049L,38L,63L,52L,53L,262144L,259L,74L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246677Inst : IEnumerable<long>
{
public static readonly long[] Value=A246677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246677.Bytes);
public long this[int i]=>Value[i];

public static A246677Inst Instance=new A246677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246678
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,8L,7L,6L,9L,14L,11L,24L,17L,26L,15L,10L,13L,20L,19L,34L,29L,44L,23L,48L,49L,32L,35L,124L,53L,80L,31L,12L,21L,74L,27L,54L,41L,62L,39L,76L,69L,38L,59L,174L,89L,134L,47L,120L,97L,50L,99L,64L,65L,98L,71L,342L,249L,104L,107L,624L,161L,242L,63L,16L,25L,56L,43L,244L,149L,224L,55L,90L,109L,68L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246678Inst : IEnumerable<long>
{
public static readonly long[] Value=A246678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246678.Bytes);
public long this[int i]=>Value[i];

public static A246678Inst Instance=new A246678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246679
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,16L,5L,32L,64L,9L,128L,6L,7L,256L,512L,13L,10L,1024L,21L,2048L,4096L,11L,8192L,12L,25L,16384L,18L,33L,32768L,65536L,19L,26L,131072L,37L,262144L,524288L,17L,20L,1048576L,15L,2097152L,42L,45L,4194304L,36L,57L,50L,8388608L,27L,16777216L,33554432L,29L,67108864L,134217728L,61L,268435456L,66L,43L,52L,24L,73L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246679Inst : IEnumerable<long>
{
public static readonly long[] Value=A246679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246679.Bytes);
public long this[int i]=>Value[i];

public static A246679Inst Instance=new A246679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246680
{
public static readonly long[] Value={ 1L,2L,4L,3L,7L,12L,13L,5L,10L,17L,22L,24L,16L,62L,40L,6L,37L,27L,31L,38L,19L,87L,67L,60L,25L,32L,49L,171L,52L,312L,121L,8L,28L,122L,112L,45L,34L,137L,94L,71L,82L,42L,58L,269L,43L,437L,202L,84L,73L,47L,76L,59L,187L,162L,148L,665L,46L,192L,157L,1200L,55L,1562L,364L,9L,97L,57L,85L,423L,115L,612L,337L,93L,61L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246680Inst : IEnumerable<long>
{
public static readonly long[] Value=A246680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246680.Bytes);
public long this[int i]=>Value[i];

public static A246680Inst Instance=new A246680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246681
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,7L,6L,9L,10L,8L,14L,11L,12L,15L,18L,20L,16L,25L,28L,21L,22L,24L,30L,27L,36L,40L,32L,50L,56L,33L,42L,13L,44L,48L,60L,54L,72L,45L,80L,64L,100L,35L,112L,75L,66L,84L,26L,63L,88L,96L,120L,108L,144L,81L,90L,160L,128L,200L,70L,49L,224L,99L,150L,132L,168L,52L,126L,55L,176L,192L,240L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246681Inst : IEnumerable<long>
{
public static readonly long[] Value=A246681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246681.Bytes);
public long this[int i]=>Value[i];

public static A246681Inst Instance=new A246681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246682
{
public static readonly long[] Value={ 0L,1L,2L,4L,3L,6L,5L,9L,7L,8L,11L,12L,31L,10L,13L,16L,127L,14L,709L,15L,19L,20L,5381L,21L,17L,46L,23L,18L,52711L,22L,648391L,26L,29L,166L,41L,24L,9737333L,858L,71L,25L,174440041L,30L,3657500101L,32L,37L,6186L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246682Inst : IEnumerable<long>
{
public static readonly long[] Value=A246682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246682.Bytes);
public long this[int i]=>Value[i];

public static A246682Inst Instance=new A246682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246683
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,8L,7L,6L,9L,16L,15L,32L,13L,10L,11L,64L,17L,128L,31L,18L,29L,256L,63L,12L,25L,14L,19L,512L,21L,1024L,127L,26L,33L,20L,255L,2048L,61L,58L,35L,4096L,57L,8192L,511L,30L,125L,16384L,23L,24L,49L,50L,27L,32768L,37L,36L,1023L,66L,41L,65536L,2047L,131072L,253L,62L,51L,52L,65L,262144L,39L,122L,509L,524288L,4095L,1048576L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246683Inst : IEnumerable<long>
{
public static readonly long[] Value=A246683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246683.Bytes);
public long this[int i]=>Value[i];

public static A246683Inst Instance=new A246683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246684
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,8L,7L,6L,9L,14L,15L,24L,13L,26L,11L,10L,17L,20L,27L,34L,29L,80L,47L,48L,25L,32L,51L,124L,21L,44L,19L,12L,33L,74L,39L,54L,53L,98L,67L,76L,57L,104L,159L,624L,93L,404L,95L,120L,49L,50L,63L,64L,101L,152L,247L,342L,41L,38L,87L,174L,37L,62L,23L,16L,65L,56L,147L,244L,77L,188L,107L,90L,105L,374L,195L,324L,133L,170L,151L,142L,113L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246684Inst : IEnumerable<long>
{
public static readonly long[] Value=A246684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246684.Bytes);
public long this[int i]=>Value[i];

public static A246684Inst Instance=new A246684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246685
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,1L,3L,5L,1L,1L,1L,3L,3L,3L,5L,17L,1L,1L,1L,3L,1L,1L,3L,5L,3L,3L,3L,9L,5L,5L,17L,257L,1L,1L,1L,3L,1L,1L,3L,5L,1L,1L,1L,3L,3L,3L,5L,17L,3L,3L,3L,9L,3L,3L,9L,15L,5L,5L,5L,15L,17L,17L,257L,65537L,1L,1L,1L,3L,1L,1L,3L,5L,1L,1L,1L,3L,3L,3L,5L,17L,1L,1L,1L,3L,1L,1L,3L,5L,3L,3L,3L,9L,5L,5L,17L,257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246685Inst : IEnumerable<long>
{
public static readonly long[] Value=A246685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246685.Bytes);
public long this[int i]=>Value[i];

public static A246685Inst Instance=new A246685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246686
{
public static readonly long[] Value={ 4L,0L,3L,9L,1L,2L,7L,2L,0L,2L,9L,8L,7L,5L,5L,8L,3L,7L,9L,3L,2L,1L,1L,4L,2L,0L,7L,4L,4L,9L,5L,3L,4L,9L,8L,8L,7L,1L,0L,2L,7L,1L,9L,2L,9L,3L,7L,7L,5L,4L,3L,2L,6L,4L,4L,1L,1L,4L,4L,6L,8L,8L,4L,6L,3L,3L,6L,8L,6L,3L,0L,7L,0L,1L,2L,9L,4L,0L,2L,3L,6L,5L,9L,3L,7L,6L,9L,6L,2L,1L,6L,8L,0L,6L,4L,3L,0L,5L,0L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246686Inst : IEnumerable<long>
{
public static readonly long[] Value=A246686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246686.Bytes);
public long this[int i]=>Value[i];

public static A246686Inst Instance=new A246686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246687
{
public static readonly long[] Value={ 0L,9L,1L,9L,2L,7L,5L,7L,5L,7L,7L,4L,7L,1L,8L,0L,2L,3L,8L,1L,5L,0L,4L,0L,2L,4L,3L,2L,1L,1L,0L,7L,2L,2L,6L,3L,5L,8L,1L,4L,0L,0L,7L,2L,9L,2L,9L,5L,4L,5L,6L,4L,5L,2L,7L,6L,2L,5L,0L,3L,5L,8L,0L,2L,0L,0L,9L,3L,2L,8L,1L,9L,5L,1L,7L,4L,0L,9L,6L,0L,0L,8L,4L,1L,8L,2L,1L,6L,9L,3L,5L,8L,2L,9L,4L,8L,6L,9L,8L,8L,8L,2L,2L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246687Inst : IEnumerable<long>
{
public static readonly long[] Value=A246687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246687.Bytes);
public long this[int i]=>Value[i];

public static A246687Inst Instance=new A246687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246688
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,1L,3L,4L,1L,4L,2L,3L,5L,1L,2L,3L,1L,5L,2L,4L,6L,1L,2L,4L,1L,6L,2L,5L,3L,4L,7L,1L,2L,5L,1L,3L,4L,1L,7L,2L,6L,3L,5L,8L,1L,2L,6L,1L,3L,5L,1L,8L,2L,3L,4L,2L,7L,3L,6L,4L,5L,9L,1L,2L,3L,4L,1L,2L,7L,1L,3L,6L,1L,4L,5L,1L,9L,2L,3L,5L,2L,8L,3L,7L,4L,6L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246688Inst : IEnumerable<long>
{
public static readonly long[] Value=A246688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246688.Bytes);
public long this[int i]=>Value[i];

public static A246688Inst Instance=new A246688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246689
{
public static readonly BigInteger[] Value={ 1L,1L,3L,13L,61L,381L,2791L,22513L,210393L,2183401L,24575851L,305067621L,4097726293L,58876485253L,910581818511L,15005958062761L,261751577640241L,4844661893762193L,94564968066402643L,1938366513866527741L,BigInteger.Parse("41760228574294689261"),BigInteger.Parse("941821175462309114701") };
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
public class A246689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246689Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246689.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246689Inst Instance=new A246689Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246690
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,2L,0L,1L,0L,1L,1L,0L,3L,1L,1L,0L,1L,0L,1L,1L,5L,0L,1L,0L,1L,1L,0L,2L,0L,8L,1L,1L,0L,1L,0L,1L,0L,3L,0L,13L,0L,1L,0L,1L,0L,1L,1L,1L,4L,1L,21L,1L,1L,0L,1L,1L,0L,1L,2L,0L,6L,0L,34L,0L,1L,0L,1L,1L,2L,0L,1L,3L,0L,9L,0L,55L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246690Inst : IEnumerable<long>
{
public static readonly long[] Value=A246690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246690.Bytes);
public long this[int i]=>Value[i];

public static A246690Inst Instance=new A246690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246691
{
public static readonly long[] Value={ 1L,1L,1L,3L,0L,4L,0L,5L,4L,0L,274L,11L,13L,0L,1601L,21L,11L,10L,0L,15571L,7921L,53L,41L,12L,1L,246441L,64208L,119L,16169L,47L,89L,35L,0L,1439975216L,17319590L,1835123L,956698L,531L,274291L,0L,82L,0L,0L,428262742476L,1923714115L,72992449L,20086406L,1915L,4051405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246691Inst : IEnumerable<long>
{
public static readonly long[] Value=A246691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246691.Bytes);
public long this[int i]=>Value[i];

public static A246691Inst Instance=new A246691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246692
{
public static readonly long[] Value={ 1L,2L,4L,8L,12L,16L,24L,32L,36L,48L,60L,64L,72L,84L,96L,108L,120L,128L,132L,136L,144L,168L,180L,192L,216L,240L,252L,256L,264L,272L,288L,300L,324L,336L,360L,384L,396L,408L,420L,432L,480L,504L,512L,528L,540L,544L,576L,588L,600L,648L,660L,672L,720L,756L,768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246692Inst : IEnumerable<long>
{
public static readonly long[] Value=A246692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246692.Bytes);
public long this[int i]=>Value[i];

public static A246692Inst Instance=new A246692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246693
{
public static readonly BigInteger[] Value={ 1L,1L,3L,51L,1155L,29427L,22639155L,19594173939L,591666769155L,17395890501991155L,BigInteger.Parse("545562959212245745155"),BigInteger.Parse("17374763192966689655283"),BigInteger.Parse("17822632594268121083311155"),BigInteger.Parse("98871007862168357169507809155"),BigInteger.Parse("20542323580569158999838073680199155") };
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
public class A246693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246693Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246693.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246693Inst Instance=new A246693Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246694
{
public static readonly long[] Value={ 1L,1L,2L,3L,2L,4L,3L,5L,4L,6L,7L,5L,8L,6L,9L,7L,10L,8L,11L,9L,12L,13L,10L,14L,11L,15L,12L,16L,13L,17L,14L,18L,15L,19L,16L,20L,21L,17L,22L,18L,23L,19L,24L,20L,25L,21L,26L,22L,27L,23L,28L,24L,29L,25L,30L,31L,26L,32L,27L,33L,28L,34L,29L,35L,30L,36L,31L,37L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246694Inst : IEnumerable<long>
{
public static readonly long[] Value=A246694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246694.Bytes);
public long this[int i]=>Value[i];

public static A246694Inst Instance=new A246694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246695
{
public static readonly long[] Value={ 1L,3L,9L,18L,35L,57L,91L,132L,189L,255L,341L,438L,559L,693L,855L,1032L,1241L,1467L,1729L,2010L,2331L,2673L,3059L,3468L,3925L,4407L,4941L,5502L,6119L,6765L,7471L,8208L,9009L,9843L,10745L,11682L,12691L,13737L,14859L,16020L,17261L,18543L,19909L,21318L,22815L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246695Inst : IEnumerable<long>
{
public static readonly long[] Value=A246695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246695.Bytes);
public long this[int i]=>Value[i];

public static A246695Inst Instance=new A246695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246696
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,7L,6L,9L,8L,11L,13L,10L,15L,12L,17L,14L,19L,16L,21L,18L,23L,25L,20L,27L,22L,29L,24L,31L,26L,33L,28L,35L,30L,37L,32L,39L,41L,34L,43L,36L,45L,38L,47L,40L,49L,42L,51L,44L,53L,46L,55L,48L,57L,50L,59L,61L,52L,63L,54L,65L,56L,67L,58L,69L,60L,71L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246696Inst : IEnumerable<long>
{
public static readonly long[] Value=A246696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246696.Bytes);
public long this[int i]=>Value[i];

public static A246696Inst Instance=new A246696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246697
{
public static readonly long[] Value={ 1L,5L,16L,34L,67L,111L,178L,260L,373L,505L,676L,870L,1111L,1379L,1702L,2056L,2473L,2925L,3448L,4010L,4651L,5335L,6106L,6924L,7837L,8801L,9868L,10990L,12223L,13515L,14926L,16400L,18001L,19669L,21472L,23346L,25363L,27455L,29698L,32020L,34501L,37065L,39796L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246697Inst : IEnumerable<long>
{
public static readonly long[] Value=A246697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246697.Bytes);
public long this[int i]=>Value[i];

public static A246697Inst Instance=new A246697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246698
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,7L,6L,9L,8L,12L,10L,14L,11L,16L,13L,18L,15L,20L,17L,23L,19L,25L,21L,27L,22L,29L,24L,31L,26L,33L,28L,35L,30L,38L,32L,40L,34L,42L,36L,44L,37L,46L,39L,48L,41L,50L,43L,52L,45L,54L,47L,57L,49L,59L,51L,61L,53L,63L,55L,65L,56L,67L,58L,69L,60L,71L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246698Inst : IEnumerable<long>
{
public static readonly long[] Value=A246698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246698.Bytes);
public long this[int i]=>Value[i];

public static A246698Inst Instance=new A246698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246699
{
public static readonly long[] Value={ 1L,2L,3L,6L,11L,21L,29L,31L,51L,55L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246699Inst : IEnumerable<long>
{
public static readonly long[] Value=A246699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246699.Bytes);
public long this[int i]=>Value[i];

public static A246699Inst Instance=new A246699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246700
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,4L,2L,1L,5L,4L,2L,1L,6L,2L,1L,7L,6L,2L,1L,8L,2L,1L,9L,6L,2L,1L,10L,4L,2L,1L,11L,10L,4L,2L,1L,12L,2L,1L,13L,12L,2L,1L,14L,6L,2L,1L,15L,4L,2L,1L,16L,4L,2L,1L,17L,16L,4L,2L,1L,18L,6L,2L,1L,19L,18L,6L,2L,1L,20L,4L,2L,1L,21L,6L,2L,1L,22L,10L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246700Inst : IEnumerable<long>
{
public static readonly long[] Value=A246700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246700.Bytes);
public long this[int i]=>Value[i];

public static A246700Inst Instance=new A246700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246701
{
public static readonly long[] Value={ 3L,7L,10L,16L,9L,27L,32L,32L,17L,17L,38L,64L,64L,64L,64L,64L,33L,33L,33L,33L,33L,107L,128L,128L,128L,128L,128L,128L,128L,128L,128L,128L,65L,65L,65L,65L,65L,65L,65L,65L,65L,65L,150L,256L,256L,256L,256L,256L,256L,256L,256L,256L,256L,256L,256L,256L,256L,256L,256L,256L,256L,256L,256L,256L,129L,129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246701Inst : IEnumerable<long>
{
public static readonly long[] Value=A246701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246701.Bytes);
public long this[int i]=>Value[i];

public static A246701Inst Instance=new A246701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246702
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,1L,1L,3L,2L,1L,10L,2L,1L,1L,1L,6L,3L,2L,1L,9L,2L,3L,3L,2L,2L,6L,1L,13L,9L,1L,1L,10L,5L,1L,3L,2L,8L,3L,2L,2L,1L,1L,10L,3L,8L,7L,9L,2L,2L,3L,1L,2L,26L,1L,3L,9L,4L,2L,9L,4L,1L,6L,1L,18L,9L,1L,7L,3L,2L,1L,3L,2L,5L,10L,1L,10L,6L,38L,3L,3L,4L,1L,41L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246702Inst : IEnumerable<long>
{
public static readonly long[] Value=A246702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246702.Bytes);
public long this[int i]=>Value[i];

public static A246702Inst Instance=new A246702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246703
{
public static readonly long[] Value={ 1L,2L,4L,8L,11L,28L,53L,78L,83L,98L,103L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246703Inst : IEnumerable<long>
{
public static readonly long[] Value=A246703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246703.Bytes);
public long this[int i]=>Value[i];

public static A246703Inst Instance=new A246703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246704
{
public static readonly long[] Value={ 1L,5L,11L,17L,49L,51L,59L,83L,92L,101L,116L,123L,131L,143L,153L,177L,183L,196L,200L,213L,218L,263L,273L,279L,290L,303L,311L,339L,344L,359L,389L,393L,399L,423L,449L,459L,470L,483L,491L,503L,521L,538L,549L,554L,569L,579L,596L,623L,633L,650L,683L,693L,699L,710L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246704Inst : IEnumerable<long>
{
public static readonly long[] Value=A246704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246704.Bytes);
public long this[int i]=>Value[i];

public static A246704Inst Instance=new A246704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246705
{
public static readonly long[] Value={ 1L,3L,4L,6L,8L,10L,11L,13L,15L,17L,19L,21L,22L,24L,26L,28L,30L,32L,34L,36L,37L,39L,41L,43L,45L,47L,49L,51L,53L,55L,56L,58L,60L,62L,64L,66L,68L,70L,72L,74L,76L,78L,79L,81L,83L,85L,87L,89L,91L,93L,95L,97L,99L,101L,103L,105L,106L,108L,110L,112L,114L,116L,118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246705Inst : IEnumerable<long>
{
public static readonly long[] Value=A246705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246705.Bytes);
public long this[int i]=>Value[i];

public static A246705Inst Instance=new A246705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246706
{
public static readonly long[] Value={ 2L,5L,7L,9L,12L,14L,16L,18L,20L,23L,25L,27L,29L,31L,33L,35L,38L,40L,42L,44L,46L,48L,50L,52L,54L,57L,59L,61L,63L,65L,67L,69L,71L,73L,75L,77L,80L,82L,84L,86L,88L,90L,92L,94L,96L,98L,100L,102L,104L,107L,109L,111L,113L,115L,117L,119L,121L,123L,125L,127L,129L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246706Inst : IEnumerable<long>
{
public static readonly long[] Value=A246706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246706.Bytes);
public long this[int i]=>Value[i];

public static A246706Inst Instance=new A246706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246707
{
public static readonly long[] Value={ 1L,-2L,-2L,2L,6L,4L,-14L,0L,6L,-2L,-12L,-8L,42L,4L,-16L,-4L,6L,-4L,-50L,8L,36L,0L,-24L,16L,42L,2L,-28L,2L,48L,-12L,-84L,-16L,6L,8L,-36L,0L,150L,-12L,-40L,-4L,36L,12L,-112L,-8L,72L,4L,-48L,0L,42L,14L,-62L,4L,84L,4L,-158L,16L,48L,-8L,-60L,-8L,252L,4L,-64L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246707Inst : IEnumerable<long>
{
public static readonly long[] Value=A246707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246707.Bytes);
public long this[int i]=>Value[i];

public static A246707Inst Instance=new A246707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246708
{
public static readonly long[] Value={ 1L,2L,0L,0L,9L,3L,6L,9L,5L,5L,1L,7L,6L,0L,0L,2L,7L,2L,6L,6L,7L,5L,4L,6L,5L,3L,8L,7L,3L,4L,9L,5L,4L,2L,8L,4L,6L,2L,9L,8L,4L,0L,7L,4L,1L,8L,2L,2L,5L,9L,8L,2L,2L,2L,5L,0L,1L,8L,3L,7L,1L,3L,9L,0L,4L,4L,9L,2L,0L,5L,6L,0L,4L,0L,1L,9L,0L,9L,4L,5L,8L,6L,0L,4L,4L,7L,4L,1L,7L,8L,8L,3L,6L,9L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246708Inst : IEnumerable<long>
{
public static readonly long[] Value=A246708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246708.Bytes);
public long this[int i]=>Value[i];

public static A246708Inst Instance=new A246708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246709
{
public static readonly long[] Value={ 1L,1L,6L,9L,9L,3L,0L,8L,1L,2L,7L,5L,8L,6L,8L,6L,8L,8L,6L,4L,6L,2L,9L,7L,5L,7L,2L,5L,5L,1L,3L,7L,3L,4L,6L,6L,7L,6L,9L,9L,4L,0L,4L,1L,9L,6L,4L,2L,0L,9L,3L,4L,2L,0L,9L,0L,3L,0L,2L,1L,8L,9L,6L,5L,5L,8L,9L,3L,3L,3L,9L,3L,6L,2L,7L,4L,0L,0L,3L,6L,7L,0L,1L,5L,1L,1L,4L,3L,0L,1L,9L,6L,9L,3L,9L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246709Inst : IEnumerable<long>
{
public static readonly long[] Value=A246709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246709.Bytes);
public long this[int i]=>Value[i];

public static A246709Inst Instance=new A246709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246710
{
public static readonly long[] Value={ 1L,1L,4L,7L,2L,0L,2L,6L,9L,0L,4L,3L,9L,8L,7L,7L,0L,8L,9L,4L,7L,3L,0L,5L,8L,6L,1L,3L,5L,3L,6L,5L,9L,7L,3L,7L,4L,1L,9L,1L,3L,7L,9L,9L,2L,1L,9L,3L,6L,8L,8L,0L,4L,5L,2L,3L,9L,2L,3L,6L,1L,9L,4L,6L,7L,2L,4L,9L,7L,4L,3L,7L,8L,0L,8L,2L,5L,5L,5L,5L,7L,4L,7L,4L,0L,8L,3L,2L,1L,4L,4L,7L,4L,9L,4L,1L,1L,5L,6L,2L,0L,5L,4L,6L,8L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246710Inst : IEnumerable<long>
{
public static readonly long[] Value=A246710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246710.Bytes);
public long this[int i]=>Value[i];

public static A246710Inst Instance=new A246710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246711
{
public static readonly long[] Value={ 1L,1L,1L,6L,1L,2L,3L,1L,7L,4L,0L,3L,3L,9L,0L,4L,4L,3L,4L,4L,4L,2L,6L,1L,4L,1L,3L,8L,3L,7L,7L,0L,9L,2L,5L,8L,1L,1L,1L,8L,3L,1L,6L,9L,2L,5L,3L,5L,0L,6L,8L,3L,7L,8L,8L,7L,1L,1L,9L,0L,1L,6L,0L,6L,4L,0L,7L,2L,6L,9L,3L,8L,7L,7L,6L,3L,8L,7L,4L,1L,2L,7L,7L,0L,6L,3L,2L,8L,5L,8L,0L,4L,3L,3L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246711Inst : IEnumerable<long>
{
public static readonly long[] Value=A246711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246711.Bytes);
public long this[int i]=>Value[i];

public static A246711Inst Instance=new A246711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246712
{
public static readonly long[] Value={ 1L,-2L,5L,-10L,18L,-32L,55L,-90L,145L,-228L,351L,-532L,795L,-1170L,1703L,-2452L,3494L,-4934L,6910L,-9598L,13238L,-18134L,24680L,-33390L,44921L,-60108L,80029L,-106044L,139875L,-183706L,240284L,-313046L,406319L,-525490L,677269L,-870010L,1114061L,-1422210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246712Inst : IEnumerable<long>
{
public static readonly long[] Value=A246712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246712.Bytes);
public long this[int i]=>Value[i];

public static A246712Inst Instance=new A246712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246713
{
public static readonly long[] Value={ 1L,2L,4L,3L,0L,-5L,-7L,-2L,8L,16L,12L,-7L,-29L,-35L,-10L,37L,70L,53L,-21L,-106L,-126L,-38L,119L,226L,164L,-70L,-326L,-378L,-106L,353L,652L,469L,-189L,-885L,-1015L,-290L,910L,1664L,1179L,-483L,-2205L,-2492L,-692L,2212L,3998L,2809L,-1120L,-5119L,-5754L,-1598L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246713Inst : IEnumerable<long>
{
public static readonly long[] Value=A246713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246713.Bytes);
public long this[int i]=>Value[i];

public static A246713Inst Instance=new A246713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246714
{
public static readonly long[] Value={ 1L,2L,0L,0L,9L,2L,4L,5L,9L,5L,10L,35L,21L,12L,14L,45L,19L,38L,36L,20L,54L,54L,19L,10L,83L,40L,101L,4L,20L,8L,16L,18L,53L,127L,25L,139L,4L,54L,149L,127L,176L,156L,71L,17L,65L,196L,10L,211L,221L,205L,63L,138L,137L,234L,254L,194L,67L,243L,155L,145L,164L,203L,76L,187L,272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246714Inst : IEnumerable<long>
{
public static readonly long[] Value=A246714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246714.Bytes);
public long this[int i]=>Value[i];

public static A246714Inst Instance=new A246714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246715
{
public static readonly long[] Value={ 1L,5L,6L,16L,27L,53L,95L,173L,308L,546L,959L,1675L,2909L,5029L,8658L,14852L,25395L,43297L,73627L,124909L,211456L,357270L,602551L,1014551L,1705657L,2863493L,4800990L,8039608L,13447563L,22469261L,37505879L,62546285L,104212364L,173489994L,288593903L,479706787L,796815125L,1322659237L,2194126122L,3637574444L,6027141411L,9980945785L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246715Inst : IEnumerable<long>
{
public static readonly long[] Value=A246715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246715.Bytes);
public long this[int i]=>Value[i];

public static A246715Inst Instance=new A246715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246716
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,9L,11L,12L,13L,16L,17L,18L,19L,20L,23L,24L,25L,27L,28L,29L,30L,31L,32L,36L,37L,40L,41L,42L,43L,44L,45L,47L,48L,49L,50L,52L,53L,54L,56L,59L,60L,61L,63L,64L,66L,67L,68L,70L,71L,72L,73L,75L,76L,78L,79L,80L,81L,83L,84L,88L,89L,90L,92L,96L,97L,98L,99L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246716Inst : IEnumerable<long>
{
public static readonly long[] Value=A246716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246716.Bytes);
public long this[int i]=>Value[i];

public static A246716Inst Instance=new A246716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246717
{
public static readonly long[] Value={ 7L,17L,23L,35L,41L,47L,49L,71L,77L,79L,95L,97L,103L,115L,137L,143L,167L,175L,191L,193L,199L,209L,235L,239L,245L,263L,271L,289L,295L,299L,311L,313L,319L,335L,343L,359L,367L,371L,383L,395L,401L,407L,409L,413L,415L,437L,449L,463L,475L,479L,487L,503L,515L,517L,521L,529L,535L,539L,551L,569L,575L,581L,583L,599L,607L,611L,647L,649L,667L,695L,707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246717Inst : IEnumerable<long>
{
public static readonly long[] Value=A246717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246717.Bytes);
public long this[int i]=>Value[i];

public static A246717Inst Instance=new A246717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246718
{
public static readonly long[] Value={ 2L,2L,3L,44L,128L,619L,4134L,28628L,229132L,2107538L,21438790L,238754555L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246718Inst : IEnumerable<long>
{
public static readonly long[] Value=A246718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246718.Bytes);
public long this[int i]=>Value[i];

public static A246718Inst Instance=new A246718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246719
{
public static readonly long[] Value={ 1L,3L,7L,15L,113L,65L,31L,91L,73L,39L,21L,331L,267L,55L,217L,435L,201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246719Inst : IEnumerable<long>
{
public static readonly long[] Value=A246719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246719.Bytes);
public long this[int i]=>Value[i];

public static A246719Inst Instance=new A246719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246720
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,2L,0L,1L,0L,1L,1L,0L,2L,1L,1L,0L,1L,0L,1L,1L,3L,0L,1L,0L,1L,1L,0L,2L,0L,3L,1L,1L,0L,1L,0L,1L,0L,2L,0L,4L,0L,1L,0L,1L,0L,1L,1L,1L,2L,1L,4L,1L,1L,0L,1L,1L,0L,1L,2L,0L,3L,0L,5L,0L,1L,0L,1L,1L,2L,0L,1L,2L,0L,3L,0L,5L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246720Inst : IEnumerable<long>
{
public static readonly long[] Value=A246720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246720.Bytes);
public long this[int i]=>Value[i];

public static A246720Inst Instance=new A246720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246721
{
public static readonly long[] Value={ 1L,1L,1L,2L,0L,2L,0L,2L,2L,0L,14L,3L,4L,0L,20L,3L,2L,1L,0L,26L,24L,4L,4L,2L,1L,35L,31L,4L,24L,2L,6L,1L,0L,378L,54L,42L,42L,5L,31L,0L,2L,0L,0L,631L,78L,61L,56L,5L,45L,34L,3L,3L,2L,2L,0L,1045L,992L,110L,85L,75L,73L,6L,55L,0L,7L,42L,8L,0L,2L,0L,1772L,1581L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246721Inst : IEnumerable<long>
{
public static readonly long[] Value=A246721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246721.Bytes);
public long this[int i]=>Value[i];

public static A246721Inst Instance=new A246721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246722
{
public static readonly long[] Value={ 1L,8L,1L,1L,4L,4L,7L,3L,2L,8L,5L,2L,7L,8L,1L,3L,3L,4L,3L,1L,8L,8L,3L,4L,5L,7L,4L,6L,4L,3L,0L,2L,0L,6L,3L,7L,5L,4L,0L,0L,8L,9L,1L,7L,6L,2L,5L,1L,5L,8L,7L,4L,7L,1L,0L,2L,3L,7L,4L,1L,6L,2L,6L,2L,7L,6L,8L,8L,4L,4L,9L,3L,4L,6L,2L,7L,1L,2L,5L,6L,7L,3L,9L,0L,9L,5L,2L,8L,7L,8L,7L,7L,8L,2L,0L,7L,1L,5L,5L,7L,4L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246722Inst : IEnumerable<long>
{
public static readonly long[] Value=A246722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246722.Bytes);
public long this[int i]=>Value[i];

public static A246722Inst Instance=new A246722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246723
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,0L,5L,1L,4L,4L,3L,3L,6L,4L,3L,8L,0L,3L,6L,0L,5L,4L,3L,1L,8L,5L,0L,5L,8L,8L,2L,1L,7L,2L,1L,6L,0L,6L,8L,1L,0L,5L,0L,3L,8L,6L,8L,6L,6L,5L,9L,7L,4L,3L,1L,3L,4L,6L,1L,4L,8L,6L,5L,4L,9L,8L,0L,7L,9L,2L,4L,5L,0L,8L,5L,3L,6L,9L,9L,4L,6L,9L,2L,0L,2L,8L,1L,1L,3L,3L,7L,9L,0L,7L,1L,9L,5L,3L,0L,3L,6L,2L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246723Inst : IEnumerable<long>
{
public static readonly long[] Value=A246723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246723.Bytes);
public long this[int i]=>Value[i];

public static A246723Inst Instance=new A246723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246724
{
public static readonly long[] Value={ 1L,5L,4L,7L,0L,0L,5L,3L,8L,3L,7L,9L,2L,5L,1L,5L,2L,9L,0L,1L,8L,2L,9L,7L,5L,6L,1L,0L,0L,3L,9L,1L,4L,9L,1L,1L,2L,9L,5L,2L,0L,3L,5L,0L,2L,5L,4L,0L,2L,5L,3L,7L,5L,2L,0L,3L,7L,2L,0L,4L,6L,5L,2L,9L,6L,7L,9L,5L,5L,3L,4L,4L,6L,0L,5L,8L,6L,6L,6L,9L,1L,3L,8L,7L,4L,3L,0L,7L,9L,1L,1L,7L,1L,4L,9L,9L,0L,5L,0L,4L,5L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246724Inst : IEnumerable<long>
{
public static readonly long[] Value=A246724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246724.Bytes);
public long this[int i]=>Value[i];

public static A246724Inst Instance=new A246724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246725
{
public static readonly long[] Value={ 2L,8L,0L,7L,7L,6L,4L,0L,6L,4L,0L,4L,4L,1L,5L,1L,3L,7L,4L,5L,5L,3L,5L,2L,4L,6L,3L,9L,9L,3L,5L,1L,9L,2L,5L,6L,2L,8L,6L,7L,9L,9L,8L,0L,6L,3L,4L,3L,4L,0L,5L,1L,0L,8L,5L,9L,9L,6L,5L,8L,3L,9L,3L,2L,7L,3L,7L,3L,8L,5L,8L,6L,5L,8L,4L,4L,0L,5L,3L,9L,8L,3L,9L,6L,9L,6L,5L,9L,1L,2L,7L,0L,2L,6L,7L,1L,0L,7L,4L,1L,7L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246725Inst : IEnumerable<long>
{
public static readonly long[] Value=A246725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246725.Bytes);
public long this[int i]=>Value[i];

public static A246725Inst Instance=new A246725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246726
{
public static readonly long[] Value={ 3L,4L,9L,1L,9L,8L,1L,8L,6L,2L,0L,8L,5L,4L,9L,8L,7L,6L,4L,7L,3L,6L,2L,3L,2L,3L,7L,0L,4L,5L,6L,9L,4L,3L,1L,5L,2L,7L,8L,2L,6L,2L,0L,4L,9L,8L,4L,3L,7L,4L,7L,5L,0L,7L,1L,9L,1L,4L,5L,1L,0L,9L,3L,9L,9L,1L,4L,8L,6L,6L,7L,2L,4L,2L,6L,2L,0L,9L,7L,3L,7L,0L,4L,3L,0L,5L,5L,8L,8L,0L,6L,4L,6L,7L,1L,8L,5L,3L,8L,0L,7L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246726Inst : IEnumerable<long>
{
public static readonly long[] Value=A246726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246726.Bytes);
public long this[int i]=>Value[i];

public static A246726Inst Instance=new A246726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246727
{
public static readonly long[] Value={ 3L,8L,6L,1L,0L,6L,1L,0L,4L,8L,5L,8L,5L,3L,8L,5L,4L,2L,2L,8L,6L,1L,3L,7L,1L,2L,9L,9L,4L,6L,9L,8L,9L,6L,9L,9L,4L,4L,3L,6L,1L,4L,6L,8L,8L,4L,5L,8L,6L,1L,7L,3L,1L,7L,7L,8L,9L,3L,9L,4L,0L,4L,2L,1L,4L,8L,3L,7L,6L,2L,8L,4L,4L,6L,6L,7L,6L,1L,8L,6L,2L,1L,2L,8L,9L,2L,4L,4L,6L,0L,4L,4L,1L,4L,6L,7L,3L,6L,0L,3L,9L,7L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246727Inst : IEnumerable<long>
{
public static readonly long[] Value=A246727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246727.Bytes);
public long this[int i]=>Value[i];

public static A246727Inst Instance=new A246727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246728
{
public static readonly long[] Value={ 5L,3L,3L,2L,9L,6L,4L,1L,6L,6L,6L,0L,3L,1L,2L,8L,6L,7L,6L,0L,0L,8L,3L,8L,0L,9L,9L,3L,1L,8L,0L,9L,3L,5L,9L,4L,0L,9L,4L,6L,7L,6L,0L,6L,3L,8L,8L,5L,2L,8L,0L,9L,1L,6L,9L,3L,0L,2L,2L,1L,3L,5L,8L,4L,7L,5L,7L,2L,8L,7L,0L,6L,4L,9L,2L,2L,3L,4L,1L,4L,8L,6L,5L,7L,1L,3L,5L,2L,0L,7L,2L,2L,5L,1L,5L,9L,1L,3L,2L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246728Inst : IEnumerable<long>
{
public static readonly long[] Value=A246728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246728.Bytes);
public long this[int i]=>Value[i];

public static A246728Inst Instance=new A246728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246729
{
public static readonly long[] Value={ 5L,4L,5L,1L,5L,1L,0L,4L,2L,1L,2L,2L,5L,7L,2L,6L,8L,7L,5L,9L,3L,8L,0L,7L,7L,1L,8L,3L,3L,7L,3L,4L,8L,6L,9L,6L,3L,8L,4L,3L,5L,5L,5L,7L,4L,9L,7L,3L,4L,6L,4L,7L,5L,2L,9L,2L,5L,3L,5L,6L,8L,1L,6L,5L,2L,1L,4L,4L,4L,1L,2L,6L,8L,7L,7L,7L,5L,2L,2L,9L,5L,9L,9L,2L,4L,7L,9L,4L,4L,6L,4L,6L,6L,2L,5L,6L,2L,7L,8L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246729Inst : IEnumerable<long>
{
public static readonly long[] Value=A246729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246729.Bytes);
public long this[int i]=>Value[i];

public static A246729Inst Instance=new A246729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246730
{
public static readonly long[] Value={ 6L,3L,7L,5L,5L,5L,9L,7L,7L,2L,3L,1L,9L,4L,5L,7L,9L,3L,4L,9L,1L,3L,1L,7L,1L,6L,7L,7L,3L,9L,9L,0L,9L,5L,9L,6L,7L,3L,7L,5L,7L,0L,8L,4L,2L,4L,5L,7L,4L,0L,1L,8L,7L,4L,0L,6L,7L,0L,8L,5L,4L,5L,6L,5L,6L,7L,3L,3L,1L,8L,1L,1L,5L,9L,9L,4L,0L,6L,8L,7L,3L,7L,5L,7L,5L,0L,4L,1L,7L,1L,6L,6L,0L,0L,7L,3L,3L,3L,7L,7L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246730Inst : IEnumerable<long>
{
public static readonly long[] Value=A246730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246730.Bytes);
public long this[int i]=>Value[i];

public static A246730Inst Instance=new A246730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246731
{
public static readonly BigInteger[] Value={ 1L,1L,3L,14L,106L,971L,10616L,123330L,1557753L,20543071L,287087740L,4168599808L,63349129196L,996257865899L,16268585660692L,273934662738565L,4763228582494891L,85139749375446911L,1565168115090666500L,BigInteger.Parse("29500470904432682460"),BigInteger.Parse("570091884338189871500") };
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
public class A246731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246731Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246731.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246731Inst Instance=new A246731Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246732
{
public static readonly long[] Value={ 124L,260L,548L,1156L,2436L,5132L,10812L,22780L,47996L,101124L,213060L,448900L,945796L,1992716L,4198492L,8845884L,18637564L,39267844L,82734180L,174314244L,367266052L,773799948L,1630334076L,3434982396L,7237230844L,15248261636L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246732Inst : IEnumerable<long>
{
public static readonly long[] Value=A246732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246732.Bytes);
public long this[int i]=>Value[i];

public static A246732Inst Instance=new A246732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246733
{
public static readonly long[] Value={ 424L,1096L,2884L,7612L,19992L,52112L,135776L,354428L,926912L,2426008L,6344712L,16581304L,43323852L,113217276L,295956684L,773719596L,2022600900L,5286817120L,13818445276L,36118847720L,94411371892L,246786721208L,645084592792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246733Inst : IEnumerable<long>
{
public static readonly long[] Value=A246733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246733.Bytes);
public long this[int i]=>Value[i];

public static A246733Inst Instance=new A246733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246734
{
public static readonly long[] Value={ 1566L,5430L,18966L,66294L,231414L,807630L,2818830L,9838974L,34342350L,119869158L,418392870L,1460364774L,5097280614L,17791629822L,62100187038L,216755476782L,756566753022L,2640732594966L,9217254934326L,32172052811478L,112293843388758L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246734Inst : IEnumerable<long>
{
public static readonly long[] Value=A246734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246734.Bytes);
public long this[int i]=>Value[i];

public static A246734Inst Instance=new A246734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246735
{
public static readonly long[] Value={ 3876L,15960L,66378L,276762L,1152576L,4791012L,19906740L,82727094L,343911336L,1430080296L,5946396012L,24722787264L,102780120750L,427285990662L,1776417823830L,7385542897866L,30705819911322L,127659940718424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246735Inst : IEnumerable<long>
{
public static readonly long[] Value=A246735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246735.Bytes);
public long this[int i]=>Value[i];

public static A246735Inst Instance=new A246735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246736
{
public static readonly long[] Value={ 9368L,47432L,241544L,1231304L,6272072L,31944440L,162700376L,828690200L,4220813912L,21498069128L,109497066248L,557706305672L,2840590647176L,14468108341688L,73691067738968L,375334033262552L,1911705731599640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246736Inst : IEnumerable<long>
{
public static readonly long[] Value=A246736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246736.Bytes);
public long this[int i]=>Value[i];

public static A246736Inst Instance=new A246736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246737
{
public static readonly long[] Value={ 2L,12L,2L,124L,16L,2L,424L,260L,22L,2L,1566L,1096L,548L,30L,2L,3876L,5430L,2884L,1156L,40L,2L,9368L,15960L,18966L,7612L,2436L,52L,2L,18768L,47432L,66378L,66294L,19992L,5132L,68L,2L,36250L,109552L,241544L,276762L,231414L,52112L,10812L,90L,2L,63100L,246890L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246737Inst : IEnumerable<long>
{
public static readonly long[] Value=A246737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246737.Bytes);
public long this[int i]=>Value[i];

public static A246737Inst Instance=new A246737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246738
{
public static readonly long[] Value={ 2L,12L,124L,424L,1566L,3876L,9368L,18768L,36250L,63100L,106452L,168312L,259574L,383124L,554416L,777376L,1072818L,1445868L,1923500L,2512200L,3245902L,4132612L,5214024L,6499824L,8040266L,9846876L,11979268L,14450968L,17331750L,20637300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246738Inst : IEnumerable<long>
{
public static readonly long[] Value=A246738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246738.Bytes);
public long this[int i]=>Value[i];

public static A246738Inst Instance=new A246738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246739
{
public static readonly long[] Value={ 2L,16L,260L,1096L,5430L,15960L,47432L,109552L,246890L,483520L,920652L,1606776L,2735390L,4392136L,6907280L,10419040L,15447762L,22202352L,31455380L,43507240L,59453702L,79710136L,105775320L,138205776L,178991930L,228860320L,290390492L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246739Inst : IEnumerable<long>
{
public static readonly long[] Value=A246739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246739.Bytes);
public long this[int i]=>Value[i];

public static A246739Inst Instance=new A246739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246740
{
public static readonly long[] Value={ 2L,22L,548L,2884L,18966L,66378L,241544L,643048L,1687850L,3716830L,7980972L,15368172L,28868798L,50412754L,86141456L,139758928L,222590034L,341128998L,514651700L,753789460L,1089386342L,1537935322L,2146429848L,2939373624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246740Inst : IEnumerable<long>
{
public static readonly long[] Value=A246740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246740.Bytes);
public long this[int i]=>Value[i];

public static A246740Inst Instance=new A246740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246741
{
public static readonly long[] Value={ 2L,30L,1156L,7612L,66294L,276762L,1231304L,3780600L,11549290L,28599190L,69230412L,147079860L,304811486L,578865042L,1074611344L,1875204592L,3208049874L,5242291470L,8421730580L,13061681580L,19963508422L,29676180490L,43560086616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246741Inst : IEnumerable<long>
{
public static readonly long[] Value=A246741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246741.Bytes);
public long this[int i]=>Value[i];

public static A246741Inst Instance=new A246741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246742
{
public static readonly long[] Value={ 2L,40L,2436L,19992L,231414L,1152576L,6272072L,22219408L,79002090L,220032120L,600454092L,1407554280L,3218159966L,6646694992L,13405336464L,25160170656L,46234874322L,80560371528L,137811490580L,226332464440L,365838595782L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246742Inst : IEnumerable<long>
{
public static readonly long[] Value=A246742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246742.Bytes);
public long this[int i]=>Value[i];

public static A246742Inst Instance=new A246742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246743
{
public static readonly long[] Value={ 2L,52L,5132L,52112L,807630L,4791012L,31944440L,130526848L,540366650L,1692606260L,5207709252L,13469585232L,33976308422L,76317563812L,167224561520L,337577831552L,666340346610L,1237996390068L,2255112904700L,3921870847120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246743Inst : IEnumerable<long>
{
public static readonly long[] Value=A246743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246743.Bytes);
public long this[int i]=>Value[i];

public static A246743Inst Instance=new A246743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246744
{
public static readonly long[] Value={ 2L,68L,10812L,135776L,2818830L,19906740L,162700376L,766650656L,3696053370L,13019727620L,45166073172L,128894476608L,358710268742L,876273071156L,2086036196400L,4529314688960L,9603337631346L,19024638124356L,36902088232940L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246744Inst : IEnumerable<long>
{
public static readonly long[] Value=A246744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246744.Bytes);
public long this[int i]=>Value[i];

public static A246744Inst Instance=new A246744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246745
{
public static readonly long[] Value={ 2L,2L,1L,8L,1L,5L,9L,5L,4L,3L,7L,5L,7L,6L,8L,8L,2L,2L,3L,0L,5L,9L,0L,5L,4L,0L,2L,1L,9L,0L,7L,6L,7L,9L,4L,5L,0L,7L,7L,0L,5L,6L,6L,5L,0L,1L,7L,7L,1L,4L,6L,9L,5L,8L,2L,2L,4L,1L,9L,7L,7L,7L,5L,2L,6L,4L,6L,1L,8L,5L,1L,6L,8L,1L,2L,3L,0L,0L,4L,7L,3L,6L,5L,1L,0L,9L,9L,1L,6L,8L,3L,3L,5L,6L,1L,7L,9L,1L,7L,6L,9L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246745Inst : IEnumerable<long>
{
public static readonly long[] Value=A246745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246745.Bytes);
public long this[int i]=>Value[i];

public static A246745Inst Instance=new A246745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246746
{
public static readonly long[] Value={ 5L,4L,2L,5L,9L,8L,5L,8L,6L,0L,9L,8L,4L,7L,1L,0L,2L,1L,9L,5L,9L,3L,8L,4L,5L,9L,5L,7L,7L,9L,4L,6L,9L,4L,2L,6L,7L,7L,9L,5L,0L,4L,6L,1L,6L,1L,9L,5L,3L,9L,2L,4L,6L,9L,6L,6L,5L,1L,5L,7L,8L,1L,0L,3L,4L,7L,0L,8L,9L,3L,1L,8L,9L,4L,7L,6L,4L,5L,6L,2L,2L,3L,2L,9L,5L,9L,3L,7L,4L,7L,4L,5L,1L,3L,4L,8L,9L,1L,0L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246746Inst : IEnumerable<long>
{
public static readonly long[] Value=A246746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246746.Bytes);
public long this[int i]=>Value[i];

public static A246746Inst Instance=new A246746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246747
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,7L,14L,37L,80L,222L,544L,1601L,4095L,12416L,33785L,105769L,293747L,935184L,2717376L,8848014L,26134254L,86210716L,262068267L,877833206L,2695238060L,9109101156L,28619396967L,97879220771L,310021153392L,1067906857449L,3440140082033L,11957123227292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246747Inst : IEnumerable<long>
{
public static readonly long[] Value=A246747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246747.Bytes);
public long this[int i]=>Value[i];

public static A246747Inst Instance=new A246747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246748
{
public static readonly long[] Value={ 3L,52L,104L,209L,343L,373L,398L,473L,628L,2633L,3273L,7538L,8060L,8813L,9025L,10847L,12493L,13768L,14196L,15486L,16865L,17486L,18362L,18613L,18842L,21175L,23522L,31825L,33537L,34507L,38740L,39603L,41802L,41947L,43314L,45479L,47550L,47668L,47787L,50321L,50682L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246748Inst : IEnumerable<long>
{
public static readonly long[] Value=A246748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246748.Bytes);
public long this[int i]=>Value[i];

public static A246748Inst Instance=new A246748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246749
{
public static readonly long[] Value={ 5L,6L,9L,7L,7L,5L,8L,9L,3L,4L,2L,3L,0L,1L,9L,2L,6L,7L,5L,7L,5L,2L,9L,1L,3L,7L,0L,4L,6L,8L,5L,2L,4L,7L,8L,9L,7L,8L,5L,8L,1L,0L,1L,9L,8L,2L,1L,7L,8L,3L,5L,7L,3L,5L,9L,3L,4L,5L,9L,5L,6L,7L,1L,7L,5L,8L,4L,1L,1L,4L,4L,0L,5L,3L,8L,6L,6L,0L,6L,7L,7L,6L,8L,3L,1L,7L,8L,4L,7L,5L,1L,5L,7L,4L,3L,8L,9L,2L,8L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246749Inst : IEnumerable<long>
{
public static readonly long[] Value=A246749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246749.Bytes);
public long this[int i]=>Value[i];

public static A246749Inst Instance=new A246749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246750
{
public static readonly long[] Value={ 8L,1L,7L,8L,1L,4L,6L,4L,0L,0L,8L,3L,6L,3L,2L,2L,3L,1L,5L,2L,5L,5L,9L,6L,8L,0L,0L,9L,0L,2L,9L,6L,5L,6L,0L,3L,8L,6L,4L,8L,5L,2L,9L,8L,2L,3L,7L,8L,9L,9L,1L,7L,8L,6L,3L,8L,6L,1L,2L,6L,3L,2L,0L,4L,2L,9L,7L,9L,1L,0L,0L,5L,2L,4L,5L,4L,9L,6L,4L,2L,1L,9L,6L,7L,0L,4L,6L,1L,9L,3L,7L,6L,4L,1L,9L,6L,7L,5L,0L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246750Inst : IEnumerable<long>
{
public static readonly long[] Value=A246750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246750.Bytes);
public long this[int i]=>Value[i];

public static A246750Inst Instance=new A246750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246751
{
public static readonly long[] Value={ 2L,1L,7L,6L,9L,6L,8L,7L,4L,3L,5L,5L,9L,4L,1L,0L,3L,2L,1L,7L,3L,9L,7L,2L,7L,2L,9L,8L,7L,3L,5L,8L,1L,4L,3L,2L,9L,7L,6L,7L,2L,7L,3L,7L,5L,8L,9L,6L,5L,8L,4L,4L,9L,6L,0L,2L,3L,8L,6L,2L,8L,0L,0L,0L,6L,4L,7L,3L,5L,2L,5L,6L,2L,2L,0L,3L,3L,7L,4L,9L,0L,9L,8L,4L,0L,5L,1L,2L,2L,7L,4L,0L,8L,6L,0L,7L,4L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246751Inst : IEnumerable<long>
{
public static readonly long[] Value=A246751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246751.Bytes);
public long this[int i]=>Value[i];

public static A246751Inst Instance=new A246751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246752
{
public static readonly long[] Value={ 1L,-1L,-2L,0L,2L,3L,-2L,0L,1L,-2L,-2L,0L,2L,0L,-2L,0L,3L,-2L,0L,0L,2L,3L,-2L,0L,2L,-2L,-2L,0L,0L,0L,-4L,0L,2L,-1L,-2L,0L,2L,6L,0L,0L,1L,-2L,-2L,0L,4L,0L,-2L,0L,0L,-2L,-2L,0L,2L,0L,-2L,0L,3L,-2L,-2L,0L,2L,0L,0L,0L,2L,-3L,-2L,0L,0L,6L,-2L,0L,4L,0L,-2L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246752Inst : IEnumerable<long>
{
public static readonly long[] Value=A246752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246752.Bytes);
public long this[int i]=>Value[i];

public static A246752Inst Instance=new A246752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246753
{
public static readonly long[] Value={ 1L,3L,6L,28L,36L,45L,55L,66L,78L,276L,378L,496L,595L,1596L,2485L,2775L,3486L,4656L,5565L,5778L,5995L,8778L,25878L,26796L,35778L,47586L,47895L,58996L,196878L,277885L,359976L,378885L,448878L,468996L,569778L,786885L,887778L,2489796L,2797795L,3667986L,3689686L,3887866L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246753Inst : IEnumerable<long>
{
public static readonly long[] Value=A246753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246753.Bytes);
public long this[int i]=>Value[i];

public static A246753Inst Instance=new A246753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246754
{
public static readonly long[] Value={ 1L,10L,57L,387L,2890L,22934L,189482L,1611056L,13993960L,123579654L,1105747503L,10000000000L,91239358932L,838673386122L,7758099162327L,72158973089377L,674359248152535L,6328590417713813L,59611349660814244L,563355446524384647L,5339735395113038337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246754Inst : IEnumerable<long>
{
public static readonly long[] Value=A246754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246754.Bytes);
public long this[int i]=>Value[i];

public static A246754Inst Instance=new A246754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246755
{
public static readonly long[] Value={ 15L,33L,43L,45L,69L,75L,87L,99L,109L,135L,141L,157L,159L,177L,207L,213L,225L,229L,249L,261L,277L,283L,297L,303L,307L,321L,363L,375L,393L,399L,405L,423L,477L,479L,499L,501L,519L,531L,537L,573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246755Inst : IEnumerable<long>
{
public static readonly long[] Value=A246755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246755.Bytes);
public long this[int i]=>Value[i];

public static A246755Inst Instance=new A246755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246756
{
public static readonly BigInteger[] Value={ 1L,1L,3L,25L,335L,5521L,101551L,1998753L,41188543L,877423873L,19166868607L,427008572673L,9664851921407L,221617029447425L,5137323018353407L,120193894356728321L,2834498556258175999L,BigInteger.Parse("67307873346885345281"),BigInteger.Parse("1607986547852912064511"),BigInteger.Parse("38620793453818766774273"),BigInteger.Parse("932025198556610269241343"),BigInteger.Parse("22588476205782950667427841") };
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
public class A246756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246756Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246756.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246756Inst Instance=new A246756Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246757
{
public static readonly BigInteger[] Value={ 9L,36L,816L,9612L,93744L,973728L,9939915L,99221112L,997711344L,9993393711L,99934212672L,999641938176L,9999121936392L,99996414731136L,999994123418112L,9999982411646976L,99999318116613312L,999991631331122112L,9999944111773994112UL,BigInteger.Parse("99999911232931433472"),BigInteger.Parse("999999832211912282112") };
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
public class A246757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246757Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246757.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246757Inst Instance=new A246757Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246758
{
public static readonly BigInteger[] Value={ 3L,11L,43L,151L,683L,2731L,43691L,174763L,599479L,2796203L,715827883L,2932031007403L,10052678938039L,145295143558111L,581283643249112959L,658812288653553079L,768614336404564651L,9520972806333758431UL,BigInteger.Parse("201487636602438195784363") };
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
public class A246758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246758Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246758.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246758Inst Instance=new A246758Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246759
{
public static readonly long[] Value={ 0L,2L,9L,48L,324L,1280L,3750L,9072L,19208L,36864L,50625L,65610L,82944L,110000L,175692L,269568L,399854L,576240L,810000L,1114112L,1503378L,1994544L,2606420L,3360000L,4278582L,5387888L,6716184L,8294400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246759Inst : IEnumerable<long>
{
public static readonly long[] Value=A246759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246759.Bytes);
public long this[int i]=>Value[i];

public static A246759Inst Instance=new A246759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246760
{
public static readonly long[] Value={ 5L,41L,617L,653L,797L,941L,977L,1013L,1049L,1193L,1229L,1373L,1409L,1553L,1697L,1733L,1877L,1913L,1949L,2273L,2309L,2633L,2777L,3677L,3821L,4397L,4721L,5297L,5333L,5477L,5801L,6701L,6737L,8501L,8537L,8573L,8609L,8753L,11057L,11093L,13397L,13721L,13757L,13901L,18257L,18401L,19301L,20201L,21101L,22397L,22433L,22469L,22613L,22937L,22973L,23117L,24413L,24989L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246760Inst : IEnumerable<long>
{
public static readonly long[] Value=A246760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246760.Bytes);
public long this[int i]=>Value[i];

public static A246760Inst Instance=new A246760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246761
{
public static readonly BigInteger[] Value={ 1L,25L,823L,34459L,1663267L,85847347L,4598058505L,252738855901L,14170006731643L,806810379495379L,46503528950782309L,2707097765891635585L,BigInteger.Parse("158884136607368717797"),BigInteger.Parse("9389663462839346537221"),BigInteger.Parse("558176792747732603265463"),BigInteger.Parse("33349982885530909490561203") };
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
public class A246761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246761Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246761.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246761Inst Instance=new A246761Inst();

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