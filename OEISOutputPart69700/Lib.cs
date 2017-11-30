using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A142297
{
public static readonly long[] Value={ 13L,101L,233L,277L,409L,541L,673L,761L,937L,1069L,1201L,1289L,1553L,1597L,1861L,1949L,1993L,2081L,2213L,2389L,2477L,2521L,2609L,2741L,2917L,3049L,3137L,3181L,3313L,3533L,3709L,3797L,3929L,4457L,4721L,5381L,5557L,5689L,5821L,5953L,6173L,6217L,6481L,6569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142297Inst : IEnumerable<long>
{
public static readonly long[] Value=A142297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142297.Bytes);
public long this[int i]=>Value[i];

public static A142297Inst Instance=new A142297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142298
{
public static readonly long[] Value={ 59L,103L,191L,367L,499L,587L,631L,719L,983L,1291L,1423L,1511L,1907L,1951L,2039L,2083L,2347L,2699L,2963L,3271L,3359L,3491L,3623L,3931L,4019L,4283L,4327L,4547L,4591L,4679L,4723L,4943L,4987L,5119L,5471L,5647L,5779L,5867L,6043L,6131L,6263L,6571L,6659L,6703L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142298Inst : IEnumerable<long>
{
public static readonly long[] Value=A142298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142298.Bytes);
public long this[int i]=>Value[i];

public static A142298Inst Instance=new A142298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142299
{
public static readonly long[] Value={ 17L,61L,149L,193L,281L,457L,677L,809L,853L,941L,1117L,1249L,1381L,1601L,1733L,1777L,1997L,2129L,2393L,2437L,2657L,2789L,2833L,3229L,3361L,3449L,3581L,3889L,4021L,4153L,4241L,4373L,4549L,4637L,4813L,5077L,5209L,5297L,5693L,5737L,5869L,6089L,6133L,6221L,6353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142299Inst : IEnumerable<long>
{
public static readonly long[] Value=A142299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142299.Bytes);
public long this[int i]=>Value[i];

public static A142299Inst Instance=new A142299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142300
{
public static readonly long[] Value={ 19L,107L,151L,239L,283L,503L,547L,811L,1031L,1163L,1427L,1471L,1559L,1823L,1867L,1999L,2087L,2131L,2351L,2659L,2791L,2879L,3011L,3187L,3319L,3407L,3539L,3583L,3671L,3803L,3847L,4111L,4243L,4463L,4507L,4639L,4903L,5167L,5387L,5431L,5519L,5563L,5651L,5783L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142300Inst : IEnumerable<long>
{
public static readonly long[] Value=A142300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142300.Bytes);
public long this[int i]=>Value[i];

public static A142300Inst Instance=new A142300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142301
{
public static readonly long[] Value={ 109L,197L,241L,373L,461L,593L,769L,857L,1033L,1297L,1429L,1693L,1913L,2089L,2221L,2309L,2441L,2617L,2749L,2837L,2969L,3541L,3673L,3761L,4157L,4201L,4289L,4421L,4597L,4729L,4817L,4861L,4993L,5081L,5477L,5521L,5653L,5741L,6269L,6577L,6709L,6841L,7193L,7237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142301Inst : IEnumerable<long>
{
public static readonly long[] Value=A142301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142301.Bytes);
public long this[int i]=>Value[i];

public static A142301Inst Instance=new A142301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142302
{
public static readonly long[] Value={ 23L,67L,199L,331L,419L,463L,683L,727L,859L,947L,991L,1123L,1607L,1783L,1871L,2003L,2179L,2267L,2311L,2399L,2531L,2663L,2707L,2927L,2971L,3191L,3323L,3499L,3631L,3719L,3851L,4027L,4159L,4423L,4643L,4951L,5039L,5171L,5303L,5347L,5479L,5743L,6007L,6271L,6359L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142302Inst : IEnumerable<long>
{
public static readonly long[] Value=A142302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142302.Bytes);
public long this[int i]=>Value[i];

public static A142302Inst Instance=new A142302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142303
{
public static readonly long[] Value={ 113L,157L,421L,509L,641L,773L,1213L,1301L,1433L,1609L,1697L,1741L,1873L,2137L,2269L,2357L,2621L,2753L,2797L,3061L,3413L,3457L,3677L,3853L,4073L,4337L,4513L,4733L,4909L,5261L,5393L,5437L,5569L,5657L,5701L,6053L,6229L,6317L,6361L,6449L,6581L,6977L,7109L,7417L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142303Inst : IEnumerable<long>
{
public static readonly long[] Value=A142303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142303.Bytes);
public long this[int i]=>Value[i];

public static A142303Inst Instance=new A142303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142304
{
public static readonly long[] Value={ 71L,379L,467L,599L,643L,863L,907L,1039L,1171L,1259L,1303L,1523L,1567L,1699L,1787L,1831L,2447L,2579L,2711L,2843L,2887L,3019L,3371L,3547L,3767L,3943L,4339L,4603L,4691L,4999L,5087L,5351L,5483L,5527L,5659L,5791L,5879L,5923L,6011L,6143L,6451L,6803L,7243L,7331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142304Inst : IEnumerable<long>
{
public static readonly long[] Value=A142304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142304.Bytes);
public long this[int i]=>Value[i];

public static A142304Inst Instance=new A142304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142305
{
public static readonly long[] Value={ 29L,73L,293L,337L,557L,601L,733L,821L,953L,997L,1129L,1217L,1481L,1613L,1657L,1789L,1877L,2053L,2141L,2273L,2713L,2801L,3109L,3329L,3373L,3461L,3593L,3637L,3769L,3989L,4253L,4297L,4517L,4561L,4649L,4957L,5309L,5441L,5573L,5749L,5881L,6101L,6277L,6673L,6761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142305Inst : IEnumerable<long>
{
public static readonly long[] Value=A142305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142305.Bytes);
public long this[int i]=>Value[i];

public static A142305Inst Instance=new A142305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142306
{
public static readonly long[] Value={ 31L,163L,251L,383L,647L,691L,823L,911L,1087L,1307L,1439L,1483L,1571L,1747L,1879L,2011L,2099L,2143L,2539L,2671L,2803L,3023L,3067L,3331L,3463L,3727L,3947L,4079L,4211L,4519L,4651L,4783L,4871L,5003L,5179L,5399L,5443L,5531L,5839L,5927L,6323L,6367L,6719L,6763L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142306Inst : IEnumerable<long>
{
public static readonly long[] Value=A142306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142306.Bytes);
public long this[int i]=>Value[i];

public static A142306Inst Instance=new A142306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142307
{
public static readonly long[] Value={ 79L,167L,211L,431L,563L,607L,739L,827L,1091L,1223L,1399L,1487L,1531L,1619L,1663L,2411L,2543L,2719L,2851L,2939L,3203L,3467L,3511L,3643L,3863L,3907L,4127L,4259L,4391L,4523L,4567L,4787L,4831L,4919L,5051L,5227L,5623L,5711L,5843L,6151L,6547L,6679L,6899L,7207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142307Inst : IEnumerable<long>
{
public static readonly long[] Value=A142307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142307.Bytes);
public long this[int i]=>Value[i];

public static A142307Inst Instance=new A142307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142308
{
public static readonly long[] Value={ 37L,257L,389L,433L,521L,653L,829L,1049L,1093L,1181L,1489L,1621L,1709L,1753L,1973L,2017L,2237L,2281L,2633L,2677L,2897L,3469L,3557L,3733L,3821L,4129L,4217L,4261L,4349L,4481L,4657L,4789L,4877L,5009L,5273L,5449L,5581L,5669L,5801L,6197L,6329L,6373L,6637L,6857L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142308Inst : IEnumerable<long>
{
public static readonly long[] Value=A142308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142308.Bytes);
public long this[int i]=>Value[i];

public static A142308Inst Instance=new A142308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142309
{
public static readonly long[] Value={ 83L,127L,347L,479L,523L,743L,787L,919L,1051L,1447L,1579L,1667L,1931L,2063L,2239L,2371L,2459L,2503L,2591L,2767L,3119L,3163L,3251L,3559L,3691L,3779L,3823L,3911L,4219L,4483L,4703L,4967L,5011L,5099L,5231L,5407L,6067L,6199L,6287L,6551L,6947L,6991L,7079L,7211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142309Inst : IEnumerable<long>
{
public static readonly long[] Value=A142309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142309.Bytes);
public long this[int i]=>Value[i];

public static A142309Inst Instance=new A142309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142310
{
public static readonly long[] Value={ 41L,173L,349L,569L,613L,701L,877L,1009L,1097L,1229L,1361L,1493L,1669L,1801L,1889L,1933L,2153L,2417L,2549L,2593L,2857L,3121L,3209L,3253L,3517L,4001L,4133L,4177L,4397L,4441L,4793L,4969L,5101L,5189L,5233L,5717L,5849L,5981L,6113L,6421L,6553L,6949L,7213L,7433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142310Inst : IEnumerable<long>
{
public static readonly long[] Value=A142310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142310.Bytes);
public long this[int i]=>Value[i];

public static A142310Inst Instance=new A142310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142311
{
public static readonly long[] Value={ 43L,131L,263L,307L,439L,571L,659L,967L,1187L,1231L,1319L,1451L,1583L,1627L,1759L,1847L,1979L,2111L,2243L,2287L,2551L,2683L,2903L,3079L,3167L,3299L,3343L,3607L,3739L,4003L,4091L,4663L,4751L,5059L,5147L,5279L,5323L,5807L,5851L,5939L,6203L,6247L,6379L,6599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142311Inst : IEnumerable<long>
{
public static readonly long[] Value=A142311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142311.Bytes);
public long this[int i]=>Value[i];

public static A142311Inst Instance=new A142311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142360
{
public static readonly long[] Value={ 103L,197L,479L,761L,1231L,1607L,1889L,3299L,3581L,3769L,3863L,4051L,5179L,5273L,5743L,6871L,7247L,7529L,7717L,8093L,8563L,9127L,9221L,9973L,10067L,10631L,11383L,12041L,12323L,12511L,13451L,13921L,14767L,15331L,16553L,16741L,17117L,17681L,18433L,19373L,19843L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142360Inst : IEnumerable<long>
{
public static readonly long[] Value=A142360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142360.Bytes);
public long this[int i]=>Value[i];

public static A142360Inst Instance=new A142360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142361
{
public static readonly long[] Value={ 151L,433L,809L,997L,1091L,1279L,1373L,2689L,2971L,3253L,3347L,3911L,4099L,4663L,5039L,5227L,5791L,6073L,6449L,6637L,7013L,7577L,8329L,8423L,8893L,9551L,9739L,9833L,10303L,10867L,11149L,11243L,11807L,12277L,12653L,12841L,13217L,13499L,13687L,13781L,14251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142361Inst : IEnumerable<long>
{
public static readonly long[] Value=A142361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142361.Bytes);
public long this[int i]=>Value[i];

public static A142361Inst Instance=new A142361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142362
{
public static readonly long[] Value={ 11L,199L,293L,857L,1327L,1609L,2267L,2549L,3019L,3301L,3583L,3677L,4241L,4523L,4993L,5087L,5557L,5651L,5839L,6121L,6779L,6967L,7907L,8377L,8753L,8941L,9787L,10069L,10163L,11197L,12043L,12889L,12983L,13171L,13829L,14957L,15427L,15803L,15991L,16273L,16649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142362Inst : IEnumerable<long>
{
public static readonly long[] Value=A142362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142362.Bytes);
public long this[int i]=>Value[i];

public static A142362Inst Instance=new A142362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142363
{
public static readonly long[] Value={ 59L,811L,1093L,1187L,1657L,2221L,2503L,2879L,3067L,3631L,4007L,4289L,4759L,5323L,5417L,5981L,6263L,6451L,6733L,6827L,7109L,7297L,7673L,8237L,8707L,9929L,10211L,10399L,11057L,11527L,11621L,11903L,12373L,13219L,13313L,13877L,14159L,14347L,14629L,14723L,15193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142363Inst : IEnumerable<long>
{
public static readonly long[] Value=A142363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142363.Bytes);
public long this[int i]=>Value[i];

public static A142363Inst Instance=new A142363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142364
{
public static readonly long[] Value={ 13L,107L,389L,577L,859L,953L,1423L,1987L,2081L,2269L,2551L,2833L,2927L,3209L,3491L,4243L,4337L,5653L,6029L,6217L,6311L,6781L,8191L,8849L,9319L,9413L,9601L,9883L,10259L,10729L,12421L,12703L,13267L,13831L,14207L,14489L,14771L,15053L,15241L,16087L,16369L,16651L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142364Inst : IEnumerable<long>
{
public static readonly long[] Value=A142364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142364.Bytes);
public long this[int i]=>Value[i];

public static A142364Inst Instance=new A142364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142365
{
public static readonly long[] Value={ 61L,719L,907L,1283L,1471L,1753L,1847L,2129L,2411L,2693L,3163L,3257L,3539L,3727L,3821L,5231L,5419L,5701L,6359L,6547L,6829L,7393L,7487L,8521L,8803L,9461L,9649L,9743L,9931L,10589L,11059L,11717L,12281L,13033L,13127L,13597L,13691L,13879L,14537L,15101L,15289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142365Inst : IEnumerable<long>
{
public static readonly long[] Value=A142365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142365.Bytes);
public long this[int i]=>Value[i];

public static A142365Inst Instance=new A142365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142366
{
public static readonly long[] Value={ 109L,673L,1049L,1237L,1613L,1801L,2083L,2459L,2647L,2741L,3023L,4057L,4339L,4621L,4903L,5279L,5749L,5843L,6689L,6971L,7159L,7253L,7723L,7817L,8287L,8663L,9133L,9227L,9697L,9791L,11483L,11953L,12329L,12517L,12611L,12799L,12893L,13457L,14303L,14867L,15149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142366Inst : IEnumerable<long>
{
public static readonly long[] Value=A142366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142366.Bytes);
public long this[int i]=>Value[i];

public static A142366Inst Instance=new A142366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142367
{
public static readonly long[] Value={ 157L,251L,439L,1097L,1567L,2131L,2789L,3259L,3541L,3823L,3917L,4481L,4951L,5233L,6079L,6173L,6361L,6737L,7019L,7207L,7489L,7583L,8053L,8147L,8429L,9181L,9463L,9839L,11437L,11719L,11813L,12377L,12659L,12941L,13411L,13693L,14633L,14821L,15667L,15761L,16231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142367Inst : IEnumerable<long>
{
public static readonly long[] Value=A142367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142367.Bytes);
public long this[int i]=>Value[i];

public static A142367Inst Instance=new A142367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142368
{
public static readonly long[] Value={ 17L,487L,769L,863L,1051L,1427L,1709L,2179L,2273L,2837L,3119L,3307L,4153L,4999L,5281L,5563L,5657L,5939L,6221L,6691L,7349L,7537L,8101L,9041L,9323L,9511L,9887L,10169L,10357L,10639L,10733L,11579L,12049L,12143L,12613L,13177L,13553L,14869L,15527L,15809L,16091L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142368Inst : IEnumerable<long>
{
public static readonly long[] Value=A142368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142368.Bytes);
public long this[int i]=>Value[i];

public static A142368Inst Instance=new A142368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142369
{
public static readonly long[] Value={ 347L,911L,1193L,1381L,1663L,2039L,2791L,3167L,3449L,3637L,3919L,4013L,4201L,4483L,5987L,6269L,6551L,6833L,7867L,8243L,8431L,8713L,8807L,9277L,9371L,10499L,10687L,10781L,11251L,11909L,12097L,12379L,12473L,13037L,13789L,13883L,14071L,14447L,15199L,16139L,16421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142369Inst : IEnumerable<long>
{
public static readonly long[] Value=A142369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142369.Bytes);
public long this[int i]=>Value[i];

public static A142369Inst Instance=new A142369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142370
{
public static readonly long[] Value={ 19L,113L,677L,1429L,1523L,1993L,2087L,2557L,3121L,3779L,3967L,4813L,5189L,5471L,5659L,6317L,6599L,7069L,7351L,7727L,8009L,8291L,8573L,8761L,9043L,9137L,9419L,10453L,11299L,11393L,11863L,12239L,13367L,13649L,13931L,14401L,14683L,16187L,16657L,17033L,17597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142370Inst : IEnumerable<long>
{
public static readonly long[] Value=A142370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142370.Bytes);
public long this[int i]=>Value[i];

public static A142370Inst Instance=new A142370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142371
{
public static readonly long[] Value={ 67L,349L,443L,631L,1289L,1571L,1759L,2417L,2699L,2887L,3169L,3733L,4297L,4391L,4673L,4861L,5237L,5519L,5801L,6271L,6553L,7211L,7681L,7963L,8527L,9091L,9467L,9749L,10313L,10501L,11159L,12569L,12757L,13697L,14449L,14543L,14731L,15013L,15107L,15671L,15859L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142371Inst : IEnumerable<long>
{
public static readonly long[] Value=A142371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142371.Bytes);
public long this[int i]=>Value[i];

public static A142371Inst Instance=new A142371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142372
{
public static readonly long[] Value={ 397L,491L,773L,1619L,1901L,2089L,2371L,3217L,3499L,3593L,4157L,4721L,4909L,5003L,5849L,6037L,6131L,6883L,6977L,7541L,7823L,8011L,8293L,8387L,8669L,8951L,9421L,10079L,10267L,10831L,11113L,11489L,11677L,11959L,12241L,12899L,13463L,13933L,14591L,14779L,15061L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142372Inst : IEnumerable<long>
{
public static readonly long[] Value=A142372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142372.Bytes);
public long this[int i]=>Value[i];

public static A142372Inst Instance=new A142372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142373
{
public static readonly long[] Value={ 163L,257L,727L,821L,1009L,1103L,1291L,1667L,1949L,2137L,3359L,3547L,3923L,4111L,4957L,5051L,5333L,5521L,5897L,6367L,7213L,7307L,7589L,8059L,8623L,8999L,9187L,9281L,10597L,10691L,10973L,11161L,11443L,12007L,12101L,12289L,12853L,13229L,13417L,14639L,14827L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142373Inst : IEnumerable<long>
{
public static readonly long[] Value=A142373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142373.Bytes);
public long this[int i]=>Value[i];

public static A142373Inst Instance=new A142373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142374
{
public static readonly long[] Value={ 23L,211L,587L,1151L,1433L,1621L,1997L,2467L,2749L,2843L,3313L,3407L,3877L,4159L,4253L,4441L,4723L,4817L,5099L,5381L,5569L,5851L,6133L,6791L,7919L,8389L,10457L,10739L,11491L,11867L,12149L,12619L,12713L,13183L,13841L,14029L,14593L,14969L,15439L,16097L,16567L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142374Inst : IEnumerable<long>
{
public static readonly long[] Value=A142374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142374.Bytes);
public long this[int i]=>Value[i];

public static A142374Inst Instance=new A142374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142375
{
public static readonly long[] Value={ 71L,353L,541L,823L,1481L,1669L,1951L,2609L,2797L,3079L,3361L,3643L,4019L,4583L,5147L,5711L,7027L,7121L,7309L,7591L,7873L,8719L,9001L,9283L,9377L,9941L,10223L,11069L,11257L,11351L,11633L,11821L,12197L,12479L,13043L,13513L,14923L,15017L,15299L,15581L,16333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142375Inst : IEnumerable<long>
{
public static readonly long[] Value=A142375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142375.Bytes);
public long this[int i]=>Value[i];

public static A142375Inst Instance=new A142375Inst();

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

public static class A142504
{
public static readonly long[] Value={ 97L,199L,607L,709L,811L,1117L,1321L,1423L,1627L,1831L,1933L,2137L,2239L,2341L,2647L,2749L,2851L,2953L,3259L,3361L,3463L,3769L,4177L,4483L,4789L,4993L,5197L,5503L,6217L,6421L,6829L,7237L,7951L,8053L,8461L,8563L,8971L,9277L,9787L,10093L,10399L,10501L,10909L,11113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142504Inst : IEnumerable<long>
{
public static readonly long[] Value=A142504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142504.Bytes);
public long this[int i]=>Value[i];

public static A142504Inst Instance=new A142504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142505
{
public static readonly long[] Value={ 47L,149L,251L,353L,557L,659L,761L,863L,1373L,2087L,2393L,2699L,2801L,2903L,3209L,3413L,3617L,3719L,3821L,3923L,4127L,4229L,4637L,4943L,5147L,5351L,5657L,5861L,6269L,6473L,6779L,6983L,7187L,7901L,8513L,8819L,9227L,9431L,9533L,9839L,9941L,10247L,10859L,11369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142505Inst : IEnumerable<long>
{
public static readonly long[] Value=A142505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142505.Bytes);
public long this[int i]=>Value[i];

public static A142505Inst Instance=new A142505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142506
{
public static readonly long[] Value={ 151L,457L,661L,967L,1069L,1171L,1579L,1783L,1987L,2089L,2293L,2803L,3109L,3313L,3517L,3823L,4027L,4129L,4231L,4639L,5557L,5659L,6067L,6271L,6373L,6577L,6679L,6781L,6883L,7393L,7699L,8209L,8311L,8719L,8821L,8923L,9127L,9433L,9739L,10453L,10657L,10861L,11677L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142506Inst : IEnumerable<long>
{
public static readonly long[] Value=A142506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142506.Bytes);
public long this[int i]=>Value[i];

public static A142506Inst Instance=new A142506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142507
{
public static readonly long[] Value={ 101L,509L,1019L,1223L,1427L,1733L,2039L,2141L,2243L,2447L,2549L,2753L,2957L,3467L,3671L,4079L,4283L,4691L,4793L,5099L,5303L,5507L,5711L,5813L,6221L,6323L,6833L,7547L,7649L,7853L,8363L,8669L,9281L,9587L,9689L,9791L,10301L,10607L,10709L,11117L,11321L,11423L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142507Inst : IEnumerable<long>
{
public static readonly long[] Value=A142507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142507.Bytes);
public long this[int i]=>Value[i];

public static A142507Inst Instance=new A142507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142508
{
public static readonly long[] Value={ 53L,157L,313L,521L,677L,937L,1093L,1249L,1301L,1613L,1873L,2029L,2081L,2237L,2341L,2393L,2549L,2861L,3121L,3329L,3433L,3797L,4057L,4421L,4733L,4889L,4993L,5669L,5981L,6397L,6449L,6553L,6709L,6761L,6917L,7177L,7229L,7333L,7489L,7541L,7853L,8009L,8269L,8581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142508Inst : IEnumerable<long>
{
public static readonly long[] Value=A142508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142508.Bytes);
public long this[int i]=>Value[i];

public static A142508Inst Instance=new A142508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142509
{
public static readonly long[] Value={ 3L,107L,211L,263L,367L,419L,523L,887L,991L,1303L,1459L,1511L,1667L,1823L,1979L,2083L,2239L,2447L,2551L,2707L,3019L,3331L,3539L,3643L,3851L,4007L,4111L,4423L,4787L,4943L,5099L,5827L,5879L,6451L,6607L,6659L,6763L,6971L,7127L,7283L,7699L,7907L,8011L,8167L,8219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142509Inst : IEnumerable<long>
{
public static readonly long[] Value=A142509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142509.Bytes);
public long this[int i]=>Value[i];

public static A142509Inst Instance=new A142509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142510
{
public static readonly long[] Value={ 5L,109L,317L,421L,577L,733L,941L,1097L,1201L,1409L,1669L,1721L,1877L,2137L,2293L,2657L,2917L,2969L,3229L,3541L,3593L,3697L,3853L,4217L,4373L,4789L,5101L,5153L,5309L,5413L,5569L,5881L,6037L,6089L,6661L,6869L,7129L,7649L,7753L,8117L,8221L,8273L,8377L,8429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142510Inst : IEnumerable<long>
{
public static readonly long[] Value=A142510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142510.Bytes);
public long this[int i]=>Value[i];

public static A142510Inst Instance=new A142510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142511
{
public static readonly long[] Value={ 7L,59L,163L,631L,683L,787L,839L,1151L,1307L,1567L,1619L,1723L,1879L,1931L,2087L,2243L,2347L,2399L,2503L,2659L,2711L,2971L,3023L,3491L,3803L,3907L,4219L,4271L,4583L,4999L,5051L,5519L,5623L,5779L,5987L,6091L,6143L,6247L,6299L,6871L,7027L,7079L,7547L,7703L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142511Inst : IEnumerable<long>
{
public static readonly long[] Value=A142511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142511.Bytes);
public long this[int i]=>Value[i];

public static A142511Inst Instance=new A142511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142512
{
public static readonly long[] Value={ 61L,113L,269L,373L,997L,1049L,1153L,1361L,1621L,1777L,1933L,2089L,2141L,2297L,2557L,2609L,2713L,3181L,3389L,3701L,4013L,4273L,4481L,4637L,4793L,5209L,5261L,5417L,5521L,5573L,6197L,6301L,6353L,6977L,7237L,7393L,7549L,7757L,8017L,8069L,8329L,8537L,8641L,8693L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142512Inst : IEnumerable<long>
{
public static readonly long[] Value=A142512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142512.Bytes);
public long this[int i]=>Value[i];

public static A142512Inst Instance=new A142512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142513
{
public static readonly long[] Value={ 11L,167L,271L,479L,739L,947L,1051L,1103L,1259L,1571L,1831L,1987L,2039L,2143L,2351L,2663L,2767L,2819L,3079L,3391L,3547L,3911L,4327L,4483L,4639L,4691L,4951L,5003L,5107L,5419L,5471L,5783L,5939L,6043L,6199L,6563L,6719L,6823L,7187L,7499L,7603L,7759L,8123L,8539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142513Inst : IEnumerable<long>
{
public static readonly long[] Value=A142513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142513.Bytes);
public long this[int i]=>Value[i];

public static A142513Inst Instance=new A142513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142514
{
public static readonly long[] Value={ 67L,223L,379L,431L,587L,691L,743L,1367L,1471L,1523L,1627L,1783L,2251L,2459L,2719L,2927L,3083L,3187L,3343L,3499L,3863L,3967L,4019L,4591L,4643L,4799L,4903L,5059L,5527L,5683L,5839L,6047L,6151L,6203L,6359L,6619L,6827L,6983L,7243L,7451L,7607L,7867L,7919L,8179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142514Inst : IEnumerable<long>
{
public static readonly long[] Value=A142514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142514.Bytes);
public long this[int i]=>Value[i];

public static A142514Inst Instance=new A142514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142515
{
public static readonly long[] Value={ 17L,173L,277L,433L,641L,797L,953L,1109L,1213L,1733L,1889L,1993L,2357L,2617L,3137L,3449L,3709L,3761L,3917L,4021L,4073L,4177L,4229L,4801L,4957L,5009L,5113L,5477L,5581L,5737L,6101L,6257L,6361L,6569L,6673L,6829L,7193L,7297L,7349L,7817L,8233L,8389L,8597L,8753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142515Inst : IEnumerable<long>
{
public static readonly long[] Value=A142515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142515.Bytes);
public long this[int i]=>Value[i];

public static A142515Inst Instance=new A142515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142516
{
public static readonly long[] Value={ 19L,71L,227L,331L,383L,487L,643L,1163L,1319L,1423L,1579L,1787L,2099L,2203L,2411L,2671L,2879L,3191L,3347L,3607L,3659L,3919L,4127L,4231L,4283L,4751L,5011L,5167L,5323L,5479L,5531L,5791L,5843L,6311L,6571L,6779L,6883L,7039L,7247L,7351L,7507L,7559L,8287L,8443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142516Inst : IEnumerable<long>
{
public static readonly long[] Value=A142516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142516.Bytes);
public long this[int i]=>Value[i];

public static A142516Inst Instance=new A142516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142517
{
public static readonly long[] Value={ 73L,229L,281L,541L,593L,853L,1009L,1061L,1217L,1321L,1373L,1789L,1997L,2153L,2309L,2621L,2777L,3037L,3089L,3557L,4129L,4337L,4441L,4493L,4597L,4649L,4909L,5273L,5689L,5741L,5897L,6053L,6469L,6521L,6781L,6833L,7457L,7561L,7717L,7873L,8081L,8237L,8861L,9173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142517Inst : IEnumerable<long>
{
public static readonly long[] Value=A142517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142517.Bytes);
public long this[int i]=>Value[i];

public static A142517Inst Instance=new A142517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142518
{
public static readonly long[] Value={ 23L,127L,179L,283L,439L,491L,647L,751L,907L,1063L,1427L,1531L,1583L,1999L,2207L,2311L,2467L,3299L,3559L,3767L,3923L,4027L,4079L,4339L,4391L,4547L,4651L,4703L,5119L,5171L,5431L,5483L,5639L,5743L,6211L,6263L,6367L,6679L,6991L,7043L,7459L,7823L,7927L,8291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142518Inst : IEnumerable<long>
{
public static readonly long[] Value=A142518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142518.Bytes);
public long this[int i]=>Value[i];

public static A142518Inst Instance=new A142518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142519
{
public static readonly long[] Value={ 181L,233L,337L,389L,701L,857L,1013L,1117L,1429L,1481L,1637L,1741L,1949L,2053L,2417L,2521L,2677L,2729L,2833L,3041L,3301L,3457L,3613L,3769L,3821L,4133L,4289L,4549L,4861L,5381L,5641L,5693L,5849L,5953L,6317L,6421L,6473L,6577L,6733L,7253L,7669L,7877L,8293L,8501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142519Inst : IEnumerable<long>
{
public static readonly long[] Value=A142519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142519.Bytes);
public long this[int i]=>Value[i];

public static A142519Inst Instance=new A142519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142568
{
public static readonly long[] Value={ 197L,409L,727L,1151L,1787L,1999L,2423L,2741L,2953L,3271L,3907L,4013L,4649L,4861L,4967L,5179L,6133L,6451L,7193L,7723L,7829L,8147L,8677L,8783L,9419L,9631L,9949L,10267L,10691L,10903L,12281L,12917L,13553L,14083L,14401L,15461L,15991L,16097L,17581L,18217L,18959L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142568Inst : IEnumerable<long>
{
public static readonly long[] Value=A142568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142568.Bytes);
public long this[int i]=>Value[i];

public static A142568Inst Instance=new A142568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142569
{
public static readonly long[] Value={ 251L,463L,569L,887L,1523L,2053L,2371L,2477L,2689L,3643L,4597L,4703L,5021L,5233L,5657L,5869L,6823L,7247L,7459L,7883L,8731L,8837L,9049L,9473L,9791L,10321L,10427L,10639L,10957L,11593L,11699L,12547L,12653L,13183L,14243L,14561L,14879L,15091L,15727L,16363L,16787L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142569Inst : IEnumerable<long>
{
public static readonly long[] Value=A142569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142569.Bytes);
public long this[int i]=>Value[i];

public static A142569Inst Instance=new A142569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142570
{
public static readonly long[] Value={ 199L,941L,1153L,1259L,1471L,1789L,2213L,2531L,3061L,3167L,3697L,3803L,4651L,4969L,5393L,5711L,5923L,6029L,6983L,7937L,8467L,8573L,9103L,9209L,9421L,9739L,10163L,10799L,11117L,11329L,12071L,12601L,12919L,13873L,14827L,15569L,15887L,16417L,17053L,17159L,17477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142570Inst : IEnumerable<long>
{
public static readonly long[] Value=A142570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142570.Bytes);
public long this[int i]=>Value[i];

public static A142570Inst Instance=new A142570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142571
{
public static readonly long[] Value={ 41L,359L,571L,677L,1949L,2161L,2267L,2797L,2903L,3221L,3433L,3539L,4493L,5023L,5659L,6719L,7673L,8521L,8627L,8839L,9157L,10111L,10429L,10853L,11171L,11383L,11489L,11701L,11807L,12973L,13291L,13397L,14033L,14563L,14669L,15199L,17107L,18061L,18379L,18803L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142571Inst : IEnumerable<long>
{
public static readonly long[] Value=A142571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142571.Bytes);
public long this[int i]=>Value[i];

public static A142571Inst Instance=new A142571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142572
{
public static readonly long[] Value={ 307L,1049L,1367L,1579L,2003L,2851L,2957L,3169L,3593L,3911L,4229L,4441L,4547L,4759L,5077L,5501L,7621L,7727L,8363L,8681L,8893L,8999L,10271L,10589L,11119L,11437L,12073L,12391L,12497L,13451L,14087L,14723L,15359L,15889L,16631L,16843L,17903L,18433L,18539L,19069L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142572Inst : IEnumerable<long>
{
public static readonly long[] Value=A142572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142572.Bytes);
public long this[int i]=>Value[i];

public static A142572Inst Instance=new A142572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142573
{
public static readonly long[] Value={ 43L,149L,467L,997L,1103L,1951L,2269L,2693L,3011L,3329L,3541L,4177L,4283L,4813L,4919L,5237L,5449L,6827L,7039L,7993L,8311L,8629L,9371L,9689L,9901L,10007L,11173L,11279L,11491L,11597L,12763L,13187L,13399L,15307L,15413L,15731L,17321L,17851L,17957L,18169L,18593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142573Inst : IEnumerable<long>
{
public static readonly long[] Value=A142573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142573.Bytes);
public long this[int i]=>Value[i];

public static A142573Inst Instance=new A142573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142574
{
public static readonly long[] Value={ 97L,521L,733L,839L,1051L,2111L,3701L,4019L,4231L,4337L,4549L,4973L,5503L,5821L,5927L,6563L,7411L,7517L,9001L,9319L,9743L,10061L,10273L,10909L,11863L,11969L,12923L,13241L,13877L,14407L,14831L,15149L,15361L,15467L,15679L,16103L,16421L,16633L,18223L,18329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142574Inst : IEnumerable<long>
{
public static readonly long[] Value=A142574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142574.Bytes);
public long this[int i]=>Value[i];

public static A142574Inst Instance=new A142574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142575
{
public static readonly long[] Value={ 151L,257L,787L,1423L,1741L,1847L,2377L,2801L,3119L,3331L,3967L,4073L,4391L,4603L,5557L,5981L,6299L,6829L,7253L,8101L,8419L,8737L,9161L,9479L,10009L,10433L,11069L,12553L,12659L,13613L,13931L,14143L,14249L,14461L,14779L,15733L,16369L,17747L,17959L,18701L,18913L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142575Inst : IEnumerable<long>
{
public static readonly long[] Value=A142575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142575.Bytes);
public long this[int i]=>Value[i];

public static A142575Inst Instance=new A142575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142576
{
public static readonly long[] Value={ 311L,523L,947L,1583L,1901L,2113L,2749L,3067L,3491L,4021L,4127L,4339L,4657L,5081L,5399L,5717L,6247L,6353L,6883L,7307L,9109L,9533L,9851L,10169L,10487L,11971L,12289L,12713L,13879L,14197L,14303L,14621L,14939L,15787L,16529L,16741L,17377L,17483L,18013L,18119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142576Inst : IEnumerable<long>
{
public static readonly long[] Value=A142576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142576.Bytes);
public long this[int i]=>Value[i];

public static A142576Inst Instance=new A142576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142577
{
public static readonly long[] Value={ 47L,577L,683L,1213L,1319L,1531L,1637L,2273L,2591L,2803L,2909L,3121L,3863L,4817L,5347L,6089L,6301L,6619L,7043L,7573L,8209L,8527L,8951L,9587L,10223L,10753L,10859L,11071L,11177L,11813L,12343L,12979L,13297L,13721L,13933L,14251L,14887L,15629L,16477L,16901L,17431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142577Inst : IEnumerable<long>
{
public static readonly long[] Value=A142577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142577.Bytes);
public long this[int i]=>Value[i];

public static A142577Inst Instance=new A142577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142578
{
public static readonly long[] Value={ 101L,313L,419L,631L,1373L,2221L,2539L,2857L,2963L,3917L,4129L,4447L,4871L,5189L,5507L,6037L,6143L,6673L,6779L,6991L,7309L,8263L,8369L,8581L,9323L,11443L,11549L,11867L,12503L,12821L,13033L,13457L,13669L,14411L,15259L,15683L,16001L,16319L,17167L,17909L,18121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142578Inst : IEnumerable<long>
{
public static readonly long[] Value=A142578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142578.Bytes);
public long this[int i]=>Value[i];

public static A142578Inst Instance=new A142578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142579
{
public static readonly long[] Value={ 367L,1109L,1321L,1427L,2063L,2381L,2593L,2699L,3229L,3547L,4289L,5879L,6091L,6197L,6833L,7151L,7681L,8317L,8423L,8741L,9059L,9377L,9907L,10331L,10861L,11497L,12239L,12451L,13723L,13829L,14783L,15101L,15313L,15737L,16267L,16691L,16903L,17327L,17539L,18493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142579Inst : IEnumerable<long>
{
public static readonly long[] Value=A142579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142579.Bytes);
public long this[int i]=>Value[i];

public static A142579Inst Instance=new A142579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142580
{
public static readonly long[] Value={ 103L,421L,739L,1163L,1481L,1693L,2011L,2647L,2753L,3389L,3919L,5297L,5827L,6569L,6781L,7417L,7523L,7841L,8053L,8689L,9007L,9431L,9643L,9749L,10067L,10597L,11551L,11657L,12611L,12823L,13883L,14519L,14731L,15473L,15791L,16427L,17911L,18229L,19183L,19289L,19501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142580Inst : IEnumerable<long>
{
public static readonly long[] Value=A142580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142580.Bytes);
public long this[int i]=>Value[i];

public static A142580Inst Instance=new A142580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142581
{
public static readonly long[] Value={ 157L,263L,1217L,1429L,1747L,2383L,3019L,3761L,4079L,4397L,5351L,5563L,5669L,5881L,5987L,6199L,7577L,7789L,8849L,9697L,9803L,10333L,10651L,11287L,11393L,11923L,12241L,12347L,12983L,13513L,13619L,13831L,14149L,14891L,15527L,15739L,16057L,16481L,16693L,17011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142581Inst : IEnumerable<long>
{
public static readonly long[] Value=A142581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142581.Bytes);
public long this[int i]=>Value[i];

public static A142581Inst Instance=new A142581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142582
{
public static readonly long[] Value={ 211L,317L,953L,1483L,1801L,1907L,2437L,2543L,2861L,3391L,3709L,4027L,4133L,4451L,4663L,5087L,6359L,6571L,7207L,7949L,8161L,9221L,9433L,9539L,9857L,10069L,11447L,12401L,12613L,13037L,13249L,13567L,14627L,15263L,15581L,16111L,16217L,16747L,17383L,17489L,17807L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142582Inst : IEnumerable<long>
{
public static readonly long[] Value=A142582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142582.Bytes);
public long this[int i]=>Value[i];

public static A142582Inst Instance=new A142582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142583
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,2L,6L,41L,31L,6L,30L,931L,940L,301L,30L,210L,44347L,51971L,21227L,3571L,210L,2310L,5339027L,6762728L,3137268L,665308L,64681L,2310L,30030L,901841261L,1212061411L,618052532L,153213712L,19579601L,1231231L,30030L,510510L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142583Inst : IEnumerable<long>
{
public static readonly long[] Value=A142583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142583.Bytes);
public long this[int i]=>Value[i];

public static A142583Inst Instance=new A142583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142632
{
public static readonly long[] Value={ 43L,263L,373L,593L,1033L,1583L,1693L,1913L,2243L,2683L,2903L,3343L,3673L,4003L,4663L,4993L,5323L,5653L,6203L,6863L,7193L,7523L,7853L,7963L,8293L,8513L,8623L,9173L,9283L,9613L,9833L,10163L,10273L,11483L,11593L,11813L,11923L,12143L,12253L,12473L,12583L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142632Inst : IEnumerable<long>
{
public static readonly long[] Value=A142632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142632.Bytes);
public long this[int i]=>Value[i];

public static A142632Inst Instance=new A142632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142633
{
public static readonly long[] Value={ 101L,211L,431L,541L,761L,1091L,1201L,1531L,1861L,2081L,2411L,2521L,2741L,2851L,3181L,3511L,4391L,4721L,4831L,5051L,5381L,5711L,5821L,6151L,6481L,6701L,7691L,8461L,8681L,9011L,9341L,9781L,10111L,10331L,10771L,11321L,11981L,12421L,12641L,13411L,14071L,14401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142633Inst : IEnumerable<long>
{
public static readonly long[] Value=A142633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142633.Bytes);
public long this[int i]=>Value[i];

public static A142633Inst Instance=new A142633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142634
{
public static readonly long[] Value={ 47L,157L,487L,1367L,1697L,2027L,2137L,2357L,2467L,2687L,2797L,3347L,3457L,3677L,4007L,4337L,4447L,5107L,5437L,5657L,5987L,6317L,6427L,6977L,7307L,7417L,8297L,8627L,8737L,9067L,9397L,10607L,10937L,11047L,11597L,11927L,12037L,12697L,12917L,13577L,13687L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142634Inst : IEnumerable<long>
{
public static readonly long[] Value=A142634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142634.Bytes);
public long this[int i]=>Value[i];

public static A142634Inst Instance=new A142634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142635
{
public static readonly long[] Value={ 103L,433L,653L,983L,1093L,1423L,1753L,1973L,2083L,2633L,2963L,3623L,3733L,4283L,4723L,4943L,5273L,6043L,6263L,6373L,6703L,7253L,7583L,8243L,8353L,8573L,9013L,9343L,10223L,10333L,10663L,10883L,10993L,11213L,12203L,12973L,13523L,13633L,13963L,14293L,14843L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142635Inst : IEnumerable<long>
{
public static readonly long[] Value=A142635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142635.Bytes);
public long this[int i]=>Value[i];

public static A142635Inst Instance=new A142635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142636
{
public static readonly long[] Value={ 269L,379L,599L,709L,929L,1039L,1259L,1699L,2029L,2579L,2689L,2909L,3019L,4229L,4339L,4889L,4999L,5659L,5879L,6869L,7309L,7529L,7639L,8629L,8849L,9619L,9839L,9949L,10169L,10499L,10939L,11159L,11489L,12149L,12479L,12589L,12809L,12919L,13249L,13469L,13799L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142636Inst : IEnumerable<long>
{
public static readonly long[] Value=A142636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142636.Bytes);
public long this[int i]=>Value[i];

public static A142636Inst Instance=new A142636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142637
{
public static readonly long[] Value={ 271L,491L,601L,821L,1151L,1481L,1811L,2141L,2251L,2801L,3461L,3571L,4231L,4451L,4561L,5441L,5881L,6101L,6211L,6761L,6871L,8081L,8191L,8521L,8741L,9181L,9511L,10061L,10391L,10501L,10831L,11161L,11491L,11821L,12041L,13691L,14461L,15121L,15451L,15671L,16001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142637Inst : IEnumerable<long>
{
public static readonly long[] Value=A142637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142637.Bytes);
public long this[int i]=>Value[i];

public static A142637Inst Instance=new A142637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142638
{
public static readonly long[] Value={ 107L,547L,877L,1097L,1427L,1867L,2087L,2417L,2857L,3187L,3407L,3517L,3847L,4177L,4397L,4507L,5167L,5387L,5717L,5827L,6047L,7477L,8467L,9127L,9677L,9787L,10007L,10337L,10667L,11437L,11657L,11987L,12097L,12647L,12757L,13417L,13967L,14407L,14627L,14737L,14957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142638Inst : IEnumerable<long>
{
public static readonly long[] Value=A142638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142638.Bytes);
public long this[int i]=>Value[i];

public static A142638Inst Instance=new A142638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142639
{
public static readonly long[] Value={ 53L,163L,383L,823L,1153L,1373L,1483L,2143L,2473L,2693L,2803L,3023L,3463L,3793L,4013L,4673L,4783L,5003L,5113L,5333L,5443L,6323L,6653L,6763L,6983L,7643L,7753L,8963L,9293L,9403L,9623L,9733L,10613L,10723L,11273L,11383L,11933L,12043L,12263L,12373L,12703L,12923L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142639Inst : IEnumerable<long>
{
public static readonly long[] Value=A142639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142639.Bytes);
public long this[int i]=>Value[i];

public static A142639Inst Instance=new A142639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142640
{
public static readonly long[] Value={ 109L,439L,659L,769L,1319L,1429L,1759L,1979L,2089L,2309L,2749L,2969L,3079L,3299L,3739L,4289L,4729L,5059L,5279L,5939L,6269L,6379L,6599L,6709L,7039L,7369L,7589L,7699L,7919L,8689L,9239L,9349L,9679L,10009L,10559L,10889L,11329L,11549L,12539L,12979L,13309L,13859L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142640Inst : IEnumerable<long>
{
public static readonly long[] Value=A142640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142640.Bytes);
public long this[int i]=>Value[i];

public static A142640Inst Instance=new A142640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142641
{
public static readonly long[] Value={ 113L,281L,337L,449L,617L,673L,953L,1009L,1289L,2017L,2129L,2297L,2521L,2633L,2689L,2801L,2857L,2969L,3137L,3361L,3529L,3697L,4201L,4481L,4649L,4817L,5153L,5209L,5657L,5881L,6217L,6329L,6553L,6833L,7001L,7057L,7393L,7561L,7673L,7841L,8009L,8233L,8513L,8681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142641Inst : IEnumerable<long>
{
public static readonly long[] Value=A142641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142641.Bytes);
public long this[int i]=>Value[i];

public static A142641Inst Instance=new A142641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142642
{
public static readonly long[] Value={ 3L,59L,227L,283L,563L,619L,787L,1123L,1291L,1459L,1571L,1627L,1907L,2131L,2243L,2411L,2467L,2579L,2803L,2971L,3083L,3251L,3307L,3643L,3923L,4091L,4259L,4483L,4651L,4931L,4987L,5099L,5323L,5659L,5827L,5939L,6163L,6779L,6947L,7283L,7451L,7507L,8011L,8123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142642Inst : IEnumerable<long>
{
public static readonly long[] Value=A142642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142642.Bytes);
public long this[int i]=>Value[i];

public static A142642Inst Instance=new A142642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142643
{
public static readonly long[] Value={ 5L,61L,173L,229L,397L,509L,677L,733L,1013L,1069L,1181L,1237L,1741L,2357L,2693L,2749L,2861L,2917L,3253L,3533L,3701L,4093L,4261L,4373L,4597L,4877L,4933L,5101L,5381L,5437L,5717L,6053L,6221L,6277L,6389L,6781L,6949L,7229L,7621L,7789L,7901L,8069L,8237L,8293L,8461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142643Inst : IEnumerable<long>
{
public static readonly long[] Value=A142643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142643.Bytes);
public long this[int i]=>Value[i];

public static A142643Inst Instance=new A142643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142644
{
public static readonly long[] Value={ 233L,401L,457L,569L,1129L,1297L,1409L,1801L,1913L,2081L,2137L,2417L,2473L,2753L,3089L,3257L,3313L,3593L,3761L,3929L,4153L,4657L,4937L,4993L,5273L,5441L,6113L,6337L,6449L,6673L,6841L,7121L,7177L,7457L,7681L,7793L,8017L,8297L,8353L,8521L,8689L,8969L,9137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142644Inst : IEnumerable<long>
{
public static readonly long[] Value=A142644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142644.Bytes);
public long this[int i]=>Value[i];

public static A142644Inst Instance=new A142644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142645
{
public static readonly long[] Value={ 11L,67L,179L,347L,571L,683L,739L,907L,1019L,1187L,1523L,1579L,1747L,2027L,2083L,2251L,2531L,2699L,3203L,3259L,3371L,3539L,3931L,4099L,4211L,4547L,4603L,5051L,5107L,5387L,5443L,5779L,6451L,6563L,6619L,6899L,7459L,7907L,7963L,8243L,8467L,8747L,8803L,8971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142645Inst : IEnumerable<long>
{
public static readonly long[] Value=A142645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142645.Bytes);
public long this[int i]=>Value[i];

public static A142645Inst Instance=new A142645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142646
{
public static readonly long[] Value={ 13L,181L,293L,349L,461L,797L,853L,1021L,1301L,1637L,1693L,1861L,1973L,2029L,2141L,2309L,2477L,3037L,3373L,3541L,3709L,3821L,3877L,3989L,4157L,4493L,4549L,5333L,5501L,5557L,5669L,6173L,6229L,6397L,6733L,7013L,7069L,7237L,7349L,7517L,7573L,7741L,7853L,8581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142646Inst : IEnumerable<long>
{
public static readonly long[] Value=A142646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142646.Bytes);
public long this[int i]=>Value[i];

public static A142646Inst Instance=new A142646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142647
{
public static readonly long[] Value={ 71L,127L,239L,463L,631L,743L,911L,967L,1303L,1471L,1583L,2087L,2143L,2311L,2423L,2591L,2647L,2927L,3319L,3767L,3823L,4159L,4271L,4327L,4663L,4831L,4943L,4999L,5167L,5279L,5503L,5783L,5839L,6007L,6287L,6343L,6679L,6791L,6959L,7127L,7351L,7687L,8191L,8527L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142647Inst : IEnumerable<long>
{
public static readonly long[] Value=A142647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142647.Bytes);
public long this[int i]=>Value[i];

public static A142647Inst Instance=new A142647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142728
{
public static readonly long[] Value={ 0L,1L,1L,35L,35L,39L,45L,45L,49L,75L,77L,81L,95L,105L,115L,119L,143L,145L,147L,159L,187L,187L,207L,217L,219L,235L,235L,243L,249L,267L,273L,289L,321L,325L,335L,339L,361L,365L,369L,369L,381L,381L,395L,395L,411L,411L,417L,427L,441L,459L,465L,471L,471L,485L,485L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142728Inst : IEnumerable<long>
{
public static readonly long[] Value=A142728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142728.Bytes);
public long this[int i]=>Value[i];

public static A142728Inst Instance=new A142728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142729
{
public static readonly long[] Value={ 2L,61L,179L,769L,887L,1123L,1831L,1949L,2539L,2657L,3011L,3719L,4073L,4663L,5843L,6079L,6197L,6551L,9029L,9619L,9973L,10091L,10799L,11743L,12097L,12451L,12569L,12923L,13159L,13513L,14221L,14929L,15401L,15991L,16699L,17053L,17761L,18233L,18587L,19531L,20357L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142729Inst : IEnumerable<long>
{
public static readonly long[] Value=A142729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142729.Bytes);
public long this[int i]=>Value[i];

public static A142729Inst Instance=new A142729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142730
{
public static readonly long[] Value={ 3L,239L,593L,829L,947L,1301L,2953L,3307L,3779L,4133L,4723L,5077L,5431L,5903L,6257L,7673L,8263L,8971L,9679L,10151L,10859L,11213L,12157L,12511L,12983L,13219L,13337L,13691L,14281L,14753L,15107L,15461L,16759L,17231L,17467L,17939L,19001L,19237L,19709L,20063L,20771L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142730Inst : IEnumerable<long>
{
public static readonly long[] Value=A142730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142730.Bytes);
public long this[int i]=>Value[i];

public static A142730Inst Instance=new A142730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142731
{
public static readonly long[] Value={ 181L,653L,1361L,1597L,1951L,2069L,2423L,2659L,2777L,4547L,4783L,6199L,6317L,6553L,6907L,8087L,8677L,9739L,9857L,10093L,10211L,11273L,11863L,11981L,12689L,13043L,13397L,13633L,13751L,14341L,14813L,16111L,16229L,16937L,17291L,17881L,18353L,20123L,20359L,20477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142731Inst : IEnumerable<long>
{
public static readonly long[] Value=A142731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142731.Bytes);
public long this[int i]=>Value[i];

public static A142731Inst Instance=new A142731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142732
{
public static readonly long[] Value={ 5L,241L,359L,1303L,1657L,2011L,2129L,2719L,2837L,3191L,4253L,5197L,5669L,6967L,7321L,7793L,8147L,8501L,8737L,9091L,9209L,10271L,10861L,10979L,11923L,12041L,12277L,13103L,13339L,13457L,13693L,14401L,14519L,15227L,15581L,15817L,16879L,17351L,18059L,18413L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142732Inst : IEnumerable<long>
{
public static readonly long[] Value=A142732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142732.Bytes);
public long this[int i]=>Value[i];

public static A142732Inst Instance=new A142732Inst();

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