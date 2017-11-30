using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A236929
{
public static readonly long[] Value={ 1L,4L,4L,0L,4L,12L,16L,16L,4L,20L,44L,16L,16L,24L,32L,64L,4L,8L,52L,16L,44L,32L,48L,48L,16L,84L,56L,64L,32L,56L,176L,32L,4L,64L,72L,112L,52L,56L,80L,64L,44L,72L,128L,32L,48L,188L,96L,48L,16L,68L,244L,128L,56L,56L,160L,176L,32L,128L,120L,112L,176L,88L,128L,144L,4L,200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A236929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A236929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A236929Inst : IEnumerable<long>
{
public static readonly long[] Value=A236929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A236929.Bytes);
public long this[int i]=>Value[i];

public static A236929Inst Instance=new A236929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A236930
{
public static readonly long[] Value={ 1L,6L,12L,8L,6L,26L,36L,24L,28L,42L,72L,72L,8L,48L,108L,48L,54L,64L,84L,120L,26L,72L,144L,88L,84L,126L,216L,80L,24L,180L,156L,192L,92L,96L,288L,144L,42L,144L,240L,144L,168L,252L,144L,168L,72L,182L,396L,184L,72L,258L,372L,192L,48L,208L,360L,312L,252L,160L,360L,360L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A236930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A236930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A236930Inst : IEnumerable<long>
{
public static readonly long[] Value=A236930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A236930.Bytes);
public long this[int i]=>Value[i];

public static A236930Inst Instance=new A236930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A236931
{
public static readonly long[] Value={ 1L,6L,12L,8L,6L,24L,26L,12L,36L,46L,36L,72L,56L,24L,72L,60L,54L,96L,52L,72L,120L,48L,36L,96L,98L,90L,144L,144L,60L,120L,144L,60L,180L,172L,96L,240L,142L,72L,192L,96L,132L,288L,180L,120L,216L,168L,144L,192L,152L,162L,276L,256L,120L,216L,210L,120L,264L,256L,180L,360L,300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A236931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A236931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A236931Inst : IEnumerable<long>
{
public static readonly long[] Value=A236931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A236931.Bytes);
public long this[int i]=>Value[i];

public static A236931Inst Instance=new A236931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A236932
{
public static readonly long[] Value={ 1L,6L,12L,8L,6L,24L,24L,2L,24L,54L,40L,36L,56L,72L,48L,24L,66L,96L,84L,40L,72L,144L,24L,12L,120L,102L,120L,80L,98L,132L,72L,64L,84L,240L,160L,48L,198L,180L,120L,72L,136L,240L,240L,84L,84L,312L,120L,96L,248L,246L,180L,96L,216L,228L,240L,80L,156L,360L,216L,120L,168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A236932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A236932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A236932Inst : IEnumerable<long>
{
public static readonly long[] Value=A236932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A236932.Bytes);
public long this[int i]=>Value[i];

public static A236932Inst Instance=new A236932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A236933
{
public static readonly long[] Value={ 1L,6L,12L,8L,6L,24L,24L,0L,12L,30L,24L,24L,10L,36L,72L,16L,18L,96L,84L,24L,48L,108L,72L,48L,40L,78L,168L,32L,12L,168L,120L,48L,60L,144L,96L,48L,78L,84L,216L,64L,24L,240L,144L,24L,48L,168L,144L,96L,70L,114L,252L,64L,84L,312L,240L,48L,120L,252L,168L,120L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A236933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A236933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A236933Inst : IEnumerable<long>
{
public static readonly long[] Value=A236933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A236933.Bytes);
public long this[int i]=>Value[i];

public static A236933Inst Instance=new A236933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A236934
{
public static readonly long[] Value={ 1L,0L,2L,0L,0L,4L,8L,4L,0L,0L,32L,64L,80L,64L,32L,0L,0L,544L,1088L,1504L,1664L,1504L,1088L,544L,0L,0L,15872L,31744L,45440L,54784L,58112L,54784L,45440L,31744L,15872L,0L,0L,707584L,1415168L,2059264L,2576384L,2911744L,3027968L,2911744L,2576384L,2059264L,1415168L,707584L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A236934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A236934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A236934Inst : IEnumerable<long>
{
public static readonly long[] Value=A236934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A236934.Bytes);
public long this[int i]=>Value[i];

public static A236934Inst Instance=new A236934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A236935
{
public static readonly long[] Value={ 1L,0L,-1L,-1L,-1L,0L,0L,1L,2L,2L,5L,5L,4L,2L,0L,0L,-5L,-10L,-14L,-16L,-16L,-61L,-61L,-56L,-46L,-32L,-16L,0L,0L,61L,122L,178L,224L,256L,272L,272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A236935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A236935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A236935Inst : IEnumerable<long>
{
public static readonly long[] Value=A236935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A236935.Bytes);
public long this[int i]=>Value[i];

public static A236935Inst Instance=new A236935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A236936
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,1L,3L,1L,6L,1L,6L,1L,10L,1L,10L,1L,15L,1L,15L,30L,5L,1L,1L,21L,96L,74L,14L,1L,21L,221L,413L,174L,1L,28L,417L,1525L,1234L,1L,28L,705L,4290L,6124L,1L,36L,1107L,10269L,23259L,1L,36L,1638L,21630L,73204L,1L,45L,2334L,41790L,199436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A236936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A236936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A236936Inst : IEnumerable<long>
{
public static readonly long[] Value=A236936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A236936.Bytes);
public long this[int i]=>Value[i];

public static A236936Inst Instance=new A236936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A236937
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,3L,3L,1L,7L,1L,7L,15L,22L,1L,42L,1L,56L,56L,30L,1L,176L,176L,56L,385L,297L,1L,627L,1L,1002L,490L,176L,1255L,2436L,1L,297L,1255L,4565L,1L,5604L,1L,4565L,12310L,792L,1L,21637L,14883L,26015L,6842L,14883L,1L,63261L,31185L,63261L,14883L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A236937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A236937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A236937Inst : IEnumerable<long>
{
public static readonly long[] Value=A236937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A236937.Bytes);
public long this[int i]=>Value[i];

public static A236937Inst Instance=new A236937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A236938
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,11L,11L,3L,1L,15L,1L,7L,15L,135L,1L,101L,1L,101L,56L,30L,1L,490L,627L,56L,1575L,490L,1L,627L,1L,5604L,490L,176L,1255L,6842L,1L,297L,1255L,10143L,1L,5604L,1L,6842L,21637L,792L,1L,63261L,53174L,63261L,6842L,21637L,1L,173525L,31185L,124754L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A236938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A236938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A236938Inst : IEnumerable<long>
{
public static readonly long[] Value=A236938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A236938.Bytes);
public long this[int i]=>Value[i];

public static A236938Inst Instance=new A236938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A236939
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,1L,3L,1L,6L,1L,6L,1L,10L,1L,10L,1L,15L,1L,15L,1L,21L,36L,6L,1L,1L,21L,113L,80L,14L,1L,28L,261L,461L,174L,1L,28L,483L,1665L,1234L,1L,36L,819L,4725L,6124L,1L,36L,1266L,11193L,23259L,1L,45L,1878L,23646L,73204L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A236939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A236939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A236939Inst : IEnumerable<long>
{
public static readonly long[] Value=A236939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A236939.Bytes);
public long this[int i]=>Value[i];

public static A236939Inst Instance=new A236939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A236940
{
public static readonly long[] Value={ 3L,13L,19L,43L,79L,109L,313L,379L,613L,709L,1171L,1213L,1399L,1543L,1693L,1759L,1861L,1933L,2089L,2239L,2341L,2371L,2503L,2521L,2731L,2749L,3001L,3061L,3229L,3433L,3571L,3739L,3769L,4219L,4801L,4933L,4951L,4993L,5011L,5023L,5209L,5281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A236940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A236940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A236940Inst : IEnumerable<long>
{
public static readonly long[] Value=A236940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A236940.Bytes);
public long this[int i]=>Value[i];

public static A236940Inst Instance=new A236940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A236941
{
public static readonly BigInteger[] Value={ 256L,112888L,534626674L,33887916009662L,BigInteger.Parse("21767431884019104260"),BigInteger.Parse("160577378511458058360114308"),BigInteger.Parse("12541685260260879735250182260062400"),BigInteger.Parse("10826931903978835718436872493300000532953496") };
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
public class A236941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A236941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A236941Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A236941.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A236941.Bytes);
public BigInteger this[int i]=>Value[i];

public static A236941Inst Instance=new A236941Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A236942
{
public static readonly long[] Value={ 256L,2796L,30698L,357316L,4195956L,50119046L,601976968L,7271574636L,88068458546L,1068829320076L,12986262880788L,157905941911406L,1920929508184336L,23375169249987756L,284496769631574458L,3462985011143368276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A236942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A236942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A236942Inst : IEnumerable<long>
{
public static readonly long[] Value=A236942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A236942.Bytes);
public long this[int i]=>Value[i];

public static A236942Inst Instance=new A236942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A236943
{
public static readonly BigInteger[] Value={ 2796L,112888L,4301002L,178006252L,7270497452L,302691231316L,12569519212796L,524245234532960L,21854738428787466L,911985738401725660L,BigInteger.Parse("38053568649173120756"),BigInteger.Parse("1588184219431937362884"),BigInteger.Parse("66282825930461723853260") };
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
public class A236943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A236943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A236943Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A236943.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A236943.Bytes);
public BigInteger this[int i]=>Value[i];

public static A236943Inst Instance=new A236943Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A236960
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,16L,79L,720L,10735L,211802L,4968491L,132655760L,3943593218L,128724395888L,4567299614131L,174792721389278L,7170679832812100L,313729852611817418L,14576333351368836005UL,BigInteger.Parse("716547887877448952206"),BigInteger.Parse("37150482490370675725494"),BigInteger.Parse("2025776434511141860123174"),BigInteger.Parse("115890536127998971200900825") };
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
public class A236960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A236960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A236960Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A236960.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A236960.Bytes);
public BigInteger this[int i]=>Value[i];

public static A236960Inst Instance=new A236960Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A236961
{
public static readonly long[] Value={ 1L,1L,1L,4L,2L,1L,27L,11L,3L,1L,256L,94L,21L,4L,1L,3125L,1076L,217L,34L,5L,1L,46656L,15362L,2910L,412L,50L,6L,1L,823543L,262171L,47598L,6333L,695L,69L,7L,1L,16777216L,5198778L,915221L,116768L,12045L,1082L,91L,8L,1L,387420489L,117368024L,20182962L,2498414L,247151L,20871L,1589L,116L,9L,1L,10000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A236961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A236961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A236961Inst : IEnumerable<long>
{
public static readonly long[] Value=A236961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A236961.Bytes);
public long this[int i]=>Value[i];

public static A236961Inst Instance=new A236961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A236962
{
public static readonly BigInteger[] Value={ 1L,2L,11L,94L,1076L,15362L,262171L,5198778L,117368024L,2970653234L,83287512901L,2561682696970L,85748218327188L,3102969248315842L,120702002794347559L,5022388886172728830L,BigInteger.Parse("222594275691025065632"),BigInteger.Parse("10468834006648393288830"),BigInteger.Parse("520740264878058965274931"),BigInteger.Parse("27314609364943353454490482") };
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
public class A236962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A236962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A236962Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A236962.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A236962.Bytes);
public BigInteger this[int i]=>Value[i];

public static A236962Inst Instance=new A236962Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A236963
{
public static readonly BigInteger[] Value={ 1L,3L,21L,217L,2910L,47598L,915221L,20182962L,501463686L,13849394018L,420676546425L,13933516789491L,499667134001968L,19284476610918801L,796927418729315367L,BigInteger.Parse("35106627960374772536"),BigInteger.Parse("1642235046999495643086"),BigInteger.Parse("81296320098443729853915"),BigInteger.Parse("4245930159553383360368993") };
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
public class A236963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A236963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A236963Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A236963.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A236963.Bytes);
public BigInteger this[int i]=>Value[i];

public static A236963Inst Instance=new A236963Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A236964
{
public static readonly BigInteger[] Value={ 1L,4L,34L,412L,6333L,116768L,2498414L,60678776L,1646370324L,49304407416L,1614242231610L,57334041759484L,2194946060935833L,90082535627196868L,3944898781246389318L,BigInteger.Parse("183589807833908851744"),BigInteger.Parse("9047581726126772883962"),BigInteger.Parse("470671514968767824048292") };
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
public class A236964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A236964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A236964Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A236964.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A236964.Bytes);
public BigInteger this[int i]=>Value[i];

public static A236964Inst Instance=new A236964Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A236965
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,3L,4L,9L,11L,7L,15L,9L,10L,21L,23L,13L,29L,15L,33L,35L,18L,39L,41L,22L,24L,25L,51L,53L,27L,28L,63L,65L,34L,69L,37L,75L,39L,81L,83L,43L,89L,45L,95L,48L,49L,99L,105L,111L,113L,57L,58L,119L,60L,125L,64L,131L,67L,135L,69L,70L,141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A236965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A236965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A236965Inst : IEnumerable<long>
{
public static readonly long[] Value=A236965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A236965.Bytes);
public long this[int i]=>Value[i];

public static A236965Inst Instance=new A236965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A236966
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,3L,2L,1L,3L,2L,1L,2L,2L,5L,6L,3L,4L,3L,5L,4L,5L,7L,9L,3L,5L,2L,10L,7L,7L,7L,7L,9L,5L,10L,4L,5L,7L,12L,11L,14L,6L,7L,5L,10L,9L,8L,5L,12L,15L,14L,8L,12L,11L,16L,12L,16L,9L,12L,10L,10L,14L,15L,10L,12L,14L,9L,10L,21L,9L,22L,21L,11L,9L,18L,24L,20L,17L,17L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A236966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A236966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A236966Inst : IEnumerable<long>
{
public static readonly long[] Value=A236966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A236966.Bytes);
public long this[int i]=>Value[i];

public static A236966Inst Instance=new A236966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A236967
{
public static readonly long[] Value={ 1L,12L,72L,324L,1296L,4860L,17496L,61236L,209952L,708588L,2361960L,7794468L,25509168L,82904796L,267846264L,860934420L,2754990144L,8781531084L,27894275208L,88331871492L,278942752080L,878669669052L,2761533245592L,8661172452084L,27113235502176L,84728860944300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A236967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A236967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A236967Inst : IEnumerable<long>
{
public static readonly long[] Value=A236967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A236967.Bytes);
public long this[int i]=>Value[i];

public static A236967Inst Instance=new A236967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A236968
{
public static readonly long[] Value={ 0L,1L,2L,2L,1L,2L,2L,3L,3L,1L,4L,4L,3L,5L,3L,1L,1L,4L,5L,6L,3L,1L,4L,4L,3L,2L,2L,3L,3L,5L,3L,6L,5L,1L,6L,1L,4L,6L,4L,1L,6L,7L,8L,6L,2L,2L,5L,8L,4L,4L,3L,3L,7L,8L,3L,5L,3L,4L,6L,7L,8L,9L,5L,2L,3L,2L,4L,7L,5L,2L,2L,6L,6L,8L,5L,1L,6L,2L,6L,7L,3L,3L,8L,8L,6L,5L,2L,5L,6L,9L,9L,5L,4L,1L,7L,2L,3L,9L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A236968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A236968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A236968Inst : IEnumerable<long>
{
public static readonly long[] Value=A236968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A236968.Bytes);
public long this[int i]=>Value[i];

public static A236968Inst Instance=new A236968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A236969
{
public static readonly long[] Value={ 3L,19L,31L,61L,67L,79L,97L,127L,307L,331L,367L,409L,457L,499L,571L,613L,631L,691L,709L,727L,733L,787L,829L,883L,991L,1063L,1087L,1093L,1213L,1297L,1303L,1327L,1423L,1471L,1549L,1567L,1693L,1699L,1723L,1747L,1777L,1783L,1801L,1987L,2011L,2053L,2083L,2143L,2161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A236969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A236969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A236969Inst : IEnumerable<long>
{
public static readonly long[] Value=A236969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A236969.Bytes);
public long this[int i]=>Value[i];

public static A236969Inst Instance=new A236969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A236970
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,3L,5L,6L,7L,13L,16L,19L,29L,38L,49L,72L,84L,108L,155L,195L,234L,331L,410L,501L,672L,824L,1006L,1341L,1621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A236970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A236970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A236970Inst : IEnumerable<long>
{
public static readonly long[] Value=A236970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A236970.Bytes);
public long this[int i]=>Value[i];

public static A236970Inst Instance=new A236970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A236971
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,2L,3L,3L,6L,7L,8L,11L,19L,21L,26L,31L,52L,66L,76L,88L,134L,169L,215L,251L,358L,412L,517L,639L,899L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A236971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A236971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A236971Inst : IEnumerable<long>
{
public static readonly long[] Value=A236971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A236971.Bytes);
public long this[int i]=>Value[i];

public static A236971Inst Instance=new A236971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A236972
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,2L,3L,3L,4L,7L,8L,9L,13L,14L,24L,29L,35L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A236972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A236972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A236972Inst : IEnumerable<long>
{
public static readonly long[] Value=A236972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A236972.Bytes);
public long this[int i]=>Value[i];

public static A236972Inst Instance=new A236972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A236973
{
public static readonly long[] Value={ 256L,1238L,6024L,31008L,160764L,849024L,4508480L,24165576L,130044760L,703680344L,3818629248L,20793569096L,113460899768L,620474785528L,3398136247248L,18637788171496L,102330560045880L,562407959930776L,3093358168328656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A236973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A236973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A236973Inst : IEnumerable<long>
{
public static readonly long[] Value=A236973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A236973.Bytes);
public long this[int i]=>Value[i];

public static A236973Inst Instance=new A236973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A236974
{
public static readonly long[] Value={ 1238L,9854L,76212L,635960L,5259146L,44597946L,376887360L,3222991866L,27520095568L,236568864708L,2032537681056L,17535842104346L,151294565594066L,1308890744507700L,11327010592855074L,98206225621215244L,851830423648769622L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A236974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A236974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A236974Inst : IEnumerable<long>
{
public static readonly long[] Value=A236974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A236974.Bytes);
public long this[int i]=>Value[i];

public static A236974Inst Instance=new A236974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A236975
{
public static readonly long[] Value={ 6024L,76212L,898820L,11850502L,151656752L,2025835812L,26630922346L,357532653542L,4755836009162L,64003985025026L,856771671964444L,11547914807203730L,155175900645701946L,2093923309757087606L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A236975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A236975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A236975Inst : IEnumerable<long>
{
public static readonly long[] Value=A236975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A236975.Bytes);
public long this[int i]=>Value[i];

public static A236975Inst Instance=new A236975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237184
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,2L,0L,2L,1L,3L,1L,3L,1L,3L,0L,4L,2L,4L,2L,2L,2L,5L,1L,3L,3L,3L,1L,5L,3L,1L,2L,4L,3L,5L,2L,3L,4L,4L,1L,7L,3L,4L,4L,4L,2L,6L,2L,5L,4L,4L,2L,7L,3L,2L,4L,5L,3L,8L,2L,2L,4L,5L,2L,7L,2L,5L,4L,4L,3L,6L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237184Inst : IEnumerable<long>
{
public static readonly long[] Value=A237184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237184.Bytes);
public long this[int i]=>Value[i];

public static A237184Inst Instance=new A237184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237185
{
public static readonly long[] Value={ 9L,4L,9L,7L,6L,5L,7L,1L,5L,3L,8L,1L,6L,3L,8L,6L,5L,9L,9L,9L,4L,4L,0L,6L,7L,1L,3L,5L,8L,5L,3L,8L,7L,9L,2L,2L,4L,3L,4L,6L,3L,0L,0L,7L,0L,8L,2L,8L,2L,6L,0L,9L,7L,5L,3L,0L,2L,8L,3L,4L,2L,4L,8L,5L,9L,6L,5L,1L,2L,1L,2L,2L,1L,6L,4L,4L,8L,1L,9L,6L,6L,4L,0L,2L,7L,1L,6L,6L,4L,9L,8L,0L,8L,6L,2L,6L,4L,0L,5L,2L,3L,4L,1L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237185Inst : IEnumerable<long>
{
public static readonly long[] Value=A237185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237185.Bytes);
public long this[int i]=>Value[i];

public static A237185Inst Instance=new A237185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237186
{
public static readonly long[] Value={ 3L,1L,2L,9L,6L,1L,7L,9L,6L,2L,0L,7L,7L,8L,6L,5L,9L,0L,7L,4L,5L,2L,7L,6L,6L,0L,4L,3L,7L,7L,7L,3L,7L,2L,3L,0L,6L,5L,1L,0L,3L,5L,9L,0L,3L,7L,7L,2L,9L,7L,8L,7L,7L,5L,3L,2L,5L,0L,4L,9L,4L,0L,4L,5L,7L,9L,9L,2L,5L,7L,9L,0L,9L,0L,7L,2L,4L,4L,6L,9L,6L,6L,0L,1L,1L,9L,3L,3L,7L,5L,6L,0L,1L,5L,1L,7L,3L,3L,1L,6L,3L,2L,5L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237186Inst : IEnumerable<long>
{
public static readonly long[] Value=A237186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237186.Bytes);
public long this[int i]=>Value[i];

public static A237186Inst Instance=new A237186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237187
{
public static readonly BigInteger[] Value={ 1L,11L,627L,154869L,156882297L,640550418651L,10485169802898219L,BigInteger.Parse("686977840316088410661"),BigInteger.Parse("180074066392854674644514625"),BigInteger.Parse("188817562686559733371879032616875"),BigInteger.Parse("791953915642546445046738160803339091875"),BigInteger.Parse("13286762105932889434920130050786333382153423125") };
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
public class A237187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237187Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A237187.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A237187.Bytes);
public BigInteger this[int i]=>Value[i];

public static A237187Inst Instance=new A237187Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237188
{
public static readonly long[] Value={ 5L,29L,2549L,6269L,41609L,259379L,418349L,492059L,514049L,521879L,819029L,1171199L,1659809L,1994339L,2014139L,2325509L,2327399L,2392139L,2420699L,2481179L,2844269L,3142829L,3393359L,3637169L,3990029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237188Inst : IEnumerable<long>
{
public static readonly long[] Value=A237188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237188.Bytes);
public long this[int i]=>Value[i];

public static A237188Inst Instance=new A237188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237189
{
public static readonly long[] Value={ 330L,1530L,3060L,4260L,4950L,6840L,10830L,15390L,18120L,23010L,25410L,26040L,31770L,33300L,40110L,41490L,45060L,49830L,53880L,59340L,65850L,70140L,73770L,78540L,88740L,95460L,96930L,109470L,111720L,112620L,117720L,131310L,133200L,134730L,135300L,150150L,165900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237189Inst : IEnumerable<long>
{
public static readonly long[] Value=A237189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237189.Bytes);
public long this[int i]=>Value[i];

public static A237189Inst Instance=new A237189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237190
{
public static readonly long[] Value={ 10830L,25410L,26040L,88740L,165900L,196560L,211050L,224400L,230280L,247710L,268500L,268920L,375480L,377490L,420330L,451410L,494340L,512820L,592620L,604170L,735750L,751290L,765780L,799170L,808080L,952680L,975660L,1053690L,1064190L,1132860L,1156170L,1532370L,1559580L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237190Inst : IEnumerable<long>
{
public static readonly long[] Value=A237190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237190.Bytes);
public long this[int i]=>Value[i];

public static A237190Inst Instance=new A237190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237191
{
public static readonly long[] Value={ 2L,520360L,14320216L,30527896L,119668186L,120506050L,131448430L,142493926L,211158676L,254574706L,276368680L,306216940L,315122416L,421132180L,472731400L,506213890L,540271396L,616078786L,629310346L,646308250L,741176296L,752897860L,800587480L,851425030L,897745996L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237191Inst : IEnumerable<long>
{
public static readonly long[] Value=A237191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237191.Bytes);
public long this[int i]=>Value[i];

public static A237191Inst Instance=new A237191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237192
{
public static readonly long[] Value={ 1L,5L,3L,8L,4L,7L,7L,8L,0L,2L,7L,2L,7L,9L,4L,4L,2L,5L,3L,1L,5L,6L,6L,5L,9L,9L,8L,7L,3L,2L,2L,5L,4L,1L,4L,0L,2L,8L,8L,1L,7L,9L,1L,9L,8L,9L,8L,2L,3L,9L,2L,7L,7L,0L,6L,3L,3L,9L,7L,4L,3L,0L,1L,4L,8L,5L,8L,1L,6L,2L,6L,9L,3L,6L,1L,4L,6L,8L,1L,5L,7L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237192Inst : IEnumerable<long>
{
public static readonly long[] Value=A237192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237192.Bytes);
public long this[int i]=>Value[i];

public static A237192Inst Instance=new A237192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237193
{
public static readonly long[] Value={ 9L,0L,9L,6L,6L,4L,8L,4L,5L,6L,5L,3L,2L,1L,9L,5L,1L,0L,0L,5L,5L,1L,3L,0L,2L,8L,7L,1L,9L,0L,0L,8L,4L,9L,6L,8L,1L,7L,6L,3L,8L,0L,3L,3L,8L,5L,4L,9L,1L,3L,9L,6L,6L,3L,0L,2L,2L,5L,2L,0L,4L,2L,2L,8L,5L,2L,3L,8L,4L,7L,0L,3L,4L,4L,4L,7L,7L,2L,0L,0L,3L,8L,9L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237193Inst : IEnumerable<long>
{
public static readonly long[] Value=A237193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237193.Bytes);
public long this[int i]=>Value[i];

public static A237193Inst Instance=new A237193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237194
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,2L,1L,0L,1L,2L,1L,1L,1L,1L,3L,2L,2L,1L,2L,2L,4L,2L,2L,2L,2L,2L,2L,5L,3L,2L,3L,1L,3L,2L,3L,6L,3L,3L,4L,3L,3L,4L,3L,3L,8L,5L,4L,5L,4L,3L,4L,5L,4L,5L,10L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,12L,7L,6L,7L,7L,7L,4L,7L,7L,7L,6L,7L,15L,8L,7L,8L,8L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237194Inst : IEnumerable<long>
{
public static readonly long[] Value=A237194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237194.Bytes);
public long this[int i]=>Value[i];

public static A237194Inst Instance=new A237194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237195
{
public static readonly BigInteger[] Value={ 1L,2L,7L,52L,846L,28628L,1928768L,255610528L,66822534992L,34632302913632L,35711543058158592L,BigInteger.Parse("73426371674544520192"),BigInteger.Parse("301419451958411673103360"),BigInteger.Parse("2472252535617096234970201088"),BigInteger.Parse("40532629372281642451697543062528"),BigInteger.Parse("1328660058258732602631909956943781888") };
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
public class A237195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237195Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A237195.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A237195.Bytes);
public BigInteger this[int i]=>Value[i];

public static A237195Inst Instance=new A237195Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237196
{
public static readonly long[] Value={ 4L,5L,7L,1L,4L,1L,5L,1L,1L,2L,1L,1L,9L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,6L,1L,8L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,2L,1L,3L,1L,2L,1L,1L,1L,4L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,3L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237196Inst : IEnumerable<long>
{
public static readonly long[] Value=A237196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237196.Bytes);
public long this[int i]=>Value[i];

public static A237196Inst Instance=new A237196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237197
{
public static readonly long[] Value={ 4L,3L,3L,6L,3L,1L,5L,8L,1L,7L,2L,0L,8L,9L,4L,0L,0L,8L,3L,5L,6L,4L,8L,7L,4L,3L,0L,5L,7L,1L,8L,3L,0L,0L,6L,1L,5L,4L,7L,7L,5L,5L,6L,2L,7L,3L,5L,0L,5L,7L,2L,2L,4L,3L,7L,1L,0L,2L,4L,1L,6L,2L,5L,0L,4L,2L,9L,3L,3L,7L,0L,9L,3L,1L,7L,2L,4L,5L,0L,0L,4L,4L,2L,7L,8L,5L,8L,9L,3L,8L,2L,7L,1L,4L,5L,5L,7L,5L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237197Inst : IEnumerable<long>
{
public static readonly long[] Value=A237197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237197.Bytes);
public long this[int i]=>Value[i];

public static A237197Inst Instance=new A237197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237198
{
public static readonly long[] Value={ 4L,7L,5L,9L,6L,2L,6L,6L,4L,2L,3L,3L,9L,6L,8L,8L,0L,8L,6L,6L,6L,7L,2L,3L,0L,2L,1L,7L,6L,4L,5L,1L,4L,1L,0L,0L,1L,9L,1L,7L,4L,7L,8L,5L,7L,9L,1L,8L,0L,8L,6L,8L,6L,8L,3L,1L,1L,0L,3L,9L,3L,2L,1L,5L,0L,1L,3L,0L,7L,6L,8L,6L,9L,1L,0L,5L,1L,1L,1L,4L,4L,8L,3L,3L,5L,2L,4L,2L,0L,2L,9L,5L,3L,1L,5L,0L,8L,2L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237198Inst : IEnumerable<long>
{
public static readonly long[] Value=A237198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237198.Bytes);
public long this[int i]=>Value[i];

public static A237198Inst Instance=new A237198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237199
{
public static readonly long[] Value={ 1L,1L,0L,0L,2L,4L,7L,8L,3L,9L,7L,0L,9L,1L,5L,0L,3L,8L,7L,1L,5L,5L,7L,0L,0L,6L,3L,6L,9L,8L,7L,0L,2L,4L,3L,8L,0L,0L,3L,6L,9L,3L,7L,9L,1L,3L,8L,9L,4L,1L,9L,6L,7L,1L,2L,8L,3L,1L,5L,1L,9L,0L,0L,5L,0L,1L,8L,8L,1L,6L,1L,6L,7L,5L,3L,4L,6L,4L,5L,1L,4L,4L,8L,6L,4L,1L,7L,4L,9L,7L,4L,3L,3L,5L,7L,7L,5L,2L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237199Inst : IEnumerable<long>
{
public static readonly long[] Value=A237199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237199.Bytes);
public long this[int i]=>Value[i];

public static A237199Inst Instance=new A237199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237232
{
public static readonly long[] Value={ 28912L,120540L,269844L,671080L,1737372L,5016852L,13078228L,34663620L,93075252L,252437984L,674728104L,1815877108L,4898412064L,13182357508L,35265033144L,95378791936L,256131894912L,690260009684L,1852770334916L,5004415058468L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237232Inst : IEnumerable<long>
{
public static readonly long[] Value=A237232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237232.Bytes);
public long this[int i]=>Value[i];

public static A237232Inst Instance=new A237232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237233
{
public static readonly long[] Value={ 100008L,401520L,926086L,1919288L,5299502L,13078228L,42143930L,92484308L,270710424L,638608676L,1940008986L,4500620876L,13454873260L,31731133484L,95618929690L,223781988876L,667596360496L,1582932137332L,4750121115990L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237233Inst : IEnumerable<long>
{
public static readonly long[] Value=A237233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237233.Bytes);
public long this[int i]=>Value[i];

public static A237233Inst Instance=new A237233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237234
{
public static readonly long[] Value={ 81L,268L,268L,928L,984L,928L,2784L,3284L,3284L,2784L,9628L,10888L,12014L,10888L,9628L,28912L,36180L,29456L,29456L,36180L,28912L,100008L,120540L,97862L,83436L,97862L,120540L,100008L,300256L,401520L,269844L,233536L,233536L,269844L,401520L,300256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237234Inst : IEnumerable<long>
{
public static readonly long[] Value=A237234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237234.Bytes);
public long this[int i]=>Value[i];

public static A237234Inst Instance=new A237234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237235
{
public static readonly long[] Value={ 256L,1280L,6976L,40064L,234752L,1395200L,8344576L,50202624L,302927872L,1834229760L,11124686848L,67635806208L,411596816384L,2509448019968L,15307122147328L,93512310194176L,571374872559616L,3495701365391360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237235Inst : IEnumerable<long>
{
public static readonly long[] Value=A237235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237235.Bytes);
public long this[int i]=>Value[i];

public static A237235Inst Instance=new A237235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237236
{
public static readonly long[] Value={ 1280L,10304L,91744L,853152L,8036672L,76825568L,738844928L,7176050400L,69914628864L,686426761312L,6746879296128L,66745483168480L,660133372477184L,6566736980062048L,65246176244780416L,651787243233111008L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237236Inst : IEnumerable<long>
{
public static readonly long[] Value=A237236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237236.Bytes);
public long this[int i]=>Value[i];

public static A237236Inst Instance=new A237236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237237
{
public static readonly ulong[] Value={ 6976L,91744L,1301304L,19274172L,289676104L,4449131420L,68828263944L,1081186864940L,17018044573704L,271159929187820L,4315151645329416L,69417325448052484L,1113035036852046440L,18031255452906128548UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237237Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A237237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237237.Bytes);
public ulong this[int i]=>Value[i];

public static A237237Inst Instance=new A237237Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237238
{
public static readonly BigInteger[] Value={ 40064L,853152L,19274172L,459119016L,11137777044L,278128391716L,6990394415904L,179301038336988L,4594600424879136L,119752730611783572L,3105297614948039160L,BigInteger.Parse("81825606349267966684"),BigInteger.Parse("2139714241242339347104"),BigInteger.Parse("56865117527802306088364") };
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
public class A237238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237238Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A237238.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A237238.Bytes);
public BigInteger this[int i]=>Value[i];

public static A237238Inst Instance=new A237238Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237239
{
public static readonly BigInteger[] Value={ 234752L,8036672L,289676104L,11137777044L,437033830120L,17747542016236L,723439724838368L,30208726334780288L,1255132450145132744L,BigInteger.Parse("53264179237458371824"),BigInteger.Parse("2238991983162295268128"),BigInteger.Parse("96118886517087816279516") };
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
public class A237239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237239Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A237239.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A237239.Bytes);
public BigInteger this[int i]=>Value[i];

public static A237239Inst Instance=new A237239Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237240
{
public static readonly BigInteger[] Value={ 1395200L,76825568L,4449131420L,278128391716L,17747542016236L,1177910661769924L,78165741582154896L,5337750233892595716L,BigInteger.Parse("360992760535969700540"),BigInteger.Parse("25075909437876022341752"),BigInteger.Parse("1716837925193150285848132") };
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
public class A237240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237240Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A237240.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A237240.Bytes);
public BigInteger this[int i]=>Value[i];

public static A237240Inst Instance=new A237240Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237241
{
public static readonly long[] Value={ 256L,1280L,1280L,6976L,10304L,6976L,40064L,91744L,91744L,40064L,234752L,853152L,1301304L,853152L,234752L,1395200L,8036672L,19274172L,19274172L,8036672L,1395200L,8344576L,76825568L,289676104L,459119016L,289676104L,76825568L,8344576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237241Inst : IEnumerable<long>
{
public static readonly long[] Value=A237241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237241.Bytes);
public long this[int i]=>Value[i];

public static A237241Inst Instance=new A237241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237242
{
public static readonly long[] Value={ 81L,344L,1488L,6496L,28176L,121088L,523776L,2286592L,9917952L,42622976L,184369152L,804880384L,3491119104L,15003287552L,64897941504L,283317895168L,1228873924608L,5281157218304L,22844075409408L,99727899099136L,432563621462016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237242Inst : IEnumerable<long>
{
public static readonly long[] Value=A237242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237242.Bytes);
public long this[int i]=>Value[i];

public static A237242Inst Instance=new A237242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237243
{
public static readonly long[] Value={ 344L,2064L,12600L,78420L,477144L,2908188L,17766000L,110572200L,672773040L,4100545080L,25050060000L,155906802000L,948609986400L,5781768562800L,35320584600000L,219828590820000L,1337540080824000L,8152293673548000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237243Inst : IEnumerable<long>
{
public static readonly long[] Value=A237243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237243.Bytes);
public long this[int i]=>Value[i];

public static A237243Inst Instance=new A237243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237244
{
public static readonly long[] Value={ 1488L,12600L,108652L,974864L,8433384L,72877504L,629104640L,5642567936L,48822536832L,421991535616L,3643475019776L,32666380795904L,282702867210240L,2444023059595264L,21105706476486656L,189154485612609536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237244Inst : IEnumerable<long>
{
public static readonly long[] Value=A237244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237244.Bytes);
public long this[int i]=>Value[i];

public static A237244Inst Instance=new A237244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237245
{
public static readonly long[] Value={ 6496L,78420L,974864L,12987512L,163330432L,2059810392L,26060799904L,355097523776L,4532945330880L,57916057781984L,741681895667456L,10266004050839616L,132424817292716928L,1707035661218555456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237245Inst : IEnumerable<long>
{
public static readonly long[] Value=A237245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237245.Bytes);
public long this[int i]=>Value[i];

public static A237245Inst Instance=new A237245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237246
{
public static readonly BigInteger[] Value={ 28176L,477144L,8433384L,163330432L,2917434432L,51846897952L,936224849104L,18672666559360L,339066019397152L,6092798602997504L,111770577368471328L,2280258602003570688L,BigInteger.Parse("41947564959167642688"),BigInteger.Parse("759810246767623997952") };
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
public class A237246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237246Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A237246.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A237246.Bytes);
public BigInteger this[int i]=>Value[i];

public static A237246Inst Instance=new A237246Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237247
{
public static readonly BigInteger[] Value={ 121088L,2908188L,72877504L,2059810392L,51846897952L,1322709022496L,33969293459504L,996183385432552L,25470281902658352L,662344336965336672L,17331810080749088272UL,BigInteger.Parse("522695419521794182008"),BigInteger.Parse("13540411746190682944976") };
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
public class A237247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237247Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A237247.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A237247.Bytes);
public BigInteger this[int i]=>Value[i];

public static A237247Inst Instance=new A237247Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237360
{
public static readonly long[] Value={ 57L,381L,993L,4557L,16257L,32943L,49953L,58323L,109893L,135057L,167691L,214833L,237657L,453603L,503391L,564753L,658533L,678153L,780573L,995007L,1248807L,1516593L,1746363L,2218611L,2400951L,3465183L,3738423L,4340973L,4750221L,5232657L,6118203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237360Inst : IEnumerable<long>
{
public static readonly long[] Value=A237360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237360.Bytes);
public long this[int i]=>Value[i];

public static A237360Inst Instance=new A237360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237361
{
public static readonly long[] Value={ 4435770414505L,30562950873505L,32152890387805L,60700878873905L,936037312559305L,1279875801783805L,3780430049614405L,6055088920612205L,10370026462436905L,12160851727605005L,16956369914710105L,18746881534017005L,20813869508536105L,30740855019988405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237361Inst : IEnumerable<long>
{
public static readonly long[] Value=A237361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237361.Bytes);
public long this[int i]=>Value[i];

public static A237361Inst Instance=new A237361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237362
{
public static readonly long[] Value={ 1L,4L,23L,136L,1147L,11277L,105046L,927054L,7581063L,57507712L,405267267L,2662585198L,16366889904L,94486124304L,514135539077L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237362Inst : IEnumerable<long>
{
public static readonly long[] Value=A237362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237362.Bytes);
public long this[int i]=>Value[i];

public static A237362Inst Instance=new A237362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237363
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,2L,6L,6L,10L,13L,20L,26L,39L,50L,71L,87L,121L,156L,208L,265L,348L,440L,566L,712L,906L,1131L,1424L,1766L,2224L,2738L,3390L,4168L,5130L,6266L,7664L,9312L,11332L,13723L,16603L,20004L,24112L,28942L,34708L,41522L,49612L,59031L,70308L,83479L,98992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237363Inst : IEnumerable<long>
{
public static readonly long[] Value=A237363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237363.Bytes);
public long this[int i]=>Value[i];

public static A237363Inst Instance=new A237363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237364
{
public static readonly BigInteger[] Value={ 616067011L,58749951412747L,93054242152309543L,BigInteger.Parse("146945091162352770847"),BigInteger.Parse("2224989620406870255043"),BigInteger.Parse("43184085337135904888293"),BigInteger.Parse("53224134341571172990843"),BigInteger.Parse("109539169818149034933067"),BigInteger.Parse("308295173856880401026941"),BigInteger.Parse("6197901576526752380316343"),BigInteger.Parse("14789135287218506962379317") };
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
public class A237364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237364Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A237364.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A237364.Bytes);
public BigInteger this[int i]=>Value[i];

public static A237364Inst Instance=new A237364Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237365
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,5L,5L,9L,12L,17L,22L,30L,38L,51L,64L,89L,110L,141L,177L,225L,279L,352L,436L,543L,669L,827L,1012L,1244L,1494L,1827L,2214L,2674L,3219L,3877L,4646L,5571L,6645L,7914L,9412L,11181L,13226L,15641L,18466L,21739L,25563L,30103L,35250L,41275L,48281L,56353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237365Inst : IEnumerable<long>
{
public static readonly long[] Value=A237365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237365.Bytes);
public long this[int i]=>Value[i];

public static A237365Inst Instance=new A237365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237366
{
public static readonly long[] Value={ 7L,19L,31L,67L,127L,181L,223L,241L,331L,367L,409L,463L,487L,673L,709L,751L,811L,823L,883L,997L,1117L,1231L,1321L,1489L,1549L,1861L,1933L,2083L,2179L,2287L,2473L,2551L,2707L,2803L,2851L,2857L,2917L,2971L,3067L,3361L,3499L,3559L,3691L,3847L,3931L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237366Inst : IEnumerable<long>
{
public static readonly long[] Value=A237366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237366.Bytes);
public long this[int i]=>Value[i];

public static A237366Inst Instance=new A237366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237367
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,3L,3L,3L,2L,3L,2L,4L,3L,5L,2L,6L,3L,6L,2L,4L,3L,4L,2L,4L,3L,4L,4L,4L,3L,8L,3L,4L,5L,6L,6L,5L,6L,5L,5L,3L,4L,7L,5L,6L,3L,7L,3L,3L,5L,4L,5L,6L,5L,8L,10L,4L,5L,11L,6L,3L,6L,5L,5L,5L,6L,5L,8L,4L,3L,5L,6L,5L,1L,7L,6L,3L,3L,5L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237367Inst : IEnumerable<long>
{
public static readonly long[] Value=A237367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237367.Bytes);
public long this[int i]=>Value[i];

public static A237367Inst Instance=new A237367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237368
{
public static readonly long[] Value={ 81L,288L,1024L,3840L,14400L,53760L,200704L,752640L,2822400L,10536960L,39337984L,147517440L,553190400L,2065244160L,7710244864L,28913418240L,108425318400L,404787855360L,1511207993344L,5667029975040L,21251362406400L,79338419650560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237368Inst : IEnumerable<long>
{
public static readonly long[] Value=A237368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237368.Bytes);
public long this[int i]=>Value[i];

public static A237368Inst Instance=new A237368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237369
{
public static readonly long[] Value={ 288L,1164L,4760L,20812L,90528L,393456L,1707488L,7460608L,32509760L,141269808L,613267808L,2679432304L,11675906432L,50736815168L,220255387008L,962317756288L,4193401642752L,18222123217856L,79104715510144L,345616379670720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237369Inst : IEnumerable<long>
{
public static readonly long[] Value=A237369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237369.Bytes);
public long this[int i]=>Value[i];

public static A237369Inst Instance=new A237369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237370
{
public static readonly long[] Value={ 1024L,4760L,22676L,116880L,597492L,3049632L,15573476L,80201408L,411286836L,2099304960L,10729460820L,55269328800L,283525603492L,1447353862496L,7398722121284L,38126239186720L,195635060216484L,998817510951744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237370Inst : IEnumerable<long>
{
public static readonly long[] Value=A237370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237370.Bytes);
public long this[int i]=>Value[i];

public static A237370Inst Instance=new A237370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237371
{
public static readonly long[] Value={ 3840L,20812L,116880L,723928L,4429368L,27053348L,165467520L,1026092552L,6319203136L,38680736568L,237385725976L,1476526709904L,9118194049424L,55928190691948L,344012027433208L,2146405306742592L,13288265907921064L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237371Inst : IEnumerable<long>
{
public static readonly long[] Value=A237371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237371.Bytes);
public long this[int i]=>Value[i];

public static A237371Inst Instance=new A237371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237372
{
public static readonly long[] Value={ 14400L,90528L,597492L,4429368L,32296444L,234383800L,1707821384L,12676271720L,93083424892L,676587278680L,4945731247332L,36822194038016L,271079114259616L,1972888324274896L,14448798341159304L,107934095999345336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237372Inst : IEnumerable<long>
{
public static readonly long[] Value=A237372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237372.Bytes);
public long this[int i]=>Value[i];

public static A237372Inst Instance=new A237372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237373
{
public static readonly long[] Value={ 53760L,393456L,3049632L,27053348L,234383800L,2025855560L,17548046424L,155695765032L,1358174204976L,11752247409536L,102066414659576L,907457040604924L,7927360821437288L,68639199462554376L,596728125581641856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237373Inst : IEnumerable<long>
{
public static readonly long[] Value=A237373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237373.Bytes);
public long this[int i]=>Value[i];

public static A237373Inst Instance=new A237373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237374
{
public static readonly long[] Value={ 200704L,1707488L,15573476L,165467520L,1707821384L,17548046424L,181220498828L,1925951897720L,20030098218572L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237374Inst : IEnumerable<long>
{
public static readonly long[] Value=A237374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237374.Bytes);
public long this[int i]=>Value[i];

public static A237374Inst Instance=new A237374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237375
{
public static readonly long[] Value={ 81L,288L,288L,1024L,1164L,1024L,3840L,4760L,4760L,3840L,14400L,20812L,22676L,20812L,14400L,53760L,90528L,116880L,116880L,90528L,53760L,200704L,393456L,597492L,723928L,597492L,393456L,200704L,752640L,1707488L,3049632L,4429368L,4429368L,3049632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237375Inst : IEnumerable<long>
{
public static readonly long[] Value=A237375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237375.Bytes);
public long this[int i]=>Value[i];

public static A237375Inst Instance=new A237375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237408
{
public static readonly long[] Value={ 5228L,44186L,373804L,3604930L,35476776L,330330878L,3029315052L,28551327846L,271444171644L,2547123932136L,23780590707200L,223518159353886L,2106911371257820L,19790959500035682L,185592593234314976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237408Inst : IEnumerable<long>
{
public static readonly long[] Value=A237408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237408.Bytes);
public long this[int i]=>Value[i];

public static A237408Inst Instance=new A237408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237409
{
public static readonly long[] Value={ 21456L,238640L,2671962L,35476776L,480758688L,6045609040L,74740595664L,958854072908L,12448856412422L,158549359318752L,2007141088266072L,25632018579342668L,328941744848836330L,4196826763296220744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237409Inst : IEnumerable<long>
{
public static readonly long[] Value=A237409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237409.Bytes);
public long this[int i]=>Value[i];

public static A237409Inst Instance=new A237409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237410
{
public static readonly BigInteger[] Value={ 87164L,1260486L,18401364L,330330878L,6045609040L,101410470742L,1668740442760L,28739211200900L,500884807969628L,8543128692901112L,144626632332405084L,2476006354146555628L,BigInteger.Parse("42573962725861207468"),BigInteger.Parse("727911488082492382520") };
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
public class A237410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237410Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A237410.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A237410.Bytes);
public BigInteger this[int i]=>Value[i];

public static A237410Inst Instance=new A237410Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237411
{
public static readonly BigInteger[] Value={ 354008L,6627450L,125750824L,3029315052L,74740595664L,1668740442760L,36546653191142L,842126502478880L,19674093304667730L,447934704016463420L,10135886871027538506UL,BigInteger.Parse("232015073246807414804"),BigInteger.Parse("5340726310335786917066") };
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
public class A237411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237411Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A237411.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A237411.Bytes);
public BigInteger this[int i]=>Value[i];

public static A237411Inst Instance=new A237411Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237412
{
public static readonly long[] Value={ 81L,322L,322L,1278L,1632L,1278L,5228L,8236L,8236L,5228L,21456L,44186L,53167L,44186L,21456L,87164L,238640L,373804L,373804L,238640L,87164L,354008L,1260486L,2671962L,3604930L,2671962L,1260486L,354008L,1441060L,6627450L,18401364L,35476776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237412Inst : IEnumerable<long>
{
public static readonly long[] Value=A237412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237412.Bytes);
public long this[int i]=>Value[i];

public static A237412Inst Instance=new A237412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237413
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,4L,3L,2L,2L,2L,2L,2L,1L,1L,2L,2L,1L,2L,5L,3L,1L,3L,3L,3L,3L,3L,1L,3L,1L,2L,2L,5L,2L,3L,3L,5L,2L,5L,7L,3L,3L,4L,5L,5L,5L,4L,4L,5L,2L,3L,4L,7L,5L,3L,4L,8L,6L,5L,4L,6L,5L,4L,2L,6L,5L,6L,5L,2L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237413Inst : IEnumerable<long>
{
public static readonly long[] Value=A237413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237413.Bytes);
public long this[int i]=>Value[i];

public static A237413Inst Instance=new A237413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237414
{
public static readonly long[] Value={ 2L,3L,43L,47L,107L,139L,191L,211L,223L,239L,293L,313L,337L,541L,743L,757L,863L,1013L,1153L,1231L,1619L,2113L,2137L,2287L,2297L,2423L,2543L,2729L,2749L,2897L,3079L,3089L,3313L,3863L,3947L,4241L,4271L,4583L,4649L,4993L,5581L,6571L,6637L,6911L,7547L,8629L,8849L,8867L,9049L,9661L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237414Inst : IEnumerable<long>
{
public static readonly long[] Value=A237414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237414.Bytes);
public long this[int i]=>Value[i];

public static A237414Inst Instance=new A237414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237415
{
public static readonly long[] Value={ 0L,1L,2L,8L,9L,10L,11L,12L,18L,19L,20L,21L,22L,28L,29L,30L,31L,32L,38L,39L,40L,41L,42L,48L,49L,50L,51L,52L,58L,59L,60L,61L,62L,68L,69L,70L,71L,72L,78L,79L,80L,81L,82L,88L,89L,90L,91L,92L,98L,99L,100L,101L,102L,108L,109L,110L,111L,112L,118L,119L,120L,121L,122L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237415Inst : IEnumerable<long>
{
public static readonly long[] Value=A237415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237415.Bytes);
public long this[int i]=>Value[i];

public static A237415Inst Instance=new A237415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237416
{
public static readonly long[] Value={ 10L,20L,30L,40L,5L,60L,70L,80L,90L,10L,110L,120L,130L,140L,15L,160L,170L,180L,190L,20L,210L,220L,230L,240L,25L,260L,270L,280L,290L,30L,310L,320L,330L,340L,35L,360L,370L,380L,390L,40L,410L,420L,430L,440L,45L,460L,470L,480L,490L,50L,510L,520L,530L,540L,55L,560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237416Inst : IEnumerable<long>
{
public static readonly long[] Value=A237416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237416.Bytes);
public long this[int i]=>Value[i];

public static A237416Inst Instance=new A237416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237417
{
public static readonly long[] Value={ 3L,5L,6L,9L,10L,12L,15L,17L,18L,20L,21L,23L,24L,27L,29L,30L,33L,34L,35L,36L,39L,40L,42L,43L,45L,46L,48L,51L,53L,54L,55L,57L,58L,60L,63L,65L,66L,68L,70L,71L,72L,78L,80L,83L,84L,85L,86L,89L,90L,92L,93L,95L,96L,99L,101L,102L,105L,106L,108L,110L,111L,113L,114L,116L,117L,119L,120L,123L,126L,129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237417Inst : IEnumerable<long>
{
public static readonly long[] Value=A237417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237417.Bytes);
public long this[int i]=>Value[i];

public static A237417Inst Instance=new A237417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237418
{
public static readonly BigInteger[] Value={ 19L,31L,79L,271L,1039L,4111L,65551L,4194319L,67108879L,1073741839L,4294967311L,1099511627791L,4398046511119L,70368744177679L,BigInteger.Parse("4722366482869645213711"),BigInteger.Parse("75557863725914323419151") };
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
public class A237418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237418Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A237418.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A237418.Bytes);
public BigInteger this[int i]=>Value[i];

public static A237418Inst Instance=new A237418Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237419
{
public static readonly BigInteger[] Value={ 1L,253L,262141L,4294967293L,1125899906842621L,BigInteger.Parse("4722366482869645213693"),BigInteger.Parse("316912650057057350374175801341"),BigInteger.Parse("340282366920938463463374607431768211453"),BigInteger.Parse("5846006549323611672814739330865132078623730171901") };
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
public class A237419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237419Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A237419.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A237419.Bytes);
public BigInteger this[int i]=>Value[i];

public static A237419Inst Instance=new A237419Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237420
{
public static readonly long[] Value={ 0L,0L,2L,0L,4L,0L,6L,0L,8L,0L,10L,0L,12L,0L,14L,0L,16L,0L,18L,0L,20L,0L,22L,0L,24L,0L,26L,0L,28L,0L,30L,0L,32L,0L,34L,0L,36L,0L,38L,0L,40L,0L,42L,0L,44L,0L,46L,0L,48L,0L,50L,0L,52L,0L,54L,0L,56L,0L,58L,0L,60L,0L,62L,0L,64L,0L,66L,0L,68L,0L,70L,0L,72L,0L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237420Inst : IEnumerable<long>
{
public static readonly long[] Value=A237420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237420.Bytes);
public long this[int i]=>Value[i];

public static A237420Inst Instance=new A237420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237421
{
public static readonly long[] Value={ 6L,0L,3L,2L,3L,2L,6L,8L,3L,7L,7L,4L,1L,3L,6L,2L,0L,6L,2L,2L,0L,1L,9L,2L,6L,5L,0L,9L,4L,8L,6L,6L,8L,2L,2L,0L,4L,2L,0L,9L,6L,2L,5L,1L,4L,2L,1L,1L,7L,4L,8L,7L,4L,8L,0L,4L,2L,4L,0L,3L,6L,1L,5L,4L,8L,8L,9L,6L,6L,5L,7L,3L,0L,6L,0L,4L,3L,0L,0L,6L,9L,7L,3L,8L,3L,0L,3L,2L,1L,9L,2L,7L,2L,3L,5L,2L,6L,2L,5L,4L,7L,6L,9L,7L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237421Inst : IEnumerable<long>
{
public static readonly long[] Value=A237421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237421.Bytes);
public long this[int i]=>Value[i];

public static A237421Inst Instance=new A237421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237422
{
public static readonly long[] Value={ 0L,1L,2L,2L,1L,1L,1L,1L,0L,2L,0L,2L,2L,1L,0L,1L,1L,1L,1L,1L,2L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,1L,1L,3L,0L,0L,0L,1L,2L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,2L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237422Inst : IEnumerable<long>
{
public static readonly long[] Value=A237422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237422.Bytes);
public long this[int i]=>Value[i];

public static A237422Inst Instance=new A237422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237423
{
public static readonly long[] Value={ 13L,17L,167L,179L,211L,223L,337L,373L,541L,661L,743L,751L,1063L,1129L,1217L,1607L,1697L,1741L,1913L,2017L,2039L,2083L,2293L,2389L,2447L,2459L,2543L,2677L,2693L,2711L,2851L,2909L,3083L,3191L,3209L,3259L,3571L,3889L,3917L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237423Inst : IEnumerable<long>
{
public static readonly long[] Value=A237423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237423.Bytes);
public long this[int i]=>Value[i];

public static A237423Inst Instance=new A237423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237456
{
public static readonly long[] Value={ 81L,308L,1144L,4272L,16280L,61152L,231680L,869120L,3299584L,12382208L,46966784L,176229376L,668720640L,2509305856L,9520095232L,35722403840L,135538946048L,508589948928L,1929634152448L,7240635777024L,27472062906368L,103084621299712L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237456Inst : IEnumerable<long>
{
public static readonly long[] Value=A237456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237456.Bytes);
public long this[int i]=>Value[i];

public static A237456Inst Instance=new A237456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237457
{
public static readonly long[] Value={ 308L,1376L,5938L,25974L,113324L,496942L,2183186L,9577336L,41971324L,184102474L,807827730L,3543250384L,15538743130L,68158488618L,298985438448L,1311406306956L,5751938471714L,25229703215602L,110665842504412L,485405880082358L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237457Inst : IEnumerable<long>
{
public static readonly long[] Value=A237457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237457.Bytes);
public long this[int i]=>Value[i];

public static A237457Inst Instance=new A237457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237458
{
public static readonly long[] Value={ 1144L,5938L,27915L,125998L,578435L,2683716L,12536462L,57585440L,267621076L,1237416868L,5770921094L,26593601924L,123810488360L,571558604608L,2663437654276L,12284087723608L,57216490431308L,264018609435988L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237458Inst : IEnumerable<long>
{
public static readonly long[] Value=A237458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237458.Bytes);
public long this[int i]=>Value[i];

public static A237458Inst Instance=new A237458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237459
{
public static readonly long[] Value={ 4272L,25974L,125998L,594190L,2864838L,14469792L,71637702L,345945382L,1692387998L,8423481016L,41623347902L,203854940676L,1002036877470L,4949498743130L,24401744486702L,120014028398474L,590821956837072L,2912112513596448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237459Inst : IEnumerable<long>
{
public static readonly long[] Value=A237459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237459.Bytes);
public long this[int i]=>Value[i];

public static A237459Inst Instance=new A237459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237460
{
public static readonly long[] Value={ 16280L,113324L,578435L,2864838L,14411725L,76965324L,395458926L,1940632168L,9857379954L,51307932252L,262316457960L,1316106065696L,6723491441428L,34492852009684L,176030300478668L,891153963024052L,4555037781585086L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237460Inst : IEnumerable<long>
{
public static readonly long[] Value=A237460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237460.Bytes);
public long this[int i]=>Value[i];

public static A237460Inst Instance=new A237460Inst();

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