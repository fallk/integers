using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A154905
{
public static readonly long[] Value={ 4L,1L,6L,9L,9L,2L,5L,0L,0L,1L,4L,4L,2L,3L,1L,2L,3L,6L,2L,9L,0L,7L,4L,7L,7L,8L,8L,7L,8L,9L,5L,6L,3L,3L,0L,1L,7L,5L,1L,9L,6L,2L,8L,8L,1L,5L,3L,8L,4L,9L,6L,2L,1L,2L,0L,9L,1L,1L,5L,0L,5L,3L,0L,9L,0L,8L,2L,1L,9L,6L,4L,5L,5L,5L,8L,8L,7L,1L,7L,1L,2L,5L,0L,4L,4L,5L,6L,0L,9L,4L,9L,8L,3L,6L,1L,7L,6L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154905Inst : IEnumerable<long>
{
public static readonly long[] Value=A154905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154905.Bytes);
public long this[int i]=>Value[i];

public static A154905Inst Instance=new A154905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154906
{
public static readonly long[] Value={ 1L,2L,4L,15L,16L,72L,160L,336L,960L,1536L,1920L,2048L,3072L,3200L,36864L,110592L,163840L,1376256L,1474560L,2064384L,50331648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154906Inst : IEnumerable<long>
{
public static readonly long[] Value=A154906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154906.Bytes);
public long this[int i]=>Value[i];

public static A154906Inst Instance=new A154906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154907
{
public static readonly long[] Value={ 1L,3L,6L,12L,18L,24L,36L,48L,60L,72L,84L,90L,96L,108L,120L,168L,180L,240L,300L,336L,360L,420L,480L,504L,600L,720L,792L,840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154907Inst : IEnumerable<long>
{
public static readonly long[] Value=A154907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154907.Bytes);
public long this[int i]=>Value[i];

public static A154907Inst Instance=new A154907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154908
{
public static readonly BigInteger[] Value={ 1L,2L,8L,144L,2584L,46368L,14930352L,4807526976L,1548008755920L,498454011879264L,160500643816367088L,2880067194370816120L,BigInteger.Parse("51680708854858323072"),BigInteger.Parse("16641027750620563662096"),BigInteger.Parse("5358359254990966640871840") };
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
public class A154908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154908Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A154908.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A154908.Bytes);
public BigInteger this[int i]=>Value[i];

public static A154908Inst Instance=new A154908Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154909
{
public static readonly long[] Value={ 2L,0L,8L,4L,9L,6L,2L,5L,0L,0L,7L,2L,1L,1L,5L,6L,1L,8L,1L,4L,5L,3L,7L,3L,8L,9L,4L,3L,9L,4L,7L,8L,1L,6L,5L,0L,8L,7L,5L,9L,8L,1L,4L,4L,0L,7L,6L,9L,2L,4L,8L,1L,0L,6L,0L,4L,5L,5L,7L,5L,2L,6L,5L,4L,5L,4L,1L,0L,9L,8L,2L,2L,7L,7L,9L,4L,3L,5L,8L,5L,6L,2L,5L,2L,2L,2L,8L,0L,4L,7L,4L,9L,1L,8L,0L,8L,8L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154909Inst : IEnumerable<long>
{
public static readonly long[] Value=A154909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154909.Bytes);
public long this[int i]=>Value[i];

public static A154909Inst Instance=new A154909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154910
{
public static readonly long[] Value={ 1L,7L,9L,5L,8L,8L,8L,9L,4L,7L,0L,4L,5L,3L,6L,3L,6L,4L,0L,9L,3L,9L,2L,3L,9L,2L,8L,7L,3L,0L,6L,0L,7L,0L,1L,3L,8L,1L,1L,9L,1L,3L,0L,7L,3L,1L,8L,2L,6L,0L,9L,4L,8L,6L,8L,6L,4L,2L,0L,8L,9L,4L,2L,0L,9L,4L,8L,1L,5L,4L,4L,0L,8L,3L,9L,1L,7L,1L,2L,0L,6L,0L,7L,5L,7L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154910Inst : IEnumerable<long>
{
public static readonly long[] Value=A154910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154910.Bytes);
public long this[int i]=>Value[i];

public static A154910Inst Instance=new A154910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154911
{
public static readonly long[] Value={ 1L,6L,1L,3L,1L,4L,7L,1L,9L,2L,7L,6L,5L,4L,5L,8L,4L,1L,3L,1L,2L,9L,7L,5L,3L,8L,6L,1L,5L,3L,2L,1L,7L,9L,1L,2L,3L,5L,3L,4L,8L,5L,8L,1L,4L,0L,5L,4L,2L,8L,9L,6L,5L,7L,1L,6L,1L,0L,5L,0L,5L,0L,7L,1L,1L,7L,3L,3L,5L,7L,9L,8L,1L,4L,5L,9L,2L,7L,7L,1L,9L,6L,1L,6L,8L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154911Inst : IEnumerable<long>
{
public static readonly long[] Value=A154911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154911.Bytes);
public long this[int i]=>Value[i];

public static A154911Inst Instance=new A154911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154912
{
public static readonly long[] Value={ 1L,4L,8L,5L,3L,5L,7L,2L,5L,5L,2L,1L,5L,1L,8L,1L,4L,0L,4L,1L,2L,3L,2L,7L,7L,4L,1L,2L,3L,5L,1L,1L,0L,7L,6L,0L,1L,5L,8L,4L,2L,1L,2L,9L,8L,5L,1L,4L,6L,3L,9L,8L,8L,9L,0L,1L,3L,0L,3L,9L,4L,9L,8L,2L,4L,0L,6L,3L,7L,2L,2L,0L,8L,7L,6L,0L,0L,7L,8L,3L,4L,2L,6L,8L,4L,4L,3L,7L,1L,5L,4L,7L,1L,8L,4L,9L,5L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154912Inst : IEnumerable<long>
{
public static readonly long[] Value=A154912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154912.Bytes);
public long this[int i]=>Value[i];

public static A154912Inst Instance=new A154912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154913
{
public static readonly long[] Value={ 4L,3L,3L,5L,-8L,5L,9L,-6L,-6L,9L,17L,-120L,176L,-120L,17L,33L,252L,-180L,-180L,252L,33L,65L,-4590L,7180L,-7200L,7180L,-4590L,65L,129L,46134L,-57204L,21336L,21336L,-57204L,46134L,129L,257L,-658840L,910520L,-603680L,433216L,-603680L,910520L,-658840L,257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154913Inst : IEnumerable<long>
{
public static readonly long[] Value=A154913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154913.Bytes);
public long this[int i]=>Value[i];

public static A154913Inst Instance=new A154913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154914
{
public static readonly long[] Value={ 4L,5L,5L,13L,-24L,13L,35L,-30L,-30L,35L,97L,-936L,1584L,-936L,97L,275L,2940L,-2700L,-2700L,2940L,275L,793L,-78570L,168012L,-194400L,168012L,-78570L,793L,2315L,1153350L,-2002140L,960120L,960120L,-2002140L,1153350L,2315L,6817L,-24113544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154914Inst : IEnumerable<long>
{
public static readonly long[] Value=A154914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154914.Bytes);
public long this[int i]=>Value[i];

public static A154914Inst Instance=new A154914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154915
{
public static readonly long[] Value={ 4L,3L,3L,5L,8L,5L,9L,24L,24L,9L,17L,70L,112L,70L,17L,33L,198L,480L,480L,198L,33L,65L,544L,1920L,2880L,1920L,544L,65L,129L,1452L,7308L,15624L,15624L,7308L,1452L,129L,257L,3770L,26724L,80640L,108864L,80640L,26724L,3770L,257L,513L,9546L,94644L,408312L,706608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154915Inst : IEnumerable<long>
{
public static readonly long[] Value=A154915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154915.Bytes);
public long this[int i]=>Value[i];

public static A154915Inst Instance=new A154915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154916
{
public static readonly long[] Value={ 4L,5L,5L,13L,24L,13L,35L,120L,120L,35L,97L,546L,1008L,546L,97L,275L,2310L,7200L,7200L,2310L,275L,793L,9312L,44928L,77760L,44928L,9312L,793L,2315L,36300L,255780L,703080L,703080L,255780L,36300L,2315L,6817L,137982L,1372356L,5660928L,8817984L,5660928L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154916Inst : IEnumerable<long>
{
public static readonly long[] Value=A154916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154916.Bytes);
public long this[int i]=>Value[i];

public static A154916Inst Instance=new A154916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154917
{
public static readonly long[] Value={ 0L,0L,1L,1L,3L,5L,11L,21L,43L,85L,171L,341L,683L,1365L,2731L,5461L,10923L,21845L,43691L,87381L,174763L,349525L,699051L,1398101L,2796203L,5592405L,11184811L,22369621L,44739243L,89478485L,178956971L,357913941L,715827883L,1431655765L,2863311531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154917Inst : IEnumerable<long>
{
public static readonly long[] Value=A154917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154917.Bytes);
public long this[int i]=>Value[i];

public static A154917Inst Instance=new A154917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154918
{
public static readonly long[] Value={ 2L,5L,5L,29L,112L,29L,221L,1144L,1144L,221L,1821L,12000L,16016L,12000L,1821L,15505L,127110L,206720L,206720L,127110L,15505L,134597L,1309528L,2838752L,2615008L,2838752L,1309528L,134597L,1184041L,13126386L,37818900L,37328655L,37328655L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154918Inst : IEnumerable<long>
{
public static readonly long[] Value=A154918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154918.Bytes);
public long this[int i]=>Value[i];

public static A154918Inst Instance=new A154918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154919
{
public static readonly long[] Value={ 2L,4L,4L,16L,30L,16L,85L,162L,162L,85L,496L,990L,990L,990L,496L,3004L,6540L,6370L,6370L,6540L,3004L,18565L,43911L,46818L,37128L,46818L,43911L,18565L,116281L,294140L,358701L,257754L,257754L,358701L,294140L,116281L,735472L,1961532L,2714782L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154919Inst : IEnumerable<long>
{
public static readonly long[] Value=A154919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154919.Bytes);
public long this[int i]=>Value[i];

public static A154919Inst Instance=new A154919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154920
{
public static readonly long[] Value={ 1L,18L,27L,324L,405L,4374L,5103L,52488L,59049L,590490L,649539L,6377292L,6908733L,66961566L,71744535L,688747536L,731794257L,6973568802L,7360989291L,69735688020L,73222472421L,690383311398L,721764371007L,6778308875544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154920Inst : IEnumerable<long>
{
public static readonly long[] Value=A154920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154920.Bytes);
public long this[int i]=>Value[i];

public static A154920Inst Instance=new A154920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154921
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,1L,13L,9L,3L,1L,75L,52L,18L,4L,1L,541L,375L,130L,30L,5L,1L,4683L,3246L,1125L,260L,45L,6L,1L,47293L,32781L,11361L,2625L,455L,63L,7L,1L,545835L,378344L,131124L,30296L,5250L,728L,84L,8L,1L,7087261L,4912515L,1702548L,393372L,68166L,9450L,1092L,108L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154921Inst : IEnumerable<long>
{
public static readonly long[] Value=A154921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154921.Bytes);
public long this[int i]=>Value[i];

public static A154921Inst Instance=new A154921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154922
{
public static readonly long[] Value={ 4L,7L,7L,29L,40L,29L,133L,280L,280L,133L,641L,2030L,2800L,2030L,641L,3157L,14630L,28000L,28000L,14630L,3157L,15689L,102560L,278400L,360000L,278400L,102560L,15689L,78253L,694540L,2699900L,4557000L,4557000L,2699900L,694540L,78253L,390881L,4549810L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154922Inst : IEnumerable<long>
{
public static readonly long[] Value=A154922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154922.Bytes);
public long this[int i]=>Value[i];

public static A154922Inst Instance=new A154922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154923
{
public static readonly long[] Value={ 2L,3L,3L,5L,16L,5L,9L,62L,62L,9L,17L,208L,464L,208L,17L,33L,642L,2680L,2680L,642L,33L,65L,1880L,13404L,24320L,13404L,1880L,65L,129L,5322L,62188L,180488L,180488L,62188L,5322L,129L,257L,14752L,280144L,1209600L,1858752L,1209600L,280144L,14752L,257L,513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154923Inst : IEnumerable<long>
{
public static readonly long[] Value=A154923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154923.Bytes);
public long this[int i]=>Value[i];

public static A154923Inst Instance=new A154923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154924
{
public static readonly long[] Value={ 3L,6L,0L,0L,12L,6L,16L,18L,16L,6L,32L,6L,36L,8L,28L,16L,2L,26L,10L,6L,10L,54L,6L,18L,0L,36L,0L,132L,18L,68L,12L,40L,24L,12L,20L,22L,20L,12L,24L,48L,0L,66L,30L,120L,150L,24L,62L,6L,4L,32L,48L,24L,8L,0L,28L,16L,18L,84L,90L,180L,18L,144L,6L,132L,52L,36L,44L,54L,28L,38L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154924Inst : IEnumerable<long>
{
public static readonly long[] Value=A154924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154924.Bytes);
public long this[int i]=>Value[i];

public static A154924Inst Instance=new A154924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154925
{
public static readonly long[] Value={ 1L,1L,1L,1L,-2L,-5L,-6L,3L,9L,-5L,-13L,-14L,5L,30L,510L,-10L,-21L,-22L,7L,59L,5163L,53307975L,-14L,-29L,-30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154925Inst : IEnumerable<long>
{
public static readonly long[] Value=A154925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154925.Bytes);
public long this[int i]=>Value[i];

public static A154925Inst Instance=new A154925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154926
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,-2L,1L,-1L,-3L,-3L,1L,-1L,-4L,-6L,-4L,1L,-1L,-5L,-10L,-10L,-5L,1L,-1L,-6L,-15L,-20L,-15L,-6L,1L,-1L,-7L,-21L,-35L,-35L,-21L,-7L,1L,-1L,-8L,-28L,-56L,-70L,-56L,-28L,-8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154926Inst : IEnumerable<long>
{
public static readonly long[] Value=A154926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154926.Bytes);
public long this[int i]=>Value[i];

public static A154926Inst Instance=new A154926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154927
{
public static readonly long[] Value={ 1L,3L,8L,9L,9L,7L,5L,0L,0L,0L,4L,8L,0L,7L,7L,0L,7L,8L,7L,6L,3L,5L,8L,2L,5L,9L,6L,2L,6L,3L,1L,8L,7L,7L,6L,7L,2L,5L,0L,6L,5L,4L,2L,9L,3L,8L,4L,6L,1L,6L,5L,4L,0L,4L,0L,3L,0L,3L,8L,3L,5L,1L,0L,3L,0L,2L,7L,3L,9L,8L,8L,1L,8L,5L,2L,9L,5L,7L,2L,3L,7L,5L,0L,1L,4L,8L,5L,3L,6L,4L,9L,9L,4L,5L,3L,9L,2L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154927Inst : IEnumerable<long>
{
public static readonly long[] Value=A154927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154927.Bytes);
public long this[int i]=>Value[i];

public static A154927Inst Instance=new A154927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154928
{
public static readonly long[] Value={ 2L,8L,3L,6L,0L,6L,8L,1L,5L,4L,0L,7L,9L,8L,0L,6L,5L,2L,2L,2L,4L,2L,5L,8L,2L,2L,2L,5L,4L,8L,2L,7L,8L,3L,3L,6L,0L,7L,9L,3L,5L,0L,5L,7L,8L,2L,3L,7L,8L,1L,4L,0L,1L,3L,4L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154928Inst : IEnumerable<long>
{
public static readonly long[] Value=A154928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154928.Bytes);
public long this[int i]=>Value[i];

public static A154928Inst Instance=new A154928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154929
{
public static readonly long[] Value={ 1L,2L,1L,3L,4L,1L,5L,10L,6L,1L,8L,22L,21L,8L,1L,13L,45L,59L,36L,10L,1L,21L,88L,147L,124L,55L,12L,1L,34L,167L,339L,366L,225L,78L,14L,1L,55L,310L,741L,976L,770L,370L,105L,16L,1L,89L,566L,1557L,2422L,2337L,1443L,567L,136L,18L,1L,144L,1020L,3174L,5696L,6505L,4920L,2485L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154929Inst : IEnumerable<long>
{
public static readonly long[] Value=A154929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154929.Bytes);
public long this[int i]=>Value[i];

public static A154929Inst Instance=new A154929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154930
{
public static readonly long[] Value={ 1L,-2L,1L,5L,-4L,1L,-15L,14L,-6L,1L,51L,-50L,27L,-8L,1L,-188L,187L,-113L,44L,-10L,1L,731L,-730L,468L,-212L,65L,-12L,1L,-2950L,2949L,-1956L,970L,-355L,90L,-14L,1L,12235L,-12234L,8291L,-4356L,1785L,-550L,119L,-16L,1L,-51822L,51821L,-35643L,19474L,-8612L,3021L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154930Inst : IEnumerable<long>
{
public static readonly long[] Value=A154930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154930.Bytes);
public long this[int i]=>Value[i];

public static A154930Inst Instance=new A154930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154931
{
public static readonly long[] Value={ 1L,3L,18L,130L,1125L,11361L,131124L,1702548L,24562575L,389799355L,6748339158L,126565340694L,2556332651145L,55320126580005L,1276961156453160L,31318513972988008L,813295166343147315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154931Inst : IEnumerable<long>
{
public static readonly long[] Value=A154931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154931.Bytes);
public long this[int i]=>Value[i];

public static A154931Inst Instance=new A154931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154932
{
public static readonly long[] Value={ 0L,7L,1L,6L,0L,6L,0L,1L,5L,3L,6L,4L,0L,6L,2L,9L,5L,0L,6L,8L,9L,0L,1L,4L,9L,0L,5L,2L,3L,3L,2L,7L,8L,5L,7L,0L,0L,3L,2L,9L,7L,7L,5L,7L,7L,4L,9L,6L,7L,6L,4L,7L,6L,6L,9L,9L,6L,8L,8L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154932Inst : IEnumerable<long>
{
public static readonly long[] Value=A154932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154932.Bytes);
public long this[int i]=>Value[i];

public static A154932Inst Instance=new A154932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154933
{
public static readonly long[] Value={ 0L,3L,11L,17L,35L,37L,47L,49L,59L,67L,77L,99L,123L,127L,133L,139L,155L,161L,169L,173L,187L,195L,213L,225L,231L,237L,241L,245L,247L,253L,275L,279L,297L,319L,325L,367L,373L,381L,383L,385L,399L,411L,425L,431L,469L,507L,511L,523L,541L,545L,553L,569L,585L,589L,609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154933Inst : IEnumerable<long>
{
public static readonly long[] Value=A154933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154933.Bytes);
public long this[int i]=>Value[i];

public static A154933Inst Instance=new A154933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154934
{
public static readonly long[] Value={ 3L,11L,17L,37L,47L,59L,67L,127L,139L,173L,241L,367L,373L,383L,431L,523L,541L,569L,613L,631L,673L,683L,691L,829L,967L,977L,1019L,1063L,1163L,1213L,1249L,1291L,1301L,1303L,1327L,1367L,1439L,1483L,1487L,1601L,1607L,1609L,1733L,1747L,1789L,1801L,1823L,1907L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154934Inst : IEnumerable<long>
{
public static readonly long[] Value=A154934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154934.Bytes);
public long this[int i]=>Value[i];

public static A154934Inst Instance=new A154934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154935
{
public static readonly long[] Value={ 7L,15L,25L,87L,91L,99L,199L,211L,265L,337L,357L,361L,367L,405L,501L,511L,537L,595L,627L,685L,697L,771L,805L,841L,847L,861L,889L,931L,939L,979L,1035L,1047L,1081L,1125L,1135L,1177L,1225L,1231L,1287L,1315L,1321L,1387L,1425L,1497L,1501L,1627L,1741L,1795L,1807L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154935Inst : IEnumerable<long>
{
public static readonly long[] Value=A154935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154935.Bytes);
public long this[int i]=>Value[i];

public static A154935Inst Instance=new A154935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154936
{
public static readonly long[] Value={ 7L,199L,211L,337L,367L,1231L,1321L,1627L,1741L,2161L,2251L,2551L,3259L,3769L,3877L,3931L,4099L,4591L,4759L,4789L,6829L,7297L,7867L,8221L,8887L,9049L,9181L,9337L,9349L,11959L,12697L,12919L,13411L,13591L,14827L,15187L,15217L,15817L,15877L,15889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154936Inst : IEnumerable<long>
{
public static readonly long[] Value=A154936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154936.Bytes);
public long this[int i]=>Value[i];

public static A154936Inst Instance=new A154936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154937
{
public static readonly long[] Value={ 2L,0L,9L,7L,8L,8L,3L,2L,3L,9L,4L,0L,0L,1L,9L,4L,9L,2L,7L,5L,5L,3L,6L,8L,6L,0L,2L,4L,6L,9L,1L,8L,9L,2L,3L,6L,2L,6L,8L,6L,1L,3L,9L,3L,2L,9L,2L,1L,8L,5L,1L,3L,4L,3L,7L,5L,2L,8L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154937Inst : IEnumerable<long>
{
public static readonly long[] Value=A154937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154937.Bytes);
public long this[int i]=>Value[i];

public static A154937Inst Instance=new A154937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154938
{
public static readonly long[] Value={ 195L,213L,231L,657L,1563L,1749L,2967L,3597L,3627L,4263L,4887L,6867L,6993L,7257L,7725L,9045L,9201L,9717L,11595L,12579L,13029L,14145L,14259L,14367L,15837L,16131L,16581L,17259L,19905L,19917L,21081L,21711L,23127L,24435L,24921L,28299L,28707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154938Inst : IEnumerable<long>
{
public static readonly long[] Value=A154938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154938.Bytes);
public long this[int i]=>Value[i];

public static A154938Inst Instance=new A154938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154939
{
public static readonly long[] Value={ 3L,5L,11L,31L,101L,131L,149L,181L,241L,331L,419L,449L,709L,1051L,1061L,1171L,1409L,1549L,1579L,1699L,1759L,1831L,2069L,3229L,3449L,3761L,3911L,4159L,4951L,5821L,6029L,6481L,6661L,6679L,6899L,7079L,7151L,7229L,7369L,8101L,8219L,8629L,8861L,9091L,9161L,9521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154939Inst : IEnumerable<long>
{
public static readonly long[] Value=A154939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154939.Bytes);
public long this[int i]=>Value[i];

public static A154939Inst Instance=new A154939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154940
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,3L,4L,5L,5L,6L,5L,5L,5L,7L,7L,6L,5L,9L,8L,8L,9L,10L,7L,9L,10L,7L,9L,7L,6L,7L,9L,7L,9L,11L,9L,9L,8L,8L,7L,7L,7L,8L,8L,9L,11L,10L,10L,13L,12L,10L,10L,10L,10L,10L,14L,9L,7L,11L,11L,9L,14L,12L,10L,12L,13L,9L,11L,8L,7L,10L,12L,10L,12L,12L,12L,12L,11L,11L,12L,8L,11L,11L,14L,10L,13L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154940Inst : IEnumerable<long>
{
public static readonly long[] Value=A154940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154940.Bytes);
public long this[int i]=>Value[i];

public static A154940Inst Instance=new A154940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154941
{
public static readonly long[] Value={ 3L,5L,11L,131L,419L,1409L,2069L,3449L,3761L,3911L,6899L,7079L,7151L,9539L,9791L,10529L,10691L,11321L,11831L,14741L,15269L,17291L,22079L,27281L,27809L,30449L,34439L,45131L,48479L,52289L,54251L,64439L,70901L,75389L,78839L,85691L,101411L,102911L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154941Inst : IEnumerable<long>
{
public static readonly long[] Value=A154941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154941.Bytes);
public long this[int i]=>Value[i];

public static A154941Inst Instance=new A154941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154942
{
public static readonly long[] Value={ 3L,5L,29L,71L,113L,263L,1103L,2339L,3203L,3413L,3593L,3659L,3719L,4421L,5939L,6269L,7841L,9011L,9029L,13121L,13841L,14423L,15671L,17033L,19073L,22079L,22811L,26783L,27851L,28949L,29303L,30839L,31973L,32063L,32141L,34301L,38543L,38873L,39119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154942Inst : IEnumerable<long>
{
public static readonly long[] Value=A154942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154942.Bytes);
public long this[int i]=>Value[i];

public static A154942Inst Instance=new A154942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154943
{
public static readonly long[] Value={ 0L,7L,9L,8L,4L,8L,0L,4L,0L,3L,0L,6L,2L,3L,2L,6L,9L,1L,8L,9L,7L,4L,0L,2L,2L,5L,4L,7L,0L,5L,1L,3L,6L,6L,8L,2L,2L,7L,2L,3L,1L,1L,9L,0L,2L,0L,8L,4L,9L,0L,8L,6L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154943Inst : IEnumerable<long>
{
public static readonly long[] Value=A154943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154943.Bytes);
public long this[int i]=>Value[i];

public static A154943Inst Instance=new A154943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154944
{
public static readonly long[] Value={ 19L,37L,67L,151L,367L,859L,1471L,2791L,2971L,3061L,4357L,4447L,4507L,6367L,7159L,7237L,7591L,8311L,8647L,11617L,12211L,12601L,13249L,14947L,15271L,15661L,16699L,18097L,19777L,20149L,20347L,20947L,21019L,22741L,23311L,23857L,24019L,25867L,26701L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154944Inst : IEnumerable<long>
{
public static readonly long[] Value=A154944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154944.Bytes);
public long this[int i]=>Value[i];

public static A154944Inst Instance=new A154944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154945
{
public static readonly long[] Value={ 5L,5L,1L,6L,9L,3L,2L,9L,7L,6L,5L,6L,9L,9L,9L,1L,8L,4L,4L,3L,9L,7L,3L,1L,0L,2L,3L,9L,7L,1L,3L,4L,3L,5L,7L,8L,1L,3L,1L,5L,0L,0L,3L,7L,7L,7L,7L,8L,6L,2L,8L,2L,5L,2L,2L,3L,0L,6L,1L,7L,3L,3L,4L,0L,5L,9L,5L,6L,5L,5L,9L,7L,6L,4L,1L,0L,7L,0L,6L,7L,1L,0L,7L,7L,7L,5L,0L,9L,8L,3L,1L,6L,8L,2L,7L,7L,9L,6L,0L,7L,2L,5L,0L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154945Inst : IEnumerable<long>
{
public static readonly long[] Value=A154945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154945.Bytes);
public long this[int i]=>Value[i];

public static A154945Inst Instance=new A154945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154946
{
public static readonly long[] Value={ 2L,5L,6L,4L,3L,4L,3L,2L,2L,0L,6L,8L,6L,3L,0L,9L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154946Inst : IEnumerable<long>
{
public static readonly long[] Value=A154946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154946.Bytes);
public long this[int i]=>Value[i];

public static A154946Inst Instance=new A154946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154947
{
public static readonly long[] Value={ 1L,3L,1L,5L,4L,6L,4L,8L,7L,6L,7L,8L,5L,7L,2L,8L,7L,1L,8L,5L,4L,9L,7L,6L,3L,5L,5L,7L,1L,7L,1L,3L,8L,0L,4L,2L,7L,1L,4L,9L,7L,9L,2L,8L,2L,0L,0L,6L,5L,9L,4L,0L,2L,1L,3L,9L,3L,5L,3L,2L,7L,4L,7L,1L,9L,1L,9L,3L,4L,2L,6L,0L,0L,6L,9L,0L,4L,5L,7L,4L,0L,2L,5L,3L,0L,5L,8L,6L,3L,4L,4L,2L,7L,4L,7L,2L,5L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154947Inst : IEnumerable<long>
{
public static readonly long[] Value=A154947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154947.Bytes);
public long this[int i]=>Value[i];

public static A154947Inst Instance=new A154947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154948
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,2L,6L,5L,1L,3L,10L,14L,7L,1L,3L,15L,30L,26L,9L,1L,4L,21L,55L,70L,42L,11L,1L,4L,28L,91L,155L,138L,62L,13L,1L,5L,36L,140L,301L,363L,242L,86L,15L,1L,0L,5L,45L,204L,532L,819L,743L,390L,114L,17L,1L,6L,55L,285L,876L,1652L,1925L,1375L,590L,146L,19L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154948Inst : IEnumerable<long>
{
public static readonly long[] Value=A154948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154948.Bytes);
public long this[int i]=>Value[i];

public static A154948Inst Instance=new A154948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154949
{
public static readonly long[] Value={ 1L,1L,3L,5L,10L,18L,34L,62L,115L,211L,389L,715L,1316L,2420L,4452L,8188L,15061L,27701L,50951L,93713L,172366L,317030L,583110L,1072506L,1972647L,3628263L,6673417L,12274327L,22576008L,41523752L,76374088L,140473848L,258371689L,475219625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154949Inst : IEnumerable<long>
{
public static readonly long[] Value=A154949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154949.Bytes);
public long this[int i]=>Value[i];

public static A154949Inst Instance=new A154949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154950
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,-1L,2L,1L,1L,-1L,-1L,3L,1L,0L,2L,-4L,0L,4L,1L,0L,2L,2L,-8L,2L,5L,1L,0L,-2L,8L,-2L,-12L,5L,6L,1L,1L,-2L,-2L,18L,-12L,-15L,9L,7L,1L,0L,3L,-12L,8L,28L,-29L,-16L,14L,8L,1L,0L,3L,3L,-32L,38L,31L,-53L,-14L,20L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154950Inst : IEnumerable<long>
{
public static readonly long[] Value=A154950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154950.Bytes);
public long this[int i]=>Value[i];

public static A154950Inst Instance=new A154950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154951
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,4L,4L,5L,6L,6L,7L,8L,9L,9L,10L,10L,11L,12L,13L,13L,14L,15L,15L,16L,16L,17L,18L,19L,19L,20L,21L,22L,22L,23L,24L,24L,25L,25L,26L,27L,28L,28L,29L,29L,30L,31L,32L,32L,33L,34L,35L,35L,36L,37L,37L,38L,38L,39L,40L,41L,41L,42L,43L,43L,44L,44L,45L,46L,47L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154951Inst : IEnumerable<long>
{
public static readonly long[] Value=A154951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154951.Bytes);
public long this[int i]=>Value[i];

public static A154951Inst Instance=new A154951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154952
{
public static readonly long[] Value={ 1L,5L,6L,7L,12L,9L,13L,17L,22L,20L,26L,56L,50L,46L,74L,106L,76L,152L,116L,242L,206L,284L,623L,1056L,1032L,1582L,1586L,1616L,1892L,1676L,4286L,5484L,4946L,7016L,5366L,11262L,18776L,17486L,19688L,18192L,21018L,60662L,51476L,56546L,79946L,66986L,105476L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154952Inst : IEnumerable<long>
{
public static readonly long[] Value=A154952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154952.Bytes);
public long this[int i]=>Value[i];

public static A154952Inst Instance=new A154952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154953
{
public static readonly long[] Value={ 1L,2L,5L,5L,2L,7L,2L,5L,0L,5L,1L,0L,3L,3L,0L,6L,0L,6L,9L,8L,0L,3L,7L,9L,4L,7L,0L,1L,2L,3L,4L,7L,2L,3L,6L,4L,5L,1L,6L,8L,4L,4L,7L,6L,0L,9L,8L,4L,3L,5L,0L,0L,2L,7L,0L,9L,7L,0L,1L,5L,8L,7L,4L,1L,7L,3L,7L,5L,6L,6L,4L,9L,4L,8L,4L,1L,7L,4L,6L,7L,5L,5L,5L,7L,2L,8L,6L,3L,9L,6L,3L,4L,1L,3L,4L,1L,8L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154953Inst : IEnumerable<long>
{
public static readonly long[] Value=A154953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154953.Bytes);
public long this[int i]=>Value[i];

public static A154953Inst Instance=new A154953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154954
{
public static readonly long[] Value={ 1L,2L,0L,5L,3L,7L,8L,6L,4L,6L,3L,0L,0L,5L,4L,0L,3L,0L,4L,2L,3L,0L,6L,4L,7L,4L,7L,5L,4L,8L,5L,7L,6L,8L,8L,0L,4L,0L,4L,0L,5L,3L,3L,3L,8L,7L,2L,3L,5L,3L,3L,0L,6L,6L,0L,9L,5L,0L,9L,8L,0L,5L,1L,2L,2L,5L,3L,1L,2L,9L,1L,8L,8L,8L,0L,5L,9L,3L,8L,3L,0L,0L,8L,2L,1L,8L,8L,9L,1L,8L,8L,5L,0L,8L,3L,6L,8L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154954Inst : IEnumerable<long>
{
public static readonly long[] Value=A154954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154954.Bytes);
public long this[int i]=>Value[i];

public static A154954Inst Instance=new A154954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154955
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154955Inst : IEnumerable<long>
{
public static readonly long[] Value=A154955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154955.Bytes);
public long this[int i]=>Value[i];

public static A154955Inst Instance=new A154955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154956
{
public static readonly long[] Value={ 1L,2L,3L,5L,10L,71L,868L,1788L,7455L,44266L,54626L,74153L,224166L,390471L,1489304L,3737961L,22277163L,37201631L,113275744L,165029426L,2642368758L,3362202939L,5191046363L,8438525012L,36226438506L,40174126779L,125336047846L,531802867080L,599020778171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154956Inst : IEnumerable<long>
{
public static readonly long[] Value=A154956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154956.Bytes);
public long this[int i]=>Value[i];

public static A154956Inst Instance=new A154956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154957
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154957Inst : IEnumerable<long>
{
public static readonly long[] Value=A154957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154957.Bytes);
public long this[int i]=>Value[i];

public static A154957Inst Instance=new A154957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154958
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,3L,2L,4L,2L,4L,2L,5L,3L,6L,3L,6L,3L,7L,4L,8L,4L,8L,4L,9L,5L,10L,5L,10L,5L,11L,6L,12L,6L,12L,6L,13L,7L,14L,7L,14L,7L,15L,8L,16L,8L,16L,8L,17L,9L,18L,9L,18L,9L,19L,10L,20L,10L,20L,10L,21L,11L,22L,11L,22L,11L,23L,12L,24L,12L,24L,12L,25L,13L,26L,13L,26L,13L,27L,14L,28L,14L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154958Inst : IEnumerable<long>
{
public static readonly long[] Value=A154958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154958.Bytes);
public long this[int i]=>Value[i];

public static A154958Inst Instance=new A154958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154959
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,-3L,1L,-1L,-7L,-6L,1L,-1L,-15L,-25L,-10L,1L,-1L,-31L,-90L,-65L,-15L,1L,-1L,-63L,-301L,-350L,-140L,-21L,1L,-1L,-127L,-966L,-1701L,-1050L,-266L,-28L,1L,-1L,-255L,-3025L,-7770L,-6951L,-2646L,-462L,-36L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154959Inst : IEnumerable<long>
{
public static readonly long[] Value=A154959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154959.Bytes);
public long this[int i]=>Value[i];

public static A154959Inst Instance=new A154959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154960
{
public static readonly long[] Value={ 1L,1L,1L,4L,3L,1L,32L,25L,6L,1L,436L,340L,85L,10L,1L,9012L,7026L,1755L,215L,15L,1L,262760L,204862L,51156L,6265L,455L,21L,1L,10270696L,8007602L,1999620L,244811L,17780L,854L,28L,1L,518277560L,404077632L,100904602L,12353796L,896931L,43092L,1470L,36L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154960Inst : IEnumerable<long>
{
public static readonly long[] Value=A154960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154960.Bytes);
public long this[int i]=>Value[i];

public static A154960Inst Instance=new A154960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154961
{
public static readonly BigInteger[] Value={ 0L,1L,3L,25L,340L,7026L,204862L,8007602L,404077632L,25569505628L,1982619985192L,184861494417920L,20406183592852460L,2631875641089358912L,BigInteger.Parse("392163247878318070876"),BigInteger.Parse("66855512799464487146588"),BigInteger.Parse("12929525365915201064027856"),BigInteger.Parse("2815456378791384288128303192") };
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
public class A154961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154961Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A154961.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A154961.Bytes);
public BigInteger this[int i]=>Value[i];

public static A154961Inst Instance=new A154961Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154962
{
public static readonly long[] Value={ 1L,1L,1L,1L,-2L,-5L,-6L,3L,10L,90L,-5L,-13L,-14L,5L,30L,510L,-10L,-21L,-22L,7L,60L,2100L,-14L,-29L,-30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154962Inst : IEnumerable<long>
{
public static readonly long[] Value=A154962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154962.Bytes);
public long this[int i]=>Value[i];

public static A154962Inst Instance=new A154962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154963
{
public static readonly long[] Value={ 2L,17L,23L,41L,61L,71L,83L,127L,227L,337L,353L,499L,503L,571L,727L,887L,911L,937L,971L,1061L,1427L,1579L,1663L,1693L,1709L,1871L,1877L,1907L,1949L,1973L,2017L,2063L,2081L,2239L,2339L,2393L,2467L,2713L,2797L,2939L,2999L,3181L,3271L,3463L,3643L,3659L,3677L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154963Inst : IEnumerable<long>
{
public static readonly long[] Value=A154963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154963.Bytes);
public long this[int i]=>Value[i];

public static A154963Inst Instance=new A154963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154964
{
public static readonly long[] Value={ 1L,1L,5L,21L,93L,405L,1773L,7749L,33885L,148149L,647757L,2832165L,12383037L,54142101L,236724525L,1035026181L,4525425693L,19786434165L,86511856653L,378254174949L,1653833664765L,7231026043989L,31616080120557L,138234396625605L,604399670600157L,2642605391554101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154964Inst : IEnumerable<long>
{
public static readonly long[] Value=A154964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154964.Bytes);
public long this[int i]=>Value[i];

public static A154964Inst Instance=new A154964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154965
{
public static readonly long[] Value={ 4L,6L,12L,18L,27L,30L,35L,36L,42L,45L,46L,54L,56L,57L,58L,82L,85L,92L,93L,99L,115L,117L,119L,121L,123L,136L,141L,145L,147L,159L,161L,171L,175L,176L,177L,206L,215L,222L,225L,237L,243L,261L,273L,274L,282L,285L,291L,295L,296L,303L,309L,315L,319L,322L,327L,328L,332L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154965Inst : IEnumerable<long>
{
public static readonly long[] Value=A154965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154965.Bytes);
public long this[int i]=>Value[i];

public static A154965Inst Instance=new A154965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154966
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,19L,29L,31L,37L,43L,47L,53L,59L,67L,73L,79L,89L,97L,101L,103L,107L,109L,113L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,211L,223L,229L,233L,239L,241L,251L,257L,263L,269L,271L,277L,281L,283L,293L,307L,311L,313L,317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154966Inst : IEnumerable<long>
{
public static readonly long[] Value=A154966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154966.Bytes);
public long this[int i]=>Value[i];

public static A154966Inst Instance=new A154966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154967
{
public static readonly long[] Value={ 1L,8L,9L,10L,14L,15L,16L,20L,21L,22L,24L,25L,26L,28L,32L,33L,34L,38L,39L,40L,44L,48L,49L,50L,51L,52L,55L,60L,62L,63L,64L,65L,66L,68L,69L,70L,72L,74L,75L,76L,77L,78L,80L,81L,84L,86L,87L,88L,90L,91L,94L,95L,96L,98L,100L,102L,104L,105L,106L,108L,110L,111L,112L,114L,116L,118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154967Inst : IEnumerable<long>
{
public static readonly long[] Value=A154967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154967.Bytes);
public long this[int i]=>Value[i];

public static A154967Inst Instance=new A154967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154968
{
public static readonly long[] Value={ 1L,1L,7L,40L,244L,1456L,8752L,52480L,314944L,1889536L,11337472L,68024320L,408146944L,2448879616L,14693281792L,88159682560L,528958111744L,3173748637696L,19042491891712L,114254951219200L,685529707577344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154968Inst : IEnumerable<long>
{
public static readonly long[] Value=A154968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154968.Bytes);
public long this[int i]=>Value[i];

public static A154968Inst Instance=new A154968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154969
{
public static readonly long[] Value={ 1L,1L,6L,3L,1L,7L,1L,1L,6L,3L,0L,4L,6L,6L,1L,0L,4L,7L,0L,4L,2L,6L,8L,6L,7L,7L,5L,6L,8L,8L,6L,3L,4L,3L,1L,9L,0L,6L,8L,5L,6L,1L,6L,9L,8L,7L,2L,1L,0L,5L,8L,0L,7L,9L,6L,0L,8L,1L,9L,1L,1L,9L,8L,9L,7L,7L,5L,1L,7L,0L,4L,8L,4L,2L,7L,8L,5L,9L,7L,3L,2L,2L,7L,5L,7L,9L,0L,8L,3L,4L,7L,9L,4L,8L,9L,1L,0L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154969Inst : IEnumerable<long>
{
public static readonly long[] Value=A154969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154969.Bytes);
public long this[int i]=>Value[i];

public static A154969Inst Instance=new A154969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154970
{
public static readonly long[] Value={ 1L,1L,2L,6L,8L,7L,2L,8L,3L,6L,4L,9L,0L,1L,0L,9L,1L,0L,3L,2L,7L,5L,6L,5L,6L,7L,5L,9L,2L,9L,2L,5L,7L,1L,4L,4L,8L,2L,1L,1L,9L,0L,6L,0L,5L,9L,0L,8L,1L,0L,5L,0L,3L,8L,3L,4L,0L,2L,4L,2L,3L,6L,1L,8L,6L,5L,2L,2L,3L,9L,9L,3L,8L,7L,8L,1L,2L,6L,0L,1L,9L,4L,7L,0L,0L,5L,5L,5L,9L,3L,7L,0L,0L,2L,4L,7L,8L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154970Inst : IEnumerable<long>
{
public static readonly long[] Value=A154970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154970.Bytes);
public long this[int i]=>Value[i];

public static A154970Inst Instance=new A154970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154971
{
public static readonly long[] Value={ 1L,0L,9L,5L,2L,2L,8L,8L,6L,2L,7L,6L,8L,7L,9L,1L,9L,7L,7L,0L,5L,1L,9L,8L,8L,2L,5L,3L,2L,5L,0L,1L,8L,4L,1L,7L,8L,5L,7L,4L,2L,5L,9L,5L,8L,2L,1L,5L,5L,7L,5L,1L,6L,4L,3L,3L,8L,4L,8L,5L,5L,0L,4L,1L,4L,3L,5L,8L,9L,5L,5L,4L,0L,3L,5L,1L,7L,3L,7L,3L,1L,4L,0L,8L,3L,9L,9L,3L,0L,3L,7L,0L,2L,1L,5L,4L,9L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154971Inst : IEnumerable<long>
{
public static readonly long[] Value=A154971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154971.Bytes);
public long this[int i]=>Value[i];

public static A154971Inst Instance=new A154971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154972
{
public static readonly long[] Value={ 1L,0L,6L,7L,3L,2L,5L,7L,6L,6L,9L,7L,4L,2L,4L,1L,2L,7L,8L,1L,5L,3L,4L,8L,7L,6L,7L,2L,0L,6L,7L,5L,8L,7L,3L,2L,9L,4L,0L,4L,6L,7L,7L,4L,3L,6L,2L,9L,1L,4L,6L,1L,9L,9L,7L,1L,2L,1L,2L,0L,9L,4L,8L,3L,2L,9L,1L,9L,6L,1L,5L,6L,6L,3L,5L,0L,3L,1L,8L,0L,8L,7L,2L,7L,5L,9L,5L,7L,1L,6L,6L,0L,8L,0L,0L,6L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154972Inst : IEnumerable<long>
{
public static readonly long[] Value=A154972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154972.Bytes);
public long this[int i]=>Value[i];

public static A154972Inst Instance=new A154972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154973
{
public static readonly long[] Value={ 1L,0L,4L,2L,4L,8L,1L,2L,5L,0L,3L,6L,0L,5L,7L,8L,0L,9L,0L,7L,2L,6L,8L,6L,9L,4L,7L,1L,9L,7L,3L,9L,0L,8L,2L,5L,4L,3L,7L,9L,9L,0L,7L,2L,0L,3L,8L,4L,6L,2L,4L,0L,5L,3L,0L,2L,2L,7L,8L,7L,6L,3L,2L,7L,2L,7L,0L,5L,4L,9L,1L,1L,3L,8L,9L,7L,1L,7L,9L,2L,8L,1L,2L,6L,1L,1L,4L,0L,2L,3L,7L,4L,5L,9L,0L,4L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154973Inst : IEnumerable<long>
{
public static readonly long[] Value=A154973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154973.Bytes);
public long this[int i]=>Value[i];

public static A154973Inst Instance=new A154973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154974
{
public static readonly long[] Value={ 1L,0L,2L,0L,1L,7L,4L,4L,1L,2L,1L,9L,5L,2L,0L,6L,1L,8L,1L,2L,6L,2L,1L,6L,0L,2L,1L,2L,7L,0L,0L,8L,1L,5L,1L,0L,1L,0L,5L,5L,6L,0L,8L,2L,2L,4L,4L,9L,6L,1L,1L,6L,1L,8L,2L,4L,7L,9L,8L,6L,6L,8L,2L,3L,1L,0L,8L,8L,1L,5L,9L,3L,6L,7L,4L,3L,7L,5L,8L,8L,0L,0L,0L,5L,8L,0L,5L,8L,1L,7L,3L,2L,0L,0L,5L,6L,3L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154974Inst : IEnumerable<long>
{
public static readonly long[] Value=A154974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154974.Bytes);
public long this[int i]=>Value[i];

public static A154974Inst Instance=new A154974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154975
{
public static readonly long[] Value={ 9L,8L,1L,6L,3L,7L,5L,1L,3L,4L,0L,9L,9L,1L,2L,1L,3L,4L,2L,0L,3L,4L,3L,0L,1L,9L,6L,2L,4L,7L,2L,2L,7L,9L,2L,6L,2L,8L,6L,6L,4L,0L,2L,7L,3L,1L,3L,2L,0L,8L,8L,7L,6L,3L,2L,6L,5L,8L,6L,4L,8L,5L,2L,3L,9L,6L,6L,1L,7L,6L,8L,5L,5L,7L,8L,1L,4L,9L,1L,1L,5L,8L,0L,0L,5L,0L,0L,1L,4L,5L,7L,0L,8L,1L,6L,3L,9L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154975Inst : IEnumerable<long>
{
public static readonly long[] Value=A154975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154975.Bytes);
public long this[int i]=>Value[i];

public static A154975Inst Instance=new A154975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154976
{
public static readonly long[] Value={ 9L,6L,4L,8L,2L,9L,7L,9L,5L,8L,4L,3L,9L,2L,8L,4L,3L,2L,0L,8L,9L,3L,1L,1L,9L,8L,6L,4L,1L,6L,3L,0L,5L,8L,0L,3L,0L,8L,2L,5L,0L,2L,3L,6L,9L,2L,3L,8L,2L,2L,9L,9L,9L,8L,4L,1L,7L,5L,9L,2L,9L,4L,8L,6L,6L,3L,4L,1L,7L,9L,4L,7L,8L,9L,3L,2L,9L,6L,6L,0L,3L,4L,7L,1L,5L,7L,7L,4L,5L,9L,6L,1L,3L,5L,6L,6L,7L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154976Inst : IEnumerable<long>
{
public static readonly long[] Value=A154976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154976.Bytes);
public long this[int i]=>Value[i];

public static A154976Inst Instance=new A154976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154977
{
public static readonly long[] Value={ 9L,4L,9L,3L,6L,7L,8L,6L,2L,1L,2L,6L,0L,1L,3L,3L,4L,4L,4L,7L,2L,2L,4L,3L,5L,6L,5L,1L,0L,9L,5L,0L,1L,5L,1L,5L,7L,6L,9L,8L,3L,8L,5L,5L,0L,7L,3L,8L,8L,3L,8L,5L,9L,1L,4L,8L,6L,2L,5L,1L,2L,3L,0L,8L,3L,8L,5L,4L,8L,5L,8L,0L,6L,1L,9L,4L,0L,6L,7L,2L,5L,3L,8L,3L,6L,7L,0L,6L,5L,9L,2L,6L,0L,9L,2L,0L,5L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154977Inst : IEnumerable<long>
{
public static readonly long[] Value=A154977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154977.Bytes);
public long this[int i]=>Value[i];

public static A154977Inst Instance=new A154977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154978
{
public static readonly long[] Value={ 9L,3L,5L,0L,7L,9L,9L,2L,9L,0L,2L,3L,9L,0L,2L,9L,0L,4L,4L,3L,8L,1L,3L,4L,4L,7L,9L,9L,6L,7L,8L,0L,9L,2L,4L,5L,9L,3L,8L,2L,6L,9L,5L,6L,6L,1L,0L,4L,6L,5L,5L,4L,8L,2L,3L,3L,8L,1L,8L,8L,1L,6L,6L,8L,4L,6L,4L,3L,1L,9L,6L,6L,0L,7L,0L,5L,8L,7L,6L,4L,6L,6L,6L,8L,7L,9L,0L,8L,6L,0L,4L,4L,0L,9L,3L,3L,1L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154978Inst : IEnumerable<long>
{
public static readonly long[] Value=A154978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154978.Bytes);
public long this[int i]=>Value[i];

public static A154978Inst Instance=new A154978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154979
{
public static readonly long[] Value={ 1L,1L,1L,1L,10L,1L,1L,27L,27L,1L,1L,60L,374L,60L,1L,1L,125L,2162L,2162L,125L,1L,1L,254L,9967L,52196L,9967L,254L,1L,1L,511L,42221L,615635L,615635L,42221L,511L,1L,1L,1024L,172780L,5760960L,27955622L,5760960L,172780L,1024L,1L,1L,2049L,697068L,49168044L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154979Inst : IEnumerable<long>
{
public static readonly long[] Value=A154979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154979.Bytes);
public long this[int i]=>Value[i];

public static A154979Inst Instance=new A154979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154980
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,15L,15L,1L,1L,32L,126L,32L,1L,1L,65L,638L,638L,65L,1L,1L,130L,2751L,9340L,2751L,130L,1L,1L,259L,11201L,93755L,93755L,11201L,259L,1L,1L,516L,44740L,809212L,2578550L,809212L,44740L,516L,1L,1L,1029L,177864L,6588864L,51390322L,51390322L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154980Inst : IEnumerable<long>
{
public static readonly long[] Value=A154980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154980.Bytes);
public long this[int i]=>Value[i];

public static A154980Inst Instance=new A154980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154981
{
public static readonly long[] Value={ 11L,13L,17L,19L,31L,41L,47L,61L,67L,71L,89L,101L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,211L,241L,251L,271L,281L,307L,311L,313L,317L,331L,401L,409L,419L,421L,431L,449L,457L,461L,467L,479L,487L,491L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154981Inst : IEnumerable<long>
{
public static readonly long[] Value=A154981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154981.Bytes);
public long this[int i]=>Value[i];

public static A154981Inst Instance=new A154981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154982
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,9L,9L,1L,1L,18L,50L,18L,1L,1L,35L,212L,212L,35L,1L,1L,68L,823L,2024L,823L,68L,1L,1L,133L,3131L,16415L,16415L,3131L,133L,1L,1L,262L,11968L,124890L,291902L,124890L,11968L,262L,1L,1L,519L,46278L,938394L,4619032L,4619032L,938394L,46278L,519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154982Inst : IEnumerable<long>
{
public static readonly long[] Value=A154982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154982.Bytes);
public long this[int i]=>Value[i];

public static A154982Inst Instance=new A154982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154983
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,11L,11L,1L,1L,24L,70L,24L,1L,1L,49L,358L,358L,49L,1L,1L,98L,1559L,4076L,1559L,98L,1L,1L,195L,6361L,40003L,40003L,6361L,195L,1L,1L,388L,25372L,345692L,862598L,345692L,25372L,388L,1L,1L,773L,100640L,2813688L,16569442L,16569442L,2813688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154983Inst : IEnumerable<long>
{
public static readonly long[] Value=A154983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154983.Bytes);
public long this[int i]=>Value[i];

public static A154983Inst Instance=new A154983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154984
{
public static readonly long[] Value={ 1L,1L,1L,1L,10L,1L,1L,29L,29L,1L,1L,66L,418L,66L,1L,1L,139L,2572L,2572L,139L,1L,1L,284L,12215L,65336L,12215L,284L,1L,1L,573L,52531L,818287L,818287L,52531L,573L,1L,1L,1150L,216688L,7906658L,39270110L,7906658L,216688L,1150L,1L,1L,2303L,877934L,68639058L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154984Inst : IEnumerable<long>
{
public static readonly long[] Value=A154984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154984.Bytes);
public long this[int i]=>Value[i];

public static A154984Inst Instance=new A154984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154985
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,17L,17L,1L,1L,38L,154L,38L,1L,1L,79L,872L,872L,79L,1L,1L,160L,3991L,14064L,3991L,160L,1L,1L,321L,16791L,157575L,157575L,16791L,321L,1L,1L,642L,68312L,1451486L,4815630L,1451486L,68312L,642L,1L,1L,1283L,274394L,12266038L,107115116L,107115116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154985Inst : IEnumerable<long>
{
public static readonly long[] Value=A154985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154985.Bytes);
public long this[int i]=>Value[i];

public static A154985Inst Instance=new A154985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154986
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,11L,11L,1L,1L,24L,70L,24L,1L,1L,45L,314L,314L,45L,1L,1L,76L,1079L,2728L,1079L,76L,1L,1L,119L,3045L,16995L,16995L,3045L,119L,1L,1L,176L,7420L,80464L,186758L,80464L,7420L,176L,1L,1L,249L,16164L,307124L,1490862L,1490862L,307124L,16164L,249L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154986Inst : IEnumerable<long>
{
public static readonly long[] Value=A154986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154986.Bytes);
public long this[int i]=>Value[i];

public static A154986Inst Instance=new A154986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154987
{
public static readonly long[] Value={ -2L,4L,4L,13L,20L,13L,41L,69L,69L,41L,183L,268L,264L,268L,183L,1099L,1405L,1080L,1080L,1405L,1099L,7943L,9486L,5970L,4080L,5970L,9486L,7943L,65547L,75775L,43806L,20370L,20370L,43806L,75775L,65547L,604831L,685672L,384552L,149520L,77280L,149520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154987Inst : IEnumerable<long>
{
public static readonly long[] Value=A154987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154987.Bytes);
public long this[int i]=>Value[i];

public static A154987Inst Instance=new A154987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154988
{
public static readonly long[] Value={ 15L,35L,39L,45L,51L,65L,69L,85L,95L,105L,141L,145L,159L,165L,175L,195L,205L,209L,221L,231L,245L,255L,261L,275L,279L,285L,299L,309L,315L,325L,329L,345L,371L,375L,391L,399L,415L,425L,435L,455L,459L,465L,471L,519L,535L,545L,555L,559L,561L,575L,581L,585L,595L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154988Inst : IEnumerable<long>
{
public static readonly long[] Value=A154988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154988.Bytes);
public long this[int i]=>Value[i];

public static A154988Inst Instance=new A154988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154989
{
public static readonly long[] Value={ 2L,1L,1L,10L,-16L,10L,11L,-5L,-5L,11L,36L,-58L,92L,-58L,36L,57L,21L,42L,42L,21L,57L,134L,156L,618L,-376L,618L,156L,134L,247L,1303L,2529L,961L,961L,2529L,1303L,247L,520L,5162L,17524L,12646L,8936L,12646L,17524L,5162L,520L,1013L,19393L,99880L,153472L,89122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154989Inst : IEnumerable<long>
{
public static readonly long[] Value=A154989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154989.Bytes);
public long this[int i]=>Value[i];

public static A154989Inst Instance=new A154989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154990
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,-1L,1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154990Inst : IEnumerable<long>
{
public static readonly long[] Value=A154990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154990.Bytes);
public long this[int i]=>Value[i];

public static A154990Inst Instance=new A154990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154991
{
public static readonly long[] Value={ 2L,1L,1L,17L,-30L,17L,16L,-10L,-10L,16L,72L,-176L,256L,-176L,72L,99L,-57L,78L,78L,-57L,99L,275L,-282L,1557L,-1660L,1557L,-282L,275L,466L,1180L,2904L,490L,490L,2904L,1180L,466L,1058L,5244L,21704L,4580L,15468L,4580L,21704L,5244L,1058L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154991Inst : IEnumerable<long>
{
public static readonly long[] Value=A154991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154991.Bytes);
public long this[int i]=>Value[i];

public static A154991Inst Instance=new A154991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154992
{
public static readonly long[] Value={ 0L,0L,1L,5L,17L,53L,161L,485L,1457L,4373L,13121L,39365L,118097L,354293L,1062881L,3188645L,9565937L,28697813L,86093441L,258280325L,774840977L,2324522933L,6973568801L,20920706405L,62762119217L,188286357653L,564859072961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154992Inst : IEnumerable<long>
{
public static readonly long[] Value=A154992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154992.Bytes);
public long this[int i]=>Value[i];

public static A154992Inst Instance=new A154992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154993
{
public static readonly long[] Value={ 9L,2L,1L,8L,2L,3L,3L,4L,2L,3L,0L,1L,9L,2L,5L,7L,0L,0L,9L,6L,3L,0L,4L,2L,8L,7L,1L,3L,8L,3L,3L,7L,6L,3L,7L,8L,5L,5L,9L,7L,3L,8L,8L,0L,8L,7L,0L,6L,8L,3L,3L,3L,3L,8L,0L,1L,6L,3L,1L,0L,5L,7L,3L,9L,3L,4L,7L,9L,5L,4L,4L,0L,4L,7L,2L,5L,7L,6L,2L,4L,6L,7L,7L,7L,2L,7L,4L,0L,4L,0L,3L,8L,0L,7L,3L,7L,5L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154993Inst : IEnumerable<long>
{
public static readonly long[] Value=A154993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154993.Bytes);
public long this[int i]=>Value[i];

public static A154993Inst Instance=new A154993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154994
{
public static readonly long[] Value={ 9L,0L,9L,4L,7L,8L,5L,4L,0L,0L,7L,2L,3L,4L,2L,2L,0L,3L,8L,5L,3L,3L,1L,0L,9L,6L,7L,7L,8L,3L,0L,5L,8L,0L,5L,6L,8L,6L,1L,6L,9L,7L,8L,7L,2L,5L,0L,2L,5L,0L,1L,1L,6L,1L,9L,2L,6L,3L,0L,9L,2L,1L,7L,6L,7L,9L,0L,7L,8L,8L,0L,9L,2L,4L,9L,5L,0L,3L,8L,2L,4L,5L,1L,0L,0L,4L,1L,1L,4L,2L,9L,0L,5L,8L,8L,8L,9L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154994Inst : IEnumerable<long>
{
public static readonly long[] Value=A154994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154994.Bytes);
public long this[int i]=>Value[i];

public static A154994Inst Instance=new A154994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154995
{
public static readonly long[] Value={ 4L,2L,4L,7L,9L,2L,7L,5L,1L,3L,4L,4L,3L,5L,8L,5L,4L,9L,3L,7L,9L,3L,5L,1L,9L,4L,2L,2L,9L,0L,6L,8L,3L,4L,4L,2L,2L,6L,9L,3L,5L,0L,7L,5L,6L,9L,6L,6L,1L,5L,3L,4L,0L,1L,4L,5L,8L,1L,5L,2L,4L,7L,3L,0L,8L,6L,4L,5L,6L,5L,2L,0L,8L,2L,0L,5L,4L,6L,4L,8L,8L,6L,8L,0L,2L,7L,0L,8L,0L,5L,4L,1L,7L,2L,1L,7L,6L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154995Inst : IEnumerable<long>
{
public static readonly long[] Value=A154995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154995.Bytes);
public long this[int i]=>Value[i];

public static A154995Inst Instance=new A154995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154996
{
public static readonly long[] Value={ 1L,1L,9L,65L,505L,3825L,29225L,222625L,1697625L,12940625L,98655625L,752090625L,5733565625L,43709640625L,333219515625L,2540290390625L,19365842265625L,147635019140625L,1125491941015625L,8580160087890625L,65410639259765625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154996Inst : IEnumerable<long>
{
public static readonly long[] Value=A154996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154996.Bytes);
public long this[int i]=>Value[i];

public static A154996Inst Instance=new A154996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154997
{
public static readonly long[] Value={ 1L,1L,11L,96L,906L,8316L,77076L,711936L,6583896L,60861456L,562685616L,5201957376L,48092312736L,444612597696L,4110444968256L,38001047740416L,351319635490176L,3247949245153536L,30027284535626496L,277602184568365056L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154997Inst : IEnumerable<long>
{
public static readonly long[] Value=A154997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154997.Bytes);
public long this[int i]=>Value[i];

public static A154997Inst Instance=new A154997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154998
{
public static readonly long[] Value={ 3L,2001907169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154998Inst : IEnumerable<long>
{
public static readonly long[] Value=A154998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154998.Bytes);
public long this[int i]=>Value[i];

public static A154998Inst Instance=new A154998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154999
{
public static readonly long[] Value={ 1L,1L,13L,133L,1477L,15925L,173509L,1883413L,20471269L,222402229L,2416608901L,26257155925L,285297665317L,3099884206069L,33681691385797L,365966976355477L,3976399872691813L,43205412115772725L,469446679463465221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154999Inst : IEnumerable<long>
{
public static readonly long[] Value=A154999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154999.Bytes);
public long this[int i]=>Value[i];

public static A154999Inst Instance=new A154999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155000
{
public static readonly long[] Value={ 1L,1L,15L,176L,2248L,27840L,348608L,4347904L,54305280L,677924864L,8464494592L,105679749120L,1319449690112L,16473663471616L,205678490419200L,2567953077764096L,32061620085587968L,400298333039493120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155000Inst : IEnumerable<long>
{
public static readonly long[] Value=A155000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155000.Bytes);
public long this[int i]=>Value[i];

public static A155000Inst Instance=new A155000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155001
{
public static readonly long[] Value={ 1L,1L,17L,225L,3249L,45441L,642897L,9057825L,127809009L,1802444481L,25424248977L,358594243425L,5057894117169L,71339832581121L,1006226869666257L,14192509772837025L,200180922571503729L,2823489006787799361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155001Inst : IEnumerable<long>
{
public static readonly long[] Value=A155001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155001.Bytes);
public long this[int i]=>Value[i];

public static A155001Inst Instance=new A155001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155002
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,3L,2L,2L,5L,5L,3L,4L,5L,12L,8L,5L,6L,10L,12L,29L,13L,8L,10L,15L,24L,29L,70L,21L,13L,16L,25L,36L,58L,70L,169L,34L,21L,26L,40L,60L,87L,140L,169L,408L,55L,34L,42L,65L,96L,145L,210L,338L,408L,985L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155002Inst : IEnumerable<long>
{
public static readonly long[] Value=A155002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155002.Bytes);
public long this[int i]=>Value[i];

public static A155002Inst Instance=new A155002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155003
{
public static readonly long[] Value={ 2L,6L,8L,0L,1L,4L,3L,8L,5L,9L,2L,4L,6L,3L,7L,5L,3L,4L,4L,8L,5L,0L,5L,6L,6L,6L,2L,0L,2L,1L,9L,1L,9L,5L,1L,3L,0L,4L,6L,6L,1L,4L,2L,8L,4L,2L,6L,9L,4L,3L,5L,3L,2L,2L,1L,8L,3L,6L,8L,8L,8L,5L,5L,6L,5L,1L,7L,9L,4L,0L,8L,7L,1L,7L,3L,5L,0L,2L,9L,3L,0L,9L,8L,7L,7L,2L,7L,4L,4L,7L,6L,8L,4L,9L,7L,5L,5L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155003Inst : IEnumerable<long>
{
public static readonly long[] Value=A155003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155003.Bytes);
public long this[int i]=>Value[i];

public static A155003Inst Instance=new A155003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155004
{
public static readonly long[] Value={ 2L,1L,2L,3L,9L,6L,3L,7L,5L,6L,7L,2L,1L,7L,9L,2L,7L,4L,6L,8L,9L,6L,7L,5L,9L,7L,1L,1L,4L,5L,3L,4L,1L,7L,2L,1L,1L,3L,4L,6L,7L,5L,3L,7L,8L,4L,8L,3L,0L,7L,6L,7L,0L,0L,7L,2L,9L,0L,7L,6L,2L,3L,6L,5L,4L,3L,2L,2L,8L,2L,6L,0L,4L,1L,0L,2L,7L,3L,2L,4L,4L,3L,4L,0L,1L,3L,5L,4L,0L,2L,7L,0L,8L,6L,0L,8L,8L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155004Inst : IEnumerable<long>
{
public static readonly long[] Value=A155004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155004.Bytes);
public long this[int i]=>Value[i];

public static A155004Inst Instance=new A155004Inst();

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