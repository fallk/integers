using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A092063
{
public static readonly long[] Value={ 2L,3L,4L,7L,8L,15L,19L,21L,22L,25L,26L,31L,34L,45L,46L,52L,65L,69L,79L,85L,89L,98L,102L,122L,137L,149L,181L,195L,210L,220L,316L,325L,340L,385L,436L,466L,497L,934L,972L,1180L,1211L,1212L,1639L,1807L,2075L,2104L,3100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092063Inst : IEnumerable<long>
{
public static readonly long[] Value=A092063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092063.Bytes);
public long this[int i]=>Value[i];

public static A092063Inst Instance=new A092063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092064
{
public static readonly long[] Value={ 2L,3L,7L,19L,31L,79L,89L,137L,149L,181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092064Inst : IEnumerable<long>
{
public static readonly long[] Value=A092064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092064.Bytes);
public long this[int i]=>Value[i];

public static A092064Inst Instance=new A092064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092065
{
public static readonly long[] Value={ 2L,3L,4L,5L,7L,14L,21L,22L,26L,27L,32L,43L,51L,58L,62L,65L,82L,131L,148L,207L,229L,249L,257L,320L,334L,386L,423L,440L,481L,747L,823L,1181L,1314L,1915L,2025L,2269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092065Inst : IEnumerable<long>
{
public static readonly long[] Value=A092065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092065.Bytes);
public long this[int i]=>Value[i];

public static A092065Inst Instance=new A092065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092066
{
public static readonly long[] Value={ 2L,3L,5L,7L,43L,131L,229L,257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092066Inst : IEnumerable<long>
{
public static readonly long[] Value=A092066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092066.Bytes);
public long this[int i]=>Value[i];

public static A092066Inst Instance=new A092066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092067
{
public static readonly long[] Value={ 2L,3L,2L,5L,2L,7L,2L,3L,2L,11L,2L,13L,2L,3L,2L,17L,2L,19L,2L,3L,2L,23L,2L,5L,2L,3L,2L,29L,2L,31L,2L,3L,2L,5L,2L,37L,2L,3L,2L,41L,2L,43L,2L,3L,2L,47L,2L,7L,2L,3L,2L,53L,2L,5L,2L,3L,2L,59L,2L,61L,2L,3L,2L,5L,2L,67L,2L,3L,2L,71L,2L,73L,2L,3L,2L,7L,2L,79L,2L,3L,2L,83L,2L,5L,2L,3L,2L,89L,2L,7L,2L,3L,2L,5L,2L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092067Inst : IEnumerable<long>
{
public static readonly long[] Value=A092067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092067.Bytes);
public long this[int i]=>Value[i];

public static A092067Inst Instance=new A092067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092116
{
public static readonly long[] Value={ 4L,18L,33L,42L,43L,57L,73L,76L,78L,87L,91L,93L,97L,102L,112L,114L,120L,141L,151L,177L,186L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092116Inst : IEnumerable<long>
{
public static readonly long[] Value=A092116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092116.Bytes);
public long this[int i]=>Value[i];

public static A092116Inst Instance=new A092116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092117
{
public static readonly long[] Value={ 10L,43L,51L,55L,58L,60L,136L,171L,204L,213L,214L,222L,270L,288L,309L,334L,339L,364L,366L,376L,414L,423L,460L,477L,492L,501L,502L,507L,513L,519L,565L,585L,586L,597L,621L,649L,726L,729L,787L,852L,861L,870L,903L,906L,915L,933L,946L,981L,988L,1005L,1038L,1071L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092117Inst : IEnumerable<long>
{
public static readonly long[] Value=A092117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092117.Bytes);
public long this[int i]=>Value[i];

public static A092117Inst Instance=new A092117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092118
{
public static readonly BigInteger[] Value={ BigInteger.Parse("1322314049613223140496"),BigInteger.Parse("2066115702520661157025"),BigInteger.Parse("2975206611629752066116"),BigInteger.Parse("4049586776940495867769"),BigInteger.Parse("5289256198452892561984"),BigInteger.Parse("6694214876166942148761"),BigInteger.Parse("8264462810082644628100"),BigInteger.Parse("183673469387755102041183673469387755102041") };
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
public class A092118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092118Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A092118.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A092118.Bytes);
public BigInteger this[int i]=>Value[i];

public static A092118Inst Instance=new A092118Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092119
{
public static readonly long[] Value={ 1L,1L,3L,4L,10L,13L,26L,35L,66L,88L,150L,202L,331L,442L,688L,919L,1394L,1848L,2716L,3590L,5174L,6796L,9589L,12542L,17440L,22680L,31055L,40208L,54420L,70096L,93772L,120256L,159380L,203436L,267142L,339573L,442478L,560050L,724302L,913198L,1173375L,1473622L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092119Inst : IEnumerable<long>
{
public static readonly long[] Value=A092119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092119.Bytes);
public long this[int i]=>Value[i];

public static A092119Inst Instance=new A092119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092120
{
public static readonly long[] Value={ 19L,3L,277L,43L,53593L,7L,67L,37L,1483087L,1867783L,9671300983L,376040154163L,13491637509487L,604490757900187L,409333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092120Inst : IEnumerable<long>
{
public static readonly long[] Value=A092120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092120.Bytes);
public long this[int i]=>Value[i];

public static A092120Inst Instance=new A092120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092121
{
public static readonly long[] Value={ 6L,8L,10L,12L,16L,16L,20L,24L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092121Inst : IEnumerable<long>
{
public static readonly long[] Value=A092121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092121.Bytes);
public long this[int i]=>Value[i];

public static A092121Inst Instance=new A092121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092122
{
public static readonly long[] Value={ 6L,154L,310L,370L,2829L,3526L,15320L,20462L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092122Inst : IEnumerable<long>
{
public static readonly long[] Value=A092122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092122.Bytes);
public long this[int i]=>Value[i];

public static A092122Inst Instance=new A092122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092123
{
public static readonly BigInteger[] Value={ 1L,1L,2L,10L,302L,391232L,912140731560L,BigInteger.Parse("6870302396056798235043564"),BigInteger.Parse("552249828443015013351729477795257932661645918815144") };
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
public class A092123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092123Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A092123.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A092123.Bytes);
public BigInteger this[int i]=>Value[i];

public static A092123Inst Instance=new A092123Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092124
{
public static readonly BigInteger[] Value={ 2L,12L,216L,55728L,3652301664L,15686516209310983872UL,BigInteger.Parse("289365149921256212111714425927549504896"),BigInteger.Parse("98465858119637274097902770931519409290135390781788892125023848289699334298368") };
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
public class A092124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092124Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A092124.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A092124.Bytes);
public BigInteger this[int i]=>Value[i];

public static A092124Inst Instance=new A092124Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092125
{
public static readonly long[] Value={ 91L,119L,141L,183L,201L,213L,215L,217L,287L,299L,301L,319L,391L,411L,413L,469L,515L,533L,579L,667L,685L,695L,789L,813L,1055L,1077L,1133L,1135L,1137L,1145L,1165L,1203L,1253L,1313L,1343L,1345L,1347L,1383L,1385L,1387L,1389L,1401L,1561L,1639L,1685L,1687L,1761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092125Inst : IEnumerable<long>
{
public static readonly long[] Value=A092125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092125.Bytes);
public long this[int i]=>Value[i];

public static A092125Inst Instance=new A092125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092126
{
public static readonly long[] Value={ 213L,215L,299L,411L,1133L,1135L,1343L,1345L,1383L,1385L,1387L,1685L,1793L,1835L,1837L,1891L,1937L,1939L,1957L,2045L,2315L,2317L,2513L,2567L,2807L,2809L,2929L,3091L,3093L,3095L,3097L,3147L,3149L,3647L,3957L,3977L,3979L,4115L,4313L,4315L,4411L,4529L,4531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092126Inst : IEnumerable<long>
{
public static readonly long[] Value=A092126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092126.Bytes);
public long this[int i]=>Value[i];

public static A092126Inst Instance=new A092126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092127
{
public static readonly long[] Value={ 213L,1133L,1343L,1383L,1385L,1835L,1937L,2315L,2807L,3091L,3093L,3095L,3147L,3977L,4313L,4529L,4835L,5089L,5609L,5611L,6185L,6533L,7141L,8129L,8131L,8133L,8135L,9753L,9755L,9983L,9985L,9987L,9989L,10401L,10403L,11013L,11015L,11099L,11663L,12053L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092127Inst : IEnumerable<long>
{
public static readonly long[] Value=A092127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092127.Bytes);
public long this[int i]=>Value[i];

public static A092127Inst Instance=new A092127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092128
{
public static readonly long[] Value={ 1383L,3091L,3093L,5609L,8129L,8131L,8133L,9753L,9983L,9985L,9987L,10401L,11013L,12053L,13637L,16499L,22457L,30991L,43339L,45803L,49083L,53761L,55559L,55561L,58277L,63047L,63951L,64829L,69603L,71727L,76803L,80633L,92603L,92605L,98493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092128Inst : IEnumerable<long>
{
public static readonly long[] Value=A092128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092128.Bytes);
public long this[int i]=>Value[i];

public static A092128Inst Instance=new A092128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092129
{
public static readonly long[] Value={ 3091L,8129L,8131L,9983L,9985L,55559L,92603L,99443L,99445L,112709L,132077L,132079L,182749L,190937L,190939L,209479L,237449L,237451L,239089L,249689L,296779L,300449L,313411L,401429L,401431L,441677L,441679L,452639L,452641L,547157L,604487L,604489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092129Inst : IEnumerable<long>
{
public static readonly long[] Value=A092129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092129.Bytes);
public long this[int i]=>Value[i];

public static A092129Inst Instance=new A092129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092130
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,2L,0L,1L,2L,1L,1L,3L,1L,1L,3L,2L,1L,4L,3L,1L,4L,4L,2L,5L,5L,2L,5L,7L,3L,6L,8L,4L,6L,10L,6L,7L,12L,7L,8L,14L,10L,9L,16L,12L,10L,19L,16L,12L,21L,19L,14L,24L,24L,17L,27L,28L,20L,31L,35L,24L,34L,40L,29L,39L,48L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092130Inst : IEnumerable<long>
{
public static readonly long[] Value=A092130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092130.Bytes);
public long this[int i]=>Value[i];

public static A092130Inst Instance=new A092130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092131
{
public static readonly long[] Value={ 0L,1L,3L,1L,5L,3L,3L,1L,9L,7L,5L,3L,17L,27L,3L,1L,29L,3L,21L,7L,17L,15L,9L,43L,35L,15L,29L,3L,11L,3L,11L,15L,17L,25L,53L,31L,9L,7L,23L,15L,27L,15L,29L,7L,59L,15L,5L,21L,69L,55L,21L,21L,5L,159L,3L,81L,9L,69L,131L,33L,15L,135L,29L,13L,131L,9L,3L,33L,29L,25L,11L,15L,29L,37L,33L,15L,11L,7L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092131Inst : IEnumerable<long>
{
public static readonly long[] Value=A092131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092131.Bytes);
public long this[int i]=>Value[i];

public static A092131Inst Instance=new A092131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092148
{
public static readonly BigInteger[] Value={ 1L,3L,11L,85L,739L,7831L,96641L,1363209L,21632759L,381433771L,7398080029L,156533563693L,3588046200179L,88571349871551L,2342565398442569L,66087436823953681L,1980956920420309231L,BigInteger.Parse("62871632567144951635") };
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
public class A092148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092148Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A092148.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A092148.Bytes);
public BigInteger this[int i]=>Value[i];

public static A092148Inst Instance=new A092148Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092149
{
public static readonly long[] Value={ 1L,-1L,-2L,-1L,-2L,0L,-1L,-1L,-1L,1L,0L,-1L,-2L,0L,1L,1L,0L,0L,-1L,-2L,-1L,1L,0L,0L,0L,2L,2L,1L,0L,-2L,-3L,-3L,-2L,0L,1L,1L,0L,2L,3L,3L,2L,0L,-1L,-2L,-2L,0L,-1L,-1L,-1L,-1L,0L,-1L,-2L,-2L,-1L,-1L,0L,2L,1L,2L,1L,3L,3L,3L,4L,2L,1L,0L,1L,-1L,-2L,-2L,-3L,-1L,-1L,-2L,-1L,-3L,-4L,-4L,-4L,-2L,-3L,-2L,-1L,1L,2L,2L,1L,1L,2L,1L,2L,4L,5L,5L,4L,4L,4L,4L,3L,1L,0L,0L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092149Inst : IEnumerable<long>
{
public static readonly long[] Value=A092149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092149.Bytes);
public long this[int i]=>Value[i];

public static A092149Inst Instance=new A092149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092150
{
public static readonly long[] Value={ 0L,3L,6L,7L,12L,12L,19L,23L,29L,31L,42L,47L,60L,64L,71L,79L,96L,102L,121L,130L,141L,149L,172L,180L,200L,210L,228L,241L,270L,280L,311L,327L,346L,360L,383L,395L,432L,448L,471L,487L,528L,542L,585L,606L,630L,650L,697L,713L,755L,775L,806L,831L,884L,902L,941L,965L,1000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092150Inst : IEnumerable<long>
{
public static readonly long[] Value=A092150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092150.Bytes);
public long this[int i]=>Value[i];

public static A092150Inst Instance=new A092150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092151
{
public static readonly long[] Value={ 0L,-6L,-3L,1L,-5L,0L,-7L,0L,0L,4L,-11L,-5L,-13L,8L,7L,0L,-17L,0L,-19L,-9L,11L,16L,-23L,0L,0L,20L,0L,-13L,-29L,-20L,-31L,0L,19L,28L,23L,0L,-37L,32L,23L,0L,-41L,-28L,-43L,-21L,0L,40L,-47L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092151Inst : IEnumerable<long>
{
public static readonly long[] Value=A092151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092151.Bytes);
public long this[int i]=>Value[i];

public static A092151Inst Instance=new A092151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092152
{
public static readonly long[] Value={ 1L,-1L,-1L,1L,-1L,1L,-1L,0L,0L,1L,-1L,-1L,-1L,1L,1L,0L,-1L,0L,-1L,-1L,1L,1L,-1L,0L,0L,1L,0L,-1L,-1L,-1L,-1L,0L,1L,1L,1L,0L,-1L,1L,1L,0L,-1L,-1L,-1L,-1L,0L,1L,-1L,0L,0L,0L,1L,-1L,-1L,0L,1L,0L,1L,1L,-1L,1L,-1L,1L,0L,0L,1L,-1L,-1L,-1L,1L,-1L,-1L,0L,-1L,1L,0L,-1L,1L,-1L,-1L,0L,0L,1L,-1L,1L,1L,1L,1L,0L,-1L,0L,1L,-1L,1L,1L,1L,0L,-1L,0L,0L,0L,-1L,-1L,-1L,0L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092152Inst : IEnumerable<long>
{
public static readonly long[] Value=A092152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092152.Bytes);
public long this[int i]=>Value[i];

public static A092152Inst Instance=new A092152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092153
{
public static readonly long[] Value={ 208L,249L,273L,408L,434L,459L,494L,698L,808L,928L,954L,1038L,1069L,1244L,1489L,1684L,1698L,1718L,1753L,2054L,2263L,2264L,2383L,2389L,2774L,2804L,3078L,3258L,3514L,4333L,4669L,5058L,5094L,5098L,5138L,5169L,5378L,5393L,5604L,7394L,7424L,8013L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092153Inst : IEnumerable<long>
{
public static readonly long[] Value=A092153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092153.Bytes);
public long this[int i]=>Value[i];

public static A092153Inst Instance=new A092153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092154
{
public static readonly long[] Value={ 3L,0L,-2L,4L,-5L,7L,-3L,2L,-4L,9L,-6L,8L,-9L,3L,1L,9L,-11L,13L,-10L,2L,-3L,15L,-15L,12L,-10L,8L,-5L,16L,-19L,21L,-15L,3L,-5L,9L,-11L,25L,-21L,7L,-7L,25L,-27L,29L,-22L,3L,-4L,27L,-31L,26L,-22L,11L,-6L,28L,-35L,21L,-15L,11L,-9L,33L,-44L,46L,-33L,8L,-4L,15L,-25L,45L,-34L,10L,-17L,45L,-47L,49L,-39L,6L,-3L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092154Inst : IEnumerable<long>
{
public static readonly long[] Value=A092154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092154.Bytes);
public long this[int i]=>Value[i];

public static A092154Inst Instance=new A092154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092155
{
public static readonly long[] Value={ -3L,1L,2L,-2L,3L,-3L,1L,0L,2L,-3L,0L,0L,3L,-1L,-1L,-1L,1L,-1L,0L,2L,1L,-3L,1L,0L,2L,-2L,-1L,0L,-1L,1L,1L,1L,1L,-1L,-1L,-1L,3L,-1L,-1L,-1L,-1L,1L,0L,1L,2L,-3L,1L,0L,0L,1L,-2L,0L,1L,1L,-1L,1L,1L,-3L,2L,-2L,3L,-2L,0L,1L,-3L,1L,0L,2L,-3L,1L,1L,-1L,3L,-2L,-1L,2L,-3L,1L,1L,0L,2L,-3L,2L,0L,1L,-1L,-1L,-1L,1L,1L,-2L,2L,1L,-1L,-1L,-1L,1L,0L,0L,-1L,-1L,1L,1L,-1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092155Inst : IEnumerable<long>
{
public static readonly long[] Value=A092155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092155.Bytes);
public long this[int i]=>Value[i];

public static A092155Inst Instance=new A092155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092156
{
public static readonly long[] Value={ 1L,5L,4L,3L,7L,1L,1L,6L,1L,6L,9L,1L,4L,9L,9L,2L,6L,0L,4L,1L,8L,7L,7L,3L,8L,7L,2L,6L,6L,7L,6L,0L,5L,4L,8L,3L,4L,2L,9L,2L,4L,1L,3L,7L,6L,9L,0L,3L,3L,3L,7L,1L,8L,0L,3L,9L,6L,5L,3L,3L,7L,6L,5L,9L,7L,8L,7L,4L,9L,1L,1L,3L,2L,7L,7L,3L,3L,4L,8L,3L,7L,6L,0L,0L,7L,8L,5L,4L,6L,4L,5L,3L,9L,3L,7L,1L,2L,2L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092156Inst : IEnumerable<long>
{
public static readonly long[] Value=A092156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092156.Bytes);
public long this[int i]=>Value[i];

public static A092156Inst Instance=new A092156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092157
{
public static readonly long[] Value={ 1L,7L,8L,4L,1L,0L,9L,7L,3L,5L,8L,5L,8L,6L,2L,3L,0L,0L,4L,8L,0L,0L,6L,7L,5L,1L,8L,9L,9L,8L,7L,3L,7L,5L,3L,0L,8L,5L,5L,1L,2L,8L,6L,0L,2L,9L,0L,7L,0L,5L,7L,0L,5L,9L,3L,2L,0L,4L,3L,4L,8L,0L,2L,9L,4L,6L,4L,6L,7L,6L,2L,6L,8L,1L,1L,8L,5L,2L,7L,7L,6L,6L,1L,0L,7L,9L,4L,1L,7L,8L,1L,2L,9L,9L,9L,9L,7L,7L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092157Inst : IEnumerable<long>
{
public static readonly long[] Value=A092157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092157.Bytes);
public long this[int i]=>Value[i];

public static A092157Inst Instance=new A092157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092158
{
public static readonly long[] Value={ 2L,0L,6L,1L,9L,4L,4L,4L,1L,6L,7L,6L,0L,0L,6L,7L,7L,4L,1L,3L,5L,4L,1L,2L,3L,2L,9L,5L,8L,3L,3L,5L,7L,7L,8L,3L,2L,9L,0L,8L,6L,9L,2L,1L,7L,2L,3L,3L,9L,5L,3L,6L,1L,4L,2L,8L,4L,1L,4L,5L,3L,0L,1L,5L,7L,1L,7L,1L,6L,9L,1L,8L,0L,7L,4L,4L,1L,8L,0L,6L,2L,1L,5L,4L,5L,8L,5L,3L,7L,1L,8L,4L,4L,6L,7L,4L,1L,9L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092158Inst : IEnumerable<long>
{
public static readonly long[] Value=A092158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092158.Bytes);
public long this[int i]=>Value[i];

public static A092158Inst Instance=new A092158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092159
{
public static readonly long[] Value={ 4L,8L,4L,9L,7L,9L,1L,2L,5L,4L,6L,6L,0L,9L,7L,4L,3L,8L,9L,2L,4L,8L,9L,3L,5L,7L,0L,5L,5L,0L,0L,2L,6L,8L,8L,8L,2L,5L,7L,0L,5L,4L,8L,1L,0L,5L,0L,5L,0L,5L,1L,3L,2L,0L,3L,2L,0L,6L,2L,9L,0L,2L,5L,6L,0L,0L,3L,9L,6L,9L,2L,8L,7L,7L,0L,2L,2L,5L,5L,4L,5L,0L,5L,0L,3L,0L,9L,4L,7L,5L,3L,1L,3L,1L,6L,4L,9L,5L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092159Inst : IEnumerable<long>
{
public static readonly long[] Value=A092159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092159.Bytes);
public long this[int i]=>Value[i];

public static A092159Inst Instance=new A092159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092160
{
public static readonly long[] Value={ 6L,4L,7L,7L,8L,9L,3L,8L,5L,6L,8L,7L,4L,8L,6L,7L,8L,9L,6L,4L,7L,0L,0L,5L,5L,3L,0L,9L,2L,2L,9L,8L,1L,4L,1L,9L,4L,9L,7L,7L,7L,3L,2L,8L,4L,9L,9L,3L,5L,3L,0L,8L,7L,8L,7L,9L,4L,8L,8L,5L,6L,6L,7L,4L,0L,6L,2L,3L,3L,3L,0L,2L,8L,1L,4L,0L,5L,4L,8L,0L,5L,8L,7L,2L,5L,1L,6L,3L,0L,1L,5L,5L,7L,2L,0L,6L,5L,7L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092160Inst : IEnumerable<long>
{
public static readonly long[] Value=A092160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092160.Bytes);
public long this[int i]=>Value[i];

public static A092160Inst Instance=new A092160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092161
{
public static readonly long[] Value={ 5L,6L,0L,5L,0L,3L,6L,3L,9L,3L,7L,8L,8L,5L,1L,7L,0L,5L,5L,2L,8L,5L,3L,7L,0L,6L,4L,2L,1L,8L,3L,5L,4L,6L,5L,8L,7L,6L,9L,1L,5L,3L,1L,1L,7L,7L,5L,8L,4L,0L,0L,4L,9L,9L,7L,3L,0L,7L,0L,4L,3L,1L,7L,4L,9L,7L,7L,3L,2L,0L,5L,1L,4L,1L,8L,1L,0L,5L,6L,1L,6L,8L,7L,0L,1L,6L,0L,5L,9L,8L,4L,1L,5L,3L,9L,1L,1L,7L,5L,2L,6L,9L,8L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092161Inst : IEnumerable<long>
{
public static readonly long[] Value=A092161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092161.Bytes);
public long this[int i]=>Value[i];

public static A092161Inst Instance=new A092161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092162
{
public static readonly long[] Value={ 4L,1L,9L,6L,3L,1L,0L,8L,8L,2L,0L,9L,3L,7L,1L,5L,1L,4L,7L,9L,4L,7L,5L,4L,2L,4L,5L,8L,7L,5L,5L,3L,9L,2L,6L,3L,4L,6L,3L,3L,5L,6L,6L,9L,2L,1L,5L,0L,0L,7L,9L,5L,5L,6L,4L,6L,2L,9L,7L,8L,8L,9L,1L,4L,3L,1L,1L,7L,0L,6L,3L,9L,7L,1L,4L,4L,5L,8L,0L,8L,8L,9L,5L,1L,1L,4L,1L,3L,3L,8L,7L,4L,0L,8L,9L,0L,5L,1L,2L,0L,7L,0L,5L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092162Inst : IEnumerable<long>
{
public static readonly long[] Value=A092162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092162.Bytes);
public long this[int i]=>Value[i];

public static A092162Inst Instance=new A092162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092163
{
public static readonly long[] Value={ 8L,18L,30L,42L,60L,78L,90L,112L,128L,144L,162L,186L,204L,216L,240L,268L,288L,308L,330L,352L,372L,390L,410L,450L,462L,480L,508L,532L,548L,564L,600L,624L,648L,684L,702L,726L,752L,772L,798L,828L,852L,872L,892L,918L,930L,966L,990L,1012L,1044L,1088L,1120L,1140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092163Inst : IEnumerable<long>
{
public static readonly long[] Value=A092163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092163.Bytes);
public long this[int i]=>Value[i];

public static A092163Inst Instance=new A092163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092260
{
public static readonly long[] Value={ 1L,11L,2L,13L,10L,3L,23L,14L,9L,4L,25L,22L,15L,8L,5L,35L,26L,21L,16L,7L,6L,37L,34L,27L,20L,17L,12L,47L,38L,33L,28L,19L,18L,49L,46L,39L,32L,29L,24L,59L,50L,45L,40L,31L,30L,61L,58L,51L,44L,41L,36L,71L,62L,57L,52L,43L,42L,73L,70L,63L,56L,53L,48L,83L,74L,69L,64L,55L,54L,85L,82L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092260Inst : IEnumerable<long>
{
public static readonly long[] Value=A092260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092260.Bytes);
public long this[int i]=>Value[i];

public static A092260Inst Instance=new A092260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092261
{
public static readonly long[] Value={ 1L,3L,4L,1L,6L,12L,8L,1L,1L,18L,12L,4L,14L,24L,24L,1L,18L,3L,20L,6L,32L,36L,24L,4L,1L,42L,1L,8L,30L,72L,32L,1L,48L,54L,48L,1L,38L,60L,56L,6L,42L,96L,44L,12L,6L,72L,48L,4L,1L,3L,72L,14L,54L,3L,72L,8L,80L,90L,60L,24L,62L,96L,8L,1L,84L,144L,68L,18L,96L,144L,72L,1L,74L,114L,4L,20L,96L,168L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092261Inst : IEnumerable<long>
{
public static readonly long[] Value=A092261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092261.Bytes);
public long this[int i]=>Value[i];

public static A092261Inst Instance=new A092261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092262
{
public static readonly long[] Value={ 2L,5L,13L,79L,181L,409L,2053L,21011L,96487L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092262Inst : IEnumerable<long>
{
public static readonly long[] Value=A092262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092262.Bytes);
public long this[int i]=>Value[i];

public static A092262Inst Instance=new A092262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092263
{
public static readonly long[] Value={ 1L,3L,6L,10L,17L,29L,48L,78L,127L,207L,336L,544L,881L,1427L,2310L,3738L,6049L,9789L,15840L,25630L,41471L,67103L,108576L,175680L,284257L,459939L,744198L,1204138L,1948337L,3152477L,5100816L,8253294L,13354111L,21607407L,34961520L,56568928L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092263Inst : IEnumerable<long>
{
public static readonly long[] Value=A092263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092263.Bytes);
public long this[int i]=>Value[i];

public static A092263Inst Instance=new A092263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092264
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,5L,9L,17L,65L,117L,227L,449L,1737L,3137L,6105L,12097L,46819L,84565L,164593L,326161L,1262361L,2280101L,4437891L,8794241L,34036913L,61478145L,119658449L,237118337L,917734275L,1657629797L,3226340217L,6393400849L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092264Inst : IEnumerable<long>
{
public static readonly long[] Value=A092264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092264.Bytes);
public long this[int i]=>Value[i];

public static A092264Inst Instance=new A092264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092265
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,10L,14L,16L,23L,26L,34L,40L,50L,58L,74L,83L,102L,120L,142L,164L,198L,226L,266L,308L,359L,412L,482L,548L,634L,730L,834L,950L,1094L,1240L,1416L,1609L,1826L,2068L,2350L,2648L,2994L,3382L,3806L,4280L,4826L,5408L,6070L,6806L,7619L,8522L,9534L,10632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092265Inst : IEnumerable<long>
{
public static readonly long[] Value=A092265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092265.Bytes);
public long this[int i]=>Value[i];

public static A092265Inst Instance=new A092265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092266
{
public static readonly long[] Value={ 1L,4L,4L,16L,36L,144L,400L,1600L,4900L,19600L,63504L,254016L,853776L,3415104L,11778624L,47114496L,165636900L,662547600L,2363904400L,9455617600L,34134779536L,136539118144L,497634306624L,1990537226496L,7312459672336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092266Inst : IEnumerable<long>
{
public static readonly long[] Value=A092266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092266.Bytes);
public long this[int i]=>Value[i];

public static A092266Inst Instance=new A092266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092267
{
public static readonly BigInteger[] Value={ 1L,454L,45891L,547208496L,3013267310449L,1961694770407970734L,BigInteger.Parse("589785633779065944213245"),BigInteger.Parse("20963601300674244910397534828794"),BigInteger.Parse("344117353602393170461608383214200982125") };
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
public class A092267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092267Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A092267.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A092267.Bytes);
public BigInteger this[int i]=>Value[i];

public static A092267Inst Instance=new A092267Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092268
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,12L,15L,20L,29L,36L,46L,61L,74L,95L,122L,145L,180L,224L,268L,328L,399L,474L,567L,682L,807L,955L,1136L,1330L,1564L,1842L,2140L,2499L,2914L,3375L,3917L,4533L,5220L,6014L,6929L,7942L,9102L,10430L,11898L,13582L,15489L,17600L,19999L,22706L,25719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092268Inst : IEnumerable<long>
{
public static readonly long[] Value=A092268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092268.Bytes);
public long this[int i]=>Value[i];

public static A092268Inst Instance=new A092268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092269
{
public static readonly long[] Value={ 1L,3L,5L,10L,14L,26L,35L,57L,80L,119L,161L,238L,315L,440L,589L,801L,1048L,1407L,1820L,2399L,3087L,3998L,5092L,6545L,8263L,10486L,13165L,16562L,20630L,25773L,31897L,39546L,48692L,59960L,73423L,89937L,109553L,133439L,161840L,196168L,236843L,285816L,343667L,412950L,494702L,592063L,706671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092269Inst : IEnumerable<long>
{
public static readonly long[] Value=A092269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092269.Bytes);
public long this[int i]=>Value[i];

public static A092269Inst Instance=new A092269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092270
{
public static readonly long[] Value={ 1L,2L,9L,8L,81L,32L,729L,128L,6561L,512L,59049L,2048L,531441L,8192L,4782969L,32768L,43046721L,131072L,387420489L,524288L,3486784401L,2097152L,31381059609L,8388608L,282429536481L,33554432L,2541865828329L,134217728L,22876792454961L,536870912L,205891132094649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092270Inst : IEnumerable<long>
{
public static readonly long[] Value=A092270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092270.Bytes);
public long this[int i]=>Value[i];

public static A092270Inst Instance=new A092270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092271
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,6L,8L,6L,1L,24L,30L,20L,10L,1L,120L,144L,90L,40L,15L,1L,720L,840L,504L,210L,70L,21L,1L,5040L,5760L,3360L,1344L,420L,112L,28L,1L,40320L,45360L,25920L,10080L,3024L,756L,168L,36L,1L,362880L,403200L,226800L,86400L,25200L,6048L,1260L,240L,45L,1L,3628800L,3991680L,2217600L,831600L,237600L,55440L,11088L,1980L,330L,55L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092271Inst : IEnumerable<long>
{
public static readonly long[] Value=A092271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092271.Bytes);
public long this[int i]=>Value[i];

public static A092271Inst Instance=new A092271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092272
{
public static readonly long[] Value={ 97L,1417L,2593L,107167L,128137L,262993L,468247L,629821L,879937L,894127L,1100347L,1260847L,1620307L,1644967L,1897417L,2890717L,3122773L,3186397L,3651667L,4169197L,6176467L,7072477L,7344187L,8237707L,8974717L,9254647L,13032547L,15540037L,15673027L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092272Inst : IEnumerable<long>
{
public static readonly long[] Value=A092272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092272.Bytes);
public long this[int i]=>Value[i];

public static A092272Inst Instance=new A092272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092273
{
public static readonly long[] Value={ 4L,56L,91784L,68401062L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092273Inst : IEnumerable<long>
{
public static readonly long[] Value=A092273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092273.Bytes);
public long this[int i]=>Value[i];

public static A092273Inst Instance=new A092273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092274
{
public static readonly long[] Value={ 0L,0L,0L,1L,6L,16L,38L,70L,124L,200L,314L,452L,644L,890L,1216L,1592L,2068L,2624L,3312L,4094L,5042L,6138L,7438L,8844L,10488L,12348L,14496L,16796L,19422L,22314L,25590L,29158L,33168L,37530L,42400L,47526L,53204L,59356L,66132L,73226L,81004L,89338L,98436L,108086L,118582L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092274Inst : IEnumerable<long>
{
public static readonly long[] Value=A092274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092274.Bytes);
public long this[int i]=>Value[i];

public static A092274Inst Instance=new A092274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092275
{
public static readonly long[] Value={ 0L,2L,11L,29L,69L,125L,224L,361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092275Inst : IEnumerable<long>
{
public static readonly long[] Value=A092275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092275.Bytes);
public long this[int i]=>Value[i];

public static A092275Inst Instance=new A092275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092276
{
public static readonly long[] Value={ 1L,2L,1L,7L,4L,1L,30L,18L,6L,1L,143L,88L,33L,8L,1L,728L,455L,182L,52L,10L,1L,3876L,2448L,1020L,320L,75L,12L,1L,21318L,13566L,5814L,1938L,510L,102L,14L,1L,120175L,76912L,33649L,11704L,3325L,760L,133L,16L,1L,690690L,444015L,197340L,70840L,21252L,5313L,1078L,168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092276Inst : IEnumerable<long>
{
public static readonly long[] Value=A092276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092276.Bytes);
public long this[int i]=>Value[i];

public static A092276Inst Instance=new A092276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092277
{
public static readonly long[] Value={ 0L,8L,30L,66L,116L,180L,258L,350L,456L,576L,710L,858L,1020L,1196L,1386L,1590L,1808L,2040L,2286L,2546L,2820L,3108L,3410L,3726L,4056L,4400L,4758L,5130L,5516L,5916L,6330L,6758L,7200L,7656L,8126L,8610L,9108L,9620L,10146L,10686L,11240L,11808L,12390L,12986L,13596L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092277Inst : IEnumerable<long>
{
public static readonly long[] Value=A092277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092277.Bytes);
public long this[int i]=>Value[i];

public static A092277Inst Instance=new A092277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092278
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,11L,11L,11L,11L,11L,12L,12L,12L,12L,12L,13L,13L,13L,13L,13L,13L,14L,14L,14L,14L,14L,15L,15L,15L,15L,15L,16L,16L,16L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092278Inst : IEnumerable<long>
{
public static readonly long[] Value=A092278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092278.Bytes);
public long this[int i]=>Value[i];

public static A092278Inst Instance=new A092278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092279
{
public static readonly long[] Value={ 5L,5L,5L,6L,6L,7L,7L,8L,8L,8L,9L,9L,10L,10L,11L,11L,12L,12L,12L,13L,13L,14L,14L,15L,15L,15L,16L,16L,17L,17L,18L,18L,19L,19L,19L,20L,20L,21L,21L,22L,22L,22L,23L,23L,24L,24L,25L,25L,26L,26L,26L,27L,27L,28L,28L,29L,29L,29L,30L,30L,31L,31L,32L,32L,33L,33L,33L,34L,34L,35L,35L,36L,36L,36L,37L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092279Inst : IEnumerable<long>
{
public static readonly long[] Value=A092279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092279.Bytes);
public long this[int i]=>Value[i];

public static A092279Inst Instance=new A092279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092280
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,8L,8L,9L,9L,11L,12L,18L,24L,25L,25L,41L,42L,60L,60L,66L,68L,90L,91L,91L,97L,100L,106L,134L,135L,150L,150L,152L,168L,174L,175L,178L,196L,202L,202L,207L,213L,234L,236L,237L,259L,305L,306L,348L,348L,364L,370L,383L,386L,388L,394L,412L,440L,498L,499L,559L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092280Inst : IEnumerable<long>
{
public static readonly long[] Value=A092280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092280.Bytes);
public long this[int i]=>Value[i];

public static A092280Inst Instance=new A092280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092281
{
public static readonly long[] Value={ 1L,1L,6L,6L,6L,48L,144L,1584L,11088L,55440L,55440L,55440L,55440L,1275120L,16576560L,480720240L,480720240L,480720240L,480720240L,480720240L,480720240L,19709529840L,19709529840L,39419059680L,39419059680L,670124014560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092281Inst : IEnumerable<long>
{
public static readonly long[] Value=A092281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092281.Bytes);
public long this[int i]=>Value[i];

public static A092281Inst Instance=new A092281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092282
{
public static readonly long[] Value={ 0L,0L,0L,3L,3L,3L,3L,-4L,1L,1L,1L,1L,1L,1L,1L,8L,8L,8L,8L,8L,8L,8L,8L,8L,17L,17L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,-2L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092282Inst : IEnumerable<long>
{
public static readonly long[] Value=A092282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092282.Bytes);
public long this[int i]=>Value[i];

public static A092282Inst Instance=new A092282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092283
{
public static readonly long[] Value={ 2L,3L,6L,4L,7L,12L,5L,8L,13L,20L,6L,9L,14L,21L,30L,7L,10L,15L,22L,31L,42L,8L,11L,16L,23L,32L,43L,56L,9L,12L,17L,24L,33L,44L,57L,72L,10L,13L,18L,25L,34L,45L,58L,73L,90L,11L,14L,19L,26L,35L,46L,59L,74L,91L,110L,12L,15L,20L,27L,36L,47L,60L,75L,92L,111L,132L,13L,16L,21L,28L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092283Inst : IEnumerable<long>
{
public static readonly long[] Value=A092283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092283.Bytes);
public long this[int i]=>Value[i];

public static A092283Inst Instance=new A092283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092284
{
public static readonly long[] Value={ 1L,3L,7L,11L,26L,42L,99L,107L,382L,428L,1156L,1223L,4525L,4903L,14811L,14827L,58022L,61236L,201420L,201611L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092284Inst : IEnumerable<long>
{
public static readonly long[] Value=A092284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092284.Bytes);
public long this[int i]=>Value[i];

public static A092284Inst Instance=new A092284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092285
{
public static readonly long[] Value={ 1L,4L,12L,22L,65L,116L,399L,554L,2475L,3232L,14938L,20208L,101413L,130846L,691890L,924946L,4867559L,6281552L,35154066L,46902128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092285Inst : IEnumerable<long>
{
public static readonly long[] Value=A092285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092285.Bytes);
public long this[int i]=>Value[i];

public static A092285Inst Instance=new A092285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092286
{
public static readonly long[] Value={ 0L,6L,16L,31L,52L,80L,116L,161L,216L,282L,360L,451L,556L,676L,812L,965L,1136L,1326L,1536L,1767L,2020L,2296L,2596L,2921L,3272L,3650L,4056L,4491L,4956L,5452L,5980L,6541L,7136L,7766L,8432L,9135L,9876L,10656L,11476L,12337L,13240L,14186L,15176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092286Inst : IEnumerable<long>
{
public static readonly long[] Value=A092286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092286.Bytes);
public long this[int i]=>Value[i];

public static A092286Inst Instance=new A092286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092287
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,96L,480L,414720L,2903040L,5945425920L,4334215495680L,277389791723520000L,3051287708958720000L,BigInteger.Parse("437332621360674939863040000"),BigInteger.Parse("5685324077688774218219520000"),BigInteger.Parse("15974941971638268369709427589120000"),BigInteger.Parse("982608696336737613503095822614528000000000") };
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
public class A092287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092287Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A092287.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A092287.Bytes);
public BigInteger this[int i]=>Value[i];

public static A092287Inst Instance=new A092287Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092288
{
public static readonly long[] Value={ 1L,4L,1L,11L,2L,1L,28L,7L,2L,1L,62L,15L,5L,2L,1L,137L,38L,13L,5L,2L,1L,278L,76L,28L,11L,5L,2L,1L,561L,164L,60L,26L,11L,5L,2L,1L,1080L,316L,124L,52L,24L,11L,5L,2L,1L,2051L,623L,244L,108L,50L,24L,11L,5L,2L,1L,3778L,1156L,469L,208L,100L,48L,24L,11L,5L,2L,1L,6885L,2160L,886L,404L,194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092288Inst : IEnumerable<long>
{
public static readonly long[] Value=A092288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092288.Bytes);
public long this[int i]=>Value[i];

public static A092288Inst Instance=new A092288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092289
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,10L,10L,12L,14L,16L,17L,18L,19L,22L,23L,24L,25L,26L,27L,29L,31L,32L,34L,36L,37L,38L,39L,41L,42L,44L,45L,47L,48L,49L,50L,53L,54L,55L,56L,57L,58L,61L,62L,65L,66L,67L,68L,69L,71L,72L,73L,74L,77L,78L,79L,81L,83L,84L,85L,86L,87L,89L,91L,93L,94L,95L,96L,97L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092289Inst : IEnumerable<long>
{
public static readonly long[] Value=A092289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092289.Bytes);
public long this[int i]=>Value[i];

public static A092289Inst Instance=new A092289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092290
{
public static readonly long[] Value={ 7L,8L,8L,7L,4L,8L,2L,1L,9L,3L,6L,9L,6L,0L,6L,1L,0L,3L,0L,2L,0L,3L,1L,9L,4L,1L,5L,3L,7L,0L,8L,1L,5L,4L,7L,8L,0L,4L,3L,7L,9L,3L,8L,4L,1L,3L,7L,7L,7L,2L,5L,1L,7L,9L,5L,4L,6L,3L,8L,4L,7L,8L,1L,4L,8L,9L,1L,3L,8L,2L,3L,2L,3L,1L,0L,9L,6L,5L,3L,1L,4L,0L,8L,3L,7L,8L,4L,6L,5L,7L,8L,5L,3L,4L,3L,5L,2L,8L,7L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092290Inst : IEnumerable<long>
{
public static readonly long[] Value=A092290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092290.Bytes);
public long this[int i]=>Value[i];

public static A092290Inst Instance=new A092290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092291
{
public static readonly long[] Value={ 574L,1269L,1910L,3384L,1185L,1376L,9611L,4789L,9670L,20946L,13019L,11247L,2689L,22708L,13355L,45251L,48407L,32653L,18761L,38706L,76391L,25563L,50310L,79023L,44948L,29864L,21716L,71441L,104339L,22993L,73572L,61549L,14714L,26122L,6227L,179369L,159687L,5862L,132157L,24925L,76023L,15346L,73479L,136956L,212240L,10587L,3801L,137040L,108520L,194171L,98550L,282532L,87272L,133081L,220187L,305002L,41764L,27268L,380180L,70921L,184940L,241076L,73858L,80108L,250927L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092291Inst : IEnumerable<long>
{
public static readonly long[] Value=A092291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092291.Bytes);
public long this[int i]=>Value[i];

public static A092291Inst Instance=new A092291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092308
{
public static readonly long[] Value={ 1L,2L,3L,3L,3L,5L,4L,4L,3L,4L,5L,7L,5L,4L,3L,4L,3L,8L,5L,4L,8L,4L,3L,5L,7L,5L,4L,3L,8L,6L,6L,4L,4L,5L,4L,6L,8L,5L,3L,4L,3L,11L,4L,8L,5L,7L,8L,4L,3L,6L,5L,3L,11L,4L,5L,3L,4L,7L,8L,8L,4L,4L,6L,4L,9L,4L,8L,10L,3L,7L,7L,3L,4L,6L,7L,3L,4L,11L,8L,8L,4L,13L,4L,11L,4L,3L,7L,7L,6L,7L,3L,3L,6L,5L,5L,3L,4L,8L,6L,14L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092308Inst : IEnumerable<long>
{
public static readonly long[] Value=A092308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092308.Bytes);
public long this[int i]=>Value[i];

public static A092308Inst Instance=new A092308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092309
{
public static readonly long[] Value={ 1L,4L,7L,15L,19L,39L,46L,80L,106L,160L,201L,318L,390L,554L,729L,998L,1262L,1727L,2168L,2894L,3670L,4749L,5963L,7737L,9635L,12232L,15257L,19206L,23727L,29723L,36509L,45296L,55512L,68292L,83298L,102079L,123805L,150697L,182254L,220790L,265766L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092309Inst : IEnumerable<long>
{
public static readonly long[] Value=A092309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092309.Bytes);
public long this[int i]=>Value[i];

public static A092309Inst Instance=new A092309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092310
{
public static readonly long[] Value={ 1L,2L,6L,7L,13L,20L,28L,34L,53L,71L,88L,117L,148L,188L,250L,301L,365L,472L,565L,688L,860L,1027L,1224L,1486L,1771L,2107L,2524L,2983L,3496L,4158L,4867L,5666L,6676L,7762L,9021L,10525L,12145L,14034L,16249L,18696L,21478L,24721L,28308L,32364L,37110L,42289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092310Inst : IEnumerable<long>
{
public static readonly long[] Value=A092310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092310.Bytes);
public long this[int i]=>Value[i];

public static A092310Inst Instance=new A092310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092311
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,10L,12L,14L,19L,23L,26L,33L,38L,44L,56L,63L,71L,88L,99L,114L,138L,155L,176L,208L,237L,269L,314L,357L,402L,468L,529L,594L,686L,772L,873L,999L,1119L,1260L,1431L,1608L,1804L,2039L,2284L,2554L,2884L,3219L,3590L,4032L,4493L,5011L,5603L,6231L,6928L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092311Inst : IEnumerable<long>
{
public static readonly long[] Value=A092311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092311.Bytes);
public long this[int i]=>Value[i];

public static A092311Inst Instance=new A092311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092312
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,161L,17218L,363949L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092312Inst : IEnumerable<long>
{
public static readonly long[] Value=A092312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092312.Bytes);
public long this[int i]=>Value[i];

public static A092312Inst Instance=new A092312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092313
{
public static readonly long[] Value={ 1L,2L,6L,5L,12L,16L,21L,22L,43L,46L,60L,75L,92L,119L,164L,167L,220L,276L,320L,390L,491L,562L,665L,796L,949L,1109L,1342L,1530L,1804L,2144L,2442L,2843L,3342L,3837L,4471L,5147L,5894L,6780L,7841L,8910L,10204L,11718L,13282L,15168L,17337L,19594L,22225L,25210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092313Inst : IEnumerable<long>
{
public static readonly long[] Value=A092313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092313.Bytes);
public long this[int i]=>Value[i];

public static A092313Inst Instance=new A092313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092314
{
public static readonly long[] Value={ 1L,1L,4L,2L,7L,6L,11L,8L,18L,16L,24L,23L,34L,36L,51L,48L,66L,74L,90L,98L,126L,137L,164L,182L,220L,247L,294L,324L,380L,434L,496L,556L,650L,728L,835L,938L,1068L,1204L,1372L,1531L,1736L,1956L,2198L,2462L,2784L,3104L,3482L,3890L,4358L,4864L,5441L,6048L,6748L,7516L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092314Inst : IEnumerable<long>
{
public static readonly long[] Value=A092314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092314.Bytes);
public long this[int i]=>Value[i];

public static A092314Inst Instance=new A092314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092315
{
public static readonly long[] Value={ 1L,7L,56L,418L,3091L,22845L,168803L,1247297L,9216353L,68100150L,503195828L,3718142207L,27473561357L,203003686105L,1500005624923L,11083625711270L,81897532160125L,605145459495140L,4471453748222756L,33039822589391675L,244133102611731230L,1803913190804074903L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092315Inst : IEnumerable<long>
{
public static readonly long[] Value=A092315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092315.Bytes);
public long this[int i]=>Value[i];

public static A092315Inst Instance=new A092315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092316
{
public static readonly long[] Value={ 1L,0L,3L,3L,5L,5L,7L,12L,14L,16L,18L,27L,29L,33L,42L,55L,59L,65L,78L,95L,110L,118L,137L,167L,188L,200L,236L,274L,303L,330L,376L,435L,485L,522L,591L,677L,741L,803L,903L,1022L,1115L,1210L,1345L,1505L,1650L,1784L,1964L,2201L,2393L,2578L,2843L,3143L,3409L,3685L,4034L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092316Inst : IEnumerable<long>
{
public static readonly long[] Value=A092316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092316.Bytes);
public long this[int i]=>Value[i];

public static A092316Inst Instance=new A092316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092317
{
public static readonly long[] Value={ 1L,15L,113L,837L,6183L,45691L,337607L,2494595L,18432707L,136200301L,1006391657L,7436284415L,54947122715L,406007372211L,3000011249847L,22167251422541L,163795064320251L,1210290918990281L,8942907496445513L,66079645178783351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092317Inst : IEnumerable<long>
{
public static readonly long[] Value=A092317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092317.Bytes);
public long this[int i]=>Value[i];

public static A092317Inst Instance=new A092317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092318
{
public static readonly long[] Value={ 0L,7L,56L,418L,3091L,22845L,168803L,1247297L,9216353L,68100150L,503195828L,3718142207L,27473561357L,203003686105L,1500005624923L,11083625711270L,81897532160125L,605145459495140L,4471453748222756L,33039822589391675L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092318Inst : IEnumerable<long>
{
public static readonly long[] Value=A092318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092318.Bytes);
public long this[int i]=>Value[i];

public static A092318Inst Instance=new A092318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092319
{
public static readonly long[] Value={ 1L,0L,3L,1L,5L,1L,7L,4L,10L,4L,12L,9L,15L,9L,20L,17L,23L,17L,28L,27L,36L,28L,41L,43L,50L,44L,62L,62L,71L,66L,84L,91L,103L,96L,119L,127L,139L,137L,167L,178L,191L,192L,223L,241L,266L,264L,302L,331L,351L,360L,411L,439L,469L,485L,542L,587L,628L,646L,714L,773L,819L,854L,945L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092319Inst : IEnumerable<long>
{
public static readonly long[] Value=A092319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092319.Bytes);
public long this[int i]=>Value[i];

public static A092319Inst Instance=new A092319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092320
{
public static readonly long[] Value={ 4L,6L,12L,30L,33L,36L,40L,45L,50L,54L,56L,60L,70L,81L,88L,90L,100L,112L,150L,162L,170L,200L,240L,252L,300L,304L,336L,340L,405L,406L,418L,456L,513L,525L,528L,551L,560L,567L,600L,660L,665L,666L,693L,704L,720L,748L,810L,828L,850L,858L,874L,882L,897L,910L,924L,960L,1005L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092320Inst : IEnumerable<long>
{
public static readonly long[] Value=A092320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092320.Bytes);
public long this[int i]=>Value[i];

public static A092320Inst Instance=new A092320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092321
{
public static readonly long[] Value={ 0L,1L,4L,8L,17L,26L,49L,69L,115L,164L,249L,343L,513L,686L,974L,1314L,1806L,2382L,3232L,4208L,5597L,7244L,9456L,12118L,15687L,19899L,25422L,32079L,40589L,50796L,63805L,79303L,98817L,122179L,151145L,185820L,228598L,279476L,341807L,416051L,506205L,613244L,742720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092321Inst : IEnumerable<long>
{
public static readonly long[] Value=A092321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092321.Bytes);
public long this[int i]=>Value[i];

public static A092321Inst Instance=new A092321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092322
{
public static readonly long[] Value={ 1L,1L,4L,4L,9L,12L,19L,24L,36L,48L,64L,83L,108L,140L,179L,224L,280L,352L,432L,532L,652L,795L,960L,1160L,1392L,1669L,1992L,2368L,2804L,3320L,3908L,4592L,5388L,6300L,7349L,8560L,9940L,11524L,13340L,15401L,17752L,20436L,23472L,26920L,30840L,35256L,40252L,45900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092322Inst : IEnumerable<long>
{
public static readonly long[] Value=A092322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092322.Bytes);
public long this[int i]=>Value[i];

public static A092322Inst Instance=new A092322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092323
{
public static readonly long[] Value={ 0L,1L,1L,3L,3L,3L,3L,7L,7L,7L,7L,7L,7L,7L,7L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,63L,63L,63L,63L,63L,63L,63L,63L,63L,63L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092323Inst : IEnumerable<long>
{
public static readonly long[] Value=A092323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092323.Bytes);
public long this[int i]=>Value[i];

public static A092323Inst Instance=new A092323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092420
{
public static readonly long[] Value={ 1L,10L,90L,801L,7120L,63280L,562401L,4998330L,44422570L,394804801L,3508820640L,31184580960L,277152408001L,2463187091050L,21891531411450L,194560595612001L,1729153829096560L,15367823866257040L,136581260967216801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092420Inst : IEnumerable<long>
{
public static readonly long[] Value=A092420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092420.Bytes);
public long this[int i]=>Value[i];

public static A092420Inst Instance=new A092420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092421
{
public static readonly long[] Value={ 1L,3L,6L,9L,12L,18L,27L,27L,15L,36L,108L,54L,-207L,81L,1296L,81L,-5397L,45L,25245L,108L,-118053L,324L,563355L,162L,-2711799L,-621L,13188096L,243L,-64689894L,3888L,319651920L,243L,-1589538684L,-16191L,7949000070L,135L,-39951345438L,75735L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092421Inst : IEnumerable<long>
{
public static readonly long[] Value=A092421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092421.Bytes);
public long this[int i]=>Value[i];

public static A092421Inst Instance=new A092421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092422
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,4L,1L,1L,4L,8L,7L,1L,1L,5L,14L,18L,11L,1L,1L,6L,21L,40L,36L,16L,1L,1L,7L,30L,72L,98L,66L,22L,1L,1L,8L,40L,119L,211L,214L,113L,29L,1L,1L,9L,52L,182L,398L,546L,428L,183L,37L,1L,1L,10L,65L,265L,692L,1170L,1278L,799L,283L,46L,1L,1L,11L,80L,368L,1123L,2286L,3104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092422Inst : IEnumerable<long>
{
public static readonly long[] Value=A092422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092422.Bytes);
public long this[int i]=>Value[i];

public static A092422Inst Instance=new A092422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092423
{
public static readonly long[] Value={ 1L,2L,4L,9L,21L,50L,121L,297L,736L,1837L,4610L,11618L,29379L,74500L,189362L,482282L,1230460L,3144137L,8045057L,20610526L,52860253L,135707819L,348720196L,896833527L,2308229426L,5944998971L,15321681454L,39511323139L,101947848801L,263183509040L,679747862389L,1756432848707L,4540430713995L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092423Inst : IEnumerable<long>
{
public static readonly long[] Value=A092423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092423.Bytes);
public long this[int i]=>Value[i];

public static A092423Inst Instance=new A092423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092424
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,9L,15L,28L,48L,90L,159L,296L,537L,992L,1830L,3376L,6273L,11609L,21627L,40186L,74966L,139764L,261063L,487901L,912607L,1708571L,3200241L,5999508L,11251618L,21116746L,39647006L,74479444L,139971218L,263167645L,494991043L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092424Inst : IEnumerable<long>
{
public static readonly long[] Value=A092424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092424.Bytes);
public long this[int i]=>Value[i];

public static A092424Inst Instance=new A092424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092425
{
public static readonly long[] Value={ 9L,7L,4L,0L,9L,0L,9L,1L,0L,3L,4L,0L,0L,2L,4L,3L,7L,2L,3L,6L,4L,4L,0L,3L,3L,2L,6L,8L,8L,7L,0L,5L,1L,1L,1L,2L,4L,9L,7L,2L,7L,5L,8L,5L,6L,7L,2L,6L,8L,5L,4L,2L,1L,6L,9L,1L,4L,6L,7L,8L,5L,9L,3L,8L,9L,9L,7L,0L,8L,5L,5L,4L,5L,6L,8L,2L,7L,1L,9L,6L,1L,9L,0L,1L,2L,1L,8L,6L,7L,2L,3L,4L,7L,5L,2L,9L,9L,2L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092425Inst : IEnumerable<long>
{
public static readonly long[] Value=A092425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092425.Bytes);
public long this[int i]=>Value[i];

public static A092425Inst Instance=new A092425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092426
{
public static readonly long[] Value={ 5L,4L,5L,9L,8L,1L,5L,0L,0L,3L,3L,1L,4L,4L,2L,3L,9L,0L,7L,8L,1L,1L,0L,2L,6L,1L,2L,0L,2L,8L,6L,0L,8L,7L,8L,4L,0L,2L,7L,9L,0L,7L,3L,7L,0L,3L,8L,6L,1L,4L,0L,6L,8L,7L,2L,5L,8L,2L,6L,5L,9L,3L,9L,5L,8L,5L,5L,3L,6L,6L,2L,0L,9L,9L,9L,3L,5L,8L,6L,9L,4L,8L,1L,6L,7L,6L,9L,8L,0L,5L,6L,1L,9L,4L,4L,7L,3L,4L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092426Inst : IEnumerable<long>
{
public static readonly long[] Value=A092426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092426.Bytes);
public long this[int i]=>Value[i];

public static A092426Inst Instance=new A092426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092427
{
public static readonly long[] Value={ 2L,6L,12L,12L,12L,24L,24L,36L,40L,45L,48L,60L,60L,60L,72L,72L,72L,80L,80L,90L,90L,120L,120L,120L,120L,120L,120L,120L,144L,144L,144L,144L,144L,144L,144L,180L,180L,180L,180L,180L,180L,180L,180L,180L,240L,240L,240L,240L,240L,240L,240L,240L,240L,240L,240L,240L,240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092427Inst : IEnumerable<long>
{
public static readonly long[] Value=A092427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092427.Bytes);
public long this[int i]=>Value[i];

public static A092427Inst Instance=new A092427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092428
{
public static readonly long[] Value={ 4L,10L,12L,13L,28L,30L,31L,36L,37L,39L,40L,82L,84L,85L,90L,91L,93L,94L,108L,109L,111L,112L,117L,118L,120L,121L,244L,246L,247L,252L,253L,255L,256L,270L,271L,273L,274L,279L,280L,282L,283L,324L,325L,327L,328L,333L,334L,336L,337L,351L,352L,354L,355L,360L,361L,363L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092428Inst : IEnumerable<long>
{
public static readonly long[] Value=A092428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092428.Bytes);
public long this[int i]=>Value[i];

public static A092428Inst Instance=new A092428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092429
{
public static readonly long[] Value={ 1L,1L,3L,10L,47L,126L,522L,1821L,8143L,26326L,109958L,396111L,1737122L,5998955L,24949277L,91979985L,397402223L,1418993350L,5881338702L,22010456331L,94022106862L,342803313261L,1416758002487L,5356198979731L,22685035586290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092429Inst : IEnumerable<long>
{
public static readonly long[] Value=A092429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092429.Bytes);
public long this[int i]=>Value[i];

public static A092429Inst Instance=new A092429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092430
{
public static readonly BigInteger[] Value={ 1L,1L,25L,438L,18388L,1409674L,206682994L,58152537184L,31715884061624L,33827568738189576L,BigInteger.Parse("71066571962396085656"),BigInteger.Parse("295645506683051376527648"),BigInteger.Parse("2444503529745123474354656720"),BigInteger.Parse("40269655263141217619453414445968") };
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
public class A092430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092430Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A092430.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A092430.Bytes);
public BigInteger this[int i]=>Value[i];

public static A092430Inst Instance=new A092430Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092431
{
public static readonly long[] Value={ 2L,9L,35L,135L,527L,2079L,8255L,32895L,131327L,524799L,2098175L,8390655L,33558527L,134225919L,536887295L,2147516415L,8590000127L,34359869439L,137439215615L,549756338175L,2199024304127L,8796095119359L,35184376283135L,140737496743935L,562949970198527L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092431Inst : IEnumerable<long>
{
public static readonly long[] Value=A092431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092431.Bytes);
public long this[int i]=>Value[i];

public static A092431Inst Instance=new A092431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092432
{
public static readonly long[] Value={ 1L,4L,5L,14L,18L,42L,43L,46L,47L,56L,60L,127L,128L,131L,132L,141L,145L,169L,170L,173L,174L,183L,187L,383L,386L,387L,396L,400L,424L,425L,428L,429L,438L,442L,510L,513L,514L,523L,527L,551L,552L,555L,556L,565L,569L,1150L,1153L,1154L,1163L,1167L,1192L,1195L,1196L,1205L,1209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092432Inst : IEnumerable<long>
{
public static readonly long[] Value=A092432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092432.Bytes);
public long this[int i]=>Value[i];

public static A092432Inst Instance=new A092432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092433
{
public static readonly long[] Value={ 7L,14L,17L,21L,27L,28L,35L,37L,42L,47L,49L,56L,57L,63L,67L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,84L,87L,91L,97L,98L,105L,107L,112L,117L,119L,126L,127L,133L,137L,140L,147L,154L,157L,161L,167L,168L,170L,171L,172L,173L,174L,175L,176L,177L,178L,179L,182L,187L,189L,196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092433Inst : IEnumerable<long>
{
public static readonly long[] Value=A092433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092433.Bytes);
public long this[int i]=>Value[i];

public static A092433Inst Instance=new A092433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092434
{
public static readonly long[] Value={ 3L,4L,10L,12L,28L,32L,72L,80L,176L,192L,416L,448L,960L,1024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092434Inst : IEnumerable<long>
{
public static readonly long[] Value=A092434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092434.Bytes);
public long this[int i]=>Value[i];

public static A092434Inst Instance=new A092434Inst();

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