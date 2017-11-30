using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A284848
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284848Inst : IEnumerable<long>
{
public static readonly long[] Value=A284848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284848.Bytes);
public long this[int i]=>Value[i];

public static A284848Inst Instance=new A284848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284849
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,5L,6L,6L,5L,5L,4L,4L,4L,3L,4L,4L,4L,3L,4L,4L,4L,3L,4L,4L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284849Inst : IEnumerable<long>
{
public static readonly long[] Value=A284849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284849.Bytes);
public long this[int i]=>Value[i];

public static A284849Inst Instance=new A284849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284850
{
public static readonly long[] Value={ 0L,5L,34L,171L,776L,3361L,14190L,58967L,242452L,989517L,4017146L,16245763L,65514528L,263652473L,1059392902L,4251920559L,17050729004L,68332056229L,273715645458L,1096024843355L,4387586157880L,17560804984785L,70274600998814L,281192547174151L,1125052618233156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284850Inst : IEnumerable<long>
{
public static readonly long[] Value=A284850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284850.Bytes);
public long this[int i]=>Value[i];

public static A284850Inst Instance=new A284850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284947
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,4L,3L,0L,0L,0L,10L,15L,12L,0L,0L,0L,20L,45L,72L,60L,0L,0L,0L,35L,105L,252L,420L,360L,0L,0L,0L,56L,210L,672L,1680L,2880L,2520L,0L,0L,0L,84L,378L,1512L,5040L,12960L,22680L,20160L,0L,0L,0L,120L,630L,3024L,12600L,43200L,113400L,201600L,181440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284947Inst : IEnumerable<long>
{
public static readonly long[] Value=A284947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284947.Bytes);
public long this[int i]=>Value[i];

public static A284947Inst Instance=new A284947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284948
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284948Inst : IEnumerable<long>
{
public static readonly long[] Value=A284948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284948.Bytes);
public long this[int i]=>Value[i];

public static A284948Inst Instance=new A284948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284949
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,5L,4L,1L,1L,9L,15L,6L,1L,1L,19L,50L,37L,9L,1L,1L,35L,160L,183L,76L,12L,1L,1L,71L,502L,877L,542L,142L,16L,1L,1L,135L,1545L,3930L,3523L,1346L,242L,20L,1L,1L,271L,4730L,17185L,21393L,11511L,2980L,390L,25L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284949Inst : IEnumerable<long>
{
public static readonly long[] Value=A284949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284949.Bytes);
public long this[int i]=>Value[i];

public static A284949Inst Instance=new A284949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284950
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,2L,1L,0L,3L,0L,1L,3L,0L,1L,3L,1L,0L,3L,1L,0L,3L,1L,0L,5L,0L,1L,4L,0L,1L,3L,0L,1L,4L,0L,0L,4L,1L,0L,6L,0L,0L,4L,0L,1L,2L,1L,1L,4L,1L,0L,4L,0L,0L,9L,0L,0L,5L,0L,0L,5L,1L,0L,4L,0L,0L,5L,0L,0L,6L,0L,1L,5L,0L,1L,5L,0L,0L,7L,1L,0L,5L,1L,0L,7L,0L,0L,6L,0L,0L,4L,1L,1L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284950Inst : IEnumerable<long>
{
public static readonly long[] Value=A284950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284950.Bytes);
public long this[int i]=>Value[i];

public static A284950Inst Instance=new A284950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284951
{
public static readonly long[] Value={ 2L,8L,24L,30L,60L,90L,120L,210L,420L,630L,840L,1050L,1260L,1680L,1890L,2310L,2730L,3780L,3990L,4200L,4620L,4830L,5460L,6930L,8190L,9240L,10710L,10920L,11550L,13650L,13860L,15960L,16170L,18480L,20790L,21840L,23100L,25410L,27300L,27720L,30030L,39270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284951Inst : IEnumerable<long>
{
public static readonly long[] Value=A284951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284951.Bytes);
public long this[int i]=>Value[i];

public static A284951Inst Instance=new A284951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284952
{
public static readonly long[] Value={ 1L,13455L,166400L,514800L,359424L,1497600L,0L,3369600L,0L,1797120L,0L,2995200L,2764800L,0L,0L,4492800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284952Inst : IEnumerable<long>
{
public static readonly long[] Value=A284952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284952.Bytes);
public long this[int i]=>Value[i];

public static A284952Inst Instance=new A284952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284953
{
public static readonly long[] Value={ 1L,63L,728L,504L,0L,504L,1728L,1512L,0L,0L,0L,1008L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284953Inst : IEnumerable<long>
{
public static readonly long[] Value=A284953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284953.Bytes);
public long this[int i]=>Value[i];

public static A284953Inst Instance=new A284953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284954
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284954Inst : IEnumerable<long>
{
public static readonly long[] Value=A284954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284954.Bytes);
public long this[int i]=>Value[i];

public static A284954Inst Instance=new A284954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284955
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,8L,10L,11L,12L,13L,15L,17L,19L,21L,22L,23L,24L,26L,27L,28L,29L,31L,32L,33L,34L,36L,37L,38L,39L,41L,43L,45L,47L,48L,49L,50L,52L,53L,54L,55L,57L,58L,59L,60L,62L,63L,64L,65L,67L,69L,71L,73L,74L,75L,76L,78L,80L,82L,84L,85L,86L,87L,89L,91L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284955Inst : IEnumerable<long>
{
public static readonly long[] Value=A284955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284955.Bytes);
public long this[int i]=>Value[i];

public static A284955Inst Instance=new A284955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284956
{
public static readonly long[] Value={ 4L,9L,14L,16L,18L,20L,25L,30L,35L,40L,42L,44L,46L,51L,56L,61L,66L,68L,70L,72L,77L,79L,81L,83L,88L,90L,92L,94L,99L,101L,103L,105L,110L,115L,120L,125L,127L,129L,131L,136L,141L,146L,151L,153L,155L,157L,162L,167L,172L,177L,179L,181L,183L,188L,193L,198L,203L,205L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284956Inst : IEnumerable<long>
{
public static readonly long[] Value=A284956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284956.Bytes);
public long this[int i]=>Value[i];

public static A284956Inst Instance=new A284956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284957
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284957Inst : IEnumerable<long>
{
public static readonly long[] Value=A284957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284957.Bytes);
public long this[int i]=>Value[i];

public static A284957Inst Instance=new A284957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284958
{
public static readonly long[] Value={ 2L,4L,6L,7L,8L,9L,11L,13L,15L,17L,18L,19L,20L,22L,24L,26L,28L,29L,30L,31L,33L,34L,35L,36L,38L,39L,40L,41L,43L,44L,45L,46L,48L,50L,52L,54L,55L,56L,57L,59L,61L,63L,65L,66L,67L,68L,70L,72L,74L,76L,77L,78L,79L,81L,83L,85L,87L,88L,89L,90L,92L,93L,94L,95L,97L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284958Inst : IEnumerable<long>
{
public static readonly long[] Value=A284958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284958.Bytes);
public long this[int i]=>Value[i];

public static A284958Inst Instance=new A284958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284959
{
public static readonly long[] Value={ 1L,3L,5L,10L,12L,14L,16L,21L,23L,25L,27L,32L,37L,42L,47L,49L,51L,53L,58L,60L,62L,64L,69L,71L,73L,75L,80L,82L,84L,86L,91L,96L,101L,106L,108L,110L,112L,117L,119L,121L,123L,128L,130L,132L,134L,139L,141L,143L,145L,150L,155L,160L,165L,167L,169L,171L,176L,181L,186L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284959Inst : IEnumerable<long>
{
public static readonly long[] Value=A284959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284959.Bytes);
public long this[int i]=>Value[i];

public static A284959Inst Instance=new A284959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284960
{
public static readonly long[] Value={ 1L,195L,4160L,3900L,5824L,0L,0L,0L,0L,12480L,0L,0L,19200L,0L,16640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284960Inst : IEnumerable<long>
{
public static readonly long[] Value=A284960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284960.Bytes);
public long this[int i]=>Value[i];

public static A284960Inst Instance=new A284960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284961
{
public static readonly long[] Value={ 1L,525L,3500L,15750L,15624L,10500L,36000L,31500L,0L,12600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284961Inst : IEnumerable<long>
{
public static readonly long[] Value=A284961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284961.Bytes);
public long this[int i]=>Value[i];

public static A284961Inst Instance=new A284961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284962
{
public static readonly long[] Value={ 1L,2107L,117992L,92708L,0L,117992L,117648L,539392L,0L,0L,0L,235984L,0L,101136L,0L,471968L,0L,0L,0L,0L,0L,0L,0L,471968L,0L,0L,0L,202272L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1843968L,0L,0L,0L,0L,943936L,0L,0L,0L,0L,0L,0L,0L,404544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284962Inst : IEnumerable<long>
{
public static readonly long[] Value=A284962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284962.Bytes);
public long this[int i]=>Value[i];

public static A284962Inst Instance=new A284962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285076
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285076Inst : IEnumerable<long>
{
public static readonly long[] Value=A285076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285076.Bytes);
public long this[int i]=>Value[i];

public static A285076Inst Instance=new A285076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285077
{
public static readonly long[] Value={ 2L,3L,5L,7L,8L,10L,12L,13L,15L,17L,19L,20L,22L,24L,25L,27L,29L,31L,32L,34L,36L,37L,39L,41L,42L,44L,46L,48L,49L,51L,53L,54L,56L,58L,60L,61L,63L,65L,66L,68L,70L,71L,73L,75L,77L,78L,80L,82L,83L,85L,87L,89L,90L,92L,94L,95L,97L,99L,101L,102L,104L,106L,107L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285077Inst : IEnumerable<long>
{
public static readonly long[] Value=A285077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285077.Bytes);
public long this[int i]=>Value[i];

public static A285077Inst Instance=new A285077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285078
{
public static readonly long[] Value={ 1L,4L,6L,9L,11L,14L,16L,18L,21L,23L,26L,28L,30L,33L,35L,38L,40L,43L,45L,47L,50L,52L,55L,57L,59L,62L,64L,67L,69L,72L,74L,76L,79L,81L,84L,86L,88L,91L,93L,96L,98L,100L,103L,105L,108L,110L,113L,115L,117L,120L,122L,125L,127L,129L,132L,134L,137L,139L,142L,144L,146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285078Inst : IEnumerable<long>
{
public static readonly long[] Value=A285078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285078.Bytes);
public long this[int i]=>Value[i];

public static A285078Inst Instance=new A285078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285079
{
public static readonly long[] Value={ 2L,6L,12L,56L,132L,156L,756L,2756L,4556L,6162L,6972L,7656L,13572L,21756L,31152L,33672L,45156L,61752L,84972L,153272L,166872L,279312L,467172L,626472L,661782L,1273512L,1412532L,1541322L,1568756L,1596432L,1786232L,1867322L,2678132L,2817362L,3416952L,3521252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285079Inst : IEnumerable<long>
{
public static readonly long[] Value=A285079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285079.Bytes);
public long this[int i]=>Value[i];

public static A285079Inst Instance=new A285079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285080
{
public static readonly long[] Value={ 0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285080Inst : IEnumerable<long>
{
public static readonly long[] Value=A285080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285080.Bytes);
public long this[int i]=>Value[i];

public static A285080Inst Instance=new A285080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285081
{
public static readonly long[] Value={ 1L,5L,7L,8L,11L,15L,16L,19L,23L,24L,27L,30L,34L,36L,37L,40L,43L,47L,48L,52L,54L,55L,58L,62L,63L,66L,69L,73L,75L,76L,79L,83L,84L,87L,91L,92L,95L,98L,102L,103L,107L,109L,110L,113L,117L,118L,121L,124L,128L,130L,131L,134L,138L,139L,142L,146L,147L,150L,153L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285081Inst : IEnumerable<long>
{
public static readonly long[] Value=A285081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285081.Bytes);
public long this[int i]=>Value[i];

public static A285081Inst Instance=new A285081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285082
{
public static readonly long[] Value={ 2L,3L,4L,6L,9L,10L,12L,13L,14L,17L,18L,20L,21L,22L,25L,26L,28L,29L,31L,32L,33L,35L,38L,39L,41L,42L,44L,45L,46L,49L,50L,51L,53L,56L,57L,59L,60L,61L,64L,65L,67L,68L,70L,71L,72L,74L,77L,78L,80L,81L,82L,85L,86L,88L,89L,90L,93L,94L,96L,97L,99L,100L,101L,104L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285082Inst : IEnumerable<long>
{
public static readonly long[] Value=A285082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285082.Bytes);
public long this[int i]=>Value[i];

public static A285082Inst Instance=new A285082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285083
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285083Inst : IEnumerable<long>
{
public static readonly long[] Value=A285083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285083.Bytes);
public long this[int i]=>Value[i];

public static A285083Inst Instance=new A285083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285084
{
public static readonly long[] Value={ 2L,3L,6L,9L,13L,14L,18L,20L,21L,24L,28L,29L,32L,35L,39L,41L,42L,45L,49L,50L,53L,56L,60L,62L,63L,66L,70L,71L,74L,78L,79L,82L,85L,89L,90L,94L,96L,97L,100L,104L,105L,108L,112L,113L,116L,119L,123L,125L,126L,129L,132L,136L,137L,141L,143L,144L,147L,151L,152L,155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285084Inst : IEnumerable<long>
{
public static readonly long[] Value=A285084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285084.Bytes);
public long this[int i]=>Value[i];

public static A285084Inst Instance=new A285084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285085
{
public static readonly long[] Value={ 1L,4L,5L,7L,8L,10L,11L,12L,15L,16L,17L,19L,22L,23L,25L,26L,27L,30L,31L,33L,34L,36L,37L,38L,40L,43L,44L,46L,47L,48L,51L,52L,54L,55L,57L,58L,59L,61L,64L,65L,67L,68L,69L,72L,73L,75L,76L,77L,80L,81L,83L,84L,86L,87L,88L,91L,92L,93L,95L,98L,99L,101L,102L,103L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285085Inst : IEnumerable<long>
{
public static readonly long[] Value=A285085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285085.Bytes);
public long this[int i]=>Value[i];

public static A285085Inst Instance=new A285085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285086
{
public static readonly long[] Value={ 1L,2L,3914L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285086Inst : IEnumerable<long>
{
public static readonly long[] Value=A285086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285086.Bytes);
public long this[int i]=>Value[i];

public static A285086Inst Instance=new A285086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285087
{
public static readonly long[] Value={ 2L,13L,21L,46909L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285087Inst : IEnumerable<long>
{
public static readonly long[] Value=A285087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285087.Bytes);
public long this[int i]=>Value[i];

public static A285087Inst Instance=new A285087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285088
{
public static readonly long[] Value={ 2L,3L,8L,3947L,43968L,61681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285088Inst : IEnumerable<long>
{
public static readonly long[] Value=A285088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285088.Bytes);
public long this[int i]=>Value[i];

public static A285088Inst Instance=new A285088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285089
{
public static readonly long[] Value={ 1L,4L,2L,9L,6L,3L,16L,12L,8L,10L,25L,20L,15L,18L,5L,36L,30L,24L,28L,21L,14L,49L,42L,35L,40L,32L,50L,7L,64L,56L,48L,54L,45L,66L,27L,44L,81L,72L,63L,70L,60L,84L,55L,78L,33L,100L,90L,80L,88L,77L,104L,91L,98L,65L,22L,121L,110L,99L,108L,96L,126L,112L,170L,105L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285089Inst : IEnumerable<long>
{
public static readonly long[] Value=A285089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285089.Bytes);
public long this[int i]=>Value[i];

public static A285089Inst Instance=new A285089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285090
{
public static readonly long[] Value={ 1L,4L,2L,9L,6L,3L,16L,12L,8L,5L,25L,20L,15L,21L,7L,36L,30L,24L,32L,27L,10L,49L,42L,35L,45L,55L,18L,11L,64L,56L,48L,60L,91L,28L,39L,13L,81L,72L,63L,77L,112L,40L,75L,85L,14L,100L,90L,80L,96L,135L,54L,119L,133L,50L,17L,121L,110L,99L,117L,160L,70L,171L,189L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285090Inst : IEnumerable<long>
{
public static readonly long[] Value=A285090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285090.Bytes);
public long this[int i]=>Value[i];

public static A285090Inst Instance=new A285090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285091
{
public static readonly long[] Value={ 1L,4L,6L,7L,10L,13L,15L,16L,18L,22L,24L,25L,28L,32L,34L,35L,37L,40L,42L,43L,46L,49L,51L,52L,54L,58L,60L,61L,63L,66L,68L,69L,72L,76L,78L,79L,82L,85L,87L,88L,90L,94L,96L,97L,100L,104L,106L,107L,109L,112L,114L,115L,118L,122L,124L,125L,128L,131L,133L,134L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285091Inst : IEnumerable<long>
{
public static readonly long[] Value=A285091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285091.Bytes);
public long this[int i]=>Value[i];

public static A285091Inst Instance=new A285091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285156
{
public static readonly BigInteger[] Value={ 0L,236L,5742L,166624L,4551741L,130177958L,3791298670L,112247761168L,3359943904563L,101402229839962L,3079694743523175L,94005932598911806L,2881375795751463371L,BigInteger.Parse("88622772444853629882"),BigInteger.Parse("2733801033248087168072") };
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
public class A285156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285156Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285156.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285156.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285156Inst Instance=new A285156Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285157
{
public static readonly BigInteger[] Value={ 0L,950L,42176L,2446130L,133021570L,7586120602L,440991447842L,26071592935186L,1558862253694926L,93999167152474650L,5705081093219095286L,BigInteger.Parse("348057953640435986490"),BigInteger.Parse("21324734520562429889518"),BigInteger.Parse("1311153858462897839643592") };
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
public class A285157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285157Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285157.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285157.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285157Inst Instance=new A285157Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285158
{
public static readonly BigInteger[] Value={ 0L,3752L,314197L,36367674L,3943470769L,448765516394L,52105131287528L,6154165757308640L,735304860260893623L,BigInteger.Parse("88615482354663882652"),BigInteger.Parse("10750513270733637895616"),BigInteger.Parse("1311121613505876821936074") };
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
public class A285158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285158Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285158.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285158.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285158Inst Instance=new A285158Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285159
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285159Inst : IEnumerable<long>
{
public static readonly long[] Value=A285159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285159.Bytes);
public long this[int i]=>Value[i];

public static A285159Inst Instance=new A285159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285160
{
public static readonly long[] Value={ 1L,2L,6L,7L,8L,12L,14L,16L,17L,18L,21L,22L,26L,28L,29L,30L,33L,34L,38L,40L,41L,42L,45L,46L,49L,50L,54L,55L,56L,60L,61L,62L,66L,68L,70L,71L,72L,75L,76L,80L,82L,83L,84L,87L,88L,92L,94L,95L,96L,99L,100L,103L,104L,108L,110L,112L,113L,114L,117L,118L,121L,122L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285160Inst : IEnumerable<long>
{
public static readonly long[] Value=A285160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285160.Bytes);
public long this[int i]=>Value[i];

public static A285160Inst Instance=new A285160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285161
{
public static readonly long[] Value={ 3L,4L,5L,9L,10L,11L,13L,15L,19L,20L,23L,24L,25L,27L,31L,32L,35L,36L,37L,39L,43L,44L,47L,48L,51L,52L,53L,57L,58L,59L,63L,64L,65L,67L,69L,73L,74L,77L,78L,79L,81L,85L,86L,89L,90L,91L,93L,97L,98L,101L,102L,105L,106L,107L,109L,111L,115L,116L,119L,120L,123L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285161Inst : IEnumerable<long>
{
public static readonly long[] Value=A285161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285161.Bytes);
public long this[int i]=>Value[i];

public static A285161Inst Instance=new A285161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285162
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285162Inst : IEnumerable<long>
{
public static readonly long[] Value=A285162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285162.Bytes);
public long this[int i]=>Value[i];

public static A285162Inst Instance=new A285162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285163
{
public static readonly long[] Value={ 2L,4L,5L,6L,9L,10L,13L,14L,18L,20L,22L,23L,24L,27L,28L,31L,32L,36L,37L,38L,42L,43L,44L,48L,50L,52L,53L,54L,57L,58L,62L,64L,65L,66L,69L,70L,73L,74L,78L,79L,80L,84L,86L,88L,89L,90L,93L,94L,98L,100L,101L,102L,105L,106L,109L,110L,114L,115L,116L,120L,122L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285163Inst : IEnumerable<long>
{
public static readonly long[] Value=A285163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285163.Bytes);
public long this[int i]=>Value[i];

public static A285163Inst Instance=new A285163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285164
{
public static readonly long[] Value={ 1L,3L,7L,8L,11L,12L,15L,16L,17L,19L,21L,25L,26L,29L,30L,33L,34L,35L,39L,40L,41L,45L,46L,47L,49L,51L,55L,56L,59L,60L,61L,63L,67L,68L,71L,72L,75L,76L,77L,81L,82L,83L,85L,87L,91L,92L,95L,96L,97L,99L,103L,104L,107L,108L,111L,112L,113L,117L,118L,119L,121L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285164Inst : IEnumerable<long>
{
public static readonly long[] Value=A285164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285164.Bytes);
public long this[int i]=>Value[i];

public static A285164Inst Instance=new A285164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285165
{
public static readonly long[] Value={ 1L,1L,1L,7L,6L,1L,73L,56L,16L,1L,879L,640L,208L,30L,1L,11713L,8256L,2848L,560L,48L,1L,167423L,115456L,41216L,9440L,1240L,70L,1L,2519937L,1710592L,624384L,156592L,25864L,2408L,96L,1L,39458047L,26468352L,9812992L,2613664L,496944L,61712L,4256L,126L,1L,637446145L,423641088L,158883840L,44169600L,9234368L,1377600L,132480L,7008L,160L,1L,10561615871L,6966960128L,2636197888L,756712960L,169378560L,28663040L,3430528L,261648L,10920L,198L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285165Inst : IEnumerable<long>
{
public static readonly long[] Value=A285165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285165.Bytes);
public long this[int i]=>Value[i];

public static A285165Inst Instance=new A285165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285166
{
public static readonly BigInteger[] Value={ 1L,6L,56L,640L,8256L,115456L,1710592L,26468352L,423641088L,6966960128L,117148778496L,2006711795712L,34918458982400L,615857321410560L,10989673088286720L,198124551844921344L,3604297438589878272L,BigInteger.Parse("66099459892606664704"),BigInteger.Parse("1220968511518137122816"),BigInteger.Parse("22700172671958160244736"),BigInteger.Parse("424526793381853406429184") };
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
public class A285166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285166Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285166.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285166.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285166Inst Instance=new A285166Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285167
{
public static readonly BigInteger[] Value={ 1L,16L,208L,2848L,41216L,624384L,9812992L,158883840L,2636197888L,44640468992L,769058340864L,13445805899776L,238091742740480L,4263121901322240L,77082929745887232L,1405899615605096448L,BigInteger.Parse("25841135069123575808"),BigInteger.Parse("478285335973855232000"),BigInteger.Parse("8908149312942805876736"),BigInteger.Parse("166863051347010382725120") };
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
public class A285167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285167Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285167.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285167.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285167Inst Instance=new A285167Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285168
{
public static readonly BigInteger[] Value={ 1L,30L,560L,9440L,156592L,2613664L,44169600L,756712960L,13136471040L,230851792896L,4102116843520L,73626174750720L,1333446495436800L,24347500823838720L,447847464256929792L,8292879605769961472L,BigInteger.Parse("154496591977544417280"),BigInteger.Parse("2894283145228079595520"),BigInteger.Parse("54496565896255729827840"),BigInteger.Parse("1030917988055843180904448") };
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
public class A285168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285168Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285168.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285168.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285168Inst Instance=new A285168Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285169
{
public static readonly BigInteger[] Value={ 1L,48L,1240L,25864L,496944L,9234368L,169378560L,3095526912L,56624998400L,1039080697856L,19147850612736L,354499096477696L,6594549035106304L,123254413518962688L,2314187071702433792L,BigInteger.Parse("43639888872132837376"),BigInteger.Parse("826342030562687975424"),BigInteger.Parse("15708220978126028537856"),BigInteger.Parse("299700151992553060696064") };
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
public class A285169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285169Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285169.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285169.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285169Inst Instance=new A285169Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285170
{
public static readonly BigInteger[] Value={ 1L,70L,2408L,61712L,1377600L,28663040L,574139904L,11259283200L,218198045184L,4201424145408L,80643838062592L,1546163834421248L,29648492642205696L,569064815285895168L,10938353882330562560UL,BigInteger.Parse("210623966993992122368"),BigInteger.Parse("4063570313100983795712"),BigInteger.Parse("78558517204195934732288"),BigInteger.Parse("1521880839150792578433024") };
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
public class A285170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285170Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285170.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285170.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285170Inst Instance=new A285170Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285171
{
public static readonly BigInteger[] Value={ 1L,96L,4256L,132480L,3430528L,80104448L,1758695424L,37158281984L,765948707328L,15534537453568L,311681600004096L,6208696187633664L,123091007914770432L,2432892993997766656L,BigInteger.Parse("47996192255918997504"),BigInteger.Parse("945900094339720151040"),BigInteger.Parse("18633845662960307929088"),BigInteger.Parse("367087117998177057243136"),BigInteger.Parse("7234078496745600613089280") };
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
public class A285171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285171Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285171.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285171.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285171Inst Instance=new A285171Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285220
{
public static readonly long[] Value={ 2L,30L,49L,54L,56L,85L,91L,104L,135L,175L,195L,203L,266L,303L,343L,409L,421L,427L,445L,448L,523L,538L,607L,622L,780L,1006L,1109L,1186L,1338L,1341L,1453L,1591L,1629L,1707L,1826L,1852L,1884L,1949L,2033L,2039L,2056L,2154L,2408L,2444L,2495L,2559L,3134L,3227L,3240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285220Inst : IEnumerable<long>
{
public static readonly long[] Value=A285220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285220.Bytes);
public long this[int i]=>Value[i];

public static A285220Inst Instance=new A285220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285221
{
public static readonly long[] Value={ 1L,2L,660L,1564L,1610L,9690L,39102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285221Inst : IEnumerable<long>
{
public static readonly long[] Value=A285221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285221.Bytes);
public long this[int i]=>Value[i];

public static A285221Inst Instance=new A285221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285222
{
public static readonly long[] Value={ 2L,3L,4L,7L,12L,39L,49L,56L,76L,91L,216L,221L,235L,272L,277L,331L,345L,362L,385L,655L,686L,749L,1023L,1591L,1742L,1825L,1836L,1911L,2179L,2511L,2638L,2951L,3004L,3327L,3692L,4743L,4868L,5546L,5658L,5997L,6032L,7867L,8261L,8620L,8811L,13762L,13950L,14150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285222Inst : IEnumerable<long>
{
public static readonly long[] Value=A285222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285222.Bytes);
public long this[int i]=>Value[i];

public static A285222Inst Instance=new A285222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285223
{
public static readonly long[] Value={ 2L,3L,8L,15L,18L,34L,106L,169L,404L,411L,421L,501L,504L,558L,586L,616L,822L,1051L,1573L,1791L,1894L,1935L,2178L,2536L,2823L,2908L,5002L,5037L,5383L,5826L,6418L,8778L,8968L,9816L,9928L,11512L,12011L,12052L,12524L,13117L,13268L,13640L,15614L,16657L,17938L,19869L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285223Inst : IEnumerable<long>
{
public static readonly long[] Value=A285223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285223.Bytes);
public long this[int i]=>Value[i];

public static A285223Inst Instance=new A285223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285224
{
public static readonly long[] Value={ 3L,4L,5L,7L,11L,28L,45L,47L,71L,115L,135L,205L,230L,258L,408L,409L,665L,703L,915L,934L,3912L,5031L,5746L,6078L,6391L,7979L,11267L,11296L,14666L,17555L,22073L,23583L,30029L,36150L,51253L,54365L,57557L,68475L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285224Inst : IEnumerable<long>
{
public static readonly long[] Value=A285224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285224.Bytes);
public long this[int i]=>Value[i];

public static A285224Inst Instance=new A285224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285225
{
public static readonly long[] Value={ 17L,53L,71L,1069L,1087L,1249L,1429L,1447L,1483L,1609L,1627L,1663L,1753L,1861L,1933L,1951L,2239L,2293L,2347L,2383L,2437L,2473L,2617L,2671L,2707L,2833L,2851L,3049L,3067L,3229L,3319L,3373L,3391L,3463L,3517L,3571L,3607L,3643L,3733L,3823L,3931L,4057L,4093L,4129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285225Inst : IEnumerable<long>
{
public static readonly long[] Value=A285225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285225.Bytes);
public long this[int i]=>Value[i];

public static A285225Inst Instance=new A285225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285226
{
public static readonly long[] Value={ 5L,19L,37L,73L,1289L,1487L,1559L,1667L,1847L,1973L,2099L,2297L,2459L,2477L,2549L,2657L,2693L,2729L,2819L,2837L,2909L,2927L,2963L,3089L,3359L,3449L,3467L,3539L,3557L,3593L,3719L,3863L,3881L,3917L,4079L,4259L,4349L,4457L,4493L,4547L,4583L,4637L,4673L,4691L,4817L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285226Inst : IEnumerable<long>
{
public static readonly long[] Value=A285226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285226.Bytes);
public long this[int i]=>Value[i];

public static A285226Inst Instance=new A285226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285227
{
public static readonly long[] Value={ 7L,59L,1999L,3889L,4789L,4969L,4987L,5689L,5779L,5869L,6679L,6949L,6967L,7489L,7669L,7687L,7759L,7867L,7993L,8389L,8677L,8839L,8893L,8929L,9199L,9397L,9649L,9739L,9829L,9883L,9973L,18899L,19889L,19979L,19997L,28979L,29789L,29879L,35999L,36899L,37799L,37889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285227Inst : IEnumerable<long>
{
public static readonly long[] Value=A285227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285227.Bytes);
public long this[int i]=>Value[i];

public static A285227Inst Instance=new A285227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285228
{
public static readonly long[] Value={ 79L,97L,6899L,8699L,8969L,9689L,9887L,49999L,68899L,69997L,77899L,78889L,78979L,79699L,79987L,85999L,88789L,88897L,88969L,89599L,89689L,89779L,89797L,89959L,89977L,94999L,95989L,96799L,96979L,96997L,97789L,97879L,97987L,98689L,98779L,98869L,98887L,99679L,99787L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285228Inst : IEnumerable<long>
{
public static readonly long[] Value=A285228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285228.Bytes);
public long this[int i]=>Value[i];

public static A285228Inst Instance=new A285228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285229
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,2L,1L,1L,0L,2L,3L,1L,1L,0L,3L,4L,3L,1L,1L,0L,4L,8L,5L,3L,1L,1L,0L,5L,11L,10L,5L,3L,1L,1L,0L,6L,18L,16L,11L,5L,3L,1L,1L,0L,8L,25L,29L,18L,11L,5L,3L,1L,1L,0L,10L,38L,44L,34L,19L,11L,5L,3L,1L,1L,0L,12L,52L,72L,55L,36L,19L,11L,5L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285229Inst : IEnumerable<long>
{
public static readonly long[] Value=A285229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285229.Bytes);
public long this[int i]=>Value[i];

public static A285229Inst Instance=new A285229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285230
{
public static readonly long[] Value={ 1L,1L,3L,5L,11L,19L,37L,63L,115L,195L,339L,566L,957L,1573L,2599L,4217L,6842L,10962L,17531L,27767L,43862L,68769L,107469L,166942L,258461L,398124L,611237L,934356L,1423724L,2161145L,3270560L,4932647L,7418099L,11121610L,16629101L,24794130L,36874451L,54698714L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285230Inst : IEnumerable<long>
{
public static readonly long[] Value=A285230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285230.Bytes);
public long this[int i]=>Value[i];

public static A285230Inst Instance=new A285230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285231
{
public static readonly BigInteger[] Value={ 1L,8L,59L,463L,3978L,37566L,388728L,4385592L,53653680L,708126480L,10034314560L,152001161280L,2451821339520L,41964428419200L,759698874547200L,14505012898790400L,291323663566387200L,6140173922952652800L,BigInteger.Parse("135515391451776000000"),BigInteger.Parse("3125606951427609600000") };
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
public class A285231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285231Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285231.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285231.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285231Inst Instance=new A285231Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285232
{
public static readonly BigInteger[] Value={ 1L,12L,119L,1177L,12217L,135302L,1606446L,20450052L,278604252L,4051377504L,62702222112L,1029832270848L,17899305402240L,328353314855040L,6341705227082880L,128655706986282240L,2735782096305749760L,BigInteger.Parse("60855815849067648000"),BigInteger.Parse("1413487524282196608000") };
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
public class A285232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285232Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285232.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285232.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285232Inst Instance=new A285232Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285233
{
public static readonly BigInteger[] Value={ 1L,17L,221L,2724L,34009L,441383L,6020276L,86673088L,1318681308L,21194234508L,359421505224L,6421154849208L,120637782989568L,2379195625677696L,49167226489281408L,1062833010282628992L,BigInteger.Parse("23992442301958329600"),BigInteger.Parse("564697104190192569600"),BigInteger.Parse("13836823816466433139200") };
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
public class A285233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285233Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285233.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285233.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285233Inst Instance=new A285233Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285234
{
public static readonly BigInteger[] Value={ 1L,23L,382L,5780L,86029L,1301673L,20338679L,330737236L,5618265376L,99849949772L,1857170751804L,36135886878072L,734947859916792L,15608257104179952L,345724111468700496L,7977315239656638912L,BigInteger.Parse("191516062334747746752"),BigInteger.Parse("4778050475554642998144"),BigInteger.Parse("123731984754223222096512") };
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
public class A285234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285234Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285234.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285234.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285234Inst Instance=new A285234Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285235
{
public static readonly BigInteger[] Value={ 1L,30L,622L,11378L,199809L,3499572L,62333543L,1141073295L,21593291506L,423749322362L,8637159909596L,182967605341204L,4028364756058464L,92147187469290768L,2188667860854515856L,BigInteger.Parse("53939340317601471888"),BigInteger.Parse("1378181549321980128288"),BigInteger.Parse("36476226109960185948768") };
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
public class A285235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285235Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285235.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285235.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285235Inst Instance=new A285235Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285268
{
public static readonly long[] Value={ 1L,2L,4L,3L,9L,15L,4L,16L,40L,64L,5L,25L,85L,205L,325L,6L,36L,156L,516L,1236L,1956L,7L,49L,259L,1099L,3619L,8659L,13699L,8L,64L,400L,2080L,8800L,28960L,69280L,109600L,9L,81L,585L,3609L,18729L,79209L,260649L,623529L,986409L,10L,100L,820L,5860L,36100L,187300L,792100L,2606500L,6235300L,9864100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285268Inst : IEnumerable<long>
{
public static readonly long[] Value=A285268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285268.Bytes);
public long this[int i]=>Value[i];

public static A285268Inst Instance=new A285268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285269
{
public static readonly long[] Value={ 0L,3L,3L,4L,4L,5L,5L,6L,6L,9L,7L,8L,7L,9L,10L,10L,9L,12L,10L,11L,13L,11L,14L,13L,14L,13L,14L,16L,16L,15L,15L,16L,17L,18L,19L,14L,22L,19L,18L,16L,22L,18L,24L,20L,22L,22L,20L,23L,24L,22L,23L,21L,25L,27L,24L,27L,26L,25L,27L,25L,23L,33L,28L,25L,29L,28L,31L,30L,33L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285269Inst : IEnumerable<long>
{
public static readonly long[] Value=A285269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285269.Bytes);
public long this[int i]=>Value[i];

public static A285269Inst Instance=new A285269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285270
{
public static readonly BigInteger[] Value={ 1L,2L,14L,180L,3340L,80600L,2389704L,83965616L,3409634960L,157077960480L,8093278209760L,461113571640128L,28784033772836544L,1953535902100115840L,BigInteger.Parse("143219579014652040320"),BigInteger.Parse("11279408109860685024000"),BigInteger.Parse("949705205977314865582336"),BigInteger.Parse("85131076752851318807814656"),BigInteger.Parse("8094279370190580822082014720") };
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
public class A285270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285270Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285270.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285270.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285270Inst Instance=new A285270Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285271
{
public static readonly long[] Value={ 11L,15L,22L,33L,44L,48L,55L,66L,77L,88L,99L,115L,122L,124L,126L,128L,155L,162L,168L,175L,184L,212L,222L,244L,248L,264L,288L,324L,333L,336L,366L,384L,396L,412L,424L,444L,448L,488L,515L,555L,636L,648L,666L,672L,728L,777L,784L,816L,824L,848L,864L,888L,936L,999L,1111L,1112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285271Inst : IEnumerable<long>
{
public static readonly long[] Value=A285271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285271.Bytes);
public long this[int i]=>Value[i];

public static A285271Inst Instance=new A285271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285272
{
public static readonly long[] Value={ 3L,21L,179L,1607L,14087L,119749L,994775L,8139609L,65978747L,531817661L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285272Inst : IEnumerable<long>
{
public static readonly long[] Value=A285272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285272.Bytes);
public long this[int i]=>Value[i];

public static A285272Inst Instance=new A285272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285273
{
public static readonly long[] Value={ 2L,4L,4L,8L,8L,32L,8L,32L,8L,32L,8L,128L,16L,32L,64L,128L,8L,256L,4L,256L,128L,128L,4L,1024L,64L,128L,32L,512L,64L,8192L,16L,4096L,64L,128L,256L,2048L,16L,16L,64L,4096L,32L,16384L,32L,2048L,512L,128L,8L,8192L,32L,2048L,256L,1024L,32L,4096L,512L,8192L,64L,512L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285273Inst : IEnumerable<long>
{
public static readonly long[] Value=A285273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285273.Bytes);
public long this[int i]=>Value[i];

public static A285273Inst Instance=new A285273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285274
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285274Inst : IEnumerable<long>
{
public static readonly long[] Value=A285274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285274.Bytes);
public long this[int i]=>Value[i];

public static A285274Inst Instance=new A285274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285275
{
public static readonly long[] Value={ 1L,6L,8L,9L,13L,17L,22L,23L,27L,31L,36L,37L,41L,45L,50L,51L,55L,59L,63L,68L,70L,71L,75L,79L,83L,88L,89L,94L,96L,97L,101L,105L,110L,111L,115L,119L,124L,125L,129L,133L,137L,142L,144L,145L,149L,153L,158L,159L,163L,167L,172L,173L,177L,181L,185L,190L,192L,193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285275Inst : IEnumerable<long>
{
public static readonly long[] Value=A285275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285275.Bytes);
public long this[int i]=>Value[i];

public static A285275Inst Instance=new A285275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285276
{
public static readonly long[] Value={ 2L,3L,4L,5L,7L,10L,11L,12L,14L,15L,16L,18L,19L,20L,21L,24L,25L,26L,28L,29L,30L,32L,33L,34L,35L,38L,39L,40L,42L,43L,44L,46L,47L,48L,49L,52L,53L,54L,56L,57L,58L,60L,61L,62L,64L,65L,66L,67L,69L,72L,73L,74L,76L,77L,78L,80L,81L,82L,84L,85L,86L,87L,90L,91L,92L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285276Inst : IEnumerable<long>
{
public static readonly long[] Value=A285276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285276.Bytes);
public long this[int i]=>Value[i];

public static A285276Inst Instance=new A285276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285277
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285277Inst : IEnumerable<long>
{
public static readonly long[] Value=A285277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285277.Bytes);
public long this[int i]=>Value[i];

public static A285277Inst Instance=new A285277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285278
{
public static readonly long[] Value={ 2L,3L,7L,11L,15L,20L,21L,26L,28L,29L,33L,37L,42L,43L,47L,51L,56L,57L,61L,65L,69L,74L,76L,77L,81L,85L,90L,91L,95L,99L,104L,105L,109L,113L,117L,122L,124L,125L,129L,133L,138L,139L,143L,147L,152L,153L,157L,161L,165L,170L,172L,173L,177L,181L,186L,187L,191L,195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285278Inst : IEnumerable<long>
{
public static readonly long[] Value=A285278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285278.Bytes);
public long this[int i]=>Value[i];

public static A285278Inst Instance=new A285278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285279
{
public static readonly long[] Value={ 1L,4L,5L,6L,8L,9L,10L,12L,13L,14L,16L,17L,18L,19L,22L,23L,24L,25L,27L,30L,31L,32L,34L,35L,36L,38L,39L,40L,41L,44L,45L,46L,48L,49L,50L,52L,53L,54L,55L,58L,59L,60L,62L,63L,64L,66L,67L,68L,70L,71L,72L,73L,75L,78L,79L,80L,82L,83L,84L,86L,87L,88L,89L,92L,93L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285279Inst : IEnumerable<long>
{
public static readonly long[] Value=A285279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285279.Bytes);
public long this[int i]=>Value[i];

public static A285279Inst Instance=new A285279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285280
{
public static readonly long[] Value={ 1L,3L,1L,9L,4L,1L,27L,14L,5L,1L,81L,46L,19L,6L,1L,243L,162L,65L,24L,7L,1L,729L,574L,247L,84L,29L,8L,1L,2187L,2042L,955L,332L,103L,34L,9L,1L,6561L,7270L,3733L,1336L,417L,122L,39L,10L,1L,19683L,25890L,14649L,5478L,1717L,502L,141L,44L,11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285280Inst : IEnumerable<long>
{
public static readonly long[] Value=A285280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285280.Bytes);
public long this[int i]=>Value[i];

public static A285280Inst Instance=new A285280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285281
{
public static readonly long[] Value={ 1L,4L,1L,16L,5L,1L,64L,23L,6L,1L,256L,101L,30L,7L,1L,1024L,467L,138L,37L,8L,1L,4096L,2165L,694L,175L,44L,9L,1L,16384L,10055L,3526L,925L,212L,51L,10L,1L,65536L,46709L,18012L,4977L,1156L,249L,58L,11L,1L,262144L,216995L,92140L,27067L,6428L,1387L,286L,65L,12L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285281Inst : IEnumerable<long>
{
public static readonly long[] Value=A285281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285281.Bytes);
public long this[int i]=>Value[i];

public static A285281Inst Instance=new A285281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285282
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,8L,18L,57L,239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285282Inst : IEnumerable<long>
{
public static readonly long[] Value=A285282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285282.Bytes);
public long this[int i]=>Value[i];

public static A285282Inst Instance=new A285282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285283
{
public static readonly long[] Value={ 1L,4L,9L,15L,22L,32L,41L,57L,74L,94L,120L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285283Inst : IEnumerable<long>
{
public static readonly long[] Value=A285283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285283.Bytes);
public long this[int i]=>Value[i];

public static A285283Inst Instance=new A285283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285348
{
public static readonly long[] Value={ 1L,2L,0L,-4L,-2L,6L,8L,-4L,-16L,-6L,20L,24L,-12L,-44L,-16L,52L,62L,-28L,-108L,-40L,122L,144L,-64L,-244L,-88L,266L,308L,-136L,-508L,-180L,544L,624L,-272L,-1008L,-356L,1060L,1206L,-524L,-1920L,-672L,1988L,2244L,-968L,-3524L,-1224L,3606L,4048L,-1732L,-6284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285348Inst : IEnumerable<long>
{
public static readonly long[] Value=A285348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285348.Bytes);
public long this[int i]=>Value[i];

public static A285348Inst Instance=new A285348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285349
{
public static readonly long[] Value={ 1L,-2L,4L,-4L,2L,2L,-8L,12L,-12L,6L,8L,-24L,36L,-36L,16L,20L,-62L,92L,-88L,40L,46L,-144L,208L,-196L,88L,102L,-308L,440L,-412L,180L,208L,-624L,884L,-816L,356L,404L,-1206L,1692L,-1552L,672L,760L,-2244L,3128L,-2852L,1224L,1378L,-4048L,5612L,-5084L,2174L,2428L,-7104L,9796L,-8836L,3760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285349Inst : IEnumerable<long>
{
public static readonly long[] Value=A285349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285349.Bytes);
public long this[int i]=>Value[i];

public static A285349Inst Instance=new A285349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285350
{
public static readonly long[] Value={ 1L,-4L,12L,-24L,36L,-36L,8L,56L,-148L,228L,-228L,80L,248L,-688L,1048L,-1048L,420L,896L,-2588L,3920L,-3884L,1648L,2864L,-8488L,12744L,-12516L,5440L,8400L,-25176L,37480L,-36504L,16032L,22892L,-69024L,101968L,-98504L,43468L,58736L,-177584L,260416L,-249732L,110328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285350Inst : IEnumerable<long>
{
public static readonly long[] Value=A285350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285350.Bytes);
public long this[int i]=>Value[i];

public static A285350Inst Instance=new A285350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285351
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285351Inst : IEnumerable<long>
{
public static readonly long[] Value=A285351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285351.Bytes);
public long this[int i]=>Value[i];

public static A285351Inst Instance=new A285351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285352
{
public static readonly long[] Value={ 1L,2L,5L,7L,8L,10L,11L,12L,15L,16L,17L,19L,21L,23L,24L,25L,27L,29L,30L,32L,33L,35L,36L,37L,39L,41L,42L,44L,45L,46L,49L,50L,51L,54L,55L,56L,58L,60L,61L,63L,64L,65L,68L,69L,70L,72L,74L,76L,77L,78L,80L,82L,84L,85L,86L,88L,90L,91L,93L,94L,95L,98L,99L,100L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285352Inst : IEnumerable<long>
{
public static readonly long[] Value=A285352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285352.Bytes);
public long this[int i]=>Value[i];

public static A285352Inst Instance=new A285352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285353
{
public static readonly long[] Value={ 1L,3L,7L,9L,13L,16L,19L,21L,25L,27L,31L,34L,37L,39L,43L,46L,48L,52L,55L,57L,61L,63L,67L,70L,73L,75L,79L,81L,85L,88L,91L,93L,97L,100L,102L,106L,109L,111L,115L,117L,121L,124L,127L,129L,133L,136L,138L,142L,144L,148L,151L,154L,156L,160L,163L,165L,169L,171L,175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285353Inst : IEnumerable<long>
{
public static readonly long[] Value=A285353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285353.Bytes);
public long this[int i]=>Value[i];

public static A285353Inst Instance=new A285353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285354
{
public static readonly long[] Value={ 2L,4L,5L,6L,8L,10L,11L,12L,14L,15L,17L,18L,20L,22L,23L,24L,26L,28L,29L,30L,32L,33L,35L,36L,38L,40L,41L,42L,44L,45L,47L,49L,50L,51L,53L,54L,56L,58L,59L,60L,62L,64L,65L,66L,68L,69L,71L,72L,74L,76L,77L,78L,80L,82L,83L,84L,86L,87L,89L,90L,92L,94L,95L,96L,98L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285354Inst : IEnumerable<long>
{
public static readonly long[] Value=A285354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285354.Bytes);
public long this[int i]=>Value[i];

public static A285354Inst Instance=new A285354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285355
{
public static readonly long[] Value={ 0L,0L,1L,-2L,-1L,6L,-3L,-8L,12L,2L,-22L,16L,22L,-42L,2L,58L,-51L,-42L,106L,-20L,-131L,124L,84L,-232L,56L,276L,-271L,-176L,486L,-120L,-561L,566L,340L,-984L,257L,1094L,-1121L,-618L,1890L,-536L,-2038L,2112L,1102L,-3462L,1028L,3672L,-3846L,-1946L,6178L,-1862L,-6457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285355Inst : IEnumerable<long>
{
public static readonly long[] Value=A285355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285355.Bytes);
public long this[int i]=>Value[i];

public static A285355Inst Instance=new A285355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285356
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,15L,16L,17L,18L,19L,21L,22L,23L,24L,26L,28L,29L,30L,31L,32L,36L,37L,38L,40L,41L,45L,46L,47L,48L,51L,55L,57L,58L,59L,66L,67L,70L,71L,78L,79L,80L,84L,92L,93L,94L,108L,109L,120L,136L,137L,155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285356Inst : IEnumerable<long>
{
public static readonly long[] Value=A285356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285356.Bytes);
public long this[int i]=>Value[i];

public static A285356Inst Instance=new A285356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285357
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,11L,11L,1L,1L,26L,64L,26L,1L,1L,57L,282L,282L,57L,1L,1L,120L,1071L,2072L,1071L,120L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285357Inst : IEnumerable<long>
{
public static readonly long[] Value=A285357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285357.Bytes);
public long this[int i]=>Value[i];

public static A285357Inst Instance=new A285357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285358
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285358Inst : IEnumerable<long>
{
public static readonly long[] Value=A285358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285358.Bytes);
public long this[int i]=>Value[i];

public static A285358Inst Instance=new A285358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285359
{
public static readonly long[] Value={ 3L,7L,10L,13L,17L,21L,24L,27L,31L,34L,37L,41L,44L,47L,51L,55L,58L,61L,65L,69L,72L,75L,79L,82L,85L,89L,92L,95L,99L,103L,106L,109L,113L,116L,119L,123L,126L,129L,133L,137L,140L,143L,147L,150L,153L,157L,160L,163L,167L,171L,174L,177L,181L,185L,188L,191L,195L,198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285359Inst : IEnumerable<long>
{
public static readonly long[] Value=A285359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285359.Bytes);
public long this[int i]=>Value[i];

public static A285359Inst Instance=new A285359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285360
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,8L,9L,11L,12L,14L,15L,16L,18L,19L,20L,22L,23L,25L,26L,28L,29L,30L,32L,33L,35L,36L,38L,39L,40L,42L,43L,45L,46L,48L,49L,50L,52L,53L,54L,56L,57L,59L,60L,62L,63L,64L,66L,67L,68L,70L,71L,73L,74L,76L,77L,78L,80L,81L,83L,84L,86L,87L,88L,90L,91L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285360Inst : IEnumerable<long>
{
public static readonly long[] Value=A285360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285360.Bytes);
public long this[int i]=>Value[i];

public static A285360Inst Instance=new A285360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285361
{
public static readonly long[] Value={ 0L,1L,11L,64L,282L,1071L,3729L,12310L,39296L,122773L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285361Inst : IEnumerable<long>
{
public static readonly long[] Value=A285361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285361.Bytes);
public long this[int i]=>Value[i];

public static A285361Inst Instance=new A285361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285362
{
public static readonly long[] Value={ 1L,4L,2L,15L,12L,3L,60L,58L,28L,4L,262L,273L,185L,55L,5L,1243L,1329L,1094L,495L,96L,6L,6358L,6839L,6293L,3757L,1148L,154L,7L,34835L,37423L,36619L,26421L,11122L,2380L,232L,8L,203307L,217606L,219931L,180482L,96454L,28975L,4518L,333L,9L,1257913L,1340597L,1376929L,1230737L,787959L,308127L,67898L,7995L,460L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285362Inst : IEnumerable<long>
{
public static readonly long[] Value=A285362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285362.Bytes);
public long this[int i]=>Value[i];

public static A285362Inst Instance=new A285362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285363
{
public static readonly long[] Value={ 1L,4L,15L,60L,262L,1243L,6358L,34835L,203307L,1257913L,8216945L,56463487L,406868167L,3065920770L,24099977863L,197179545722L,1675846476148L,14769104672839L,134745258569108L,1270767279092285L,12371426210292311L,124173909409948575L,1283498833928098171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285363Inst : IEnumerable<long>
{
public static readonly long[] Value=A285363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285363.Bytes);
public long this[int i]=>Value[i];

public static A285363Inst Instance=new A285363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285412
{
public static readonly long[] Value={ 1L,3L,4L,6L,9L,11L,14L,16L,17L,19L,20L,22L,23L,25L,28L,30L,33L,35L,36L,38L,41L,43L,48L,50L,53L,55L,56L,58L,61L,63L,66L,68L,69L,71L,74L,76L,81L,83L,86L,88L,89L,91L,94L,96L,99L,101L,102L,104L,105L,107L,108L,110L,113L,115L,118L,120L,121L,123L,124L,126L,127L,129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285412Inst : IEnumerable<long>
{
public static readonly long[] Value=A285412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285412.Bytes);
public long this[int i]=>Value[i];

public static A285412Inst Instance=new A285412Inst();

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