using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A142285
{
public static readonly long[] Value={ 79L,251L,337L,509L,853L,1283L,1627L,2143L,2659L,2917L,3089L,3347L,3433L,3691L,3863L,4637L,4723L,5153L,5669L,5927L,6271L,6529L,6701L,6959L,7561L,9109L,9281L,9539L,9883L,10141L,10313L,10399L,10657L,11087L,11173L,11689L,12119L,12377L,12721L,12893L,12979L,13151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142285Inst : IEnumerable<long>
{
public static readonly long[] Value=A142285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142285.Bytes);
public long this[int i]=>Value[i];

public static A142285Inst Instance=new A142285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142286
{
public static readonly long[] Value={ 37L,467L,811L,983L,1069L,1327L,1499L,2273L,2531L,2617L,2789L,3391L,3821L,3907L,4079L,4337L,4423L,5197L,6143L,6229L,6659L,6917L,7433L,7691L,7949L,8293L,9067L,9239L,9497L,10099L,10271L,10357L,10529L,11131L,12163L,12421L,13109L,13367L,13711L,13883L,14657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142286Inst : IEnumerable<long>
{
public static readonly long[] Value=A142286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142286.Bytes);
public long this[int i]=>Value[i];

public static A142286Inst Instance=new A142286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142287
{
public static readonly long[] Value={ 167L,683L,769L,941L,1543L,1801L,1973L,2833L,3607L,3779L,4639L,5413L,5843L,6101L,6359L,6703L,6961L,7219L,7477L,7649L,7907L,7993L,8423L,8681L,9283L,10487L,10831L,11003L,11261L,11519L,11777L,11863L,12379L,12637L,12809L,13411L,13669L,13841L,15131L,15217L,15647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142287Inst : IEnumerable<long>
{
public static readonly long[] Value=A142287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142287.Bytes);
public long this[int i]=>Value[i];

public static A142287Inst Instance=new A142287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142288
{
public static readonly long[] Value={ 211L,383L,641L,727L,1759L,1931L,2017L,2447L,2791L,2963L,3049L,3221L,3307L,3823L,4253L,4339L,4597L,5113L,5801L,6317L,6661L,6833L,7177L,7349L,7607L,7951L,8123L,8209L,8467L,9241L,9413L,9929L,10273L,10531L,10789L,11047L,11821L,12251L,12853L,13627L,13799L,14057L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142288Inst : IEnumerable<long>
{
public static readonly long[] Value=A142288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142288.Bytes);
public long this[int i]=>Value[i];

public static A142288Inst Instance=new A142288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142289
{
public static readonly long[] Value={ 83L,599L,857L,1201L,1373L,1459L,1889L,2663L,2749L,4211L,4297L,4813L,5501L,6361L,6619L,6791L,7307L,7393L,7823L,8081L,8167L,8597L,8941L,9199L,9371L,9629L,9887L,9973L,11177L,11779L,12037L,12553L,12983L,13241L,13327L,13499L,13757L,15391L,15649L,15907L,17627L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142289Inst : IEnumerable<long>
{
public static readonly long[] Value=A142289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142289.Bytes);
public long this[int i]=>Value[i];

public static A142289Inst Instance=new A142289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142290
{
public static readonly long[] Value={ 41L,127L,557L,643L,1847L,1933L,2621L,2707L,2879L,3137L,3739L,3911L,4513L,4943L,5717L,6491L,6577L,7351L,7523L,7867L,8039L,8297L,8641L,9157L,9587L,9931L,10103L,11393L,11909L,12253L,12511L,12941L,13457L,14489L,14747L,15091L,15263L,15349L,15607L,16381L,16553L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142290Inst : IEnumerable<long>
{
public static readonly long[] Value=A142290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142290.Bytes);
public long this[int i]=>Value[i];

public static A142290Inst Instance=new A142290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142291
{
public static readonly long[] Value={ 257L,601L,773L,859L,1031L,1117L,1289L,2063L,2579L,2837L,3181L,3697L,4127L,4643L,4729L,4987L,5417L,5503L,6277L,6449L,6793L,7309L,7481L,8513L,8599L,9029L,9631L,9803L,10061L,10663L,11093L,11351L,11437L,11867L,11953L,12211L,12641L,12899L,13759L,13931L,14447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142291Inst : IEnumerable<long>
{
public static readonly long[] Value=A142291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142291.Bytes);
public long this[int i]=>Value[i];

public static A142291Inst Instance=new A142291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142292
{
public static readonly long[] Value={ 89L,353L,397L,617L,661L,881L,1013L,1277L,1321L,1409L,1453L,2069L,2113L,2333L,2377L,2729L,2861L,3037L,3169L,3257L,3301L,3389L,3433L,3697L,3917L,4049L,4093L,4357L,4621L,4973L,5237L,5281L,5413L,5501L,5897L,6029L,6073L,6337L,6469L,6689L,6733L,6997L,7129L,7349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142292Inst : IEnumerable<long>
{
public static readonly long[] Value=A142292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142292.Bytes);
public long this[int i]=>Value[i];

public static A142292Inst Instance=new A142292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142293
{
public static readonly long[] Value={ 3L,47L,179L,223L,311L,443L,487L,619L,751L,839L,883L,971L,1103L,1279L,1367L,1499L,1543L,2027L,2203L,2423L,2467L,2687L,2731L,2819L,3083L,3259L,3347L,3391L,3919L,4007L,4051L,4139L,4271L,4447L,4799L,4931L,5107L,5503L,5591L,5987L,6163L,6427L,6691L,6779L,6823L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142293Inst : IEnumerable<long>
{
public static readonly long[] Value=A142293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142293.Bytes);
public long this[int i]=>Value[i];

public static A142293Inst Instance=new A142293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142294
{
public static readonly long[] Value={ 5L,137L,181L,269L,313L,401L,577L,709L,797L,929L,1061L,1193L,1237L,1721L,2029L,2161L,2293L,2381L,2557L,2689L,2777L,2909L,2953L,3041L,3217L,3613L,3701L,3833L,3877L,4229L,4273L,4493L,4801L,4889L,4933L,5021L,5153L,5197L,5417L,5813L,5857L,6121L,6473L,6737L,6781L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142294Inst : IEnumerable<long>
{
public static readonly long[] Value=A142294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142294.Bytes);
public long this[int i]=>Value[i];

public static A142294Inst Instance=new A142294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142295
{
public static readonly long[] Value={ 7L,139L,227L,271L,359L,491L,887L,1019L,1063L,1151L,1283L,1327L,1459L,1723L,1811L,1987L,2207L,2251L,2339L,2383L,2647L,2999L,3307L,3527L,3571L,3659L,3923L,3967L,4099L,4231L,4363L,4451L,4583L,4759L,5023L,5419L,5507L,5639L,5683L,5903L,6079L,6211L,6299L,6343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142295Inst : IEnumerable<long>
{
public static readonly long[] Value=A142295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142295.Bytes);
public long this[int i]=>Value[i];

public static A142295Inst Instance=new A142295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142344
{
public static readonly long[] Value={ 71L,163L,347L,439L,577L,761L,853L,991L,1129L,1451L,1543L,2003L,2141L,2371L,2417L,2647L,2693L,2969L,3061L,3613L,3659L,3797L,3889L,4027L,4073L,4211L,4349L,4441L,4993L,5039L,5407L,5591L,5683L,5821L,5867L,6143L,6373L,6833L,6971L,7109L,7247L,7477L,7523L,7753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142344Inst : IEnumerable<long>
{
public static readonly long[] Value=A142344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142344.Bytes);
public long this[int i]=>Value[i];

public static A142344Inst Instance=new A142344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142345
{
public static readonly long[] Value={ 3L,23L,29L,37L,41L,47L,61L,67L,83L,103L,113L,149L,157L,167L,193L,269L,277L,281L,331L,347L,439L,521L,569L,593L,677L,733L,823L,827L,877L,911L,1019L,1061L,1097L,1117L,1153L,1217L,1259L,1289L,1381L,1433L,1447L,1489L,1499L,1553L,1607L,1637L,1693L,1699L,1733L,1801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142345Inst : IEnumerable<long>
{
public static readonly long[] Value=A142345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142345.Bytes);
public long this[int i]=>Value[i];

public static A142345Inst Instance=new A142345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142346
{
public static readonly long[] Value={ 2L,11L,47L,73L,131L,151L,173L,181L,227L,239L,271L,307L,367L,379L,383L,461L,523L,643L,661L,677L,743L,797L,991L,997L,1021L,1063L,1091L,1307L,1459L,1567L,1637L,1723L,1811L,1831L,1951L,1987L,1999L,2027L,2111L,2251L,2273L,2297L,2543L,2609L,2647L,2699L,2707L,2801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142346Inst : IEnumerable<long>
{
public static readonly long[] Value=A142346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142346.Bytes);
public long this[int i]=>Value[i];

public static A142346Inst Instance=new A142346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142347
{
public static readonly long[] Value={ 1L,22L,32L,42L,58L,66L,88L,99L,104L,114L,119L,144L,166L,196L,200L,214L,221L,253L,279L,287L,291L,300L,314L,326L,345L,352L,372L,400L,407L,418L,426L,442L,454L,472L,482L,502L,506L,513L,538L,556L,566L,573L,580L,590L,602L,612L,618L,625L,630L,669L,698L,708L,717L,725L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142347Inst : IEnumerable<long>
{
public static readonly long[] Value=A142347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142347.Bytes);
public long this[int i]=>Value[i];

public static A142347Inst Instance=new A142347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142348
{
public static readonly long[] Value={ 2L,13L,19L,31L,37L,47L,61L,103L,137L,149L,293L,313L,349L,397L,421L,439L,463L,491L,587L,727L,751L,863L,929L,1049L,1153L,1187L,1229L,1289L,1297L,1361L,1427L,1483L,1493L,1553L,1571L,1601L,1741L,1787L,1847L,1867L,1933L,1997L,2027L,2069L,2131L,2239L,2389L,2411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142348Inst : IEnumerable<long>
{
public static readonly long[] Value=A142348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142348.Bytes);
public long this[int i]=>Value[i];

public static A142348Inst Instance=new A142348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142349
{
public static readonly long[] Value={ 2L,3L,5L,7L,5L,5L,7L,11L,17L,23L,37L,41L,43L,29L,31L,61L,41L,43L,67L,71L,73L,79L,53L,83L,89L,97L,67L,107L,109L,113L,131L,67L,137L,139L,149L,151L,101L,163L,109L,167L,113L,173L,181L,191L,193L,197L,199L,223L,229L,233L,157L,239L,241L,163L,257L,173L,263L,181L,281L,193L,293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142349Inst : IEnumerable<long>
{
public static readonly long[] Value=A142349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142349.Bytes);
public long this[int i]=>Value[i];

public static A142349Inst Instance=new A142349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142350
{
public static readonly long[] Value={ 1L,4L,8L,6L,8L,14L,10L,18L,20L,21L,15L,24L,25L,27L,28L,30L,21L,32L,22L,34L,24L,25L,26L,42L,44L,45L,46L,48L,49L,50L,34L,52L,54L,55L,56L,38L,58L,40L,42L,64L,65L,66L,68L,46L,48L,75L,51L,77L,52L,80L,81L,82L,84L,86L,87L,88L,90L,91L,92L,93L,63L,95L,96L,98L,66L,100L,102L,104L,70L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142350Inst : IEnumerable<long>
{
public static readonly long[] Value=A142350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142350.Bytes);
public long this[int i]=>Value[i];

public static A142350Inst Instance=new A142350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142351
{
public static readonly long[] Value={ 3L,13L,11L,17L,29L,31L,23L,41L,43L,53L,61L,41L,43L,67L,47L,71L,73L,79L,83L,67L,101L,107L,109L,113L,79L,137L,139L,97L,149L,101L,157L,107L,167L,173L,179L,127L,191L,193L,197L,199L,139L,211L,223L,151L,227L,229L,241L,167L,251L,179L,269L,271L,277L,281L,283L,307L,311L,317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142351Inst : IEnumerable<long>
{
public static readonly long[] Value=A142351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142351.Bytes);
public long this[int i]=>Value[i];

public static A142351Inst Instance=new A142351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142352
{
public static readonly long[] Value={ 2L,5L,7L,11L,17L,23L,19L,31L,23L,43L,59L,31L,67L,47L,71L,73L,79L,83L,59L,89L,53L,107L,109L,113L,127L,131L,89L,137L,139L,97L,149L,103L,157L,163L,167L,173L,179L,181L,127L,191L,131L,197L,199L,223L,151L,227L,22L,9L,233L,239L,241L,163L,263L,271L,181L,277L,281L,283L,293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142352Inst : IEnumerable<long>
{
public static readonly long[] Value=A142352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142352.Bytes);
public long this[int i]=>Value[i];

public static A142352Inst Instance=new A142352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142353
{
public static readonly long[] Value={ 2L,5L,5L,7L,11L,11L,17L,23L,17L,13L,19L,31L,37L,19L,41L,43L,47L,59L,61L,43L,71L,73L,79L,83L,61L,47L,97L,103L,73L,113L,83L,127L,131L,137L,149L,151L,157L,163L,167L,173L,191L,193L,211L,149L,227L,229L,157L,239L,241L,167L,257L,269L,271L,281L,293L,197L,307L,311L,211L,331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142353Inst : IEnumerable<long>
{
public static readonly long[] Value=A142353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142353.Bytes);
public long this[int i]=>Value[i];

public static A142353Inst Instance=new A142353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142354
{
public static readonly long[] Value={ 0L,0L,2L,0L,6L,6L,0L,2L,0L,4L,0L,0L,8L,4L,8L,0L,0L,0L,0L,0L,0L,0L,2L,6L,2L,0L,0L,2L,0L,6L,6L,0L,8L,0L,6L,6L,0L,2L,0L,4L,4L,0L,2L,0L,4L,0L,0L,8L,4L,8L,0L,0L,8L,4L,8L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142354Inst : IEnumerable<long>
{
public static readonly long[] Value=A142354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142354.Bytes);
public long this[int i]=>Value[i];

public static A142354Inst Instance=new A142354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142355
{
public static readonly long[] Value={ 2L,331L,613L,1459L,1553L,1741L,2399L,2963L,3433L,3527L,4091L,4373L,4561L,4937L,5407L,5501L,5689L,5783L,6911L,7193L,7757L,8039L,10859L,11047L,11329L,11423L,11987L,12269L,12457L,12739L,13397L,13679L,14149L,14243L,14431L,14713L,15277L,15559L,16217L,17627L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142355Inst : IEnumerable<long>
{
public static readonly long[] Value=A142355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142355.Bytes);
public long this[int i]=>Value[i];

public static A142355Inst Instance=new A142355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142356
{
public static readonly long[] Value={ 239L,521L,709L,991L,1367L,1931L,2213L,2683L,2777L,3529L,3623L,4093L,4657L,4751L,5503L,5879L,6067L,7477L,7759L,7853L,8699L,8887L,9733L,10391L,10861L,11519L,11801L,12553L,12647L,13399L,13681L,13963L,14057L,14621L,15091L,15373L,15467L,15749L,15937L,17159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142356Inst : IEnumerable<long>
{
public static readonly long[] Value=A142356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142356.Bytes);
public long this[int i]=>Value[i];

public static A142356Inst Instance=new A142356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142357
{
public static readonly long[] Value={ 53L,241L,523L,617L,1087L,1181L,1933L,2027L,2309L,2591L,3061L,3343L,3719L,3907L,4001L,4283L,5693L,5881L,6163L,6257L,7103L,7573L,7949L,8231L,8419L,8513L,9547L,9829L,9923L,10111L,10487L,10957L,11239L,11897L,12743L,14153L,14341L,14717L,15187L,16033L,16127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142357Inst : IEnumerable<long>
{
public static readonly long[] Value=A142357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142357.Bytes);
public long this[int i]=>Value[i];

public static A142357Inst Instance=new A142357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142358
{
public static readonly long[] Value={ 7L,101L,383L,571L,853L,947L,1229L,1511L,1699L,2357L,3109L,3203L,3391L,3673L,3767L,4049L,4519L,4801L,5647L,5741L,6211L,6869L,7057L,7151L,7433L,7621L,8467L,9689L,10159L,10253L,10723L,11287L,12227L,12697L,12791L,12979L,14107L,14389L,15329L,16363L,16927L,17021L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142358Inst : IEnumerable<long>
{
public static readonly long[] Value=A142358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142358.Bytes);
public long this[int i]=>Value[i];

public static A142358Inst Instance=new A142358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142359
{
public static readonly long[] Value={ 149L,337L,431L,619L,1277L,1559L,1747L,2029L,2311L,2593L,2687L,2969L,3251L,3533L,4003L,4567L,4943L,5413L,5507L,6353L,6823L,6917L,7481L,7669L,7951L,8233L,8609L,9173L,9643L,10301L,10771L,11617L,13121L,13309L,13591L,13873L,13967L,14249L,14437L,14813L,15377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142359Inst : IEnumerable<long>
{
public static readonly long[] Value=A142359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142359.Bytes);
public long this[int i]=>Value[i];

public static A142359Inst Instance=new A142359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142408
{
public static readonly long[] Value={ 31L,79L,127L,223L,271L,367L,463L,607L,751L,991L,1039L,1087L,1231L,1279L,1327L,1423L,1471L,1567L,1663L,1759L,1951L,1999L,2143L,2239L,2287L,2383L,2671L,2719L,2767L,3343L,3391L,3583L,3631L,3727L,3823L,3919L,3967L,4111L,4159L,4447L,4591L,4639L,4783L,4831L,5023L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142408Inst : IEnumerable<long>
{
public static readonly long[] Value=A142408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142408.Bytes);
public long this[int i]=>Value[i];

public static A142408Inst Instance=new A142408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142409
{
public static readonly long[] Value={ 83L,131L,179L,227L,419L,467L,563L,659L,947L,1091L,1187L,1283L,1427L,1523L,1571L,1619L,1667L,1811L,1907L,2003L,2099L,2243L,2339L,2531L,2579L,2819L,2963L,3011L,3203L,3251L,3299L,3347L,3491L,3539L,3779L,3923L,4019L,4211L,4259L,4451L,4547L,4643L,4691L,4787L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142409Inst : IEnumerable<long>
{
public static readonly long[] Value=A142409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142409.Bytes);
public long this[int i]=>Value[i];

public static A142409Inst Instance=new A142409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142410
{
public static readonly long[] Value={ 37L,181L,229L,277L,373L,421L,613L,661L,709L,757L,853L,997L,1093L,1237L,1381L,1429L,1621L,1669L,1861L,2053L,2293L,2341L,2389L,2437L,2677L,2917L,3061L,3109L,3253L,3301L,3541L,3637L,3733L,3877L,4021L,4261L,4357L,4549L,4597L,4789L,4933L,5077L,5413L,5557L,5653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142410Inst : IEnumerable<long>
{
public static readonly long[] Value=A142410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142410.Bytes);
public long this[int i]=>Value[i];

public static A142410Inst Instance=new A142410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142411
{
public static readonly long[] Value={ 41L,89L,137L,233L,281L,521L,569L,617L,761L,809L,857L,953L,1049L,1097L,1193L,1289L,1433L,1481L,1721L,1913L,2153L,2297L,2393L,2441L,2633L,2729L,2777L,2969L,3209L,3257L,3449L,3593L,3833L,3881L,3929L,4073L,4217L,4409L,4457L,4649L,4793L,4889L,4937L,5081L,5273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142411Inst : IEnumerable<long>
{
public static readonly long[] Value=A142411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142411.Bytes);
public long this[int i]=>Value[i];

public static A142411Inst Instance=new A142411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142412
{
public static readonly long[] Value={ 43L,139L,283L,331L,379L,523L,571L,619L,811L,859L,907L,1051L,1291L,1483L,1531L,1579L,1627L,1723L,1867L,2011L,2203L,2251L,2347L,2539L,2683L,2731L,2971L,3019L,3067L,3163L,3259L,3307L,3499L,3547L,3643L,3691L,3739L,3931L,4027L,4219L,4363L,4507L,4603L,4651L,4987L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142412Inst : IEnumerable<long>
{
public static readonly long[] Value=A142412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142412.Bytes);
public long this[int i]=>Value[i];

public static A142412Inst Instance=new A142412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142413
{
public static readonly long[] Value={ 47L,191L,239L,383L,431L,479L,719L,863L,911L,1103L,1151L,1439L,1487L,1583L,1823L,1871L,2063L,2111L,2207L,2351L,2399L,2447L,2543L,2591L,2687L,2879L,2927L,3023L,3119L,3167L,3359L,3407L,4079L,4127L,4271L,4463L,4703L,4751L,4799L,4943L,5039L,5087L,5231L,5279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142413Inst : IEnumerable<long>
{
public static readonly long[] Value=A142413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142413.Bytes);
public long this[int i]=>Value[i];

public static A142413Inst Instance=new A142413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142414
{
public static readonly long[] Value={ 197L,491L,883L,1373L,1471L,1667L,2549L,2647L,2843L,3137L,3529L,3823L,4019L,4999L,5783L,5881L,6469L,6763L,6959L,7057L,7253L,7351L,7547L,7841L,8233L,8429L,8527L,8821L,9311L,10193L,10487L,10781L,11173L,11369L,11467L,12251L,13721L,14407L,14897L,15289L,15583L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142414Inst : IEnumerable<long>
{
public static readonly long[] Value=A142414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142414.Bytes);
public long this[int i]=>Value[i];

public static A142414Inst Instance=new A142414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142415
{
public static readonly long[] Value={ 2L,149L,443L,541L,1031L,1129L,1423L,1619L,1913L,2011L,2207L,3089L,3187L,3677L,4363L,4657L,4951L,5147L,5441L,6029L,6323L,6421L,6911L,7499L,7793L,8087L,8969L,9067L,9851L,9949L,10243L,10733L,10831L,11027L,11321L,11909L,12007L,12203L,12301L,12497L,12791L,12889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142415Inst : IEnumerable<long>
{
public static readonly long[] Value=A142415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142415.Bytes);
public long this[int i]=>Value[i];

public static A142415Inst Instance=new A142415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142416
{
public static readonly long[] Value={ 3L,101L,199L,787L,983L,1277L,1571L,1669L,2551L,3041L,3433L,3727L,3923L,4021L,4217L,4903L,5099L,5197L,5393L,5981L,6079L,6373L,6569L,6863L,6961L,7451L,7549L,8039L,8431L,8627L,9803L,9901L,10391L,10979L,11273L,11959L,12253L,12547L,12743L,12841L,13037L,13331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142416Inst : IEnumerable<long>
{
public static readonly long[] Value=A142416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142416.Bytes);
public long this[int i]=>Value[i];

public static A142416Inst Instance=new A142416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142417
{
public static readonly long[] Value={ 53L,151L,347L,641L,739L,1033L,1229L,1327L,1523L,1621L,2111L,2503L,2699L,2797L,3581L,4463L,4561L,5051L,5443L,5639L,5737L,6521L,6619L,7109L,7207L,8089L,8677L,8971L,9461L,10343L,11519L,11617L,11813L,12107L,12401L,13381L,13577L,14557L,14753L,14851L,15439L,15733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142417Inst : IEnumerable<long>
{
public static readonly long[] Value=A142417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142417.Bytes);
public long this[int i]=>Value[i];

public static A142417Inst Instance=new A142417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142418
{
public static readonly long[] Value={ 5L,103L,397L,593L,691L,887L,1181L,1279L,1867L,2063L,2161L,2357L,2749L,3533L,3631L,4219L,4513L,5003L,5101L,5297L,5591L,5689L,6277L,6473L,6571L,7159L,7649L,8237L,8629L,8923L,9413L,9511L,10099L,10589L,10687L,10883L,11177L,11471L,11863L,12157L,12451L,12647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142418Inst : IEnumerable<long>
{
public static readonly long[] Value=A142418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142418.Bytes);
public long this[int i]=>Value[i];

public static A142418Inst Instance=new A142418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142419
{
public static readonly long[] Value={ 251L,349L,643L,839L,937L,1231L,1427L,1721L,2113L,2309L,2897L,3191L,3583L,3779L,3877L,4073L,4759L,5347L,5641L,6131L,6229L,6719L,7013L,7307L,7699L,7993L,8287L,8581L,9463L,10247L,10639L,11423L,11717L,12011L,12109L,12697L,12893L,13187L,13873L,14461L,14657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142419Inst : IEnumerable<long>
{
public static readonly long[] Value=A142419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142419.Bytes);
public long this[int i]=>Value[i];

public static A142419Inst Instance=new A142419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142420
{
public static readonly long[] Value={ 449L,547L,743L,1429L,1723L,2017L,2213L,2311L,2801L,3389L,4271L,4663L,4957L,5153L,5741L,5839L,6133L,6329L,6427L,6917L,7211L,7309L,7603L,8093L,8191L,8387L,8681L,8779L,9661L,9857L,10151L,10739L,10837L,11131L,11621L,11719L,12503L,12601L,13679L,14071L,14561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142420Inst : IEnumerable<long>
{
public static readonly long[] Value=A142420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142420.Bytes);
public long this[int i]=>Value[i];

public static A142420Inst Instance=new A142420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142421
{
public static readonly long[] Value={ 107L,401L,499L,1087L,1283L,1381L,1871L,2459L,2557L,2753L,2851L,3733L,3929L,4027L,4517L,4909L,5399L,5693L,5791L,5987L,6379L,6673L,6869L,6967L,7457L,8731L,9221L,9319L,9613L,9907L,10103L,10691L,10789L,11083L,11279L,11867L,12161L,12553L,13043L,13337L,13729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142421Inst : IEnumerable<long>
{
public static readonly long[] Value=A142421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142421.Bytes);
public long this[int i]=>Value[i];

public static A142421Inst Instance=new A142421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142422
{
public static readonly long[] Value={ 59L,157L,353L,647L,941L,1039L,1627L,1823L,2411L,2803L,2999L,3391L,3881L,4273L,4567L,4861L,5351L,5449L,5743L,5939L,6037L,7213L,7507L,7703L,8291L,8389L,9173L,9467L,9859L,10937L,11329L,12113L,12211L,12799L,13093L,13681L,13877L,14563L,14759L,15053L,15641L,15739L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142422Inst : IEnumerable<long>
{
public static readonly long[] Value=A142422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142422.Bytes);
public long this[int i]=>Value[i];

public static A142422Inst Instance=new A142422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142423
{
public static readonly long[] Value={ 11L,109L,599L,991L,1187L,1481L,1579L,1873L,2069L,2657L,3049L,3343L,3539L,3637L,3833L,3931L,4127L,4421L,4519L,4813L,5009L,5107L,5303L,6577L,6871L,7459L,7753L,7949L,8243L,8537L,8831L,8929L,9419L,9811L,10007L,10301L,10399L,10889L,10987L,12163L,12457L,12653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142423Inst : IEnumerable<long>
{
public static readonly long[] Value=A142423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142423.Bytes);
public long this[int i]=>Value[i];

public static A142423Inst Instance=new A142423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142456
{
public static readonly long[] Value={ 3L,3L,5L,5L,7L,13L,31L,31L,37L,43L,47L,53L,53L,59L,73L,83L,97L,137L,137L,157L,173L,173L,191L,199L,233L,281L,293L,337L,397L,397L,409L,421L,431L,449L,457L,463L,467L,467L,487L,487L,499L,499L,503L,509L,521L,523L,593L,593L,599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142456Inst : IEnumerable<long>
{
public static readonly long[] Value=A142456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142456.Bytes);
public long this[int i]=>Value[i];

public static A142456Inst Instance=new A142456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142457
{
public static readonly long[] Value={ 0L,0L,2L,0L,6L,5L,0L,1L,8L,10L,0L,9L,4L,7L,7L,0L,8L,4L,10L,4L,8L,0L,9L,8L,8L,9L,0L,3L,0L,1L,5L,1L,0L,2L,7L,4L,0L,6L,6L,0L,10L,3L,1L,4L,1L,0L,2L,0L,5L,6L,3L,7L,7L,3L,6L,0L,0L,9L,5L,10L,2L,3L,2L,10L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142457Inst : IEnumerable<long>
{
public static readonly long[] Value=A142457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142457.Bytes);
public long this[int i]=>Value[i];

public static A142457Inst Instance=new A142457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142458
{
public static readonly long[] Value={ 1L,1L,1L,1L,8L,1L,1L,39L,39L,1L,1L,166L,546L,166L,1L,1L,677L,5482L,5482L,677L,1L,1L,2724L,47175L,109640L,47175L,2724L,1L,1L,10915L,373809L,1709675L,1709675L,373809L,10915L,1L,1L,43682L,2824048L,23077694L,44451550L,23077694L,2824048L,43682L,1L,1L,174753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142458Inst : IEnumerable<long>
{
public static readonly long[] Value=A142458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142458.Bytes);
public long this[int i]=>Value[i];

public static A142458Inst Instance=new A142458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142459
{
public static readonly long[] Value={ 1L,1L,1L,1L,10L,1L,1L,59L,59L,1L,1L,308L,1062L,308L,1L,1L,1557L,13562L,13562L,1557L,1L,1L,7806L,148527L,352612L,148527L,7806L,1L,1L,39055L,1500669L,7108915L,7108915L,1500669L,39055L,1L,1L,195304L,14482396L,123929944L,241703110L,123929944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142459Inst : IEnumerable<long>
{
public static readonly long[] Value=A142459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142459.Bytes);
public long this[int i]=>Value[i];

public static A142459Inst Instance=new A142459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142460
{
public static readonly long[] Value={ 1L,1L,1L,1L,12L,1L,1L,83L,83L,1L,1L,514L,1826L,514L,1L,1L,3105L,28310L,28310L,3105L,1L,1L,18656L,376615L,905920L,376615L,18656L,1L,1L,111967L,4627821L,22403635L,22403635L,4627821L,111967L,1L,1L,671838L,54377008L,478781506L,940952670L,478781506L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142460Inst : IEnumerable<long>
{
public static readonly long[] Value=A142460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142460.Bytes);
public long this[int i]=>Value[i];

public static A142460Inst Instance=new A142460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142461
{
public static readonly long[] Value={ 1L,1L,1L,1L,14L,1L,1L,111L,111L,1L,1L,796L,2886L,796L,1L,1L,5597L,52642L,52642L,5597L,1L,1L,39210L,824271L,2000396L,824271L,39210L,1L,1L,274507L,11931033L,58614299L,58614299L,11931033L,274507L,1L,1L,1921592L,165260188L,1483533704L,2930714950L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142461Inst : IEnumerable<long>
{
public static readonly long[] Value=A142461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142461.Bytes);
public long this[int i]=>Value[i];

public static A142461Inst Instance=new A142461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142462
{
public static readonly long[] Value={ 1L,1L,1L,1L,16L,1L,1L,143L,143L,1L,1L,1166L,4290L,1166L,1L,1L,9357L,90002L,90002L,9357L,1L,1L,74892L,1621383L,3960088L,1621383L,74892L,1L,1L,599179L,27016857L,134142043L,134142043L,27016857L,599179L,1L,1L,4793482L,431017552L,3923731798L,7780238494L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142462Inst : IEnumerable<long>
{
public static readonly long[] Value=A142462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142462.Bytes);
public long this[int i]=>Value[i];

public static A142462Inst Instance=new A142462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142463
{
public static readonly long[] Value={ -1L,3L,11L,23L,39L,59L,83L,111L,143L,179L,219L,263L,311L,363L,419L,479L,543L,611L,683L,759L,839L,923L,1011L,1103L,1199L,1299L,1403L,1511L,1623L,1739L,1859L,1983L,2111L,2243L,2379L,2519L,2663L,2811L,2963L,3119L,3279L,3443L,3611L,3783L,3959L,4139L,4323L,4511L,4703L,4899L,5099L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142463Inst : IEnumerable<long>
{
public static readonly long[] Value=A142463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142463.Bytes);
public long this[int i]=>Value[i];

public static A142463Inst Instance=new A142463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142464
{
public static readonly long[] Value={ 3L,6L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142464Inst : IEnumerable<long>
{
public static readonly long[] Value=A142464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142464.Bytes);
public long this[int i]=>Value[i];

public static A142464Inst Instance=new A142464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142465
{
public static readonly long[] Value={ 1L,1L,1L,1L,7L,1L,1L,28L,28L,1L,1L,84L,336L,84L,1L,1L,210L,2520L,2520L,210L,1L,1L,462L,13860L,41580L,13860L,462L,1L,1L,924L,60984L,457380L,457380L,60984L,924L,1L,1L,1716L,226512L,3737448L,9343620L,3737448L,226512L,1716L,1L,1L,3003L,736164L,24293412L,133613766L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142465Inst : IEnumerable<long>
{
public static readonly long[] Value=A142465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142465.Bytes);
public long this[int i]=>Value[i];

public static A142465Inst Instance=new A142465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142466
{
public static readonly long[] Value={ 127L,227L,277L,577L,677L,727L,827L,877L,977L,1277L,1327L,1427L,1627L,1777L,1877L,2027L,2377L,2477L,2677L,2777L,2927L,3527L,3677L,3727L,3877L,4027L,4127L,4177L,4327L,4877L,5077L,5227L,5477L,5527L,5827L,5927L,6277L,6427L,6577L,6827L,6977L,7027L,7127L,7177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142466Inst : IEnumerable<long>
{
public static readonly long[] Value=A142466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142466.Bytes);
public long this[int i]=>Value[i];

public static A142466Inst Instance=new A142466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142467
{
public static readonly long[] Value={ 1L,1L,1L,1L,8L,1L,1L,36L,36L,1L,1L,120L,540L,120L,1L,1L,330L,4950L,4950L,330L,1L,1L,792L,32670L,108900L,32670L,792L,1L,1L,1716L,169884L,1557270L,1557270L,169884L,1716L,1L,1L,3432L,736164L,16195608L,44537922L,16195608L,736164L,3432L,1L,1L,6435L,2760615L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142467Inst : IEnumerable<long>
{
public static readonly long[] Value=A142467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142467.Bytes);
public long this[int i]=>Value[i];

public static A142467Inst Instance=new A142467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142468
{
public static readonly long[] Value={ 1L,1L,1L,1L,9L,1L,1L,45L,45L,1L,1L,165L,825L,165L,1L,1L,495L,9075L,9075L,495L,1L,1L,1287L,70785L,259545L,70785L,1287L,1L,1L,3003L,429429L,4723719L,4723719L,429429L,3003L,1L,1L,6435L,2147145L,61408347L,184225041L,61408347L,2147145L,6435L,1L,1L,12870L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142468Inst : IEnumerable<long>
{
public static readonly long[] Value=A142468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142468.Bytes);
public long this[int i]=>Value[i];

public static A142468Inst Instance=new A142468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142469
{
public static readonly long[] Value={ 3L,3L,46L,6L,46L,347L,532L,532L,347L,1932L,14505L,740L,14505L,1932L,9199L,203925L,152405L,152405L,203925L,9199L,40250L,2087884L,6882086L,-86372L,6882086L,2087884L,40250L,168318L,17968725L,152844537L,78623775L,78623775L,152844537L,17968725L,168318L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142469Inst : IEnumerable<long>
{
public static readonly long[] Value=A142469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142469.Bytes);
public long this[int i]=>Value[i];

public static A142469Inst Instance=new A142469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142470
{
public static readonly long[] Value={ 1L,1L,1L,1L,8L,1L,1L,30L,30L,1L,1L,80L,300L,80L,1L,1L,175L,1750L,1750L,175L,1L,1L,336L,7350L,19600L,7350L,336L,1L,1L,588L,24696L,144060L,144060L,24696L,588L,1L,1L,960L,70560L,790272L,1728720L,790272L,70560L,960L,1L,1L,1485L,178200L,3492720L,14669424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142470Inst : IEnumerable<long>
{
public static readonly long[] Value=A142470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142470.Bytes);
public long this[int i]=>Value[i];

public static A142470Inst Instance=new A142470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142471
{
public static readonly BigInteger[] Value={ 0L,0L,2L,2L,6L,14L,86L,1206L,103718L,125083910L,12973452977382L,BigInteger.Parse("1622770224612082123622"),BigInteger.Parse("21052933202100473722674133293917606"),BigInteger.Parse("34164073141115747076263787631563122725393126176374288934") };
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
public class A142471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142471Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A142471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142471.Bytes);
public BigInteger this[int i]=>Value[i];

public static A142471Inst Instance=new A142471Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142520
{
public static readonly long[] Value={ 79L,131L,443L,547L,599L,859L,911L,1171L,1223L,1327L,1483L,1847L,1951L,2003L,2731L,2887L,2939L,3251L,3407L,3511L,3719L,3823L,4447L,4603L,4759L,4967L,5227L,5279L,5591L,5851L,5903L,6007L,6163L,7151L,7307L,7411L,7723L,7879L,8087L,8191L,8243L,8867L,8971L,9127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142520Inst : IEnumerable<long>
{
public static readonly long[] Value=A142520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142520.Bytes);
public long this[int i]=>Value[i];

public static A142520Inst Instance=new A142520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142521
{
public static readonly long[] Value={ 29L,601L,653L,757L,809L,1069L,1277L,1381L,1433L,1693L,1901L,2161L,2213L,2473L,2837L,3253L,3461L,3617L,3877L,3929L,4241L,4397L,4657L,4813L,4969L,5021L,5281L,5333L,5437L,5749L,5801L,6113L,6217L,6269L,6373L,6529L,6581L,6737L,6841L,6997L,7309L,7517L,7621L,7673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142521Inst : IEnumerable<long>
{
public static readonly long[] Value=A142521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142521.Bytes);
public long this[int i]=>Value[i];

public static A142521Inst Instance=new A142521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142522
{
public static readonly long[] Value={ 31L,83L,239L,499L,811L,863L,967L,1019L,1123L,1279L,1487L,1747L,2111L,2267L,2371L,2423L,2579L,2683L,3203L,3307L,3359L,3463L,3671L,3931L,4139L,4243L,4451L,4919L,5023L,5179L,5231L,5387L,5647L,6011L,6271L,6323L,6427L,6791L,6947L,7103L,7207L,7727L,7883L,8039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142522Inst : IEnumerable<long>
{
public static readonly long[] Value=A142522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142522.Bytes);
public long this[int i]=>Value[i];

public static A142522Inst Instance=new A142522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142523
{
public static readonly long[] Value={ 137L,241L,293L,397L,449L,709L,761L,1021L,1229L,1489L,1697L,1801L,2113L,2269L,2477L,2633L,2789L,3049L,3257L,3361L,3413L,3517L,3673L,3881L,4297L,4349L,4817L,4973L,5077L,5233L,5441L,5701L,5857L,6221L,6481L,6637L,6689L,6793L,6949L,7001L,7417L,7573L,7937L,8093L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142523Inst : IEnumerable<long>
{
public static readonly long[] Value=A142523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142523.Bytes);
public long this[int i]=>Value[i];

public static A142523Inst Instance=new A142523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142524
{
public static readonly long[] Value={ 139L,191L,347L,503L,607L,659L,919L,971L,1231L,1283L,1439L,1543L,1699L,1907L,2011L,2063L,2531L,2687L,2791L,2843L,2999L,3259L,3467L,3571L,3623L,3727L,3779L,4091L,4507L,4663L,4871L,5443L,5651L,5807L,6067L,6379L,6691L,6899L,7159L,7211L,7523L,8147L,8563L,8719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142524Inst : IEnumerable<long>
{
public static readonly long[] Value=A142524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142524.Bytes);
public long this[int i]=>Value[i];

public static A142524Inst Instance=new A142524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142525
{
public static readonly long[] Value={ 37L,89L,193L,349L,401L,557L,661L,1129L,1181L,1493L,1597L,1753L,2221L,2273L,2377L,2689L,2741L,2897L,3001L,3209L,3313L,3469L,3677L,3833L,3989L,4093L,4457L,4561L,5081L,5237L,5393L,5653L,5861L,6121L,6173L,6277L,6329L,7057L,7109L,7213L,7369L,7577L,7681L,7993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142525Inst : IEnumerable<long>
{
public static readonly long[] Value=A142525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142525.Bytes);
public long this[int i]=>Value[i];

public static A142525Inst Instance=new A142525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142526
{
public static readonly long[] Value={ 41L,197L,353L,457L,509L,613L,769L,821L,977L,1237L,1289L,1549L,1601L,1861L,1913L,2017L,2069L,2381L,2693L,2797L,2953L,3109L,3733L,3889L,4201L,4253L,4357L,4409L,4513L,4721L,4877L,5189L,5449L,5501L,5657L,5813L,6073L,6229L,7321L,7477L,7529L,7789L,7841L,8101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142526Inst : IEnumerable<long>
{
public static readonly long[] Value=A142526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142526.Bytes);
public long this[int i]=>Value[i];

public static A142526Inst Instance=new A142526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142527
{
public static readonly long[] Value={ 43L,199L,251L,563L,719L,823L,1031L,1187L,1291L,1447L,1499L,1759L,1811L,2383L,2539L,2591L,2851L,2903L,3163L,3319L,3371L,3527L,3631L,3943L,4099L,4463L,4567L,4723L,4931L,5087L,5347L,5399L,5503L,5659L,5711L,5867L,6491L,6803L,6907L,6959L,7219L,7583L,7687L,8311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142527Inst : IEnumerable<long>
{
public static readonly long[] Value=A142527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142527.Bytes);
public long this[int i]=>Value[i];

public static A142527Inst Instance=new A142527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142528
{
public static readonly long[] Value={ 97L,149L,409L,461L,617L,773L,877L,929L,1033L,1553L,1657L,1709L,2281L,2333L,2437L,2593L,2749L,2801L,2957L,3061L,3217L,3373L,3529L,3581L,4049L,4153L,4517L,4621L,4673L,4933L,5297L,5557L,5869L,6337L,6389L,6701L,6857L,6961L,7013L,7481L,7741L,7793L,7949L,8053L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142528Inst : IEnumerable<long>
{
public static readonly long[] Value=A142528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142528.Bytes);
public long this[int i]=>Value[i];

public static A142528Inst Instance=new A142528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142529
{
public static readonly long[] Value={ 47L,151L,307L,359L,463L,619L,827L,983L,1087L,1399L,1451L,1607L,1867L,2179L,2543L,2647L,2699L,2803L,3011L,3167L,3271L,3323L,3583L,3739L,3947L,4051L,4259L,4363L,4519L,4831L,4987L,5039L,5351L,5507L,5923L,6079L,6131L,6287L,6547L,6599L,6703L,6911L,7639L,7691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142529Inst : IEnumerable<long>
{
public static readonly long[] Value=A142529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142529.Bytes);
public long this[int i]=>Value[i];

public static A142529Inst Instance=new A142529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142530
{
public static readonly long[] Value={ 101L,257L,569L,673L,829L,881L,1193L,1297L,1453L,1609L,1973L,2129L,2389L,2441L,2753L,2857L,2909L,3169L,3221L,3533L,3637L,3793L,4001L,4157L,4261L,4729L,4937L,5197L,5717L,5821L,6029L,6133L,6653L,7069L,7121L,7433L,7537L,7589L,7901L,8161L,8317L,8369L,8629L,8681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142530Inst : IEnumerable<long>
{
public static readonly long[] Value=A142530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142530.Bytes);
public long this[int i]=>Value[i];

public static A142530Inst Instance=new A142530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142531
{
public static readonly long[] Value={ 103L,311L,467L,571L,727L,883L,1039L,1091L,1559L,1663L,1871L,2027L,2131L,2287L,2339L,2963L,3067L,3119L,3691L,3847L,4003L,4159L,4211L,4523L,4679L,4783L,5147L,5303L,5407L,5563L,5927L,6343L,6551L,6863L,6967L,7019L,7331L,7487L,7591L,7643L,8059L,8111L,8423L,8527L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142531Inst : IEnumerable<long>
{
public static readonly long[] Value=A142531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142531.Bytes);
public long this[int i]=>Value[i];

public static A142531Inst Instance=new A142531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142532
{
public static readonly long[] Value={ 2L,373L,479L,691L,797L,1009L,1327L,1433L,2069L,2281L,2917L,3023L,3659L,4507L,4931L,5779L,6203L,6521L,6733L,7369L,7687L,7793L,8111L,8429L,8641L,8747L,9277L,10337L,10867L,10973L,11503L,11821L,11927L,12457L,13093L,13411L,13729L,14153L,14683L,15107L,15319L,16061L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142532Inst : IEnumerable<long>
{
public static readonly long[] Value=A142532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142532.Bytes);
public long this[int i]=>Value[i];

public static A142532Inst Instance=new A142532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142533
{
public static readonly long[] Value={ 3L,109L,1063L,1381L,1487L,1699L,2017L,2441L,2971L,3607L,4243L,4349L,4561L,5197L,5303L,5939L,6151L,6257L,6469L,7211L,7529L,7741L,8059L,8377L,9013L,9437L,9649L,9967L,10391L,10709L,11027L,11239L,11981L,12511L,12829L,13147L,14207L,14419L,14737L,14843L,15161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142533Inst : IEnumerable<long>
{
public static readonly long[] Value=A142533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142533.Bytes);
public long this[int i]=>Value[i];

public static A142533Inst Instance=new A142533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142534
{
public static readonly long[] Value={ 163L,269L,587L,1117L,1223L,1753L,2389L,2707L,3343L,3449L,3767L,4297L,4721L,4933L,5039L,5569L,6311L,6841L,6947L,7159L,7477L,7583L,7901L,8219L,8431L,8537L,9067L,9173L,9491L,10657L,11399L,11717L,12671L,14897L,15427L,16063L,16381L,16487L,16699L,17123L,17971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142534Inst : IEnumerable<long>
{
public static readonly long[] Value=A142534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142534.Bytes);
public long this[int i]=>Value[i];

public static A142534Inst Instance=new A142534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142535
{
public static readonly long[] Value={ 5L,641L,853L,1171L,1277L,1489L,1913L,2549L,3079L,3821L,4139L,4457L,4987L,5623L,6047L,6577L,7001L,7213L,8167L,8273L,8803L,9227L,9439L,10181L,10499L,10711L,12301L,12619L,13043L,13679L,13997L,14633L,14951L,15269L,16223L,17389L,17707L,18131L,18661L,18979L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142535Inst : IEnumerable<long>
{
public static readonly long[] Value=A142535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142535.Bytes);
public long this[int i]=>Value[i];

public static A142535Inst Instance=new A142535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142552
{
public static readonly long[] Value={ 181L,499L,1453L,1559L,1877L,2089L,3361L,3467L,4421L,4951L,5693L,6011L,6329L,7177L,7283L,7919L,8237L,9403L,9721L,10039L,10357L,10463L,10781L,10993L,11311L,12583L,12689L,13007L,13219L,13537L,14173L,15233L,15551L,16187L,16823L,17989L,18307L,18413L,18731L,20533L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142552Inst : IEnumerable<long>
{
public static readonly long[] Value=A142552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142552.Bytes);
public long this[int i]=>Value[i];

public static A142552Inst Instance=new A142552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142553
{
public static readonly long[] Value={ 23L,659L,977L,1613L,1931L,2143L,3203L,3733L,4051L,4157L,4793L,5323L,5641L,6277L,6701L,7019L,7549L,7867L,8291L,8609L,8821L,10093L,10729L,11047L,11471L,11789L,12107L,12637L,12743L,13591L,13697L,14969L,15287L,15817L,15923L,16453L,18043L,18149L,18679L,19421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142553Inst : IEnumerable<long>
{
public static readonly long[] Value=A142553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142553.Bytes);
public long this[int i]=>Value[i];

public static A142553Inst Instance=new A142553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142554
{
public static readonly long[] Value={ 607L,1031L,1667L,1879L,2621L,2833L,2939L,3257L,3469L,4211L,4423L,5059L,5483L,5801L,6967L,7603L,8663L,9511L,9829L,10253L,10889L,12161L,12373L,12479L,13009L,13327L,13751L,13963L,14281L,14387L,16189L,16931L,18097L,18521L,18839L,19051L,19157L,19687L,19793L,20323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142554Inst : IEnumerable<long>
{
public static readonly long[] Value=A142554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142554.Bytes);
public long this[int i]=>Value[i];

public static A142554Inst Instance=new A142554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142555
{
public static readonly long[] Value={ 131L,449L,661L,1297L,1721L,1933L,2039L,2251L,2357L,2887L,3947L,4159L,4583L,5113L,5431L,5749L,6067L,6173L,6491L,6703L,7127L,8081L,8293L,8929L,9883L,10837L,11261L,11579L,11897L,12109L,13063L,13381L,13487L,14653L,14759L,15077L,15289L,15607L,16349L,16561L,16879L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142555Inst : IEnumerable<long>
{
public static readonly long[] Value=A142555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142555.Bytes);
public long this[int i]=>Value[i];

public static A142555Inst Instance=new A142555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142556
{
public static readonly long[] Value={ 79L,397L,503L,821L,1033L,1669L,1987L,2411L,2729L,3259L,4001L,4637L,5167L,5273L,5591L,6121L,6863L,7393L,7499L,7817L,9619L,10891L,11527L,11633L,12163L,12269L,12799L,13859L,14071L,14177L,14389L,14813L,15131L,15661L,15767L,17569L,18311L,18523L,18947L,19477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142556Inst : IEnumerable<long>
{
public static readonly long[] Value=A142556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142556.Bytes);
public long this[int i]=>Value[i];

public static A142556Inst Instance=new A142556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142557
{
public static readonly long[] Value={ 239L,557L,769L,1087L,1193L,1511L,1723L,2677L,3313L,3631L,4373L,4691L,4903L,5009L,5857L,6599L,6917L,7129L,8719L,9461L,10627L,10733L,11369L,12323L,12641L,12853L,12959L,13171L,13807L,13913L,14549L,14867L,16033L,16139L,16987L,17093L,17623L,17729L,18047L,19001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142557Inst : IEnumerable<long>
{
public static readonly long[] Value=A142557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142557.Bytes);
public long this[int i]=>Value[i];

public static A142557Inst Instance=new A142557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142558
{
public static readonly long[] Value={ 293L,823L,929L,1459L,1777L,2731L,2837L,3049L,4003L,4639L,4957L,5381L,6229L,6547L,6653L,6971L,7607L,8243L,9091L,9833L,10151L,11317L,11423L,11953L,12377L,12589L,12907L,13331L,13649L,13967L,15451L,16087L,16193L,16829L,17041L,17359L,17783L,18313L,19267L,19373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142558Inst : IEnumerable<long>
{
public static readonly long[] Value=A142558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142558.Bytes);
public long this[int i]=>Value[i];

public static A142558Inst Instance=new A142558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142559
{
public static readonly long[] Value={ 29L,241L,347L,877L,983L,1301L,1619L,1831L,2467L,3209L,3527L,3739L,4057L,4481L,4799L,5011L,5647L,6389L,7237L,7873L,8191L,8297L,8933L,9463L,9781L,9887L,10099L,11159L,11689L,12007L,12113L,13597L,14551L,14657L,14869L,15187L,15823L,16141L,16883L,17519L,17837L,18049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142559Inst : IEnumerable<long>
{
public static readonly long[] Value=A142559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142559.Bytes);
public long this[int i]=>Value[i];

public static A142559Inst Instance=new A142559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142560
{
public static readonly long[] Value={ 83L,401L,613L,719L,1249L,1567L,2203L,2309L,2521L,3581L,3793L,4111L,4217L,5171L,5701L,5807L,6337L,6761L,7079L,7927L,8563L,8669L,9199L,9623L,9941L,10259L,10789L,11213L,11743L,12379L,12697L,13121L,13757L,14923L,15241L,15559L,15877L,16301L,16619L,16831L,16937L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142560Inst : IEnumerable<long>
{
public static readonly long[] Value=A142560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142560.Bytes);
public long this[int i]=>Value[i];

public static A142560Inst Instance=new A142560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142561
{
public static readonly long[] Value={ 31L,137L,349L,773L,1091L,1303L,1409L,1621L,2999L,3529L,3847L,4271L,4483L,4801L,5119L,5437L,5861L,6073L,6709L,7027L,7451L,8087L,9041L,9677L,10313L,10631L,10949L,11161L,11903L,12433L,12539L,14341L,14447L,15083L,15401L,16249L,16567L,16673L,17203L,17627L,17839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142561Inst : IEnumerable<long>
{
public static readonly long[] Value=A142561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142561.Bytes);
public long this[int i]=>Value[i];

public static A142561Inst Instance=new A142561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142562
{
public static readonly long[] Value={ 191L,509L,827L,1039L,1993L,2099L,2311L,2417L,3371L,3583L,4007L,4219L,4643L,5279L,6551L,6763L,6869L,7187L,7717L,7823L,8353L,9413L,11003L,11321L,12487L,12911L,13229L,13441L,13759L,14713L,15031L,15137L,15349L,15667L,15773L,16091L,17257L,17681L,18211L,19483L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142562Inst : IEnumerable<long>
{
public static readonly long[] Value=A142562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142562.Bytes);
public long this[int i]=>Value[i];

public static A142562Inst Instance=new A142562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142563
{
public static readonly long[] Value={ 139L,457L,563L,881L,1093L,2153L,2683L,2789L,3001L,3319L,3637L,4273L,4591L,4909L,5227L,5333L,5651L,6287L,7559L,7877L,8089L,8513L,8831L,9043L,9467L,9679L,10103L,10739L,11057L,11587L,12011L,12329L,12541L,12647L,13177L,14449L,14767L,16993L,17099L,17417L,18371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142563Inst : IEnumerable<long>
{
public static readonly long[] Value=A142563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142563.Bytes);
public long this[int i]=>Value[i];

public static A142563Inst Instance=new A142563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142564
{
public static readonly long[] Value={ 193L,617L,829L,1571L,1783L,1889L,2207L,2843L,3373L,3691L,3797L,4327L,4751L,5281L,5387L,6553L,6659L,6871L,6977L,7507L,8461L,8779L,9203L,9521L,9733L,9839L,10369L,10687L,11959L,12277L,13337L,14503L,14821L,15139L,15881L,16411L,16729L,17047L,17471L,17683L,17789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142564Inst : IEnumerable<long>
{
public static readonly long[] Value=A142564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142564.Bytes);
public long this[int i]=>Value[i];

public static A142564Inst Instance=new A142564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142565
{
public static readonly long[] Value={ 353L,883L,1201L,1307L,2473L,2579L,2791L,2897L,3109L,3533L,3851L,5441L,5653L,6607L,7243L,7349L,7561L,7879L,9151L,9257L,9787L,10211L,10529L,10847L,11059L,11483L,11801L,12119L,12437L,12967L,13709L,13921L,14557L,15193L,15299L,15511L,16253L,16889L,17207L,17419L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142565Inst : IEnumerable<long>
{
public static readonly long[] Value=A142565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142565.Bytes);
public long this[int i]=>Value[i];

public static A142565Inst Instance=new A142565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142566
{
public static readonly long[] Value={ 89L,619L,937L,1361L,1997L,2633L,3163L,5813L,6131L,6343L,6449L,6661L,7297L,7933L,8039L,8887L,9311L,9629L,10159L,10477L,11113L,12491L,12703L,12809L,13127L,13339L,13763L,14081L,14293L,14717L,14929L,15671L,16519L,16943L,17579L,17791L,18427L,19381L,19699L,20123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142566Inst : IEnumerable<long>
{
public static readonly long[] Value=A142566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142566.Bytes);
public long this[int i]=>Value[i];

public static A142566Inst Instance=new A142566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142567
{
public static readonly long[] Value={ 37L,461L,673L,991L,1097L,1627L,1733L,2687L,3217L,3323L,3853L,5231L,5443L,5867L,6079L,6397L,7351L,7457L,7669L,8093L,8623L,8941L,10531L,11273L,11909L,12227L,12757L,13499L,13711L,14029L,14347L,14771L,14983L,15619L,15937L,16361L,16573L,17209L,18269L,18481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142567Inst : IEnumerable<long>
{
public static readonly long[] Value=A142567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142567.Bytes);
public long this[int i]=>Value[i];

public static A142567Inst Instance=new A142567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142584
{
public static readonly long[] Value={ 2L,4L,6L,10L,18L,28L,46L,76L,122L,198L,322L,520L,842L,1364L,2206L,3570L,5778L,9348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142584Inst : IEnumerable<long>
{
public static readonly long[] Value=A142584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142584.Bytes);
public long this[int i]=>Value[i];

public static A142584Inst Instance=new A142584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142585
{
public static readonly long[] Value={ 1L,0L,1L,0L,-1L,5L,-14L,35L,-81L,180L,-389L,825L,-1726L,3575L,-7349L,15020L,-30561L,61965L,-125294L,252795L,-509161L,1024100L,-2057549L,4130225L,-8284926L,16609455L,-33282989L,66669660L,-133507081L,267285605L,-535010414L,1070731475L,-2142612801L,4287086100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142585Inst : IEnumerable<long>
{
public static readonly long[] Value=A142585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142585.Bytes);
public long this[int i]=>Value[i];

public static A142585Inst Instance=new A142585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142586
{
public static readonly long[] Value={ 1L,2L,5L,14L,39L,107L,290L,779L,2079L,5522L,14615L,38579L,101634L,267347L,702455L,1844114L,4838079L,12686507L,33254210L,87141659L,228301839L,598026002L,1566300455L,4101923939L,10741568514L,28126975907L,73647747815L,192833044754L,504884940879L,1321888886747L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142586Inst : IEnumerable<long>
{
public static readonly long[] Value=A142586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142586.Bytes);
public long this[int i]=>Value[i];

public static A142586Inst Instance=new A142586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142587
{
public static readonly long[] Value={ 33603L,55377L,70999L,78571L,97779L,131673L,139579L,236761L,252391L,282097L,333811L,342037L,355651L,359931L,425427L,436363L,444129L,473143L,479859L,484423L,515787L,543447L,680979L,684273L,709053L,709431L,780199L,781891L,788527L,813019L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142587Inst : IEnumerable<long>
{
public static readonly long[] Value=A142587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142587.Bytes);
public long this[int i]=>Value[i];

public static A142587Inst Instance=new A142587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142588
{
public static readonly BigInteger[] Value={ 0L,5L,70L,985L,13860L,195025L,2744210L,38613965L,543339720L,7645370045L,107578520350L,1513744654945L,21300003689580L,299713796309065L,4217293152016490L,59341817924539925L,835002744095575440L,11749380235262596085UL,BigInteger.Parse("165326326037771920630"),BigInteger.Parse("2326317944764069484905") };
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
public class A142588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142588Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A142588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142588.Bytes);
public BigInteger this[int i]=>Value[i];

public static A142588Inst Instance=new A142588Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142589
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,6L,3L,1L,1L,24L,15L,4L,1L,1L,120L,105L,28L,5L,1L,1L,720L,945L,280L,45L,6L,1L,1L,5040L,10395L,3640L,585L,66L,7L,1L,1L,40320L,135135L,58240L,9945L,1056L,91L,8L,1L,1L,362880L,2027025L,1106560L,208845L,22176L,1729L,120L,9L,1L,1L,3628800L,34459425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142589Inst : IEnumerable<long>
{
public static readonly long[] Value=A142589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142589.Bytes);
public long this[int i]=>Value[i];

public static A142589Inst Instance=new A142589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142590
{
public static readonly long[] Value={ 0L,21L,15L,117L,12L,285L,99L,525L,42L,837L,255L,1221L,90L,1677L,483L,2205L,156L,2805L,783L,3477L,240L,4221L,1155L,5037L,342L,5925L,1599L,6885L,462L,7917L,2115L,9021L,600L,10197L,2703L,11445L,756L,12765L,3363L,14157L,930L,15621L,4095L,17157L,1122L,18765L,4899L,20445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142590Inst : IEnumerable<long>
{
public static readonly long[] Value=A142590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142590.Bytes);
public long this[int i]=>Value[i];

public static A142590Inst Instance=new A142590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142591
{
public static readonly long[] Value={ 15L,35L,95L,119L,143L,209L,287L,319L,323L,377L,527L,559L,779L,899L,923L,989L,1007L,1189L,1199L,1343L,1349L,1763L,1919L,2159L,2507L,2759L,2911L,3239L,3599L,3827L,4031L,4607L,5183L,5207L,5249L,5459L,5543L,6439L,6887L,7067L,7279L,7739L,8159L,8639L,9179L,9593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142591Inst : IEnumerable<long>
{
public static readonly long[] Value=A142591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142591.Bytes);
public long this[int i]=>Value[i];

public static A142591Inst Instance=new A142591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142592
{
public static readonly long[] Value={ 29L,83L,137L,191L,353L,461L,569L,677L,839L,947L,1109L,1163L,1217L,1433L,1487L,1811L,1973L,2027L,2081L,2243L,2297L,2351L,2459L,2621L,2729L,2837L,2999L,3323L,3539L,3593L,3701L,3863L,3917L,4079L,4133L,4241L,4349L,4457L,4673L,4889L,4943L,5051L,5483L,5591L,5807L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142592Inst : IEnumerable<long>
{
public static readonly long[] Value=A142592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142592.Bytes);
public long this[int i]=>Value[i];

public static A142592Inst Instance=new A142592Inst();

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