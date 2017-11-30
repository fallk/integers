using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A245362
{
public static readonly long[] Value={ 51L,323L,341L,422L,591L,993L,998L,4227L,4265L,5129L,5534L,5921L,5937L,8049L,8657L,8801L,9953L,32133L,32282L,32471L,32597L,32817L,34091L,34379L,36611L,36863L,38937L,42011L,42243L,42605L,53211L,53673L,55745L,57167L,57903L,59543L,82151L,86354L,86781L,88217L,88433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245362Inst : IEnumerable<long>
{
public static readonly long[] Value=A245362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245362.Bytes);
public long this[int i]=>Value[i];

public static A245362Inst Instance=new A245362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245363
{
public static readonly long[] Value={ 19L,37L,49L,69L,73L,102L,165L,236L,253L,365L,465L,542L,595L,694L,713L,723L,762L,920L,962L,979L,1119L,1162L,1259L,1334L,1387L,1441L,1706L,1797L,1843L,1906L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245363Inst : IEnumerable<long>
{
public static readonly long[] Value=A245363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245363.Bytes);
public long this[int i]=>Value[i];

public static A245363Inst Instance=new A245363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245364
{
public static readonly long[] Value={ 111L,164L,195L,222L,265L,333L,444L,498L,555L,666L,777L,888L,999L,1111L,1664L,1995L,2222L,2665L,3333L,4444L,4847L,4998L,5555L,6545L,6666L,7424L,7777L,8888L,9999L,11111L,16664L,19995L,22222L,26665L,33333L,43243L,44444L,49998L,55555L,66666L,77777L,86486L,88888L,99999L,111111L,166664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245364Inst : IEnumerable<long>
{
public static readonly long[] Value=A245364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245364.Bytes);
public long this[int i]=>Value[i];

public static A245364Inst Instance=new A245364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245365
{
public static readonly long[] Value={ 22L,35L,51L,145L,247L,287L,1247L,1717L,2147L,2501L,3151L,4187L,5017L,7957L,11051L,13207L,15251L,16801L,17767L,20827L,26867L,33227L,49051L,63551L,68587L,71177L,76501L,81317L,96647L,112477L,118301L,128627L,147737L,159251L,182527L,232657L,237407L,241001L,250717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245365Inst : IEnumerable<long>
{
public static readonly long[] Value=A245365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245365.Bytes);
public long this[int i]=>Value[i];

public static A245365Inst Instance=new A245365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245366
{
public static readonly BigInteger[] Value={ 2L,3L,4L,9L,55L,1321L,570673L,40677571441L,BigInteger.Parse("30641887385179424641"),BigInteger.Parse("711307017047678652146384291462042881"),BigInteger.Parse("886599784992546696966754646294076268713472764725575212247451289601") };
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
public class A245366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245366Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245366.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245366.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245366Inst Instance=new A245366Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245367
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,1L,1L,2L,1L,3L,3L,3L,6L,5L,8L,10L,11L,17L,18L,25L,32L,37L,52L,61L,79L,102L,123L,163L,200L,254L,326L,402L,519L,649L,819L,1045L,1305L,1664L,2096L,2643L,3358L,4220L,5352L,6759L,8527L,10806L,13622L,17237L,21785L,27501L,34802L,43934L,55544L,70209L,88672L,112131L,141644L,179018L,226274L,285860L,361358L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245367Inst : IEnumerable<long>
{
public static readonly long[] Value=A245367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245367.Bytes);
public long this[int i]=>Value[i];

public static A245367Inst Instance=new A245367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245368
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,1L,3L,1L,1L,5L,5L,2L,7L,13L,8L,10L,25L,26L,20L,42L,64L,54L,72L,131L,144L,146L,245L,339L,344L,463L,715L,827L,953L,1423L,1881L,2124L,2839L,4019L,4832L,5916L,8281L,10732L,12872L,17036L,23032L,28436L,35824L,48349L,62200L,77132L,101209L,133581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245368Inst : IEnumerable<long>
{
public static readonly long[] Value=A245368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245368.Bytes);
public long this[int i]=>Value[i];

public static A245368Inst Instance=new A245368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245369
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,1L,0L,3L,1L,1L,5L,1L,5L,7L,2L,13L,9L,8L,25L,12L,26L,41L,22L,64L,62L,56L,130L,96L,146L,233L,174L,340L,391L,376L,703L,661L,862L,1327L,1211L,1905L,2379L,2449L,3935L,4251L,5216L,7641L,7911L,11056L,14271L,15576L,22632L,26433L,31848L,44544L,49920L,65536L,85248L,97344L,132712L,161601L,194728L,262504L,308865L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245369Inst : IEnumerable<long>
{
public static readonly long[] Value=A245369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245369.Bytes);
public long this[int i]=>Value[i];

public static A245369Inst Instance=new A245369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245370
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,1L,0L,2L,2L,1L,3L,3L,3L,6L,5L,6L,11L,10L,13L,19L,19L,27L,35L,37L,52L,65L,74L,100L,121L,145L,192L,230L,282L,365L,440L,548L,695L,843L,1058L,1327L,1621L,2035L,2535L,3119L,3910L,4851L,5997L,7503L,9297L,11528L,14389L,17829L,22150L,27596L,34208L,42536L,52928L,65655L,81660L,101525L,126020L,156738L,194776L,241888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245370Inst : IEnumerable<long>
{
public static readonly long[] Value=A245370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245370.Bytes);
public long this[int i]=>Value[i];

public static A245370Inst Instance=new A245370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245371
{
public static readonly long[] Value={ 16L,25L,36L,49L,64L,81L,100L,121L,144L,169L,289L,324L,361L,400L,441L,484L,529L,729L,784L,841L,900L,961L,1225L,1600L,1681L,1764L,1849L,1936L,2025L,2116L,2209L,2304L,2401L,2500L,2601L,2704L,2809L,2916L,3025L,3136L,3249L,3364L,3481L,3600L,4225L,4900L,5625L,6400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245371Inst : IEnumerable<long>
{
public static readonly long[] Value=A245371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245371.Bytes);
public long this[int i]=>Value[i];

public static A245371Inst Instance=new A245371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245372
{
public static readonly long[] Value={ 46L,76L,96L,106L,134L,142L,146L,204L,218L,276L,310L,408L,438L,466L,518L,534L,536L,546L,580L,624L,650L,672L,680L,694L,792L,800L,896L,970L,1000L,1016L,1100L,1160L,1170L,1318L,1344L,1358L,1364L,1384L,1470L,1480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245372Inst : IEnumerable<long>
{
public static readonly long[] Value=A245372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245372.Bytes);
public long this[int i]=>Value[i];

public static A245372Inst Instance=new A245372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245373
{
public static readonly BigInteger[] Value={ 1L,2L,6L,20L,80L,368L,1904L,10880L,67904L,459008L,3336704L,25925120L,214175744L,1873092608L,17276401664L,167504076800L,1702214549504L,18084149854208L,200388963958784L,2311212530401280L,27693720143396864L,344157474490155008L,4428851361694613504L,BigInteger.Parse("58933575269230837760") };
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
public class A245373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245373Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245373.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245373.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245373Inst Instance=new A245373Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245374
{
public static readonly BigInteger[] Value={ 1L,3L,12L,54L,288L,1782L,12474L,96714L,819882L,7536402L,74610234L,790692354L,8921660922L,106687646802L,1346863560714L,17890362862434L,249297686894682L,3634756665823602L,55317506662094634L,876911386062810114L,14451743847813157242UL,BigInteger.Parse("247171758180997987602"),BigInteger.Parse("4380263376360686471754") };
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
public class A245374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245374Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245374.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245374.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245374Inst Instance=new A245374Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245375
{
public static readonly BigInteger[] Value={ 1L,4L,20L,112L,736L,5632L,49024L,474112L,5017600L,57597952L,712597504L,9446981632L,133474877440L,2000265674752L,31666683510784L,527786775150592L,9233419259084800L,169106747636580352L,3234542505882025984L,BigInteger.Parse("64473076850860490752"),BigInteger.Parse("1336621867385969704960"),BigInteger.Parse("28769619371258703511552") };
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
public class A245375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245375Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245375.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245375.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245375Inst Instance=new A245375Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245376
{
public static readonly BigInteger[] Value={ 1L,5L,30L,200L,1550L,14000L,144500L,1662500L,20952500L,286437500L,4221312500L,66703437500L,1124194062500L,20109785937500L,380209901562500L,7571141773437500L,158312671414062500L,3466819503710937500L,BigInteger.Parse("79316483272226562500"),BigInteger.Parse("1891747084452148437500"),BigInteger.Parse("46942864023040039062500") };
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
public class A245376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245376Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245376.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245376.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245376Inst Instance=new A245376Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245377
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,4L,17L,80L,422L,2480L,16095L,114432L,884969L,7398464L,66502048L,639653632L,6556170841L,71340409600L,821408397105L,9977630263296L,127518757153174L,1710576547456000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245377Inst : IEnumerable<long>
{
public static readonly long[] Value=A245377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245377.Bytes);
public long this[int i]=>Value[i];

public static A245377Inst Instance=new A245377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245378
{
public static readonly long[] Value={ 1L,1L,3L,10L,39L,165L,743L,3507L,17199L,87126L,454159L,2430031L,13326623L,74856230L,430628069L,2538270783L,15343363603L,95233568052L,607850790015L,3996223189468L,27105153736781L,189947851239185L,1376864409041417L,10330672337146804L,80248762443834399L,645206035074873681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245378Inst : IEnumerable<long>
{
public static readonly long[] Value=A245378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245378.Bytes);
public long this[int i]=>Value[i];

public static A245378Inst Instance=new A245378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245379
{
public static readonly long[] Value={ 12L,18L,24L,36L,40L,56L,72L,80L,88L,96L,104L,108L,136L,152L,184L,225L,232L,248L,288L,296L,328L,344L,376L,384L,424L,441L,448L,472L,488L,536L,568L,584L,632L,640L,664L,712L,776L,808L,824L,856L,864L,872L,896L,904L,972L,1016L,1048L,1089L,1096L,1112L,1152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245379Inst : IEnumerable<long>
{
public static readonly long[] Value=A245379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245379.Bytes);
public long this[int i]=>Value[i];

public static A245379Inst Instance=new A245379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245380
{
public static readonly long[] Value={ 0L,1L,22L,153L,624L,1875L,4626L,9947L,19328L,34749L,58750L,94501L,145872L,217503L,314874L,444375L,613376L,830297L,1104678L,1447249L,1870000L,2386251L,3010722L,3759603L,4650624L,5703125L,6938126L,8378397L,10048528L,11974999L,14186250L,16712751L,19587072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245380Inst : IEnumerable<long>
{
public static readonly long[] Value=A245380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245380.Bytes);
public long this[int i]=>Value[i];

public static A245380Inst Instance=new A245380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245381
{
public static readonly long[] Value={ 19L,37L,73L,127L,271L,1153L,1531L,1571L,3511L,5113L,5171L,5711L,7151L,11161L,11251L,12511L,15121L,16111L,25111L,111119L,111191L,111317L,111731L,113117L,113131L,113171L,115151L,131113L,131171L,131311L,131711L,171131L,311711L,511151L,515111L,711131L,911111L,1111213L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245381Inst : IEnumerable<long>
{
public static readonly long[] Value=A245381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245381.Bytes);
public long this[int i]=>Value[i];

public static A245381Inst Instance=new A245381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245382
{
public static readonly long[] Value={ 19L,23L,37L,41L,53L,61L,73L,127L,137L,157L,173L,191L,251L,271L,313L,317L,331L,521L,571L,751L,911L,1123L,1153L,1213L,1217L,1231L,1321L,1531L,1571L,1721L,2113L,2131L,2311L,2711L,3121L,3511L,4111L,5113L,5171L,5711L,7121L,7151L,7211L,11119L,11161L,11173L,11177L,11213L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245382Inst : IEnumerable<long>
{
public static readonly long[] Value=A245382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245382.Bytes);
public long this[int i]=>Value[i];

public static A245382Inst Instance=new A245382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245383
{
public static readonly long[] Value={ 4L,6L,9L,14L,16L,19L,22L,23L,25L,27L,32L,33L,35L,37L,41L,52L,53L,55L,57L,61L,72L,73L,75L,77L,91L,114L,116L,119L,122L,123L,125L,127L,132L,133L,135L,137L,141L,152L,153L,155L,157L,161L,172L,173L,175L,177L,191L,212L,213L,215L,217L,221L,231L,251L,271L,312L,313L,315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245383Inst : IEnumerable<long>
{
public static readonly long[] Value=A245383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245383.Bytes);
public long this[int i]=>Value[i];

public static A245383Inst Instance=new A245383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245384
{
public static readonly BigInteger[] Value={ 1L,2L,3L,8L,54L,1320L,570672L,40677571440L,BigInteger.Parse("30641887385179424640"),BigInteger.Parse("711307017047678652146384291462042880"),BigInteger.Parse("886599784992546696966754646294076268713472764725575212247451289600") };
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
public class A245384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245384Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245384.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245384.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245384Inst Instance=new A245384Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245385
{
public static readonly long[] Value={ 111L,164L,195L,222L,265L,333L,444L,498L,555L,666L,777L,888L,999L,1111L,1664L,1995L,2222L,2665L,3333L,4444L,4847L,4998L,5555L,6545L,6666L,7424L,7777L,8888L,9999L,11111L,16664L,19995L,21775L,22222L,24996L,26665L,33333L,43243L,44444L,49998L,55555L,66666L,77777L,86486L,88888L,99999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245385Inst : IEnumerable<long>
{
public static readonly long[] Value=A245385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245385.Bytes);
public long this[int i]=>Value[i];

public static A245385Inst Instance=new A245385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245386
{
public static readonly long[] Value={ 164L,195L,265L,498L,1664L,1995L,2665L,4847L,4998L,6545L,7424L,16664L,19995L,21775L,24996L,26665L,43243L,49998L,86486L,148480L,166664L,175150L,199995L,217775L,249996L,266665L,368180L,484847L,499998L,654545L,742424L,1001001L,1081075L,1216216L,1249992L,1297290L,1451850L,1471468L,1481477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245386Inst : IEnumerable<long>
{
public static readonly long[] Value=A245386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245386.Bytes);
public long this[int i]=>Value[i];

public static A245386Inst Instance=new A245386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245387
{
public static readonly long[] Value={ 1L,5L,10L,20L,21L,43L,56L,78L,80L,100L,131L,160L,170L,215L,230L,300L,355L,485L,505L,540L,692L,824L,1000L,1055L,1165L,1335L,1340L,1429L,1453L,1505L,1739L,2102L,2309L,2740L,2936L,3772L,3972L,4055L,4489L,4676L,5080L,5512L,5600L,5660L,5700L,5770L,5796L,6350L,7173L,7512L,7790L,8372L,9380L,9767L,10000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245387Inst : IEnumerable<long>
{
public static readonly long[] Value=A245387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245387.Bytes);
public long this[int i]=>Value[i];

public static A245387Inst Instance=new A245387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245388
{
public static readonly long[] Value={ 1L,2L,3L,4L,8L,11L,24L,83L,85L,125L,152L,156L,175L,227L,297L,365L,443L,445L,533L,584L,600L,629L,847L,924L,965L,969L,1036L,1091L,1304L,1308L,1458L,1523L,1612L,1685L,1800L,1853L,1960L,2027L,2316L,2340L,2409L,2605L,2716L,2813L,3029L,3251L,3729L,3973L,4108L,4233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245388Inst : IEnumerable<long>
{
public static readonly long[] Value=A245388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245388.Bytes);
public long this[int i]=>Value[i];

public static A245388Inst Instance=new A245388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245389
{
public static readonly long[] Value={ 1L,2L,6L,23L,102L,496L,2570L,13959L,78682L,457243L,2727360L,16647048L,103759186L,659500772L,4271197824L,28175622291L,189321228022L,1296246842443L,9049626101836L,64481397834665L,469461395956168L,3497006117588399L,26688813841105524L,208977790442594368L,1680981707733908594L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245389Inst : IEnumerable<long>
{
public static readonly long[] Value=A245389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245389.Bytes);
public long this[int i]=>Value[i];

public static A245389Inst Instance=new A245389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245390
{
public static readonly long[] Value={ 1L,1L,3L,11L,39L,145L,514L,1901L,6741L,24880L,87791L,325634L,1152725L,4251234L,15052387L,55750323L,197031808L,729360141L,2579285955L,9539017676L,33822222227L,124889799518L,440743675148L,1635528366655L,5790967247863L,21360573026444L,75643815954959L,280096917425535L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245390Inst : IEnumerable<long>
{
public static readonly long[] Value=A245390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245390.Bytes);
public long this[int i]=>Value[i];

public static A245390Inst Instance=new A245390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245391
{
public static readonly long[] Value={ 1L,8L,60L,448L,3360L,25344L,192192L,1464320L,11202048L,85995520L,662165504L,5112102912L,39557939200L,306726174720L,2382605107200L,18537602088960L,144438816276480L,1126891074355200L,8802271391907840L,68829791335219200L,538749548542033920L,4220762508660572160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245391Inst : IEnumerable<long>
{
public static readonly long[] Value=A245391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245391.Bytes);
public long this[int i]=>Value[i];

public static A245391Inst Instance=new A245391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245392
{
public static readonly long[] Value={ 2L,4L,8L,16L,32L,56L,128L,224L,480L,856L,2048L,3200L,8192L,13656L,29920L,54752L,131072L,202104L,524288L,857952L,1939168L,3495256L,8388608L,12918016L,33013248L,55924056L,124631008L,222655840L,536870912L,809850488L,2147483648L,3579172320L,7974270688L,14316557656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245392Inst : IEnumerable<long>
{
public static readonly long[] Value=A245392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245392.Bytes);
public long this[int i]=>Value[i];

public static A245392Inst Instance=new A245392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245393
{
public static readonly BigInteger[] Value={ 683L,51828151L,57154490053L,128011456717L,39700406579747L,60867245726761L,135938684703251L,2681921038140191L,825977153711699903L,2411248431216834661L,BigInteger.Parse("38518333422551932951"),BigInteger.Parse("161352769633614478921"),BigInteger.Parse("4679818035765747188623"),BigInteger.Parse("10926823630072049689441"),BigInteger.Parse("13158906479414390795167") };
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
public class A245393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245393Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245393.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245393.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245393Inst Instance=new A245393Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245394
{
public static readonly long[] Value={ 0L,1L,3L,6L,7L,13L,20L,22L,23L,24L,25L,26L,27L,47L,49L,72L,73L,75L,77L,79L,81L,115L,117L,119L,121L,123L,125L,127L,129L,131L,133L,134L,189L,245L,253L,298L,341L,448L,454L,460L,525L,540L,546L,552L,558L,561L,734L,759L,769L,883L,892L,893L,903L,909L,915L,921L,927L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245394Inst : IEnumerable<long>
{
public static readonly long[] Value=A245394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245394.Bytes);
public long this[int i]=>Value[i];

public static A245394Inst Instance=new A245394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245395
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,7L,9L,11L,13L,15L,17L,19L,20L,22L,23L,25L,27L,29L,31L,33L,34L,36L,38L,40L,42L,44L,46L,48L,50L,52L,54L,55L,56L,60L,83L,106L,107L,111L,115L,148L,157L,161L,165L,169L,172L,173L,186L,192L,250L,256L,258L,264L,268L,272L,276L,280L,284L,287L,289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245395Inst : IEnumerable<long>
{
public static readonly long[] Value=A245395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245395.Bytes);
public long this[int i]=>Value[i];

public static A245395Inst Instance=new A245395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245396
{
public static readonly long[] Value={ 3L,5L,7L,11L,17L,19L,23L,23L,31L,37L,41L,47L,53L,53L,59L,67L,73L,73L,83L,83L,89L,89L,97L,107L,113L,113L,113L,113L,127L,131L,139L,151L,157L,157L,167L,173L,179L,181L,181L,193L,199L,199L,211L,211L,211L,223L,233L,241L,251L,251L,257L,263L,263L,277L,283L,283L,293L,293L,293L,307L,307L,317L,331L,337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245396Inst : IEnumerable<long>
{
public static readonly long[] Value=A245396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245396.Bytes);
public long this[int i]=>Value[i];

public static A245396Inst Instance=new A245396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245397
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,1L,1L,4L,10L,1L,1L,6L,27L,35L,1L,1L,10L,93L,256L,126L,1L,1L,18L,381L,2716L,3125L,462L,1L,1L,34L,1785L,36628L,127905L,46656L,1716L,1L,1L,66L,9237L,591460L,7120505L,8848236L,823543L,6435L,1L,1L,130L,51033L,11007556L,495872505L,2443835736L,844691407L,16777216L,24310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245397Inst : IEnumerable<long>
{
public static readonly long[] Value=A245397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245397.Bytes);
public long this[int i]=>Value[i];

public static A245397Inst Instance=new A245397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245398
{
public static readonly BigInteger[] Value={ 1L,1L,6L,381L,591460L,41262262505L,207874071367118436L,BigInteger.Parse("110807909819808911886548575"),BigInteger.Parse("8558639841332633529404511878004186120"),BigInteger.Parse("124773193097402414339622625011223384066643153613969"),BigInteger.Parse("431220070110830123225191271755402469908417673177630594034899052340") };
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
public class A245398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245398Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245398.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245398.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245398Inst Instance=new A245398Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245399
{
public static readonly long[] Value={ 6L,6L,6L,6L,6L,6L,12L,12L,12L,18L,18L,24L,30L,36L,42L,48L,60L,72L,84L,102L,126L,150L,180L,216L,258L,312L,372L,444L,534L,642L,768L,924L,1110L,1332L,1596L,1914L,2298L,2760L,3312L,3972L,4770L,5724L,6864L,8238L,9888L,11862L,14238L,17082L,20502L,24600L,29520L,35424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245399Inst : IEnumerable<long>
{
public static readonly long[] Value=A245399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245399.Bytes);
public long this[int i]=>Value[i];

public static A245399Inst Instance=new A245399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245400
{
public static readonly long[] Value={ 9L,9L,9L,9L,9L,9L,9L,9L,9L,18L,18L,18L,18L,27L,27L,27L,36L,36L,45L,45L,54L,63L,72L,81L,90L,99L,108L,126L,144L,162L,180L,198L,225L,252L,288L,324L,360L,405L,459L,513L,576L,648L,729L,819L,927L,1044L,1170L,1314L,1485L,1665L,1872L,2106L,2376L,2673L,3006L,3384L,3807L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245400Inst : IEnumerable<long>
{
public static readonly long[] Value=A245400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245400.Bytes);
public long this[int i]=>Value[i];

public static A245400Inst Instance=new A245400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245401
{
public static readonly long[] Value={ 8L,8L,8L,8L,8L,8L,8L,8L,16L,16L,16L,16L,24L,24L,32L,32L,40L,40L,48L,56L,64L,72L,80L,96L,112L,128L,144L,160L,184L,216L,240L,280L,320L,360L,416L,472L,544L,616L,704L,808L,920L,1056L,1208L,1376L,1576L,1800L,2056L,2352L,2688L,3072L,3512L,4008L,4584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245401Inst : IEnumerable<long>
{
public static readonly long[] Value=A245401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245401.Bytes);
public long this[int i]=>Value[i];

public static A245401Inst Instance=new A245401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245402
{
public static readonly long[] Value={ 7L,7L,7L,7L,7L,7L,7L,14L,14L,14L,21L,21L,28L,28L,35L,42L,49L,56L,63L,77L,91L,105L,119L,140L,161L,189L,224L,259L,301L,350L,413L,483L,560L,651L,763L,889L,1036L,1211L,1414L,1645L,1925L,2240L,2618L,3052L,3563L,4158L,4851L,5656L,6601L,7700L,8981L,10479L,12229L,14266L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245402Inst : IEnumerable<long>
{
public static readonly long[] Value=A245402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245402.Bytes);
public long this[int i]=>Value[i];

public static A245402Inst Instance=new A245402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245403
{
public static readonly long[] Value={ 10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,20L,20L,20L,20L,20L,30L,30L,30L,40L,40L,50L,50L,60L,60L,70L,80L,90L,100L,110L,120L,130L,150L,160L,180L,200L,220L,250L,280L,310L,340L,380L,420L,470L,520L,580L,640L,710L,790L,880L,980L,1090L,1210L,1340L,1490L,1660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245403Inst : IEnumerable<long>
{
public static readonly long[] Value=A245403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245403.Bytes);
public long this[int i]=>Value[i];

public static A245403Inst Instance=new A245403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245404
{
public static readonly long[] Value={ 7L,21L,70L,245L,861L,3010L,10535L,36876L,129066L,451731L,1581055L,5533696L,19367936L,67787776L,237257216L,830400256L,2906400896L,10172403136L,35603410976L,124611938416L,436141784456L,1526496245596L,5342736859586L,18699579008551L,65448526529925L,229069842854741L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245404Inst : IEnumerable<long>
{
public static readonly long[] Value=A245404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245404.Bytes);
public long this[int i]=>Value[i];

public static A245404Inst Instance=new A245404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245405
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,2L,1L,1L,2L,6L,1L,1L,2L,3L,24L,1L,1L,4L,9L,40L,120L,1L,1L,4L,24L,76L,205L,720L,1L,1L,4L,27L,208L,825L,2556L,5040L,1L,1L,4L,27L,252L,2325L,10206L,24409L,40320L,1L,1L,4L,27L,256L,3025L,31956L,143521L,347712L,362880L,1L,1L,4L,27L,256L,3120L,44406L,520723L,2313200L,4794633L,3628800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245405Inst : IEnumerable<long>
{
public static readonly long[] Value=A245405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245405.Bytes);
public long this[int i]=>Value[i];

public static A245405Inst Instance=new A245405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245406
{
public static readonly BigInteger[] Value={ 1L,1L,2L,9L,76L,825L,10206L,143521L,2313200L,42482313L,875799550L,19972186311L,498430219464L,13509979971241L,395352049852046L,12425644029361725L,417456939168255616L,14929305882415781265UL,BigInteger.Parse("566234625018001351230"),BigInteger.Parse("22701936510037394021395"),BigInteger.Parse("959341639105178919209000") };
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
public class A245406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245406Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245406.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245406.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245406Inst Instance=new A245406Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245407
{
public static readonly BigInteger[] Value={ 1L,1L,4L,24L,208L,2325L,31956L,520723L,9812160L,209843145L,5020469200L,132844628411L,3851705048016L,121428210575581L,4135403154270584L,151297710936948675L,5917989635505922816L,BigInteger.Parse("246444213949305536017"),BigInteger.Parse("10885732208011517726880"),BigInteger.Parse("508350675616737391265563") };
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
public class A245407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245407Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245407.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245407.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245407Inst Instance=new A245407Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245408
{
public static readonly BigInteger[] Value={ 1L,1L,4L,27L,252L,3025L,44406L,770623L,15434616L,350420337L,8893045900L,249474767861L,7665670072116L,256045368531433L,9237038259841770L,357934480164387225L,14827066792663179616UL,BigInteger.Parse("653843231295154192017"),BigInteger.Parse("30581468519362170893784"),BigInteger.Parse("1512123060477719223218791") };
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
public class A245408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245408Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245408.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245408.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245408Inst Instance=new A245408Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245409
{
public static readonly BigInteger[] Value={ 1L,1L,4L,27L,256L,3120L,46476L,818251L,16623552L,382775625L,9851207860L,280231042751L,8731004146272L,295688565207373L,10815259910601524L,424893916814719815L,17844053214957081856UL,BigInteger.Parse("797744088027002799121"),BigInteger.Parse("37826128915102284480144"),BigInteger.Parse("1896083271482048297688979") };
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
public class A245409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245409Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245409.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245409.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245409Inst Instance=new A245409Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245410
{
public static readonly BigInteger[] Value={ 1L,1L,4L,27L,256L,3125L,46650L,823249L,16766240L,387033417L,9986221900L,284803470611L,8896457440872L,302075780925685L,11077712976422470L,436342859278138275L,18372866764869817216UL,BigInteger.Parse("823539597176786793105"),BigInteger.Parse("39151767720093507173304"),BigInteger.Parse("1967688517596911564272795") };
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
public class A245410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245410Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245410.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245410.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245410Inst Instance=new A245410Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245411
{
public static readonly BigInteger[] Value={ 1L,1L,4L,27L,256L,3125L,46656L,823536L,16776768L,387399753L,9999125200L,285275370611L,8914569819552L,302808495261181L,11108991885125512L,437751439912499175L,18439707410896028416UL,BigInteger.Parse("826876746821203814161"),BigInteger.Parse("39326776141693679404128"),BigInteger.Parse("1977312147376328609765419") };
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
public class A245411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245411Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245411.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245411.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245411Inst Instance=new A245411Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245412
{
public static readonly BigInteger[] Value={ 1L,1L,4L,27L,256L,3125L,46656L,823543L,16777208L,387419841L,9999963550L,285309855611L,8916013480716L,302870943384061L,11111803896854038L,437883715342385775L,18446216323273596016UL,BigInteger.Parse("827211862188632409057"),BigInteger.Parse("39344820189873938423748"),BigInteger.Parse("1978327362506349226513213") };
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
public class A245412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245412Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245412.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245412.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245412Inst Instance=new A245412Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245413
{
public static readonly BigInteger[] Value={ 1L,1L,4L,27L,256L,3125L,46656L,823543L,16777216L,387420480L,9999999100L,285311610111L,8916096934416L,302874913851133L,11111996418957812L,437893325100944175L,18446712799609551616UL,BigInteger.Parse("827238486905202346257"),BigInteger.Parse("39346304291930549899764"),BigInteger.Parse("1978413388840508514186871") };
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
public class A245413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245413Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245413.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245413.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245413Inst Instance=new A245413Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245414
{
public static readonly BigInteger[] Value={ 1L,1L,4L,27L,256L,3125L,46656L,823543L,16777216L,387420489L,9999999990L,285311669401L,8916100352424L,302875100167549L,11112006425304162L,437893866154577295L,18446742614251551616UL,BigInteger.Parse("827240173137280043281"),BigInteger.Parse("39346402580883043716420"),BigInteger.Parse("1978419307503657602437003") };
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
public class A245414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245414Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245414.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245414.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245414Inst Instance=new A245414Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245415
{
public static readonly long[] Value={ 5L,10L,25L,60L,150L,375L,940L,2350L,5875L,14685L,36715L,91785L,229465L,573660L,1434150L,3585375L,8963440L,22408600L,56021500L,140053750L,350134375L,875335935L,2188339840L,5470849600L,13677124000L,34192810000L,85482025000L,213705062500L,534262656250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245415Inst : IEnumerable<long>
{
public static readonly long[] Value=A245415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245415.Bytes);
public long this[int i]=>Value[i];

public static A245415Inst Instance=new A245415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245416
{
public static readonly long[] Value={ 9L,36L,162L,729L,3276L,14742L,66339L,298530L,1343385L,6045228L,27203526L,122415867L,550871406L,2478921327L,11155145967L,50198156856L,225891705852L,1016512676334L,4574307043503L,20584381695759L,92629717630920L,416833729339140L,1875751782026130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245416Inst : IEnumerable<long>
{
public static readonly long[] Value=A245416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245416.Bytes);
public long this[int i]=>Value[i];

public static A245416Inst Instance=new A245416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245417
{
public static readonly long[] Value={ 7L,14L,28L,70L,161L,378L,882L,2058L,4802L,11200L,26138L,60984L,142296L,332024L,774725L,1807694L,4217948L,9841881L,22964389L,53583572L,125028337L,291732784L,680709834L,1588322946L,3706086874L,8647536037L,20177584084L,47081029534L,109855735577L,256330049682L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245417Inst : IEnumerable<long>
{
public static readonly long[] Value=A245417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245417.Bytes);
public long this[int i]=>Value[i];

public static A245417Inst Instance=new A245417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245418
{
public static readonly long[] Value={ 5L,5L,10L,15L,25L,40L,70L,115L,190L,320L,530L,885L,1475L,2460L,4100L,6830L,11385L,18975L,31625L,52710L,87850L,146415L,244025L,406710L,677850L,1129750L,1882915L,3138190L,5230320L,8717200L,14528665L,24214440L,40357400L,67262335L,112103890L,186839820L,311399700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245418Inst : IEnumerable<long>
{
public static readonly long[] Value=A245418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245418.Bytes);
public long this[int i]=>Value[i];

public static A245418Inst Instance=new A245418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245419
{
public static readonly long[] Value={ 8L,16L,40L,112L,296L,792L,2112L,5632L,15016L,40040L,106776L,284736L,759296L,2024792L,5399440L,14398512L,38396032L,102389416L,273038440L,728102512L,1941606696L,5177617856L,13806980952L,36818615872L,98182975656L,261821268416L,698190049112L,1861840130960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245419Inst : IEnumerable<long>
{
public static readonly long[] Value=A245419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245419.Bytes);
public long this[int i]=>Value[i];

public static A245419Inst Instance=new A245419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245420
{
public static readonly long[] Value={ 8L,8L,16L,24L,40L,64L,96L,160L,256L,408L,648L,1040L,1664L,2664L,4264L,6816L,10912L,17456L,27928L,44688L,71496L,114400L,183040L,292864L,468576L,749728L,1199560L,1919296L,3070872L,4913400L,7861440L,12578304L,20125288L,32200456L,51520728L,82433168L,131893072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245420Inst : IEnumerable<long>
{
public static readonly long[] Value=A245420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245420.Bytes);
public long this[int i]=>Value[i];

public static A245420Inst Instance=new A245420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245421
{
public static readonly long[] Value={ 1L,2L,2L,2L,1L,-1L,-2L,-3L,-2L,1L,4L,6L,5L,1L,-5L,-11L,-12L,-7L,3L,15L,22L,19L,5L,-15L,-32L,-36L,-22L,8L,40L,58L,50L,12L,-41L,-84L,-93L,-54L,22L,103L,148L,124L,32L,-96L,-200L,-219L,-128L,46L,231L,330L,275L,67L,-216L,-439L,-477L,-275L,107L,501L,708L,590L,146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245421Inst : IEnumerable<long>
{
public static readonly long[] Value=A245421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245421.Bytes);
public long this[int i]=>Value[i];

public static A245421Inst Instance=new A245421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245422
{
public static readonly long[] Value={ 1L,4L,5L,7L,2L,7L,0L,8L,7L,9L,2L,7L,3L,6L,5L,3L,8L,5L,3L,6L,9L,4L,4L,5L,4L,0L,6L,8L,1L,2L,0L,0L,4L,7L,0L,5L,9L,6L,6L,0L,5L,3L,0L,0L,2L,0L,2L,3L,5L,2L,2L,4L,6L,5L,9L,2L,1L,3L,2L,9L,7L,0L,8L,0L,7L,3L,9L,7L,9L,8L,3L,7L,3L,9L,7L,3L,2L,2L,0L,0L,0L,1L,8L,2L,0L,5L,8L,7L,9L,5L,8L,3L,0L,9L,6L,8L,4L,0L,3L,4L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245422Inst : IEnumerable<long>
{
public static readonly long[] Value=A245422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245422.Bytes);
public long this[int i]=>Value[i];

public static A245422Inst Instance=new A245422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245423
{
public static readonly long[] Value={ 7L,7L,7L,14L,14L,21L,28L,42L,56L,84L,112L,161L,224L,315L,441L,616L,861L,1204L,1687L,2366L,3311L,4634L,6489L,9086L,12719L,17808L,24927L,34902L,48860L,68404L,95767L,134071L,187698L,262780L,367892L,515046L,721070L,1009498L,1413293L,1978613L,2770054L,3878077L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245423Inst : IEnumerable<long>
{
public static readonly long[] Value=A245423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245423.Bytes);
public long this[int i]=>Value[i];

public static A245423Inst Instance=new A245423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245424
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,-1L,-2L,-3L,-2L,1L,4L,6L,5L,1L,-5L,-11L,-12L,-7L,3L,15L,22L,19L,5L,-15L,-32L,-36L,-22L,8L,40L,58L,50L,12L,-41L,-84L,-93L,-54L,22L,103L,148L,124L,32L,-96L,-200L,-219L,-128L,46L,231L,330L,275L,67L,-216L,-439L,-477L,-275L,107L,501L,708L,590L,146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245424Inst : IEnumerable<long>
{
public static readonly long[] Value=A245424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245424.Bytes);
public long this[int i]=>Value[i];

public static A245424Inst Instance=new A245424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245425
{
public static readonly long[] Value={ 9L,18L,36L,81L,180L,405L,918L,2061L,4635L,10431L,23472L,52812L,118827L,267363L,601560L,1353510L,3045402L,6852150L,15417342L,34689015L,78050286L,175613148L,395129583L,889041555L,2000343501L,4500772875L,10126738971L,22785162687L,51266616048L,115349886108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245425Inst : IEnumerable<long>
{
public static readonly long[] Value=A245425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245425.Bytes);
public long this[int i]=>Value[i];

public static A245425Inst Instance=new A245425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245426
{
public static readonly long[] Value={ 7L,7L,14L,21L,42L,70L,126L,217L,378L,665L,1162L,2037L,3563L,6237L,10913L,19096L,33418L,58485L,102347L,179109L,313439L,548520L,959910L,1679839L,2939720L,5144510L,9002889L,15755061L,27571355L,48249873L,84437276L,147765233L,258589156L,452531023L,791929292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245426Inst : IEnumerable<long>
{
public static readonly long[] Value=A245426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245426.Bytes);
public long this[int i]=>Value[i];

public static A245426Inst Instance=new A245426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245427
{
public static readonly long[] Value={ 43L,547L,909091L,1623931L,7027567L,10678711L,15790321L,22796593L,32222107L,81867661L,183458857L,234750601L,574995877L,2498207293L,6177695707L,7095062437L,9272716111L,13564461457L,19397579293L,24344094727L,50689400581L,81420308971L,137405657593L,149289169177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245427Inst : IEnumerable<long>
{
public static readonly long[] Value=A245427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245427.Bytes);
public long this[int i]=>Value[i];

public static A245427Inst Instance=new A245427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245428
{
public static readonly long[] Value={ 10L,30L,100L,330L,1100L,3670L,12230L,40770L,135900L,453000L,1510000L,5033330L,16777770L,55925900L,186419660L,621398870L,2071329570L,6904431900L,23014773000L,76715910000L,255719700000L,852399000000L,2841330000000L,9471100000000L,31570333333330L,105234444444430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245428Inst : IEnumerable<long>
{
public static readonly long[] Value=A245428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245428.Bytes);
public long this[int i]=>Value[i];

public static A245428Inst Instance=new A245428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245429
{
public static readonly long[] Value={ 9L,9L,9L,9L,18L,18L,27L,36L,45L,54L,72L,90L,117L,153L,198L,252L,324L,414L,531L,684L,882L,1134L,1458L,1872L,2412L,3096L,3978L,5121L,6579L,8460L,10881L,13986L,17982L,23121L,29727L,38223L,49140L,63180L,81234L,104445L,134280L,172647L,221976L,285399L,366939L,471780L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245429Inst : IEnumerable<long>
{
public static readonly long[] Value=A245429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245429.Bytes);
public long this[int i]=>Value[i];

public static A245429Inst Instance=new A245429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245430
{
public static readonly long[] Value={ 9L,9L,18L,36L,63L,108L,198L,360L,648L,1161L,2088L,3762L,6768L,12186L,21933L,39483L,71064L,127917L,230256L,414459L,746028L,1342845L,2417121L,4350816L,7831476L,14096655L,25373979L,45673164L,82211688L,147981042L,266365872L,479458575L,863025435L,1553445783L,2796202404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245430Inst : IEnumerable<long>
{
public static readonly long[] Value=A245430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245430.Bytes);
public long this[int i]=>Value[i];

public static A245430Inst Instance=new A245430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245431
{
public static readonly long[] Value={ 10L,10L,10L,20L,30L,40L,60L,80L,120L,170L,240L,340L,490L,700L,1000L,1430L,2040L,2910L,4160L,5940L,8490L,12130L,17330L,24750L,35360L,50520L,72170L,103100L,147280L,210400L,300570L,429390L,613410L,876300L,1251860L,1788370L,2554820L,3649740L,5213910L,7448450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245431Inst : IEnumerable<long>
{
public static readonly long[] Value=A245431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245431.Bytes);
public long this[int i]=>Value[i];

public static A245431Inst Instance=new A245431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245432
{
public static readonly long[] Value={ 1L,1L,-1L,-2L,3L,4L,-6L,-8L,11L,15L,-20L,-26L,34L,44L,-56L,-72L,91L,114L,-143L,-178L,220L,272L,-334L,-408L,498L,605L,-732L,-884L,1064L,1276L,-1528L,-1824L,2171L,2580L,-3058L,-3616L,4269L,5028L,-5910L,-6936L,8124L,9498L,-11088L,-12922L,15034L,17468L,-20264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245432Inst : IEnumerable<long>
{
public static readonly long[] Value=A245432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245432.Bytes);
public long this[int i]=>Value[i];

public static A245432Inst Instance=new A245432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245433
{
public static readonly long[] Value={ 1L,1L,0L,-1L,1L,1L,-2L,-2L,3L,4L,-4L,-5L,5L,6L,-8L,-9L,12L,13L,-14L,-17L,18L,21L,-26L,-28L,34L,39L,-42L,-49L,53L,60L,-70L,-78L,90L,101L,-110L,-125L,137L,153L,-174L,-192L,217L,241L,-264L,-295L,322L,357L,-400L,-438L,490L,540L,-588L,-652L,711L,781L,-866L,-946L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245433Inst : IEnumerable<long>
{
public static readonly long[] Value=A245433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245433.Bytes);
public long this[int i]=>Value[i];

public static A245433Inst Instance=new A245433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245434
{
public static readonly long[] Value={ 1L,3L,1L,-4L,0L,9L,-1L,-20L,1L,38L,1L,-64L,-2L,107L,-2L,-180L,3L,292L,4L,-452L,-4L,686L,-5L,-1044L,5L,1563L,6L,-2276L,-8L,3284L,-9L,-4724L,12L,6712L,13L,-9408L,-14L,13086L,-17L,-18112L,18L,24879L,21L,-33864L,-26L,45806L,-28L,-61696L,34L,82614L,39L,-109892L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245434Inst : IEnumerable<long>
{
public static readonly long[] Value=A245434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245434.Bytes);
public long this[int i]=>Value[i];

public static A245434Inst Instance=new A245434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245435
{
public static readonly long[] Value={ -36L,-288L,-36L,0L,-972L,-288L,0L,-2304L,-36L,-500L,-33750L,-7776L,-2304L,0L,-12348L,-36L,-288L,-4500L,-18432L,-108L,-4096L,-26244L,-7776L,-972L,-5000L,-47916L,-1372L,-36L,-36L,-972L,-79092L,-1728L,-26244L,500L,-98784L,-4500L,-43904L,-36000L,-16875L,-2304L,-8000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245435Inst : IEnumerable<long>
{
public static readonly long[] Value=A245435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245435.Bytes);
public long this[int i]=>Value[i];

public static A245435Inst Instance=new A245435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245436
{
public static readonly long[] Value={ 1L,2L,3L,2L,1L,-2L,-4L,-4L,0L,6L,9L,8L,-1L,-12L,-20L,-16L,1L,22L,38L,30L,1L,-40L,-64L,-52L,-2L,68L,107L,88L,-2L,-112L,-180L,-144L,3L,182L,292L,228L,4L,-286L,-452L,-356L,-4L,440L,686L,544L,-5L,-668L,-1044L,-816L,5L,996L,1563L,1210L,6L,-1464L,-2276L,-1768L,-8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245436Inst : IEnumerable<long>
{
public static readonly long[] Value=A245436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245436.Bytes);
public long this[int i]=>Value[i];

public static A245436Inst Instance=new A245436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245437
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,2L,3L,6L,10L,17L,29L,50L,86L,147L,252L,432L,741L,1270L,2177L,3732L,6398L,10968L,18802L,32232L,55255L,94723L,162382L,278369L,477204L,818064L,1402395L,2404105L,4121322L,7065122L,12111635L,20762798L,35593360L,61017175L,104600848L,179315699L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245437Inst : IEnumerable<long>
{
public static readonly long[] Value=A245437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245437.Bytes);
public long this[int i]=>Value[i];

public static A245437Inst Instance=new A245437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245438
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,5L,6L,8L,17L,53L,158L,450L,1224L,3195L,8036L,19585L,46549L,108541L,219677L,664149L,1891075L,5091680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245438Inst : IEnumerable<long>
{
public static readonly long[] Value=A245438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245438.Bytes);
public long this[int i]=>Value[i];

public static A245438Inst Instance=new A245438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245439
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,5L,6L,8L,26L,81L,243L,693L,1887L,4932L,12418L,30288L,72026L,167989L,541500L,1635975L,4662579L,12580587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245439Inst : IEnumerable<long>
{
public static readonly long[] Value=A245439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245439.Bytes);
public long this[int i]=>Value[i];

public static A245439Inst Instance=new A245439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245440
{
public static readonly long[] Value={ 353L,373L,449L,461L,521L,541L,593L,653L,673L,757L,769L,797L,821L,829L,941L,953L,1009L,1021L,1061L,1069L,1097L,1193L,1217L,1237L,1249L,1277L,1361L,1381L,1481L,1489L,1549L,1597L,1613L,1621L,1657L,1669L,1693L,1709L,1721L,1733L,1777L,1801L,1877L,1889L,1933L,1949L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245440Inst : IEnumerable<long>
{
public static readonly long[] Value=A245440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245440.Bytes);
public long this[int i]=>Value[i];

public static A245440Inst Instance=new A245440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245441
{
public static readonly long[] Value={ 3L,3L,3L,3L,7L,17L,13L,27L,25L,15L,25L,23L,21L,15L,9L,17L,15L,21L,51L,35L,19L,33L,25L,39L,57L,57L,81L,45L,45L,213L,111L,57L,31L,131L,99L,83L,45L,27L,25L,107L,55L,33L,33L,35L,67L,141L,91L,89L,69L,41L,129L,89L,147L,101L,195L,129L,79L,77L,45L,77L,69L,53L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245441Inst : IEnumerable<long>
{
public static readonly long[] Value=A245441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245441.Bytes);
public long this[int i]=>Value[i];

public static A245441Inst Instance=new A245441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245442
{
public static readonly long[] Value={ 3L,5L,127L,139L,347L,661L,2203L,6521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245442Inst : IEnumerable<long>
{
public static readonly long[] Value=A245442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245442.Bytes);
public long this[int i]=>Value[i];

public static A245442Inst Instance=new A245442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245443
{
public static readonly long[] Value={ 0L,1L,2L,3L,7L,6L,4L,5L,10L,11L,9L,8L,15L,14L,12L,13L,27L,26L,24L,25L,30L,31L,29L,28L,20L,21L,23L,22L,17L,16L,18L,19L,38L,39L,37L,36L,35L,34L,32L,33L,41L,40L,42L,43L,44L,45L,47L,46L,55L,54L,52L,53L,50L,51L,49L,48L,56L,57L,59L,58L,61L,60L,62L,63L,127L,126L,124L,125L,122L,123L,121L,120L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245443Inst : IEnumerable<long>
{
public static readonly long[] Value=A245443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245443.Bytes);
public long this[int i]=>Value[i];

public static A245443Inst Instance=new A245443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245444
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,7L,5L,4L,11L,10L,8L,9L,14L,15L,13L,12L,29L,28L,30L,31L,24L,25L,27L,26L,18L,19L,17L,16L,23L,22L,20L,21L,38L,39L,37L,36L,35L,34L,32L,33L,41L,40L,42L,43L,44L,45L,47L,46L,55L,54L,52L,53L,50L,51L,49L,48L,56L,57L,59L,58L,61L,60L,62L,63L,106L,107L,105L,104L,111L,110L,108L,109L,101L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245444Inst : IEnumerable<long>
{
public static readonly long[] Value=A245444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245444.Bytes);
public long this[int i]=>Value[i];

public static A245444Inst Instance=new A245444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245445
{
public static readonly long[] Value={ 0L,1L,3L,2L,5L,6L,4L,7L,15L,8L,12L,11L,10L,13L,9L,14L,17L,30L,22L,25L,26L,21L,29L,18L,16L,31L,23L,24L,27L,20L,28L,19L,51L,44L,60L,35L,36L,59L,43L,52L,48L,47L,63L,32L,39L,56L,40L,55L,46L,49L,33L,62L,57L,38L,54L,41L,45L,50L,34L,61L,58L,37L,53L,42L,85L,106L,74L,117L,122L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245445Inst : IEnumerable<long>
{
public static readonly long[] Value=A245445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245445.Bytes);
public long this[int i]=>Value[i];

public static A245445Inst Instance=new A245445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245446
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,4L,5L,7L,9L,14L,12L,11L,10L,13L,15L,8L,24L,16L,23L,31L,29L,21L,18L,26L,27L,19L,20L,28L,30L,22L,17L,25L,43L,50L,58L,35L,36L,61L,53L,44L,46L,55L,63L,38L,33L,56L,48L,41L,40L,49L,57L,32L,39L,62L,54L,47L,45L,52L,60L,37L,34L,59L,51L,42L,126L,84L,77L,103L,111L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245446Inst : IEnumerable<long>
{
public static readonly long[] Value=A245446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245446.Bytes);
public long this[int i]=>Value[i];

public static A245446Inst Instance=new A245446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245447
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,14L,8L,17L,9L,7L,6L,15L,13L,10L,38L,22L,11L,35L,23L,122L,50L,32L,18L,86L,25L,26L,138L,74L,41L,30L,12L,101L,33L,16L,43L,64L,28L,39L,24L,81L,20L,45L,68L,31L,176L,59L,63L,171L,34L,62L,203L,72L,53L,239L,44L,76L,47L,27L,19L,125L,29L,149L,218L,277L,158L,182L,113L,71L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245447Inst : IEnumerable<long>
{
public static readonly long[] Value=A245447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245447.Bytes);
public long this[int i]=>Value[i];

public static A245447Inst Instance=new A245447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245448
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,11L,10L,7L,9L,14L,17L,31L,13L,6L,12L,34L,8L,23L,59L,41L,71L,16L,19L,39L,25L,26L,58L,37L,61L,30L,44L,22L,33L,49L,18L,85L,86L,15L,38L,69L,29L,151L,35L,55L,42L,107L,57L,97L,106L,21L,191L,122L,53L,111L,134L,74L,145L,109L,46L,82L,89L,50L,47L,36L,157L,133L,121L,43L,92L,110L,68L,52L,131L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245448Inst : IEnumerable<long>
{
public static readonly long[] Value=A245448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245448.Bytes);
public long this[int i]=>Value[i];

public static A245448Inst Instance=new A245448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245449
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,9L,13L,25L,26L,30L,33L,53L,93L,1023L,1034L,1203L,1330L,2657L,8584L,17159L,779212L,970225L,1558409L,8550146L,240902643L,244608573L,325422273L,414690595L,570131490L,1020233393L,1864797542L,2438037206L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245449Inst : IEnumerable<long>
{
public static readonly long[] Value=A245449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245449.Bytes);
public long this[int i]=>Value[i];

public static A245449Inst Instance=new A245449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245450
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,13L,8L,9L,10L,19L,12L,7L,14L,15L,16L,53L,18L,11L,20L,21L,22L,23L,24L,25L,26L,27L,33L,41L,30L,113L,32L,28L,34L,35L,36L,47L,39L,38L,92L,29L,54L,163L,85L,45L,462L,37L,60L,49L,70L,51L,94L,17L,42L,55L,74L,57L,156L,193L,48L,101L,62L,115L,64L,259L,77L,73L,132L,69L,50L,181L,102L,67L,56L,169L,76L,66L,78L,137L,87L,180L,398L,139L,84L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245450Inst : IEnumerable<long>
{
public static readonly long[] Value=A245450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245450.Bytes);
public long this[int i]=>Value[i];

public static A245450Inst Instance=new A245450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245451
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,9L,16L,6L,5L,27L,32L,18L,64L,81L,25L,12L,128L,7L,256L,54L,125L,243L,512L,36L,10L,729L,15L,162L,1024L,49L,2048L,24L,625L,2187L,50L,14L,4096L,6561L,3125L,108L,8192L,343L,16384L,486L,75L,19683L,32768L,72L,20L,21L,15625L,1458L,65536L,35L,250L,324L,78125L,59049L,131072L,98L,262144L,177147L,375L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245451Inst : IEnumerable<long>
{
public static readonly long[] Value=A245451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245451.Bytes);
public long this[int i]=>Value[i];

public static A245451Inst Instance=new A245451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245452
{
public static readonly long[] Value={ 1L,2L,4L,3L,9L,8L,18L,5L,6L,25L,75L,16L,150L,36L,27L,7L,735L,12L,1470L,49L,50L,245L,12705L,32L,15L,300L,10L,72L,25410L,125L,195195L,11L,225L,4235L,54L,24L,390390L,2940L,490L,121L,4339335L,100L,8678670L,847L,81L,65065L,92147055L,64L,30L,35L,2205L,600L,184294110L,20L,147L,144L,8470L,50820L,2565568005L,343L,5131136010L,1446445L,98L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245452Inst : IEnumerable<long>
{
public static readonly long[] Value=A245452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245452.Bytes);
public long this[int i]=>Value[i];

public static A245452Inst Instance=new A245452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245453
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,19L,6L,7L,8L,9L,38L,13L,12L,11L,14L,57L,16L,59L,18L,5L,76L,21L,26L,53L,24L,361L,22L,27L,28L,109L,114L,31L,32L,39L,118L,133L,36L,41L,10L,33L,152L,37L,42L,103L,52L,171L,106L,61L,48L,49L,722L,177L,44L,23L,54L,247L,56L,15L,218L,17L,228L,47L,62L,63L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245453Inst : IEnumerable<long>
{
public static readonly long[] Value=A245453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245453.Bytes);
public long this[int i]=>Value[i];

public static A245453Inst Instance=new A245453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245454
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,5L,18L,8L,9L,25L,11L,16L,64L,14L,27L,12L,96L,7L,288L,21L,20L,243L,891L,45L,10L,405L,15L,162L,33750L,30L,78650L,75L,625L,2025L,35L,81L,390390L,224L,875L,250L,41L,375L,16384L,270L,24L,300125L,24576L,150L,125L,54L,6125L,1350L,73728L,50L,108L,350L,594L,140777L,5845851L,98L,221433750L,1446445L,343L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245454Inst : IEnumerable<long>
{
public static readonly long[] Value=A245454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245454.Bytes);
public long this[int i]=>Value[i];

public static A245454Inst Instance=new A245454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245455
{
public static readonly long[] Value={ 1L,3L,4L,9L,23L,61L,166L,459L,1284L,3623L,10292L,29395L,84327L,242807L,701314L,2031085L,5895951L,17150013L,49975428L,145862571L,426337773L,1247741271L,3655973226L,10723668081L,31485145902L,92524150845L,272120203908L,800931753629L,2359038637409L,6952768502473L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245455Inst : IEnumerable<long>
{
public static readonly long[] Value=A245455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245455.Bytes);
public long this[int i]=>Value[i];

public static A245455Inst Instance=new A245455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245456
{
public static readonly long[] Value={ 0L,1L,3L,4L,192L,5L,81L,76L,6L,32L,15L,22L,216L,7L,111L,130L,168L,37L,27L,112L,60L,8L,117L,64L,198L,25L,99L,136L,204L,29L,105L,88L,174L,13L,9L,70L,222L,43L,93L,172L,30L,41L,63L,124L,12L,55L,21L,154L,186L,49L,75L,148L,36L,67L,129L,10L,162L,23L,87L,118L,180L,61L,57L,166L,72L,20L,141L,94L,24L,31L,45L,142L,54L,47L,51L,100L,48L,14L,33L,58L,210L,19L,123L,106L,18L,80L,39L,16L,66L,11L,135L,82L,156L,26L,69L,160L,42L,17L,147L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245456Inst : IEnumerable<long>
{
public static readonly long[] Value=A245456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245456.Bytes);
public long this[int i]=>Value[i];

public static A245456Inst Instance=new A245456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245457
{
public static readonly BigInteger[] Value={ 1L,4L,26L,92L,2102L,23102L,60062L,510512L,29099072L,3792578792L,84106011992L,2005604901302L,252305096583542L,11561510014033982L,52331045326680122L,BigInteger.Parse("31359378912013061912"),BigInteger.Parse("1792403716245452460152"),BigInteger.Parse("98060777857864844592572"),BigInteger.Parse("3401363059422802158514832") };
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
public class A245457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245457Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245457.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245457.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245457Inst Instance=new A245457Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245458
{
public static readonly BigInteger[] Value={ 1L,3L,8L,122L,212L,6932L,450452L,9189182L,193993802L,2677114442L,116454478142L,5415133233512L,51945166943672L,1521251317636052L,562558737261811292L,1229779565176982822L,BigInteger.Parse("130356633908760178922"),BigInteger.Parse("19227603501542126390702"),BigInteger.Parse("4456958491657464897364262") };
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
public class A245458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245458Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245458.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245458.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245458Inst Instance=new A245458Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245459
{
public static readonly long[] Value={ 0L,0L,1L,4L,3L,2L,3L,5L,1L,4L,2L,4L,0L,6L,2L,2L,1L,2L,3L,5L,1L,9L,1L,4L,2L,3L,1L,2L,2L,2L,1L,4L,1L,5L,1L,2L,3L,3L,1L,2L,2L,1L,0L,3L,0L,1L,1L,2L,1L,4L,0L,1L,0L,3L,0L,3L,0L,2L,1L,4L,5L,3L,0L,3L,5L,9L,1L,5L,1L,6L,1L,0L,1L,4L,1L,1L,0L,4L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245459Inst : IEnumerable<long>
{
public static readonly long[] Value=A245459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245459.Bytes);
public long this[int i]=>Value[i];

public static A245459Inst Instance=new A245459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245460
{
public static readonly BigInteger[] Value={ 1L,4L,26L,122L,2102L,23102L,450452L,9189182L,193993802L,3792578792L,116454478142L,5415133233512L,252305096583542L,11561510014033982L,562558737261811292L,BigInteger.Parse("31359378912013061912"),BigInteger.Parse("1792403716245452460152"),BigInteger.Parse("98060777857864844592572"),BigInteger.Parse("4456958491657464897364262") };
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
public class A245460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245460Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245460.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245460.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245460Inst Instance=new A245460Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245461
{
public static readonly long[] Value={ 1L,2L,1L,9L,6L,6L,9L,8L,9L,1L,2L,6L,6L,5L,0L,4L,4L,5L,4L,9L,2L,6L,5L,3L,8L,8L,4L,7L,4L,6L,5L,2L,5L,5L,1L,7L,7L,8L,7L,9L,3L,5L,9L,3L,3L,0L,7L,7L,5L,1L,1L,2L,1L,2L,9L,4L,5L,6L,3L,8L,1L,2L,6L,5L,5L,7L,6L,9L,4L,3L,2L,8L,0L,2L,8L,0L,7L,6L,0L,1L,4L,4L,2L,5L,0L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245461Inst : IEnumerable<long>
{
public static readonly long[] Value=A245461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245461.Bytes);
public long this[int i]=>Value[i];

public static A245461Inst Instance=new A245461Inst();

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