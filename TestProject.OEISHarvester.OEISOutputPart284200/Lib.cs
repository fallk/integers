using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A142215
{
public static readonly long[] Value={ 59L,223L,797L,1289L,1453L,1699L,2027L,2273L,2437L,2683L,3011L,3257L,4159L,4241L,4651L,4733L,5471L,5717L,5881L,6373L,6619L,6701L,6947L,7193L,7603L,8423L,8669L,9161L,9817L,10391L,10883L,11047L,11621L,11867L,12113L,12277L,13999L,14081L,14327L,14737L,14983L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142215Inst : IEnumerable<long>
{
public static readonly long[] Value=A142215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142215.Bytes);
public long this[int i]=>Value[i];

public static A142215Inst Instance=new A142215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142376
{
public static readonly long[] Value={ 307L,401L,683L,1153L,1811L,1999L,2281L,2657L,2939L,3221L,3691L,4349L,5101L,5477L,6229L,6323L,6793L,7451L,7639L,8297L,8861L,9049L,9613L,10177L,10271L,10459L,11117L,11399L,11587L,11681L,12433L,12527L,12809L,14407L,14783L,15629L,15817L,16193L,16381L,17321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142376Inst : IEnumerable<long>
{
public static readonly long[] Value=A142376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142376.Bytes);
public long this[int i]=>Value[i];

public static A142376Inst Instance=new A142376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142377
{
public static readonly long[] Value={ 73L,167L,449L,919L,1013L,1201L,1483L,2141L,2423L,3457L,3739L,3833L,4021L,4397L,4679L,5431L,5807L,6089L,6277L,6653L,6841L,7499L,7687L,8627L,9473L,9661L,10037L,10601L,10789L,10883L,11071L,11353L,11447L,12011L,12763L,13327L,13421L,14173L,14549L,14737L,14831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142377Inst : IEnumerable<long>
{
public static readonly long[] Value=A142377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142377.Bytes);
public long this[int i]=>Value[i];

public static A142377Inst Instance=new A142377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142378
{
public static readonly long[] Value={ 967L,1061L,1249L,1531L,1907L,2377L,2659L,2753L,3881L,5009L,5197L,5479L,5573L,6043L,6607L,6701L,6983L,7547L,7829L,8017L,8111L,8581L,8863L,9239L,9521L,9803L,10273L,10837L,11119L,11213L,11777L,13093L,13187L,13469L,13751L,14033L,14221L,14503L,14879L,15161L,15349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142378Inst : IEnumerable<long>
{
public static readonly long[] Value=A142378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142378.Bytes);
public long this[int i]=>Value[i];

public static A142378Inst Instance=new A142378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142379
{
public static readonly long[] Value={ 263L,733L,827L,1109L,1297L,1579L,1861L,2143L,2237L,2707L,2801L,3083L,3271L,3929L,4211L,4493L,5527L,5903L,6091L,6373L,7219L,7877L,8629L,9851L,10039L,10133L,10321L,10979L,11261L,11731L,12107L,12577L,12671L,12953L,13799L,14081L,14551L,15679L,15773L,16619L,16901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142379Inst : IEnumerable<long>
{
public static readonly long[] Value=A142379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142379.Bytes);
public long this[int i]=>Value[i];

public static A142379Inst Instance=new A142379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142380
{
public static readonly long[] Value={ 29L,311L,499L,593L,1063L,1439L,1627L,1721L,2003L,2473L,3037L,3319L,3413L,4259L,4447L,4729L,5011L,5387L,5669L,5857L,6421L,6703L,7079L,7549L,7643L,8677L,9241L,10181L,10369L,10463L,10651L,11027L,11497L,11779L,12343L,12437L,12907L,13001L,14411L,15727L,16103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142380Inst : IEnumerable<long>
{
public static readonly long[] Value=A142380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142380.Bytes);
public long this[int i]=>Value[i];

public static A142380Inst Instance=new A142380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142381
{
public static readonly long[] Value={ 359L,547L,641L,829L,1487L,2239L,2333L,2521L,2803L,2897L,3461L,3931L,4871L,5059L,5153L,5623L,5717L,6469L,6563L,7127L,7691L,7879L,8161L,8443L,8537L,8819L,9007L,11827L,12109L,12203L,12391L,13049L,13331L,13613L,14083L,14177L,14741L,14929L,15493L,16057L,16339L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142381Inst : IEnumerable<long>
{
public static readonly long[] Value=A142381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142381.Bytes);
public long this[int i]=>Value[i];

public static A142381Inst Instance=new A142381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142382
{
public static readonly long[] Value={ 31L,313L,877L,971L,1723L,2099L,2287L,2381L,2663L,2851L,3697L,4073L,4261L,4637L,4919L,5107L,5483L,5953L,6047L,6329L,7457L,7927L,8209L,8867L,9337L,9431L,9619L,9901L,10559L,11311L,11593L,11969L,12157L,12251L,12721L,13003L,13567L,15259L,15541L,15823L,16481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142382Inst : IEnumerable<long>
{
public static readonly long[] Value=A142382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142382.Bytes);
public long this[int i]=>Value[i];

public static A142382Inst Instance=new A142382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142383
{
public static readonly long[] Value={ 79L,173L,643L,1019L,1301L,1489L,1583L,2053L,2617L,2711L,3181L,3463L,3557L,4027L,4591L,4967L,5437L,5531L,5813L,6659L,7129L,7411L,8069L,8539L,8821L,9103L,9479L,9949L,10513L,10607L,10889L,11171L,11923L,12487L,13709L,14461L,15307L,15401L,15683L,16529L,16811L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142383Inst : IEnumerable<long>
{
public static readonly long[] Value=A142383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142383.Bytes);
public long this[int i]=>Value[i];

public static A142383Inst Instance=new A142383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142384
{
public static readonly long[] Value={ 127L,409L,503L,691L,1913L,2383L,2477L,3041L,3229L,3323L,3511L,3793L,4357L,4451L,4639L,4733L,5297L,5861L,6143L,7177L,7459L,7741L,8117L,8681L,8963L,9151L,9433L,10091L,10937L,11689L,11783L,11971L,12253L,12347L,12911L,13099L,13381L,13757L,14321L,15073L,15731L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142384Inst : IEnumerable<long>
{
public static readonly long[] Value=A142384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142384.Bytes);
public long this[int i]=>Value[i];

public static A142384Inst Instance=new A142384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142385
{
public static readonly long[] Value={ 269L,457L,739L,1021L,1303L,1867L,2243L,2713L,3089L,3371L,3559L,4217L,4969L,6379L,6473L,6661L,7507L,7789L,7883L,8353L,8447L,9011L,9199L,9293L,9857L,10139L,10891L,11173L,11549L,11831L,12113L,12301L,12583L,12959L,13147L,13241L,13523L,13711L,14087L,14369L,14557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142385Inst : IEnumerable<long>
{
public static readonly long[] Value=A142385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142385.Bytes);
public long this[int i]=>Value[i];

public static A142385Inst Instance=new A142385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142386
{
public static readonly long[] Value={ 223L,317L,599L,787L,881L,1069L,1163L,3137L,3607L,3701L,3889L,4547L,5393L,5581L,6427L,6521L,6709L,6803L,6991L,7649L,9059L,9341L,9623L,9811L,10093L,10657L,10939L,11503L,11597L,12161L,13007L,13477L,13759L,14323L,14699L,14887L,15263L,15451L,15733L,16673L,17519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142386Inst : IEnumerable<long>
{
public static readonly long[] Value=A142386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142386.Bytes);
public long this[int i]=>Value[i];

public static A142386Inst Instance=new A142386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142387
{
public static readonly long[] Value={ 83L,271L,647L,929L,1117L,1399L,1493L,2339L,2621L,2903L,3373L,3467L,4219L,4783L,4877L,5347L,5441L,6287L,6569L,7039L,7321L,7603L,8167L,8543L,8731L,9013L,9859L,10141L,10799L,10987L,11551L,11833L,11927L,12491L,13337L,13619L,13807L,13901L,14653L,14747L,15217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142387Inst : IEnumerable<long>
{
public static readonly long[] Value=A142387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142387.Bytes);
public long this[int i]=>Value[i];

public static A142387Inst Instance=new A142387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142388
{
public static readonly long[] Value={ 37L,131L,601L,883L,977L,1259L,1447L,1823L,2011L,2293L,2857L,3797L,4079L,4549L,4643L,4831L,5113L,6053L,6899L,7369L,7933L,8779L,9343L,9437L,9719L,9907L,10753L,10847L,11317L,11411L,12163L,12539L,12821L,13009L,13103L,13291L,14419L,14983L,15077L,15359L,15641L,15923L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142388Inst : IEnumerable<long>
{
public static readonly long[] Value=A142388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142388.Bytes);
public long this[int i]=>Value[i];

public static A142388Inst Instance=new A142388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142389
{
public static readonly long[] Value={ 179L,367L,461L,743L,1213L,1307L,1777L,1871L,2153L,2341L,2999L,3187L,3469L,4127L,4409L,4597L,4691L,4973L,5443L,6007L,6101L,6571L,6947L,7229L,7417L,7699L,7793L,8263L,9109L,9203L,9391L,9767L,10331L,10613L,11083L,11177L,12211L,13151L,13339L,13903L,13997L,14561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142389Inst : IEnumerable<long>
{
public static readonly long[] Value=A142389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142389.Bytes);
public long this[int i]=>Value[i];

public static A142389Inst Instance=new A142389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142390
{
public static readonly long[] Value={ 227L,509L,1543L,1637L,2389L,2671L,2953L,3329L,3517L,4363L,4457L,5021L,5209L,5303L,5867L,6337L,6619L,7559L,7841L,8123L,8311L,8969L,9157L,9439L,9533L,9721L,10567L,11131L,11789L,12071L,12541L,12823L,12917L,13669L,13763L,14327L,14797L,14891L,15173L,15361L,15643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142390Inst : IEnumerable<long>
{
public static readonly long[] Value=A142390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142390.Bytes);
public long this[int i]=>Value[i];

public static A142390Inst Instance=new A142390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142391
{
public static readonly long[] Value={ 181L,463L,557L,839L,1873L,2437L,2531L,2719L,3001L,3659L,3847L,4129L,4787L,5351L,5821L,6197L,6761L,6949L,7043L,7607L,8171L,8641L,8923L,9769L,10333L,10427L,10709L,11273L,11743L,12119L,12401L,12589L,13999L,14281L,14563L,14657L,14939L,15973L,16067L,16349L,16631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142391Inst : IEnumerable<long>
{
public static readonly long[] Value=A142391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142391.Bytes);
public long this[int i]=>Value[i];

public static A142391Inst Instance=new A142391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142440
{
public static readonly long[] Value={ 31L,227L,521L,619L,1109L,1697L,2089L,2383L,2579L,2677L,2971L,3167L,3461L,3559L,3853L,4049L,4441L,4637L,4931L,5323L,5519L,5813L,6793L,7283L,7577L,8263L,8753L,9341L,9439L,9733L,9929L,10223L,10321L,10909L,11399L,11497L,11987L,12281L,12379L,12967L,13163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142440Inst : IEnumerable<long>
{
public static readonly long[] Value=A142440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142440.Bytes);
public long this[int i]=>Value[i];

public static A142440Inst Instance=new A142440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142441
{
public static readonly long[] Value={ 179L,277L,571L,1061L,1453L,1747L,2237L,2531L,3119L,3217L,3413L,3511L,4001L,4099L,5471L,5569L,6353L,6451L,7039L,7333L,7529L,7823L,8117L,8803L,8999L,9293L,9391L,9587L,10273L,10567L,10861L,11057L,11351L,11743L,11939L,12037L,12527L,12821L,12919L,13997L,14389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142441Inst : IEnumerable<long>
{
public static readonly long[] Value=A142441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142441.Bytes);
public long this[int i]=>Value[i];

public static A142441Inst Instance=new A142441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142442
{
public static readonly long[] Value={ 131L,229L,523L,719L,1013L,1307L,1601L,1699L,1993L,2287L,2777L,3169L,3463L,3659L,4051L,4639L,4933L,5227L,5521L,5717L,6011L,6599L,6991L,7187L,7481L,7873L,8069L,8167L,8363L,8461L,8951L,9049L,9343L,9539L,9833L,9931L,11597L,12479L,12577L,14243L,14341L,14537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142442Inst : IEnumerable<long>
{
public static readonly long[] Value=A142442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142442.Bytes);
public long this[int i]=>Value[i];

public static A142442Inst Instance=new A142442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142443
{
public static readonly long[] Value={ 83L,181L,769L,1063L,1259L,1553L,1847L,2141L,2239L,2729L,3023L,3121L,3709L,4003L,4297L,4493L,4591L,4787L,5081L,5179L,5669L,6257L,6551L,7237L,7433L,7727L,8609L,8707L,9001L,9491L,9883L,10079L,10177L,10667L,11059L,11353L,11549L,11941L,12823L,13313L,13411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142443Inst : IEnumerable<long>
{
public static readonly long[] Value=A142443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142443.Bytes);
public long this[int i]=>Value[i];

public static A142443Inst Instance=new A142443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142444
{
public static readonly long[] Value={ 281L,379L,673L,967L,1163L,2143L,2339L,2437L,2633L,2731L,2927L,3221L,3319L,3613L,3907L,4201L,4397L,4691L,4789L,5279L,5573L,5867L,6553L,7043L,8219L,8317L,8513L,8807L,9199L,9689L,9787L,11159L,11257L,11551L,12041L,12433L,12923L,13217L,13903L,14197L,15373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142444Inst : IEnumerable<long>
{
public static readonly long[] Value=A142444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142444.Bytes);
public long this[int i]=>Value[i];

public static A142444Inst Instance=new A142444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142445
{
public static readonly long[] Value={ 37L,233L,331L,821L,919L,1213L,1409L,1801L,1997L,2389L,2683L,2879L,3271L,3467L,3761L,4153L,4349L,4447L,4643L,4937L,5231L,5623L,6113L,6211L,6701L,7583L,7681L,7877L,8171L,8269L,8563L,9151L,9739L,11503L,11699L,12973L,13267L,13463L,13757L,14051L,14149L,14639L,14737L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142445Inst : IEnumerable<long>
{
public static readonly long[] Value=A142445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142445.Bytes);
public long this[int i]=>Value[i];

public static A142445Inst Instance=new A142445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142446
{
public static readonly long[] Value={ 283L,479L,577L,773L,1361L,1459L,1753L,1949L,2243L,2341L,3517L,4007L,4889L,4987L,5281L,5477L,5869L,6163L,6359L,6653L,6947L,7829L,7927L,8123L,8221L,9103L,9397L,9887L,10181L,10867L,11161L,12043L,12239L,13121L,13219L,13513L,13709L,13807L,14591L,14983L,15277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142446Inst : IEnumerable<long>
{
public static readonly long[] Value=A142446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142446.Bytes);
public long this[int i]=>Value[i];

public static A142446Inst Instance=new A142446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142447
{
public static readonly long[] Value={ 137L,431L,823L,1019L,1117L,1607L,1901L,1999L,2293L,3371L,3469L,4057L,4253L,4547L,5233L,5527L,5821L,6311L,6703L,6899L,6997L,7193L,7487L,7879L,8369L,8467L,8663L,8761L,9349L,9643L,9839L,10133L,10427L,11113L,11701L,11897L,12289L,12583L,13171L,13367L,13759L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142447Inst : IEnumerable<long>
{
public static readonly long[] Value=A142447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142447.Bytes);
public long this[int i]=>Value[i];

public static A142447Inst Instance=new A142447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142448
{
public static readonly long[] Value={ 89L,383L,677L,971L,1069L,1559L,1657L,1951L,2441L,2539L,2833L,3323L,3617L,3911L,4597L,4793L,5087L,5381L,5479L,6067L,6263L,6361L,6949L,7243L,7537L,8419L,8713L,9007L,9203L,9497L,9791L,10477L,10771L,11261L,12143L,12241L,12437L,12829L,13417L,13613L,13711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142448Inst : IEnumerable<long>
{
public static readonly long[] Value=A142448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142448.Bytes);
public long this[int i]=>Value[i];

public static A142448Inst Instance=new A142448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142449
{
public static readonly long[] Value={ 41L,139L,433L,727L,1021L,1217L,1511L,1609L,2099L,2393L,2687L,3079L,3373L,3863L,4157L,4451L,4549L,5039L,5333L,5431L,6607L,6803L,7489L,8273L,8861L,9547L,9743L,10037L,10331L,10429L,10723L,11213L,11311L,11801L,12487L,12781L,13859L,14153L,14251L,14447L,14741L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142449Inst : IEnumerable<long>
{
public static readonly long[] Value=A142449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142449.Bytes);
public long this[int i]=>Value[i];

public static A142449Inst Instance=new A142449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142450
{
public static readonly long[] Value={ 43L,239L,337L,631L,827L,1709L,2003L,2297L,2591L,2689L,3571L,3767L,4159L,4649L,4943L,5237L,5531L,5923L,6217L,7001L,7393L,7589L,7687L,7883L,8863L,9059L,9157L,9941L,10039L,10333L,10529L,10627L,11117L,11411L,12097L,12391L,12979L,13469L,13567L,13763L,14057L,14449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142450Inst : IEnumerable<long>
{
public static readonly long[] Value=A142450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142450.Bytes);
public long this[int i]=>Value[i];

public static A142450Inst Instance=new A142450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142451
{
public static readonly long[] Value={ 191L,877L,1171L,1367L,1759L,2053L,2347L,2543L,2837L,3229L,3719L,4013L,4111L,4993L,5189L,5483L,5581L,6659L,7247L,7541L,7639L,7933L,8423L,8521L,9011L,9109L,9403L,9697L,11069L,11657L,12049L,12343L,12539L,12637L,13127L,13421L,14009L,14107L,14303L,14401L,14891L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142451Inst : IEnumerable<long>
{
public static readonly long[] Value=A142451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142451.Bytes);
public long this[int i]=>Value[i];

public static A142451Inst Instance=new A142451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142452
{
public static readonly long[] Value={ 241L,829L,1123L,1319L,1613L,1907L,2593L,2789L,2887L,3083L,3181L,3671L,3769L,4259L,4357L,4651L,5827L,6121L,6317L,6709L,7297L,7591L,8081L,8179L,8669L,8963L,9257L,9551L,9649L,10139L,10433L,10531L,11119L,11903L,12197L,12491L,12589L,13177L,14549L,14843L,15137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142452Inst : IEnumerable<long>
{
public static readonly long[] Value=A142452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142452.Bytes);
public long this[int i]=>Value[i];

public static A142452Inst Instance=new A142452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142453
{
public static readonly long[] Value={ 193L,389L,487L,683L,977L,1663L,2153L,2251L,2447L,2741L,3329L,3623L,3917L,4211L,4603L,4799L,5387L,5779L,6073L,6269L,6367L,6563L,6661L,6857L,7151L,8719L,9013L,9209L,9601L,10091L,10973L,11071L,11953L,12149L,12541L,13619L,13913L,14011L,14207L,15187L,15383L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142453Inst : IEnumerable<long>
{
public static readonly long[] Value=A142453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142453.Bytes);
public long this[int i]=>Value[i];

public static A142453Inst Instance=new A142453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142454
{
public static readonly long[] Value={ 47L,439L,733L,929L,1223L,1321L,1811L,2203L,2399L,2693L,2791L,3673L,3967L,4261L,4457L,4751L,5437L,5927L,6221L,6907L,7103L,7691L,7789L,8377L,8573L,8867L,9161L,9749L,10141L,10337L,10631L,10729L,11317L,11807L,12101L,12689L,12983L,13669L,13963L,14159L,14551L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142454Inst : IEnumerable<long>
{
public static readonly long[] Value=A142454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142454.Bytes);
public long this[int i]=>Value[i];

public static A142454Inst Instance=new A142454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142455
{
public static readonly long[] Value={ 97L,293L,587L,881L,1567L,1861L,2351L,2939L,3037L,3331L,3527L,3821L,3919L,4409L,4507L,4703L,4801L,5683L,5879L,6173L,6271L,6761L,7349L,7643L,7741L,7937L,8231L,8329L,8623L,8819L,10093L,10289L,11171L,12347L,12641L,12739L,13033L,13229L,13327L,13523L,14503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142455Inst : IEnumerable<long>
{
public static readonly long[] Value=A142455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142455.Bytes);
public long this[int i]=>Value[i];

public static A142455Inst Instance=new A142455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142472
{
public static readonly long[] Value={ 1L,-4L,1L,21L,-18L,1L,-140L,240L,-48L,1L,1140L,-3150L,1300L,-100L,1L,-11004L,43620L,-29700L,4800L,-180L,1L,123074L,-650769L,647780L,-175175L,13965L,-294L,1L,-1566928L,10517108L,-14190400L,5676160L,-764400L,34496L,-448L,1L,22390488L,-184052520L,319680732L,-175091112L,35160048L,-2698920L,75600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142472Inst : IEnumerable<long>
{
public static readonly long[] Value=A142472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142472.Bytes);
public long this[int i]=>Value[i];

public static A142472Inst Instance=new A142472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142473
{
public static readonly long[] Value={ 1L,-1L,2L,4L,-6L,6L,-36L,44L,-36L,24L,576L,-600L,420L,-240L,120L,-14400L,13152L,-8100L,4080L,-1800L,720L,518400L,-423360L,233856L,-105840L,42000L,-15120L,5040L,-25401600L,18817920L,-9455040L,3898944L,-1411200L,463680L,-141120L,40320L,1625702400L,-1104606720L,510295680L,-193777920L,64653120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142473Inst : IEnumerable<long>
{
public static readonly long[] Value=A142473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142473.Bytes);
public long this[int i]=>Value[i];

public static A142473Inst Instance=new A142473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142474
{
public static readonly long[] Value={ 1L,0L,1L,2L,4L,9L,19L,41L,88L,189L,406L,872L,1873L,4023L,8641L,18560L,39865L,85626L,183916L,395033L,848491L,1822473L,3914488L,8407925L,18059374L,38789712L,83316385L,178955183L,384377665L,825604416L,1773314929L,3808901426L,8181135700L,17572253481L,37743426307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142474Inst : IEnumerable<long>
{
public static readonly long[] Value=A142474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142474.Bytes);
public long this[int i]=>Value[i];

public static A142474Inst Instance=new A142474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142475
{
public static readonly long[] Value={ 1L,0L,0L,-1L,0L,0L,1L,-1L,0L,0L,0L,1L,-1L,0L,0L,-1L,-1L,1L,-1L,0L,0L,1L,2L,-1L,1L,-1L,0L,0L,0L,-3L,1L,-1L,1L,-1L,0L,0L,-1L,4L,0L,1L,-1L,1L,-1L,0L,0L,1L,-6L,-1L,-1L,1L,-1L,1L,-1L,0L,0L,0L,9L,2L,2L,-1L,1L,-1L,1L,-1L,0L,0L,-1L,-13L,-3L,-3L,1L,-1L,1L,-1L,1L,-1L,0L,0L,1L,19L,3L,4L,0L,1L,-1L,1L,-1L,1L,-1L,0L,0L,0L,-28L,-2L,-5L,-1L,-1L,1L,-1L,1L,-1L,1L,-1L,0L,0L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142475Inst : IEnumerable<long>
{
public static readonly long[] Value=A142475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142475.Bytes);
public long this[int i]=>Value[i];

public static A142475Inst Instance=new A142475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142476
{
public static readonly long[] Value={ 103L,307L,409L,613L,919L,1021L,1123L,1327L,1429L,1531L,2143L,2347L,2551L,2857L,3061L,3163L,3469L,3571L,3673L,3877L,4591L,4999L,5101L,5407L,6121L,6427L,6529L,6733L,7039L,7243L,7549L,7753L,8059L,8161L,8263L,8467L,9181L,9283L,10099L,10303L,10711L,11119L,11527L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142476Inst : IEnumerable<long>
{
public static readonly long[] Value=A142476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142476.Bytes);
public long this[int i]=>Value[i];

public static A142476Inst Instance=new A142476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142477
{
public static readonly long[] Value={ 2L,53L,257L,359L,461L,563L,971L,1277L,1481L,1583L,1787L,1889L,2297L,2399L,2909L,3011L,3623L,3929L,4133L,4337L,4643L,5051L,5153L,5867L,6173L,6581L,7193L,7499L,7703L,7907L,8009L,8111L,9029L,9437L,9539L,9743L,10151L,10253L,10457L,10559L,11069L,11171L,11273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142477Inst : IEnumerable<long>
{
public static readonly long[] Value=A142477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142477.Bytes);
public long this[int i]=>Value[i];

public static A142477Inst Instance=new A142477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142478
{
public static readonly long[] Value={ 157L,463L,769L,1279L,1381L,1483L,1789L,1993L,2503L,2707L,3217L,3319L,3727L,3931L,4339L,4441L,4951L,5563L,5869L,6073L,6277L,6379L,6481L,6991L,7297L,7603L,8011L,8317L,8419L,8521L,8623L,8929L,9133L,9337L,9439L,9643L,9949L,10357L,10459L,10663L,10867L,11071L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142478Inst : IEnumerable<long>
{
public static readonly long[] Value=A142478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142478.Bytes);
public long this[int i]=>Value[i];

public static A142478Inst Instance=new A142478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142479
{
public static readonly long[] Value={ 5L,107L,311L,617L,719L,821L,1229L,1433L,1637L,2351L,2657L,2861L,2963L,3167L,3371L,3677L,3779L,3881L,4289L,4391L,4493L,4799L,5003L,5309L,5717L,6329L,6737L,7043L,7247L,7349L,7451L,7757L,8369L,8573L,9491L,10103L,10613L,11633L,11939L,12041L,12143L,12347L,12653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142479Inst : IEnumerable<long>
{
public static readonly long[] Value=A142479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142479.Bytes);
public long this[int i]=>Value[i];

public static A142479Inst Instance=new A142479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142480
{
public static readonly long[] Value={ 7L,109L,211L,313L,619L,823L,1129L,1231L,1741L,2251L,2557L,2659L,3067L,3169L,3271L,3373L,4597L,4801L,4903L,5107L,5209L,5413L,5821L,5923L,6229L,6637L,6841L,7351L,7759L,7963L,8167L,8269L,8677L,8779L,9187L,9391L,9697L,9901L,10513L,11329L,11839L,11941L,12043L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142480Inst : IEnumerable<long>
{
public static readonly long[] Value=A142480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142480.Bytes);
public long this[int i]=>Value[i];

public static A142480Inst Instance=new A142480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142481
{
public static readonly long[] Value={ 59L,263L,467L,569L,773L,977L,1181L,1283L,1487L,1997L,2099L,2609L,2711L,3119L,3221L,3323L,3527L,3833L,4139L,4241L,4547L,4649L,4751L,5261L,5669L,6689L,6791L,7607L,8117L,8219L,8423L,8627L,8831L,8933L,9137L,9239L,9341L,9749L,9851L,10259L,10463L,10667L,10973L,11177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142481Inst : IEnumerable<long>
{
public static readonly long[] Value=A142481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142481.Bytes);
public long this[int i]=>Value[i];

public static A142481Inst Instance=new A142481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142482
{
public static readonly long[] Value={ 61L,163L,367L,571L,673L,877L,1489L,1693L,1999L,2203L,2713L,2917L,3019L,3121L,3529L,3631L,3733L,4243L,4447L,4549L,4651L,4957L,5059L,5569L,6079L,6691L,6793L,6997L,7507L,8017L,8221L,8527L,8629L,8731L,9241L,9343L,9547L,9649L,10159L,10567L,10771L,11383L,11587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142482Inst : IEnumerable<long>
{
public static readonly long[] Value=A142482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142482.Bytes);
public long this[int i]=>Value[i];

public static A142482Inst Instance=new A142482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142483
{
public static readonly long[] Value={ 11L,113L,317L,419L,521L,827L,929L,1031L,1439L,1847L,1949L,2153L,2357L,2459L,2663L,2969L,3581L,3989L,4091L,4397L,4703L,5009L,5417L,5519L,5927L,6029L,6131L,6947L,7151L,7253L,7457L,7559L,8069L,8171L,8273L,8681L,8783L,9293L,9497L,9803L,10007L,10211L,10313L,11027L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142483Inst : IEnumerable<long>
{
public static readonly long[] Value=A142483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142483.Bytes);
public long this[int i]=>Value[i];

public static A142483Inst Instance=new A142483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142484
{
public static readonly long[] Value={ 13L,421L,523L,727L,829L,1033L,1237L,1543L,1747L,1951L,2053L,2767L,2971L,3583L,3889L,4093L,4297L,4603L,4909L,5011L,5113L,5419L,5521L,5623L,5827L,6133L,6337L,6949L,7459L,7561L,7867L,8377L,8581L,8887L,9091L,9397L,9601L,9907L,10009L,10111L,10723L,11131L,11437L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142484Inst : IEnumerable<long>
{
public static readonly long[] Value=A142484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142484.Bytes);
public long this[int i]=>Value[i];

public static A142484Inst Instance=new A142484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142485
{
public static readonly long[] Value={ 167L,269L,677L,881L,983L,1187L,1289L,1493L,1697L,1901L,2003L,2207L,2309L,2411L,2819L,3023L,3329L,3533L,4349L,4451L,5471L,5573L,5879L,5981L,6287L,6389L,6491L,6899L,7001L,7103L,7307L,7817L,7919L,8123L,8429L,8837L,9041L,9551L,9857L,10061L,10163L,10979L,11489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142485Inst : IEnumerable<long>
{
public static readonly long[] Value=A142485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142485.Bytes);
public long this[int i]=>Value[i];

public static A142485Inst Instance=new A142485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142486
{
public static readonly long[] Value={ 67L,271L,373L,577L,883L,1087L,1291L,1597L,1699L,1801L,2311L,2617L,2719L,3229L,3331L,3433L,3637L,3739L,3943L,4657L,4759L,4861L,5167L,5779L,5881L,7207L,7309L,7411L,7717L,8329L,8431L,8737L,8839L,8941L,9043L,9349L,9859L,10267L,10369L,11083L,11287L,11491L,11593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142486Inst : IEnumerable<long>
{
public static readonly long[] Value=A142486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142486.Bytes);
public long this[int i]=>Value[i];

public static A142486Inst Instance=new A142486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142487
{
public static readonly long[] Value={ 19L,223L,631L,733L,937L,1039L,1447L,1549L,1753L,2161L,2467L,2671L,3079L,3181L,3691L,3793L,4099L,4201L,4507L,4813L,5119L,5323L,5527L,6037L,6343L,6547L,7057L,7159L,7669L,7873L,8179L,8689L,8893L,9199L,9403L,9811L,10321L,10627L,10729L,10831L,11239L,11443L,11953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142487Inst : IEnumerable<long>
{
public static readonly long[] Value=A142487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142487.Bytes);
public long this[int i]=>Value[i];

public static A142487Inst Instance=new A142487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142664
{
public static readonly long[] Value={ 167L,223L,503L,727L,839L,1063L,1231L,1399L,1511L,1567L,1847L,2239L,2351L,2687L,3023L,3079L,3191L,3359L,3527L,3583L,3863L,3919L,4423L,4591L,4703L,4759L,4871L,5039L,5431L,5711L,5879L,6047L,6271L,6551L,6607L,6719L,7559L,7727L,7951L,8231L,8287L,8623L,9127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142664Inst : IEnumerable<long>
{
public static readonly long[] Value=A142664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142664.Bytes);
public long this[int i]=>Value[i];

public static A142664Inst Instance=new A142664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142665
{
public static readonly long[] Value={ 229L,457L,571L,1483L,1597L,2053L,2281L,2851L,3079L,3307L,3877L,4219L,4447L,4561L,4789L,4903L,5701L,6043L,6271L,6841L,7069L,7297L,7411L,7639L,7753L,7867L,8209L,8779L,8893L,9007L,9349L,9463L,10831L,11059L,11173L,11287L,11743L,11971L,12541L,13339L,13567L,13681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142665Inst : IEnumerable<long>
{
public static readonly long[] Value=A142665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142665.Bytes);
public long this[int i]=>Value[i];

public static A142665Inst Instance=new A142665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142666
{
public static readonly long[] Value={ 2L,59L,173L,401L,743L,857L,971L,1427L,1997L,2111L,2339L,2909L,3023L,3137L,3251L,3593L,3821L,4049L,4391L,4733L,5189L,5303L,5417L,5531L,5987L,6101L,6329L,6899L,7013L,7127L,7583L,8039L,8609L,8837L,8951L,9293L,9521L,9749L,10091L,10433L,10889L,11003L,11117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142666Inst : IEnumerable<long>
{
public static readonly long[] Value=A142666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142666.Bytes);
public long this[int i]=>Value[i];

public static A142666Inst Instance=new A142666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142667
{
public static readonly long[] Value={ 61L,631L,859L,1087L,1201L,1429L,1543L,1657L,1999L,2113L,2341L,2683L,2797L,3253L,3709L,3823L,4051L,4507L,4621L,5077L,5419L,5647L,6217L,6673L,7129L,7243L,7699L,7927L,8269L,8839L,9067L,9181L,10093L,10321L,10663L,10891L,11119L,11689L,12373L,12487L,12601L,12829L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142667Inst : IEnumerable<long>
{
public static readonly long[] Value=A142667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142667.Bytes);
public long this[int i]=>Value[i];

public static A142667Inst Instance=new A142667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142668
{
public static readonly long[] Value={ 5L,233L,347L,461L,1031L,1259L,1373L,1487L,1601L,2399L,2741L,2969L,3083L,3539L,3767L,3881L,4337L,4451L,4679L,4793L,5021L,5477L,5591L,6047L,6389L,6959L,7187L,7529L,7643L,7757L,8669L,8783L,9011L,9239L,9467L,9923L,10037L,10151L,10607L,10949L,11177L,11519L,11633L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142668Inst : IEnumerable<long>
{
public static readonly long[] Value=A142668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142668.Bytes);
public long this[int i]=>Value[i];

public static A142668Inst Instance=new A142668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142669
{
public static readonly long[] Value={ 7L,349L,463L,577L,691L,919L,1033L,1489L,1831L,2287L,2857L,2971L,3313L,3541L,3769L,4111L,4339L,4567L,4909L,5023L,5479L,5821L,6163L,6277L,6619L,6733L,6961L,7417L,7759L,7873L,8101L,8329L,8443L,9013L,9127L,9241L,9697L,9811L,10039L,10267L,10723L,10837L,11863L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142669Inst : IEnumerable<long>
{
public static readonly long[] Value=A142669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142669.Bytes);
public long this[int i]=>Value[i];

public static A142669Inst Instance=new A142669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142670
{
public static readonly long[] Value={ 179L,293L,521L,863L,977L,1091L,1319L,1433L,1889L,2003L,2459L,2687L,2801L,3257L,3371L,4283L,4397L,4967L,5081L,5309L,5651L,5879L,6221L,6449L,6563L,6791L,7019L,7247L,7589L,7703L,7817L,8273L,8387L,8501L,9413L,10211L,10667L,10781L,11351L,11579L,11807L,12149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142670Inst : IEnumerable<long>
{
public static readonly long[] Value=A142670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142670.Bytes);
public long this[int i]=>Value[i];

public static A142670Inst Instance=new A142670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142671
{
public static readonly long[] Value={ 67L,181L,409L,523L,751L,1093L,1321L,1549L,1663L,1777L,2347L,2689L,2803L,2917L,3259L,3373L,3943L,4057L,4513L,4969L,5197L,5653L,5881L,6337L,6451L,6679L,6793L,6907L,7477L,7591L,7933L,8161L,8389L,8731L,9187L,9643L,9871L,10099L,11239L,11353L,11467L,11923L,12037L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142671Inst : IEnumerable<long>
{
public static readonly long[] Value=A142671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142671.Bytes);
public long this[int i]=>Value[i];

public static A142671Inst Instance=new A142671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142672
{
public static readonly long[] Value={ 11L,239L,353L,467L,809L,1151L,1493L,1607L,1721L,1949L,2063L,2633L,2861L,3089L,3203L,3659L,4001L,4229L,4457L,4799L,5483L,5711L,5939L,6053L,6737L,7079L,7193L,7307L,7649L,7877L,8219L,8447L,9473L,9587L,9929L,10271L,10499L,10613L,11069L,11411L,11867L,11981L,12323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142672Inst : IEnumerable<long>
{
public static readonly long[] Value=A142672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142672.Bytes);
public long this[int i]=>Value[i];

public static A142672Inst Instance=new A142672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142673
{
public static readonly long[] Value={ 13L,127L,241L,811L,1039L,1153L,1381L,1609L,1723L,1951L,2179L,2293L,2521L,2749L,3319L,3433L,3547L,3889L,4003L,4231L,4801L,5827L,6397L,6967L,7309L,7537L,7879L,7993L,8221L,8563L,8677L,9133L,9817L,9931L,10159L,10273L,10501L,10729L,10957L,11071L,11299L,11527L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142673Inst : IEnumerable<long>
{
public static readonly long[] Value=A142673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142673.Bytes);
public long this[int i]=>Value[i];

public static A142673Inst Instance=new A142673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142674
{
public static readonly long[] Value={ 71L,641L,983L,1097L,1439L,1553L,1667L,2237L,2351L,2579L,2693L,3491L,3719L,3833L,3947L,4289L,4517L,4973L,5087L,5657L,6113L,6569L,6911L,7253L,7481L,7823L,7937L,8849L,8963L,9419L,9533L,10103L,10331L,10559L,11243L,11471L,11699L,11813L,11927L,12041L,12269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142674Inst : IEnumerable<long>
{
public static readonly long[] Value=A142674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142674.Bytes);
public long this[int i]=>Value[i];

public static A142674Inst Instance=new A142674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142675
{
public static readonly long[] Value={ 73L,643L,757L,1213L,1327L,1669L,1783L,2011L,2239L,2467L,3037L,3607L,4177L,4519L,4861L,5431L,5659L,6229L,6343L,6571L,7027L,7369L,8053L,8167L,8623L,8737L,9421L,9649L,10333L,10789L,10903L,11131L,11587L,11701L,12043L,12157L,12613L,12841L,13183L,13297L,13411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142675Inst : IEnumerable<long>
{
public static readonly long[] Value=A142675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142675.Bytes);
public long this[int i]=>Value[i];

public static A142675Inst Instance=new A142675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142676
{
public static readonly long[] Value={ 17L,131L,359L,587L,701L,929L,1499L,1613L,2069L,2297L,2411L,2753L,3209L,3323L,3779L,4007L,4349L,4463L,4691L,4919L,5147L,5261L,5717L,6173L,6287L,6857L,6971L,7541L,7883L,8111L,8681L,9137L,9479L,10163L,10391L,10733L,10847L,11987L,12101L,12329L,12671L,12899L,13127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142676Inst : IEnumerable<long>
{
public static readonly long[] Value=A142676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142676.Bytes);
public long this[int i]=>Value[i];

public static A142676Inst Instance=new A142676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142677
{
public static readonly long[] Value={ 191L,419L,647L,761L,1103L,1217L,1559L,1787L,1901L,2129L,2243L,2357L,2699L,2927L,3041L,4409L,4523L,4637L,4751L,6689L,6803L,6917L,7487L,7829L,8171L,8513L,8627L,8741L,8969L,9311L,9539L,9767L,10223L,10337L,11933L,12161L,12503L,12959L,13187L,13757L,14327L,14669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142677Inst : IEnumerable<long>
{
public static readonly long[] Value=A142677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142677.Bytes);
public long this[int i]=>Value[i];

public static A142677Inst Instance=new A142677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142678
{
public static readonly long[] Value={ 79L,193L,307L,421L,877L,991L,1447L,1789L,2017L,2131L,2473L,3271L,3499L,3613L,3727L,4297L,4639L,5209L,5323L,5437L,5779L,6007L,6121L,6577L,6691L,7489L,7603L,7717L,8059L,8287L,8629L,8971L,9199L,9769L,9883L,10111L,10453L,10567L,10909L,11251L,11593L,11821L,12049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142678Inst : IEnumerable<long>
{
public static readonly long[] Value=A142678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142678.Bytes);
public long this[int i]=>Value[i];

public static A142678Inst Instance=new A142678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142679
{
public static readonly long[] Value={ 23L,137L,251L,479L,593L,821L,1049L,1163L,1277L,1619L,1733L,1847L,2417L,2531L,3329L,3557L,3671L,4013L,4127L,4241L,4583L,5039L,5153L,5381L,6521L,6863L,6977L,7433L,7547L,8117L,8231L,8573L,9029L,9257L,9371L,9941L,10169L,10739L,10853L,11423L,12107L,12791L,13931L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142679Inst : IEnumerable<long>
{
public static readonly long[] Value=A142679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142679.Bytes);
public long this[int i]=>Value[i];

public static A142679Inst Instance=new A142679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142776
{
public static readonly long[] Value={ 167L,521L,757L,1229L,1583L,2999L,3943L,4297L,4651L,5477L,6067L,6421L,7129L,7247L,8191L,8663L,9371L,10079L,10433L,11731L,12203L,12911L,13147L,13619L,14327L,14563L,15271L,16097L,16333L,16451L,17041L,17159L,17749L,18457L,19991L,21407L,21997L,22469L,23059L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142776Inst : IEnumerable<long>
{
public static readonly long[] Value=A142776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142776.Bytes);
public long this[int i]=>Value[i];

public static A142776Inst Instance=new A142776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142777
{
public static readonly long[] Value={ 109L,227L,463L,1171L,1289L,1879L,1997L,2351L,3413L,3767L,4003L,4357L,5419L,6481L,6599L,7307L,8369L,9431L,10139L,10729L,10847L,11083L,11437L,11909L,12263L,12853L,13679L,14033L,14387L,14741L,15331L,15803L,16747L,17573L,18517L,19697L,20051L,20287L,20641L,20759L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142777Inst : IEnumerable<long>
{
public static readonly long[] Value=A142777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142777.Bytes);
public long this[int i]=>Value[i];

public static A142777Inst Instance=new A142777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142778
{
public static readonly long[] Value={ 523L,641L,877L,1231L,2293L,2411L,2647L,3001L,3119L,3709L,4889L,5479L,6659L,7013L,7603L,8311L,8429L,8783L,9137L,9491L,10789L,11261L,11497L,11969L,12323L,13267L,14447L,14683L,15391L,16217L,16453L,17987L,18223L,18341L,19403L,19993L,20347L,21881L,22943L,23297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142778Inst : IEnumerable<long>
{
public static readonly long[] Value=A142778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142778.Bytes);
public long this[int i]=>Value[i];

public static A142778Inst Instance=new A142778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142779
{
public static readonly long[] Value={ 229L,347L,701L,937L,1291L,1409L,1999L,2707L,3061L,3533L,3769L,4241L,4831L,5303L,5657L,6011L,6247L,6719L,7309L,8017L,9433L,9551L,9787L,10141L,10259L,10613L,11321L,12619L,12973L,13327L,13681L,13799L,14153L,14389L,15451L,15569L,15923L,16631L,17929L,18047L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142779Inst : IEnumerable<long>
{
public static readonly long[] Value=A142779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142779.Bytes);
public long this[int i]=>Value[i];

public static A142779Inst Instance=new A142779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142780
{
public static readonly long[] Value={ 53L,643L,761L,997L,1823L,2531L,2767L,3121L,3593L,3947L,5009L,5717L,5953L,6661L,6779L,7369L,7487L,7723L,7841L,8431L,9257L,10909L,11027L,11617L,11971L,13033L,13151L,13859L,14449L,15511L,15629L,16573L,16691L,16927L,17989L,18461L,19051L,19759L,20113L,20231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142780Inst : IEnumerable<long>
{
public static readonly long[] Value=A142780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142780.Bytes);
public long this[int i]=>Value[i];

public static A142780Inst Instance=new A142780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142781
{
public static readonly long[] Value={ 113L,349L,467L,821L,2237L,2473L,2591L,3181L,3299L,3889L,4007L,4243L,4597L,4951L,5659L,6131L,6367L,7193L,7547L,7901L,8609L,8963L,9199L,9907L,10733L,11087L,11677L,12149L,12503L,12739L,13093L,14627L,15217L,16633L,16987L,17341L,18049L,18521L,18757L,19583L,19819L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142781Inst : IEnumerable<long>
{
public static readonly long[] Value=A142781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142781.Bytes);
public long this[int i]=>Value[i];

public static A142781Inst Instance=new A142781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142782
{
public static readonly long[] Value={ 173L,409L,881L,1117L,1471L,2179L,2297L,2887L,3359L,4421L,4657L,5011L,5483L,6073L,6427L,6781L,6899L,7253L,7489L,7607L,8669L,9377L,9613L,9967L,10321L,11383L,12799L,12917L,14923L,15277L,15749L,16103L,16339L,16693L,16811L,17047L,17401L,17519L,19289L,19997L,20233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142782Inst : IEnumerable<long>
{
public static readonly long[] Value=A142782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142782.Bytes);
public long this[int i]=>Value[i];

public static A142782Inst Instance=new A142782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142783
{
public static readonly long[] Value={ 233L,587L,823L,941L,1531L,2003L,2239L,2357L,2593L,2711L,3301L,4127L,4363L,4481L,5189L,5779L,5897L,6133L,6841L,6959L,7549L,9319L,9437L,9791L,10499L,10853L,11443L,12269L,13331L,13567L,13921L,14629L,14747L,14983L,15101L,15809L,16871L,17107L,17579L,18169L,18287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142783Inst : IEnumerable<long>
{
public static readonly long[] Value=A142783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142783.Bytes);
public long this[int i]=>Value[i];

public static A142783Inst Instance=new A142783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142784
{
public static readonly long[] Value={ 293L,647L,883L,1237L,1709L,2063L,2417L,3361L,3833L,4423L,5839L,6311L,6547L,7019L,7727L,7963L,8081L,8317L,9497L,9733L,9851L,10559L,11149L,11503L,11621L,12211L,12329L,12919L,13037L,13627L,15161L,16223L,16931L,17167L,18229L,18583L,18701L,19763L,20117L,20353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142784Inst : IEnumerable<long>
{
public static readonly long[] Value=A142784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142784.Bytes);
public long this[int i]=>Value[i];

public static A142784Inst Instance=new A142784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142785
{
public static readonly long[] Value={ 353L,1061L,1297L,2477L,2713L,3067L,3539L,4129L,4483L,5309L,6607L,6961L,7079L,7433L,7669L,8377L,8731L,8849L,9203L,9439L,10501L,10973L,11681L,12743L,12979L,13451L,13687L,14159L,14867L,16519L,17581L,18289L,19469L,20177L,21121L,23599L,24071L,25841L,26431L,26903L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142785Inst : IEnumerable<long>
{
public static readonly long[] Value=A142785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142785.Bytes);
public long this[int i]=>Value[i];

public static A142785Inst Instance=new A142785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142786
{
public static readonly long[] Value={ 7L,67L,127L,307L,367L,487L,547L,607L,727L,787L,907L,967L,1087L,1327L,1447L,1567L,1627L,1747L,1867L,1987L,2287L,2347L,2467L,2647L,2707L,2767L,2887L,3067L,3187L,3307L,3547L,3607L,3727L,3847L,3907L,3967L,4027L,4327L,4447L,4507L,4567L,4987L,5107L,5167L,5227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142786Inst : IEnumerable<long>
{
public static readonly long[] Value=A142786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142786.Bytes);
public long this[int i]=>Value[i];

public static A142786Inst Instance=new A142786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142787
{
public static readonly long[] Value={ 13L,73L,193L,313L,373L,433L,613L,673L,733L,853L,1033L,1093L,1153L,1213L,1453L,1693L,1753L,1873L,1933L,1993L,2053L,2113L,2293L,2473L,2593L,2713L,2833L,2953L,3253L,3313L,3373L,3433L,3613L,3673L,3733L,3793L,3853L,4093L,4153L,4273L,4513L,4813L,4933L,4993L,5113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142787Inst : IEnumerable<long>
{
public static readonly long[] Value=A142787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142787.Bytes);
public long this[int i]=>Value[i];

public static A142787Inst Instance=new A142787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142788
{
public static readonly long[] Value={ 17L,137L,197L,257L,317L,557L,617L,677L,797L,857L,977L,1097L,1217L,1277L,1637L,1697L,1877L,1997L,2237L,2297L,2357L,2417L,2477L,2657L,2777L,2837L,2897L,2957L,3137L,3257L,3557L,3617L,3677L,3797L,3917L,4157L,4217L,4337L,4397L,4457L,4517L,4637L,4817L,4877L,4937L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142788Inst : IEnumerable<long>
{
public static readonly long[] Value=A142788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142788.Bytes);
public long this[int i]=>Value[i];

public static A142788Inst Instance=new A142788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142789
{
public static readonly long[] Value={ 19L,79L,139L,199L,379L,439L,499L,619L,739L,859L,919L,1039L,1279L,1399L,1459L,1579L,1699L,1759L,1879L,1999L,2179L,2239L,2539L,2659L,2719L,3019L,3079L,3259L,3319L,3499L,3559L,3739L,3919L,4099L,4159L,4219L,4339L,4519L,4639L,4759L,4999L,5059L,5119L,5179L,5419L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142789Inst : IEnumerable<long>
{
public static readonly long[] Value=A142789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142789.Bytes);
public long this[int i]=>Value[i];

public static A142789Inst Instance=new A142789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142790
{
public static readonly long[] Value={ 23L,83L,263L,383L,443L,503L,563L,683L,743L,863L,983L,1103L,1163L,1223L,1283L,1523L,1583L,1823L,2003L,2063L,2243L,2423L,2543L,2663L,2843L,2903L,2963L,3023L,3083L,3203L,3323L,3623L,3803L,3863L,3923L,4283L,4463L,4523L,4583L,4643L,4703L,4943L,5003L,5303L,5483L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142790Inst : IEnumerable<long>
{
public static readonly long[] Value=A142790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142790.Bytes);
public long this[int i]=>Value[i];

public static A142790Inst Instance=new A142790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142791
{
public static readonly long[] Value={ 29L,89L,149L,269L,389L,449L,509L,569L,809L,929L,1049L,1109L,1229L,1289L,1409L,1709L,1889L,1949L,2069L,2129L,2309L,2549L,2609L,2729L,2789L,2909L,2969L,3089L,3209L,3329L,3389L,3449L,3929L,3989L,4049L,4229L,4289L,4349L,4409L,4649L,4889L,5009L,5189L,5309L,5669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142791Inst : IEnumerable<long>
{
public static readonly long[] Value=A142791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142791.Bytes);
public long this[int i]=>Value[i];

public static A142791Inst Instance=new A142791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142840
{
public static readonly long[] Value={ 103L,347L,1201L,1567L,1811L,1933L,2543L,2909L,4007L,4129L,4373L,4861L,5227L,5471L,6203L,6569L,6691L,7057L,7789L,8521L,8887L,9497L,9619L,11083L,12547L,12791L,13523L,14011L,14621L,16451L,16573L,17183L,19013L,19379L,19501L,19867L,20233L,20477L,20599L,22063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142840Inst : IEnumerable<long>
{
public static readonly long[] Value=A142840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142840.Bytes);
public long this[int i]=>Value[i];

public static A142840Inst Instance=new A142840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142841
{
public static readonly long[] Value={ 43L,409L,653L,1019L,1873L,2239L,2971L,3581L,3947L,4679L,4801L,5167L,6143L,6997L,7607L,8461L,9437L,9803L,10169L,10657L,11633L,12487L,12853L,13219L,13463L,13829L,14561L,14683L,16879L,17123L,17489L,17977L,18587L,19319L,19441L,20051L,20173L,21149L,21881L,22003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142841Inst : IEnumerable<long>
{
public static readonly long[] Value=A142841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142841.Bytes);
public long this[int i]=>Value[i];

public static A142841Inst Instance=new A142841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142842
{
public static readonly long[] Value={ 227L,349L,593L,1447L,2179L,2423L,2789L,3643L,4253L,5107L,5351L,5717L,5839L,6449L,6571L,7547L,7669L,9011L,9133L,9377L,9743L,10597L,11329L,11939L,12671L,13037L,13159L,14867L,15233L,16087L,16453L,17551L,19259L,19381L,19991L,20113L,20357L,20479L,21089L,21211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142842Inst : IEnumerable<long>
{
public static readonly long[] Value=A142842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142842.Bytes);
public long this[int i]=>Value[i];

public static A142842Inst Instance=new A142842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142843
{
public static readonly long[] Value={ 167L,1021L,1753L,1997L,2729L,2851L,3217L,3461L,3583L,5413L,5657L,5779L,6389L,7121L,7243L,7487L,7853L,8219L,8707L,8951L,9439L,10781L,10903L,12611L,13099L,13709L,13831L,14197L,14563L,14929L,15173L,15661L,16759L,17491L,18223L,19687L,20297L,20663L,21517L,22859L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142843Inst : IEnumerable<long>
{
public static readonly long[] Value=A142843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142843.Bytes);
public long this[int i]=>Value[i];

public static A142843Inst Instance=new A142843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142844
{
public static readonly long[] Value={ 107L,229L,839L,1327L,1571L,1693L,2791L,3767L,3889L,4133L,4621L,4987L,5231L,6329L,6451L,7549L,7793L,8647L,9013L,9257L,9623L,10111L,10477L,11087L,11941L,12917L,13649L,14503L,14747L,14869L,15601L,16333L,16699L,16943L,17431L,18041L,18773L,19139L,19993L,20359L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142844Inst : IEnumerable<long>
{
public static readonly long[] Value=A142844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142844.Bytes);
public long this[int i]=>Value[i];

public static A142844Inst Instance=new A142844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142845
{
public static readonly long[] Value={ 47L,1511L,1877L,1999L,2243L,2609L,2731L,3463L,4073L,4561L,5171L,5659L,5903L,6269L,7001L,7489L,8221L,8831L,9319L,9929L,11027L,11149L,11393L,12491L,12613L,12979L,13711L,14321L,15053L,15541L,15907L,16273L,16883L,17737L,17981L,18713L,19079L,20177L,20543L,21031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142845Inst : IEnumerable<long>
{
public static readonly long[] Value=A142845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142845.Bytes);
public long this[int i]=>Value[i];

public static A142845Inst Instance=new A142845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142846
{
public static readonly long[] Value={ 109L,353L,719L,1451L,2549L,2671L,3037L,3769L,4013L,5233L,5477L,5843L,7307L,7673L,8039L,8161L,8527L,8893L,9137L,10357L,10601L,10723L,11699L,11821L,12553L,12919L,13163L,14627L,15359L,16091L,16823L,17189L,17921L,18043L,18287L,19141L,19507L,19751L,20117L,20483L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142846Inst : IEnumerable<long>
{
public static readonly long[] Value=A142846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142846.Bytes);
public long this[int i]=>Value[i];

public static A142846Inst Instance=new A142846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142847
{
public static readonly long[] Value={ 293L,659L,1879L,3221L,3343L,3709L,4441L,5051L,5417L,5783L,6271L,6637L,7247L,7369L,8101L,8467L,9199L,9931L,10663L,11273L,13103L,13469L,13591L,14323L,15299L,15787L,16519L,16763L,18593L,18959L,19081L,19447L,19813L,20789L,21277L,21521L,22619L,22741L,23473L,24083L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142847Inst : IEnumerable<long>
{
public static readonly long[] Value=A142847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142847.Bytes);
public long this[int i]=>Value[i];

public static A142847Inst Instance=new A142847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142848
{
public static readonly long[] Value={ 233L,599L,1087L,1453L,1697L,2063L,2551L,2917L,3527L,4259L,5113L,5479L,6089L,6211L,6577L,7187L,7309L,7919L,9749L,9871L,10847L,11213L,11579L,11701L,12433L,12799L,13043L,14629L,15361L,15727L,15971L,16703L,17191L,17923L,18289L,18899L,19387L,19753L,19997L,22193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142848Inst : IEnumerable<long>
{
public static readonly long[] Value=A142848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142848.Bytes);
public long this[int i]=>Value[i];

public static A142848Inst Instance=new A142848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142849
{
public static readonly long[] Value={ 173L,661L,1637L,1759L,2003L,2857L,3467L,3833L,4931L,5297L,5419L,6029L,6151L,6761L,6883L,7127L,8713L,9323L,9689L,9811L,10177L,10909L,11519L,12007L,12251L,12373L,12739L,12983L,14081L,14447L,14813L,15667L,16033L,17497L,17863L,18229L,18839L,19571L,19937L,21157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142849Inst : IEnumerable<long>
{
public static readonly long[] Value=A142849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142849.Bytes);
public long this[int i]=>Value[i];

public static A142849Inst Instance=new A142849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142850
{
public static readonly long[] Value={ 113L,479L,601L,967L,1699L,2309L,2797L,3041L,3163L,3407L,3529L,4139L,4261L,4871L,4993L,5237L,6091L,6701L,6823L,7433L,8287L,9629L,11093L,12923L,13411L,14143L,14387L,14753L,15241L,15607L,15973L,16217L,16339L,17681L,18047L,18169L,18413L,19267L,20731L,21341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142850Inst : IEnumerable<long>
{
public static readonly long[] Value=A142850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142850.Bytes);
public long this[int i]=>Value[i];

public static A142850Inst Instance=new A142850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142851
{
public static readonly long[] Value={ 53L,419L,541L,907L,1151L,2371L,3347L,3469L,4079L,4201L,4567L,4933L,6397L,6763L,7129L,8837L,9203L,10301L,10667L,10789L,11399L,11887L,12253L,12497L,12619L,13229L,14083L,14327L,14449L,15791L,15913L,16889L,17011L,17377L,17987L,18353L,18719L,19207L,20183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142851Inst : IEnumerable<long>
{
public static readonly long[] Value=A142851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142851.Bytes);
public long this[int i]=>Value[i];

public static A142851Inst Instance=new A142851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142852
{
public static readonly long[] Value={ 359L,1091L,1213L,1579L,1823L,2311L,2677L,4019L,4507L,4751L,5483L,5849L,6337L,6581L,6703L,6947L,7069L,8167L,9631L,10607L,10729L,10973L,11827L,12071L,12437L,13291L,13901L,14389L,14633L,15121L,15731L,16097L,16829L,17317L,17683L,18049L,19391L,20123L,20611L,21221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142852Inst : IEnumerable<long>
{
public static readonly long[] Value=A142852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142852.Bytes);
public long this[int i]=>Value[i];

public static A142852Inst Instance=new A142852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142853
{
public static readonly long[] Value={ 421L,787L,1031L,1153L,2129L,2251L,2617L,2861L,3593L,4447L,4691L,4813L,5179L,6277L,6521L,7253L,7741L,8839L,10181L,10303L,11279L,12011L,12377L,12743L,13109L,13597L,13841L,13963L,14207L,14939L,15061L,15427L,15671L,17257L,17623L,17989L,18233L,19087L,19697L,19819L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142853Inst : IEnumerable<long>
{
public static readonly long[] Value=A142853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142853.Bytes);
public long this[int i]=>Value[i];

public static A142853Inst Instance=new A142853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142854
{
public static readonly long[] Value={ 239L,727L,971L,1093L,1459L,2069L,2557L,2801L,3167L,3533L,4021L,5119L,5851L,6217L,6827L,6949L,7193L,7559L,7681L,8291L,8779L,9511L,10243L,10487L,10853L,12073L,13049L,13171L,13537L,13781L,13903L,14879L,15733L,16831L,17807L,17929L,18539L,18661L,19759L,20369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142854Inst : IEnumerable<long>
{
public static readonly long[] Value=A142854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142854.Bytes);
public long this[int i]=>Value[i];

public static A142854Inst Instance=new A142854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142855
{
public static readonly long[] Value={ 179L,911L,1033L,1277L,1399L,2131L,2741L,3229L,4327L,4937L,5059L,5303L,5669L,5791L,7499L,7621L,8231L,8353L,8597L,8719L,8963L,9817L,10061L,10427L,11159L,12379L,13477L,13721L,14087L,15307L,15551L,16649L,17137L,17747L,19211L,19333L,19577L,19699L,20431L,21163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142855Inst : IEnumerable<long>
{
public static readonly long[] Value=A142855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142855.Bytes);
public long this[int i]=>Value[i];

public static A142855Inst Instance=new A142855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143000
{
public static readonly BigInteger[] Value={ 0L,1L,9L,151L,3900L,143956L,7188048L,466900848L,38269041408L,3864146985216L,471339558835200L,68335862058777600L,11616056962961817600UL,BigInteger.Parse("2288216707872948633600"),BigInteger.Parse("517111756256861311795200") };
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
public class A143000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143000Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143000.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143000Inst Instance=new A143000Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143001
{
public static readonly BigInteger[] Value={ 0L,1L,15L,391L,14900L,770596L,51695280L,4358885616L,451036788480L,56192122503936L,8297504007091200L,1433159145783936000L,BigInteger.Parse("286297057932974899200"),BigInteger.Parse("65505120288597559296000") };
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
public class A143001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143001Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143001.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143001Inst Instance=new A143001Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143002
{
public static readonly BigInteger[] Value={ 0L,1L,21L,751L,38500L,2617756L,225629712L,23924915568L,3053853073152L,461404969871616L,81403191005875200L,16580318776579814400UL,BigInteger.Parse("3861255442546368921600"),BigInteger.Parse("1019529192596773592678400") };
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
public class A143002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143002Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143002.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143002Inst Instance=new A143002Inst();

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