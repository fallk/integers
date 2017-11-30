using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

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

public static class A142023
{
public static readonly long[] Value={ 19L,577L,701L,887L,1259L,1321L,1693L,1879L,2003L,2251L,2437L,3119L,3181L,3491L,3677L,3739L,3863L,4049L,4111L,4297L,4421L,4483L,4793L,5227L,5351L,5413L,6343L,6529L,6653L,7211L,7459L,7583L,8017L,8389L,8513L,8699L,8761L,9133L,9257L,9319L,9629L,10559L,10993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142023Inst : IEnumerable<long>
{
public static readonly long[] Value=A142023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142023.Bytes);
public long this[int i]=>Value[i];

public static A142023Inst Instance=new A142023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142022
{
public static readonly long[] Value={ 173L,359L,421L,607L,1103L,1289L,1723L,1847L,2281L,2467L,2591L,2777L,2963L,3583L,3769L,4079L,4327L,4451L,4513L,4637L,5009L,5381L,5443L,5939L,6311L,6373L,6869L,7489L,8171L,8233L,8419L,8543L,9349L,9473L,9721L,9907L,10093L,10589L,10651L,10837L,11519L,11953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142022Inst : IEnumerable<long>
{
public static readonly long[] Value=A142022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142022.Bytes);
public long this[int i]=>Value[i];

public static A142022Inst Instance=new A142022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142021
{
public static readonly long[] Value={ 17L,79L,389L,761L,823L,947L,1009L,1319L,1381L,1567L,1753L,1877L,2063L,2311L,2621L,2683L,3613L,3923L,4357L,4481L,4729L,5039L,5101L,5659L,5783L,6217L,6899L,6961L,7333L,7457L,7643L,7829L,8263L,8387L,8573L,8821L,9007L,9689L,10061L,10247L,10433L,10867L,11177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142021Inst : IEnumerable<long>
{
public static readonly long[] Value=A142021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142021.Bytes);
public long this[int i]=>Value[i];

public static A142021Inst Instance=new A142021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142020
{
public static readonly long[] Value={ 47L,109L,233L,419L,853L,977L,1039L,1163L,1597L,1721L,1783L,1907L,2341L,2713L,2837L,3023L,3209L,3271L,3457L,3581L,3643L,3767L,4139L,4201L,4759L,5441L,5503L,5689L,5813L,6247L,6619L,6991L,7177L,7487L,7549L,7673L,8231L,8293L,9161L,9533L,9719L,9781L,9967L,10091L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142020Inst : IEnumerable<long>
{
public static readonly long[] Value=A142020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142020.Bytes);
public long this[int i]=>Value[i];

public static A142020Inst Instance=new A142020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142019
{
public static readonly long[] Value={ 139L,263L,449L,821L,883L,1069L,1193L,1627L,1999L,2309L,2371L,2557L,3301L,3673L,3797L,4231L,4603L,4789L,5099L,5347L,5471L,5657L,5843L,6029L,6091L,6277L,6959L,7207L,7331L,7393L,7517L,7703L,7951L,8447L,8819L,9067L,9377L,9439L,9749L,9811L,10369L,11113L,11299L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142019Inst : IEnumerable<long>
{
public static readonly long[] Value=A142019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142019.Bytes);
public long this[int i]=>Value[i];

public static A142019Inst Instance=new A142019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142018
{
public static readonly long[] Value={ 107L,293L,479L,541L,727L,1223L,1409L,1471L,1657L,2029L,2153L,2339L,2711L,2897L,3083L,3331L,3517L,3889L,4013L,4261L,4447L,4943L,5501L,5563L,5749L,6121L,6679L,6803L,7237L,7547L,7919L,8167L,8291L,8353L,8539L,8663L,8849L,9221L,9283L,10151L,10337L,10399L,10709L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142018Inst : IEnumerable<long>
{
public static readonly long[] Value=A142018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142018.Bytes);
public long this[int i]=>Value[i];

public static A142018Inst Instance=new A142018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142017
{
public static readonly long[] Value={ 13L,137L,199L,509L,571L,757L,881L,1129L,1439L,1811L,1873L,1997L,2617L,2741L,2803L,2927L,3299L,3361L,3547L,3671L,3733L,3919L,4229L,4663L,4787L,4973L,5407L,5531L,5717L,5779L,5903L,6089L,6151L,6337L,6709L,6833L,7019L,7577L,7639L,7949L,8011L,8693L,8941L,9127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142017Inst : IEnumerable<long>
{
public static readonly long[] Value=A142017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142017.Bytes);
public long this[int i]=>Value[i];

public static A142017Inst Instance=new A142017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142016
{
public static readonly long[] Value={ 43L,167L,229L,353L,601L,787L,911L,1097L,1283L,1531L,2027L,2089L,2213L,2399L,2647L,2833L,2957L,3019L,3329L,3391L,3701L,4073L,4259L,4507L,4817L,5003L,5189L,5437L,5623L,6367L,6491L,6553L,6863L,7297L,7607L,7669L,7793L,8537L,8599L,8971L,9157L,9281L,9343L,9467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142016Inst : IEnumerable<long>
{
public static readonly long[] Value=A142016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142016.Bytes);
public long this[int i]=>Value[i];

public static A142016Inst Instance=new A142016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142015
{
public static readonly long[] Value={ 11L,73L,197L,383L,569L,631L,941L,1499L,1747L,1871L,1933L,2243L,2677L,2801L,3049L,3359L,3607L,3793L,3917L,4289L,4723L,4909L,5281L,5591L,5653L,5839L,6211L,6397L,6521L,7079L,7451L,7699L,7823L,8009L,8443L,8629L,8753L,9001L,9187L,9311L,9497L,9931L,10303L,10427L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142015Inst : IEnumerable<long>
{
public static readonly long[] Value=A142015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142015.Bytes);
public long this[int i]=>Value[i];

public static A142015Inst Instance=new A142015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142014
{
public static readonly long[] Value={ 41L,103L,227L,599L,661L,971L,1033L,1777L,1901L,2087L,2273L,2459L,2521L,2707L,3079L,3203L,3389L,3637L,3761L,3823L,3947L,4133L,4567L,4691L,4877L,5683L,5807L,5869L,6427L,6551L,6737L,7109L,7481L,7853L,8039L,8101L,8287L,8597L,8783L,8969L,9341L,9403L,10271L,10333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142014Inst : IEnumerable<long>
{
public static readonly long[] Value=A142014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142014.Bytes);
public long this[int i]=>Value[i];

public static A142014Inst Instance=new A142014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142013
{
public static readonly long[] Value={ 71L,257L,443L,691L,877L,1063L,1187L,1249L,1373L,1559L,1621L,1931L,1993L,2179L,2551L,2861L,3109L,3853L,4349L,4597L,4721L,4783L,4969L,5279L,5527L,5651L,6271L,6581L,6829L,7573L,7759L,7883L,8069L,8317L,8627L,8689L,8999L,9371L,9433L,9619L,9743L,9929L,10177L,10301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142013Inst : IEnumerable<long>
{
public static readonly long[] Value=A142013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142013.Bytes);
public long this[int i]=>Value[i];

public static A142013Inst Instance=new A142013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142012
{
public static readonly long[] Value={ 101L,163L,349L,659L,907L,1031L,1093L,1217L,1279L,2333L,2767L,2953L,3449L,3511L,3697L,3821L,4007L,4441L,4751L,4813L,4937L,4999L,5309L,5557L,5743L,5867L,6053L,6301L,6673L,6983L,7417L,7541L,7603L,7727L,7789L,8161L,8719L,9029L,9091L,9277L,9463L,9587L,9649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142012Inst : IEnumerable<long>
{
public static readonly long[] Value=A142012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142012.Bytes);
public long this[int i]=>Value[i];

public static A142012Inst Instance=new A142012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142011
{
public static readonly long[] Value={ 7L,131L,193L,317L,379L,503L,751L,937L,1061L,1123L,1433L,1619L,1867L,2053L,2239L,2549L,2797L,3169L,3541L,3727L,3851L,4099L,4409L,4657L,4967L,5153L,5711L,5897L,6269L,6703L,6827L,7013L,7757L,8191L,8377L,8501L,8563L,9059L,9431L,9679L,9803L,10733L,11353L,12097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142011Inst : IEnumerable<long>
{
public static readonly long[] Value=A142011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142011.Bytes);
public long this[int i]=>Value[i];

public static A142011Inst Instance=new A142011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142010
{
public static readonly long[] Value={ 37L,223L,347L,409L,719L,967L,1091L,1153L,1277L,2083L,2207L,2269L,2393L,2579L,3137L,3323L,3571L,3881L,3943L,4129L,4253L,5059L,5431L,5741L,5927L,6113L,6299L,6361L,6547L,6733L,6857L,7043L,7229L,7477L,8221L,8779L,9151L,9337L,9461L,9833L,10267L,10391L,10453L,10639L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142010Inst : IEnumerable<long>
{
public static readonly long[] Value=A142010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142010.Bytes);
public long this[int i]=>Value[i];

public static A142010Inst Instance=new A142010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142009
{
public static readonly long[] Value={ 5L,67L,191L,439L,563L,811L,997L,1307L,1493L,1741L,2113L,2237L,2423L,2609L,2671L,2857L,3167L,3229L,3539L,3911L,4159L,4283L,4903L,5399L,5647L,6143L,6329L,6577L,6701L,6763L,6949L,7321L,7507L,7817L,7879L,8623L,8747L,8933L,9181L,9491L,9677L,9739L,10111L,10607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142009Inst : IEnumerable<long>
{
public static readonly long[] Value=A142009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142009.Bytes);
public long this[int i]=>Value[i];

public static A142009Inst Instance=new A142009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142008
{
public static readonly long[] Value={ 97L,283L,593L,1151L,1213L,1399L,1523L,1709L,2081L,2143L,2267L,2887L,3011L,3259L,3631L,4003L,4127L,4561L,4871L,4933L,5119L,5801L,5987L,6173L,6359L,6421L,6607L,6793L,6917L,7103L,7351L,7537L,7723L,8219L,8467L,8839L,8963L,9397L,9521L,9769L,10079L,10141L,10513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142008Inst : IEnumerable<long>
{
public static readonly long[] Value=A142008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142008.Bytes);
public long this[int i]=>Value[i];

public static A142008Inst Instance=new A142008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142007
{
public static readonly long[] Value={ 3L,127L,251L,313L,499L,809L,1181L,1367L,1429L,1553L,1801L,1987L,2111L,2297L,2731L,2917L,3041L,3413L,3847L,4157L,4219L,4591L,5087L,5273L,5521L,6079L,6203L,6389L,6451L,6637L,6761L,6823L,6947L,7691L,7753L,7877L,8311L,8807L,9241L,9551L,9613L,9923L,10357L,10667L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142007Inst : IEnumerable<long>
{
public static readonly long[] Value=A142007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142007.Bytes);
public long this[int i]=>Value[i];

public static A142007Inst Instance=new A142007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142006
{
public static readonly long[] Value={ 2L,157L,281L,467L,653L,839L,1087L,1459L,1583L,1831L,2017L,2141L,2203L,2389L,2699L,3257L,3319L,3691L,3877L,4001L,4373L,4621L,4931L,4993L,5179L,5303L,5737L,5861L,5923L,6047L,6481L,6791L,6977L,7039L,7349L,7411L,7907L,8093L,8527L,8713L,8837L,9209L,9643L,9767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142006Inst : IEnumerable<long>
{
public static readonly long[] Value=A142006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142006.Bytes);
public long this[int i]=>Value[i];

public static A142006Inst Instance=new A142006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142005
{
public static readonly long[] Value={ 311L,373L,683L,1117L,1303L,1427L,1489L,1613L,1861L,2357L,2543L,2729L,2791L,3163L,3659L,3907L,4093L,4217L,4651L,5023L,5147L,5209L,5333L,5519L,5581L,5953L,6263L,6449L,6883L,7069L,7193L,7937L,8123L,8681L,8867L,8929L,9239L,9859L,10169L,10789L,11161L,11471L,11657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142005Inst : IEnumerable<long>
{
public static readonly long[] Value=A142005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142005.Bytes);
public long this[int i]=>Value[i];

public static A142005Inst Instance=new A142005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142004
{
public static readonly long[] Value={ 173L,347L,463L,521L,811L,1217L,1913L,2029L,2087L,2203L,2377L,2551L,2609L,2957L,3769L,3943L,4001L,4349L,4523L,4639L,4813L,4871L,4987L,5393L,5683L,5741L,5857L,6089L,6263L,6379L,6553L,6959L,7307L,7481L,7829L,8293L,8467L,8641L,8699L,9221L,9337L,9511L,9743L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142004Inst : IEnumerable<long>
{
public static readonly long[] Value=A142004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142004.Bytes);
public long this[int i]=>Value[i];

public static A142004Inst Instance=new A142004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142003
{
public static readonly long[] Value={ 317L,433L,491L,607L,839L,1013L,1129L,1187L,1303L,1361L,1709L,1999L,2347L,2521L,2579L,2753L,2927L,3217L,3391L,3449L,3623L,3739L,3797L,4261L,4493L,4783L,4957L,5189L,5479L,5653L,5711L,5827L,6581L,6871L,7103L,7219L,7393L,7451L,7741L,8089L,8147L,8263L,8669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142003Inst : IEnumerable<long>
{
public static readonly long[] Value=A142003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142003.Bytes);
public long this[int i]=>Value[i];

public static A142003Inst Instance=new A142003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142002
{
public static readonly long[] Value={ 113L,229L,461L,577L,751L,809L,983L,1447L,1621L,2027L,2143L,2549L,2897L,3187L,3361L,3593L,3709L,3767L,4057L,4231L,4289L,4463L,4637L,5101L,5333L,5449L,5507L,5623L,6029L,6203L,6551L,6841L,6899L,7247L,7537L,8059L,8117L,8233L,8291L,8581L,8929L,9103L,9161L,9277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142002Inst : IEnumerable<long>
{
public static readonly long[] Value=A142002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142002.Bytes);
public long this[int i]=>Value[i];

public static A142002Inst Instance=new A142002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142001
{
public static readonly long[] Value={ 83L,199L,257L,373L,431L,547L,953L,1069L,1301L,1823L,1997L,2113L,2287L,2693L,3041L,3331L,3389L,3853L,3911L,4027L,4201L,4259L,4549L,4723L,5303L,5419L,5477L,5651L,6173L,6521L,6637L,6869L,7043L,7159L,7333L,7507L,7681L,8087L,8377L,8609L,8783L,9421L,9479L,9769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142001Inst : IEnumerable<long>
{
public static readonly long[] Value=A142001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142001.Bytes);
public long this[int i]=>Value[i];

public static A142001Inst Instance=new A142001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142000
{
public static readonly long[] Value={ 53L,227L,401L,691L,1039L,1097L,1213L,1619L,2083L,2141L,2663L,2837L,2953L,3011L,3301L,3359L,3533L,3823L,3881L,4229L,4519L,4751L,5099L,5273L,5563L,5737L,6143L,6317L,6491L,6607L,6781L,7013L,7129L,7187L,7477L,7883L,8231L,8521L,8753L,9043L,9391L,9623L,9739L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142000Inst : IEnumerable<long>
{
public static readonly long[] Value=A142000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142000.Bytes);
public long this[int i]=>Value[i];

public static A142000Inst Instance=new A142000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141999
{
public static readonly long[] Value={ 23L,139L,197L,313L,487L,661L,719L,1009L,1531L,1879L,2053L,2111L,2459L,2633L,2749L,3271L,3329L,3677L,3793L,3851L,3967L,4373L,4547L,4663L,4721L,5011L,5417L,5591L,5881L,5939L,6113L,6229L,6287L,6577L,6983L,7331L,7621L,7853L,8317L,8839L,9013L,9187L,9419L,9767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141999Inst : IEnumerable<long>
{
public static readonly long[] Value=A141999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141999.Bytes);
public long this[int i]=>Value[i];

public static A141999Inst Instance=new A141999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141998
{
public static readonly long[] Value={ 109L,167L,283L,457L,631L,863L,1153L,1327L,1559L,1733L,1907L,2081L,2371L,2719L,2777L,3067L,3299L,3821L,4111L,4517L,4691L,5039L,5387L,5503L,5851L,6199L,6257L,6373L,6547L,6779L,7069L,7127L,7243L,7417L,7591L,7649L,7823L,8171L,8287L,8461L,8693L,8867L,9041L,9157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141998Inst : IEnumerable<long>
{
public static readonly long[] Value=A141998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141998.Bytes);
public long this[int i]=>Value[i];

public static A141998Inst Instance=new A141998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141997
{
public static readonly long[] Value={ 79L,137L,311L,601L,659L,1123L,1181L,1297L,1471L,1877L,1993L,2341L,2399L,2689L,3037L,3559L,3617L,3733L,3907L,4139L,4603L,4951L,5009L,5531L,5647L,5821L,5879L,6053L,6343L,6691L,7039L,7213L,7561L,7793L,8431L,8663L,8779L,8837L,9011L,9127L,9533L,9649L,10867L,11273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141997Inst : IEnumerable<long>
{
public static readonly long[] Value=A141997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141997.Bytes);
public long this[int i]=>Value[i];

public static A141997Inst Instance=new A141997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141996
{
public static readonly long[] Value={ 107L,223L,281L,397L,571L,919L,977L,1093L,1151L,1499L,1789L,1847L,2137L,2311L,2543L,2659L,2833L,3181L,3413L,3529L,3761L,3877L,4051L,4283L,4457L,5153L,5443L,5501L,5791L,5849L,6197L,6661L,6719L,7589L,7879L,7937L,8053L,8111L,8807L,8923L,9619L,9677L,9851L,9967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141996Inst : IEnumerable<long>
{
public static readonly long[] Value=A141996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141996.Bytes);
public long this[int i]=>Value[i];

public static A141996Inst Instance=new A141996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141995
{
public static readonly long[] Value={ 19L,193L,251L,367L,541L,599L,773L,947L,1063L,1237L,1759L,1933L,2281L,2339L,2687L,2803L,2861L,3209L,3499L,3557L,3673L,3847L,4021L,4079L,4253L,5297L,5413L,5471L,6689L,6863L,7211L,7559L,7907L,8081L,8429L,8719L,8893L,8951L,9067L,9241L,9473L,10111L,10169L,10343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141995Inst : IEnumerable<long>
{
public static readonly long[] Value=A141995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141995.Bytes);
public long this[int i]=>Value[i];

public static A141995Inst Instance=new A141995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141994
{
public static readonly long[] Value={ 47L,163L,337L,569L,743L,859L,1033L,1091L,1381L,1439L,1613L,1787L,2251L,2309L,2657L,3121L,3469L,3527L,3643L,3701L,4049L,4339L,4397L,4513L,4861L,4919L,5209L,5441L,5557L,6079L,6311L,6427L,6659L,6833L,6949L,7297L,7529L,7703L,7877L,7993L,8167L,8573L,8689L,8747L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141994Inst : IEnumerable<long>
{
public static readonly long[] Value=A141994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141994.Bytes);
public long this[int i]=>Value[i];

public static A141994Inst Instance=new A141994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141993
{
public static readonly long[] Value={ 17L,191L,307L,829L,887L,1061L,1409L,1583L,1699L,1873L,1931L,2221L,2801L,2917L,3323L,3613L,3671L,4019L,4483L,4657L,4831L,4889L,5179L,5237L,5527L,5701L,6397L,6571L,6803L,6977L,7151L,7499L,7673L,7789L,7963L,8311L,8369L,8543L,9007L,9181L,9239L,9413L,9587L,10399L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141993Inst : IEnumerable<long>
{
public static readonly long[] Value=A141993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141993.Bytes);
public long this[int i]=>Value[i];

public static A141993Inst Instance=new A141993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141992
{
public static readonly long[] Value={ 103L,277L,509L,683L,857L,1031L,1321L,1553L,1669L,1901L,2017L,2423L,2539L,2713L,2887L,3061L,3119L,3467L,3583L,3931L,3989L,4337L,4801L,5323L,5381L,5903L,6367L,6599L,6947L,7121L,7237L,7411L,7643L,7759L,7817L,7933L,8513L,8629L,8803L,8861L,9151L,9209L,10079L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141992Inst : IEnumerable<long>
{
public static readonly long[] Value=A141992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141992.Bytes);
public long this[int i]=>Value[i];

public static A141992Inst Instance=new A141992Inst();

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

public static class A141863
{
public static readonly long[] Value={ 3L,2L,3L,7L,5L,2L,5L,11L,17L,7L,17L,59L,13L,17L,41L,23L,29L,61L,47L,199L,101L,71L,41L,23L,263L,269L,137L,139L,97L,59L,101L,103L,67L,173L,353L,127L,409L,139L,419L,449L,229L,163L,199L,103L,223L,229L,349L,181L,733L,751L,853L,883L,109L,197L,1033L,347L,521L,211L,137L,1109L,373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141863Inst : IEnumerable<long>
{
public static readonly long[] Value=A141863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141863.Bytes);
public long this[int i]=>Value[i];

public static A141863Inst Instance=new A141863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141862
{
public static readonly long[] Value={ 3L,2L,2L,3L,11L,7L,13L,31L,7L,13L,23L,17L,53L,59L,61L,31L,71L,73L,89L,31L,107L,31L,149L,31L,79L,167L,193L,223L,83L,257L,263L,47L,293L,157L,53L,109L,179L,193L,67L,47L,433L,443L,31L,157L,71L,251L,503L,509L,173L,521L,271L,37L,83L,197L,613L,617L,313L,631L,643L,109L,661L,337L,227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141862Inst : IEnumerable<long>
{
public static readonly long[] Value=A141862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141862.Bytes);
public long this[int i]=>Value[i];

public static A141862Inst Instance=new A141862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141861
{
public static readonly long[] Value={ 2L,3L,13L,29L,37L,59L,163L,173L,181L,193L,223L,241L,281L,313L,337L,373L,547L,733L,797L,823L,877L,911L,947L,953L,977L,1051L,1087L,1109L,1117L,1213L,1289L,1381L,1427L,1429L,1459L,1481L,1523L,1693L,1801L,1811L,1901L,1987L,2027L,2029L,2161L,2213L,2251L,2267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141861Inst : IEnumerable<long>
{
public static readonly long[] Value=A141861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141861.Bytes);
public long this[int i]=>Value[i];

public static A141861Inst Instance=new A141861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141860
{
public static readonly long[] Value={ 2L,17L,47L,107L,137L,167L,197L,227L,257L,317L,347L,467L,557L,587L,617L,647L,677L,797L,827L,857L,887L,947L,977L,1097L,1187L,1217L,1277L,1307L,1367L,1427L,1487L,1607L,1637L,1667L,1697L,1787L,1847L,1877L,1907L,1997L,2027L,2087L,2207L,2237L,2267L,2297L,2357L,2417L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141860Inst : IEnumerable<long>
{
public static readonly long[] Value=A141860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141860.Bytes);
public long this[int i]=>Value[i];

public static A141860Inst Instance=new A141860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141859
{
public static readonly long[] Value={ 103L,181L,233L,311L,337L,389L,467L,571L,701L,727L,857L,883L,1013L,1039L,1091L,1117L,1429L,1481L,1559L,1637L,1663L,1741L,1871L,1949L,2027L,2053L,2131L,2287L,2339L,2417L,2521L,2677L,2729L,2833L,2963L,3041L,3067L,3119L,3301L,3457L,3613L,3691L,3769L,3821L,3847L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141859Inst : IEnumerable<long>
{
public static readonly long[] Value=A141859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141859.Bytes);
public long this[int i]=>Value[i];

public static A141859Inst Instance=new A141859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141858
{
public static readonly long[] Value={ 2L,41L,67L,197L,223L,353L,379L,431L,457L,509L,587L,613L,691L,743L,769L,821L,977L,1237L,1289L,1367L,1471L,1523L,1549L,1601L,1627L,1783L,1861L,1913L,2017L,2069L,2251L,2381L,2459L,2693L,2719L,2797L,2927L,2953L,3083L,3109L,3187L,3343L,3499L,3733L,3863L,3889L,3967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141858Inst : IEnumerable<long>
{
public static readonly long[] Value=A141858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141858.Bytes);
public long this[int i]=>Value[i];

public static A141858Inst Instance=new A141858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141857
{
public static readonly long[] Value={ 43L,109L,131L,197L,241L,263L,307L,373L,439L,461L,571L,593L,659L,769L,857L,967L,1033L,1187L,1231L,1297L,1319L,1429L,1451L,1583L,1627L,1693L,1759L,1847L,1913L,1979L,2089L,2111L,2221L,2243L,2287L,2309L,2441L,2551L,2617L,2683L,2749L,2837L,2903L,2969L,3079L,3167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141857Inst : IEnumerable<long>
{
public static readonly long[] Value=A141857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141857.Bytes);
public long this[int i]=>Value[i];

public static A141857Inst Instance=new A141857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141856
{
public static readonly long[] Value={ 31L,53L,97L,163L,229L,251L,317L,383L,449L,647L,691L,757L,823L,911L,977L,1021L,1087L,1109L,1153L,1307L,1373L,1439L,1483L,1549L,1571L,1637L,1747L,1879L,1901L,2011L,2099L,2143L,2297L,2341L,2473L,2539L,2671L,2693L,2803L,2957L,3001L,3023L,3067L,3089L,3221L,3331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141856Inst : IEnumerable<long>
{
public static readonly long[] Value=A141856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141856.Bytes);
public long this[int i]=>Value[i];

public static A141856Inst Instance=new A141856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141855
{
public static readonly long[] Value={ 19L,41L,107L,151L,173L,239L,283L,349L,503L,547L,569L,613L,701L,811L,877L,1009L,1031L,1097L,1163L,1229L,1361L,1427L,1471L,1493L,1559L,1669L,1801L,1823L,1867L,1889L,1933L,1999L,2087L,2131L,2153L,2351L,2417L,2549L,2593L,2659L,2791L,2857L,2879L,3011L,3121L,3187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141855Inst : IEnumerable<long>
{
public static readonly long[] Value=A141855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141855.Bytes);
public long this[int i]=>Value[i];

public static A141855Inst Instance=new A141855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141854
{
public static readonly long[] Value={ 7L,29L,73L,139L,227L,271L,293L,337L,359L,491L,557L,601L,733L,821L,887L,953L,997L,1019L,1063L,1129L,1151L,1217L,1283L,1327L,1459L,1481L,1613L,1657L,1723L,1789L,1811L,1877L,1987L,2053L,2141L,2207L,2251L,2273L,2339L,2383L,2647L,2713L,2801L,2999L,3109L,3307L,3329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141854Inst : IEnumerable<long>
{
public static readonly long[] Value=A141854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141854.Bytes);
public long this[int i]=>Value[i];

public static A141854Inst Instance=new A141854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141853
{
public static readonly long[] Value={ 17L,61L,83L,127L,149L,193L,281L,347L,457L,479L,523L,677L,743L,787L,809L,853L,919L,941L,1051L,1117L,1249L,1381L,1447L,1579L,1601L,1667L,1733L,1777L,1931L,1997L,2063L,2129L,2239L,2371L,2393L,2437L,2459L,2503L,2591L,2657L,2767L,2789L,2833L,3119L,3163L,3229L,3251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141853Inst : IEnumerable<long>
{
public static readonly long[] Value=A141853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141853.Bytes);
public long this[int i]=>Value[i];

public static A141853Inst Instance=new A141853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141852
{
public static readonly long[] Value={ 5L,71L,137L,181L,269L,313L,379L,401L,467L,577L,599L,643L,709L,797L,863L,907L,929L,1039L,1061L,1171L,1193L,1237L,1259L,1303L,1523L,1567L,1699L,1721L,1787L,1831L,2029L,2161L,2293L,2381L,2447L,2557L,2579L,2689L,2711L,2777L,2843L,2887L,2909L,2953L,3019L,3041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141852Inst : IEnumerable<long>
{
public static readonly long[] Value=A141852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141852.Bytes);
public long this[int i]=>Value[i];

public static A141852Inst Instance=new A141852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141851
{
public static readonly long[] Value={ 37L,59L,103L,191L,257L,367L,389L,433L,499L,521L,587L,631L,653L,719L,829L,983L,1049L,1093L,1181L,1291L,1423L,1489L,1511L,1621L,1709L,1753L,1907L,1951L,1973L,2017L,2039L,2083L,2237L,2281L,2347L,2633L,2677L,2699L,2897L,2963L,3271L,3359L,3469L,3491L,3557L,3623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141851Inst : IEnumerable<long>
{
public static readonly long[] Value=A141851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141851.Bytes);
public long this[int i]=>Value[i];

public static A141851Inst Instance=new A141851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141850
{
public static readonly long[] Value={ 3L,47L,113L,157L,179L,223L,311L,421L,443L,487L,509L,619L,641L,751L,773L,839L,883L,971L,1103L,1213L,1279L,1301L,1367L,1433L,1499L,1543L,1609L,1697L,1741L,1873L,2027L,2137L,2203L,2269L,2357L,2423L,2467L,2621L,2687L,2731L,2753L,2797L,2819L,3061L,3083L,3259L,3347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141850Inst : IEnumerable<long>
{
public static readonly long[] Value=A141850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141850.Bytes);
public long this[int i]=>Value[i];

public static A141850Inst Instance=new A141850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141849
{
public static readonly long[] Value={ 23L,67L,89L,199L,331L,353L,397L,419L,463L,617L,661L,683L,727L,859L,881L,947L,991L,1013L,1123L,1277L,1321L,1409L,1453L,1607L,1783L,1871L,2003L,2069L,2113L,2179L,2267L,2311L,2333L,2377L,2399L,2531L,2663L,2707L,2729L,2861L,2927L,2971L,3037L,3169L,3191L,3257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141849Inst : IEnumerable<long>
{
public static readonly long[] Value=A141849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141849.Bytes);
public long this[int i]=>Value[i];

public static A141849Inst Instance=new A141849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141848
{
public static readonly long[] Value={ 5L,8L,0L,5L,7L,7L,5L,5L,8L,2L,0L,4L,8L,9L,2L,4L,0L,2L,2L,9L,0L,0L,4L,3L,8L,9L,2L,2L,9L,7L,0L,2L,5L,7L,4L,7L,7L,6L,6L,0L,4L,6L,7L,6L,5L,6L,0L,7L,3L,3L,3L,2L,5L,0L,9L,1L,9L,5L,5L,0L,0L,8L,3L,3L,6L,8L,2L,2L,7L,9L,4L,9L,1L,2L,7L,2L,9L,0L,8L,0L,6L,0L,8L,9L,9L,7L,6L,7L,5L,4L,5L,2L,5L,7L,6L,1L,8L,0L,4L,4L,9L,7L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141848Inst : IEnumerable<long>
{
public static readonly long[] Value=A141848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141848.Bytes);
public long this[int i]=>Value[i];

public static A141848Inst Instance=new A141848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141703
{
public static readonly long[] Value={ 0L,1L,3L,6L,0L,5L,2L,2L,1L,2L,7L,5L,7L,11L,3L,3L,1L,10L,3L,7L,4L,1L,2L,5L,6L,2L,5L,3L,10L,5L,5L,11L,4L,6L,2L,9L,11L,7L,2L,3L,4L,11L,6L,10L,0L,7L,17L,5L,4L,6L,1L,5L,10L,7L,5L,4L,4L,14L,8L,9L,2L,5L,12L,9L,16L,2L,16L,15L,2L,6L,5L,2L,9L,8L,8L,3L,1L,7L,13L,7L,3L,13L,5L,14L,6L,8L,4L,9L,6L,4L,1L,1L,9L,7L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141703Inst : IEnumerable<long>
{
public static readonly long[] Value=A141703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141703.Bytes);
public long this[int i]=>Value[i];

public static A141703Inst Instance=new A141703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141702
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,2L,1L,0L,1L,1L,0L,1L,0L,0L,0L,0L,1L,1L,0L,2L,0L,0L,0L,1L,1L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,2L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,2L,1L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,2L,0L,0L,0L,3L,1L,2L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141702Inst : IEnumerable<long>
{
public static readonly long[] Value=A141702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141702.Bytes);
public long this[int i]=>Value[i];

public static A141702Inst Instance=new A141702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141701
{
public static readonly long[] Value={ 0L,2L,0L,3L,0L,0L,4L,2L,0L,0L,5L,0L,0L,0L,0L,5L,3L,2L,0L,0L,0L,7L,0L,0L,0L,0L,0L,0L,6L,4L,0L,2L,0L,0L,0L,0L,6L,0L,3L,0L,0L,0L,0L,0L,0L,7L,5L,0L,0L,2L,0L,0L,0L,0L,0L,11L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,7L,5L,4L,3L,0L,2L,0L,0L,0L,0L,0L,0L,13L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,9L,7L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141701Inst : IEnumerable<long>
{
public static readonly long[] Value=A141701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141701.Bytes);
public long this[int i]=>Value[i];

public static A141701Inst Instance=new A141701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141700
{
public static readonly long[] Value={ 0L,2L,0L,3L,0L,0L,2L,2L,0L,0L,5L,0L,0L,0L,0L,0L,3L,2L,0L,0L,0L,7L,0L,0L,0L,0L,0L,0L,2L,2L,0L,2L,0L,0L,0L,0L,3L,0L,3L,0L,0L,0L,0L,0L,0L,0L,5L,0L,0L,2L,0L,0L,0L,0L,0L,11L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,3L,0L,2L,0L,0L,0L,0L,0L,0L,13L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,7L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141700Inst : IEnumerable<long>
{
public static readonly long[] Value=A141700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141700.Bytes);
public long this[int i]=>Value[i];

public static A141700Inst Instance=new A141700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141699
{
public static readonly long[] Value={ 34L,39L,46L,51L,55L,68L,69L,74L,82L,85L,87L,91L,92L,93L,94L,95L,106L,111L,115L,117L,118L,119L,123L,129L,133L,134L,136L,141L,142L,145L,148L,153L,155L,158L,159L,164L,177L,178L,183L,184L,187L,188L,194L,202L,203L,205L,207L,212L,213L,214L,215L,217L,219L,226L,235L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141699Inst : IEnumerable<long>
{
public static readonly long[] Value=A141699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141699.Bytes);
public long this[int i]=>Value[i];

public static A141699Inst Instance=new A141699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141698
{
public static readonly long[] Value={ 6L,12L,15L,18L,21L,24L,30L,33L,35L,36L,42L,45L,48L,54L,57L,60L,63L,65L,66L,72L,75L,77L,84L,90L,96L,99L,105L,108L,114L,120L,126L,132L,135L,143L,144L,147L,150L,161L,162L,168L,171L,175L,180L,185L,189L,192L,195L,198L,201L,209L,210L,216L,221L,225L,228L,231L,240L,245L,252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141698Inst : IEnumerable<long>
{
public static readonly long[] Value=A141698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141698.Bytes);
public long this[int i]=>Value[i];

public static A141698Inst Instance=new A141698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141697
{
public static readonly long[] Value={ 1L,1L,1L,1L,16L,1L,1L,59L,59L,1L,1L,158L,426L,158L,1L,1L,369L,2054L,2054L,369L,1L,1L,804L,8247L,16792L,8247L,804L,1L,1L,1687L,29925L,109123L,109123L,29925L,1687L,1L,1L,3466L,102088L,617302L,1092910L,617302L,102088L,3466L,1L,1L,7037L,334664L,3185840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141697Inst : IEnumerable<long>
{
public static readonly long[] Value=A141697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141697.Bytes);
public long this[int i]=>Value[i];

public static A141697Inst Instance=new A141697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141696
{
public static readonly long[] Value={ 1L,1L,1L,1L,8L,1L,1L,27L,27L,1L,1L,70L,186L,70L,1L,1L,161L,886L,886L,161L,1L,1L,348L,3543L,7208L,3543L,348L,1L,1L,727L,12837L,46787L,46787L,12837L,727L,1L,1L,1490L,43768L,264590L,468430L,264590L,43768L,1490L,1L,1L,3021L,143448L,1365408L,3930810L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141696Inst : IEnumerable<long>
{
public static readonly long[] Value=A141696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141696.Bytes);
public long this[int i]=>Value[i];

public static A141696Inst Instance=new A141696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141695
{
public static readonly long[] Value={ 0L,3L,-3L,3L,5L,-8L,3L,5L,7L,-15L,3L,5L,7L,9L,-24L,3L,5L,7L,9L,11L,-35L,3L,5L,7L,9L,11L,13L,-48L,3L,5L,7L,9L,11L,13L,15L,-63L,3L,5L,7L,9L,11L,13L,15L,17L,-80L,3L,5L,7L,9L,11L,13L,15L,17L,19L,-99L,3L,5L,7L,9L,11L,13L,15L,17L,19L,21L,-120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141695Inst : IEnumerable<long>
{
public static readonly long[] Value=A141695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141695.Bytes);
public long this[int i]=>Value[i];

public static A141695Inst Instance=new A141695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141694
{
public static readonly long[] Value={ 12L,34L,56L,78L,100L,122L,144L,166L,188L,210L,232L,254L,276L,298L,320L,342L,364L,386L,408L,430L,452L,474L,496L,518L,540L,562L,584L,606L,628L,650L,672L,694L,716L,738L,760L,782L,804L,826L,848L,870L,892L,914L,936L,958L,980L,1002L,1024L,1046L,1068L,1090L,1112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141694Inst : IEnumerable<long>
{
public static readonly long[] Value=A141694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141694.Bytes);
public long this[int i]=>Value[i];

public static A141694Inst Instance=new A141694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141693
{
public static readonly long[] Value={ 0L,-1L,1L,-2L,0L,2L,-3L,-4L,1L,3L,-4L,-22L,0L,2L,4L,-5L,-78L,-66L,26L,3L,5L,-6L,-228L,-604L,0L,114L,4L,6L,-7L,-600L,-3573L,-2416L,1191L,360L,5L,7L,-8L,-1482L,-17172L,-31238L,0L,8586L,988L,6L,8L,-9L,-3514L,-73040L,-264702L,-156190L,88234L,43824L,2510L,7L,9L,-10L,-8104L,-287040L,-1820768L,-2620708L,0L,910384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141693Inst : IEnumerable<long>
{
public static readonly long[] Value=A141693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141693.Bytes);
public long this[int i]=>Value[i];

public static A141693Inst Instance=new A141693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141692
{
public static readonly long[] Value={ 0L,-1L,1L,-2L,0L,2L,-3L,-3L,3L,3L,-4L,-8L,0L,8L,4L,-5L,-15L,-10L,10L,15L,5L,-6L,-24L,-30L,0L,30L,24L,6L,-7L,-35L,-63L,-35L,35L,63L,35L,7L,-8L,-48L,-112L,-112L,0L,112L,112L,48L,8L,-9L,-63L,-180L,-252L,-126L,126L,252L,180L,63L,9L,-10L,-80L,-270L,-480L,-420L,0L,420L,480L,270L,80L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141692Inst : IEnumerable<long>
{
public static readonly long[] Value=A141692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141692.Bytes);
public long this[int i]=>Value[i];

public static A141692Inst Instance=new A141692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141691
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,15L,15L,1L,1L,37L,96L,37L,1L,1L,83L,448L,448L,83L,1L,1L,177L,1779L,3614L,1779L,177L,1L,1L,367L,6429L,23411L,23411L,6429L,367L,1L,1L,749L,21898L,132323L,234250L,132323L,21898L,749L,1L,1L,1515L,71742L,682746L,1965468L,1965468L,682746L,71742L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141691Inst : IEnumerable<long>
{
public static readonly long[] Value=A141691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141691.Bytes);
public long this[int i]=>Value[i];

public static A141691Inst Instance=new A141691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141690
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,19L,19L,1L,1L,48L,126L,48L,1L,1L,109L,594L,594L,109L,1L,1L,234L,2367L,4812L,2367L,234L,1L,1L,487L,8565L,31203L,31203L,8565L,487L,1L,1L,996L,29188L,176412L,312310L,176412L,29188L,996L,1L,1L,2017L,95644L,910300L,2620582L,2620582L,910300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141690Inst : IEnumerable<long>
{
public static readonly long[] Value=A141690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141690.Bytes);
public long this[int i]=>Value[i];

public static A141690Inst Instance=new A141690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141689
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,7L,7L,1L,1L,15L,36L,15L,1L,1L,31L,156L,156L,31L,1L,1L,63L,603L,1218L,603L,63L,1L,1L,127L,2157L,7827L,7827L,2157L,127L,1L,1L,255L,7318L,44145L,78130L,44145L,7318L,255L,1L,1L,511L,23938L,227638L,655240L,655240L,227638L,23938L,511L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141689Inst : IEnumerable<long>
{
public static readonly long[] Value=A141689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141689.Bytes);
public long this[int i]=>Value[i];

public static A141689Inst Instance=new A141689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141688
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,26L,26L,1L,1L,99L,416L,99L,1L,1L,352L,5407L,5407L,352L,1L,1L,1200L,62616L,227094L,62616L,1200L,1L,1L,3977L,673728L,8212854L,8212854L,673728L,3977L,1L,1L,12918L,6889153L,269486766L,903413940L,269486766L,6889153L,12918L,1L,1L,41338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141688Inst : IEnumerable<long>
{
public static readonly long[] Value=A141688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141688.Bytes);
public long this[int i]=>Value[i];

public static A141688Inst Instance=new A141688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141543
{
public static readonly long[] Value={ 0L,0L,-1L,0L,-2L,1L,0L,-3L,1L,-2L,0L,-4L,1L,-3L,2L,0L,-5L,1L,-4L,2L,-3L,0L,-6L,1L,-5L,2L,-4L,3L,0L,-7L,1L,-6L,2L,-5L,3L,-4L,0L,-8L,1L,-7L,2L,-6L,3L,-5L,4L,0L,-9L,1L,-8L,2L,-7L,3L,-6L,4L,-5L,0L,-10L,1L,-9L,2L,-8L,3L,-7L,4L,-6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141543Inst : IEnumerable<long>
{
public static readonly long[] Value=A141543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141543.Bytes);
public long this[int i]=>Value[i];

public static A141543Inst Instance=new A141543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141542
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,12L,18L,12L,1L,1L,10L,60L,60L,10L,1L,1L,11L,55L,220L,55L,11L,1L,1L,13L,74L,245L,245L,74L,13L,1L,1L,16L,104L,383L,319L,383L,104L,16L,1L,1L,17L,135L,603L,553L,553L,603L,135L,17L,1L,1L,19L,167L,869L,967L,1064L,967L,869L,167L,19L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141542Inst : IEnumerable<long>
{
public static readonly long[] Value=A141542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141542.Bytes);
public long this[int i]=>Value[i];

public static A141542Inst Instance=new A141542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141541
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,8L,8L,1L,1L,10L,18L,10L,1L,1L,12L,29L,29L,12L,1L,1L,14L,44L,56L,44L,14L,1L,1L,17L,61L,99L,99L,61L,17L,1L,1L,19L,82L,158L,198L,158L,82L,19L,1L,1L,22L,105L,236L,357L,357L,236L,105L,22L,1L,1L,24L,131L,338L,594L,713L,594L,338L,131L,24L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141541Inst : IEnumerable<long>
{
public static readonly long[] Value=A141541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141541.Bytes);
public long this[int i]=>Value[i];

public static A141541Inst Instance=new A141541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141540
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,6L,6L,1L,1L,8L,12L,8L,1L,1L,10L,20L,20L,10L,1L,1L,12L,30L,40L,30L,12L,1L,1L,14L,42L,70L,70L,42L,14L,1L,1L,16L,56L,112L,140L,112L,56L,16L,1L,1L,18L,72L,168L,252L,252L,168L,72L,18L,1L,1L,20L,90L,240L,420L,504L,420L,240L,90L,20L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141540Inst : IEnumerable<long>
{
public static readonly long[] Value=A141540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141540.Bytes);
public long this[int i]=>Value[i];

public static A141540Inst Instance=new A141540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141539
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,4L,1L,2L,3L,8L,1L,2L,3L,5L,16L,1L,2L,3L,4L,8L,32L,1L,2L,3L,4L,6L,13L,64L,1L,2L,3L,4L,5L,9L,21L,128L,1L,2L,3L,4L,5L,7L,13L,34L,256L,1L,2L,3L,4L,5L,6L,10L,19L,55L,512L,1L,2L,3L,4L,5L,6L,8L,14L,28L,89L,1024L,1L,2L,3L,4L,5L,6L,7L,11L,19L,41L,144L,2048L,1L,2L,3L,4L,5L,6L,7L,9L,15L,26L,60L,233L,4096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141539Inst : IEnumerable<long>
{
public static readonly long[] Value=A141539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141539.Bytes);
public long this[int i]=>Value[i];

public static A141539Inst Instance=new A141539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141538
{
public static readonly long[] Value={ 5L,5L,8L,7L,3L,9L,5L,7L,4L,7L,3L,7L,3L,0L,4L,6L,0L,4L,3L,9L,5L,2L,0L,9L,1L,2L,7L,6L,1L,7L,5L,0L,0L,4L,4L,9L,8L,2L,9L,0L,9L,0L,2L,0L,1L,0L,6L,2L,4L,5L,4L,5L,4L,8L,2L,1L,2L,7L,0L,7L,1L,8L,2L,0L,5L,6L,4L,9L,7L,0L,2L,9L,5L,3L,1L,4L,9L,2L,6L,1L,0L,1L,2L,2L,8L,6L,6L,0L,3L,0L,4L,2L,1L,9L,1L,2L,3L,1L,6L,3L,5L,7L,4L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141538Inst : IEnumerable<long>
{
public static readonly long[] Value=A141538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141538.Bytes);
public long this[int i]=>Value[i];

public static A141538Inst Instance=new A141538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141537
{
public static readonly long[] Value={ 47L,227L,71L,359L,113L,563L,173L,839L,251L,1187L,347L,1607L,461L,2099L,593L,2663L,743L,3299L,911L,4007L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141537Inst : IEnumerable<long>
{
public static readonly long[] Value=A141537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141537.Bytes);
public long this[int i]=>Value[i];

public static A141537Inst Instance=new A141537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141536
{
public static readonly long[] Value={ 5L,8L,16L,10L,30L,64L,120L,192L,384L,1152L,14400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141536Inst : IEnumerable<long>
{
public static readonly long[] Value=A141536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141536.Bytes);
public long this[int i]=>Value[i];

public static A141536Inst Instance=new A141536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141535
{
public static readonly long[] Value={ 0L,3L,12L,105L,168L,444L,603L,1158L,2550L,3060L,5469L,7518L,8568L,11292L,16563L,23217L,25458L,34167L,40740L,43998L,56307L,65391L,81210L,106272L,120000L,126750L,142155L,149685L,166863L,241152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141535Inst : IEnumerable<long>
{
public static readonly long[] Value=A141535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141535.Bytes);
public long this[int i]=>Value[i];

public static A141535Inst Instance=new A141535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141534
{
public static readonly long[] Value={ 1L,4L,11L,26L,55L,105L,184L,301L,466L,690L,985L,1364L,1841L,2431L,3150L,4015L,5044L,6256L,7671L,9310L,11195L,13349L,15796L,18561L,21670L,25150L,29029L,33336L,38101L,43355L,49130L,55459L,62376L,69916L,78115L,87010L,96639L,107041L,118256L,130325L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141534Inst : IEnumerable<long>
{
public static readonly long[] Value=A141534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141534.Bytes);
public long this[int i]=>Value[i];

public static A141534Inst Instance=new A141534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141533
{
public static readonly long[] Value={ 1L,-1L,-2L,23L,28L,-7L,22L,251L,376L,149L,658L,3143L,5188L,4913L,13102L,42611L,75376L,101549L,232618L,612863L,1137148L,1831433L,3928582L,9185771L,17574376L,31162949L,64717378L,141392183L,275609908L,515347553L,1052218462L,2212053731L,4359537376L,8396224349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141533Inst : IEnumerable<long>
{
public static readonly long[] Value=A141533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141533.Bytes);
public long this[int i]=>Value[i];

public static A141533Inst Instance=new A141533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141532
{
public static readonly long[] Value={ 1L,1L,1L,-2L,4L,-8L,7L,22L,-125L,376L,-878L,1756L,-3143L,5188L,-8189L,13102L,-22928L,45856L,-101549L,232618L,-524285L,1137148L,-2362874L,4725748L,-9185771L,17574376L,-33554429L,64717378L,-127043276L,254086552L,-515347553L,1052218462L,-2147483645L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141532Inst : IEnumerable<long>
{
public static readonly long[] Value=A141532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141532.Bytes);
public long this[int i]=>Value[i];

public static A141532Inst Instance=new A141532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141531
{
public static readonly long[] Value={ 1L,1L,1L,-2L,4L,-8L,16L,-32L,64L,-128L,256L,-512L,1024L,-2048L,4096L,-8192L,16384L,-32768L,65536L,-131072L,262144L,-524288L,1048576L,-2097152L,4194304L,-8388608L,16777216L,-33554432L,67108864L,-134217728L,268435456L,-536870912L,1073741824L,-2147483648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141531Inst : IEnumerable<long>
{
public static readonly long[] Value=A141531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141531.Bytes);
public long this[int i]=>Value[i];

public static A141531Inst Instance=new A141531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141530
{
public static readonly long[] Value={ 1L,-1L,9L,55L,161L,351L,649L,1079L,1665L,2431L,3401L,4599L,6049L,7775L,9801L,12151L,14849L,17919L,21385L,25271L,29601L,34399L,39689L,45495L,51841L,58751L,66249L,74359L,83105L,92511L,102601L,113399L,124929L,137215L,150281L,164151L,178849L,194399L,210825L,228151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141530Inst : IEnumerable<long>
{
public static readonly long[] Value=A141530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141530.Bytes);
public long this[int i]=>Value[i];

public static A141530Inst Instance=new A141530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141529
{
public static readonly long[] Value={ 31L,29L,23L,19L,17L,13L,11L,7L,5L,3L,2L,31L,29L,23L,19L,17L,13L,11L,7L,5L,3L,2L,31L,29L,23L,19L,17L,13L,11L,7L,5L,3L,2L,31L,29L,23L,19L,17L,13L,11L,7L,5L,3L,2L,31L,29L,23L,19L,17L,13L,11L,7L,5L,3L,2L,31L,29L,23L,19L,17L,13L,11L,7L,5L,3L,2L,31L,29L,23L,19L,17L,13L,11L,7L,5L,3L,2L,31L,29L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141529Inst : IEnumerable<long>
{
public static readonly long[] Value=A141529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141529.Bytes);
public long this[int i]=>Value[i];

public static A141529Inst Instance=new A141529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141528
{
public static readonly long[] Value={ 0L,-1L,1L,40L,-81L,-1559L,4880L,59039L,-259119L,-2161480L,12785359L,75835321L,-600035040L,-2509213121L,27110649761L,75767088200L,-1187303728401L,-1919146887799L,50598599752240L,28086422647519L,-2102629012489359L,951085683941080L,85256703828122639L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141528Inst : IEnumerable<long>
{
public static readonly long[] Value=A141528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141528.Bytes);
public long this[int i]=>Value[i];

public static A141528Inst Instance=new A141528Inst();

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