using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A141865
{
public static readonly long[] Value={ 13L,47L,149L,251L,353L,421L,523L,557L,659L,727L,761L,829L,863L,1033L,1237L,1373L,1543L,1747L,1951L,2053L,2087L,2393L,2699L,2767L,2801L,2903L,2971L,3209L,3413L,3583L,3617L,3719L,3821L,3889L,3923L,4093L,4127L,4229L,4297L,4603L,4637L,4909L,4943L,5011L,5113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141865Inst : IEnumerable<long>
{
public static readonly long[] Value=A141865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141865.Bytes);
public long this[int i]=>Value[i];

public static A141865Inst Instance=new A141865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141866
{
public static readonly long[] Value={ 89L,509L,719L,929L,1559L,1979L,2399L,2609L,2819L,3449L,3659L,4079L,4289L,4919L,6389L,6599L,7019L,7229L,7649L,8069L,8699L,9539L,9749L,10169L,10589L,10799L,12269L,12479L,12689L,12899L,13109L,14159L,14369L,15629L,16889L,17099L,17519L,17729L,17939L,18149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141866Inst : IEnumerable<long>
{
public static readonly long[] Value=A141866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141866.Bytes);
public long this[int i]=>Value[i];

public static A141866Inst Instance=new A141866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141867
{
public static readonly long[] Value={ 3L,3L,5L,7L,11L,13L,17L,17L,23L,31L,29L,37L,43L,47L,53L,61L,61L,61L,71L,79L,83L,101L,103L,107L,113L,137L,137L,139L,151L,163L,167L,163L,167L,173L,173L,179L,181L,199L,211L,211L,223L,229L,233L,233L,239L,233L,251L,251L,263L,263L,283L,277L,307L,307L,313L,317L,313L,337L,347L,347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141867Inst : IEnumerable<long>
{
public static readonly long[] Value=A141867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141867.Bytes);
public long this[int i]=>Value[i];

public static A141867Inst Instance=new A141867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141868
{
public static readonly long[] Value={ 191L,229L,419L,457L,571L,647L,761L,1103L,1217L,1483L,1559L,1597L,1787L,1901L,2053L,2129L,2243L,2281L,2357L,2699L,2851L,2927L,3041L,3079L,3307L,3877L,4219L,4409L,4447L,4523L,4561L,4637L,4751L,4789L,4903L,5701L,6043L,6271L,6689L,6803L,6841L,6917L,7069L,7297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141868Inst : IEnumerable<long>
{
public static readonly long[] Value=A141868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141868.Bytes);
public long this[int i]=>Value[i];

public static A141868Inst Instance=new A141868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141869
{
public static readonly long[] Value={ 2L,59L,97L,173L,211L,401L,439L,743L,857L,971L,1009L,1123L,1237L,1427L,1579L,1693L,1997L,2111L,2339L,2377L,2719L,2833L,2909L,3023L,3061L,3137L,3251L,3517L,3593L,3631L,3821L,4049L,4201L,4391L,4657L,4733L,4999L,5113L,5189L,5227L,5303L,5417L,5531L,5569L,5683L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141869Inst : IEnumerable<long>
{
public static readonly long[] Value=A141869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141869.Bytes);
public long this[int i]=>Value[i];

public static A141869Inst Instance=new A141869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141870
{
public static readonly long[] Value={ 23L,61L,137L,251L,479L,593L,631L,821L,859L,1049L,1087L,1163L,1201L,1277L,1429L,1543L,1619L,1657L,1733L,1847L,1999L,2113L,2341L,2417L,2531L,2683L,2797L,3253L,3329L,3557L,3671L,3709L,3823L,4013L,4051L,4127L,4241L,4507L,4583L,4621L,5039L,5077L,5153L,5381L,5419L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141870Inst : IEnumerable<long>
{
public static readonly long[] Value=A141870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141870.Bytes);
public long this[int i]=>Value[i];

public static A141870Inst Instance=new A141870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141871
{
public static readonly long[] Value={ 101L,139L,367L,443L,557L,709L,823L,937L,1013L,1051L,1279L,1583L,1621L,1697L,1811L,2039L,2153L,2267L,2381L,2609L,2647L,2837L,3217L,3331L,3407L,3559L,3673L,3863L,4091L,4129L,4243L,4357L,4547L,4813L,4889L,5003L,5231L,5573L,5801L,5839L,5953L,6029L,6067L,6143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141871Inst : IEnumerable<long>
{
public static readonly long[] Value=A141871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141871.Bytes);
public long this[int i]=>Value[i];

public static A141871Inst Instance=new A141871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141872
{
public static readonly long[] Value={ 7L,83L,197L,311L,349L,463L,577L,653L,691L,881L,919L,1033L,1109L,1223L,1451L,1489L,1831L,1907L,2287L,2477L,2591L,2819L,2857L,2971L,3313L,3389L,3541L,3617L,3769L,4073L,4111L,4339L,4567L,4643L,4871L,4909L,5023L,5099L,5441L,5479L,5669L,5783L,5821L,5897L,6011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141872Inst : IEnumerable<long>
{
public static readonly long[] Value=A141872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141872.Bytes);
public long this[int i]=>Value[i];

public static A141872Inst Instance=new A141872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141873
{
public static readonly long[] Value={ 103L,179L,293L,331L,521L,673L,787L,863L,977L,1091L,1129L,1319L,1433L,1471L,1699L,1889L,2003L,2269L,2383L,2459L,2687L,2801L,2953L,3067L,3181L,3257L,3371L,3637L,4093L,4283L,4397L,4549L,4663L,4967L,5081L,5119L,5233L,5309L,5347L,5651L,5689L,5879L,6221L,6373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141873Inst : IEnumerable<long>
{
public static readonly long[] Value=A141873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141873.Bytes);
public long this[int i]=>Value[i];

public static A141873Inst Instance=new A141873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141874
{
public static readonly long[] Value={ 47L,199L,313L,389L,503L,541L,617L,769L,883L,997L,1187L,1301L,1453L,1567L,1871L,2099L,2137L,2213L,2251L,2441L,2593L,2707L,2897L,3011L,3049L,3163L,3391L,3467L,3581L,3733L,3847L,3923L,4493L,4721L,4759L,4987L,5101L,5443L,5519L,5557L,5861L,6089L,6203L,6317L,6469L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141874Inst : IEnumerable<long>
{
public static readonly long[] Value=A141874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141874.Bytes);
public long this[int i]=>Value[i];

public static A141874Inst Instance=new A141874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141875
{
public static readonly long[] Value={ 29L,67L,181L,257L,409L,523L,599L,751L,827L,941L,1093L,1283L,1321L,1511L,1549L,1663L,1777L,2081L,2309L,2347L,2423L,2689L,2803L,2879L,2917L,3221L,3259L,3373L,3449L,3677L,3943L,4019L,4057L,4133L,4513L,4703L,4817L,4931L,4969L,5197L,5273L,5387L,5501L,5653L,5843L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141875Inst : IEnumerable<long>
{
public static readonly long[] Value=A141875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141875.Bytes);
public long this[int i]=>Value[i];

public static A141875Inst Instance=new A141875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141876
{
public static readonly long[] Value={ 11L,163L,239L,277L,353L,467L,619L,733L,809L,1151L,1303L,1493L,1531L,1607L,1721L,1759L,1873L,1949L,1987L,2063L,2557L,2633L,2671L,2861L,3089L,3203L,3469L,3583L,3659L,3697L,4001L,4153L,4229L,4457L,4723L,4799L,4951L,5179L,5407L,5483L,5521L,5711L,5749L,5939L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141876Inst : IEnumerable<long>
{
public static readonly long[] Value=A141876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141876.Bytes);
public long this[int i]=>Value[i];

public static A141876Inst Instance=new A141876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141877
{
public static readonly long[] Value={ 31L,107L,373L,449L,487L,563L,601L,677L,829L,1019L,1171L,1361L,1399L,1627L,1741L,1931L,2083L,2273L,2311L,2539L,2729L,2767L,2843L,2957L,3109L,3299L,3413L,3527L,3793L,3907L,4021L,4211L,4363L,4591L,4933L,5009L,5237L,5351L,5503L,5693L,5807L,6073L,6263L,6301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141877Inst : IEnumerable<long>
{
public static readonly long[] Value=A141877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141877.Bytes);
public long this[int i]=>Value[i];

public static A141877Inst Instance=new A141877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141878
{
public static readonly long[] Value={ 13L,89L,127L,241L,317L,431L,659L,773L,811L,887L,1039L,1153L,1229L,1381L,1571L,1609L,1723L,1913L,1951L,2027L,2141L,2179L,2293L,2521L,2711L,2749L,2939L,3167L,3319L,3433L,3547L,3623L,3851L,3889L,4003L,4079L,4231L,4421L,4649L,4801L,4877L,5333L,5827L,5903L,6131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141878Inst : IEnumerable<long>
{
public static readonly long[] Value=A141878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141878.Bytes);
public long this[int i]=>Value[i];

public static A141878Inst Instance=new A141878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141879
{
public static readonly long[] Value={ 71L,109L,223L,337L,641L,907L,983L,1021L,1097L,1249L,1439L,1553L,1667L,1933L,2161L,2237L,2351L,2389L,2503L,2579L,2617L,2693L,2731L,3187L,3301L,3491L,3529L,3643L,3719L,3833L,3947L,4099L,4289L,4327L,4441L,4517L,4783L,4973L,5011L,5087L,5581L,5657L,5923L,6037L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141879Inst : IEnumerable<long>
{
public static readonly long[] Value=A141879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141879.Bytes);
public long this[int i]=>Value[i];

public static A141879Inst Instance=new A141879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141912
{
public static readonly long[] Value={ 31L,307L,353L,491L,859L,997L,1181L,1319L,1549L,1733L,1871L,2239L,2377L,2423L,2699L,2791L,2837L,3067L,3251L,3343L,3389L,3527L,3803L,4079L,4217L,4447L,4493L,4723L,4861L,4999L,5413L,5689L,5827L,6011L,6287L,6379L,6563L,6701L,6793L,6977L,7069L,7207L,7253L,7529L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141912Inst : IEnumerable<long>
{
public static readonly long[] Value=A141912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141912.Bytes);
public long this[int i]=>Value[i];

public static A141912Inst Instance=new A141912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141913
{
public static readonly long[] Value={ 101L,193L,239L,331L,607L,653L,883L,929L,1021L,1297L,1481L,1619L,1987L,2309L,2447L,2539L,2677L,2861L,2953L,2999L,3137L,3229L,3413L,3643L,3919L,4057L,4241L,4517L,4793L,4931L,5023L,5437L,5483L,5851L,5897L,6173L,6311L,6449L,6679L,6863L,7001L,7369L,7507L,7691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141913Inst : IEnumerable<long>
{
public static readonly long[] Value=A141913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141913.Bytes);
public long this[int i]=>Value[i];

public static A141913Inst Instance=new A141913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141914
{
public static readonly long[] Value={ 79L,263L,401L,631L,677L,769L,907L,953L,1091L,1229L,1321L,1367L,1459L,1597L,1873L,2011L,2287L,2333L,2609L,3023L,3253L,3299L,3391L,3529L,3851L,3943L,3989L,4127L,4219L,4357L,4679L,4817L,4909L,5231L,5323L,5507L,5737L,5783L,6151L,6197L,6427L,6473L,6703L,6841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141914Inst : IEnumerable<long>
{
public static readonly long[] Value=A141914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141914.Bytes);
public long this[int i]=>Value[i];

public static A141914Inst Instance=new A141914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141915
{
public static readonly long[] Value={ 11L,103L,149L,241L,379L,563L,701L,839L,977L,1069L,1483L,1621L,1667L,1759L,2081L,2311L,2357L,2633L,2909L,3001L,3323L,3461L,3691L,3967L,4013L,4243L,4289L,4519L,4657L,4703L,4933L,5209L,5347L,5393L,5531L,5623L,5669L,5807L,6037L,6221L,6359L,6451L,6911L,7187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141915Inst : IEnumerable<long>
{
public static readonly long[] Value=A141915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141915.Bytes);
public long this[int i]=>Value[i];

public static A141915Inst Instance=new A141915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141916
{
public static readonly long[] Value={ 127L,173L,311L,449L,541L,587L,863L,1093L,1231L,1277L,1553L,1783L,2243L,2381L,2473L,2657L,2749L,2887L,3163L,3209L,3301L,3347L,3623L,3761L,3853L,4129L,4451L,4957L,5003L,5233L,5279L,5417L,5647L,5693L,5923L,6199L,6337L,6521L,6659L,7027L,7211L,7349L,7487L,7717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141916Inst : IEnumerable<long>
{
public static readonly long[] Value=A141916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141916.Bytes);
public long this[int i]=>Value[i];

public static A141916Inst Instance=new A141916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141917
{
public static readonly long[] Value={ 13L,59L,151L,197L,887L,1117L,1163L,1301L,1439L,1531L,1669L,2083L,2129L,2221L,2267L,2543L,2819L,2957L,3049L,3187L,3371L,3463L,3739L,3877L,3923L,4153L,4337L,4567L,4751L,4889L,5119L,5303L,5441L,5717L,6131L,6269L,6361L,6637L,6959L,7603L,7649L,7741L,7879L,8017L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141917Inst : IEnumerable<long>
{
public static readonly long[] Value=A141917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141917.Bytes);
public long this[int i]=>Value[i];

public static A141917Inst Instance=new A141917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141918
{
public static readonly long[] Value={ 37L,83L,313L,359L,727L,773L,911L,1049L,1187L,1279L,1601L,1693L,1831L,1877L,2153L,2383L,2521L,2659L,2797L,2843L,3119L,3257L,3533L,3671L,3947L,4177L,4591L,4637L,4729L,5051L,5189L,5281L,5419L,5557L,5741L,5879L,6247L,6569L,6661L,6983L,7121L,7213L,7351L,7489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141918Inst : IEnumerable<long>
{
public static readonly long[] Value=A141918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141918.Bytes);
public long this[int i]=>Value[i];

public static A141918Inst Instance=new A141918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141919
{
public static readonly long[] Value={ 61L,107L,199L,337L,383L,521L,613L,659L,751L,797L,1303L,1487L,1579L,1901L,1993L,2039L,2131L,2269L,2591L,2683L,2729L,3373L,3511L,3557L,3833L,4201L,4339L,4523L,4799L,4937L,5167L,5351L,5443L,5581L,5857L,5903L,6133L,6271L,6317L,6547L,6823L,6869L,6961L,7237L,7283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141919Inst : IEnumerable<long>
{
public static readonly long[] Value=A141919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141919.Bytes);
public long this[int i]=>Value[i];

public static A141919Inst Instance=new A141919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141920
{
public static readonly long[] Value={ 131L,223L,269L,499L,683L,821L,1051L,1097L,1327L,1373L,1511L,1741L,1787L,1879L,2017L,2063L,2293L,2339L,2477L,2707L,2753L,3121L,3167L,3259L,3581L,3673L,3719L,4133L,4271L,4363L,4409L,4547L,4639L,5099L,5237L,5651L,5743L,5881L,5927L,6203L,6571L,6709L,7307L,7537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141920Inst : IEnumerable<long>
{
public static readonly long[] Value=A141920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141920.Bytes);
public long this[int i]=>Value[i];

public static A141920Inst Instance=new A141920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141921
{
public static readonly long[] Value={ 17L,109L,293L,431L,523L,569L,661L,937L,983L,1213L,1259L,1489L,1627L,1811L,1949L,2087L,2179L,2593L,2731L,2777L,3191L,3329L,3467L,3559L,3697L,3881L,4019L,4111L,4157L,4663L,4801L,5077L,5261L,5399L,5813L,6043L,6089L,6733L,6779L,6871L,6917L,7193L,7331L,7561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141921Inst : IEnumerable<long>
{
public static readonly long[] Value=A141921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141921.Bytes);
public long this[int i]=>Value[i];

public static A141921Inst Instance=new A141921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141922
{
public static readonly long[] Value={ 41L,179L,271L,317L,409L,547L,593L,823L,1237L,1283L,1559L,1697L,1789L,1973L,2111L,2203L,2341L,2617L,2663L,2801L,2939L,3169L,3307L,3491L,3583L,3767L,4273L,4457L,4549L,4733L,4871L,5009L,5101L,5147L,5653L,5791L,6067L,6113L,6343L,6389L,6481L,6619L,6803L,7079L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141922Inst : IEnumerable<long>
{
public static readonly long[] Value=A141922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141922.Bytes);
public long this[int i]=>Value[i];

public static A141922Inst Instance=new A141922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141923
{
public static readonly long[] Value={ 19L,157L,433L,479L,571L,617L,709L,1031L,1123L,1307L,1399L,1583L,1721L,1951L,1997L,2089L,2273L,2411L,2503L,2549L,2687L,2917L,2963L,3331L,3469L,3607L,3929L,4021L,4159L,4297L,4481L,4987L,5171L,5309L,5861L,5953L,6091L,6229L,6367L,6551L,6689L,6781L,6827L,7057L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141923Inst : IEnumerable<long>
{
public static readonly long[] Value=A141923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141923.Bytes);
public long this[int i]=>Value[i];

public static A141923Inst Instance=new A141923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141924
{
public static readonly long[] Value={ 43L,89L,181L,227L,457L,503L,641L,733L,1009L,1193L,1423L,1607L,1699L,2113L,2251L,2297L,2389L,2711L,2803L,3079L,3217L,3539L,3631L,3677L,3769L,3907L,4091L,4229L,4597L,4643L,4919L,5011L,5333L,5471L,5563L,5701L,5839L,6299L,6529L,7127L,7219L,7541L,7817L,8093L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141924Inst : IEnumerable<long>
{
public static readonly long[] Value=A141924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141924.Bytes);
public long this[int i]=>Value[i];

public static A141924Inst Instance=new A141924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141925
{
public static readonly long[] Value={ 67L,113L,251L,389L,619L,757L,941L,1033L,1171L,1217L,1447L,1493L,1723L,1861L,1907L,1999L,2137L,2459L,2551L,2689L,3011L,3517L,3701L,3793L,3931L,4253L,4391L,4483L,4621L,4759L,4943L,5081L,5449L,6047L,6277L,6323L,6553L,6599L,6691L,6737L,6829L,6967L,7013L,7151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141925Inst : IEnumerable<long>
{
public static readonly long[] Value=A141925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141925.Bytes);
public long this[int i]=>Value[i];

public static A141925Inst Instance=new A141925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141926
{
public static readonly long[] Value={ 137L,229L,367L,643L,827L,919L,1103L,1471L,1609L,1747L,1931L,2069L,2161L,2207L,2437L,2621L,2713L,2851L,2897L,3449L,3541L,3863L,4001L,4093L,4139L,4231L,4507L,4691L,4783L,4967L,5059L,5197L,5381L,5519L,5657L,5749L,6163L,6301L,6577L,6761L,6899L,6991L,7129L,7451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141926Inst : IEnumerable<long>
{
public static readonly long[] Value=A141926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141926.Bytes);
public long this[int i]=>Value[i];

public static A141926Inst Instance=new A141926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141927
{
public static readonly long[] Value={ 101L,151L,251L,401L,601L,701L,751L,1051L,1151L,1201L,1301L,1451L,1601L,1801L,1901L,1951L,2251L,2351L,2551L,2801L,2851L,3001L,3251L,3301L,3701L,3851L,4001L,4051L,4201L,4451L,4651L,4751L,4801L,4951L,5051L,5101L,5351L,5501L,5651L,5701L,5801L,5851L,6101L,6151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141927Inst : IEnumerable<long>
{
public static readonly long[] Value=A141927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141927.Bytes);
public long this[int i]=>Value[i];

public static A141927Inst Instance=new A141927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142056
{
public static readonly long[] Value={ 13L,79L,211L,277L,409L,541L,607L,673L,739L,937L,1069L,1201L,1399L,1531L,1597L,1663L,1861L,1993L,2389L,2521L,2719L,2851L,2917L,3049L,3181L,3313L,3511L,3643L,3709L,3907L,4567L,4831L,5227L,5557L,5623L,5689L,5821L,5953L,6151L,6217L,6481L,6547L,6679L,7207L,7537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142056Inst : IEnumerable<long>
{
public static readonly long[] Value=A142056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142056.Bytes);
public long this[int i]=>Value[i];

public static A142056Inst Instance=new A142056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142057
{
public static readonly long[] Value={ 47L,113L,179L,311L,443L,509L,641L,773L,839L,971L,1103L,1301L,1367L,1433L,1499L,1697L,2027L,2357L,2423L,2621L,2687L,2753L,2819L,3083L,3347L,3413L,3677L,4007L,4073L,4139L,4271L,4337L,4733L,4799L,4931L,5261L,5393L,5591L,5657L,5987L,6053L,6317L,6449L,6581L,6779L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142057Inst : IEnumerable<long>
{
public static readonly long[] Value=A142057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142057.Bytes);
public long this[int i]=>Value[i];

public static A142057Inst Instance=new A142057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142058
{
public static readonly long[] Value={ 181L,313L,379L,577L,643L,709L,907L,1039L,1171L,1237L,1303L,1567L,1699L,1831L,2029L,2161L,2293L,2557L,2689L,2887L,2953L,3019L,3217L,3547L,3613L,3877L,3943L,4273L,4339L,4603L,4801L,4933L,4999L,5197L,5527L,5659L,5791L,5857L,5923L,6121L,6451L,6781L,7177L,7243L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142058Inst : IEnumerable<long>
{
public static readonly long[] Value=A142058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142058.Bytes);
public long this[int i]=>Value[i];

public static A142058Inst Instance=new A142058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142059
{
public static readonly long[] Value={ 17L,83L,149L,281L,347L,479L,677L,743L,809L,941L,1601L,1667L,1733L,1931L,1997L,2063L,2129L,2393L,2459L,2591L,2657L,2789L,3119L,3251L,3449L,3581L,3779L,3911L,4241L,4373L,4637L,4703L,4967L,5099L,5231L,5297L,5693L,6089L,6221L,6287L,6353L,6551L,6947L,7013L,7079L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142059Inst : IEnumerable<long>
{
public static readonly long[] Value=A142059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142059.Bytes);
public long this[int i]=>Value[i];

public static A142059Inst Instance=new A142059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142060
{
public static readonly long[] Value={ 19L,151L,283L,349L,547L,613L,811L,877L,1009L,1471L,1669L,1801L,1867L,1933L,1999L,2131L,2593L,2659L,2791L,2857L,3121L,3187L,3253L,3319L,3517L,3583L,3847L,4111L,4177L,4243L,4441L,4507L,4639L,4903L,4969L,5101L,5167L,5233L,5431L,5563L,5827L,6091L,6421L,6553L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142060Inst : IEnumerable<long>
{
public static readonly long[] Value=A142060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142060.Bytes);
public long this[int i]=>Value[i];

public static A142060Inst Instance=new A142060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142061
{
public static readonly long[] Value={ 53L,251L,317L,383L,449L,647L,911L,977L,1109L,1307L,1373L,1439L,1571L,1637L,1901L,2099L,2297L,2693L,2957L,3023L,3089L,3221L,3617L,3881L,3947L,4013L,4079L,4211L,4409L,4673L,4871L,4937L,5003L,5333L,5399L,5531L,5861L,5927L,6257L,6323L,6389L,6521L,6653L,6719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142061Inst : IEnumerable<long>
{
public static readonly long[] Value=A142061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142061.Bytes);
public long this[int i]=>Value[i];

public static A142061Inst Instance=new A142061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142062
{
public static readonly long[] Value={ 23L,89L,353L,419L,617L,683L,881L,947L,1013L,1277L,1409L,1607L,1871L,2003L,2069L,2267L,2333L,2399L,2531L,2663L,2729L,2861L,2927L,3191L,3257L,3323L,3389L,3719L,3851L,3917L,4049L,4643L,4973L,5039L,5171L,5237L,5303L,5501L,5897L,6029L,6359L,6491L,6689L,7019L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142062Inst : IEnumerable<long>
{
public static readonly long[] Value=A142062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142062.Bytes);
public long this[int i]=>Value[i];

public static A142062Inst Instance=new A142062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142063
{
public static readonly long[] Value={ 157L,223L,421L,487L,619L,751L,883L,1213L,1279L,1543L,1609L,1741L,1873L,2137L,2203L,2269L,2467L,2731L,2797L,3061L,3259L,3391L,3457L,3853L,3919L,4051L,4447L,4513L,4909L,5107L,5437L,5503L,5569L,5701L,6163L,6229L,6361L,6427L,6691L,6823L,7219L,7351L,7417L,7549L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142063Inst : IEnumerable<long>
{
public static readonly long[] Value=A142063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142063.Bytes);
public long this[int i]=>Value[i];

public static A142063Inst Instance=new A142063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142064
{
public static readonly long[] Value={ 59L,191L,257L,389L,521L,587L,653L,719L,983L,1049L,1181L,1511L,1709L,1907L,1973L,2039L,2237L,2633L,2699L,2897L,2963L,3359L,3491L,3557L,3623L,3821L,4019L,4217L,4283L,4349L,4481L,4547L,4679L,4877L,4943L,5009L,5273L,5471L,5669L,5801L,5867L,6131L,6197L,6263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142064Inst : IEnumerable<long>
{
public static readonly long[] Value=A142064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142064.Bytes);
public long this[int i]=>Value[i];

public static A142064Inst Instance=new A142064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142065
{
public static readonly long[] Value={ 61L,127L,193L,457L,523L,787L,853L,919L,1051L,1117L,1249L,1381L,1447L,1579L,1777L,2239L,2371L,2437L,2503L,2767L,2833L,3163L,3229L,3361L,3559L,3691L,3823L,3889L,4021L,4153L,4219L,4483L,4549L,4813L,5011L,5077L,5209L,5407L,5737L,5869L,6067L,6133L,6199L,6397L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142065Inst : IEnumerable<long>
{
public static readonly long[] Value=A142065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142065.Bytes);
public long this[int i]=>Value[i];

public static A142065Inst Instance=new A142065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142066
{
public static readonly long[] Value={ 29L,227L,293L,359L,491L,557L,821L,887L,953L,1019L,1151L,1217L,1283L,1481L,1613L,1811L,1877L,2141L,2207L,2273L,2339L,2801L,2999L,3329L,3461L,3527L,3593L,3659L,3923L,3989L,4253L,4451L,4517L,4583L,4649L,5309L,5441L,5507L,5573L,5639L,5903L,6101L,6299L,6563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142066Inst : IEnumerable<long>
{
public static readonly long[] Value=A142066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142066.Bytes);
public long this[int i]=>Value[i];

public static A142066Inst Instance=new A142066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142067
{
public static readonly long[] Value={ 31L,97L,163L,229L,691L,757L,823L,1021L,1087L,1153L,1483L,1549L,1747L,1879L,2011L,2143L,2341L,2473L,2539L,2671L,2803L,3001L,3067L,3331L,3463L,3529L,3727L,3793L,4057L,4519L,4651L,4783L,5113L,5179L,5443L,5641L,5839L,6037L,6301L,6367L,6763L,6829L,6961L,7027L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142067Inst : IEnumerable<long>
{
public static readonly long[] Value=A142067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142067.Bytes);
public long this[int i]=>Value[i];

public static A142067Inst Instance=new A142067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142068
{
public static readonly long[] Value={ 131L,197L,263L,461L,593L,659L,857L,1187L,1319L,1451L,1583L,1847L,1913L,1979L,2111L,2243L,2309L,2441L,2837L,2903L,2969L,3167L,3299L,3761L,4091L,4157L,4289L,4421L,4751L,4817L,5081L,5147L,5279L,5477L,5741L,5807L,5939L,6203L,6269L,6599L,6863L,7127L,7193L,7457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142068Inst : IEnumerable<long>
{
public static readonly long[] Value=A142068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142068.Bytes);
public long this[int i]=>Value[i];

public static A142068Inst Instance=new A142068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142069
{
public static readonly long[] Value={ 3L,7L,2L,6L,1L,5L,0L,4L,8L,3L,7L,2L,6L,1L,5L,0L,4L,8L,3L,7L,2L,6L,1L,5L,0L,4L,8L,3L,7L,2L,6L,1L,5L,0L,4L,8L,3L,7L,2L,6L,1L,5L,0L,4L,8L,3L,7L,2L,6L,1L,5L,0L,4L,8L,3L,7L,2L,6L,1L,5L,0L,4L,8L,3L,7L,2L,6L,1L,5L,0L,4L,8L,3L,7L,2L,6L,1L,5L,0L,4L,8L,3L,7L,2L,6L,1L,5L,0L,4L,8L,3L,7L,2L,6L,1L,5L,0L,4L,8L,3L,7L,2L,6L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142069Inst : IEnumerable<long>
{
public static readonly long[] Value=A142069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142069.Bytes);
public long this[int i]=>Value[i];

public static A142069Inst Instance=new A142069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142070
{
public static readonly long[] Value={ 1L,-1L,2L,2L,-7L,6L,-6L,29L,-46L,24L,24L,-146L,329L,-326L,120L,-120L,874L,-2521L,3604L,-2556L,720L,720L,-6084L,21244L,-39271L,40564L,-22212L,5040L,-5040L,48348L,-197380L,444849L,-598116L,479996L,-212976L,40320L,40320L,-432144L,2014172L,-5335212L,8788569L,-9223012L,6023772L,-2239344L,362880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142070Inst : IEnumerable<long>
{
public static readonly long[] Value=A142070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142070.Bytes);
public long this[int i]=>Value[i];

public static A142070Inst Instance=new A142070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142071
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,0L,1L,3L,2L,0L,1L,7L,12L,6L,0L,1L,15L,50L,60L,24L,0L,1L,31L,180L,390L,360L,120L,0L,1L,63L,602L,2100L,3360L,2520L,720L,0L,1L,127L,1932L,10206L,25200L,31920L,20160L,5040L,0L,1L,255L,6050L,46620L,166824L,317520L,332640L,181440L,40320L,0L,1L,511L,18660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142071Inst : IEnumerable<long>
{
public static readonly long[] Value=A142071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142071.Bytes);
public long this[int i]=>Value[i];

public static A142071Inst Instance=new A142071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142088
{
public static readonly long[] Value={ 53L,193L,263L,613L,683L,823L,1033L,1103L,1453L,1523L,1663L,1733L,1873L,2083L,2153L,2293L,2503L,2713L,3203L,3343L,3413L,3623L,3833L,4253L,4463L,4603L,4673L,4813L,5023L,5233L,5303L,5443L,5653L,6073L,6143L,6353L,6563L,6703L,6983L,7193L,7333L,7753L,7823L,7963L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142088Inst : IEnumerable<long>
{
public static readonly long[] Value=A142088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142088.Bytes);
public long this[int i]=>Value[i];

public static A142088Inst Instance=new A142088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142089
{
public static readonly long[] Value={ 19L,89L,229L,439L,509L,719L,859L,929L,1069L,1279L,1489L,1559L,1699L,1979L,2399L,2539L,2609L,2749L,2819L,3169L,3449L,3659L,4079L,4219L,4289L,4639L,4919L,5059L,5479L,5689L,6389L,6529L,6599L,6949L,7019L,7159L,7229L,7369L,7649L,7789L,8069L,8209L,8419L,8629L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142089Inst : IEnumerable<long>
{
public static readonly long[] Value=A142089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142089.Bytes);
public long this[int i]=>Value[i];

public static A142089Inst Instance=new A142089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142090
{
public static readonly long[] Value={ 127L,197L,337L,547L,617L,757L,827L,967L,1597L,1667L,1877L,2017L,2087L,2297L,2437L,2647L,2857L,2927L,3067L,3137L,3347L,3557L,3697L,3767L,3907L,4327L,4397L,4817L,4957L,5167L,5237L,5657L,5867L,6007L,6217L,6287L,6427L,6637L,6917L,7057L,7127L,7477L,7547L,7687L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142090Inst : IEnumerable<long>
{
public static readonly long[] Value=A142090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142090.Bytes);
public long this[int i]=>Value[i];

public static A142090Inst Instance=new A142090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142091
{
public static readonly long[] Value={ 23L,163L,233L,373L,443L,653L,863L,1213L,1283L,1423L,1493L,1913L,2053L,2333L,2473L,2543L,2683L,2753L,2963L,3313L,3593L,3733L,3803L,3943L,4013L,4153L,4363L,4643L,4783L,4993L,5273L,5413L,5483L,5623L,5693L,5903L,6043L,6113L,6323L,6673L,6883L,7583L,7723L,7793L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142091Inst : IEnumerable<long>
{
public static readonly long[] Value=A142091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142091.Bytes);
public long this[int i]=>Value[i];

public static A142091Inst Instance=new A142091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142092
{
public static readonly long[] Value={ 59L,199L,269L,409L,479L,619L,829L,1039L,1109L,1249L,1319L,1459L,1669L,1879L,1949L,2089L,2579L,2719L,2789L,2999L,3209L,3559L,3769L,4049L,4259L,4679L,4889L,5099L,5309L,5449L,5519L,5659L,5869L,5939L,6079L,6359L,6569L,6709L,6779L,7129L,7549L,7759L,7829L,8039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142092Inst : IEnumerable<long>
{
public static readonly long[] Value=A142092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142092.Bytes);
public long this[int i]=>Value[i];

public static A142092Inst Instance=new A142092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142093
{
public static readonly long[] Value={ 61L,131L,271L,691L,761L,971L,1181L,1321L,1531L,1601L,1741L,1811L,1951L,2161L,2371L,2441L,2791L,2861L,3001L,3491L,3631L,3701L,3911L,4051L,4261L,4751L,5101L,5171L,5381L,5521L,5591L,5801L,6011L,6151L,6221L,6361L,6571L,6781L,6991L,7411L,7481L,7621L,7691L,7901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142093Inst : IEnumerable<long>
{
public static readonly long[] Value=A142093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142093.Bytes);
public long this[int i]=>Value[i];

public static A142093Inst Instance=new A142093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142094
{
public static readonly long[] Value={ 97L,167L,307L,587L,727L,797L,937L,1217L,1427L,1567L,1637L,1777L,1847L,1987L,2267L,2477L,2617L,2687L,2897L,3037L,3457L,3527L,3877L,3947L,4157L,4297L,4507L,4787L,5347L,5417L,5557L,6047L,6257L,6397L,6607L,7027L,7237L,7307L,7517L,7727L,7867L,7937L,8147L,8287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142094Inst : IEnumerable<long>
{
public static readonly long[] Value=A142094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142094.Bytes);
public long this[int i]=>Value[i];

public static A142094Inst Instance=new A142094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142095
{
public static readonly long[] Value={ 29L,239L,379L,449L,659L,1009L,1289L,1429L,1499L,1709L,2129L,2269L,2339L,2549L,2689L,2969L,3109L,3319L,3389L,3529L,3739L,4019L,4159L,4229L,4649L,4789L,4999L,5209L,5279L,5419L,5839L,6329L,6469L,6679L,6959L,7309L,7589L,8009L,8219L,8429L,8779L,8849L,9059L,9199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142095Inst : IEnumerable<long>
{
public static readonly long[] Value=A142095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142095.Bytes);
public long this[int i]=>Value[i];

public static A142095Inst Instance=new A142095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142096
{
public static readonly long[] Value={ 31L,101L,241L,311L,521L,661L,941L,1151L,1291L,1361L,1571L,2131L,2341L,2411L,2551L,2621L,2971L,3041L,3181L,3251L,3391L,3461L,3671L,3881L,4021L,4091L,4231L,4441L,4651L,4721L,4861L,4931L,5281L,5351L,5701L,5981L,6121L,6961L,7451L,7591L,8011L,8081L,8221L,8291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142096Inst : IEnumerable<long>
{
public static readonly long[] Value=A142096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142096.Bytes);
public long this[int i]=>Value[i];

public static A142096Inst Instance=new A142096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142097
{
public static readonly long[] Value={ 67L,137L,277L,347L,487L,557L,907L,977L,1117L,1187L,1327L,1607L,1747L,2027L,2237L,2377L,2447L,2657L,2797L,3217L,3637L,3847L,3917L,4057L,4127L,4337L,4547L,4967L,5107L,5387L,5527L,5737L,5807L,6367L,6577L,6857L,6997L,7207L,7417L,7487L,7907L,8117L,8467L,8537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142097Inst : IEnumerable<long>
{
public static readonly long[] Value=A142097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142097.Bytes);
public long this[int i]=>Value[i];

public static A142097Inst Instance=new A142097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142098
{
public static readonly long[] Value={ 103L,173L,313L,383L,523L,593L,733L,1013L,1153L,1223L,1433L,1783L,1993L,2063L,2203L,2273L,2693L,2833L,2903L,3253L,3323L,3463L,3533L,3673L,4093L,4373L,4513L,4583L,4723L,4793L,4933L,5003L,5563L,5843L,6053L,6263L,6473L,6823L,7103L,7243L,7523L,7873L,8293L,8363L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142098Inst : IEnumerable<long>
{
public static readonly long[] Value=A142098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142098.Bytes);
public long this[int i]=>Value[i];

public static A142098Inst Instance=new A142098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142099
{
public static readonly long[] Value={ 139L,349L,419L,769L,839L,1049L,1259L,1399L,1609L,1889L,2029L,2099L,2239L,2309L,2659L,2729L,2939L,3079L,3359L,3499L,3709L,3779L,3919L,3989L,4129L,4339L,4409L,4549L,4759L,4969L,5039L,5179L,5669L,5879L,6089L,6229L,6299L,6719L,7069L,7349L,7489L,7559L,7699L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142099Inst : IEnumerable<long>
{
public static readonly long[] Value=A142099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142099.Bytes);
public long this[int i]=>Value[i];

public static A142099Inst Instance=new A142099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142100
{
public static readonly long[] Value={ 37L,73L,109L,181L,397L,433L,541L,577L,613L,757L,829L,937L,1009L,1117L,1153L,1297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142100Inst : IEnumerable<long>
{
public static readonly long[] Value=A142100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142100.Bytes);
public long this[int i]=>Value[i];

public static A142100Inst Instance=new A142100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142101
{
public static readonly long[] Value={ 5L,41L,113L,149L,257L,293L,401L,509L,617L,653L,761L,797L,941L,977L,1013L,1049L,1193L,1229L,1301L,1373L,1409L,1481L,1553L,1697L,1733L,1877L,1913L,1949L,2129L,2237L,2273L,2309L,2381L,2417L,2633L,2741L,2777L,2957L,3137L,3209L,3389L,3461L,3533L,3677L,3821L,3929L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142101Inst : IEnumerable<long>
{
public static readonly long[] Value=A142101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142101.Bytes);
public long this[int i]=>Value[i];

public static A142101Inst Instance=new A142101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142102
{
public static readonly long[] Value={ 7L,43L,79L,151L,223L,331L,367L,439L,547L,619L,691L,727L,907L,1051L,1087L,1123L,1231L,1303L,1447L,1483L,1627L,1663L,1699L,1879L,1951L,1987L,2131L,2203L,2239L,2311L,2347L,2383L,2671L,2707L,2851L,2887L,3067L,3319L,3391L,3463L,3499L,3571L,3607L,3643L,3823L,3931L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142102Inst : IEnumerable<long>
{
public static readonly long[] Value=A142102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142102.Bytes);
public long this[int i]=>Value[i];

public static A142102Inst Instance=new A142102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142103
{
public static readonly long[] Value={ 11L,47L,83L,191L,227L,263L,443L,479L,587L,659L,839L,911L,947L,983L,1019L,1091L,1163L,1307L,1451L,1487L,1523L,1559L,1667L,1811L,1847L,2027L,2063L,2099L,2207L,2243L,2351L,2423L,2459L,2531L,2711L,2819L,2927L,2963L,2999L,3251L,3323L,3359L,3467L,3539L,3719L,3863L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142103Inst : IEnumerable<long>
{
public static readonly long[] Value=A142103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142103.Bytes);
public long this[int i]=>Value[i];

public static A142103Inst Instance=new A142103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142152
{
public static readonly long[] Value={ 59L,97L,173L,211L,401L,439L,743L,857L,971L,1009L,1123L,1237L,1427L,1579L,1693L,1997L,2111L,2339L,2377L,2719L,2833L,2909L,3023L,3061L,3137L,3251L,3517L,3593L,3631L,3821L,4049L,4201L,4391L,4657L,4733L,4999L,5113L,5189L,5227L,5303L,5417L,5531L,5569L,5683L,5987L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142152Inst : IEnumerable<long>
{
public static readonly long[] Value=A142152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142152.Bytes);
public long this[int i]=>Value[i];

public static A142152Inst Instance=new A142152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142153
{
public static readonly long[] Value={ 1L,2L,5L,18L,87L,451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142153Inst : IEnumerable<long>
{
public static readonly long[] Value=A142153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142153.Bytes);
public long this[int i]=>Value[i];

public static A142153Inst Instance=new A142153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142154
{
public static readonly long[] Value={ 4L,4L,6L,0L,-2L,12L,0L,-8L,30L,0L,-30L,0L,4L,90L,0L,-120L,0L,34L,315L,0L,-525L,0L,231L,0L,-17L,1260L,0L,-2520L,0L,1512L,0L,-248L,5670L,0L,-13230L,0L,10080L,0L,-2640L,0L,124L,28350L,0L,-75600L,0L,69930L,0L,-25440L,0L,2764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142154Inst : IEnumerable<long>
{
public static readonly long[] Value=A142154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142154.Bytes);
public long this[int i]=>Value[i];

public static A142154Inst Instance=new A142154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142155
{
public static readonly long[] Value={ 1L,-1L,2L,-3L,6L,-9L,17L,-27L,48L,-80L,139L,-233L,402L,-680L,1165L,-1979L,3382L,-5754L,9822L,-16727L,28531L,-48613L,82893L,-141268L,240847L,-410505L,699808L,-1192838L,2033410L,-3466085L,5908459L,-10071512L,17168221L,-29265017L,49885842L,-85035890L,144953845L,-247090156L,421194210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142155Inst : IEnumerable<long>
{
public static readonly long[] Value=A142155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142155.Bytes);
public long this[int i]=>Value[i];

public static A142155Inst Instance=new A142155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142156
{
public static readonly long[] Value={ 1L,1L,-1L,2L,-1L,-1L,6L,-2L,-1L,-3L,24L,-6L,-2L,-3L,-13L,120L,-24L,-6L,-6L,-13L,-71L,720L,-120L,-24L,-18L,-26L,-71L,-461L,5040L,-720L,-120L,-72L,-78L,-142L,-461L,-3447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142156Inst : IEnumerable<long>
{
public static readonly long[] Value=A142156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142156.Bytes);
public long this[int i]=>Value[i];

public static A142156Inst Instance=new A142156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142157
{
public static readonly long[] Value={ 1L,1L,3L,3L,1L,1L,7L,3L,3L,5L,3L,7L,5L,3L,3L,3L,3L,1L,3L,5L,1L,7L,9L,1L,5L,1L,7L,7L,3L,7L,7L,3L,9L,5L,1L,3L,9L,9L,1L,5L,3L,5L,5L,7L,1L,5L,1L,5L,9L,5L,3L,3L,5L,1L,9L,7L,9L,9L,5L,5L,5L,9L,1L,1L,3L,3L,1L,1L,7L,3L,3L,5L,3L,7L,5L,3L,3L,3L,3L,1L,3L,5L,1L,7L,9L,1L,5L,1L,7L,7L,3L,7L,7L,3L,9L,5L,1L,3L,9L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142157Inst : IEnumerable<long>
{
public static readonly long[] Value=A142157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142157.Bytes);
public long this[int i]=>Value[i];

public static A142157Inst Instance=new A142157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142158
{
public static readonly long[] Value={ 0L,1L,1L,4L,-3L,1L,27L,-44L,31L,-8L,256L,-655L,731L,-389L,81L,3125L,-10974L,17026L,-13934L,5901L,-1024L,46656L,-208943L,418377L,-465898L,300182L,-105279L,15625L,823543L,-4491192L,11064957L,-15661904L,13617801L,-7229592L,2161363L,-279936L,16777216L,-107948223L,316559287L,-545245307L,598756419L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142158Inst : IEnumerable<long>
{
public static readonly long[] Value=A142158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142158.Bytes);
public long this[int i]=>Value[i];

public static A142158Inst Instance=new A142158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142159
{
public static readonly long[] Value={ 79L,157L,313L,547L,859L,937L,1093L,1171L,1249L,1327L,1483L,1873L,1951L,2029L,2341L,2731L,2887L,3121L,3433L,3511L,3823L,4057L,4447L,4603L,4759L,4993L,5227L,5851L,6007L,6163L,6397L,6553L,6709L,7177L,7333L,7411L,7489L,7723L,7879L,8191L,8269L,8581L,8737L,8893L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142159Inst : IEnumerable<long>
{
public static readonly long[] Value=A142159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142159.Bytes);
public long this[int i]=>Value[i];

public static A142159Inst Instance=new A142159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142160
{
public static readonly long[] Value={ 2L,41L,197L,353L,431L,509L,587L,743L,821L,977L,1289L,1367L,1523L,1601L,1913L,2069L,2381L,2459L,2693L,2927L,3083L,3863L,4019L,4253L,4409L,4643L,4721L,4799L,4877L,5189L,5501L,5657L,5813L,6047L,6203L,6359L,6827L,6983L,7451L,7529L,7607L,7841L,7919L,8231L,8387L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142160Inst : IEnumerable<long>
{
public static readonly long[] Value=A142160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142160.Bytes);
public long this[int i]=>Value[i];

public static A142160Inst Instance=new A142160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142161
{
public static readonly long[] Value={ 43L,199L,277L,433L,823L,1213L,1291L,1447L,1759L,1993L,2383L,2539L,2617L,2851L,3163L,3319L,3631L,3709L,3943L,4021L,4099L,4177L,4567L,4723L,4801L,4957L,5113L,5347L,5503L,5581L,5659L,5737L,6361L,6673L,6829L,6907L,7219L,7297L,7687L,8233L,8311L,8389L,8467L,8623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142161Inst : IEnumerable<long>
{
public static readonly long[] Value=A142161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142161.Bytes);
public long this[int i]=>Value[i];

public static A142161Inst Instance=new A142161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142162
{
public static readonly long[] Value={ 5L,83L,239L,317L,863L,941L,1019L,1097L,1409L,1487L,1721L,1877L,2111L,2267L,2423L,2579L,2657L,2969L,3203L,3359L,3593L,3671L,4139L,4217L,4373L,4451L,4919L,5153L,5231L,5309L,5387L,6011L,6089L,6323L,6791L,6869L,6947L,7103L,7649L,7727L,7883L,8039L,8117L,8273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142162Inst : IEnumerable<long>
{
public static readonly long[] Value=A142162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142162.Bytes);
public long this[int i]=>Value[i];

public static A142162Inst Instance=new A142162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142163
{
public static readonly long[] Value={ 7L,163L,241L,397L,631L,709L,787L,1021L,1489L,1567L,1723L,1801L,1879L,2113L,2269L,2347L,2503L,2659L,2971L,3049L,3361L,3517L,3673L,3907L,4219L,4297L,4999L,5077L,5233L,5623L,5701L,5779L,5857L,6091L,6247L,6481L,6637L,6793L,6871L,6949L,7027L,7417L,7573L,7963L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142163Inst : IEnumerable<long>
{
public static readonly long[] Value=A142163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142163.Bytes);
public long this[int i]=>Value[i];

public static A142163Inst Instance=new A142163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142164
{
public static readonly long[] Value={ 47L,281L,359L,593L,827L,983L,1061L,1217L,1373L,1451L,1607L,1997L,2153L,2309L,2543L,2621L,2699L,2777L,3011L,3089L,3167L,3323L,3557L,3947L,4259L,4337L,4493L,4649L,5039L,5273L,5351L,5507L,5741L,5897L,6053L,6131L,6287L,6521L,6599L,6833L,6911L,7457L,7691L,8081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142164Inst : IEnumerable<long>
{
public static readonly long[] Value=A142164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142164.Bytes);
public long this[int i]=>Value[i];

public static A142164Inst Instance=new A142164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142165
{
public static readonly long[] Value={ 127L,283L,439L,673L,751L,829L,907L,1063L,1297L,1453L,1531L,1609L,1999L,2311L,2389L,2467L,2857L,3169L,3559L,3637L,3793L,4027L,4261L,4339L,4651L,4729L,5119L,5197L,5431L,5743L,5821L,6133L,6211L,6367L,6679L,6991L,7069L,7459L,7537L,7927L,8161L,8317L,8629L,8707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142165Inst : IEnumerable<long>
{
public static readonly long[] Value=A142165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142165.Bytes);
public long this[int i]=>Value[i];

public static A142165Inst Instance=new A142165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142166
{
public static readonly long[] Value={ 11L,89L,167L,401L,479L,557L,947L,1103L,1181L,1259L,1493L,1571L,2039L,2273L,2351L,2663L,2741L,2819L,2897L,3209L,3677L,3833L,3911L,3989L,4457L,4691L,5003L,5081L,5237L,5393L,5471L,5783L,5861L,5939L,6173L,6329L,6563L,6719L,7109L,7187L,7499L,7577L,8123L,8513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142166Inst : IEnumerable<long>
{
public static readonly long[] Value=A142166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142166.Bytes);
public long this[int i]=>Value[i];

public static A142166Inst Instance=new A142166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142167
{
public static readonly long[] Value={ 53L,131L,443L,521L,599L,677L,911L,1223L,1301L,1613L,1847L,2003L,2081L,2237L,2393L,2549L,2861L,2939L,3251L,3329L,3407L,3719L,3797L,4421L,4733L,4889L,4967L,5279L,5591L,5669L,5903L,5981L,6449L,6761L,6917L,7151L,7229L,7307L,7541L,7853L,8009L,8087L,8243L,8867L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142167Inst : IEnumerable<long>
{
public static readonly long[] Value=A142167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142167.Bytes);
public long this[int i]=>Value[i];

public static A142167Inst Instance=new A142167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142232
{
public static readonly long[] Value={ 199L,281L,691L,773L,937L,1019L,1429L,1511L,2003L,2659L,2741L,3643L,3889L,4217L,4463L,5119L,5693L,5857L,5939L,6841L,7333L,7907L,8317L,8563L,9137L,9547L,9629L,10039L,10531L,10613L,10859L,11351L,11597L,12007L,12253L,13729L,14057L,14221L,14303L,14549L,14713L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142232Inst : IEnumerable<long>
{
public static readonly long[] Value=A142232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142232.Bytes);
public long this[int i]=>Value[i];

public static A142232Inst Instance=new A142232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142233
{
public static readonly long[] Value={ 241L,487L,569L,733L,1061L,1307L,1471L,1553L,3767L,3931L,4013L,4177L,4259L,4423L,4751L,5407L,5653L,5981L,6473L,6637L,6719L,6883L,7129L,7211L,7457L,7621L,7703L,7867L,7949L,8933L,9343L,10163L,11311L,11393L,12049L,12377L,12541L,13033L,14591L,15083L,15329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142233Inst : IEnumerable<long>
{
public static readonly long[] Value=A142233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142233.Bytes);
public long this[int i]=>Value[i];

public static A142233Inst Instance=new A142233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142234
{
public static readonly long[] Value={ 37L,283L,857L,1021L,1103L,1759L,2087L,2251L,2333L,2579L,3727L,4219L,4547L,4793L,4957L,5039L,5449L,5531L,6269L,6679L,6761L,7253L,7417L,7499L,8237L,8647L,8893L,9221L,9467L,9631L,10369L,10861L,11353L,11681L,11927L,12583L,12829L,12911L,13567L,13649L,14387L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142234Inst : IEnumerable<long>
{
public static readonly long[] Value=A142234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142234.Bytes);
public long this[int i]=>Value[i];

public static A142234Inst Instance=new A142234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142235
{
public static readonly long[] Value={ 79L,571L,653L,1063L,1637L,1801L,2129L,2293L,2539L,2621L,3359L,3769L,3851L,4261L,4507L,4999L,5081L,5573L,5737L,6229L,6311L,6803L,6967L,7213L,7459L,7541L,7951L,8443L,8689L,9181L,10247L,10657L,10739L,10903L,11149L,11887L,11969L,12379L,12953L,13691L,14347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142235Inst : IEnumerable<long>
{
public static readonly long[] Value=A142235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142235.Bytes);
public long this[int i]=>Value[i];

public static A142235Inst Instance=new A142235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142236
{
public static readonly long[] Value={ 367L,449L,613L,859L,941L,1187L,1433L,1597L,2089L,2417L,2663L,2909L,3319L,4057L,4139L,4549L,4877L,5779L,5861L,6271L,6353L,6599L,6763L,7583L,7829L,7993L,8731L,9059L,9551L,10289L,10453L,10781L,11027L,11273L,11437L,11519L,12011L,12421L,12503L,13159L,13241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142236Inst : IEnumerable<long>
{
public static readonly long[] Value=A142236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142236.Bytes);
public long this[int i]=>Value[i];

public static A142236Inst Instance=new A142236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142237
{
public static readonly long[] Value={ 163L,409L,491L,983L,1229L,1721L,2131L,2213L,2377L,2459L,3361L,3607L,3853L,4099L,4591L,4673L,4919L,5657L,5821L,5903L,6067L,7297L,7789L,8117L,8363L,8527L,8609L,9511L,9839L,10331L,10987L,11069L,11807L,11971L,12791L,13037L,13693L,14431L,14759L,14923L,15497L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142237Inst : IEnumerable<long>
{
public static readonly long[] Value=A142237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142237.Bytes);
public long this[int i]=>Value[i];

public static A142237Inst Instance=new A142237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142238
{
public static readonly long[] Value={ 1L,5L,11L,49L,109L,485L,1079L,4801L,10681L,47525L,105731L,470449L,1046629L,4656965L,10360559L,46099201L,102558961L,456335045L,1015229051L,4517251249L,10049731549L,44716177445L,99482086439L,442644523201L,984771132841L,4381729054565L,9748229241971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142238Inst : IEnumerable<long>
{
public static readonly long[] Value=A142238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142238.Bytes);
public long this[int i]=>Value[i];

public static A142238Inst Instance=new A142238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142239
{
public static readonly long[] Value={ 1L,4L,9L,40L,89L,396L,881L,3920L,8721L,38804L,86329L,384120L,854569L,3802396L,8459361L,37639840L,83739041L,372596004L,828931049L,3688320200L,8205571449L,36510605996L,81226783441L,361417739760L,804062262961L,3577666791604L,7959395846169L,35415250176280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142239Inst : IEnumerable<long>
{
public static readonly long[] Value=A142239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142239.Bytes);
public long this[int i]=>Value[i];

public static A142239Inst Instance=new A142239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142240
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,2L,2L,4L,4L,2L,2L,5L,6L,5L,2L,2L,6L,8L,8L,6L,2L,2L,7L,10L,11L,10L,7L,2L,2L,8L,12L,14L,14L,12L,8L,2L,2L,9L,14L,17L,18L,17L,14L,9L,2L,2L,10L,16L,20L,22L,22L,20L,16L,10L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142240Inst : IEnumerable<long>
{
public static readonly long[] Value=A142240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142240.Bytes);
public long this[int i]=>Value[i];

public static A142240Inst Instance=new A142240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142241
{
public static readonly long[] Value={ 14L,38L,62L,86L,110L,134L,158L,182L,206L,230L,254L,278L,302L,326L,350L,374L,398L,422L,446L,470L,494L,518L,542L,566L,590L,614L,638L,662L,686L,710L,734L,758L,782L,806L,830L,854L,878L,902L,926L,950L,974L,998L,1022L,1046L,1070L,1094L,1118L,1142L,1166L,1190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142241Inst : IEnumerable<long>
{
public static readonly long[] Value=A142241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142241.Bytes);
public long this[int i]=>Value[i];

public static A142241Inst Instance=new A142241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142242
{
public static readonly long[] Value={ 2L,2L,0L,2L,0L,0L,-4L,2L,0L,0L,-4L,0L,-4L,-4L,-12L,2L,0L,0L,-4L,0L,-4L,-4L,-12L,0L,-4L,-4L,-12L,-4L,-12L,-12L,-28L,2L,0L,0L,-4L,0L,-4L,-4L,-12L,0L,-4L,-4L,-12L,-4L,-12L,-12L,-28L,0L,-4L,-4L,-12L,-4L,-12L,-12L,-28L,-4L,-12L,-12L,-28L,-12L,-28L,-28L,-60L,2L,0L,0L,-4L,0L,-4L,-4L,-12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142242Inst : IEnumerable<long>
{
public static readonly long[] Value=A142242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142242.Bytes);
public long this[int i]=>Value[i];

public static A142242Inst Instance=new A142242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142243
{
public static readonly long[] Value={ 1L,2L,2L,6L,8L,6L,20L,36L,30L,20L,70L,160L,168L,112L,70L,252L,700L,900L,720L,420L,252L,924L,3024L,4620L,4400L,2970L,1584L,924L,3432L,12936L,22932L,25480L,20020L,12012L,6006L,3432L,12870L,54912L,110880L,141120L,127400L,87360L,48048L,22880L,12870L,48620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142243Inst : IEnumerable<long>
{
public static readonly long[] Value=A142243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142243.Bytes);
public long this[int i]=>Value[i];

public static A142243Inst Instance=new A142243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142244
{
public static readonly long[] Value={ 23L,107L,149L,191L,233L,317L,359L,401L,443L,569L,653L,821L,863L,947L,1031L,1283L,1367L,1409L,1451L,1493L,1619L,1787L,1871L,1913L,1997L,2039L,2081L,2207L,2333L,2417L,2459L,2543L,2711L,2753L,2837L,2879L,2963L,3089L,3257L,3299L,3467L,3593L,3677L,3719L,3761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142244Inst : IEnumerable<long>
{
public static readonly long[] Value=A142244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142244.Bytes);
public long this[int i]=>Value[i];

public static A142244Inst Instance=new A142244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142245
{
public static readonly long[] Value={ 0L,12L,34L,68L,124L,214L,360L,596L,978L,1596L,2596L,4214L,6832L,11068L,17922L,29012L,46956L,75990L,122968L,198980L,321970L,520972L,842964L,1363958L,2206944L,3570924L,5777890L,9348836L,15126748L,24475606L,39602376L,64078004L,103680402L,167758428L,271438852L,439197302L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142245Inst : IEnumerable<long>
{
public static readonly long[] Value=A142245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142245.Bytes);
public long this[int i]=>Value[i];

public static A142245Inst Instance=new A142245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142246
{
public static readonly long[] Value={ 3L,2L,3L,3L,3L,3L,2L,3L,3L,2L,2L,3L,7L,2L,3L,2L,2L,3L,3L,2L,3L,3L,3L,3L,2L,2L,2L,7L,3L,2L,7L,2L,3L,3L,3L,3L,3L,3L,2L,2L,3L,3L,2L,2L,2L,2L,3L,3L,3L,2L,3L,3L,3L,3L,3L,2L,3L,3L,3L,13L,2L,2L,7L,3L,3L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,3L,2L,3L,3L,3L,2L,3L,2L,2L,3L,3L,7L,3L,3L,7L,2L,2L,7L,3L,3L,7L,2L,3L,3L,2L,3L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142246Inst : IEnumerable<long>
{
public static readonly long[] Value=A142246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142246.Bytes);
public long this[int i]=>Value[i];

public static A142246Inst Instance=new A142246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142247
{
public static readonly BigInteger[] Value={ 3L,5L,7L,11L,29L,31L,127L,131L,8191L,131071L,524287L,536870909L,2147483647L,2305843009213693951L,BigInteger.Parse("147573952589676412931"),BigInteger.Parse("618970019642690137449562111"),BigInteger.Parse("162259276829213363391578010288127") };
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
public class A142247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142247Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A142247.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A142247.Bytes);
public BigInteger this[int i]=>Value[i];

public static A142247Inst Instance=new A142247Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142280
{
public static readonly long[] Value={ 31L,461L,547L,719L,977L,1063L,1321L,1493L,1579L,2267L,3041L,3299L,3557L,3643L,4073L,4159L,4933L,5449L,5879L,6481L,6653L,6911L,6997L,8287L,8803L,9319L,9491L,9749L,10007L,10093L,10781L,10867L,11383L,11813L,12071L,12157L,12329L,13103L,13619L,13877L,13963L,14221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142280Inst : IEnumerable<long>
{
public static readonly long[] Value=A142280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142280.Bytes);
public long this[int i]=>Value[i];

public static A142280Inst Instance=new A142280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142281
{
public static readonly long[] Value={ 419L,677L,1021L,1193L,1279L,1451L,1709L,2053L,2311L,2741L,2999L,3257L,3343L,4289L,4547L,5407L,5923L,6353L,6869L,7127L,7213L,7643L,7901L,8761L,8933L,9277L,10223L,10567L,10739L,11083L,12373L,12889L,13147L,13577L,13921L,14437L,14867L,15383L,15641L,15727L,16673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142281Inst : IEnumerable<long>
{
public static readonly long[] Value=A142281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142281.Bytes);
public long this[int i]=>Value[i];

public static A142281Inst Instance=new A142281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142282
{
public static readonly long[] Value={ 463L,1151L,1237L,1409L,1667L,1753L,2011L,2269L,2441L,2699L,2957L,3301L,3559L,3989L,4591L,5021L,5107L,5279L,5623L,5881L,6053L,6311L,6397L,6569L,6827L,7687L,8117L,8461L,8719L,9923L,10009L,10181L,10267L,11213L,11299L,11471L,11987L,12073L,12503L,12589L,13879L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142282Inst : IEnumerable<long>
{
public static readonly long[] Value=A142282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142282.Bytes);
public long this[int i]=>Value[i];

public static A142282Inst Instance=new A142282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142283
{
public static readonly long[] Value={ 163L,421L,593L,937L,1109L,1367L,1453L,2141L,2399L,2657L,3001L,3259L,3517L,3947L,4463L,4549L,4721L,5237L,5323L,5581L,5839L,6011L,6269L,6871L,7043L,7129L,7559L,7817L,8161L,8419L,8677L,8849L,9623L,9967L,10139L,11171L,11257L,12203L,12289L,12547L,13063L,13751L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142283Inst : IEnumerable<long>
{
public static readonly long[] Value=A142283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142283.Bytes);
public long this[int i]=>Value[i];

public static A142283Inst Instance=new A142283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142284
{
public static readonly long[] Value={ 293L,379L,809L,1153L,1583L,1669L,2099L,2357L,3217L,3389L,3733L,4421L,4507L,4679L,4937L,5023L,5281L,5711L,6571L,6829L,7001L,7517L,7603L,8291L,8377L,8807L,8893L,9151L,9323L,9839L,10613L,10957L,11731L,11903L,12161L,12763L,13451L,13537L,13709L,13967L,14741L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142284Inst : IEnumerable<long>
{
public static readonly long[] Value=A142284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142284.Bytes);
public long this[int i]=>Value[i];

public static A142284Inst Instance=new A142284Inst();

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