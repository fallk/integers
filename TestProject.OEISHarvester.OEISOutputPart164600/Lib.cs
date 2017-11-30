using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A195057
{
public static readonly long[] Value={ 8L,9L,7L,2L,3L,6L,7L,6L,3L,7L,3L,5L,3L,9L,6L,2L,3L,8L,0L,7L,5L,8L,6L,2L,8L,1L,8L,1L,7L,0L,5L,5L,9L,1L,9L,4L,1L,1L,9L,4L,2L,7L,2L,1L,8L,8L,4L,0L,0L,7L,1L,8L,7L,5L,1L,2L,8L,4L,8L,6L,3L,0L,6L,9L,2L,9L,0L,9L,4L,9L,8L,3L,8L,5L,6L,2L,9L,1L,3L,8L,5L,7L,2L,7L,4L,3L,3L,9L,4L,5L,7L,9L,2L,5L,9L,5L,6L,5L,7L,4L,3L,8L,5L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195057Inst : IEnumerable<long>
{
public static readonly long[] Value=A195057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195057.Bytes);
public long this[int i]=>Value[i];

public static A195057Inst Instance=new A195057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195058
{
public static readonly long[] Value={ 0L,1L,23L,47L,92L,139L,207L,277L,368L,461L,575L,691L,828L,967L,1127L,1289L,1472L,1657L,1863L,2071L,2300L,2531L,2783L,3037L,3312L,3589L,3887L,4187L,4508L,4831L,5175L,5521L,5888L,6257L,6647L,7039L,7452L,7867L,8303L,8741L,9200L,9661L,10143L,10627L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195058Inst : IEnumerable<long>
{
public static readonly long[] Value=A195058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195058.Bytes);
public long this[int i]=>Value[i];

public static A195058Inst Instance=new A195058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195059
{
public static readonly long[] Value={ 7L,5L,9L,2L,0L,0L,3L,3L,8L,5L,4L,5L,3L,3L,5L,2L,7L,8L,3L,7L,1L,8L,8L,3L,9L,2L,3L,0L,6L,7L,3L,9L,6L,2L,4L,1L,1L,7L,7L,9L,7L,6L,8L,7L,7L,4L,8L,0L,0L,6L,0L,8L,1L,7L,4L,1L,6L,4L,1L,1L,4L,9L,0L,4L,7L,8L,4L,6L,4L,9L,8L,6L,3L,3L,9L,9L,3L,8L,8L,6L,4L,8L,4L,6L,2L,9L,0L,2L,6L,1L,8L,2L,4L,5L,0L,4L,0L,1L,7L,8L,3L,2L,6L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195059Inst : IEnumerable<long>
{
public static readonly long[] Value=A195059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195059.Bytes);
public long this[int i]=>Value[i];

public static A195059Inst Instance=new A195059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195060
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,7L,9L,12L,13L,15L,18L,22L,24L,26L,30L,35L,37L,40L,45L,51L,54L,57L,63L,70L,73L,77L,84L,92L,96L,100L,108L,117L,121L,126L,135L,145L,150L,155L,165L,176L,181L,187L,198L,210L,216L,222L,234L,247L,253L,260L,273L,287L,294L,301L,315L,330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195060Inst : IEnumerable<long>
{
public static readonly long[] Value=A195060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195060.Bytes);
public long this[int i]=>Value[i];

public static A195060Inst Instance=new A195060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195061
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195061Inst : IEnumerable<long>
{
public static readonly long[] Value=A195061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195061.Bytes);
public long this[int i]=>Value[i];

public static A195061Inst Instance=new A195061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195062
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195062Inst : IEnumerable<long>
{
public static readonly long[] Value=A195062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195062.Bytes);
public long this[int i]=>Value[i];

public static A195062Inst Instance=new A195062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195063
{
public static readonly long[] Value={ 6L,14L,22L,26L,28L,30L,46L,50L,54L,58L,60L,62L,78L,86L,90L,94L,98L,102L,106L,108L,110L,114L,116L,118L,120L,122L,124L,126L,158L,166L,174L,182L,186L,190L,194L,198L,202L,206L,210L,214L,218L,220L,222L,226L,228L,230L,234L,236L,238L,242L,244L,246L,248L,250L,252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195063Inst : IEnumerable<long>
{
public static readonly long[] Value=A195063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195063.Bytes);
public long this[int i]=>Value[i];

public static A195063Inst Instance=new A195063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195064
{
public static readonly long[] Value={ 2L,6L,10L,12L,14L,22L,26L,28L,30L,38L,42L,46L,50L,52L,54L,56L,58L,60L,62L,78L,86L,90L,94L,98L,102L,106L,108L,110L,114L,116L,118L,120L,122L,124L,126L,142L,150L,158L,166L,170L,174L,178L,182L,186L,190L,194L,198L,202L,204L,206L,210L,212L,214L,218L,220L,222L,226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195064Inst : IEnumerable<long>
{
public static readonly long[] Value=A195064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195064.Bytes);
public long this[int i]=>Value[i];

public static A195064Inst Instance=new A195064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195065
{
public static readonly long[] Value={ 0L,4L,8L,16L,18L,20L,24L,32L,34L,36L,40L,44L,48L,64L,66L,68L,70L,72L,74L,76L,80L,82L,84L,88L,92L,96L,100L,104L,112L,128L,130L,132L,134L,136L,138L,140L,144L,146L,148L,152L,154L,156L,160L,162L,164L,168L,172L,176L,180L,184L,188L,192L,196L,200L,208L,216L,224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195065Inst : IEnumerable<long>
{
public static readonly long[] Value=A195065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195065.Bytes);
public long this[int i]=>Value[i];

public static A195065Inst Instance=new A195065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195066
{
public static readonly long[] Value={ 0L,2L,4L,8L,10L,12L,16L,18L,20L,24L,32L,34L,36L,38L,40L,42L,44L,48L,52L,56L,64L,66L,68L,70L,72L,74L,76L,80L,82L,84L,88L,92L,96L,100L,104L,112L,128L,130L,132L,134L,136L,138L,140L,142L,144L,146L,148L,150L,152L,154L,156L,160L,162L,164L,168L,170L,172L,176L,178L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195066Inst : IEnumerable<long>
{
public static readonly long[] Value=A195066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195066.Bytes);
public long this[int i]=>Value[i];

public static A195066Inst Instance=new A195066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195067
{
public static readonly BigInteger[] Value={ 1L,1L,3L,17L,191L,4261L,189123L,16723689L,2949213319L,1037964817357L,729449200732395L,1024041038817726353L,BigInteger.Parse("2872628913886690237679"),BigInteger.Parse("16105674069113302453209781"),BigInteger.Parse("180504701103754829110217971731"),BigInteger.Parse("4044484405239396750189431682523833") };
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
public class A195067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195067Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195067.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195067.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195067Inst Instance=new A195067Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195068
{
public static readonly BigInteger[] Value={ 1L,1L,2L,7L,37L,279L,2919L,42011L,833314L,22937285L,882905932L,47833330376L,3664667588132L,398332024544864L,61567508987316736L,13553812089298857340UL,BigInteger.Parse("4254977588443309549759"),BigInteger.Parse("1906584878492298737985244"),BigInteger.Parse("1220249817955981418494900097") };
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
public class A195068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195068Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195068.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195068.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195068Inst Instance=new A195068Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195069
{
public static readonly long[] Value={ 2048L,6144L,9216L,10240L,13824L,14336L,20736L,22528L,25600L,26624L,30720L,31104L,34816L,38912L,43008L,46080L,46656L,47104L,50176L,59392L,63488L,64000L,64512L,67584L,69120L,69984L,71680L,75776L,76800L,79872L,83968L,88064L,96256L,96768L,101376L,103680L,104448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195069Inst : IEnumerable<long>
{
public static readonly long[] Value=A195069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195069.Bytes);
public long this[int i]=>Value[i];

public static A195069Inst Instance=new A195069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195070
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,2L,7L,5L,5L,7L,3L,1L,9L,2L,2L,4L,0L,2L,6L,9L,9L,3L,8L,2L,8L,7L,9L,0L,4L,4L,1L,2L,4L,9L,5L,6L,9L,4L,3L,3L,4L,4L,0L,3L,3L,2L,3L,6L,7L,5L,7L,4L,7L,6L,8L,0L,5L,9L,7L,5L,0L,7L,1L,5L,2L,4L,6L,5L,1L,2L,7L,5L,6L,5L,3L,3L,5L,1L,4L,6L,1L,5L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195070Inst : IEnumerable<long>
{
public static readonly long[] Value=A195070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195070.Bytes);
public long this[int i]=>Value[i];

public static A195070Inst Instance=new A195070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195071
{
public static readonly long[] Value={ 1L,3L,2L,6L,5L,4L,9L,10L,8L,7L,13L,15L,14L,12L,11L,18L,21L,20L,19L,17L,16L,24L,27L,28L,26L,25L,23L,22L,31L,34L,36L,35L,33L,32L,30L,29L,39L,42L,45L,44L,43L,41L,40L,38L,37L,48L,51L,55L,54L,53L,52L,50L,49L,47L,46L,58L,61L,65L,66L,64L,63L,62L,60L,59L,57L,56L,69L,72L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195071Inst : IEnumerable<long>
{
public static readonly long[] Value=A195071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195071.Bytes);
public long this[int i]=>Value[i];

public static A195071Inst Instance=new A195071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195072
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,3L,4L,4L,5L,5L,6L,6L,6L,7L,7L,8L,8L,9L,9L,9L,10L,10L,11L,11L,11L,12L,12L,13L,13L,14L,14L,14L,15L,15L,16L,16L,17L,17L,17L,18L,18L,19L,19L,20L,20L,20L,21L,21L,22L,22L,22L,23L,23L,24L,24L,25L,25L,25L,26L,26L,27L,27L,28L,28L,28L,29L,29L,30L,30L,31L,31L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195072Inst : IEnumerable<long>
{
public static readonly long[] Value=A195072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195072.Bytes);
public long this[int i]=>Value[i];

public static A195072Inst Instance=new A195072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195073
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,1L,2L,4L,3L,1L,2L,4L,5L,3L,1L,2L,4L,6L,5L,3L,1L,2L,4L,7L,6L,5L,3L,1L,2L,4L,7L,8L,6L,5L,3L,1L,2L,4L,7L,9L,8L,6L,5L,3L,1L,2L,4L,7L,9L,10L,8L,6L,5L,3L,1L,2L,4L,7L,9L,11L,10L,8L,6L,5L,3L,1L,2L,4L,7L,9L,11L,12L,10L,8L,6L,5L,3L,1L,2L,4L,7L,9L,11L,13L,12L,10L,8L,6L,5L,3L,1L,2L,4L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195073Inst : IEnumerable<long>
{
public static readonly long[] Value=A195073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195073.Bytes);
public long this[int i]=>Value[i];

public static A195073Inst Instance=new A195073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195074
{
public static readonly long[] Value={ 1L,3L,2L,6L,4L,5L,10L,7L,9L,8L,15L,11L,14L,12L,13L,21L,16L,20L,17L,19L,18L,28L,22L,27L,23L,26L,25L,24L,36L,29L,35L,30L,34L,33L,31L,32L,45L,37L,44L,38L,43L,42L,39L,41L,40L,55L,46L,54L,47L,53L,52L,48L,51L,49L,50L,66L,56L,65L,57L,64L,63L,58L,62L,59L,61L,60L,78L,67L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195074Inst : IEnumerable<long>
{
public static readonly long[] Value=A195074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195074.Bytes);
public long this[int i]=>Value[i];

public static A195074Inst Instance=new A195074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195075
{
public static readonly long[] Value={ 1L,3L,2L,5L,6L,4L,8L,10L,9L,7L,12L,14L,15L,13L,11L,17L,19L,21L,20L,18L,16L,23L,25L,28L,27L,26L,24L,22L,30L,32L,35L,36L,34L,33L,31L,29L,38L,40L,43L,45L,44L,42L,41L,39L,37L,47L,49L,52L,54L,55L,53L,51L,50L,48L,46L,57L,59L,62L,64L,66L,65L,63L,61L,60L,58L,56L,68L,70L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195075Inst : IEnumerable<long>
{
public static readonly long[] Value=A195075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195075.Bytes);
public long this[int i]=>Value[i];

public static A195075Inst Instance=new A195075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195076
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,1L,2L,4L,3L,1L,2L,5L,4L,3L,1L,2L,5L,6L,4L,3L,1L,2L,5L,7L,6L,4L,3L,1L,2L,5L,8L,7L,6L,4L,3L,1L,2L,5L,8L,9L,7L,6L,4L,3L,1L,2L,5L,8L,10L,9L,7L,6L,4L,3L,1L,2L,5L,8L,11L,10L,9L,7L,6L,4L,3L,1L,2L,5L,8L,11L,12L,10L,9L,7L,6L,4L,3L,1L,2L,5L,8L,11L,13L,12L,10L,9L,7L,6L,4L,3L,1L,2L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195076Inst : IEnumerable<long>
{
public static readonly long[] Value=A195076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195076.Bytes);
public long this[int i]=>Value[i];

public static A195076Inst Instance=new A195076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195077
{
public static readonly long[] Value={ 1L,3L,2L,6L,4L,5L,10L,7L,9L,8L,15L,11L,14L,13L,12L,21L,16L,20L,19L,17L,18L,28L,22L,27L,26L,23L,25L,24L,36L,29L,35L,34L,30L,33L,32L,31L,45L,37L,44L,43L,38L,42L,41L,39L,40L,55L,46L,54L,53L,47L,52L,51L,48L,50L,49L,66L,56L,65L,64L,57L,63L,62L,58L,61L,60L,59L,78L,67L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195077Inst : IEnumerable<long>
{
public static readonly long[] Value=A195077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195077.Bytes);
public long this[int i]=>Value[i];

public static A195077Inst Instance=new A195077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195078
{
public static readonly long[] Value={ 1L,3L,2L,5L,6L,4L,8L,10L,9L,7L,12L,15L,14L,13L,11L,17L,20L,21L,19L,18L,16L,23L,26L,28L,27L,25L,24L,22L,30L,33L,36L,35L,34L,32L,31L,29L,38L,41L,44L,45L,43L,42L,40L,39L,37L,47L,50L,53L,55L,54L,52L,51L,49L,48L,46L,57L,60L,63L,66L,65L,64L,62L,61L,59L,58L,56L,68L,71L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195078Inst : IEnumerable<long>
{
public static readonly long[] Value=A195078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195078.Bytes);
public long this[int i]=>Value[i];

public static A195078Inst Instance=new A195078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195079
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,3L,4L,2L,1L,3L,5L,4L,2L,1L,3L,6L,5L,4L,2L,1L,3L,7L,6L,5L,4L,2L,1L,3L,7L,8L,6L,5L,4L,2L,1L,3L,7L,9L,8L,6L,5L,4L,2L,1L,3L,7L,10L,9L,8L,6L,5L,4L,2L,1L,3L,7L,11L,10L,9L,8L,6L,5L,4L,2L,1L,3L,7L,11L,12L,10L,9L,8L,6L,5L,4L,2L,1L,3L,7L,11L,13L,12L,10L,9L,8L,6L,5L,4L,2L,1L,3L,7L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195079Inst : IEnumerable<long>
{
public static readonly long[] Value=A195079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195079.Bytes);
public long this[int i]=>Value[i];

public static A195079Inst Instance=new A195079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195080
{
public static readonly long[] Value={ 1L,3L,2L,6L,5L,4L,10L,9L,7L,8L,15L,14L,11L,13L,12L,21L,20L,16L,19L,18L,17L,28L,27L,22L,26L,25L,24L,23L,36L,35L,29L,34L,33L,32L,30L,31L,45L,44L,37L,43L,42L,41L,38L,40L,39L,55L,54L,46L,53L,52L,51L,47L,50L,49L,48L,66L,65L,56L,64L,63L,62L,57L,61L,60L,59L,58L,78L,77L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195080Inst : IEnumerable<long>
{
public static readonly long[] Value=A195080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195080.Bytes);
public long this[int i]=>Value[i];

public static A195080Inst Instance=new A195080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195081
{
public static readonly long[] Value={ 1L,3L,2L,6L,5L,4L,9L,10L,8L,7L,13L,15L,14L,12L,11L,18L,21L,20L,19L,17L,16L,24L,28L,27L,26L,25L,23L,22L,31L,35L,36L,34L,33L,32L,30L,29L,39L,43L,45L,44L,42L,41L,40L,38L,37L,48L,52L,55L,54L,53L,51L,50L,49L,47L,46L,58L,62L,66L,65L,64L,63L,61L,60L,59L,57L,56L,69L,73L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195081Inst : IEnumerable<long>
{
public static readonly long[] Value=A195081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195081.Bytes);
public long this[int i]=>Value[i];

public static A195081Inst Instance=new A195081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195082
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,2L,4L,3L,1L,2L,4L,5L,3L,1L,2L,4L,5L,6L,3L,1L,2L,4L,5L,7L,6L,3L,1L,2L,4L,5L,7L,8L,6L,3L,1L,2L,4L,5L,7L,8L,9L,6L,3L,1L,2L,4L,5L,7L,8L,10L,9L,6L,3L,1L,2L,4L,5L,7L,8L,10L,11L,9L,6L,3L,1L,2L,4L,5L,7L,8L,10L,11L,12L,9L,6L,3L,1L,2L,4L,5L,7L,8L,10L,11L,13L,12L,9L,6L,3L,1L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195082Inst : IEnumerable<long>
{
public static readonly long[] Value=A195082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195082.Bytes);
public long this[int i]=>Value[i];

public static A195082Inst Instance=new A195082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195083
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,10L,9L,11L,12L,15L,13L,14L,16L,17L,21L,18L,19L,20L,22L,23L,28L,24L,25L,27L,26L,29L,30L,36L,31L,32L,35L,33L,34L,37L,38L,45L,39L,40L,44L,41L,42L,43L,46L,47L,55L,48L,49L,54L,50L,51L,53L,52L,56L,57L,66L,58L,59L,65L,60L,61L,64L,62L,63L,67L,68L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195083Inst : IEnumerable<long>
{
public static readonly long[] Value=A195083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195083.Bytes);
public long this[int i]=>Value[i];

public static A195083Inst Instance=new A195083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195084
{
public static readonly long[] Value={ 1L,3L,0L,4L,-1L,5L,-2L,6L,-3L,7L,-4L,8L,-5L,9L,-6L,10L,-7L,11L,-8L,12L,-9L,13L,-10L,14L,-11L,15L,-12L,16L,-13L,17L,-14L,18L,-15L,19L,-16L,20L,-17L,21L,-18L,22L,-19L,23L,-20L,24L,-21L,25L,-22L,26L,-23L,27L,-24L,28L,-25L,29L,-26L,30L,-27L,31L,-28L,32L,-29L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195084Inst : IEnumerable<long>
{
public static readonly long[] Value=A195084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195084.Bytes);
public long this[int i]=>Value[i];

public static A195084Inst Instance=new A195084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195085
{
public static readonly long[] Value={ 9L,18L,27L,45L,54L,63L,90L,99L,117L,126L,135L,153L,171L,189L,198L,207L,234L,261L,270L,279L,297L,306L,315L,333L,342L,351L,369L,378L,387L,414L,423L,459L,477L,495L,513L,522L,531L,549L,558L,585L,594L,603L,621L,630L,639L,657L,666L,693L,702L,711L,738L,747L,765L,774L,783L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195085Inst : IEnumerable<long>
{
public static readonly long[] Value=A195085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195085.Bytes);
public long this[int i]=>Value[i];

public static A195085Inst Instance=new A195085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195086
{
public static readonly long[] Value={ 8L,24L,27L,36L,40L,54L,56L,88L,100L,104L,120L,125L,135L,136L,152L,168L,180L,184L,189L,196L,225L,232L,248L,250L,252L,264L,270L,280L,296L,297L,300L,312L,328L,343L,344L,351L,375L,376L,378L,396L,408L,424L,440L,441L,450L,456L,459L,468L,472L,484L,488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195086Inst : IEnumerable<long>
{
public static readonly long[] Value=A195086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195086.Bytes);
public long this[int i]=>Value[i];

public static A195086Inst Instance=new A195086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195087
{
public static readonly long[] Value={ 16L,48L,72L,80L,81L,108L,112L,162L,176L,200L,208L,240L,272L,304L,336L,360L,368L,392L,405L,464L,496L,500L,504L,528L,540L,560L,567L,592L,600L,624L,625L,656L,675L,688L,752L,756L,792L,810L,816L,848L,880L,891L,900L,912L,936L,944L,968L,976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195087Inst : IEnumerable<long>
{
public static readonly long[] Value=A195087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195087.Bytes);
public long this[int i]=>Value[i];

public static A195087Inst Instance=new A195087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195088
{
public static readonly long[] Value={ 32L,96L,144L,160L,216L,224L,243L,324L,352L,400L,416L,480L,486L,544L,608L,672L,720L,736L,784L,928L,992L,1000L,1008L,1056L,1080L,1120L,1184L,1200L,1215L,1248L,1312L,1376L,1504L,1512L,1584L,1620L,1632L,1696L,1701L,1760L,1800L,1824L,1872L,1888L,1936L,1952L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195088Inst : IEnumerable<long>
{
public static readonly long[] Value=A195088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195088.Bytes);
public long this[int i]=>Value[i];

public static A195088Inst Instance=new A195088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195089
{
public static readonly long[] Value={ 64L,192L,288L,320L,432L,448L,648L,704L,729L,800L,832L,960L,972L,1088L,1216L,1344L,1440L,1458L,1472L,1568L,1856L,1984L,2000L,2016L,2112L,2160L,2240L,2368L,2400L,2496L,2624L,2752L,3008L,3024L,3168L,3240L,3264L,3392L,3520L,3600L,3645L,3648L,3744L,3776L,3872L,3904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195089Inst : IEnumerable<long>
{
public static readonly long[] Value=A195089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195089.Bytes);
public long this[int i]=>Value[i];

public static A195089Inst Instance=new A195089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195090
{
public static readonly long[] Value={ 128L,384L,576L,640L,864L,896L,1296L,1408L,1600L,1664L,1920L,1944L,2176L,2187L,2432L,2688L,2880L,2916L,2944L,3136L,3712L,3968L,4000L,4032L,4224L,4320L,4374L,4480L,4736L,4800L,4992L,5248L,5504L,6016L,6048L,6336L,6480L,6528L,6784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195090Inst : IEnumerable<long>
{
public static readonly long[] Value=A195090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195090.Bytes);
public long this[int i]=>Value[i];

public static A195090Inst Instance=new A195090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195091
{
public static readonly long[] Value={ 256L,768L,1152L,1280L,1728L,1792L,2592L,2816L,3200L,3328L,3840L,3888L,4352L,4864L,5376L,5760L,5832L,5888L,6272L,6561L,7424L,7936L,8000L,8064L,8448L,8640L,8748L,8960L,9472L,9600L,9984L,10496L,11008L,12032L,12096L,12672L,12960L,13056L,13122L,13568L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195091Inst : IEnumerable<long>
{
public static readonly long[] Value=A195091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195091.Bytes);
public long this[int i]=>Value[i];

public static A195091Inst Instance=new A195091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195092
{
public static readonly long[] Value={ 512L,1536L,2304L,2560L,3456L,3584L,5184L,5632L,6400L,6656L,7680L,7776L,8704L,9728L,10752L,11520L,11664L,11776L,12544L,14848L,15872L,16000L,16128L,16896L,17280L,17496L,17920L,18944L,19200L,19683L,19968L,20992L,22016L,24064L,24192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195092Inst : IEnumerable<long>
{
public static readonly long[] Value=A195092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195092.Bytes);
public long this[int i]=>Value[i];

public static A195092Inst Instance=new A195092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195093
{
public static readonly long[] Value={ 1024L,3072L,4608L,5120L,6912L,7168L,10368L,11264L,12800L,13312L,15360L,15552L,17408L,19456L,21504L,23040L,23328L,23552L,25088L,29696L,31744L,32000L,32256L,33792L,34560L,34992L,35840L,37888L,38400L,39936L,41984L,44032L,48128L,48384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195093Inst : IEnumerable<long>
{
public static readonly long[] Value=A195093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195093.Bytes);
public long this[int i]=>Value[i];

public static A195093Inst Instance=new A195093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195094
{
public static readonly long[] Value={ 1L,3L,5L,10L,14L,18L,27L,36L,39L,52L,65L,68L,90L,102L,100L,136L,152L,150L,189L,200L,198L,250L,275L,264L,310L,348L,333L,396L,434L,392L,495L,528L,490L,592L,588L,588L,702L,738L,684L,784L,860L,780L,945L,980L,876L,1078L,1127L,1040L,1197L,1220L,1168L,1368L,1430L,1314L,1460L,1560L,1458L,1708L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195094Inst : IEnumerable<long>
{
public static readonly long[] Value=A195094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195094.Bytes);
public long this[int i]=>Value[i];

public static A195094Inst Instance=new A195094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195095
{
public static readonly long[] Value={ 1L,2L,3L,8L,15L,30L,63L,128L,252L,510L,1023L,2040L,4095L,8190L,16365L,32768L,65535L,131040L,262143L,524280L,1048509L,2097150L,4194303L,8388480L,16777200L,33554430L,67108608L,134217720L,268435455L,536870370L,1073741823L,2147483648L,4294966269L,8589934590L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195095Inst : IEnumerable<long>
{
public static readonly long[] Value=A195095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195095.Bytes);
public long this[int i]=>Value[i];

public static A195095Inst Instance=new A195095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195096
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,10L,9L,11L,12L,14L,15L,13L,16L,17L,19L,20L,21L,18L,22L,23L,25L,26L,28L,27L,24L,29L,30L,32L,33L,35L,36L,34L,31L,37L,38L,40L,41L,43L,44L,45L,42L,39L,46L,47L,49L,50L,52L,53L,55L,54L,51L,48L,56L,57L,59L,60L,62L,63L,65L,66L,64L,61L,58L,67L,68L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195096Inst : IEnumerable<long>
{
public static readonly long[] Value=A195096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195096.Bytes);
public long this[int i]=>Value[i];

public static A195096Inst Instance=new A195096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195097
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,2L,3L,4L,1L,2L,3L,5L,4L,1L,2L,3L,5L,6L,4L,1L,2L,3L,5L,6L,7L,4L,1L,2L,3L,5L,6L,7L,8L,4L,1L,2L,3L,5L,6L,7L,9L,8L,4L,1L,2L,3L,5L,6L,7L,9L,10L,8L,4L,1L,2L,3L,5L,6L,7L,9L,10L,11L,8L,4L,1L,2L,3L,5L,6L,7L,9L,10L,11L,12L,8L,4L,1L,2L,3L,5L,6L,7L,9L,10L,11L,13L,12L,8L,4L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195097Inst : IEnumerable<long>
{
public static readonly long[] Value=A195097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195097.Bytes);
public long this[int i]=>Value[i];

public static A195097Inst Instance=new A195097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195098
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,15L,14L,16L,17L,18L,21L,19L,20L,22L,23L,24L,28L,25L,26L,27L,29L,30L,31L,36L,32L,33L,34L,35L,37L,38L,39L,45L,40L,41L,42L,44L,43L,46L,47L,48L,55L,49L,50L,51L,54L,52L,53L,56L,57L,58L,66L,59L,60L,61L,65L,62L,63L,64L,67L,68L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195098Inst : IEnumerable<long>
{
public static readonly long[] Value=A195098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195098.Bytes);
public long this[int i]=>Value[i];

public static A195098Inst Instance=new A195098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195099
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,15L,14L,16L,17L,18L,20L,21L,19L,22L,23L,24L,26L,27L,28L,25L,29L,30L,31L,33L,34L,35L,36L,32L,37L,38L,39L,41L,42L,43L,45L,44L,40L,46L,47L,48L,50L,51L,52L,54L,55L,53L,49L,56L,57L,58L,60L,61L,62L,64L,65L,66L,63L,59L,67L,68L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195099Inst : IEnumerable<long>
{
public static readonly long[] Value=A195099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195099.Bytes);
public long this[int i]=>Value[i];

public static A195099Inst Instance=new A195099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195100
{
public static readonly long[] Value={ 1L,11L,21L,25L,28L,33L,66L,122L,140L,142L,188L,307L,322L,349L,1007L,1052L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195100Inst : IEnumerable<long>
{
public static readonly long[] Value=A195100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195100.Bytes);
public long this[int i]=>Value[i];

public static A195100Inst Instance=new A195100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195101
{
public static readonly long[] Value={ 1L,6L,8L,9L,12L,14L,15L,16L,18L,20L,21L,24L,26L,27L,30L,32L,34L,35L,36L,38L,39L,40L,42L,44L,45L,48L,50L,51L,52L,54L,56L,57L,60L,62L,63L,64L,66L,68L,70L,72L,74L,75L,76L,78L,80L,81L,84L,86L,87L,88L,90L,92L,93L,95L,96L,98L,99L,100L,102L,104L,105L,108L,110L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195101Inst : IEnumerable<long>
{
public static readonly long[] Value=A195101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195101.Bytes);
public long this[int i]=>Value[i];

public static A195101Inst Instance=new A195101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195102
{
public static readonly long[] Value={ 1L,6L,9L,0L,3L,0L,2L,9L,7L,1L,4L,0L,5L,2L,4L,4L,8L,5L,3L,3L,4L,3L,7L,8L,0L,1L,5L,0L,3L,2L,4L,1L,6L,1L,3L,4L,8L,2L,2L,8L,2L,7L,8L,0L,5L,9L,7L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195102Inst : IEnumerable<long>
{
public static readonly long[] Value=A195102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195102.Bytes);
public long this[int i]=>Value[i];

public static A195102Inst Instance=new A195102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195103
{
public static readonly long[] Value={ 6L,6L,7L,6L,9L,1L,4L,5L,7L,1L,8L,9L,6L,0L,9L,1L,7L,6L,6L,5L,8L,6L,9L,0L,9L,2L,9L,3L,0L,0L,2L,4L,8L,4L,8L,2L,2L,5L,1L,5L,9L,7L,8L,2L,9L,7L,4L,2L,9L,3L,7L,0L,9L,7L,7L,4L,9L,7L,9L,8L,6L,5L,7L,3L,2L,1L,7L,6L,1L,6L,0L,8L,7L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195103Inst : IEnumerable<long>
{
public static readonly long[] Value=A195103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195103.Bytes);
public long this[int i]=>Value[i];

public static A195103Inst Instance=new A195103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195104
{
public static readonly long[] Value={ 3L,2L,5L,11L,2L,11L,3L,29L,101L,199L,29L,7L,13L,11L,29L,71L,13L,3L,71L,101L,29L,43L,79L,5L,11L,11L,5L,29L,61L,2L,2L,11L,19L,11L,29L,5L,11L,7L,41L,19L,181L,19L,59L,5L,11L,7L,29L,11L,41L,179L,41L,13L,61L,181L,19L,241L,139L,331L,271L,3L,59L,5L,41L,211L,19L,2L,5L,131L,59L,5L,5L,509L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195104Inst : IEnumerable<long>
{
public static readonly long[] Value=A195104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195104.Bytes);
public long this[int i]=>Value[i];

public static A195104Inst Instance=new A195104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195105
{
public static readonly BigInteger[] Value={ 1L,-3L,21L,177L,11721L,605157L,-13346979L,-22645137063L,-9383133860079L,-3118216413426483L,-681462248603151579L,BigInteger.Parse("220767331752698256897"),BigInteger.Parse("516670540464500515714521"),BigInteger.Parse("546555407869823056031953077"),BigInteger.Parse("418410321677501798899834234221"),BigInteger.Parse("139924678536116450478811178022057") };
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
public class A195105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195105Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195105.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195105.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195105Inst Instance=new A195105Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195106
{
public static readonly long[] Value={ 21L,63L,77L,105L,147L,189L,221L,315L,437L,441L,525L,539L,567L,735L,847L,945L,1029L,1323L,1517L,1575L,1701L,2021L,2205L,2625L,2835L,2873L,3087L,3675L,3757L,3773L,3969L,4725L,4757L,5103L,5145L,5929L,6557L,6615L,7203L,7875L,8303L,8505L,9261L,9317L,9797L,10051L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195106Inst : IEnumerable<long>
{
public static readonly long[] Value=A195106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195106.Bytes);
public long this[int i]=>Value[i];

public static A195106Inst Instance=new A195106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195107
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,2L,3L,1L,4L,2L,3L,5L,1L,4L,2L,6L,3L,5L,1L,4L,2L,6L,3L,5L,7L,1L,4L,2L,6L,3L,8L,5L,7L,1L,4L,2L,6L,9L,3L,8L,5L,7L,1L,4L,2L,10L,6L,9L,3L,8L,5L,7L,1L,4L,2L,10L,6L,9L,3L,11L,8L,5L,7L,1L,4L,2L,10L,6L,9L,12L,3L,11L,8L,5L,7L,1L,4L,2L,10L,6L,13L,9L,12L,3L,11L,8L,5L,7L,1L,4L,2L,10L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195107Inst : IEnumerable<long>
{
public static readonly long[] Value=A195107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195107.Bytes);
public long this[int i]=>Value[i];

public static A195107Inst Instance=new A195107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195108
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,4L,8L,10L,7L,9L,13L,15L,11L,14L,12L,19L,21L,17L,20L,18L,16L,26L,28L,23L,27L,24L,22L,25L,34L,36L,30L,35L,32L,29L,33L,31L,43L,45L,39L,44L,41L,37L,42L,40L,38L,53L,55L,49L,54L,51L,47L,52L,50L,48L,46L,64L,66L,59L,65L,62L,57L,63L,61L,58L,56L,60L,76L,78L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195108Inst : IEnumerable<long>
{
public static readonly long[] Value=A195108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195108.Bytes);
public long this[int i]=>Value[i];

public static A195108Inst Instance=new A195108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195109
{
public static readonly long[] Value={ 1L,2L,3L,6L,4L,5L,9L,7L,10L,8L,13L,15L,11L,14L,12L,21L,18L,20L,16L,19L,17L,27L,24L,26L,28L,22L,25L,23L,34L,31L,36L,33L,35L,29L,32L,30L,42L,45L,39L,44L,41L,43L,37L,40L,38L,55L,51L,54L,48L,53L,50L,52L,46L,49L,47L,65L,61L,64L,58L,66L,63L,60L,62L,56L,59L,57L,76L,72L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195109Inst : IEnumerable<long>
{
public static readonly long[] Value=A195109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195109.Bytes);
public long this[int i]=>Value[i];

public static A195109Inst Instance=new A195109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195110
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,1L,4L,2L,3L,1L,4L,5L,2L,3L,1L,4L,5L,6L,2L,3L,1L,7L,4L,5L,6L,2L,3L,1L,7L,8L,4L,5L,6L,2L,3L,1L,7L,8L,9L,4L,5L,6L,2L,3L,1L,7L,8L,9L,10L,4L,5L,6L,2L,3L,1L,11L,7L,8L,9L,10L,4L,5L,6L,2L,3L,1L,11L,12L,7L,8L,9L,10L,4L,5L,6L,2L,3L,1L,11L,12L,13L,7L,8L,9L,10L,4L,5L,6L,2L,3L,1L,11L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195110Inst : IEnumerable<long>
{
public static readonly long[] Value=A195110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195110.Bytes);
public long this[int i]=>Value[i];

public static A195110Inst Instance=new A195110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195111
{
public static readonly long[] Value={ 1L,3L,2L,6L,4L,5L,10L,8L,9L,7L,15L,13L,14L,11L,12L,21L,19L,20L,16L,17L,18L,28L,26L,27L,23L,24L,25L,22L,36L,34L,35L,31L,32L,33L,29L,30L,45L,43L,44L,40L,41L,42L,37L,38L,39L,55L,53L,54L,50L,51L,52L,46L,47L,48L,49L,66L,64L,65L,61L,62L,63L,57L,58L,59L,60L,56L,78L,76L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195111Inst : IEnumerable<long>
{
public static readonly long[] Value=A195111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195111.Bytes);
public long this[int i]=>Value[i];

public static A195111Inst Instance=new A195111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195112
{
public static readonly long[] Value={ 1L,3L,2L,5L,6L,4L,10L,8L,9L,7L,14L,15L,12L,13L,11L,19L,20L,21L,17L,18L,16L,28L,25L,26L,27L,23L,24L,22L,35L,36L,32L,33L,34L,30L,31L,29L,43L,44L,45L,40L,41L,42L,38L,39L,37L,52L,53L,54L,55L,49L,50L,51L,47L,48L,46L,66L,62L,63L,64L,65L,59L,60L,61L,57L,58L,56L,77L,78L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195112Inst : IEnumerable<long>
{
public static readonly long[] Value=A195112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195112.Bytes);
public long this[int i]=>Value[i];

public static A195112Inst Instance=new A195112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195113
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,1L,2L,3L,4L,1L,5L,2L,3L,4L,1L,5L,6L,2L,3L,4L,1L,5L,6L,7L,2L,3L,4L,1L,5L,6L,7L,8L,2L,3L,4L,1L,9L,5L,6L,7L,8L,2L,3L,4L,1L,9L,10L,5L,6L,7L,8L,2L,3L,4L,1L,9L,10L,11L,5L,6L,7L,8L,2L,3L,4L,1L,9L,10L,11L,12L,5L,6L,7L,8L,2L,3L,4L,1L,9L,10L,11L,12L,13L,5L,6L,7L,8L,2L,3L,4L,1L,14L,9L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195113Inst : IEnumerable<long>
{
public static readonly long[] Value=A195113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195113.Bytes);
public long this[int i]=>Value[i];

public static A195113Inst Instance=new A195113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195114
{
public static readonly long[] Value={ 1L,3L,2L,6L,4L,5L,10L,7L,8L,9L,15L,12L,13L,14L,11L,21L,18L,19L,20L,16L,17L,28L,25L,26L,27L,22L,23L,24L,36L,33L,34L,35L,29L,30L,31L,32L,45L,42L,43L,44L,38L,39L,40L,41L,37L,55L,52L,53L,54L,48L,49L,50L,51L,46L,47L,66L,63L,64L,65L,59L,60L,61L,62L,56L,57L,58L,78L,75L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195114Inst : IEnumerable<long>
{
public static readonly long[] Value=A195114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195114.Bytes);
public long this[int i]=>Value[i];

public static A195114Inst Instance=new A195114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195115
{
public static readonly long[] Value={ 1L,3L,2L,5L,6L,4L,8L,9L,10L,7L,15L,12L,13L,14L,11L,20L,21L,17L,18L,19L,16L,26L,27L,28L,23L,24L,25L,22L,33L,34L,35L,36L,30L,31L,32L,29L,45L,41L,42L,43L,44L,38L,39L,40L,37L,54L,55L,50L,51L,52L,53L,47L,48L,49L,46L,64L,65L,66L,60L,61L,62L,63L,57L,58L,59L,56L,75L,76L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195115Inst : IEnumerable<long>
{
public static readonly long[] Value=A195115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195115.Bytes);
public long this[int i]=>Value[i];

public static A195115Inst Instance=new A195115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195116
{
public static readonly long[] Value={ 12L,25L,77L,319L,1577L,8575L,48977L,286759L,1699817L,10137775L,60645377L,363332599L,2178384857L,13065493375L,78378545777L,470228096839L,2821239178697L,16927047127375L,101561119454177L,609363227843479L,3656168902513337L,21936982025631775L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195116Inst : IEnumerable<long>
{
public static readonly long[] Value=A195116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195116.Bytes);
public long this[int i]=>Value[i];

public static A195116Inst Instance=new A195116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195117
{
public static readonly long[] Value={ 11L,41L,103L,601L,911L,2441L,3191L,6329L,9281L,13033L,17681L,23321L,33851L,42391L,52259L,69761L,98641L,144731L,178289L,203321L,260201L,275911L,292241L,383611L,492281L,516223L,592681L,676339L,767521L,1011359L,1171463L,1257491L,1394273L,1540631L,1643683L,1751231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195117Inst : IEnumerable<long>
{
public static readonly long[] Value=A195117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195117.Bytes);
public long this[int i]=>Value[i];

public static A195117Inst Instance=new A195117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195118
{
public static readonly long[] Value={ 55L,91L,187L,247L,275L,385L,391L,605L,637L,667L,1001L,1147L,1183L,1375L,1591L,1925L,1927L,2057L,2431L,2491L,2695L,3025L,3127L,3179L,3211L,4087L,4199L,4235L,4459L,4693L,4891L,5767L,6647L,6655L,6875L,7007L,7387L,7429L,8281L,8993L,9625L,9991L,10807L,11011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195118Inst : IEnumerable<long>
{
public static readonly long[] Value=A195118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195118.Bytes);
public long this[int i]=>Value[i];

public static A195118Inst Instance=new A195118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195119
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,4L,5L,5L,6L,6L,7L,8L,8L,9L,9L,10L,10L,11L,12L,12L,13L,13L,14L,15L,15L,16L,16L,17L,17L,18L,19L,19L,20L,20L,21L,22L,22L,23L,23L,24L,25L,25L,26L,26L,27L,27L,28L,29L,29L,30L,30L,31L,32L,32L,33L,33L,34L,34L,35L,36L,36L,37L,37L,38L,39L,39L,40L,40L,41L,42L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195119Inst : IEnumerable<long>
{
public static readonly long[] Value=A195119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195119.Bytes);
public long this[int i]=>Value[i];

public static A195119Inst Instance=new A195119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195120
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,2L,2L,3L,3L,3L,3L,4L,4L,4L,5L,5L,5L,5L,6L,6L,6L,6L,7L,7L,7L,7L,8L,8L,8L,9L,9L,9L,9L,10L,10L,10L,10L,11L,11L,11L,11L,12L,12L,12L,13L,13L,13L,13L,14L,14L,14L,14L,15L,15L,15L,16L,16L,16L,16L,17L,17L,17L,17L,18L,18L,18L,18L,19L,19L,19L,20L,20L,20L,20L,21L,21L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195120Inst : IEnumerable<long>
{
public static readonly long[] Value=A195120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195120.Bytes);
public long this[int i]=>Value[i];

public static A195120Inst Instance=new A195120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195121
{
public static readonly long[] Value={ 0L,2L,3L,5L,6L,7L,9L,10L,12L,13L,14L,16L,17L,18L,20L,21L,23L,24L,25L,27L,28L,30L,31L,32L,34L,35L,36L,38L,39L,41L,42L,43L,45L,46L,47L,49L,50L,52L,53L,54L,56L,57L,59L,60L,61L,63L,64L,65L,67L,68L,70L,71L,72L,74L,75L,77L,78L,79L,81L,82L,83L,85L,86L,88L,89L,90L,92L,93L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195121Inst : IEnumerable<long>
{
public static readonly long[] Value=A195121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195121.Bytes);
public long this[int i]=>Value[i];

public static A195121Inst Instance=new A195121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195122
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,6L,8L,9L,10L,11L,12L,14L,15L,16L,17L,18L,20L,21L,22L,23L,24L,26L,27L,28L,29L,30L,31L,33L,34L,35L,36L,37L,39L,40L,41L,42L,43L,45L,46L,47L,48L,49L,51L,52L,53L,54L,55L,56L,58L,59L,60L,61L,62L,64L,65L,66L,67L,68L,70L,71L,72L,73L,74L,76L,77L,78L,79L,80L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195122Inst : IEnumerable<long>
{
public static readonly long[] Value=A195122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195122.Bytes);
public long this[int i]=>Value[i];

public static A195122Inst Instance=new A195122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195123
{
public static readonly long[] Value={ 0L,2L,3L,5L,6L,8L,9L,11L,12L,14L,15L,17L,18L,19L,21L,22L,24L,25L,27L,28L,30L,31L,33L,34L,36L,37L,38L,40L,41L,43L,44L,46L,47L,49L,50L,52L,53L,55L,56L,57L,59L,60L,62L,63L,65L,66L,68L,69L,71L,72L,74L,75L,76L,78L,79L,81L,82L,84L,85L,87L,88L,90L,91L,93L,94L,95L,97L,98L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195123Inst : IEnumerable<long>
{
public static readonly long[] Value=A195123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195123.Bytes);
public long this[int i]=>Value[i];

public static A195123Inst Instance=new A195123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195124
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,4L,4L,5L,6L,6L,7L,8L,8L,9L,9L,10L,11L,11L,12L,13L,13L,14L,15L,15L,16L,17L,17L,18L,18L,19L,20L,20L,21L,22L,22L,23L,24L,24L,25L,25L,26L,27L,27L,28L,29L,29L,30L,31L,31L,32L,33L,33L,34L,34L,35L,36L,36L,37L,38L,38L,39L,40L,40L,41L,42L,42L,43L,43L,44L,45L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195124Inst : IEnumerable<long>
{
public static readonly long[] Value=A195124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195124.Bytes);
public long this[int i]=>Value[i];

public static A195124Inst Instance=new A195124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195125
{
public static readonly long[] Value={ 0L,2L,4L,6L,8L,10L,12L,14L,15L,17L,19L,21L,23L,25L,27L,28L,30L,32L,34L,36L,38L,40L,41L,43L,45L,47L,49L,51L,53L,54L,56L,58L,60L,62L,64L,66L,67L,69L,71L,73L,75L,77L,79L,80L,82L,84L,86L,88L,90L,92L,93L,95L,97L,99L,101L,103L,105L,106L,108L,110L,112L,114L,116L,118L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195125Inst : IEnumerable<long>
{
public static readonly long[] Value=A195125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195125.Bytes);
public long this[int i]=>Value[i];

public static A195125Inst Instance=new A195125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195126
{
public static readonly long[] Value={ 0L,2L,4L,5L,7L,8L,10L,12L,13L,15L,16L,18L,20L,21L,23L,24L,26L,28L,29L,31L,32L,34L,36L,37L,39L,40L,42L,44L,45L,47L,48L,50L,52L,53L,55L,56L,58L,60L,61L,63L,64L,66L,68L,69L,71L,72L,74L,75L,77L,79L,80L,82L,83L,85L,87L,88L,90L,91L,93L,95L,96L,98L,99L,101L,103L,104L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195126Inst : IEnumerable<long>
{
public static readonly long[] Value=A195126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195126.Bytes);
public long this[int i]=>Value[i];

public static A195126Inst Instance=new A195126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195127
{
public static readonly long[] Value={ 0L,2L,4L,6L,7L,9L,11L,12L,14L,16L,17L,19L,21L,22L,24L,26L,27L,29L,31L,32L,34L,36L,37L,39L,41L,42L,44L,46L,47L,49L,51L,52L,54L,56L,57L,59L,61L,63L,64L,66L,68L,69L,71L,73L,74L,76L,78L,79L,81L,83L,84L,86L,88L,89L,91L,93L,94L,96L,98L,99L,101L,103L,104L,106L,108L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195127Inst : IEnumerable<long>
{
public static readonly long[] Value=A195127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195127.Bytes);
public long this[int i]=>Value[i];

public static A195127Inst Instance=new A195127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195128
{
public static readonly long[] Value={ 0L,2L,3L,4L,6L,7L,8L,10L,11L,12L,13L,15L,16L,17L,19L,20L,21L,22L,24L,25L,26L,28L,29L,30L,32L,33L,34L,35L,37L,38L,39L,41L,42L,43L,44L,46L,47L,48L,50L,51L,52L,54L,55L,56L,57L,59L,60L,61L,63L,64L,65L,66L,68L,69L,70L,72L,73L,74L,75L,77L,78L,79L,81L,82L,83L,85L,86L,87L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195128Inst : IEnumerable<long>
{
public static readonly long[] Value=A195128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195128.Bytes);
public long this[int i]=>Value[i];

public static A195128Inst Instance=new A195128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195129
{
public static readonly long[] Value={ 0L,2L,3L,5L,6L,8L,9L,10L,12L,13L,15L,16L,18L,19L,20L,22L,23L,25L,26L,28L,29L,30L,32L,33L,35L,36L,37L,39L,40L,42L,43L,45L,46L,47L,49L,50L,52L,53L,55L,56L,57L,59L,60L,62L,63L,65L,66L,67L,69L,70L,72L,73L,74L,76L,77L,79L,80L,82L,83L,84L,86L,87L,89L,90L,92L,93L,94L,96L,97L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195129Inst : IEnumerable<long>
{
public static readonly long[] Value=A195129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195129.Bytes);
public long this[int i]=>Value[i];

public static A195129Inst Instance=new A195129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195130
{
public static readonly BigInteger[] Value={ 1L,24L,852L,35744L,1645794L,80415216L,4094489992L,214888573248L,11542515402255L,631467591949480L,35063515239394764L,1971043639046131296L,BigInteger.Parse("111949770626330347638"),BigInteger.Parse("6414671157989386260432"),BigInteger.Parse("370360217892318010055832") };
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
public class A195130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195130Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195130.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195130.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195130Inst Instance=new A195130Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195131
{
public static readonly long[] Value={ 3L,4L,5L,10L,14L,17L,18L,19L,25L,27L,30L,33L,34L,38L,44L,49L,52L,54L,55L,59L,63L,67L,69L,70L,72L,80L,89L,94L,97L,98L,102L,103L,104L,105L,107L,110L,128L,130L,132L,135L,140L,149L,154L,157L,158L,163L,174L,175L,177L,185L,187L,188L,199L,203L,220L,223L,224L,228L,237L,238L,240L,245L,249L,257L,258L,262L,265L,268L,270L,279L,280L,287L,290L,292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195131Inst : IEnumerable<long>
{
public static readonly long[] Value=A195131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195131.Bytes);
public long this[int i]=>Value[i];

public static A195131Inst Instance=new A195131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195132
{
public static readonly long[] Value={ 3L,5L,4L,3L,12L,44L,37L,7L,2L,7L,27L,80L,14L,32L,12L,14L,53L,32L,3L,87L,62L,13L,32L,13L,237L,147L,35L,63L,48L,35L,32L,44L,34L,32L,18L,28L,17L,12L,130L,250L,47L,108L,112L,73L,25L,5L,149L,44L,14L,129L,208L,238L,10L,13L,212L,124L,37L,180L,80L,212L,4L,19L,124L,42L,17L,112L,47L,27L,214L,84L,95L,182L,73L,957L,59L,68L,47L,13L,199L,130L,194L,75L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195132Inst : IEnumerable<long>
{
public static readonly long[] Value=A195132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195132.Bytes);
public long this[int i]=>Value[i];

public static A195132Inst Instance=new A195132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195133
{
public static readonly long[] Value={ 1L,2L,0L,4L,2L,-2L,-4L,8L,10L,6L,4L,-12L,-14L,-18L,-12L,24L,22L,30L,28L,12L,18L,14L,12L,-44L,-42L,-46L,-48L,-64L,-66L,-46L,-48L,60L,66L,62L,68L,104L,102L,98L,104L,48L,46L,66L,64L,48L,38L,34L,32L,-160L,-158L,-150L,-144L,-160L,-162L,-174L,-168L,-224L,-218L,-222L,-224L,-136L,-138L,-142L,-152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195133Inst : IEnumerable<long>
{
public static readonly long[] Value=A195133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195133.Bytes);
public long this[int i]=>Value[i];

public static A195133Inst Instance=new A195133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195134
{
public static readonly BigInteger[] Value={ 1L,1L,3L,14L,93L,796L,8407L,105832L,1551865L,26033680L,492708491L,10400139232L,242507271061L,6195709678016L,172208913873375L,5175087678675584L,167222667351260145L,5781987852483789056L,BigInteger.Parse("213003988054590430099"),BigInteger.Parse("8328278686225469009408"),BigInteger.Parse("344418854322690984069581") };
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
public class A195134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195134Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195134.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195134.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195134Inst Instance=new A195134Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195135
{
public static readonly BigInteger[] Value={ 1L,1L,-3L,20L,-235L,3856L,-81487L,2105536L,-64314423L,2267105536L,-90581348891L,4045219841024L,-199679678243747L,10795704486465536L,-634443738868419495L,BigInteger.Parse("40268829506038513664"),BigInteger.Parse("-2745282759717516526831"),BigInteger.Parse("200066916824905348612096"),BigInteger.Parse("-15521045994692397205950259"),BigInteger.Parse("1277100761225714616266653696") };
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
public class A195135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195135Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195135.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195135.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195135Inst Instance=new A195135Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195136
{
public static readonly BigInteger[] Value={ 1L,2L,10L,76L,776L,9966L,154400L,2803256L,58388608L,1372684090L,35958682112L,1038736032324L,32805006411776L,1124535087475814L,41584800431742976L,1650158470945337584L,BigInteger.Parse("69943137585151901696"),BigInteger.Parse("3153813559835569475058"),BigInteger.Parse("150745204037648268787712"),BigInteger.Parse("7613458147995669857352380"),BigInteger.Parse("405143549343202022103973888"),BigInteger.Parse("405143549343202022103973888"),BigInteger.Parse("22657085569540734204315357022") };
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
public class A195136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195136Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195136.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195136.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195136Inst Instance=new A195136Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195137
{
public static readonly BigInteger[] Value={ 2L,5L,17L,89L,1087L,30559L,127591L,8381719L,134207119L,140737488310807L,BigInteger.Parse("3450873173395281893717377931138512726225554486085193277581262109788439") };
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
public class A195137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195137Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195137.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195137.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195137Inst Instance=new A195137Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195138
{
public static readonly long[] Value={ 2L,2L,8L,8L,2L,2L,2L,2L,9L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,2L,2L,2L,2L,2L,2L,2L,3L,9L,9L,2L,7L,4L,4L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195138Inst : IEnumerable<long>
{
public static readonly long[] Value=A195138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195138.Bytes);
public long this[int i]=>Value[i];

public static A195138Inst Instance=new A195138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195139
{
public static readonly long[] Value={ 1L,1L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,2L,6L,2L,8L,8L,8L,8L,8L,8L,8L,8L,4L,4L,8L,8L,8L,8L,8L,8L,8L,8L,8L,4L,4L,6L,6L,4L,4L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,6L,6L,6L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195139Inst : IEnumerable<long>
{
public static readonly long[] Value=A195139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195139.Bytes);
public long this[int i]=>Value[i];

public static A195139Inst Instance=new A195139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195140
{
public static readonly long[] Value={ 0L,1L,5L,3L,10L,5L,15L,7L,20L,9L,25L,11L,30L,13L,35L,15L,40L,17L,45L,19L,50L,21L,55L,23L,60L,25L,65L,27L,70L,29L,75L,31L,80L,33L,85L,35L,90L,37L,95L,39L,100L,41L,105L,43L,110L,45L,115L,47L,120L,49L,125L,51L,130L,53L,135L,55L,140L,57L,145L,59L,150L,61L,155L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195140Inst : IEnumerable<long>
{
public static readonly long[] Value=A195140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195140.Bytes);
public long this[int i]=>Value[i];

public static A195140Inst Instance=new A195140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195141
{
public static readonly long[] Value={ 1L,1L,1L,1L,8L,8L,8L,8L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,8L,8L,5L,5L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195141Inst : IEnumerable<long>
{
public static readonly long[] Value=A195141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195141.Bytes);
public long this[int i]=>Value[i];

public static A195141Inst Instance=new A195141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195142
{
public static readonly long[] Value={ 0L,1L,10L,21L,40L,61L,90L,121L,160L,201L,250L,301L,360L,421L,490L,561L,640L,721L,810L,901L,1000L,1101L,1210L,1321L,1440L,1561L,1690L,1821L,1960L,2101L,2250L,2401L,2560L,2721L,2890L,3061L,3240L,3421L,3610L,3801L,4000L,4201L,4410L,4621L,4840L,5061L,5290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195142Inst : IEnumerable<long>
{
public static readonly long[] Value=A195142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195142.Bytes);
public long this[int i]=>Value[i];

public static A195142Inst Instance=new A195142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195143
{
public static readonly long[] Value={ 0L,1L,12L,25L,48L,73L,108L,145L,192L,241L,300L,361L,432L,505L,588L,673L,768L,865L,972L,1081L,1200L,1321L,1452L,1585L,1728L,1873L,2028L,2185L,2352L,2521L,2700L,2881L,3072L,3265L,3468L,3673L,3888L,4105L,4332L,4561L,4800L,5041L,5292L,5545L,5808L,6073L,6348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195143Inst : IEnumerable<long>
{
public static readonly long[] Value=A195143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195143.Bytes);
public long this[int i]=>Value[i];

public static A195143Inst Instance=new A195143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195144
{
public static readonly long[] Value={ 5L,8L,895799L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195144Inst : IEnumerable<long>
{
public static readonly long[] Value=A195144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195144.Bytes);
public long this[int i]=>Value[i];

public static A195144Inst Instance=new A195144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195145
{
public static readonly long[] Value={ 0L,1L,14L,29L,56L,85L,126L,169L,224L,281L,350L,421L,504L,589L,686L,785L,896L,1009L,1134L,1261L,1400L,1541L,1694L,1849L,2016L,2185L,2366L,2549L,2744L,2941L,3150L,3361L,3584L,3809L,4046L,4285L,4536L,4789L,5054L,5321L,5600L,5881L,6174L,6469L,6776L,7085L,7406L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195145Inst : IEnumerable<long>
{
public static readonly long[] Value=A195145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195145.Bytes);
public long this[int i]=>Value[i];

public static A195145Inst Instance=new A195145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195146
{
public static readonly long[] Value={ 0L,1L,16L,33L,64L,97L,144L,193L,256L,321L,400L,481L,576L,673L,784L,897L,1024L,1153L,1296L,1441L,1600L,1761L,1936L,2113L,2304L,2497L,2704L,2913L,3136L,3361L,3600L,3841L,4096L,4353L,4624L,4897L,5184L,5473L,5776L,6081L,6400L,6721L,7056L,7393L,7744L,8097L,8464L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195146Inst : IEnumerable<long>
{
public static readonly long[] Value=A195146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195146.Bytes);
public long this[int i]=>Value[i];

public static A195146Inst Instance=new A195146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195147
{
public static readonly long[] Value={ 0L,1L,18L,37L,72L,109L,162L,217L,288L,361L,450L,541L,648L,757L,882L,1009L,1152L,1297L,1458L,1621L,1800L,1981L,2178L,2377L,2592L,2809L,3042L,3277L,3528L,3781L,4050L,4321L,4608L,4897L,5202L,5509L,5832L,6157L,6498L,6841L,7200L,7561L,7938L,8317L,8712L,9109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195147Inst : IEnumerable<long>
{
public static readonly long[] Value=A195147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195147.Bytes);
public long this[int i]=>Value[i];

public static A195147Inst Instance=new A195147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195148
{
public static readonly long[] Value={ 0L,1L,20L,41L,80L,121L,180L,241L,320L,401L,500L,601L,720L,841L,980L,1121L,1280L,1441L,1620L,1801L,2000L,2201L,2420L,2641L,2880L,3121L,3380L,3641L,3920L,4201L,4500L,4801L,5120L,5441L,5780L,6121L,6480L,6841L,7220L,7601L,8000L,8401L,8820L,9241L,9680L,10121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195148Inst : IEnumerable<long>
{
public static readonly long[] Value=A195148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195148.Bytes);
public long this[int i]=>Value[i];

public static A195148Inst Instance=new A195148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195149
{
public static readonly long[] Value={ 0L,1L,22L,45L,88L,133L,198L,265L,352L,441L,550L,661L,792L,925L,1078L,1233L,1408L,1585L,1782L,1981L,2200L,2421L,2662L,2905L,3168L,3433L,3718L,4005L,4312L,4621L,4950L,5281L,5632L,5985L,6358L,6733L,7128L,7525L,7942L,8361L,8800L,9241L,9702L,10165L,10648L,11133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195149Inst : IEnumerable<long>
{
public static readonly long[] Value=A195149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195149.Bytes);
public long this[int i]=>Value[i];

public static A195149Inst Instance=new A195149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195150
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,1L,2L,2L,2L,1L,2L,1L,2L,3L,3L,1L,3L,1L,3L,3L,2L,1L,4L,2L,2L,3L,4L,1L,4L,1L,4L,3L,2L,3L,5L,1L,2L,3L,5L,1L,4L,1L,4L,5L,2L,1L,6L,2L,4L,3L,4L,1L,5L,3L,5L,3L,2L,1L,6L,1L,2L,5L,5L,3L,5L,1L,4L,3L,6L,1L,7L,1L,2L,5L,4L,3L,5L,1L,7L,4L,2L,1L,7L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195150Inst : IEnumerable<long>
{
public static readonly long[] Value=A195150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195150.Bytes);
public long this[int i]=>Value[i];

public static A195150Inst Instance=new A195150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195151
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,0L,3L,1L,1L,0L,0L,3L,2L,1L,0L,5L,2L,3L,3L,1L,0L,0L,5L,4L,3L,4L,1L,0L,7L,3L,5L,6L,3L,5L,1L,0L,0L,7L,6L,5L,8L,3L,6L,1L,0L,9L,4L,7L,9L,5L,10L,3L,7L,1L,0L,0L,9L,8L,7L,12L,5L,12L,3L,8L,1L,0L,11L,5L,9L,12L,7L,15L,5L,14L,3L,9L,1L,0L,0L,11L,10L,9L,16L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195151Inst : IEnumerable<long>
{
public static readonly long[] Value=A195151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195151.Bytes);
public long this[int i]=>Value[i];

public static A195151Inst Instance=new A195151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195152
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,0L,4L,2L,1L,0L,4L,5L,3L,1L,0L,9L,7L,6L,4L,1L,0L,9L,12L,10L,7L,5L,1L,0L,16L,15L,15L,13L,8L,6L,1L,0L,16L,22L,21L,18L,16L,9L,7L,1L,0L,25L,26L,28L,27L,21L,19L,10L,8L,1L,0L,25L,35L,36L,34L,33L,24L,22L,11L,9L,1L,0L,36L,40L,45L,46L,40L,39L,27L,25L,12L,10L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195152Inst : IEnumerable<long>
{
public static readonly long[] Value=A195152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195152.Bytes);
public long this[int i]=>Value[i];

public static A195152Inst Instance=new A195152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195153
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,3L,7L,2L,8L,4L,9L,10L,5L,11L,12L,6L,13L,2L,4L,14L,3L,7L,15L,16L,5L,8L,17L,18L,3L,9L,19L,2L,6L,20L,10L,21L,22L,5L,7L,11L,23L,4L,24L,12L,25L,2L,8L,26L,3L,6L,13L,27L,28L,4L,9L,14L,29L,30L,3L,7L,15L,31L,2L,10L,32L,16L,33L,4L,6L,34L,5L,8L,11L,17L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195153Inst : IEnumerable<long>
{
public static readonly long[] Value=A195153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195153.Bytes);
public long this[int i]=>Value[i];

public static A195153Inst Instance=new A195153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195154
{
public static readonly long[] Value={ 1L,1L,-2L,6L,-30L,184L,-1294L,10034L,-83908L,746006L,-6983600L,68360302L,-696122684L,7345561204L,-80074813040L,899590031932L,-10394864935860L,123344285904634L,-1500938535372826L,18709376854618500L,-238664936823622052L,3113060999816038350L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195154Inst : IEnumerable<long>
{
public static readonly long[] Value=A195154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195154.Bytes);
public long this[int i]=>Value[i];

public static A195154Inst Instance=new A195154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195155
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,3L,1L,2L,1L,2L,1L,4L,1L,2L,1L,2L,1L,3L,1L,3L,1L,2L,1L,4L,1L,2L,1L,2L,1L,4L,1L,2L,1L,2L,1L,4L,1L,2L,1L,3L,1L,4L,1L,2L,1L,2L,1L,4L,1L,2L,1L,2L,1L,3L,1L,3L,1L,2L,1L,6L,1L,2L,1L,2L,1L,3L,1L,2L,1L,2L,1L,5L,1L,2L,1L,2L,1L,3L,1L,3L,1L,2L,1L,5L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195155Inst : IEnumerable<long>
{
public static readonly long[] Value=A195155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195155.Bytes);
public long this[int i]=>Value[i];

public static A195155Inst Instance=new A195155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195156
{
public static readonly BigInteger[] Value={ 0L,5L,85L,1365L,21845L,349525L,5592405L,89478485L,1431655765L,22906492245L,366503875925L,5864062014805L,93824992236885L,1501199875790165L,24019198012642645L,384307168202282325L,6148914691236517205L,BigInteger.Parse("98382635059784275285"),BigInteger.Parse("1574122160956548404565") };
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
public class A195156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195156Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195156.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195156.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195156Inst Instance=new A195156Inst();

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