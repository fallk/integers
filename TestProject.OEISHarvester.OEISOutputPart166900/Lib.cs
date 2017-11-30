using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A197357
{
public static readonly long[] Value={ 1L,10L,55L,670L,4840L,55252L,436975L,4816030L,40051495L,432457640L,3715101654L,39581170420L,347847754670L,3671331273480L,32811494188975L,343900019857310L,3113537578058979L,32458256583753952L,296896918816556380L,3081918923741896840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197357Inst : IEnumerable<long>
{
public static readonly long[] Value=A197357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197357.Bytes);
public long this[int i]=>Value[i];

public static A197357Inst Instance=new A197357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197358
{
public static readonly long[] Value={ 1L,1L,33L,803L,79051L,24799027L,22225081365L,66858428077735L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197358Inst : IEnumerable<long>
{
public static readonly long[] Value=A197358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197358.Bytes);
public long this[int i]=>Value[i];

public static A197358Inst Instance=new A197358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197359
{
public static readonly long[] Value={ 1L,9L,33L,113L,593L,2435L,10317L,45615L,195093L,841571L,3646693L,15718319L,67872219L,293228491L,1265855985L,5466238427L,23604968149L,101924529475L,440126714041L,1900525775017L,8206607484875L,35437081228013L,153021248588503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197359Inst : IEnumerable<long>
{
public static readonly long[] Value=A197359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197359.Bytes);
public long this[int i]=>Value[i];

public static A197359Inst Instance=new A197359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197360
{
public static readonly long[] Value={ 1L,17L,113L,803L,5855L,41459L,300943L,2224023L,16153497L,116797601L,851944533L,6202923531L,45107191789L,328173759843L,2387891294531L,17373638032901L,126409617048273L,919727576644501L,6691670125651177L,48687601545703711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197360Inst : IEnumerable<long>
{
public static readonly long[] Value=A197360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197360.Bytes);
public long this[int i]=>Value[i];

public static A197360Inst Instance=new A197360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197361
{
public static readonly long[] Value={ 1L,33L,593L,5855L,79051L,1041263L,13639968L,178359981L,2325301494L,30421739045L,398559303702L,5208529268691L,68100059270101L,890956015271870L,11653212521783971L,152394870737191233L,1993174813555117586L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197361Inst : IEnumerable<long>
{
public static readonly long[] Value=A197361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197361.Bytes);
public long this[int i]=>Value[i];

public static A197361Inst Instance=new A197361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197362
{
public static readonly BigInteger[] Value={ 1L,89L,2435L,41459L,1041263L,24799027L,564930689L,13016997513L,302413118055L,7014256316261L,162356900029937L,3756243587537729L,87022713805696677L,2015969474427313369L,BigInteger.Parse("46677826922272579365"),BigInteger.Parse("1080890025532285110563") };
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
public class A197362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197362Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197362.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197362Inst Instance=new A197362Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197363
{
public static readonly BigInteger[] Value={ 1L,249L,10317L,300943L,13639968L,564930689L,22225081365L,916121380455L,37586117262267L,1524500056348640L,62133636167189064L,2537563935267330621L,BigInteger.Parse("103445371582832062080"),BigInteger.Parse("4215904817820876539413"),BigInteger.Parse("171923620467459691011031") };
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
public class A197363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197363Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197363.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197363Inst Instance=new A197363Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197364
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,9L,9L,1L,1L,17L,33L,17L,1L,1L,33L,113L,113L,33L,1L,1L,89L,593L,803L,593L,89L,1L,1L,249L,2435L,5855L,5855L,2435L,249L,1L,1L,553L,10317L,41459L,79051L,41459L,10317L,553L,1L,1L,1321L,45615L,300943L,1041263L,1041263L,300943L,45615L,1321L,1L,1L,3361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197364Inst : IEnumerable<long>
{
public static readonly long[] Value=A197364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197364.Bytes);
public long this[int i]=>Value[i];

public static A197364Inst Instance=new A197364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197365
{
public static readonly long[] Value={ 1L,1L,2L,5L,1L,16L,8L,63L,54L,3L,296L,368L,56L,1623L,2649L,753L,15L,10176L,20544L,9024L,576L,71793L,172596L,104814L,13572L,105L,562848L,1569408L,1228608L,259968L,7968L,4853949L,15398829L,14824314L,4532034L,306729L,945L,45664896L,162412416L,185991936L,75929856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197365Inst : IEnumerable<long>
{
public static readonly long[] Value=A197365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197365.Bytes);
public long this[int i]=>Value[i];

public static A197365Inst Instance=new A197365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197366
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,2L,0L,3L,1L,2L,1L,2L,0L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197366Inst : IEnumerable<long>
{
public static readonly long[] Value=A197366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197366.Bytes);
public long this[int i]=>Value[i];

public static A197366Inst Instance=new A197366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197367
{
public static readonly BigInteger[] Value={ 1L,1L,32L,161L,7485L,509018L,79831388L,27751402365L,20901475723923L,34381589920722561L,BigInteger.Parse("123453405715147118697") };
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
public class A197367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197367Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197367.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197367Inst Instance=new A197367Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197368
{
public static readonly long[] Value={ 1L,3L,32L,45L,189L,646L,1873L,6209L,19883L,62891L,201940L,644884L,2058462L,6580709L,21022103L,67159181L,214583759L,685563259L,2190314160L,6997940987L,22357818950L,71431546562L,228218559544L,729140737836L,2329549699706L,7442735684274L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197368Inst : IEnumerable<long>
{
public static readonly long[] Value=A197368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197368.Bytes);
public long this[int i]=>Value[i];

public static A197368Inst Instance=new A197368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197369
{
public static readonly long[] Value={ 1L,7L,45L,161L,899L,4023L,19387L,92169L,436539L,2077281L,9861263L,46848707L,222547181L,1057107041L,5021579939L,23853406065L,113308835575L,538241104209L,2556757711375L,12145141483565L,57691981461499L,274049091332625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197369Inst : IEnumerable<long>
{
public static readonly long[] Value=A197369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197369.Bytes);
public long this[int i]=>Value[i];

public static A197369Inst Instance=new A197369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197370
{
public static readonly long[] Value={ 1L,17L,189L,899L,7485L,50831L,355929L,2503359L,17611057L,123747825L,869308845L,6110148907L,42934775357L,301710593001L,2120231045803L,14899304646125L,104701046013783L,735760461321649L,5170369292373967L,36333455835692225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197370Inst : IEnumerable<long>
{
public static readonly long[] Value=A197370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197370.Bytes);
public long this[int i]=>Value[i];

public static A197370Inst Instance=new A197370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197371
{
public static readonly long[] Value={ 1L,41L,646L,4023L,50831L,509018L,5198997L,54278107L,559939403L,5785336959L,59865826196L,618821603760L,6398319110978L,66160018680427L,684049467447585L,7072850485476387L,73130794356723859L,756143068281744553L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197371Inst : IEnumerable<long>
{
public static readonly long[] Value=A197371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197371.Bytes);
public long this[int i]=>Value[i];

public static A197371Inst Instance=new A197371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197372
{
public static readonly long[] Value={ 1L,99L,1873L,19387L,355929L,5198997L,79831388L,1224953019L,18720559109L,286695564063L,4387392987375L,67144325650311L,1027713403550939L,15728844758196796L,240730652255271607L,3684411293604740543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197372Inst : IEnumerable<long>
{
public static readonly long[] Value=A197372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197372.Bytes);
public long this[int i]=>Value[i];

public static A197372Inst Instance=new A197372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197373
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,3L,3L,1L,1L,7L,32L,7L,1L,1L,17L,45L,45L,17L,1L,1L,41L,189L,161L,189L,41L,1L,1L,99L,646L,899L,899L,646L,99L,1L,1L,239L,1873L,4023L,7485L,4023L,1873L,239L,1L,1L,577L,6209L,19387L,50831L,50831L,19387L,6209L,577L,1L,1L,1393L,19883L,92169L,355929L,509018L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197373Inst : IEnumerable<long>
{
public static readonly long[] Value=A197373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197373.Bytes);
public long this[int i]=>Value[i];

public static A197373Inst Instance=new A197373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197374
{
public static readonly long[] Value={ 5L,2L,9L,9L,9L,1L,6L,2L,5L,0L,8L,5L,6L,3L,4L,9L,8L,7L,1L,9L,4L,1L,0L,6L,8L,4L,9L,8L,9L,4L,5L,3L,1L,6L,1L,0L,7L,7L,1L,5L,6L,0L,5L,6L,1L,4L,6L,0L,7L,6L,7L,2L,5L,9L,0L,3L,8L,0L,7L,1L,5L,7L,2L,5L,5L,0L,6L,3L,5L,9L,0L,0L,5L,1L,8L,4L,3L,2L,3L,7L,4L,0L,8L,1L,6L,4L,6L,0L,9L,8L,0L,0L,0L,0L,1L,5L,0L,7L,6L,1L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197374Inst : IEnumerable<long>
{
public static readonly long[] Value=A197374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197374.Bytes);
public long this[int i]=>Value[i];

public static A197374Inst Instance=new A197374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197375
{
public static readonly long[] Value={ 9L,6L,7L,9L,1L,9L,9L,1L,7L,1L,6L,2L,8L,4L,0L,1L,2L,4L,6L,1L,0L,7L,0L,3L,7L,5L,3L,8L,3L,1L,8L,3L,0L,1L,7L,4L,1L,3L,5L,2L,2L,3L,3L,0L,3L,9L,8L,2L,9L,3L,4L,7L,6L,7L,0L,1L,7L,9L,1L,5L,6L,8L,1L,4L,0L,9L,1L,6L,1L,9L,1L,7L,8L,8L,2L,1L,0L,4L,5L,9L,5L,3L,9L,4L,9L,3L,7L,5L,7L,7L,2L,1L,1L,6L,6L,9L,3L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197375Inst : IEnumerable<long>
{
public static readonly long[] Value=A197375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197375.Bytes);
public long this[int i]=>Value[i];

public static A197375Inst Instance=new A197375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197376
{
public static readonly long[] Value={ 2L,2L,1L,4L,2L,9L,7L,4L,3L,5L,5L,8L,8L,1L,8L,1L,0L,0L,6L,0L,3L,4L,1L,3L,0L,9L,2L,0L,3L,5L,7L,0L,7L,4L,0L,8L,0L,1L,4L,0L,0L,9L,5L,2L,9L,0L,8L,0L,2L,8L,6L,5L,2L,9L,3L,3L,5L,3L,0L,7L,8L,4L,1L,4L,8L,6L,7L,4L,2L,0L,6L,7L,7L,9L,5L,4L,7L,2L,5L,5L,8L,8L,0L,2L,6L,8L,3L,4L,2L,5L,7L,3L,7L,2L,3L,4L,1L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197376Inst : IEnumerable<long>
{
public static readonly long[] Value=A197376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197376.Bytes);
public long this[int i]=>Value[i];

public static A197376Inst Instance=new A197376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197377
{
public static readonly long[] Value={ 2L,5L,4L,4L,1L,8L,6L,2L,3L,6L,9L,4L,4L,4L,4L,3L,0L,2L,4L,1L,5L,8L,8L,3L,3L,0L,1L,6L,9L,9L,5L,2L,5L,4L,2L,4L,0L,2L,2L,0L,0L,9L,8L,6L,3L,9L,7L,8L,9L,3L,3L,7L,9L,2L,8L,5L,8L,2L,1L,5L,4L,4L,9L,0L,7L,1L,0L,6L,0L,2L,4L,6L,3L,6L,8L,5L,4L,2L,2L,7L,0L,3L,0L,4L,7L,5L,6L,9L,4L,0L,5L,1L,9L,5L,8L,7L,1L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197377Inst : IEnumerable<long>
{
public static readonly long[] Value=A197377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197377.Bytes);
public long this[int i]=>Value[i];

public static A197377Inst Instance=new A197377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197378
{
public static readonly long[] Value={ 1L,9L,5L,0L,7L,2L,1L,8L,5L,4L,6L,5L,2L,8L,5L,4L,5L,7L,6L,2L,8L,6L,6L,6L,5L,5L,1L,8L,2L,0L,4L,0L,1L,1L,5L,4L,4L,6L,4L,5L,0L,1L,6L,3L,4L,2L,9L,2L,8L,2L,1L,8L,2L,3L,0L,8L,4L,5L,4L,6L,0L,2L,4L,3L,6L,0L,3L,5L,8L,9L,9L,8L,7L,1L,5L,7L,0L,7L,0L,3L,3L,2L,5L,1L,5L,5L,4L,0L,3L,5L,5L,1L,6L,0L,0L,0L,4L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197378Inst : IEnumerable<long>
{
public static readonly long[] Value=A197378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197378.Bytes);
public long this[int i]=>Value[i];

public static A197378Inst Instance=new A197378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197379
{
public static readonly long[] Value={ 1L,7L,5L,6L,9L,7L,7L,1L,2L,3L,8L,6L,5L,4L,8L,3L,8L,9L,2L,5L,0L,7L,8L,1L,8L,5L,0L,4L,0L,0L,4L,1L,4L,5L,3L,4L,5L,3L,1L,3L,5L,2L,3L,5L,1L,9L,3L,7L,1L,9L,4L,6L,1L,8L,0L,9L,8L,7L,0L,4L,5L,4L,7L,1L,2L,5L,4L,7L,9L,8L,0L,0L,8L,0L,5L,3L,6L,4L,1L,5L,3L,9L,8L,7L,4L,6L,0L,9L,6L,0L,5L,0L,8L,6L,2L,5L,6L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197379Inst : IEnumerable<long>
{
public static readonly long[] Value=A197379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197379.Bytes);
public long this[int i]=>Value[i];

public static A197379Inst Instance=new A197379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197380
{
public static readonly long[] Value={ 2L,1L,1L,4L,4L,9L,8L,2L,9L,4L,0L,9L,7L,4L,0L,0L,3L,5L,4L,9L,4L,7L,5L,9L,3L,5L,4L,2L,6L,5L,1L,5L,5L,6L,8L,4L,4L,2L,9L,3L,1L,9L,2L,8L,5L,6L,6L,7L,8L,4L,9L,2L,6L,3L,2L,4L,0L,0L,4L,6L,6L,1L,2L,2L,8L,2L,3L,7L,3L,1L,1L,3L,9L,2L,8L,3L,8L,4L,1L,9L,7L,9L,6L,0L,9L,7L,1L,4L,2L,0L,6L,3L,1L,3L,2L,6L,1L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197380Inst : IEnumerable<long>
{
public static readonly long[] Value=A197380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197380.Bytes);
public long this[int i]=>Value[i];

public static A197380Inst Instance=new A197380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197381
{
public static readonly long[] Value={ 8L,8L,7L,3L,6L,0L,4L,8L,4L,4L,7L,7L,8L,5L,1L,6L,3L,6L,8L,6L,1L,3L,1L,4L,2L,5L,6L,8L,0L,8L,3L,6L,9L,0L,1L,2L,5L,1L,3L,0L,6L,8L,4L,3L,9L,8L,9L,4L,4L,2L,1L,2L,8L,2L,1L,5L,5L,7L,2L,9L,6L,2L,2L,6L,0L,6L,1L,9L,8L,2L,8L,8L,7L,9L,9L,0L,9L,8L,9L,9L,9L,6L,4L,7L,5L,8L,9L,9L,9L,1L,8L,3L,6L,4L,8L,4L,8L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197381Inst : IEnumerable<long>
{
public static readonly long[] Value=A197381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197381.Bytes);
public long this[int i]=>Value[i];

public static A197381Inst Instance=new A197381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197382
{
public static readonly long[] Value={ 2L,4L,8L,3L,7L,3L,6L,2L,0L,6L,1L,2L,3L,1L,3L,2L,7L,5L,7L,6L,0L,9L,7L,3L,7L,1L,4L,4L,8L,1L,9L,7L,5L,1L,1L,6L,8L,6L,9L,8L,9L,9L,0L,0L,7L,1L,2L,3L,6L,6L,9L,3L,8L,8L,1L,8L,0L,0L,6L,6L,3L,0L,8L,9L,3L,7L,7L,0L,5L,4L,2L,4L,9L,2L,9L,6L,5L,2L,6L,5L,3L,0L,2L,2L,7L,0L,2L,3L,9L,0L,5L,9L,7L,9L,5L,5L,2L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197382Inst : IEnumerable<long>
{
public static readonly long[] Value=A197382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197382.Bytes);
public long this[int i]=>Value[i];

public static A197382Inst Instance=new A197382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197383
{
public static readonly long[] Value={ 5L,2L,1L,3L,3L,7L,8L,2L,9L,5L,7L,1L,7L,1L,5L,6L,9L,8L,6L,9L,1L,9L,8L,8L,5L,6L,4L,4L,5L,4L,9L,1L,7L,9L,7L,7L,3L,0L,9L,1L,8L,1L,3L,9L,4L,7L,3L,3L,6L,8L,8L,7L,1L,9L,5L,4L,9L,1L,8L,4L,8L,6L,2L,5L,1L,5L,5L,9L,0L,6L,0L,9L,6L,1L,0L,2L,5L,9L,8L,8L,8L,9L,7L,4L,9L,7L,5L,6L,9L,0L,0L,3L,9L,4L,9L,7L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197383Inst : IEnumerable<long>
{
public static readonly long[] Value=A197383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197383.Bytes);
public long this[int i]=>Value[i];

public static A197383Inst Instance=new A197383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197384
{
public static readonly long[] Value={ 1L,5L,4L,0L,6L,7L,5L,0L,0L,2L,9L,3L,4L,0L,1L,2L,5L,1L,0L,8L,8L,0L,4L,7L,8L,2L,3L,9L,5L,2L,2L,4L,3L,4L,3L,4L,4L,3L,8L,8L,3L,9L,4L,1L,0L,2L,0L,4L,5L,4L,5L,6L,5L,9L,8L,2L,5L,0L,3L,9L,3L,5L,7L,5L,6L,3L,9L,3L,4L,3L,1L,2L,7L,5L,8L,0L,4L,6L,1L,6L,2L,9L,3L,8L,1L,4L,7L,6L,2L,0L,9L,3L,9L,5L,9L,1L,4L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197384Inst : IEnumerable<long>
{
public static readonly long[] Value=A197384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197384.Bytes);
public long this[int i]=>Value[i];

public static A197384Inst Instance=new A197384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197385
{
public static readonly long[] Value={ 2L,8L,8L,4L,4L,9L,4L,1L,6L,5L,1L,2L,4L,6L,1L,5L,2L,8L,8L,3L,7L,9L,4L,6L,3L,5L,9L,5L,7L,1L,3L,8L,7L,1L,6L,3L,9L,1L,5L,1L,7L,5L,0L,8L,6L,6L,9L,3L,6L,1L,0L,8L,8L,2L,2L,5L,7L,3L,4L,3L,5L,7L,8L,7L,1L,6L,2L,4L,8L,9L,9L,2L,1L,4L,3L,4L,8L,7L,3L,8L,4L,5L,7L,2L,3L,6L,3L,2L,1L,8L,0L,0L,2L,2L,6L,7L,0L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197385Inst : IEnumerable<long>
{
public static readonly long[] Value=A197385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197385.Bytes);
public long this[int i]=>Value[i];

public static A197385Inst Instance=new A197385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197386
{
public static readonly long[] Value={ 1L,2L,1L,3L,0L,3L,7L,5L,6L,3L,4L,4L,5L,3L,6L,4L,5L,1L,1L,9L,4L,9L,3L,2L,1L,3L,9L,7L,3L,2L,0L,4L,5L,8L,9L,2L,3L,3L,7L,9L,6L,8L,0L,3L,7L,0L,3L,7L,8L,7L,6L,7L,6L,1L,3L,4L,3L,4L,2L,2L,1L,5L,3L,3L,5L,1L,7L,1L,0L,7L,5L,9L,6L,2L,8L,0L,7L,7L,6L,9L,9L,7L,0L,8L,4L,4L,8L,4L,3L,9L,6L,7L,8L,6L,1L,5L,0L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197386Inst : IEnumerable<long>
{
public static readonly long[] Value=A197386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197386.Bytes);
public long this[int i]=>Value[i];

public static A197386Inst Instance=new A197386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197387
{
public static readonly long[] Value={ 2L,1L,5L,3L,2L,1L,5L,0L,6L,6L,6L,8L,2L,6L,9L,8L,3L,3L,5L,4L,3L,3L,9L,0L,1L,2L,2L,7L,8L,4L,4L,6L,1L,3L,4L,8L,4L,2L,9L,2L,6L,1L,6L,3L,2L,0L,4L,9L,1L,8L,4L,6L,4L,1L,3L,8L,6L,0L,7L,7L,3L,3L,0L,9L,6L,6L,2L,0L,5L,4L,0L,3L,7L,4L,3L,9L,6L,7L,3L,8L,3L,8L,0L,6L,4L,6L,8L,2L,1L,6L,8L,7L,7L,8L,3L,0L,9L,4L,58L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197387Inst : IEnumerable<long>
{
public static readonly long[] Value=A197387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197387.Bytes);
public long this[int i]=>Value[i];

public static A197387Inst Instance=new A197387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197388
{
public static readonly long[] Value={ 2L,4L,6L,1L,0L,2L,9L,2L,2L,1L,4L,8L,3L,2L,8L,7L,4L,2L,4L,5L,6L,8L,5L,9L,8L,7L,6L,6L,1L,2L,9L,7L,1L,4L,4L,1L,5L,1L,6L,9L,6L,5L,4L,9L,7L,2L,0L,3L,9L,6L,7L,0L,0L,8L,6L,9L,7L,8L,9L,2L,8L,0L,1L,9L,4L,2L,3L,5L,1L,3L,2L,8L,9L,4L,3L,2L,9L,1L,2L,9L,0L,7L,3L,4L,1L,2L,3L,8L,0L,2L,5L,4L,3L,1L,8L,6L,5L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197388Inst : IEnumerable<long>
{
public static readonly long[] Value=A197388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197388.Bytes);
public long this[int i]=>Value[i];

public static A197388Inst Instance=new A197388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197389
{
public static readonly long[] Value={ 1L,9L,0L,3L,9L,9L,2L,2L,5L,1L,9L,3L,0L,9L,5L,6L,2L,7L,3L,4L,0L,4L,2L,7L,7L,7L,2L,4L,5L,5L,5L,6L,8L,3L,2L,1L,1L,0L,9L,6L,8L,0L,6L,9L,1L,6L,0L,0L,7L,1L,2L,9L,1L,5L,2L,1L,7L,7L,5L,3L,3L,7L,7L,4L,3L,2L,9L,8L,8L,2L,8L,5L,4L,0L,0L,0L,7L,4L,6L,4L,7L,3L,1L,1L,5L,2L,3L,7L,7L,6L,5L,0L,2L,7L,7L,5L,4L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197389Inst : IEnumerable<long>
{
public static readonly long[] Value=A197389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197389.Bytes);
public long this[int i]=>Value[i];

public static A197389Inst Instance=new A197389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197390
{
public static readonly long[] Value={ 9L,9L,7L,2L,7L,3L,0L,3L,0L,9L,5L,9L,9L,9L,6L,5L,7L,1L,6L,6L,4L,3L,8L,3L,4L,5L,7L,5L,4L,4L,6L,4L,5L,3L,9L,4L,1L,3L,2L,0L,9L,1L,2L,7L,5L,4L,4L,8L,6L,0L,4L,0L,3L,8L,7L,1L,4L,0L,6L,7L,1L,9L,8L,4L,7L,2L,2L,7L,0L,6L,4L,5L,0L,7L,7L,2L,3L,0L,9L,3L,7L,1L,9L,7L,4L,2L,1L,0L,6L,3L,9L,5L,0L,1L,5L,8L,5L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197390Inst : IEnumerable<long>
{
public static readonly long[] Value=A197390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197390.Bytes);
public long this[int i]=>Value[i];

public static A197390Inst Instance=new A197390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197391
{
public static readonly long[] Value={ 2L,0L,7L,0L,5L,3L,4L,3L,2L,1L,0L,0L,7L,2L,5L,6L,5L,9L,0L,1L,3L,9L,5L,8L,5L,2L,2L,0L,5L,5L,2L,0L,4L,9L,7L,4L,4L,8L,2L,4L,4L,6L,5L,1L,2L,0L,3L,3L,5L,4L,2L,1L,5L,6L,1L,0L,0L,0L,1L,5L,0L,8L,1L,0L,9L,0L,2L,2L,0L,0L,3L,2L,3L,6L,8L,0L,3L,3L,7L,1L,4L,3L,2L,0L,8L,1L,9L,1L,4L,3L,4L,0L,4L,3L,9L,9L,2L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197391Inst : IEnumerable<long>
{
public static readonly long[] Value=A197391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197391.Bytes);
public long this[int i]=>Value[i];

public static A197391Inst Instance=new A197391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197392
{
public static readonly long[] Value={ 0L,8L,9L,3L,1L,1L,7L,7L,4L,8L,5L,4L,4L,8L,4L,7L,6L,2L,9L,4L,4L,5L,4L,2L,3L,6L,0L,1L,7L,1L,0L,9L,9L,4L,7L,7L,0L,8L,2L,6L,4L,5L,8L,9L,5L,0L,0L,5L,0L,8L,4L,9L,4L,2L,4L,4L,4L,3L,9L,3L,3L,8L,9L,1L,3L,0L,1L,1L,5L,7L,8L,4L,5L,7L,0L,9L,8L,7L,2L,0L,2L,8L,1L,0L,1L,7L,1L,0L,3L,2L,5L,5L,5L,9L,6L,8L,4L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197392Inst : IEnumerable<long>
{
public static readonly long[] Value=A197392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197392.Bytes);
public long this[int i]=>Value[i];

public static A197392Inst Instance=new A197392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197393
{
public static readonly long[] Value={ 2L,5L,3L,8L,6L,5L,6L,3L,3L,5L,9L,0L,7L,9L,4L,1L,6L,9L,7L,8L,7L,2L,3L,7L,0L,2L,9L,9L,4L,0L,7L,5L,7L,7L,6L,1L,4L,7L,9L,5L,7L,4L,2L,5L,5L,4L,6L,7L,6L,1L,7L,2L,2L,0L,2L,9L,0L,3L,3L,7L,8L,3L,6L,5L,7L,7L,3L,1L,7L,7L,1L,3L,8L,6L,6L,7L,6L,6L,1L,9L,6L,4L,1L,5L,3L,6L,5L,0L,3L,5L,3L,3L,7L,0L,3L,3L,9L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197393Inst : IEnumerable<long>
{
public static readonly long[] Value=A197393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197393.Bytes);
public long this[int i]=>Value[i];

public static A197393Inst Instance=new A197393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197394
{
public static readonly long[] Value={ 2L,9L,9L,8L,8L,7L,3L,7L,3L,2L,3L,3L,1L,8L,9L,8L,6L,2L,1L,7L,7L,6L,8L,5L,1L,9L,0L,3L,1L,3L,9L,1L,6L,1L,0L,2L,1L,9L,0L,2L,4L,5L,5L,2L,2L,8L,6L,7L,3L,2L,7L,1L,9L,5L,4L,0L,2L,6L,0L,1L,4L,1L,6L,1L,9L,5L,0L,6L,8L,4L,6L,1L,8L,6L,6L,1L,4L,4L,9L,9L,7L,3L,2L,2L,8L,5L,1L,0L,3L,2L,9L,6L,2L,7L,6L,4L,0L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197394Inst : IEnumerable<long>
{
public static readonly long[] Value=A197394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197394.Bytes);
public long this[int i]=>Value[i];

public static A197394Inst Instance=new A197394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197395
{
public static readonly long[] Value={ 1L,1L,17L,547L,19603L,1982913L,534127371L,330460207137L,459425284426157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197395Inst : IEnumerable<long>
{
public static readonly long[] Value=A197395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197395.Bytes);
public long this[int i]=>Value[i];

public static A197395Inst Instance=new A197395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197396
{
public static readonly long[] Value={ 1L,9L,17L,81L,257L,1003L,3417L,12673L,46165L,168569L,614795L,2245461L,8191537L,29913649L,109228305L,398768515L,1455927145L,5315748449L,19407950069L,70859924513L,258716449075L,944591935629L,3448776039137L,12591745130321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197396Inst : IEnumerable<long>
{
public static readonly long[] Value=A197396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197396.Bytes);
public long this[int i]=>Value[i];

public static A197396Inst Instance=new A197396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197397
{
public static readonly long[] Value={ 1L,17L,81L,547L,2571L,13397L,78101L,423957L,2255611L,12173719L,66864485L,361733507L,1953439221L,10607016995L,57610139877L,312099473393L,1691511381425L,9176876436943L,49767044309153L,269799849310117L,1462993236129599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197397Inst : IEnumerable<long>
{
public static readonly long[] Value=A197397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197397.Bytes);
public long this[int i]=>Value[i];

public static A197397Inst Instance=new A197397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197398
{
public static readonly long[] Value={ 1L,33L,257L,2571L,19603L,159463L,1353761L,11871747L,99322949L,832736311L,7100237801L,60485596877L,511509684117L,4330650440271L,36779000662959L,312087013491651L,2645221650088423L,22429333082583617L,190276664212068839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197398Inst : IEnumerable<long>
{
public static readonly long[] Value=A197398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197398.Bytes);
public long this[int i]=>Value[i];

public static A197398Inst Instance=new A197398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197399
{
public static readonly long[] Value={ 1L,89L,1003L,13397L,159463L,1982913L,26456233L,338629635L,4353024153L,55929879939L,722493236409L,9314480449393L,119992375800087L,1545874022307093L,19926794194335021L,256859243868710897L,3310199428923647595L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197399Inst : IEnumerable<long>
{
public static readonly long[] Value=A197399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197399.Bytes);
public long this[int i]=>Value[i];

public static A197399Inst Instance=new A197399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197400
{
public static readonly BigInteger[] Value={ 1L,249L,3417L,78101L,1353761L,26456233L,534127371L,10702459629L,210165095895L,4163535286913L,82989760611503L,1647146588097919L,32676624824656185L,648733177064446543L,12886037922010071897UL,BigInteger.Parse("255825582321287654665") };
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
public class A197400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197400Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197400.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197400Inst Instance=new A197400Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197401
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,9L,9L,1L,1L,17L,17L,17L,1L,1L,33L,81L,81L,33L,1L,1L,89L,257L,547L,257L,89L,1L,1L,249L,1003L,2571L,2571L,1003L,249L,1L,1L,553L,3417L,13397L,19603L,13397L,3417L,553L,1L,1L,1321L,12673L,78101L,159463L,159463L,78101L,12673L,1321L,1L,1L,3361L,46165L,423957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197401Inst : IEnumerable<long>
{
public static readonly long[] Value=A197401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197401.Bytes);
public long this[int i]=>Value[i];

public static A197401Inst Instance=new A197401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197402
{
public static readonly long[] Value={ 1L,9L,60L,3305L,356211L,93153650L,77683473682L,174585377113223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197402Inst : IEnumerable<long>
{
public static readonly long[] Value=A197402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197402.Bytes);
public long this[int i]=>Value[i];

public static A197402Inst Instance=new A197402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197403
{
public static readonly long[] Value={ 3L,9L,20L,71L,227L,664L,2107L,6675L,20696L,65029L,205057L,643930L,2026105L,6384135L,20104382L,63329883L,199576691L,628932096L,1982100085L,6247388117L,19691746204L,62069757373L,195654894641L,616749232724L,1944155102539L,6128552692107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197403Inst : IEnumerable<long>
{
public static readonly long[] Value=A197403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197403.Bytes);
public long this[int i]=>Value[i];

public static A197403Inst Instance=new A197403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197404
{
public static readonly long[] Value={ 4L,20L,60L,358L,1626L,7232L,34717L,160988L,748843L,3514426L,16448990L,76889286L,359867470L,1684122959L,7879951514L,36879246800L,172597946528L,807735845097L,3780221117751L,17691605965676L,82797291928191L,387496301051514L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197404Inst : IEnumerable<long>
{
public static readonly long[] Value=A197404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197404.Bytes);
public long this[int i]=>Value[i];

public static A197404Inst Instance=new A197404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197405
{
public static readonly long[] Value={ 5L,71L,358L,3305L,25621L,199384L,1634731L,13013551L,103260478L,825286477L,6597403489L,52719871616L,421012069157L,3360781198751L,26839340562982L,214392512110323L,1712358386200271L,13675010695945780L,109210026376844947L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197405Inst : IEnumerable<long>
{
public static readonly long[] Value=A197405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197405.Bytes);
public long this[int i]=>Value[i];

public static A197405Inst Instance=new A197405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197406
{
public static readonly long[] Value={ 9L,227L,1626L,25621L,356211L,4499426L,60334353L,801294395L,10631272297L,141478252511L,1877225887699L,24928405579380L,331380977085358L,4402455983432465L,58475570189400714L,776864156510384965L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197406Inst : IEnumerable<long>
{
public static readonly long[] Value=A197406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197406.Bytes);
public long this[int i]=>Value[i];

public static A197406Inst Instance=new A197406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197407
{
public static readonly BigInteger[] Value={ 16L,664L,7232L,199384L,4499426L,93153650L,2065093081L,45796265386L,1003308210971L,22026879283832L,484764553481336L,10667288376795442L,234488008953014630L,5155498381464737047L,BigInteger.Parse("113400638560649259216") };
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
public class A197407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197407Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197407.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197407Inst Instance=new A197407Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197408
{
public static readonly BigInteger[] Value={ 25L,2107L,34717L,1634731L,60334353L,2065093081L,77683473682L,2861267797023L,104224692369107L,3821001855576417L,140295906943370100L,5143358134125047217L,BigInteger.Parse("188539285472381998575"),BigInteger.Parse("6914680866283564114758"),BigInteger.Parse("253564501233044701809946") };
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
public class A197408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197408Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197408.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197408Inst Instance=new A197408Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197409
{
public static readonly long[] Value={ 1L,3L,3L,4L,9L,4L,5L,20L,20L,5L,9L,71L,60L,71L,9L,16L,227L,358L,358L,227L,16L,25L,664L,1626L,3305L,1626L,664L,25L,39L,2107L,7232L,25621L,25621L,7232L,2107L,39L,64L,6675L,34717L,199384L,356211L,199384L,34717L,6675L,64L,105L,20696L,160988L,1634731L,4499426L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197409Inst : IEnumerable<long>
{
public static readonly long[] Value=A197409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197409.Bytes);
public long this[int i]=>Value[i];

public static A197409Inst Instance=new A197409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197410
{
public static readonly long[] Value={ 1L,3L,4L,21L,6L,216L,8L,315L,52L,432L,12L,80640L,14L,720L,864L,9765L,18L,176904L,20L,232848L,1408L,1512L,24L,149299200L,186L,2016L,2080L,460992L,30L,274827168L,32L,615195L,2880L,3240L,3744L,13333320000L,38L,3960L,3808L,680400000L,42L,702079488L,44L,1270080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197410Inst : IEnumerable<long>
{
public static readonly long[] Value=A197410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197410.Bytes);
public long this[int i]=>Value[i];

public static A197410Inst Instance=new A197410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197411
{
public static readonly long[] Value={ 2L,1L,9L,4L,2L,3L,2L,9L,1L,9L,0L,1L,6L,9L,1L,9L,1L,4L,4L,4L,7L,4L,1L,6L,4L,0L,9L,4L,9L,3L,4L,0L,8L,4L,2L,1L,5L,8L,8L,8L,0L,2L,1L,6L,0L,3L,0L,6L,8L,3L,7L,9L,9L,6L,9L,1L,4L,7L,7L,4L,8L,0L,0L,9L,3L,5L,2L,7L,5L,8L,6L,8L,6L,0L,7L,7L,7L,8L,5L,9L,5L,4L,3L,6L,7L,3L,0L,8L,6L,2L,5L,8L,2L,9L,9L,8L,8L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197411Inst : IEnumerable<long>
{
public static readonly long[] Value=A197411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197411.Bytes);
public long this[int i]=>Value[i];

public static A197411Inst Instance=new A197411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197412
{
public static readonly long[] Value={ 3L,2L,8L,1L,3L,7L,2L,2L,9L,5L,3L,1L,1L,0L,4L,9L,8L,9L,9L,4L,2L,4L,7L,9L,8L,3L,5L,4L,8L,3L,9L,6L,1L,9L,2L,2L,0L,2L,2L,6L,2L,0L,6L,6L,2L,9L,3L,8L,6L,2L,2L,6L,7L,8L,2L,6L,3L,8L,5L,7L,0L,6L,9L,2L,5L,6L,4L,6L,8L,4L,3L,8L,5L,9L,1L,0L,5L,5L,0L,5L,4L,3L,1L,2L,1L,6L,5L,0L,7L,0L,0L,5L,7L,5L,8L,2L,0L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197412Inst : IEnumerable<long>
{
public static readonly long[] Value=A197412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197412.Bytes);
public long this[int i]=>Value[i];

public static A197412Inst Instance=new A197412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197413
{
public static readonly long[] Value={ 1L,9L,6L,0L,6L,6L,9L,6L,5L,4L,5L,8L,7L,9L,3L,5L,5L,9L,3L,9L,5L,4L,4L,8L,6L,8L,8L,3L,3L,1L,5L,7L,6L,5L,6L,8L,5L,3L,1L,5L,9L,7L,0L,0L,2L,3L,6L,7L,6L,8L,2L,2L,3L,1L,5L,7L,7L,3L,5L,6L,1L,5L,0L,9L,2L,1L,7L,0L,1L,5L,8L,8L,6L,1L,8L,5L,3L,3L,8L,8L,4L,0L,0L,3L,4L,1L,5L,1L,5L,3L,0L,4L,5L,7L,7L,5L,6L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197413Inst : IEnumerable<long>
{
public static readonly long[] Value=A197413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197413.Bytes);
public long this[int i]=>Value[i];

public static A197413Inst Instance=new A197413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197414
{
public static readonly long[] Value={ 1L,3L,3L,9L,6L,7L,6L,6L,2L,2L,8L,1L,7L,2L,7L,1L,4L,4L,4L,1L,6L,8L,1L,3L,5L,4L,0L,2L,5L,6L,6L,4L,9L,2L,1L,5L,6L,2L,3L,9L,6L,8L,8L,4L,2L,5L,0L,7L,6L,2L,7L,4L,1L,3L,6L,6L,6L,5L,9L,0L,0L,8L,3L,6L,9L,5L,1L,7L,3L,6L,7L,6L,8L,5L,6L,4L,8L,0L,8L,0L,4L,2L,1L,5L,2L,5L,6L,5L,4L,8L,8L,3L,3L,9L,5L,2L,7L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197414Inst : IEnumerable<long>
{
public static readonly long[] Value=A197414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197414.Bytes);
public long this[int i]=>Value[i];

public static A197414Inst Instance=new A197414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197415
{
public static readonly long[] Value={ 0L,5L,8L,7L,7L,5L,0L,5L,6L,2L,2L,4L,6L,2L,9L,9L,5L,0L,9L,7L,7L,6L,4L,4L,1L,4L,2L,2L,4L,2L,5L,9L,4L,8L,4L,2L,4L,0L,9L,2L,7L,7L,4L,9L,0L,1L,9L,2L,7L,3L,1L,7L,9L,3L,6L,4L,3L,0L,6L,4L,7L,4L,3L,2L,6L,6L,6L,5L,3L,6L,9L,2L,4L,4L,8L,5L,1L,6L,4L,0L,7L,6L,4L,5L,9L,9L,9L,1L,5L,3L,3L,0L,2L,2L,3L,7L,5L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197415Inst : IEnumerable<long>
{
public static readonly long[] Value=A197415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197415.Bytes);
public long this[int i]=>Value[i];

public static A197415Inst Instance=new A197415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197416
{
public static readonly long[] Value={ 3L,0L,8L,1L,3L,5L,0L,0L,0L,5L,8L,6L,8L,0L,2L,5L,0L,2L,1L,7L,6L,0L,9L,5L,6L,4L,7L,9L,0L,4L,4L,8L,6L,8L,6L,8L,8L,7L,7L,6L,7L,8L,8L,2L,0L,4L,0L,9L,0L,9L,1L,3L,1L,9L,6L,5L,0L,0L,7L,8L,7L,1L,5L,1L,2L,7L,8L,6L,8L,6L,2L,5L,5L,1L,6L,0L,9L,2L,3L,2L,5L,8L,7L,6L,2L,9L,5L,2L,4L,1L,8L,7L,9L,1L,8L,2L,9L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197416Inst : IEnumerable<long>
{
public static readonly long[] Value=A197416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197416.Bytes);
public long this[int i]=>Value[i];

public static A197416Inst Instance=new A197416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197417
{
public static readonly long[] Value={ 3L,8L,0L,7L,9L,8L,4L,5L,0L,3L,8L,6L,1L,9L,1L,2L,5L,4L,6L,8L,0L,8L,5L,5L,5L,4L,4L,9L,1L,1L,1L,3L,6L,6L,4L,2L,2L,1L,9L,3L,6L,1L,3L,8L,3L,2L,0L,1L,4L,2L,5L,8L,3L,0L,4L,3L,5L,5L,0L,6L,7L,5L,4L,8L,6L,5L,9L,7L,6L,5L,7L,0L,8L,0L,0L,1L,4L,9L,2L,9L,4L,6L,2L,3L,0L,4L,7L,5L,5L,3L,0L,0L,5L,5L,5L,0L,9L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197417Inst : IEnumerable<long>
{
public static readonly long[] Value=A197417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197417.Bytes);
public long this[int i]=>Value[i];

public static A197417Inst Instance=new A197417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197418
{
public static readonly long[] Value={ 1L,4L,9L,5L,9L,0L,9L,5L,4L,6L,4L,3L,9L,9L,9L,4L,8L,5L,7L,4L,9L,6L,5L,7L,5L,1L,8L,6L,3L,1L,6L,9L,6L,8L,0L,9L,1L,1L,9L,8L,1L,3L,6L,9L,1L,3L,1L,7L,2L,9L,0L,6L,0L,5L,8L,0L,7L,1L,1L,0L,0L,7L,9L,7L,7L,0L,8L,4L,0L,5L,9L,6L,7L,6L,1L,5L,8L,4L,6L,4L,0L,5L,7L,9L,6L,1L,3L,1L,5L,9L,5L,9L,2L,5L,2L,3L,7L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197418Inst : IEnumerable<long>
{
public static readonly long[] Value=A197418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197418.Bytes);
public long this[int i]=>Value[i];

public static A197418Inst Instance=new A197418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197419
{
public static readonly long[] Value={ 1L,-1L,1L,5L,-2L,1L,-1L,5L,-3L,1L,1L,-2L,5L,-4L,1L,1L,1L,-5L,25L,-5L,1L,-5L,1L,3L,-10L,25L,-6L,1L,-1L,-5L,7L,7L,-35L,35L,-7L,1L,7L,-4L,-10L,28L,7L,-28L,70L,-8L,1L,3L,21L,-6L,-10L,21L,63L,-42L,30L,-9L,1L,-15L,3L,21L,-20L,-25L,42L,21L,-60L,75L,-10L,1L,-5L,-15L,33L,77L,-55L,-55L,77L,33L,-165L,275L,-11L,1L,7601L,-10L,-45L,66L,231L,-132L,-110L,132L,99L,-110L,55L,-12L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197419Inst : IEnumerable<long>
{
public static readonly long[] Value=A197419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197419.Bytes);
public long this[int i]=>Value[i];

public static A197419Inst Instance=new A197419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197420
{
public static readonly long[] Value={ 1L,1L,1L,6L,1L,1L,2L,2L,1L,1L,10L,1L,1L,1L,1L,6L,2L,1L,3L,1L,1L,42L,1L,2L,1L,2L,1L,1L,6L,6L,2L,2L,2L,2L,1L,1L,30L,3L,3L,3L,1L,1L,3L,1L,1L,10L,10L,1L,1L,1L,5L,1L,1L,1L,1L,22L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,6L,2L,2L,2L,1L,1L,1L,1L,2L,6L,1L,1L,2730L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197420Inst : IEnumerable<long>
{
public static readonly long[] Value=A197420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197420.Bytes);
public long this[int i]=>Value[i];

public static A197420Inst Instance=new A197420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197421
{
public static readonly long[] Value={ 44839L,60859L,130411L,204749L,303767L,902971L,1027969L,1471633L,2514257L,3658769L,6908719L,7415743L,21966317L,28168523L,32413109L,37049567L,44034163L,47856331L,373881787L,425445073L,443609813L,564963589L,732111109L,758871401L,857997893L,995046653L,2489902577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197421Inst : IEnumerable<long>
{
public static readonly long[] Value=A197421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197421.Bytes);
public long this[int i]=>Value[i];

public static A197421Inst Instance=new A197421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197422
{
public static readonly long[] Value={ 1103L,9281L,10949L,12157L,26921L,48757L,61949L,87407L,92459L,95923L,124087L,162859L,198811L,289417L,363809L,467183L,530983L,754981L,792307L,830677L,1124051L,1537373L,1662307L,1706251L,1830401L,2023183L,2507963L,2534879L,3358099L,3616721L,3912901L,3929707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197422Inst : IEnumerable<long>
{
public static readonly long[] Value=A197422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197422.Bytes);
public long this[int i]=>Value[i];

public static A197422Inst Instance=new A197422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197423
{
public static readonly long[] Value={ 1L,0L,3L,14L,5L,25L,69L,16L,20L,4L,34L,28L,41L,9L,8L,53L,73L,12L,7L,38L,46L,81L,13L,18L,120L,138L,6L,156L,186L,52L,31L,33L,14L,166L,98L,97L,96L,104L,35L,105L,27L,22L,93L,146L,5L,48L,55L,249L,15L,91L,37L,42L,187L,77L,90L,124L,352L,25L,110L,394L,89L,280L,69L,147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197423Inst : IEnumerable<long>
{
public static readonly long[] Value=A197423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197423.Bytes);
public long this[int i]=>Value[i];

public static A197423Inst Instance=new A197423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197424
{
public static readonly long[] Value={ 4L,36L,225L,1600L,10816L,74529L,509796L,3496900L,23961025L,164249856L,1125736704L,7716041281L,52886200900L,362488284900L,2484529385121L,17029223715904L,116720020119616L,800010960336225L,5483356589096100L,37583485459535236L,257601040852192129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197424Inst : IEnumerable<long>
{
public static readonly long[] Value=A197424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197424.Bytes);
public long this[int i]=>Value[i];

public static A197424Inst Instance=new A197424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197425
{
public static readonly long[] Value={ 1L,9L,68L,5197L,720447L,337295264L,529968166606L,2583340386672393L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197425Inst : IEnumerable<long>
{
public static readonly long[] Value=A197425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197425.Bytes);
public long this[int i]=>Value[i];

public static A197425Inst Instance=new A197425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197426
{
public static readonly long[] Value={ 4L,20L,68L,448L,2152L,10684L,55567L,280544L,1425111L,7280350L,37165198L,189316196L,965915209L,4926863205L,25123365839L,128156345456L,653685106884L,3334114760247L,17006120383127L,86741818975198L,442435364449588L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197426Inst : IEnumerable<long>
{
public static readonly long[] Value=A197426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197426.Bytes);
public long this[int i]=>Value[i];

public static A197426Inst Instance=new A197426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197427
{
public static readonly long[] Value={ 5L,71L,448L,5197L,43909L,410456L,4017895L,37566429L,351740354L,3301443327L,31135760775L,294213106126L,2771339919971L,26068700897789L,245447885397640L,2313251869240159L,21800440099050007L,205343629421991480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197427Inst : IEnumerable<long>
{
public static readonly long[] Value=A197427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197427.Bytes);
public long this[int i]=>Value[i];

public static A197427Inst Instance=new A197427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197428
{
public static readonly ulong[] Value={ 9L,227L,2152L,43909L,720447L,11769456L,195632425L,3187783369L,53026008675L,881220874951L,14498616415957L,239536136122464L,3969393711476942L,65665510796270903L,1084945281836331610L,17938093372334278851UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197428Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A197428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197428.Bytes);
public ulong this[int i]=>Value[i];

public static A197428Inst Instance=new A197428Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197429
{
public static readonly BigInteger[] Value={ 16L,664L,10684L,410456L,11769456L,337295264L,9869104795L,292706228390L,8642552356445L,253114165333694L,7454560598765350L,220113696023686560L,6476539750313171801L,BigInteger.Parse("190545665782624046543"),BigInteger.Parse("5615390905643680916267") };
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
public class A197429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197429Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197429.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197429Inst Instance=new A197429Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197430
{
public static readonly BigInteger[] Value={ 25L,2107L,55567L,4017895L,195632425L,9869104795L,529968166606L,27927270266251L,1461399711177586L,76357681634837889L,4016048479413867754L,BigInteger.Parse("210995429397329769859"),BigInteger.Parse("11066069030221109085243"),BigInteger.Parse("581180575552246936955138") };
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
public class A197430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197430Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197430.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197430Inst Instance=new A197430Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197431
{
public static readonly long[] Value={ 1L,3L,3L,4L,9L,4L,5L,20L,20L,5L,9L,71L,68L,71L,9L,16L,227L,448L,448L,227L,16L,25L,664L,2152L,5197L,2152L,664L,25L,39L,2107L,10684L,43909L,43909L,10684L,2107L,39L,64L,6675L,55567L,410456L,720447L,410456L,55567L,6675L,64L,105L,20696L,280544L,4017895L,11769456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197431Inst : IEnumerable<long>
{
public static readonly long[] Value=A197431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197431.Bytes);
public long this[int i]=>Value[i];

public static A197431Inst Instance=new A197431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197432
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,3L,4L,5L,6L,6L,7L,7L,8L,8L,9L,14L,15L,15L,16L,16L,17L,17L,18L,19L,20L,20L,21L,21L,22L,22L,23L,42L,43L,43L,44L,44L,45L,45L,46L,47L,48L,48L,49L,49L,50L,50L,51L,56L,57L,57L,58L,58L,59L,59L,60L,61L,62L,62L,63L,63L,64L,64L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197432Inst : IEnumerable<long>
{
public static readonly long[] Value=A197432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197432.Bytes);
public long this[int i]=>Value[i];

public static A197432Inst Instance=new A197432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197433
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,7L,8L,14L,15L,16L,17L,19L,20L,21L,22L,42L,43L,44L,45L,47L,48L,49L,50L,56L,57L,58L,59L,61L,62L,63L,64L,132L,133L,134L,135L,137L,138L,139L,140L,146L,147L,148L,149L,151L,152L,153L,154L,174L,175L,176L,177L,179L,180L,181L,182L,188L,189L,190L,191L,193L,194L,195L,196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197433Inst : IEnumerable<long>
{
public static readonly long[] Value=A197433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197433.Bytes);
public long this[int i]=>Value[i];

public static A197433Inst Instance=new A197433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197434
{
public static readonly BigInteger[] Value={ 3L,34L,5032L,5184780L,41434710920L,2476133354164264L,BigInteger.Parse("1112998745351676081292") };
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
public class A197434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197434Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197434.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197434Inst Instance=new A197434Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197435
{
public static readonly long[] Value={ 3L,6L,10L,28L,66L,164L,400L,982L,2406L,5898L,14456L,35434L,86852L,212884L,521802L,1278994L,3134954L,7684116L,18834610L,46165692L,113157168L,277360614L,679841246L,1666365362L,4084444032L,10011419722L,24539086364L,60147988628L,147429308586L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197435Inst : IEnumerable<long>
{
public static readonly long[] Value=A197435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197435.Bytes);
public long this[int i]=>Value[i];

public static A197435Inst Instance=new A197435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197436
{
public static readonly long[] Value={ 6L,34L,246L,1736L,12450L,89528L,644328L,4638654L,33398106L,240473126L,1731475912L,12467176650L,89767756044L,646357555524L,4653989082594L,33510269018262L,241285084850682L,1737332890742456L,12509374882010702L,90071661504230880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197436Inst : IEnumerable<long>
{
public static readonly long[] Value=A197436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197436.Bytes);
public long this[int i]=>Value[i];

public static A197436Inst Instance=new A197436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197437
{
public static readonly BigInteger[] Value={ 10L,246L,5032L,98356L,1933358L,37989740L,746250884L,14659367358L,287967404918L,5656823960766L,111122501459806L,2182887521173568L,42880585565696148L,842345101555883176L,16547005149070978968UL,BigInteger.Parse("325048936455561795752") };
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
public class A197437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197437Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197437.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197437Inst Instance=new A197437Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197438
{
public static readonly BigInteger[] Value={ 28L,1736L,98356L,5184780L,279785830L,15068331840L,811669674888L,43723066740718L,2355282493094894L,126874994917842426L,6834535322256736280L,BigInteger.Parse("368164567512212216530"),BigInteger.Parse("19832386906421976298012"),BigInteger.Parse("1068336297549353928162784") };
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
public class A197438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197438Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197438.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197438Inst Instance=new A197438Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197439
{
public static readonly BigInteger[] Value={ 66L,12450L,1933358L,279785830L,41434710920L,6117749044788L,903529041581340L,133441483281347232L,BigInteger.Parse("19707781710109683796"),BigInteger.Parse("2910613305873428168598"),BigInteger.Parse("429864171311414595234150"),BigInteger.Parse("63486005383317296504335560") };
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
public class A197439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197439Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197439.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197439Inst Instance=new A197439Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197440
{
public static readonly BigInteger[] Value={ 164L,89528L,37989740L,15068331840L,6117749044788L,2476133354164264L,1002605692717130692L,BigInteger.Parse("405955156856554399238"),BigInteger.Parse("164371431760256700590038"),BigInteger.Parse("66554100814528841770905242"),BigInteger.Parse("26947801511575118488851200530") };
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
public class A197440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197440Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197440.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197440Inst Instance=new A197440Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197441
{
public static readonly BigInteger[] Value={ 400L,644328L,746250884L,811669674888L,903529041581340L,1002605692717130692L,BigInteger.Parse("1112998745351676081292"),BigInteger.Parse("1235511655153578238343970"),BigInteger.Parse("1371513250568819862402121642"),BigInteger.Parse("1522485346268679493501795851082") };
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
public class A197441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197441Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197441.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197441Inst Instance=new A197441Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197442
{
public static readonly long[] Value={ 3L,6L,6L,10L,34L,10L,28L,246L,246L,28L,66L,1736L,5032L,1736L,66L,164L,12450L,98356L,98356L,12450L,164L,400L,89528L,1933358L,5184780L,1933358L,89528L,400L,982L,644328L,37989740L,279785830L,279785830L,37989740L,644328L,982L,2406L,4638654L,746250884L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197442Inst : IEnumerable<long>
{
public static readonly long[] Value=A197442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197442.Bytes);
public long this[int i]=>Value[i];

public static A197442Inst Instance=new A197442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197443
{
public static readonly BigInteger[] Value={ 1L,5L,81L,4837L,1108699L,982926107L,3148323076125L,37516007592943532L,BigInteger.Parse("1657994465210882573048") };
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
public class A197443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197443Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197443.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197443Inst Instance=new A197443Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197444
{
public static readonly long[] Value={ 2L,5L,12L,36L,107L,321L,957L,2868L,8581L,25694L,76914L,230273L,689377L,2063867L,6178778L,18498023L,55379290L,165794354L,496354537L,1485984549L,4448735449L,13318609060L,39873206463L,119372269782L,357376295102L,1069911935955L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197444Inst : IEnumerable<long>
{
public static readonly long[] Value=A197444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197444.Bytes);
public long this[int i]=>Value[i];

public static A197444Inst Instance=new A197444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197445
{
public static readonly long[] Value={ 3L,12L,81L,474L,2678L,15410L,88767L,510482L,2936714L,16895217L,97197637L,559175541L,3216923150L,18506887013L,106469709385L,612517802024L,3523801014059L,20272347435052L,116626354899557L,670948774602366L,3859953085161367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197445Inst : IEnumerable<long>
{
public static readonly long[] Value=A197445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197445.Bytes);
public long this[int i]=>Value[i];

public static A197445Inst Instance=new A197445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197446
{
public static readonly long[] Value={ 4L,36L,474L,4837L,52117L,585194L,6455759L,71202438L,787298158L,8700460833L,96129107870L,1062244177133L,11737953179188L,129703872646573L,1433228960340464L,15837211757913841L,175001375414696401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197446Inst : IEnumerable<long>
{
public static readonly long[] Value=A197446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197446.Bytes);
public long this[int i]=>Value[i];

public static A197446Inst Instance=new A197446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197447
{
public static readonly BigInteger[] Value={ 7L,107L,2678L,52117L,1108699L,23829080L,504568165L,10724642167L,228248265080L,4853181015432L,103200753393047L,2194748772730124L,46673287485335449L,992547357156970890L,BigInteger.Parse("21107504726738892508"),BigInteger.Parse("448871249985110511395") };
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
public class A197447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197447Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197447.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197447Inst Instance=new A197447Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197448
{
public static readonly BigInteger[] Value={ 11L,321L,15410L,585194L,23829080L,982926107L,40087361395L,1640477445822L,67160665746869L,2747685400705119L,112433629005651948L,4600917175526994358L,BigInteger.Parse("188267595598497672073"),BigInteger.Parse("7703877269427034462338"),BigInteger.Parse("315242428170240015474340") };
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
public class A197448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197448Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197448.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197448Inst Instance=new A197448Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197449
{
public static readonly BigInteger[] Value={ 16L,957L,88767L,6455759L,504568165L,40087361395L,3148323076125L,247785141871837L,19514460176530843L,1536223846055481075L,BigInteger.Parse("120945067934443941208"),BigInteger.Parse("9522042330180130196817"),BigInteger.Parse("749659600975504964938552") };
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
public class A197449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197449Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197449.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197449Inst Instance=new A197449Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197450
{
public static readonly long[] Value={ 1L,2L,2L,3L,5L,3L,4L,12L,12L,4L,7L,36L,81L,36L,7L,11L,107L,474L,474L,107L,11L,16L,321L,2678L,4837L,2678L,321L,16L,26L,957L,15410L,52117L,52117L,15410L,957L,26L,41L,2868L,88767L,585194L,1108699L,585194L,88767L,2868L,41L,62L,8581L,510482L,6455759L,23829080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197450Inst : IEnumerable<long>
{
public static readonly long[] Value=A197450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197450.Bytes);
public long this[int i]=>Value[i];

public static A197450Inst Instance=new A197450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197451
{
public static readonly long[] Value={ 1L,7L,31L,583L,15825L,1097175L,168397471L,55114740895L,39081044835889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197451Inst : IEnumerable<long>
{
public static readonly long[] Value=A197451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197451.Bytes);
public long this[int i]=>Value[i];

public static A197451Inst Instance=new A197451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197452
{
public static readonly long[] Value={ 2L,10L,31L,84L,290L,923L,2887L,9216L,29288L,92868L,294893L,936361L,2972409L,9436595L,29959267L,95112260L,301956214L,958634094L,3043413512L,9662045566L,30674490204L,97383543481L,309167462063L,981526438497L,3116091639355L,9892781977749L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197452Inst : IEnumerable<long>
{
public static readonly long[] Value=A197452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197452.Bytes);
public long this[int i]=>Value[i];

public static A197452Inst Instance=new A197452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197453
{
public static readonly long[] Value={ 3L,23L,84L,583L,2233L,10758L,53337L,252125L,1209824L,5768661L,27595593L,132068806L,631286751L,3018734589L,14435100274L,69026970467L,330080196953L,1578377336418L,7547555375561L,36091265919103L,172582773358524L,825263869695369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197453Inst : IEnumerable<long>
{
public static readonly long[] Value=A197453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197453.Bytes);
public long this[int i]=>Value[i];

public static A197453Inst Instance=new A197453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197454
{
public static readonly long[] Value={ 5L,57L,290L,2233L,15825L,104318L,738363L,5142371L,35673015L,248507899L,1727900136L,12019095470L,83618547829L,581654826801L,4046193710054L,28146680058973L,195796930694058L,1362027864550703L,9474705122664336L,65909095102841385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197454Inst : IEnumerable<long>
{
public static readonly long[] Value=A197454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197454.Bytes);
public long this[int i]=>Value[i];

public static A197454Inst Instance=new A197454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197455
{
public static readonly long[] Value={ 13L,275L,2887L,53337L,738363L,11014567L,168397471L,2499153985L,37543948067L,563650708913L,8446755201728L,126708291472793L,1900212948780127L,28496971166752387L,427384695145743821L,6409496691822202443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197455Inst : IEnumerable<long>
{
public static readonly long[] Value=A197455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197455.Bytes);
public long this[int i]=>Value[i];

public static A197455Inst Instance=new A197455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197456
{
public static readonly long[] Value={ 8L,122L,923L,10758L,104318L,1097175L,11014567L,112906556L,1151692226L,11746179526L,119887238727L,1222862832433L,12477649526031L,127300836703227L,1298804091935221L,13251229266573000L,135196822837023688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197456Inst : IEnumerable<long>
{
public static readonly long[] Value=A197456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197456.Bytes);
public long this[int i]=>Value[i];

public static A197456Inst Instance=new A197456Inst();

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