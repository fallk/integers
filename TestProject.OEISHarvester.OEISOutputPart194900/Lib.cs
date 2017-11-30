using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A225357
{
public static readonly long[] Value={ 3L,9L,2L,4L,2L,2L,0L,6L,4L,1L,6L,0L,8L,3L,2L,7L,3L,2L,3L,4L,0L,8L,7L,9L,4L,2L,0L,3L,6L,1L,2L,6L,4L,4L,4L,1L,3L,7L,8L,2L,4L,0L,8L,8L,5L,5L,1L,1L,1L,3L,3L,9L,2L,5L,6L,2L,8L,4L,8L,8L,6L,5L,4L,9L,9L,5L,4L,8L,1L,9L,9L,0L,2L,7L,3L,3L,1L,4L,8L,7L,2L,7L,0L,0L,1L,6L,0L,8L,5L,8L,7L,3L,5L,2L,9L,8L,5L,0L,1L,0L,6L,9L,3L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225357Inst : IEnumerable<long>
{
public static readonly long[] Value=A225357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225357.Bytes);
public long this[int i]=>Value[i];

public static A225357Inst Instance=new A225357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225358
{
public static readonly long[] Value={ 56L,176L,792L,2323520L,4087968L,8118264L,92669720L,118114304L,150198136L,384276336L,541946240L,1188908248L,1844349560L,2291320912L,3163127352L,4351078600L,5371315400L,5964539504L,7346629512L,10015581680L,11097645016L,16670689208L,18440293320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225358Inst : IEnumerable<long>
{
public static readonly long[] Value=A225358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225358.Bytes);
public long this[int i]=>Value[i];

public static A225358Inst Instance=new A225358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225359
{
public static readonly long[] Value={ 3L,3L,9L,2L,4L,2L,2L,0L,6L,4L,1L,6L,0L,8L,3L,2L,7L,3L,2L,3L,4L,0L,8L,7L,9L,4L,2L,0L,3L,6L,1L,2L,6L,4L,4L,4L,1L,3L,7L,8L,2L,4L,0L,8L,8L,5L,5L,1L,1L,1L,3L,3L,9L,2L,5L,6L,2L,8L,4L,8L,8L,6L,5L,4L,9L,9L,5L,4L,8L,1L,9L,9L,0L,2L,7L,3L,3L,1L,4L,8L,7L,2L,7L,0L,0L,1L,6L,0L,8L,5L,8L,7L,3L,5L,2L,9L,8L,5L,0L,1L,0L,6L,9L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225359Inst : IEnumerable<long>
{
public static readonly long[] Value=A225359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225359.Bytes);
public long this[int i]=>Value[i];

public static A225359Inst Instance=new A225359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225360
{
public static readonly long[] Value={ 135L,297L,792L,1575L,10143L,31185L,63261L,329931L,15796476L,44108109L,4835271870L,7346629512L,12292341831L,18440293320L,107438159466L,129913904637L,156919475295L,250438925115L,1527273599625L,3345365983698L,3646072432125L,7206841706490L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225360Inst : IEnumerable<long>
{
public static readonly long[] Value=A225360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225360.Bytes);
public long this[int i]=>Value[i];

public static A225360Inst Instance=new A225360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225361
{
public static readonly long[] Value={ 11L,22L,77L,176L,231L,297L,385L,627L,792L,1958L,3718L,4565L,6842L,8349L,14883L,21637L,26015L,31185L,44583L,53174L,63261L,173525L,204226L,239943L,281589L,386155L,526823L,715220L,831820L,1121505L,1300156L,1741630L,5392783L,7089500L,8118264L,12132164L,18004327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225361Inst : IEnumerable<long>
{
public static readonly long[] Value=A225361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225361.Bytes);
public long this[int i]=>Value[i];

public static A225361Inst Instance=new A225361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225362
{
public static readonly long[] Value={ 1L,3L,217L,3937L,57337L,917497L,1040257L,11010027L,12189603L,16252897L,16646017L,3612185689L,4294434817L,66571993057L,68718821377L,17590038552577L,270545999761249L,281472829095937L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225362Inst : IEnumerable<long>
{
public static readonly long[] Value=A225362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225362.Bytes);
public long this[int i]=>Value[i];

public static A225362Inst Instance=new A225362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225363
{
public static readonly long[] Value={ 0L,1L,6L,24L,39L,50L,52L,72L,259L,1002L,4610L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225363Inst : IEnumerable<long>
{
public static readonly long[] Value=A225363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225363.Bytes);
public long this[int i]=>Value[i];

public static A225363Inst Instance=new A225363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225364
{
public static readonly long[] Value={ 1L,8L,9L,30L,25L,18L,110L,242L,59L,100L,12L,71L,28L,153L,225L,114L,159L,66L,75L,102L,924L,6L,631L,150L,299L,434L,701L,24L,1687L,196L,1482L,779L,1552L,2658L,505L,496L,255L,46L,1626L,183L,2551L,1083L,39L,665L,1419L,678L,1676L,50L,1027L,2047L,3726L,1309L,2327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225364Inst : IEnumerable<long>
{
public static readonly long[] Value=A225364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225364.Bytes);
public long this[int i]=>Value[i];

public static A225364Inst Instance=new A225364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225365
{
public static readonly long[] Value={ 3L,15L,23L,39L,47L,71L,84L,87L,95L,119L,167L,191L,199L,215L,231L,239L,260L,311L,327L,335L,383L,399L,407L,420L,431L,455L,479L,551L,591L,647L,671L,695L,719L,759L,776L,791L,831L,839L,887L,935L,959L,983L,1031L,1079L,1140L,1151L,1199L,1239L,1271L,1295L,1319L,1391L,1439L,1487L,1511L,1559L,1679L,1751L,1799L,1847L,1959L,1991L,2015L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225365Inst : IEnumerable<long>
{
public static readonly long[] Value=A225365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225365.Bytes);
public long this[int i]=>Value[i];

public static A225365Inst Instance=new A225365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225366
{
public static readonly long[] Value={ 0L,2L,5L,6L,6L,13L,20L,13L,20L,19L,23L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225366Inst : IEnumerable<long>
{
public static readonly long[] Value=A225366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225366.Bytes);
public long this[int i]=>Value[i];

public static A225366Inst Instance=new A225366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225367
{
public static readonly long[] Value={ 3L,2L,6L,6L,18L,18L,54L,54L,162L,162L,486L,486L,1458L,1458L,4374L,4374L,13122L,13122L,39366L,39366L,118098L,118098L,354294L,354294L,1062882L,1062882L,3188646L,3188646L,9565938L,9565938L,28697814L,28697814L,86093442L,86093442L,258280326L,258280326L,774840978L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225367Inst : IEnumerable<long>
{
public static readonly long[] Value=A225367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225367.Bytes);
public long this[int i]=>Value[i];

public static A225367Inst Instance=new A225367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225368
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,2L,6L,2L,14L,7L,20L,8L,52L,23L,84L,28L,214L,85L,348L,109L,890L,328L,1444L,420L,3810L,1283L,6098L,1675L,16388L,5201L,26016L,6771L,71048L,21142L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225368Inst : IEnumerable<long>
{
public static readonly long[] Value=A225368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225368.Bytes);
public long this[int i]=>Value[i];

public static A225368Inst Instance=new A225368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225369
{
public static readonly long[] Value={ 1L,2L,4L,6L,6L,6L,6L,8L,10L,10L,12L,12L,12L,12L,12L,12L,12L,12L,14L,16L,18L,18L,18L,18L,20L,20L,20L,22L,22L,24L,24L,24L,24L,24L,28L,28L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225369Inst : IEnumerable<long>
{
public static readonly long[] Value=A225369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225369.Bytes);
public long this[int i]=>Value[i];

public static A225369Inst Instance=new A225369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225370
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,2L,2L,2L,3L,3L,4L,4L,5L,5L,5L,6L,6L,7L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225370Inst : IEnumerable<long>
{
public static readonly long[] Value=A225370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225370.Bytes);
public long this[int i]=>Value[i];

public static A225370Inst Instance=new A225370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225371
{
public static readonly BigInteger[] Value={ 1L,2L,10L,260L,31096L,13711952L,28275659056L,224402782202048L,7293836994286696576L,BigInteger.Parse("952002419516769475035392"),BigInteger.Parse("497678654312172407869125822976"),BigInteger.Parse("1044660329769242614113093804053562368"),BigInteger.Parse("8745525723307044762290950664928498588583936") };
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
public class A225371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225371Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A225371.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A225371.Bytes);
public BigInteger this[int i]=>Value[i];

public static A225371Inst Instance=new A225371Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225372
{
public static readonly long[] Value={ 1L,1L,1L,1L,-2L,1L,1L,-1L,-1L,1L,1L,-4L,6L,-4L,1L,1L,-3L,2L,2L,-3L,1L,1L,-6L,15L,-20L,15L,-6L,1L,1L,-5L,9L,-5L,-5L,9L,-5L,1L,1L,-8L,28L,-56L,70L,-56L,28L,-8L,1L,1L,-7L,20L,-28L,14L,14L,-28L,20L,-7L,1L,1L,-10L,45L,-120L,210L,-252L,210L,-120L,45L,-10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225372Inst : IEnumerable<long>
{
public static readonly long[] Value=A225372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225372.Bytes);
public long this[int i]=>Value[i];

public static A225372Inst Instance=new A225372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225373
{
public static readonly long[] Value={ 1L,2L,2L,4L,4L,8L,6L,14L,10L,20L,14L,30L,18L,42L,24L,50L,32L,66L,38L,84L,46L,96L,56L,118L,64L,138L,76L,156L,88L,184L,96L,214L,112L,234L,128L,258L,140L,294L,158L,318L,174L,358L,186L,400L,206L,424L,228L,470L,244L,512L,264L,544L,288L,596L,306L,636L,330L,672L,358L,730L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225373Inst : IEnumerable<long>
{
public static readonly long[] Value=A225373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225373.Bytes);
public long this[int i]=>Value[i];

public static A225373Inst Instance=new A225373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225374
{
public static readonly BigInteger[] Value={ 1L,111L,12321L,1367631L,151807041L,16850581551L,1870414552161L,207616015289871L,23045377697175681L,2558036924386500591L,BigInteger.Parse("283942098606901565601"),BigInteger.Parse("31517572945366073781711"),BigInteger.Parse("3498450596935634189769921"),BigInteger.Parse("388328016259855395064461231"),BigInteger.Parse("43104409804843948852155196641") };
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
public class A225374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225374Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A225374.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A225374.Bytes);
public BigInteger this[int i]=>Value[i];

public static A225374Inst Instance=new A225374Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225375
{
public static readonly long[] Value={ 15L,21L,33L,35L,39L,45L,51L,55L,57L,63L,65L,69L,75L,77L,85L,87L,91L,93L,95L,99L,111L,115L,117L,119L,123L,129L,133L,135L,141L,143L,145L,147L,153L,155L,159L,161L,171L,175L,177L,183L,185L,187L,189L,201L,203L,205L,207L,209L,213L,215L,217L,219L,221L,225L,235L,237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225375Inst : IEnumerable<long>
{
public static readonly long[] Value=A225375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225375.Bytes);
public long this[int i]=>Value[i];

public static A225375Inst Instance=new A225375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225376
{
public static readonly long[] Value={ 1L,5L,11L,20L,36L,60L,94L,140L,199L,272L,360L,465L,588L,730L,893L,1078L,1286L,1519L,1778L,2064L,2378L,2721L,3094L,3498L,3934L,4403L,4907L,5448L,6027L,6645L,7303L,8002L,8743L,9527L,10355L,11228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225376Inst : IEnumerable<long>
{
public static readonly long[] Value=A225376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225376.Bytes);
public long this[int i]=>Value[i];

public static A225376Inst Instance=new A225376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225377
{
public static readonly long[] Value={ 4L,6L,9L,16L,24L,34L,46L,59L,73L,88L,105L,123L,142L,163L,185L,208L,233L,259L,286L,314L,343L,373L,404L,436L,469L,504L,541L,579L,618L,658L,699L,741L,784L,828L,873L,920L,968L,1017L,1067L,1118L,1170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225377Inst : IEnumerable<long>
{
public static readonly long[] Value=A225377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225377.Bytes);
public long this[int i]=>Value[i];

public static A225377Inst Instance=new A225377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225378
{
public static readonly long[] Value={ 2L,3L,7L,8L,10L,12L,13L,14L,15L,17L,18L,19L,21L,22L,23L,25L,26L,27L,28L,29L,30L,31L,32L,33L,35L,37L,38L,39L,40L,41L,42L,43L,44L,45L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,61L,62L,63L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225378Inst : IEnumerable<long>
{
public static readonly long[] Value=A225378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225378.Bytes);
public long this[int i]=>Value[i];

public static A225378Inst Instance=new A225378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225379
{
public static readonly long[] Value={ 1L,4L,16L,44L,131L,344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225379Inst : IEnumerable<long>
{
public static readonly long[] Value=A225379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225379.Bytes);
public long this[int i]=>Value[i];

public static A225379Inst Instance=new A225379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225380
{
public static readonly long[] Value={ 1L,6L,36L,160L,750L,3240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225380Inst : IEnumerable<long>
{
public static readonly long[] Value=A225380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225380.Bytes);
public long this[int i]=>Value[i];

public static A225380Inst Instance=new A225380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225381
{
public static readonly long[] Value={ 1L,2L,2L,4L,3L,5L,4L,8L,5L,8L,6L,11L,7L,11L,8L,16L,9L,14L,10L,18L,11L,17L,12L,23L,13L,20L,14L,25L,15L,23L,16L,32L,17L,26L,18L,32L,19L,29L,20L,38L,21L,32L,22L,39L,23L,35L,24L,47L,25L,38L,26L,46L,27L,41L,28L,53L,29L,44L,30L,53L,31L,47L,32L,64L,33L,50L,34L,60L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225381Inst : IEnumerable<long>
{
public static readonly long[] Value=A225381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225381.Bytes);
public long this[int i]=>Value[i];

public static A225381Inst Instance=new A225381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225382
{
public static readonly long[] Value={ 1L,6L,30L,110L,360L,1026L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225382Inst : IEnumerable<long>
{
public static readonly long[] Value=A225382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225382.Bytes);
public long this[int i]=>Value[i];

public static A225382Inst Instance=new A225382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225383
{
public static readonly long[] Value={ 1L,6L,24L,74L,195L,456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225383Inst : IEnumerable<long>
{
public static readonly long[] Value=A225383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225383.Bytes);
public long this[int i]=>Value[i];

public static A225383Inst Instance=new A225383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225384
{
public static readonly long[] Value={ 1L,6L,18L,36L,72L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225384Inst : IEnumerable<long>
{
public static readonly long[] Value=A225384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225384.Bytes);
public long this[int i]=>Value[i];

public static A225384Inst Instance=new A225384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225385
{
public static readonly long[] Value={ 1L,3L,9L,20L,38L,64L,100L,148L,209L,284L,374L,480L,603L,745L,908L,1093L,1301L,1533L,1790L,2074L,2386L,2727L,3098L,3500L,3934L,4401L,4902L,5438L,6011L,6623L,7275L,7968L,8703L,9481L,10303L,11170L,12083L,13043L,14052L,15111L,16221L,17383L,18598L,19867L,21191L,22571L,24008L,25503L,27057L,28671L,30347L,32086L,33890L,35760L,37697L,39702L,41776L,43920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225385Inst : IEnumerable<long>
{
public static readonly long[] Value=A225385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225385.Bytes);
public long this[int i]=>Value[i];

public static A225385Inst Instance=new A225385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225386
{
public static readonly long[] Value={ 2L,6L,11L,18L,26L,36L,48L,61L,75L,90L,106L,123L,142L,163L,185L,208L,232L,257L,284L,312L,341L,371L,402L,434L,467L,501L,536L,573L,612L,652L,693L,735L,778L,822L,867L,913L,960L,1009L,1059L,1110L,1162L,1215L,1269L,1324L,1380L,1437L,1495L,1554L,1614L,1676L,1739L,1804L,1870L,1937L,2005L,2074L,2144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225386Inst : IEnumerable<long>
{
public static readonly long[] Value=A225386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225386.Bytes);
public long this[int i]=>Value[i];

public static A225386Inst Instance=new A225386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225387
{
public static readonly long[] Value={ 4L,5L,7L,8L,10L,12L,13L,14L,15L,16L,17L,19L,21L,22L,23L,24L,25L,27L,28L,29L,30L,31L,32L,33L,34L,35L,37L,39L,40L,41L,42L,43L,44L,45L,46L,47L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,62L,63L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,76L,77L,78L,79L,80L,81L,82L,83L,84L,85L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225387Inst : IEnumerable<long>
{
public static readonly long[] Value=A225387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225387.Bytes);
public long this[int i]=>Value[i];

public static A225387Inst Instance=new A225387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225388
{
public static readonly long[] Value={ 25L,125L,169L,243L,256L,289L,625L,841L,1369L,1681L,2809L,3125L,3721L,5329L,9409L,11881L,12769L,18769L,22201L,28561L,37249L,38809L,54289L,76729L,83521L,100489L,113569L,151321L,160801L,196249L,201601L,208849L,292681L,323761L,375769L,390625L,410881L,426409L,452929L,502681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225388Inst : IEnumerable<long>
{
public static readonly long[] Value=A225388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225388.Bytes);
public long this[int i]=>Value[i];

public static A225388Inst Instance=new A225388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225389
{
public static readonly long[] Value={ 781370209L,59015782001929L,109012413691801L,185341023228001L,275502533796361L,315952509152809L,613721000732449L,1579642847367841L,3182047597748881L,5927491050020401L,13602074755852489L,22706626517726761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225389Inst : IEnumerable<long>
{
public static readonly long[] Value=A225389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225389.Bytes);
public long this[int i]=>Value[i];

public static A225389Inst Instance=new A225389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225390
{
public static readonly long[] Value={ 630L,749700L,2162160L,34283340L,76576500L,105887628L,330360660L,865924920L,2456409186L,17246794950L,35051708835L,999302826060L,3153804823260L,161708540211900L,1153195485992550L,1330786621788263640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225390Inst : IEnumerable<long>
{
public static readonly long[] Value=A225390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225390.Bytes);
public long this[int i]=>Value[i];

public static A225390Inst Instance=new A225390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225391
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,8L,14L,23L,38L,63L,104L,172L,285L,472L,781L,1293L,2140L,3542L,5863L,9705L,16064L,26590L,44013L,72852L,120588L,199603L,330392L,546880L,905221L,1498363L,2480159L,4105273L,6795236L,11247786L,18617851L,30817120L,51009909L,84433939L,139758925L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225391Inst : IEnumerable<long>
{
public static readonly long[] Value=A225391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225391.Bytes);
public long this[int i]=>Value[i];

public static A225391Inst Instance=new A225391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225392
{
public static readonly long[] Value={ 22155L,1864149L,2760681L,6222765L,22687797L,25631319L,29309589L,33333069L,36490905L,56310891L,60212889L,74097849L,76008207L,80864685L,84214395L,132006225L,132621171L,137362521L,138993381L,152223885L,154185525L,175950081L,188261481L,188677335L,194279955L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225392Inst : IEnumerable<long>
{
public static readonly long[] Value=A225392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225392.Bytes);
public long this[int i]=>Value[i];

public static A225392Inst Instance=new A225392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225393
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,8L,12L,19L,30L,47L,74L,116L,183L,288L,453L,713L,1122L,1766L,2779L,4373L,6882L,10830L,17043L,26820L,42206L,66419L,104522L,164484L,258845L,407339L,641021L,1008761L,1587466L,2498162L,3931305L,6186612L,9735741L,15320931L,24110227L,37941757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225393Inst : IEnumerable<long>
{
public static readonly long[] Value=A225393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225393.Bytes);
public long this[int i]=>Value[i];

public static A225393Inst Instance=new A225393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225394
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,8L,13L,20L,32L,51L,81L,129L,205L,326L,519L,826L,1314L,2091L,3327L,5294L,8424L,13404L,21328L,33937L,54000L,85924L,136721L,217548L,346159L,550803L,876429L,1394560L,2219002L,3530841L,5618219L,8939622L,14224586L,22633938L,36014767L,57306132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225394Inst : IEnumerable<long>
{
public static readonly long[] Value=A225394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225394.Bytes);
public long this[int i]=>Value[i];

public static A225394Inst Instance=new A225394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225395
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,4L,1L,2L,3L,5L,2L,6L,4L,6L,1L,7L,2L,8L,3L,8L,5L,9L,2L,3L,6L,4L,4L,10L,6L,11L,1L,10L,7L,12L,2L,12L,8L,12L,3L,13L,8L,14L,5L,6L,9L,15L,2L,4L,3L,14L,6L,16L,4L,15L,4L,16L,10L,17L,6L,18L,11L,8L,1L,18L,10L,19L,7L,18L,12L,20L,2L,21L,12L,6L,8L,20L,12L,22L,3L,2L,13L,23L,8L,21L,14L,20L,5L,24L,6L,24L,9L,22L,15L,24L,2L,25L,4L,10L,3L,26L,14L,27L,6L,24L,16L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225395Inst : IEnumerable<long>
{
public static readonly long[] Value=A225395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225395.Bytes);
public long this[int i]=>Value[i];

public static A225395Inst Instance=new A225395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225396
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,8L,13L,21L,34L,55L,88L,142L,229L,369L,595L,959L,1546L,2492L,4017L,6475L,10438L,16826L,27123L,43722L,70479L,113611L,183139L,295217L,475885L,767119L,1236583L,1993351L,3213249L,5179704L,8349597L,13459412L,21696349L,34974155L,56377758L,90880011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225396Inst : IEnumerable<long>
{
public static readonly long[] Value=A225396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225396.Bytes);
public long this[int i]=>Value[i];

public static A225396Inst Instance=new A225396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225397
{
public static readonly long[] Value={ 31L,109L,373L,409L,619L,823L,1531L,6637L,70687L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225397Inst : IEnumerable<long>
{
public static readonly long[] Value=A225397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225397.Bytes);
public long this[int i]=>Value[i];

public static A225397Inst Instance=new A225397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225398
{
public static readonly long[] Value={ 1L,1L,38L,1L,1L,676L,4806L,676L,1L,1L,10914L,362895L,1346780L,362895L,10914L,1L,1L,174752L,20554588L,263879264L,683233990L,263879264L,20554588L,174752L,1L,1L,2796190L,1063096365L,35677598760L,267248150610L,554291429748L,267248150610L,35677598760L,1063096365L,2796190L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225398Inst : IEnumerable<long>
{
public static readonly long[] Value=A225398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225398.Bytes);
public long this[int i]=>Value[i];

public static A225398Inst Instance=new A225398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225399
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,1L,0L,2L,2L,0L,2L,2L,0L,3L,4L,0L,1L,1L,1L,6L,2L,0L,2L,4L,0L,1L,3L,0L,2L,2L,0L,3L,1L,0L,8L,2L,0L,1L,5L,1L,2L,2L,0L,7L,3L,0L,2L,4L,0L,2L,3L,0L,1L,4L,3L,4L,1L,0L,4L,4L,0L,2L,5L,1L,3L,1L,0L,2L,4L,0L,3L,3L,0L,2L,5L,0L,4L,1L,1L,7L,1L,0L,3L,8L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225399Inst : IEnumerable<long>
{
public static readonly long[] Value=A225399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225399.Bytes);
public long this[int i]=>Value[i];

public static A225399Inst Instance=new A225399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225400
{
public static readonly long[] Value={ 0L,3L,8L,14L,15L,39L,20L,44L,35L,195L,119L,104L,594L,224L,384L,455L,539L,440L,560L,3080L,2184L,1539L,2015L,2639L,5264L,4199L,15399L,13299L,8855L,23919L,2079L,30744L,43680L,36575L,14399L,5984L,58695L,113399L,47124L,107184L,12375L,78624L,98175L,73359L,111320L,242879L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225400Inst : IEnumerable<long>
{
public static readonly long[] Value=A225400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225400.Bytes);
public long this[int i]=>Value[i];

public static A225400Inst Instance=new A225400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225401
{
public static readonly long[] Value={ 3L,5L,7L,0L,6L,6L,9L,9L,8L,3L,3L,2L,7L,9L,4L,1L,3L,6L,9L,5L,5L,3L,9L,0L,2L,8L,0L,5L,7L,3L,1L,2L,0L,3L,1L,9L,4L,2L,8L,9L,3L,3L,0L,1L,3L,5L,0L,9L,0L,1L,4L,0L,9L,4L,0L,3L,4L,7L,8L,4L,6L,5L,3L,2L,7L,5L,5L,8L,3L,6L,7L,3L,8L,5L,8L,9L,7L,2L,9L,9L,4L,5L,8L,2L,0L,3L,5L,8L,6L,7L,8L,9L,5L,3L,8L,4L,3L,8L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225401Inst : IEnumerable<long>
{
public static readonly long[] Value=A225401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225401.Bytes);
public long this[int i]=>Value[i];

public static A225401Inst Instance=new A225401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225402
{
public static readonly long[] Value={ 7L,7L,4L,6L,4L,4L,5L,8L,3L,4L,4L,6L,8L,3L,1L,5L,1L,0L,5L,1L,6L,9L,6L,1L,3L,1L,3L,7L,2L,2L,4L,6L,4L,4L,3L,8L,3L,5L,3L,3L,5L,6L,2L,5L,2L,3L,2L,8L,6L,3L,4L,1L,8L,9L,6L,7L,0L,4L,8L,3L,6L,7L,1L,1L,6L,6L,5L,2L,0L,7L,4L,0L,9L,2L,8L,0L,3L,0L,3L,0L,7L,3L,9L,7L,9L,7L,3L,4L,6L,5L,3L,1L,3L,0L,0L,8L,7L,4L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225402Inst : IEnumerable<long>
{
public static readonly long[] Value=A225402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225402.Bytes);
public long this[int i]=>Value[i];

public static A225402Inst Instance=new A225402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225403
{
public static readonly long[] Value={ 2L,3L,7L,5L,7L,41L,283L,3L,127L,11161L,1427L,17L,8011L,821L,607L,2161L,4903L,509L,1607L,127L,11261L,8273L,12037L,58207L,419L,11491L,2153L,1789L,9059L,67843L,29L,5641L,1999L,2459L,1699L,15299L,35747L,2531L,10987L,26497L,36781L,719L,24709L,13721L,29803L,1049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225403Inst : IEnumerable<long>
{
public static readonly long[] Value=A225403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225403.Bytes);
public long this[int i]=>Value[i];

public static A225403Inst Instance=new A225403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225404
{
public static readonly long[] Value={ 7L,8L,5L,4L,3L,1L,5L,9L,8L,7L,8L,0L,0L,5L,8L,3L,2L,4L,0L,6L,1L,5L,6L,6L,2L,9L,4L,8L,1L,3L,0L,3L,6L,1L,8L,4L,8L,4L,6L,1L,9L,2L,2L,1L,3L,3L,8L,6L,8L,7L,8L,8L,9L,0L,6L,5L,9L,6L,3L,5L,3L,0L,2L,4L,2L,3L,0L,9L,0L,5L,2L,1L,6L,0L,7L,0L,1L,9L,9L,4L,7L,5L,7L,9L,3L,4L,8L,6L,6L,3L,3L,1L,1L,4L,3L,3L,6L,6L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225404Inst : IEnumerable<long>
{
public static readonly long[] Value=A225404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225404.Bytes);
public long this[int i]=>Value[i];

public static A225404Inst Instance=new A225404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225405
{
public static readonly long[] Value={ 3L,4L,5L,1L,5L,0L,7L,1L,2L,2L,2L,4L,4L,2L,9L,6L,0L,7L,3L,5L,4L,5L,8L,8L,8L,0L,4L,1L,8L,5L,1L,4L,0L,0L,6L,1L,3L,5L,4L,4L,8L,1L,3L,7L,4L,0L,7L,4L,8L,5L,5L,1L,6L,7L,4L,5L,5L,0L,0L,4L,9L,0L,4L,7L,0L,8L,6L,8L,4L,7L,4L,4L,2L,2L,0L,3L,2L,2L,0L,1L,6L,5L,5L,4L,3L,0L,3L,4L,9L,7L,1L,5L,1L,2L,3L,0L,2L,5L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225405Inst : IEnumerable<long>
{
public static readonly long[] Value=A225405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225405.Bytes);
public long this[int i]=>Value[i];

public static A225405Inst Instance=new A225405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225406
{
public static readonly long[] Value={ 9L,6L,5L,0L,6L,6L,3L,4L,8L,6L,6L,0L,4L,8L,5L,4L,5L,9L,4L,5L,1L,1L,9L,4L,0L,6L,0L,8L,1L,3L,7L,0L,6L,6L,9L,4L,8L,3L,9L,9L,3L,0L,2L,4L,2L,0L,3L,5L,9L,8L,6L,5L,5L,0L,9L,6L,7L,7L,4L,8L,0L,7L,4L,6L,1L,0L,3L,2L,9L,8L,5L,8L,2L,1L,5L,7L,0L,9L,0L,9L,8L,8L,1L,6L,0L,6L,8L,6L,0L,3L,9L,5L,0L,9L,9L,5L,6L,5L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225406Inst : IEnumerable<long>
{
public static readonly long[] Value=A225406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225406.Bytes);
public long this[int i]=>Value[i];

public static A225406Inst Instance=new A225406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225407
{
public static readonly long[] Value={ 3L,1L,4L,5L,6L,8L,4L,0L,1L,2L,1L,9L,9L,4L,1L,6L,7L,5L,9L,3L,8L,4L,3L,3L,7L,0L,5L,1L,8L,6L,9L,6L,3L,8L,1L,5L,1L,5L,3L,8L,0L,7L,7L,8L,6L,6L,1L,3L,1L,2L,1L,1L,0L,9L,3L,4L,0L,3L,6L,4L,6L,9L,7L,5L,7L,6L,9L,0L,9L,4L,7L,8L,3L,9L,2L,9L,8L,0L,0L,5L,2L,4L,2L,0L,6L,5L,1L,3L,3L,6L,6L,8L,8L,5L,6L,6L,3L,3L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225407Inst : IEnumerable<long>
{
public static readonly long[] Value=A225407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225407.Bytes);
public long this[int i]=>Value[i];

public static A225407Inst Instance=new A225407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225408
{
public static readonly long[] Value={ 7L,5L,4L,8L,4L,9L,2L,8L,7L,7L,7L,5L,5L,7L,0L,3L,9L,2L,6L,4L,5L,4L,1L,1L,1L,9L,5L,8L,1L,4L,8L,5L,9L,9L,3L,8L,6L,4L,5L,5L,1L,8L,6L,2L,5L,9L,2L,5L,1L,4L,4L,8L,3L,2L,5L,4L,4L,9L,9L,5L,0L,9L,5L,2L,9L,1L,3L,1L,5L,2L,5L,5L,7L,7L,9L,6L,7L,7L,9L,8L,3L,4L,4L,5L,6L,9L,6L,5L,0L,2L,8L,4L,8L,7L,6L,9L,7L,4L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225408Inst : IEnumerable<long>
{
public static readonly long[] Value=A225408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225408.Bytes);
public long this[int i]=>Value[i];

public static A225408Inst Instance=new A225408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225409
{
public static readonly long[] Value={ 1L,3L,4L,9L,3L,3L,6L,5L,1L,3L,3L,9L,5L,1L,4L,5L,4L,0L,5L,4L,8L,8L,0L,5L,9L,3L,9L,1L,8L,6L,2L,9L,3L,3L,0L,5L,1L,6L,0L,0L,6L,9L,7L,5L,7L,9L,6L,4L,0L,1L,3L,4L,4L,9L,0L,3L,2L,2L,5L,1L,9L,2L,5L,3L,8L,9L,6L,7L,0L,1L,4L,1L,7L,8L,4L,2L,9L,0L,9L,0L,1L,1L,8L,3L,9L,3L,1L,3L,9L,6L,0L,4L,9L,0L,0L,4L,3L,4L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225409Inst : IEnumerable<long>
{
public static readonly long[] Value=A225409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225409.Bytes);
public long this[int i]=>Value[i];

public static A225409Inst Instance=new A225409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225410
{
public static readonly long[] Value={ 7L,4L,2L,9L,3L,3L,0L,0L,1L,6L,6L,7L,2L,0L,5L,8L,6L,3L,0L,4L,4L,6L,0L,9L,7L,1L,9L,4L,2L,6L,8L,7L,9L,6L,8L,0L,5L,7L,1L,0L,6L,6L,9L,8L,6L,4L,9L,0L,9L,8L,5L,9L,0L,5L,9L,6L,5L,2L,1L,5L,3L,4L,6L,7L,2L,4L,4L,1L,6L,3L,2L,6L,1L,4L,1L,0L,2L,7L,0L,0L,5L,4L,1L,7L,9L,6L,4L,1L,3L,2L,1L,0L,4L,6L,1L,5L,6L,1L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225410Inst : IEnumerable<long>
{
public static readonly long[] Value=A225410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225410.Bytes);
public long this[int i]=>Value[i];

public static A225410Inst Instance=new A225410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225411
{
public static readonly long[] Value={ 3L,2L,5L,3L,5L,5L,4L,1L,6L,5L,5L,3L,1L,6L,8L,4L,8L,9L,4L,8L,3L,0L,3L,8L,6L,8L,6L,2L,7L,7L,5L,3L,5L,5L,6L,1L,6L,4L,6L,6L,4L,3L,7L,4L,7L,6L,7L,1L,3L,6L,5L,8L,1L,0L,3L,2L,9L,5L,1L,6L,3L,2L,8L,8L,3L,3L,4L,7L,9L,2L,5L,9L,0L,7L,1L,9L,6L,9L,6L,9L,2L,6L,0L,2L,0L,2L,6L,5L,3L,4L,6L,8L,6L,9L,9L,1L,2L,5L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225411Inst : IEnumerable<long>
{
public static readonly long[] Value=A225411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225411.Bytes);
public long this[int i]=>Value[i];

public static A225411Inst Instance=new A225411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225412
{
public static readonly long[] Value={ 9L,2L,5L,1L,1L,7L,1L,3L,6L,2L,6L,3L,3L,8L,2L,1L,4L,1L,0L,2L,7L,1L,2L,2L,4L,6L,1L,6L,0L,1L,0L,1L,2L,7L,2L,8L,2L,8L,8L,3L,6L,7L,0L,7L,7L,7L,2L,2L,6L,2L,6L,9L,9L,6L,8L,1L,3L,2L,1L,5L,4L,3L,7L,4L,7L,7L,6L,9L,6L,1L,4L,0L,2L,0L,9L,6L,3L,6L,6L,1L,9L,1L,9L,9L,7L,4L,9L,8L,8L,7L,7L,3L,0L,8L,7L,7L,8L,8L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225412Inst : IEnumerable<long>
{
public static readonly long[] Value=A225412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225412.Bytes);
public long this[int i]=>Value[i];

public static A225412Inst Instance=new A225412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225413
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,3L,3L,0L,0L,0L,0L,6L,12L,6L,0L,0L,0L,0L,10L,30L,30L,10L,0L,0L,0L,0L,15L,60L,91L,60L,15L,0L,0L,0L,0L,21L,105L,215L,215L,105L,21L,0L,0L,0L,0L,28L,168L,435L,590L,435L,168L,28L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225413Inst : IEnumerable<long>
{
public static readonly long[] Value=A225413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225413.Bytes);
public long this[int i]=>Value[i];

public static A225413Inst Instance=new A225413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225414
{
public static readonly long[] Value={ 3L,22L,49L,69L,156L,187L,190L,295L,465L,498L,594L,777L,880L,931L,1144L,1269L,1330L,1501L,1611L,1633L,2190L,2272L,2494L,2619L,2655L,2893L,3475L,3732L,3937L,4182L,4524L,4719L,4900L,5502L,5635L,5866L,6490L,7021L,7185L,7719L,7761L,7828L,7849L,8688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225414Inst : IEnumerable<long>
{
public static readonly long[] Value=A225414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225414.Bytes);
public long this[int i]=>Value[i];

public static A225414Inst Instance=new A225414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225415
{
public static readonly long[] Value={ 1L,1L,58L,1L,1L,1556L,12006L,1556L,1L,1L,39054L,1461615L,5647300L,1461615L,39054L,1L,1L,976552L,135028828L,1838120344L,4873361350L,1838120344L,135028828L,976552L,1L,1L,24414050L,11462721645L,414730580760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225415Inst : IEnumerable<long>
{
public static readonly long[] Value=A225415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225415.Bytes);
public long this[int i]=>Value[i];

public static A225415Inst Instance=new A225415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225416
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,3L,2L,3L,2L,2L,3L,1L,2L,1L,2L,3L,2L,2L,3L,3L,2L,1L,2L,2L,1L,2L,3L,4L,5L,2L,3L,1L,3L,3L,2L,1L,2L,3L,4L,5L,3L,1L,2L,2L,3L,2L,1L,2L,3L,4L,5L,1L,3L,2L,4L,3L,2L,1L,2L,3L,4L,1L,2L,3L,5L,4L,3L,2L,1L,2L,3L,1L,2L,3L,2L,5L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225416Inst : IEnumerable<long>
{
public static readonly long[] Value=A225416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225416.Bytes);
public long this[int i]=>Value[i];

public static A225416Inst Instance=new A225416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225417
{
public static readonly long[] Value={ 6L,28L,121L,437L,496L,611L,1331L,1397L,8128L,10201L,14641L,27019L,40301L,40991L,41347L,41917L,45743L,47873L,49901L,51101L,67997L,76459L,97637L,99101L,99553L,99779L,120353L,133307L,133961L,134179L,153091L,161051L,165101L,165743L,166171L,182525L,186503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225417Inst : IEnumerable<long>
{
public static readonly long[] Value=A225417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225417.Bytes);
public long this[int i]=>Value[i];

public static A225417Inst Instance=new A225417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225418
{
public static readonly long[] Value={ 25L,32L,54L,98L,125L,126L,128L,140L,196L,230L,243L,246L,255L,256L,315L,322L,348L,366L,392L,512L,520L,576L,625L,810L,828L,896L,1024L,1029L,1060L,1080L,1152L,1166L,1216L,1224L,1225L,1243L,1330L,1395L,1400L,1458L,1462L,1512L,1536L,1548L,1575L,1647L,1708L,1792L,1824L,1872L,1875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225418Inst : IEnumerable<long>
{
public static readonly long[] Value=A225418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225418.Bytes);
public long this[int i]=>Value[i];

public static A225418Inst Instance=new A225418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225419
{
public static readonly long[] Value={ 1L,1L,4L,1L,6L,15L,1L,8L,28L,56L,1L,10L,45L,120L,210L,1L,12L,66L,220L,495L,792L,1L,14L,91L,364L,1001L,2002L,3003L,1L,16L,120L,560L,1820L,4368L,8008L,11440L,1L,18L,153L,816L,3060L,8568L,18564L,31824L,43758L,1L,20L,190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225419Inst : IEnumerable<long>
{
public static readonly long[] Value=A225419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225419.Bytes);
public long this[int i]=>Value[i];

public static A225419Inst Instance=new A225419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225420
{
public static readonly long[] Value={ 1L,14L,33L,32L,91L,141L,213L,212L,213L,3090L,3093L,3090L,3090L,3090L,38405L,38404L,3090L,3090L,38401L,38400L,294581L,294581L,39569681L,5571498L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225420Inst : IEnumerable<long>
{
public static readonly long[] Value=A225420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225420.Bytes);
public long this[int i]=>Value[i];

public static A225420Inst Instance=new A225420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225421
{
public static readonly long[] Value={ 3L,5L,7L,11L,19L,53L,59L,151L,353L,557L,599L,773L,997L,5557L,7559L,11119L,15559L,59999L,71777L,75553L,79999L,99991L,191999L,511111L,555557L,575557L,775777L,777977L,799979L,1111151L,3353333L,5595559L,5755559L,7577777L,9999991L,33335333L,55555553L,55555559L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225421Inst : IEnumerable<long>
{
public static readonly long[] Value=A225421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225421.Bytes);
public long this[int i]=>Value[i];

public static A225421Inst Instance=new A225421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225422
{
public static readonly long[] Value={ 2L,2L,6L,12L,12L,24L,60L,180L,360L,1260L,5040L,15120L,55440L,166320L,831600L,4324320L,36756720L,367567200L,2327925600L,27935107200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225422Inst : IEnumerable<long>
{
public static readonly long[] Value=A225422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225422.Bytes);
public long this[int i]=>Value[i];

public static A225422Inst Instance=new A225422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225423
{
public static readonly long[] Value={ 37L,43L,103L,157L,181L,283L,331L,379L,409L,433L,613L,631L,643L,691L,739L,811L,823L,829L,991L,1021L,1093L,1171L,1201L,1237L,1249L,1279L,1297L,1381L,1483L,1741L,1759L,1777L,1873L,1879L,2011L,2017L,2131L,2221L,2239L,2269L,2341L,2377L,2467L,2473L,2551L,2659L,2791L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225423Inst : IEnumerable<long>
{
public static readonly long[] Value=A225423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225423.Bytes);
public long this[int i]=>Value[i];

public static A225423Inst Instance=new A225423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225424
{
public static readonly long[] Value={ 5L,0L,3L,37L,7L,17L,11L,101L,61L,19L,41L,197L,109L,229L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225424Inst : IEnumerable<long>
{
public static readonly long[] Value=A225424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225424.Bytes);
public long this[int i]=>Value[i];

public static A225424Inst Instance=new A225424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225425
{
public static readonly long[] Value={ 1L,6L,31L,120L,418L,1268L,3499L,8987L,22316L,51677L,116978L,252856L,528275L,1075319L,2131671L,4119410L,7801334L,14482065L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225425Inst : IEnumerable<long>
{
public static readonly long[] Value=A225425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225425.Bytes);
public long this[int i]=>Value[i];

public static A225425Inst Instance=new A225425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225426
{
public static readonly long[] Value={ 1L,8L,9L,5L,27L,32L,1L,48L,49L,1L,63L,64L,1L,80L,81L,32L,49L,81L,4L,121L,125L,3L,125L,128L,1L,224L,225L,1L,242L,243L,2L,243L,245L,7L,243L,250L,13L,243L,256L,81L,175L,256L,1L,288L,289L,100L,243L,343L,32L,343L,375L,5L,507L,512L,169L,343L,512L,1L,512L,513L,27L,512L,539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225426Inst : IEnumerable<long>
{
public static readonly long[] Value=A225426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225426.Bytes);
public long this[int i]=>Value[i];

public static A225426Inst Instance=new A225426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225427
{
public static readonly long[] Value={ 3L,34L,10L,21L,8L,20L,12L,456L,168L,216L,40L,1764L,24L,432L,2772L,780L,1008L,5640L,720L,88452L,15840L,840L,3360L,14040L,288288L,117600L,338400L,13860L,40320L,6283200L,100800L,2106720L,7698600L,26943840L,19768320L,202799520L,12972960L,242260200L,372556800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225427Inst : IEnumerable<long>
{
public static readonly long[] Value=A225427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225427.Bytes);
public long this[int i]=>Value[i];

public static A225427Inst Instance=new A225427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225428
{
public static readonly long[] Value={ 0L,1L,9L,47L,212L,1232L,6592L,31145L,129587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225428Inst : IEnumerable<long>
{
public static readonly long[] Value=A225428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225428.Bytes);
public long this[int i]=>Value[i];

public static A225428Inst Instance=new A225428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225429
{
public static readonly long[] Value={ 0L,1L,8L,38L,165L,1020L,5360L,24553L,98442L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225429Inst : IEnumerable<long>
{
public static readonly long[] Value=A225429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225429.Bytes);
public long this[int i]=>Value[i];

public static A225429Inst Instance=new A225429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225430
{
public static readonly long[] Value={ 4L,7L,8L,17L,43L,83L,167L,314L,707L,836L,6833L,8167L,21886L,41833L,89437L,134164L,947617L,987917L,3143167L,3162083L,9272917L,24060133L,60827617L,434738887L,529027313L,2641873937L,5383305583L,14141757313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225430Inst : IEnumerable<long>
{
public static readonly long[] Value=A225430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225430.Bytes);
public long this[int i]=>Value[i];

public static A225430Inst Instance=new A225430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225431
{
public static readonly long[] Value={ 3L,11L,41L,2131L,110771L,15558008491L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225431Inst : IEnumerable<long>
{
public static readonly long[] Value=A225431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225431.Bytes);
public long this[int i]=>Value[i];

public static A225431Inst Instance=new A225431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225432
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,10L,1L,5L,250L,106L,1138L,2L,25L,146L,298L,5L,17L,1L,97L,253970L,2L,226L,3034L,9148450L,2050L,10L,157L,126890L,1L,14341370L,5L,110671282L,986L,7586L,530L,130L,173L,5129602L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225432Inst : IEnumerable<long>
{
public static readonly long[] Value=A225432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225432.Bytes);
public long this[int i]=>Value[i];

public static A225432Inst Instance=new A225432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225433
{
public static readonly long[] Value={ 1L,1L,1L,1L,-38L,1L,1L,-165L,-165L,1L,1L,-676L,4806L,-676L,1L,1L,-2723L,44452L,44452L,-2723L,1L,1L,-10914L,362895L,-1346780L,362895L,-10914L,1L,1L,-43681L,2780367L,-20297327L,-20297327L,2780367L,-43681L,1L,1L,-174752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225433Inst : IEnumerable<long>
{
public static readonly long[] Value=A225433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225433.Bytes);
public long this[int i]=>Value[i];

public static A225433Inst Instance=new A225433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225434
{
public static readonly long[] Value={ 1L,1L,1L,1L,-58L,1L,1L,-307L,-307L,1L,1L,-1556L,12006L,-1556L,1L,1L,-7805L,140722L,140722L,-7805L,1L,1L,-39054L,1461615L,-5647300L,1461615L,-39054L,1L,1L,-195303L,14287093L,-109642851L,-109642851L,14287093L,-195303L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225434Inst : IEnumerable<long>
{
public static readonly long[] Value=A225434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225434.Bytes);
public long this[int i]=>Value[i];

public static A225434Inst Instance=new A225434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225435
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,19L,68L,44L,416L,758L,6092L,24284L,10348L,110864L,997828L,4545476L,827252L,5166356L,255994804L,1289266004L,3332578444L,8757252244L,3766552348L,27079574548L,1434303566956L,4061479240156L,46849154788124L,54858398447372L,816458740546228L,189647639388428L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225435Inst : IEnumerable<long>
{
public static readonly long[] Value=A225435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225435.Bytes);
public long this[int i]=>Value[i];

public static A225435Inst Instance=new A225435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225436
{
public static readonly long[] Value={ 1L,3L,3L,9L,12L,39L,123L,87L,771L,1473L,11427L,46779L,19533L,212559L,1890093L,8691981L,1570137L,9863961L,486463449L,2459255649L,6337494039L,16694653089L,7166066763L,51605000913L,2729643372111L,7738039298811L,89176449644619L,104501330075607L,1554311845035993L,361227369257943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225436Inst : IEnumerable<long>
{
public static readonly long[] Value=A225436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225436.Bytes);
public long this[int i]=>Value[i];

public static A225436Inst Instance=new A225436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225437
{
public static readonly long[] Value={ 1L,1L,2L,0L,4L,0L,5L,1L,7L,0L,4L,0L,18L,0L,2L,0L,17L,0L,16L,0L,15L,0L,9L,0L,39L,0L,9L,0L,61L,0L,10L,3L,27L,0L,18L,0L,56L,0L,8L,0L,80L,0L,48L,1L,41L,0L,12L,0L,118L,1L,10L,0L,90L,0L,30L,2L,24L,0L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225437Inst : IEnumerable<long>
{
public static readonly long[] Value=A225437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225437.Bytes);
public long this[int i]=>Value[i];

public static A225437Inst Instance=new A225437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225438
{
public static readonly long[] Value={ 1L,9L,15L,21L,25L,27L,33L,39L,45L,49L,51L,55L,57L,63L,65L,69L,75L,77L,81L,85L,87L,93L,99L,105L,111L,117L,123L,129L,135L,141L,147L,153L,155L,159L,161L,165L,171L,177L,183L,185L,187L,189L,195L,201L,205L,207L,213L,219L,221L,225L,231L,237L,243L,245L,247L,249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225438Inst : IEnumerable<long>
{
public static readonly long[] Value=A225438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225438.Bytes);
public long this[int i]=>Value[i];

public static A225438Inst Instance=new A225438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225439
{
public static readonly long[] Value={ 1L,3L,21L,162L,1305L,10773L,90342L,765936L,6546177L,56293380L,486451251L,4220183916L,36731240910L,320571837810L,2804298945840L,24580601689752L,215832643307217L,1898042178972285L,16714070686567620L,147360883148636850L,1300623629653125855L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225439Inst : IEnumerable<long>
{
public static readonly long[] Value=A225439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225439.Bytes);
public long this[int i]=>Value[i];

public static A225439Inst Instance=new A225439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225440
{
public static readonly long[] Value={ 378L,630L,990L,3240L,4095L,4950L,5460L,9180L,15400L,19110L,25200L,31878L,37128L,37950L,39060L,52650L,61425L,79800L,97020L,103740L,105570L,122265L,145530L,157080L,161028L,176715L,192510L,221445L,265356L,288420L,304590L,306936L,346528L,437580L,500500L,545490L,583740L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225440Inst : IEnumerable<long>
{
public static readonly long[] Value=A225440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225440.Bytes);
public long this[int i]=>Value[i];

public static A225440Inst Instance=new A225440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225441
{
public static readonly long[] Value={ 3L,3L,6L,5L,9L,8L,0L,3L,1L,9L,2L,2L,9L,2L,4L,9L,3L,1L,3L,9L,4L,0L,7L,4L,3L,6L,7L,8L,6L,4L,6L,8L,1L,7L,7L,1L,3L,8L,8L,0L,1L,7L,8L,4L,6L,0L,3L,0L,1L,0L,0L,2L,8L,0L,2L,4L,3L,4L,8L,2L,9L,2L,3L,5L,5L,4L,1L,3L,5L,3L,1L,0L,7L,0L,1L,1L,6L,7L,9L,9L,8L,1L,7L,2L,0L,8L,4L,1L,3L,1L,7L,4L,3L,5L,3L,7L,0L,6L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225441Inst : IEnumerable<long>
{
public static readonly long[] Value=A225441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225441.Bytes);
public long this[int i]=>Value[i];

public static A225441Inst Instance=new A225441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225442
{
public static readonly long[] Value={ 7L,3L,4L,7L,5L,2L,2L,0L,4L,1L,9L,0L,8L,3L,4L,1L,0L,5L,3L,3L,0L,9L,6L,5L,3L,4L,9L,0L,4L,7L,7L,0L,5L,1L,3L,8L,2L,2L,9L,9L,9L,1L,8L,0L,6L,9L,5L,8L,3L,9L,8L,1L,4L,6L,7L,1L,1L,3L,0L,5L,0L,5L,2L,2L,8L,8L,5L,7L,7L,9L,5L,1L,5L,8L,3L,6L,5L,0L,4L,7L,7L,9L,0L,1L,3L,7L,7L,9L,2L,8L,9L,8L,4L,4L,2L,7L,6L,5L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225442Inst : IEnumerable<long>
{
public static readonly long[] Value=A225442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225442.Bytes);
public long this[int i]=>Value[i];

public static A225442Inst Instance=new A225442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225443
{
public static readonly long[] Value={ 1L,3L,0L,1L,9L,1L,8L,7L,3L,0L,2L,4L,3L,2L,5L,8L,3L,2L,4L,7L,4L,4L,6L,5L,6L,9L,7L,2L,5L,7L,7L,4L,8L,4L,4L,0L,8L,4L,1L,3L,1L,9L,8L,3L,1L,7L,7L,8L,4L,2L,0L,6L,9L,6L,8L,6L,6L,0L,0L,1L,7L,0L,9L,8L,8L,6L,6L,0L,7L,2L,1L,3L,3L,5L,9L,7L,3L,3L,7L,3L,9L,4L,5L,4L,5L,2L,3L,7L,6L,7L,3L,5L,5L,3L,7L,7L,3L,3L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225443Inst : IEnumerable<long>
{
public static readonly long[] Value=A225443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225443.Bytes);
public long this[int i]=>Value[i];

public static A225443Inst Instance=new A225443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225444
{
public static readonly long[] Value={ 7L,2L,6L,1L,5L,9L,6L,2L,8L,3L,7L,8L,8L,7L,9L,3L,6L,0L,9L,3L,4L,8L,1L,3L,8L,2L,7L,6L,2L,0L,5L,7L,4L,8L,4L,1L,7L,6L,4L,5L,3L,5L,1L,1L,5L,1L,0L,9L,6L,1L,7L,8L,6L,2L,0L,6L,2L,7L,7L,9L,5L,1L,7L,1L,3L,6L,0L,6L,5L,4L,8L,9L,1L,5L,3L,5L,9L,7L,2L,9L,3L,1L,4L,8L,3L,5L,8L,7L,3L,1L,0L,5L,5L,9L,0L,0L,7L,0L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225444Inst : IEnumerable<long>
{
public static readonly long[] Value=A225444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225444.Bytes);
public long this[int i]=>Value[i];

public static A225444Inst Instance=new A225444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225445
{
public static readonly long[] Value={ 3L,4L,3L,2L,1L,0L,9L,4L,6L,2L,6L,6L,3L,5L,3L,3L,3L,4L,9L,8L,0L,7L,9L,7L,3L,9L,5L,8L,1L,9L,5L,2L,0L,2L,3L,5L,9L,5L,9L,0L,0L,7L,4L,3L,9L,1L,6L,4L,5L,0L,2L,8L,4L,9L,1L,8L,9L,7L,8L,9L,8L,1L,0L,5L,6L,9L,5L,9L,6L,0L,1L,3L,0L,7L,8L,5L,7L,7L,8L,5L,1L,2L,9L,9L,9L,5L,2L,9L,9L,3L,5L,8L,8L,3L,1L,6L,4L,1L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225445Inst : IEnumerable<long>
{
public static readonly long[] Value=A225445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225445.Bytes);
public long this[int i]=>Value[i];

public static A225445Inst Instance=new A225445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225446
{
public static readonly long[] Value={ 9L,2L,1L,7L,4L,9L,7L,9L,3L,5L,3L,7L,1L,0L,8L,5L,2L,9L,1L,0L,5L,5L,6L,4L,6L,0L,5L,0L,3L,6L,4L,7L,4L,2L,7L,6L,0L,5L,0L,5L,1L,1L,8L,9L,9L,5L,1L,5L,8L,5L,1L,4L,5L,0L,0L,7L,7L,2L,8L,0L,7L,7L,7L,4L,8L,3L,6L,2L,7L,7L,9L,9L,1L,0L,4L,7L,0L,9L,0L,3L,0L,5L,1L,1L,1L,7L,5L,6L,3L,3L,2L,0L,1L,1L,7L,9L,5L,6L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225446Inst : IEnumerable<long>
{
public static readonly long[] Value=A225446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225446.Bytes);
public long this[int i]=>Value[i];

public static A225446Inst Instance=new A225446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225447
{
public static readonly long[] Value={ 3L,7L,3L,8L,4L,0L,3L,7L,1L,6L,2L,1L,1L,2L,0L,6L,3L,9L,0L,6L,5L,1L,8L,6L,1L,7L,2L,3L,7L,9L,4L,2L,5L,1L,5L,8L,2L,3L,5L,4L,6L,4L,8L,8L,4L,8L,9L,0L,3L,8L,2L,1L,3L,7L,9L,3L,7L,2L,2L,0L,4L,8L,2L,8L,6L,3L,9L,3L,4L,5L,1L,0L,8L,4L,6L,4L,0L,2L,7L,0L,6L,8L,5L,1L,6L,4L,1L,2L,6L,8L,9L,4L,4L,0L,9L,9L,2L,9L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225447Inst : IEnumerable<long>
{
public static readonly long[] Value=A225447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225447.Bytes);
public long this[int i]=>Value[i];

public static A225447Inst Instance=new A225447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225448
{
public static readonly long[] Value={ 7L,5L,6L,7L,8L,9L,0L,5L,3L,7L,3L,3L,6L,4L,6L,6L,6L,5L,0L,1L,9L,2L,0L,2L,6L,0L,4L,1L,8L,0L,4L,7L,9L,7L,6L,4L,0L,4L,0L,9L,9L,2L,5L,6L,0L,8L,3L,5L,4L,9L,7L,1L,5L,0L,8L,1L,0L,2L,1L,0L,1L,8L,9L,4L,3L,0L,4L,0L,3L,9L,8L,6L,9L,2L,1L,4L,2L,2L,1L,4L,8L,7L,0L,0L,0L,4L,7L,0L,0L,6L,4L,1L,1L,6L,8L,3L,5L,8L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225448Inst : IEnumerable<long>
{
public static readonly long[] Value=A225448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225448.Bytes);
public long this[int i]=>Value[i];

public static A225448Inst Instance=new A225448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225449
{
public static readonly long[] Value={ 1L,7L,8L,2L,5L,0L,2L,0L,6L,4L,6L,2L,8L,9L,1L,4L,7L,0L,8L,9L,4L,4L,3L,5L,3L,9L,4L,9L,6L,3L,5L,2L,5L,7L,2L,3L,9L,4L,9L,4L,8L,8L,1L,0L,0L,4L,8L,4L,1L,4L,8L,5L,4L,9L,9L,2L,2L,7L,1L,9L,2L,2L,2L,5L,1L,6L,3L,7L,2L,2L,0L,0L,8L,9L,5L,2L,9L,0L,9L,6L,9L,4L,8L,8L,8L,2L,4L,3L,6L,6L,7L,9L,8L,8L,2L,0L,4L,3L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225449Inst : IEnumerable<long>
{
public static readonly long[] Value=A225449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225449.Bytes);
public long this[int i]=>Value[i];

public static A225449Inst Instance=new A225449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225450
{
public static readonly long[] Value={ 7L,6L,3L,4L,0L,1L,9L,6L,8L,0L,7L,7L,0L,7L,5L,0L,6L,8L,6L,0L,5L,9L,2L,5L,6L,3L,2L,1L,3L,5L,3L,1L,8L,2L,2L,8L,6L,1L,1L,9L,8L,2L,1L,5L,3L,9L,6L,9L,8L,9L,9L,7L,1L,9L,7L,5L,6L,5L,1L,7L,0L,7L,6L,4L,4L,5L,8L,6L,4L,6L,8L,9L,2L,9L,8L,8L,3L,2L,0L,0L,1L,8L,2L,7L,9L,1L,5L,8L,6L,8L,2L,5L,6L,4L,6L,2L,9L,3L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225450Inst : IEnumerable<long>
{
public static readonly long[] Value=A225450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225450.Bytes);
public long this[int i]=>Value[i];

public static A225450Inst Instance=new A225450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225451
{
public static readonly long[] Value={ 3L,6L,5L,2L,4L,7L,7L,9L,5L,8L,0L,9L,1L,6L,5L,8L,9L,4L,6L,6L,9L,0L,3L,4L,6L,5L,0L,9L,5L,2L,2L,9L,4L,8L,6L,1L,7L,7L,0L,0L,0L,8L,1L,9L,3L,0L,4L,1L,6L,0L,1L,8L,5L,3L,2L,8L,8L,6L,9L,4L,9L,4L,7L,7L,1L,1L,4L,2L,2L,0L,4L,8L,4L,1L,6L,3L,4L,9L,5L,2L,2L,0L,9L,8L,6L,2L,2L,0L,7L,1L,0L,1L,5L,5L,7L,2L,3L,4L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225451Inst : IEnumerable<long>
{
public static readonly long[] Value=A225451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225451.Bytes);
public long this[int i]=>Value[i];

public static A225451Inst Instance=new A225451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225452
{
public static readonly long[] Value={ 9L,6L,9L,8L,0L,8L,1L,2L,6L,9L,7L,5L,6L,7L,4L,1L,6L,7L,5L,2L,5L,5L,3L,4L,3L,0L,2L,7L,4L,2L,2L,5L,1L,5L,5L,9L,1L,5L,8L,6L,8L,0L,1L,6L,8L,2L,2L,1L,5L,7L,9L,3L,0L,3L,1L,3L,3L,9L,9L,8L,2L,9L,0L,1L,1L,3L,3L,9L,2L,7L,8L,6L,6L,4L,0L,2L,6L,6L,2L,6L,0L,5L,4L,5L,4L,7L,6L,2L,3L,2L,6L,4L,4L,6L,2L,2L,6L,6L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225452Inst : IEnumerable<long>
{
public static readonly long[] Value=A225452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225452.Bytes);
public long this[int i]=>Value[i];

public static A225452Inst Instance=new A225452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225453
{
public static readonly long[] Value={ 7L,3L,3L,4L,8L,0L,8L,1L,7L,8L,6L,4L,7L,5L,1L,0L,2L,5L,1L,7L,1L,7L,2L,4L,0L,8L,1L,1L,4L,8L,7L,0L,6L,5L,3L,2L,1L,4L,0L,4L,2L,9L,6L,1L,0L,6L,8L,3L,5L,9L,2L,4L,1L,2L,9L,5L,4L,2L,9L,1L,6L,8L,4L,8L,7L,1L,6L,6L,5L,1L,2L,6L,7L,4L,6L,0L,9L,0L,5L,3L,8L,4L,4L,1L,4L,4L,1L,6L,6L,6L,5L,4L,2L,4L,9L,0L,0L,1L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225453Inst : IEnumerable<long>
{
public static readonly long[] Value=A225453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225453.Bytes);
public long this[int i]=>Value[i];

public static A225453Inst Instance=new A225453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225454
{
public static readonly long[] Value={ 3L,5L,8L,8L,4L,3L,5L,1L,8L,9L,4L,3L,0L,2L,8L,7L,3L,6L,5L,9L,9L,1L,4L,9L,8L,0L,3L,6L,0L,6L,7L,4L,8L,6L,5L,2L,4L,5L,6L,8L,0L,9L,2L,1L,6L,2L,9L,2L,0L,0L,6L,2L,4L,0L,4L,6L,1L,0L,9L,1L,1L,7L,0L,5L,5L,8L,6L,6L,1L,9L,4L,3L,9L,5L,6L,7L,3L,8L,7L,3L,7L,5L,5L,3L,4L,2L,5L,9L,3L,8L,2L,7L,7L,3L,9L,8L,7L,5L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225454Inst : IEnumerable<long>
{
public static readonly long[] Value=A225454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225454.Bytes);
public long this[int i]=>Value[i];

public static A225454Inst Instance=new A225454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225455
{
public static readonly long[] Value={ 1L,9L,3L,4L,8L,5L,1L,1L,9L,3L,5L,8L,6L,8L,7L,0L,8L,3L,8L,4L,5L,2L,6L,8L,7L,2L,8L,2L,5L,8L,9L,8L,2L,0L,5L,0L,8L,7L,4L,3L,6L,6L,9L,4L,4L,3L,6L,2L,2L,8L,0L,2L,2L,3L,7L,5L,2L,0L,5L,5L,6L,9L,2L,8L,2L,7L,1L,7L,1L,0L,8L,0L,6L,3L,0L,8L,8L,8L,6L,7L,6L,7L,5L,7L,4L,9L,8L,1L,5L,5L,2L,1L,7L,0L,3L,1L,6L,0L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225455Inst : IEnumerable<long>
{
public static readonly long[] Value=A225455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225455.Bytes);
public long this[int i]=>Value[i];

public static A225455Inst Instance=new A225455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225456
{
public static readonly long[] Value={ 3L,8L,4L,8L,6L,5L,6L,4L,6L,4L,5L,5L,2L,3L,6L,5L,5L,3L,6L,4L,9L,7L,9L,9L,7L,5L,6L,0L,7L,5L,8L,8L,9L,3L,7L,7L,1L,9L,0L,3L,1L,0L,8L,3L,6L,1L,4L,2L,7L,5L,6L,7L,3L,8L,7L,8L,8L,7L,3L,4L,2L,8L,0L,0L,8L,6L,6L,9L,6L,4L,9L,4L,5L,5L,5L,6L,7L,0L,6L,5L,1L,7L,3L,6L,4L,6L,3L,3L,4L,6L,3L,0L,9L,7L,7L,1L,6L,2L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225456Inst : IEnumerable<long>
{
public static readonly long[] Value=A225456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225456.Bytes);
public long this[int i]=>Value[i];

public static A225456Inst Instance=new A225456Inst();

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