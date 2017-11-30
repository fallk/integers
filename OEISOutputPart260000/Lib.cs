using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A141987
{
public static readonly long[] Value={ 11L,127L,359L,823L,881L,997L,1171L,1229L,1693L,1867L,2099L,2273L,2389L,2447L,2621L,2969L,3259L,3433L,3491L,3607L,4013L,4129L,4651L,4999L,5231L,5347L,5521L,5869L,5927L,6043L,6101L,6217L,6449L,6971L,7841L,8363L,8537L,9001L,9059L,9349L,9697L,9871L,9929L,10103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141987Inst : IEnumerable<long>
{
public static readonly long[] Value=A141987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141987.Bytes);
public long this[int i]=>Value[i];

public static A141987Inst Instance=new A141987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141988
{
public static readonly long[] Value={ 41L,157L,331L,389L,563L,853L,911L,1201L,1259L,1433L,1549L,1607L,1723L,2129L,2477L,2593L,2767L,2999L,3347L,3463L,3637L,4159L,4217L,4391L,4507L,5087L,5261L,5783L,6073L,6131L,6247L,6421L,6653L,6827L,7001L,7349L,7523L,7639L,8161L,8219L,8741L,9437L,9901L,10133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141988Inst : IEnumerable<long>
{
public static readonly long[] Value=A141988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141988.Bytes);
public long this[int i]=>Value[i];

public static A141988Inst Instance=new A141988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141989
{
public static readonly long[] Value={ 13L,71L,419L,593L,709L,883L,941L,1231L,1289L,1579L,1637L,1753L,1811L,2333L,2797L,2971L,3203L,3319L,4073L,4363L,4421L,4943L,5059L,5233L,5407L,5581L,5639L,5813L,5987L,6277L,6451L,6857L,7321L,7669L,7727L,7901L,8017L,8191L,8423L,8539L,8597L,8713L,8887L,9293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141989Inst : IEnumerable<long>
{
public static readonly long[] Value=A141989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141989.Bytes);
public long this[int i]=>Value[i];

public static A141989Inst Instance=new A141989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141990
{
public static readonly long[] Value={ 43L,101L,449L,739L,797L,971L,1087L,1319L,1493L,1609L,1667L,1783L,2131L,2711L,3001L,3407L,3581L,3697L,3929L,4219L,4451L,4567L,4799L,4973L,5147L,5437L,5669L,5843L,6133L,6481L,6829L,7177L,7351L,7583L,7699L,7757L,7873L,8221L,8627L,9091L,9323L,9439L,9497L,9613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141990Inst : IEnumerable<long>
{
public static readonly long[] Value=A141990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141990.Bytes);
public long this[int i]=>Value[i];

public static A141990Inst Instance=new A141990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141991
{
public static readonly long[] Value={ 73L,131L,421L,479L,653L,769L,827L,1117L,1291L,1523L,1697L,1871L,1987L,2161L,2393L,2683L,2741L,2857L,3089L,3727L,4133L,4423L,4481L,4597L,5003L,5119L,5351L,5641L,6047L,6163L,6221L,6337L,6569L,6917L,7207L,8599L,8831L,9643L,9817L,10223L,10513L,10687L,10861L,11093L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141991Inst : IEnumerable<long>
{
public static readonly long[] Value=A141991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141991.Bytes);
public long this[int i]=>Value[i];

public static A141991Inst Instance=new A141991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142040
{
public static readonly long[] Value={ 13L,109L,173L,269L,397L,461L,557L,653L,877L,941L,1069L,1229L,1453L,1549L,1613L,1709L,1741L,1901L,1933L,1997L,2029L,2221L,2381L,2477L,2797L,2861L,2957L,3181L,3373L,3469L,3533L,3821L,3853L,3917L,4013L,4397L,4493L,4621L,4813L,4877L,4909L,4973L,5101L,5197L,5261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142040Inst : IEnumerable<long>
{
public static readonly long[] Value=A142040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142040.Bytes);
public long this[int i]=>Value[i];

public static A142040Inst Instance=new A142040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142041
{
public static readonly long[] Value={ 47L,79L,239L,271L,367L,431L,463L,719L,751L,911L,1039L,1103L,1231L,1327L,1423L,1487L,1583L,1871L,1999L,2063L,2287L,2351L,2383L,2447L,2543L,2671L,2767L,2927L,3023L,3119L,3343L,3407L,3631L,3727L,3823L,3919L,4079L,4111L,4271L,4463L,4591L,4751L,4783L,4943L,5039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142041Inst : IEnumerable<long>
{
public static readonly long[] Value=A142041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142041.Bytes);
public long this[int i]=>Value[i];

public static A142041Inst Instance=new A142041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142042
{
public static readonly long[] Value={ 19L,83L,179L,211L,307L,467L,499L,563L,659L,691L,787L,883L,947L,1171L,1427L,1459L,1523L,1619L,1747L,1811L,1907L,2003L,2099L,2131L,2579L,2707L,2803L,2963L,3187L,3251L,3347L,3539L,3571L,3923L,4019L,4051L,4211L,4243L,4339L,4691L,4723L,4787L,5011L,5107L,5171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142042Inst : IEnumerable<long>
{
public static readonly long[] Value=A142042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142042.Bytes);
public long this[int i]=>Value[i];

public static A142042Inst Instance=new A142042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142043
{
public static readonly long[] Value={ 53L,149L,181L,277L,373L,661L,757L,821L,853L,1013L,1109L,1237L,1301L,1429L,1493L,1621L,1877L,1973L,2069L,2293L,2357L,2389L,2549L,2677L,2741L,2837L,3061L,3221L,3253L,3413L,3541L,3637L,3701L,3733L,3797L,3989L,4021L,4373L,4597L,4789L,5077L,5237L,5333L,5557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142043Inst : IEnumerable<long>
{
public static readonly long[] Value=A142043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142043.Bytes);
public long this[int i]=>Value[i];

public static A142043Inst Instance=new A142043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142044
{
public static readonly long[] Value={ 23L,151L,311L,439L,503L,599L,631L,727L,823L,887L,919L,983L,1303L,1367L,1399L,1559L,1783L,1847L,1879L,2039L,2423L,2551L,2647L,2711L,2903L,2999L,3191L,3319L,3511L,3607L,3671L,3767L,3863L,4567L,4663L,4759L,4919L,4951L,5303L,5399L,5431L,5527L,5591L,5623L,5783L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142044Inst : IEnumerable<long>
{
public static readonly long[] Value=A142044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142044.Bytes);
public long this[int i]=>Value[i];

public static A142044Inst Instance=new A142044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142045
{
public static readonly long[] Value={ 89L,281L,313L,409L,569L,601L,761L,857L,953L,1049L,1433L,1657L,1721L,1753L,1913L,2137L,2297L,2393L,2521L,2617L,2713L,2777L,2969L,3001L,3257L,3449L,3673L,3769L,3833L,3929L,4057L,4153L,4217L,4409L,4441L,4729L,4793L,4889L,5081L,5113L,5209L,5273L,5657L,5689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142045Inst : IEnumerable<long>
{
public static readonly long[] Value=A142045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142045.Bytes);
public long this[int i]=>Value[i];

public static A142045Inst Instance=new A142045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142046
{
public static readonly long[] Value={ 59L,251L,283L,347L,379L,443L,571L,827L,859L,1019L,1051L,1307L,1499L,1531L,1627L,1723L,1787L,1979L,2011L,2203L,2267L,2459L,2683L,2843L,2939L,2971L,3067L,3163L,3259L,3323L,3547L,3643L,3739L,3803L,3931L,4027L,4091L,4219L,4283L,4507L,4603L,4987L,5051L,5147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142046Inst : IEnumerable<long>
{
public static readonly long[] Value=A142046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142046.Bytes);
public long this[int i]=>Value[i];

public static A142046Inst Instance=new A142046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142047
{
public static readonly long[] Value={ 29L,61L,157L,317L,349L,509L,541L,701L,733L,797L,829L,1021L,1117L,1181L,1213L,1277L,1373L,1597L,1693L,1789L,1949L,2141L,2237L,2269L,2333L,2557L,2621L,2749L,2909L,3037L,3229L,3389L,3517L,3581L,3613L,3677L,3709L,4093L,4157L,4253L,4349L,4637L,4733L,4861L,4957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142047Inst : IEnumerable<long>
{
public static readonly long[] Value=A142047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142047.Bytes);
public long this[int i]=>Value[i];

public static A142047Inst Instance=new A142047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142048
{
public static readonly long[] Value={ 1L,3L,1L,5L,3L,1L,7L,45L,1L,1L,9L,105L,15L,3L,1L,11L,1575L,945L,15L,3L,1L,13L,10395L,175L,945L,9L,1L,1L,15L,315315L,17325L,14175L,189L,15L,3L,1L,17L,45045L,23648625L,7425L,2835L,189L,15L,3L,1L,19L,6891885L,1576575L,23648625L,93555L,945L,135L,45L,1L,1L,21L,72747675L,7309575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142048Inst : IEnumerable<long>
{
public static readonly long[] Value=A142048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142048.Bytes);
public long this[int i]=>Value[i];

public static A142048Inst Instance=new A142048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142049
{
public static readonly long[] Value={ 67L,199L,331L,397L,463L,661L,727L,859L,991L,1123L,1321L,1453L,1783L,2113L,2179L,2311L,2377L,2707L,2971L,3037L,3169L,3301L,3433L,3499L,3631L,3697L,4027L,4093L,4159L,4357L,4423L,4621L,4951L,5281L,5347L,5413L,5479L,5743L,6007L,6073L,6271L,6337L,6469L,6733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142049Inst : IEnumerable<long>
{
public static readonly long[] Value=A142049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142049.Bytes);
public long this[int i]=>Value[i];

public static A142049Inst Instance=new A142049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142050
{
public static readonly long[] Value={ 2L,101L,167L,233L,431L,563L,761L,827L,1091L,1223L,1289L,1487L,1553L,1619L,1949L,2081L,2213L,2411L,2477L,2543L,2609L,2741L,2939L,3137L,3203L,3467L,3533L,3797L,3863L,3929L,4127L,4259L,4391L,4457L,4523L,4721L,4787L,4919L,5051L,5381L,5711L,5843L,6173L,6569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142050Inst : IEnumerable<long>
{
public static readonly long[] Value=A142050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142050.Bytes);
public long this[int i]=>Value[i];

public static A142050Inst Instance=new A142050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142051
{
public static readonly long[] Value={ 37L,103L,367L,433L,499L,631L,829L,1093L,1291L,1423L,1489L,1621L,1753L,1951L,2017L,2083L,2281L,2347L,2677L,3271L,3469L,3733L,3931L,4129L,4261L,4327L,4591L,4657L,4723L,4789L,4987L,5119L,5449L,5581L,5647L,5779L,6043L,6373L,6571L,6637L,6703L,6967L,7297L,7561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142051Inst : IEnumerable<long>
{
public static readonly long[] Value=A142051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142051.Bytes);
public long this[int i]=>Value[i];

public static A142051Inst Instance=new A142051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142052
{
public static readonly long[] Value={ 5L,71L,137L,269L,401L,467L,599L,797L,863L,929L,1061L,1193L,1259L,1523L,1721L,1787L,2381L,2447L,2579L,2711L,2777L,2843L,2909L,3041L,3371L,3701L,3767L,3833L,4229L,4493L,4691L,4889L,5021L,5087L,5153L,5351L,5417L,5483L,5813L,5879L,6011L,6143L,6473L,6737L,6803L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142052Inst : IEnumerable<long>
{
public static readonly long[] Value=A142052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142052.Bytes);
public long this[int i]=>Value[i];

public static A142052Inst Instance=new A142052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142053
{
public static readonly long[] Value={ 7L,73L,139L,271L,337L,601L,733L,997L,1063L,1129L,1327L,1459L,1657L,1723L,1789L,1987L,2053L,2251L,2383L,2647L,2713L,3109L,3307L,3373L,3571L,3637L,3769L,3967L,4099L,4231L,4297L,4363L,4561L,4759L,4957L,5023L,5419L,5683L,5749L,5881L,6079L,6211L,6277L,6343L,6607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142053Inst : IEnumerable<long>
{
public static readonly long[] Value=A142053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142053.Bytes);
public long this[int i]=>Value[i];

public static A142053Inst Instance=new A142053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142054
{
public static readonly long[] Value={ 41L,107L,173L,239L,503L,569L,701L,1031L,1097L,1163L,1229L,1361L,1427L,1493L,1559L,1823L,1889L,2087L,2153L,2351L,2417L,2549L,2879L,3011L,3209L,3407L,3539L,3671L,3803L,4001L,4133L,4397L,4463L,4793L,5189L,5387L,5519L,5651L,5717L,5783L,5849L,5981L,6047L,6113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142054Inst : IEnumerable<long>
{
public static readonly long[] Value=A142054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142054.Bytes);
public long this[int i]=>Value[i];

public static A142054Inst Instance=new A142054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142055
{
public static readonly long[] Value={ 43L,109L,241L,307L,373L,439L,571L,769L,967L,1033L,1231L,1297L,1429L,1627L,1693L,1759L,2089L,2221L,2287L,2551L,2617L,2683L,2749L,3079L,3343L,3541L,3607L,3673L,3739L,4003L,4201L,4597L,4663L,4729L,4861L,4993L,5059L,5323L,5521L,5653L,5851L,6247L,6379L,6577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142055Inst : IEnumerable<long>
{
public static readonly long[] Value=A142055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142055.Bytes);
public long this[int i]=>Value[i];

public static A142055Inst Instance=new A142055Inst();

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

public static class A142168
{
public static readonly long[] Value={ 211L,367L,523L,601L,757L,991L,1069L,1303L,1381L,1459L,1693L,2083L,2161L,2239L,2473L,2551L,2707L,3019L,3253L,3331L,3643L,3877L,4111L,4423L,4657L,4813L,4969L,5281L,5437L,5749L,5827L,6217L,6373L,6451L,6529L,6607L,6763L,6841L,6997L,7309L,7621L,7699L,7933L,8011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142168Inst : IEnumerable<long>
{
public static readonly long[] Value=A142168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142168.Bytes);
public long this[int i]=>Value[i];

public static A142168Inst Instance=new A142168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142169
{
public static readonly long[] Value={ 17L,173L,251L,563L,641L,719L,797L,953L,1031L,1109L,1187L,1499L,1733L,1811L,1889L,2357L,2591L,2903L,3137L,3371L,3449L,3527L,3761L,3917L,4073L,4229L,4463L,4931L,5009L,5087L,5399L,5477L,5711L,5867L,6101L,6257L,6491L,6569L,6803L,6959L,7193L,7349L,7583L,7817L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142169Inst : IEnumerable<long>
{
public static readonly long[] Value=A142169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142169.Bytes);
public long this[int i]=>Value[i];

public static A142169Inst Instance=new A142169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142170
{
public static readonly long[] Value={ 19L,97L,331L,409L,487L,643L,877L,1033L,1423L,1579L,1657L,2203L,2281L,2437L,2593L,2671L,2749L,3061L,3217L,3373L,3529L,3607L,3919L,4153L,4231L,4621L,4933L,5011L,5167L,5323L,5479L,5557L,5791L,5869L,6337L,6571L,6883L,6961L,7039L,7351L,7507L,7741L,8053L,8209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142170Inst : IEnumerable<long>
{
public static readonly long[] Value=A142170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142170.Bytes);
public long this[int i]=>Value[i];

public static A142170Inst Instance=new A142170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142171
{
public static readonly long[] Value={ 59L,137L,293L,449L,683L,761L,839L,1151L,1229L,1307L,1619L,1697L,1931L,2087L,2243L,2399L,2477L,2633L,2711L,2789L,3023L,3257L,3413L,3491L,3803L,3881L,4271L,4349L,4583L,4817L,4973L,5051L,5441L,5519L,5987L,6143L,6221L,6299L,6689L,7001L,7079L,7547L,7703L,7937L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142171Inst : IEnumerable<long>
{
public static readonly long[] Value=A142171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142171.Bytes);
public long this[int i]=>Value[i];

public static A142171Inst Instance=new A142171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142172
{
public static readonly long[] Value={ 61L,139L,373L,607L,919L,997L,1153L,1231L,1543L,1621L,1699L,1777L,1933L,2011L,2089L,2557L,2713L,2791L,3181L,3259L,3571L,3727L,4273L,4507L,4663L,5209L,5443L,5521L,6067L,6301L,6379L,6691L,7159L,7237L,7393L,7549L,8017L,8329L,8563L,8641L,8719L,9109L,9187L,9343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142172Inst : IEnumerable<long>
{
public static readonly long[] Value=A142172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142172.Bytes);
public long this[int i]=>Value[i];

public static A142172Inst Instance=new A142172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142173
{
public static readonly long[] Value={ 23L,101L,179L,257L,491L,569L,647L,881L,1193L,1427L,1583L,1973L,2129L,2207L,2441L,2753L,2909L,3221L,3299L,3533L,3767L,3923L,4001L,4079L,4157L,4391L,4547L,4703L,4937L,5171L,5483L,5639L,5717L,6029L,6263L,6653L,7043L,7121L,7433L,7589L,7823L,7901L,8291L,8369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142173Inst : IEnumerable<long>
{
public static readonly long[] Value=A142173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142173.Bytes);
public long this[int i]=>Value[i];

public static A142173Inst Instance=new A142173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142174
{
public static readonly long[] Value={ 103L,181L,337L,571L,727L,883L,1039L,1117L,1429L,1663L,1741L,2053L,2131L,2287L,2521L,2677L,2833L,3067L,3301L,3457L,3613L,3691L,3769L,3847L,4003L,4159L,4549L,4783L,4861L,5407L,5563L,5641L,5953L,6343L,6421L,6577L,6733L,6967L,7591L,7669L,8059L,8293L,8527L,8761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142174Inst : IEnumerable<long>
{
public static readonly long[] Value=A142174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142174.Bytes);
public long this[int i]=>Value[i];

public static A142174Inst Instance=new A142174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142175
{
public static readonly long[] Value={ 1L,1L,1L,1L,8L,1L,1L,36L,36L,1L,1L,133L,420L,133L,1L,1L,449L,3334L,3334L,449L,1L,1L,1446L,21939L,49364L,21939L,1446L,1L,1L,4534L,130044L,560957L,560957L,130044L,4534L,1L,1L,13991L,724222L,5459561L,10284514L,5459561L,724222L,13991L,1L,1L,42747L,3880014L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142175Inst : IEnumerable<long>
{
public static readonly long[] Value=A142175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142175.Bytes);
public long this[int i]=>Value[i];

public static A142175Inst Instance=new A142175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142176
{
public static readonly long[] Value={ 29L,107L,263L,419L,653L,809L,887L,1277L,1433L,1511L,1667L,1823L,1901L,1979L,2213L,2447L,2837L,3461L,3539L,3617L,3851L,3929L,4007L,4241L,4397L,4787L,4943L,5021L,5099L,5333L,5801L,5879L,6113L,6269L,6581L,6659L,6737L,6971L,7127L,7283L,7517L,7673L,7829L,7907L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142176Inst : IEnumerable<long>
{
public static readonly long[] Value=A142176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142176.Bytes);
public long this[int i]=>Value[i];

public static A142176Inst Instance=new A142176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142177
{
public static readonly long[] Value={ 31L,109L,421L,499L,577L,733L,811L,967L,1123L,1201L,1279L,1669L,1747L,2137L,2293L,2371L,2683L,2917L,3229L,3307L,3463L,3541L,3697L,3853L,3931L,4243L,4789L,5023L,5101L,5179L,5413L,5569L,5647L,5881L,6037L,6271L,6427L,6661L,7129L,7207L,7753L,8221L,8377L,8689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142177Inst : IEnumerable<long>
{
public static readonly long[] Value=A142177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142177.Bytes);
public long this[int i]=>Value[i];

public static A142177Inst Instance=new A142177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142178
{
public static readonly long[] Value={ 71L,149L,227L,383L,461L,617L,773L,929L,1163L,1319L,1553L,1709L,1787L,2099L,2333L,2411L,2801L,2879L,2957L,3191L,3347L,3581L,3659L,4049L,4127L,4283L,4517L,4673L,4751L,5297L,5531L,5843L,6311L,6389L,6701L,6779L,6857L,7013L,7247L,7481L,7559L,7793L,7949L,8573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142178Inst : IEnumerable<long>
{
public static readonly long[] Value=A142178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142178.Bytes);
public long this[int i]=>Value[i];

public static A142178Inst Instance=new A142178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142179
{
public static readonly long[] Value={ 73L,151L,229L,307L,463L,541L,619L,853L,1009L,1087L,1321L,1399L,1789L,1867L,2179L,2647L,2803L,3037L,3271L,3583L,3739L,4051L,4129L,4363L,4441L,4519L,4597L,4831L,4909L,4987L,5689L,5923L,6079L,6469L,6547L,6703L,6781L,7561L,7639L,7717L,7873L,7951L,8263L,8419L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142179Inst : IEnumerable<long>
{
public static readonly long[] Value=A142179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142179.Bytes);
public long this[int i]=>Value[i];

public static A142179Inst Instance=new A142179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142180
{
public static readonly long[] Value={ 113L,191L,269L,347L,503L,659L,971L,1049L,1283L,1361L,1439L,1907L,2063L,2141L,2297L,2531L,2609L,2687L,2843L,2999L,3389L,3467L,3623L,3701L,3779L,4013L,4091L,4481L,4637L,4793L,4871L,5261L,5417L,5573L,5651L,5807L,6197L,6353L,6899L,6977L,7211L,7523L,7757L,8069L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142180Inst : IEnumerable<long>
{
public static readonly long[] Value=A142180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142180.Bytes);
public long this[int i]=>Value[i];

public static A142180Inst Instance=new A142180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142181
{
public static readonly long[] Value={ 37L,193L,271L,349L,661L,739L,1051L,1129L,1597L,1753L,1831L,1987L,2143L,2221L,2377L,2689L,2767L,3001L,3079L,3313L,3391L,3469L,3547L,4093L,4327L,4483L,4561L,4639L,4951L,5107L,5419L,5653L,6043L,6121L,6199L,6277L,6823L,7057L,7213L,7369L,7603L,7681L,7759L,7993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142181Inst : IEnumerable<long>
{
public static readonly long[] Value=A142181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142181.Bytes);
public long this[int i]=>Value[i];

public static A142181Inst Instance=new A142181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142182
{
public static readonly long[] Value={ 233L,311L,389L,467L,701L,857L,1013L,1091L,1481L,1559L,1637L,1871L,1949L,2027L,2339L,2417L,2729L,2963L,3041L,3119L,3821L,4133L,4211L,4289L,4523L,4679L,5147L,5303L,5381L,5693L,5849L,5927L,6317L,6473L,6551L,6863L,7019L,7253L,7331L,7487L,7643L,7877L,8111L,8423L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142182Inst : IEnumerable<long>
{
public static readonly long[] Value=A142182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142182.Bytes);
public long this[int i]=>Value[i];

public static A142182Inst Instance=new A142182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142183
{
public static readonly long[] Value={ 41L,241L,281L,401L,521L,601L,641L,761L,881L,1201L,1321L,1361L,1481L,1601L,1721L,1801L,2081L,2161L,2281L,2441L,2521L,2801L,3001L,3041L,3121L,3361L,3761L,3881L,4001L,4201L,4241L,4441L,4481L,4561L,4721L,4801L,5081L,5281L,5441L,5521L,5641L,5801L,5881L,6121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142183Inst : IEnumerable<long>
{
public static readonly long[] Value=A142183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142183.Bytes);
public long this[int i]=>Value[i];

public static A142183Inst Instance=new A142183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142200
{
public static readonly long[] Value={ 3L,167L,331L,577L,659L,823L,1069L,1151L,1889L,2053L,2381L,2791L,3037L,3119L,3529L,4021L,4349L,4513L,4759L,5087L,5333L,5743L,6317L,6481L,6563L,7219L,7547L,7793L,8039L,8941L,9187L,9433L,9679L,10007L,10253L,10499L,10663L,10909L,11483L,12713L,12959L,13451L,13697L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142200Inst : IEnumerable<long>
{
public static readonly long[] Value=A142200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142200.Bytes);
public long this[int i]=>Value[i];

public static A142200Inst Instance=new A142200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142201
{
public static readonly long[] Value={ 127L,373L,619L,701L,947L,1193L,1439L,1931L,2341L,2423L,2833L,3079L,3407L,3571L,4391L,4637L,4801L,5867L,6113L,6277L,6359L,7507L,7589L,7753L,8081L,8573L,8737L,8819L,9311L,9721L,9803L,9967L,10459L,11197L,11279L,11443L,11689L,12263L,12919L,13001L,13411L,13903L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142201Inst : IEnumerable<long>
{
public static readonly long[] Value=A142201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142201.Bytes);
public long this[int i]=>Value[i];

public static A142201Inst Instance=new A142201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142202
{
public static readonly long[] Value={ 5L,251L,661L,743L,907L,1153L,1399L,1481L,1973L,2137L,2383L,2711L,2957L,3121L,3203L,3449L,3613L,4597L,4679L,5171L,5417L,5581L,5827L,6073L,7057L,7549L,7877L,8123L,8287L,8369L,8779L,8861L,10009L,10091L,10337L,10501L,10993L,11239L,11321L,11731L,11813L,13043L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142202Inst : IEnumerable<long>
{
public static readonly long[] Value=A142202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142202.Bytes);
public long this[int i]=>Value[i];

public static A142202Inst Instance=new A142202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142203
{
public static readonly long[] Value={ 47L,211L,293L,457L,1031L,1277L,1523L,1933L,2179L,2671L,2753L,2917L,2999L,3163L,3491L,4229L,4639L,4721L,4967L,5623L,5869L,6197L,6361L,6607L,6689L,7591L,7673L,7919L,8329L,8821L,9067L,9887L,10133L,10789L,11117L,11527L,12101L,12347L,12511L,12757L,13003L,13249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142203Inst : IEnumerable<long>
{
public static readonly long[] Value=A142203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142203.Bytes);
public long this[int i]=>Value[i];

public static A142203Inst Instance=new A142203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142204
{
public static readonly long[] Value={ 7L,89L,499L,827L,991L,1237L,1319L,1483L,1811L,2221L,2467L,2549L,2713L,3041L,3533L,3697L,3779L,3943L,4271L,4517L,5009L,5419L,5501L,6977L,7879L,8699L,8863L,9109L,9437L,9601L,9929L,10093L,10667L,10831L,11159L,11897L,12143L,12553L,12799L,13127L,13291L,13537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142204Inst : IEnumerable<long>
{
public static readonly long[] Value=A142204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142204.Bytes);
public long this[int i]=>Value[i];

public static A142204Inst Instance=new A142204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142205
{
public static readonly long[] Value={ 131L,541L,787L,1033L,1279L,1361L,1607L,2017L,2099L,2591L,2837L,3001L,3083L,3329L,3739L,3821L,4231L,4723L,4969L,5051L,5297L,5953L,6199L,6691L,7019L,7757L,8167L,8741L,9151L,9397L,9479L,9643L,10463L,10627L,10709L,11119L,11447L,11939L,12841L,12923L,13907L,14071L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142205Inst : IEnumerable<long>
{
public static readonly long[] Value=A142205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142205.Bytes);
public long this[int i]=>Value[i];

public static A142205Inst Instance=new A142205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142206
{
public static readonly long[] Value={ 173L,337L,419L,829L,911L,1321L,1567L,2141L,2551L,2633L,2797L,2879L,3371L,3617L,3863L,4027L,4273L,4519L,5011L,5503L,5749L,6323L,6569L,6733L,7307L,7717L,7963L,8209L,8291L,8537L,8783L,9029L,9439L,9521L,9767L,9931L,10177L,10259L,11161L,11243L,11489L,11981L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142206Inst : IEnumerable<long>
{
public static readonly long[] Value=A142206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142206.Bytes);
public long this[int i]=>Value[i];

public static A142206Inst Instance=new A142206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142207
{
public static readonly long[] Value={ 379L,461L,953L,1117L,1609L,2347L,2593L,3167L,3331L,3413L,3659L,3823L,4397L,4561L,4643L,4889L,5381L,5791L,6037L,6529L,6857L,7103L,7349L,7759L,7841L,8087L,9973L,10301L,10711L,10957L,11777L,11941L,12269L,12433L,13007L,13171L,13417L,13499L,14401L,15139L,15467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142207Inst : IEnumerable<long>
{
public static readonly long[] Value=A142207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142207.Bytes);
public long this[int i]=>Value[i];

public static A142207Inst Instance=new A142207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142208
{
public static readonly long[] Value={ 11L,257L,421L,503L,1487L,1733L,1979L,2143L,2389L,2963L,3209L,3373L,3701L,3947L,4111L,4357L,4603L,4931L,5669L,6079L,6571L,6653L,6899L,7309L,7883L,8293L,8539L,8867L,9277L,9769L,9851L,10343L,10589L,10753L,11491L,12721L,12967L,13049L,14033L,14197L,14771L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142208Inst : IEnumerable<long>
{
public static readonly long[] Value=A142208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142208.Bytes);
public long this[int i]=>Value[i];

public static A142208Inst Instance=new A142208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142209
{
public static readonly long[] Value={ 53L,463L,709L,1201L,1283L,1447L,1693L,2267L,2677L,3169L,3251L,3907L,3989L,4153L,4481L,4973L,5711L,6121L,6203L,6367L,6449L,7187L,7351L,7433L,8089L,8171L,8581L,8663L,9319L,9811L,10139L,10303L,10631L,11287L,11369L,11779L,12107L,12517L,12763L,13009L,13337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142209Inst : IEnumerable<long>
{
public static readonly long[] Value=A142209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142209.Bytes);
public long this[int i]=>Value[i];

public static A142209Inst Instance=new A142209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142210
{
public static readonly long[] Value={ 13L,587L,751L,997L,1489L,1571L,2063L,2309L,2473L,2719L,2801L,3457L,3539L,4441L,4523L,4933L,5179L,5261L,5507L,6163L,6491L,6737L,6983L,7229L,7393L,7639L,8377L,8623L,8951L,9689L,10099L,10181L,10427L,10837L,11083L,11329L,11411L,11657L,11821L,11903L,12149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142210Inst : IEnumerable<long>
{
public static readonly long[] Value=A142210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142210.Bytes);
public long this[int i]=>Value[i];

public static A142210Inst Instance=new A142210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142211
{
public static readonly long[] Value={ 137L,383L,547L,1039L,1367L,1531L,1613L,1777L,2269L,2351L,2843L,3089L,3253L,3499L,3581L,4073L,4483L,4729L,5303L,6287L,6451L,6779L,7517L,7681L,7927L,8009L,8419L,8501L,8747L,9157L,9239L,9403L,9649L,10141L,10223L,11617L,11699L,11863L,12109L,12437L,12601L,13093L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142211Inst : IEnumerable<long>
{
public static readonly long[] Value=A142211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142211.Bytes);
public long this[int i]=>Value[i];

public static A142211Inst Instance=new A142211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142212
{
public static readonly long[] Value={ 97L,179L,1163L,1327L,1409L,1901L,2311L,2393L,2557L,2803L,3049L,3541L,3623L,5099L,5591L,6247L,6329L,7477L,7559L,7723L,8297L,8461L,8543L,8707L,9199L,9281L,10429L,11003L,11987L,12479L,12889L,13217L,13381L,13463L,13627L,13709L,13873L,14447L,14939L,15349L,15923L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142212Inst : IEnumerable<long>
{
public static readonly long[] Value=A142212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142212.Bytes);
public long this[int i]=>Value[i];

public static A142212Inst Instance=new A142212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142213
{
public static readonly long[] Value={ 139L,467L,631L,877L,1123L,1451L,1697L,1861L,2927L,3583L,3911L,4157L,4567L,4649L,4813L,5059L,5387L,5879L,6043L,6781L,6863L,7027L,7109L,8011L,8093L,8831L,9241L,9323L,9733L,10061L,10799L,11701L,11783L,13177L,13259L,13669L,13751L,13997L,14243L,14407L,14489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142213Inst : IEnumerable<long>
{
public static readonly long[] Value=A142213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142213.Bytes);
public long this[int i]=>Value[i];

public static A142213Inst Instance=new A142213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142214
{
public static readonly long[] Value={ 17L,181L,263L,509L,673L,919L,1493L,1657L,2477L,2887L,2969L,3461L,4363L,4691L,4937L,5101L,5347L,5839L,6577L,6659L,6823L,7069L,7151L,7561L,7643L,8053L,8627L,9283L,9857L,10103L,10267L,10513L,11087L,11251L,11497L,11579L,11743L,12071L,12809L,12973L,13219L,13711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142214Inst : IEnumerable<long>
{
public static readonly long[] Value=A142214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142214.Bytes);
public long this[int i]=>Value[i];

public static A142214Inst Instance=new A142214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

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

public static class A142536
{
public static readonly long[] Value={ 59L,271L,907L,1013L,1543L,1861L,2179L,3557L,3769L,4723L,5147L,5783L,6101L,6737L,6949L,7691L,8009L,8221L,8539L,8963L,9281L,9811L,11083L,11719L,12037L,12143L,13309L,13627L,14051L,14369L,15217L,15641L,15959L,17231L,17443L,17761L,18397L,18503L,19139L,19457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142536Inst : IEnumerable<long>
{
public static readonly long[] Value=A142536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142536.Bytes);
public long this[int i]=>Value[i];

public static A142536Inst Instance=new A142536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142537
{
public static readonly long[] Value={ 7L,113L,431L,643L,1279L,1597L,2339L,2551L,2657L,3187L,3823L,3929L,5413L,5519L,6367L,6473L,6791L,7109L,7321L,7639L,8699L,9547L,10289L,10501L,10607L,11243L,12197L,12409L,13151L,13469L,13681L,13999L,14423L,14741L,15271L,15377L,15907L,16649L,17497L,17921L,18133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142537Inst : IEnumerable<long>
{
public static readonly long[] Value=A142537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142537.Bytes);
public long this[int i]=>Value[i];

public static A142537Inst Instance=new A142537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142538
{
public static readonly long[] Value={ 61L,167L,379L,1439L,2287L,2393L,2711L,3347L,3559L,3877L,4513L,4831L,4937L,5573L,6421L,7057L,7481L,8011L,8117L,8329L,8647L,8753L,9283L,9601L,10343L,10979L,11827L,11933L,12251L,12569L,12781L,13099L,13417L,13523L,13841L,14159L,15643L,15749L,16067L,16703L,17021L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142538Inst : IEnumerable<long>
{
public static readonly long[] Value=A142538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142538.Bytes);
public long this[int i]=>Value[i];

public static A142538Inst Instance=new A142538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142539
{
public static readonly long[] Value={ 433L,751L,857L,1069L,1493L,1811L,2129L,2341L,2447L,2659L,3083L,3613L,3719L,3931L,4567L,4673L,5309L,5521L,5839L,6263L,6581L,6793L,6899L,7853L,8171L,8807L,9337L,9973L,10079L,11351L,11987L,12517L,12941L,13259L,13577L,13789L,14107L,15061L,15803L,16333L,16651L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142539Inst : IEnumerable<long>
{
public static readonly long[] Value=A142539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142539.Bytes);
public long this[int i]=>Value[i];

public static A142539Inst Instance=new A142539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142540
{
public static readonly long[] Value={ 487L,593L,911L,1123L,1229L,1759L,2713L,2819L,3137L,4091L,4409L,4621L,6211L,6317L,6529L,7589L,7907L,8543L,8861L,9391L,9497L,10133L,10663L,11087L,11299L,11617L,12041L,12253L,12889L,13313L,14479L,14797L,16069L,16493L,16811L,17341L,17659L,17977L,18401L,18719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142540Inst : IEnumerable<long>
{
public static readonly long[] Value=A142540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142540.Bytes);
public long this[int i]=>Value[i];

public static A142540Inst Instance=new A142540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142541
{
public static readonly long[] Value={ 11L,223L,541L,647L,859L,1283L,1601L,2131L,2237L,2767L,3191L,4357L,4463L,4993L,5099L,5417L,6053L,6689L,7219L,7537L,7643L,8597L,9127L,9551L,10399L,11353L,11777L,12413L,13049L,13367L,14321L,14533L,14639L,14851L,14957L,16229L,16547L,16759L,17077L,17183L,17713L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142541Inst : IEnumerable<long>
{
public static readonly long[] Value=A142541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142541.Bytes);
public long this[int i]=>Value[i];

public static A142541Inst Instance=new A142541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142542
{
public static readonly long[] Value={ 277L,383L,701L,1019L,1231L,1549L,1867L,1973L,2503L,2609L,2927L,3457L,3881L,4093L,4517L,4729L,5153L,5471L,5683L,6637L,7591L,8863L,8969L,9181L,9817L,9923L,10453L,10559L,10771L,11831L,12043L,12149L,13103L,13421L,13633L,14057L,15329L,15541L,15647L,15859L,17449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142542Inst : IEnumerable<long>
{
public static readonly long[] Value=A142542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142542.Bytes);
public long this[int i]=>Value[i];

public static A142542Inst Instance=new A142542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142543
{
public static readonly long[] Value={ 13L,331L,967L,1709L,2027L,2239L,2557L,2663L,3299L,3511L,3617L,4253L,4783L,4889L,5101L,5419L,5737L,5843L,6373L,6691L,7433L,7963L,8069L,8387L,8599L,9341L,9871L,10613L,11779L,12097L,12203L,13687L,14323L,14747L,15277L,15383L,15913L,16231L,17291L,17609L,18457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142543Inst : IEnumerable<long>
{
public static readonly long[] Value=A142543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142543.Bytes);
public long this[int i]=>Value[i];

public static A142543Inst Instance=new A142543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142544
{
public static readonly long[] Value={ 67L,173L,491L,809L,1021L,1657L,2081L,2293L,2399L,3671L,3989L,4201L,4519L,4943L,5261L,5791L,5897L,6427L,7487L,7699L,8017L,8123L,8971L,10243L,10667L,11197L,11621L,11833L,11939L,12893L,15013L,15331L,15649L,16073L,16603L,16921L,17027L,17239L,17981L,18617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142544Inst : IEnumerable<long>
{
public static readonly long[] Value=A142544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142544.Bytes);
public long this[int i]=>Value[i];

public static A142544Inst Instance=new A142544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142545
{
public static readonly long[] Value={ 227L,439L,757L,863L,1181L,1499L,2029L,2347L,3089L,3301L,3407L,4679L,5209L,5527L,6163L,6269L,6481L,7541L,7753L,8389L,8707L,9343L,9661L,9767L,11251L,11887L,12841L,13159L,13477L,13901L,14431L,14537L,15173L,15809L,16127L,16339L,16657L,16763L,17293L,17929L,18353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142545Inst : IEnumerable<long>
{
public static readonly long[] Value=A142545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142545.Bytes);
public long this[int i]=>Value[i];

public static A142545Inst Instance=new A142545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142546
{
public static readonly long[] Value={ 281L,599L,811L,1129L,1447L,1553L,1871L,2083L,2719L,3037L,3461L,3673L,3779L,4733L,5051L,5581L,6217L,6323L,6959L,7489L,8231L,8443L,8761L,8867L,9397L,10139L,10457L,10987L,11093L,11411L,11941L,12577L,13001L,14591L,15121L,15227L,15439L,17029L,18089L,18301L,19891L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142546Inst : IEnumerable<long>
{
public static readonly long[] Value=A142546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142546.Bytes);
public long this[int i]=>Value[i];

public static A142546Inst Instance=new A142546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142547
{
public static readonly long[] Value={ 17L,229L,547L,653L,971L,1289L,1607L,2137L,2243L,2879L,3727L,3833L,4363L,4787L,4999L,5741L,5953L,6271L,6907L,7013L,7331L,7649L,8179L,9133L,9239L,9769L,10193L,10723L,11677L,11783L,12101L,13267L,13691L,13903L,14009L,14221L,14327L,15493L,16447L,16553L,16871L,17189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142547Inst : IEnumerable<long>
{
public static readonly long[] Value=A142547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142547.Bytes);
public long this[int i]=>Value[i];

public static A142547Inst Instance=new A142547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142548
{
public static readonly long[] Value={ 71L,283L,389L,601L,919L,1237L,1873L,1979L,2297L,3251L,3463L,4099L,4523L,5477L,5689L,6007L,6113L,6961L,7703L,8233L,9187L,9293L,9929L,10141L,10247L,10459L,10883L,11519L,11731L,12049L,12473L,12791L,13003L,13109L,14593L,14699L,15017L,15971L,16183L,16607L,17137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142548Inst : IEnumerable<long>
{
public static readonly long[] Value=A142548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142548.Bytes);
public long this[int i]=>Value[i];

public static A142548Inst Instance=new A142548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142549
{
public static readonly long[] Value={ 19L,337L,443L,761L,1291L,1609L,2351L,3517L,3623L,4153L,4259L,4789L,5107L,5531L,5743L,5849L,6379L,6803L,7121L,7333L,7757L,8287L,8923L,9029L,9241L,10301L,10513L,10831L,10937L,11149L,11467L,12421L,12527L,12739L,13163L,13693L,13799L,14011L,14753L,15601L,15919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142549Inst : IEnumerable<long>
{
public static readonly long[] Value=A142549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142549.Bytes);
public long this[int i]=>Value[i];

public static A142549Inst Instance=new A142549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142550
{
public static readonly long[] Value={ 73L,179L,709L,1451L,1663L,2087L,2617L,3041L,3253L,3359L,3571L,3677L,3889L,5479L,5903L,6221L,6857L,7069L,8447L,9613L,9719L,9931L,10037L,10567L,11839L,12157L,12263L,12899L,13217L,14489L,15443L,15761L,15973L,16927L,17033L,17351L,17669L,17881L,17987L,18199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142550Inst : IEnumerable<long>
{
public static readonly long[] Value=A142550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142550.Bytes);
public long this[int i]=>Value[i];

public static A142550Inst Instance=new A142550Inst();

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