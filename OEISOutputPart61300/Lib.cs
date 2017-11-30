using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A076234
{
public static readonly long[] Value={ 1L,6L,120L,672L,30240L,32760L,33550336L,459818240L,1379454720L,8589869056L,31998395520L,51001180160L,137438691328L,153003540480L,30823866178560L,796928461056000L,6088728021160320L,212517062615531520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076234Inst : IEnumerable<long>
{
public static readonly long[] Value=A076234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076234.Bytes);
public long this[int i]=>Value[i];

public static A076234Inst Instance=new A076234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076235
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,2L,3L,3L,3L,3L,4L,5L,6L,5L,6L,6L,7L,7L,8L,9L,12L,10L,11L,11L,11L,11L,12L,15L,16L,8L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L,11L,11L,12L,12L,12L,12L,13L,13L,28L,29L,29L,30L,31L,31L,15L,15L,15L,15L,16L,17L,18L,18L,18L,18L,19L,19L,20L,20L,20L,20L,21L,21L,22L,22L,22L,22L,22L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076235Inst : IEnumerable<long>
{
public static readonly long[] Value=A076235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076235.Bytes);
public long this[int i]=>Value[i];

public static A076235Inst Instance=new A076235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076236
{
public static readonly long[] Value={ 1L,0L,7L,7L,8L,9L,10L,10L,10L,10L,12L,12L,12L,12L,13L,13L,13L,14L,15L,16L,16L,16L,16L,16L,17L,17L,17L,18L,19L,19L,19L,20L,20L,20L,21L,22L,22L,22L,22L,23L,23L,24L,24L,24L,24L,25L,25L,25L,25L,25L,26L,26L,27L,28L,28L,28L,30L,30L,30L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076236Inst : IEnumerable<long>
{
public static readonly long[] Value=A076236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076236.Bytes);
public long this[int i]=>Value[i];

public static A076236Inst Instance=new A076236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076237
{
public static readonly long[] Value={ 0L,0L,0L,0L,3L,3L,3L,1L,8L,8L,10L,9L,8L,8L,8L,7L,6L,6L,7L,8L,7L,6L,5L,4L,5L,4L,3L,4L,5L,4L,3L,4L,3L,2L,2L,2L,2L,1L,0L,0L,40L,0L,0L,43L,43L,44L,44L,45L,45L,45L,47L,48L,49L,50L,50L,50L,53L,53L,53L,55L,55L,55L,55L,55L,56L,56L,56L,56L,56L,56L,57L,58L,59L,59L,60L,62L,63L,63L,64L,65L,65L,65L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076237Inst : IEnumerable<long>
{
public static readonly long[] Value=A076237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076237.Bytes);
public long this[int i]=>Value[i];

public static A076237Inst Instance=new A076237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076238
{
public static readonly long[] Value={ 0L,3L,1L,8L,8L,9L,8L,8L,7L,6L,8L,7L,6L,4L,5L,4L,3L,4L,4L,4L,3L,2L,2L,2L,1L,0L,0L,0L,43L,43L,44L,45L,45L,45L,47L,48L,50L,50L,50L,53L,53L,55L,55L,55L,55L,56L,56L,56L,56L,56L,58L,59L,60L,62L,63L,63L,65L,65L,65L,68L,68L,68L,68L,68L,69L,69L,69L,69L,70L,70L,72L,72L,73L,74L,74L,76L,78L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076238Inst : IEnumerable<long>
{
public static readonly long[] Value=A076238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076238.Bytes);
public long this[int i]=>Value[i];

public static A076238Inst Instance=new A076238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076239
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,3L,1L,6L,3L,2L,4L,1L,11L,10L,10L,8L,6L,6L,7L,8L,6L,4L,3L,2L,2L,0L,26L,0L,0L,28L,28L,29L,28L,27L,28L,28L,30L,29L,28L,30L,29L,31L,31L,30L,29L,29L,28L,28L,27L,26L,28L,29L,29L,30L,30L,29L,31L,30L,29L,32L,31L,30L,29L,28L,29L,28L,27L,26L,26L,25L,26L,26L,26L,26L,26L,28L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076239Inst : IEnumerable<long>
{
public static readonly long[] Value=A076239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076239.Bytes);
public long this[int i]=>Value[i];

public static A076239Inst Instance=new A076239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076240
{
public static readonly long[] Value={ 1L,2L,1L,3L,9L,2L,8L,10L,14L,22L,3L,9L,15L,19L,23L,29L,41L,39L,63L,69L,2L,6L,16L,16L,24L,42L,48L,52L,54L,52L,74L,84L,88L,102L,114L,122L,134L,152L,156L,166L,168L,1L,7L,13L,19L,23L,31L,71L,71L,73L,73L,65L,77L,91L,79L,91L,109L,115L,125L,137L,149L,155L,185L,197L,203L,197L,235L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076240Inst : IEnumerable<long>
{
public static readonly long[] Value=A076240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076240.Bytes);
public long this[int i]=>Value[i];

public static A076240Inst Instance=new A076240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076241
{
public static readonly long[] Value={ 0L,1L,2L,1L,1L,5L,3L,3L,2L,9L,6L,1L,10L,9L,1L,1L,5L,13L,8L,13L,10L,5L,17L,5L,9L,1L,23L,27L,19L,17L,27L,3L,14L,15L,19L,13L,31L,17L,16L,31L,38L,37L,35L,27L,31L,21L,28L,17L,12L,47L,43L,43L,39L,31L,26L,45L,13L,1L,17L,23L,17L,53L,11L,15L,1L,53L,10L,25L,64L,41L,38L,41L,68L,33L,59L,63L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076241Inst : IEnumerable<long>
{
public static readonly long[] Value=A076241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076241.Bytes);
public long this[int i]=>Value[i];

public static A076241Inst Instance=new A076241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076242
{
public static readonly long[] Value={ 1L,2L,1L,3L,6L,10L,5L,8L,17L,19L,27L,31L,38L,35L,28L,39L,17L,17L,10L,38L,68L,63L,13L,55L,48L,4L,74L,100L,37L,29L,47L,121L,115L,136L,105L,28L,128L,109L,159L,90L,114L,31L,151L,4L,86L,108L,81L,147L,149L,189L,185L,119L,231L,166L,88L,238L,197L,233L,64L,186L,258L,111L,128L,260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076242Inst : IEnumerable<long>
{
public static readonly long[] Value=A076242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076242.Bytes);
public long this[int i]=>Value[i];

public static A076242Inst Instance=new A076242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076243
{
public static readonly long[] Value={ 0L,1L,1L,3L,2L,5L,4L,3L,8L,9L,5L,7L,10L,5L,7L,3L,2L,11L,17L,1L,20L,21L,11L,19L,12L,17L,14L,17L,18L,19L,18L,23L,28L,27L,11L,19L,15L,7L,2L,21L,40L,25L,31L,1L,19L,15L,9L,31L,46L,47L,10L,15L,43L,23L,14L,9L,17L,19L,18L,41L,24L,27L,50L,3L,14L,29L,13L,3L,4L,39L,21L,1L,47L,19L,31L,13L,6L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076243Inst : IEnumerable<long>
{
public static readonly long[] Value=A076243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076243.Bytes);
public long this[int i]=>Value[i];

public static A076243Inst Instance=new A076243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076260
{
public static readonly long[] Value={ 0L,0L,0L,2L,0L,0L,0L,3L,3L,0L,0L,2L,0L,0L,0L,2L,0L,2L,0L,2L,0L,0L,0L,3L,3L,0L,3L,3L,0L,0L,0L,2L,0L,0L,0L,2L,0L,0L,0L,2L,0L,0L,0L,3L,3L,0L,0L,4L,4L,4L,0L,2L,0L,2L,0L,2L,0L,0L,0L,2L,0L,0L,3L,3L,0L,0L,0L,2L,0L,0L,0L,2L,0L,0L,3L,3L,0L,0L,0L,3L,3L,0L,0L,2L,0L,0L,0L,2L,0L,2L,0L,2L,0L,0L,0L,2L,0L,4L,4L,4L,0L,0L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076260Inst : IEnumerable<long>
{
public static readonly long[] Value=A076260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076260.Bytes);
public long this[int i]=>Value[i];

public static A076260Inst Instance=new A076260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076261
{
public static readonly long[] Value={ 4L,0L,8L,0L,4L,12L,0L,0L,18L,14L,0L,0L,10L,44L,10L,0L,0L,0L,50L,74L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076261Inst : IEnumerable<long>
{
public static readonly long[] Value=A076261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076261.Bytes);
public long this[int i]=>Value[i];

public static A076261Inst Instance=new A076261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076262
{
public static readonly long[] Value={ 9L,0L,27L,0L,9L,72L,0L,0L,69L,174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076262Inst : IEnumerable<long>
{
public static readonly long[] Value=A076262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076262.Bytes);
public long this[int i]=>Value[i];

public static A076262Inst Instance=new A076262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076263
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,1L,3L,5L,5L,4L,2L,1L,1L,6L,13L,19L,22L,20L,14L,9L,5L,2L,1L,1L,11L,33L,67L,107L,132L,138L,126L,95L,64L,40L,21L,10L,5L,2L,1L,1L,23L,89L,236L,486L,814L,1169L,1454L,1579L,1515L,1290L,970L,658L,400L,220L,114L,56L,24L,11L,5L,2L,1L,1L,47L,240L,797L,2075L,4495L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076263Inst : IEnumerable<long>
{
public static readonly long[] Value=A076263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076263.Bytes);
public long this[int i]=>Value[i];

public static A076263Inst Instance=new A076263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076264
{
public static readonly long[] Value={ 1L,3L,9L,26L,75L,216L,622L,1791L,5157L,14849L,42756L,123111L,354484L,1020696L,2938977L,8462447L,24366645L,70160958L,202020427L,581694636L,1674922950L,4822748423L,13886550633L,39984728949L,115131438424L,331507764639L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076264Inst : IEnumerable<long>
{
public static readonly long[] Value=A076264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076264.Bytes);
public long this[int i]=>Value[i];

public static A076264Inst Instance=new A076264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076265
{
public static readonly BigInteger[] Value={ 4L,108L,337500L,277945762500L,BigInteger.Parse("79301169838123235887500"),BigInteger.Parse("24018350267611933650627567399079537500"),BigInteger.Parse("19868946365457062696924774946056904675112420776003728137500") };
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
public class A076265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076265Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A076265.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A076265.Bytes);
public BigInteger this[int i]=>Value[i];

public static A076265Inst Instance=new A076265Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076266
{
public static readonly long[] Value={ 0L,1L,0L,0L,0L,5L,0L,4L,0L,3L,0L,2L,0L,1L,0L,0L,0L,2L,0L,1L,0L,0L,4L,0L,3L,0L,2L,0L,1L,0L,0L,0L,2L,0L,1L,0L,0L,13L,0L,12L,0L,11L,0L,10L,0L,9L,0L,8L,0L,7L,0L,6L,0L,5L,0L,4L,0L,3L,0L,2L,0L,1L,0L,0L,0L,5L,0L,4L,0L,3L,0L,2L,0L,1L,0L,0L,11L,0L,10L,0L,9L,0L,8L,0L,7L,0L,6L,0L,5L,0L,4L,0L,3L,0L,2L,0L,1L,0L,0L,0L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076266Inst : IEnumerable<long>
{
public static readonly long[] Value=A076266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076266.Bytes);
public long this[int i]=>Value[i];

public static A076266Inst Instance=new A076266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076267
{
public static readonly long[] Value={ 1L,2L,50L,56L,128L,156L,166L,208L,238L,272L,308L,336L,392L,474L,476L,512L,618L,658L,666L,710L,734L,836L,868L,1016L,1064L,1376L,1386L,1424L,1432L,1832L,2216L,2280L,2334L,2606L,2638L,2676L,2700L,2740L,2782L,2786L,2912L,2922L,2948L,2954L,3758L,4260L,4632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076267Inst : IEnumerable<long>
{
public static readonly long[] Value=A076267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076267.Bytes);
public long this[int i]=>Value[i];

public static A076267Inst Instance=new A076267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076268
{
public static readonly long[] Value={ 1L,2L,4L,7L,10L,14L,19L,24L,30L,36L,42L,50L,58L,66L,76L,85L,95L,106L,117L,129L,141L,153L,165L,181L,195L,209L,225L,241L,257L,273L,293L,310L,327L,347L,368L,387L,407L,429L,450L,472L,495L,518L,542L,566L,590L,614L,638L,670L,694L,719L,749L,777L,803L,833L,863L,891L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076268Inst : IEnumerable<long>
{
public static readonly long[] Value=A076268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076268.Bytes);
public long this[int i]=>Value[i];

public static A076268Inst Instance=new A076268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076269
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,2L,2L,3L,4L,4L,5L,6L,7L,9L,10L,11L,14L,17L,20L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076269Inst : IEnumerable<long>
{
public static readonly long[] Value=A076269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076269.Bytes);
public long this[int i]=>Value[i];

public static A076269Inst Instance=new A076269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076270
{
public static readonly long[] Value={ 1L,4L,10L,13L,28L,40L,82L,91L,121L,244L,364L,730L,757L,820L,1093L,2188L,3280L,6562L,6643L,7381L,9841L,19684L,20440L,29524L,59050L,59293L,66430L,88573L,177148L,265720L,531442L,532171L,538084L,551881L,597871L,797161L,1594324L,2391484L,4782970L,4785157L,5380840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076270Inst : IEnumerable<long>
{
public static readonly long[] Value=A076270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076270.Bytes);
public long this[int i]=>Value[i];

public static A076270Inst Instance=new A076270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076271
{
public static readonly long[] Value={ 1L,2L,4L,6L,9L,12L,15L,20L,25L,30L,35L,42L,49L,56L,63L,70L,77L,88L,99L,110L,121L,132L,143L,156L,169L,182L,195L,208L,221L,238L,255L,272L,289L,306L,323L,342L,361L,380L,399L,418L,437L,460L,483L,506L,529L,552L,575L,598L,621L,644L,667L,696L,725L,754L,783L,812L,841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076271Inst : IEnumerable<long>
{
public static readonly long[] Value=A076271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076271.Bytes);
public long this[int i]=>Value[i];

public static A076271Inst Instance=new A076271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076272
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,3L,5L,5L,5L,5L,7L,7L,7L,7L,7L,7L,11L,11L,11L,11L,11L,11L,13L,13L,13L,13L,13L,13L,17L,17L,17L,17L,17L,17L,19L,19L,19L,19L,19L,19L,23L,23L,23L,23L,23L,23L,23L,23L,23L,23L,29L,29L,29L,29L,29L,29L,29L,29L,31L,31L,31L,31L,31L,31L,31L,31L,37L,37L,37L,37L,37L,37L,37L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076272Inst : IEnumerable<long>
{
public static readonly long[] Value=A076272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076272.Bytes);
public long this[int i]=>Value[i];

public static A076272Inst Instance=new A076272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076273
{
public static readonly long[] Value={ 1L,2L,4L,7L,11L,17L,23L,29L,35L,41L,51L,59L,67L,77L,83L,89L,99L,111L,119L,127L,137L,143L,151L,161L,171L,185L,197L,203L,209L,215L,221L,239L,257L,267L,275L,287L,299L,307L,319L,329L,339L,351L,359L,371L,383L,389L,395L,409L,433L,449L,455L,461L,471L,479L,491L,507L,519L,531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076273Inst : IEnumerable<long>
{
public static readonly long[] Value=A076273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076273.Bytes);
public long this[int i]=>Value[i];

public static A076273Inst Instance=new A076273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076274
{
public static readonly long[] Value={ 1L,3L,5L,9L,13L,21L,25L,33L,37L,45L,57L,61L,73L,81L,85L,93L,105L,117L,121L,133L,141L,145L,157L,165L,177L,193L,201L,205L,213L,217L,225L,253L,261L,273L,277L,297L,301L,313L,325L,333L,345L,357L,361L,381L,385L,393L,397L,421L,445L,453L,457L,465L,477L,481L,501L,513L,525L,537L,541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076274Inst : IEnumerable<long>
{
public static readonly long[] Value=A076274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076274.Bytes);
public long this[int i]=>Value[i];

public static A076274Inst Instance=new A076274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076275
{
public static readonly long[] Value={ 1L,5L,17L,21L,65L,85L,257L,273L,341L,1025L,1365L,4097L,4161L,4369L,5461L,16385L,21845L,65537L,65793L,69905L,87381L,262145L,266305L,349525L,1048577L,1049601L,1118481L,1398101L,4194305L,5592405L,16777217L,16781313L,16843009L,17043521L,17895697L,22369621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076275Inst : IEnumerable<long>
{
public static readonly long[] Value=A076275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076275.Bytes);
public long this[int i]=>Value[i];

public static A076275Inst Instance=new A076275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076340
{
public static readonly long[] Value={ 1L,2L,4L,4L,4L,8L,8L,8L,15L,8L,12L,16L,12L,16L,17L,16L,16L,30L,20L,16L,31L,24L,24L,32L,15L,24L,52L,32L,28L,34L,32L,32L,47L,32L,33L,60L,36L,40L,49L,32L,40L,62L,44L,48L,68L,48L,48L,64L,63L,30L,65L,48L,52L,104L,49L,64L,79L,56L,60L,68L,60L,64L,112L,64L,47L,94L,68L,64L,95L,66L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076340Inst : IEnumerable<long>
{
public static readonly long[] Value=A076340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076340.Bytes);
public long this[int i]=>Value[i];

public static A076340Inst Instance=new A076340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076341
{
public static readonly long[] Value={ 0L,0L,-1L,0L,1L,-2L,-1L,0L,-8L,2L,-1L,-4L,1L,-2L,0L,0L,1L,-16L,-1L,4L,-12L,-2L,-1L,-8L,8L,2L,-47L,-4L,1L,0L,-1L,0L,-16L,2L,4L,-32L,1L,-2L,-8L,8L,1L,-24L,-1L,-4L,-17L,-2L,-1L,-16L,-16L,16L,-12L,4L,1L,-94L,8L,-8L,-24L,2L,-1L,0L,1L,-2L,-79L,0L,16L,-32L,-1L,4L,-28L,8L,-1L,-64L,1L,2L,17L,-4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076341Inst : IEnumerable<long>
{
public static readonly long[] Value=A076341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076341.Bytes);
public long this[int i]=>Value[i];

public static A076341Inst Instance=new A076341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076342
{
public static readonly long[] Value={ 2L,4L,4L,8L,12L,12L,16L,20L,24L,28L,32L,36L,40L,44L,48L,52L,60L,60L,68L,72L,72L,80L,84L,88L,96L,100L,104L,108L,108L,112L,128L,132L,136L,140L,148L,152L,156L,164L,168L,172L,180L,180L,192L,192L,196L,200L,212L,224L,228L,228L,232L,240L,240L,252L,256L,264L,268L,272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076342Inst : IEnumerable<long>
{
public static readonly long[] Value=A076342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076342.Bytes);
public long this[int i]=>Value[i];

public static A076342Inst Instance=new A076342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076343
{
public static readonly long[] Value={ 4L,8L,15L,8L,16L,17L,31L,24L,15L,24L,47L,32L,33L,40L,49L,48L,63L,65L,49L,79L,56L,64L,47L,95L,72L,95L,80L,63L,88L,113L,97L,127L,96L,81L,104L,145L,97L,120L,129L,143L,120L,161L,175L,159L,136L,191L,144L,145L,111L,144L,129L,160L,209L,191L,168L,143L,239L,176L,241L,143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076343Inst : IEnumerable<long>
{
public static readonly long[] Value=A076343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076343.Bytes);
public long this[int i]=>Value[i];

public static A076343Inst Instance=new A076343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076344
{
public static readonly long[] Value={ 0L,-2L,-8L,2L,-2L,0L,-12L,-2L,8L,2L,-16L,2L,4L,-2L,-8L,-2L,-16L,-12L,8L,-24L,2L,-2L,16L,-28L,2L,-20L,2L,20L,-2L,-24L,-4L,-36L,-2L,16L,2L,-32L,20L,-2L,-8L,-24L,2L,-36L,-48L,-28L,-2L,-52L,-2L,0L,32L,2L,28L,-2L,-48L,-32L,-2L,24L,-64L,2L,-56L,40L,-4L,2L,-72L,2L,-20L,44L,-2L,-32L,-76L,-2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076344Inst : IEnumerable<long>
{
public static readonly long[] Value=A076344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076344.Bytes);
public long this[int i]=>Value[i];

public static A076344Inst Instance=new A076344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076345
{
public static readonly long[] Value={ 1L,2L,4L,4L,4L,8L,8L,15L,12L,12L,16L,16L,20L,24L,15L,52L,28L,32L,32L,36L,40L,44L,48L,63L,52L,60L,60L,64L,68L,72L,72L,80L,161L,84L,88L,96L,100L,104L,108L,108L,112L,143L,52L,128L,128L,132L,136L,140L,148L,152L,156L,164L,168L,143L,172L,180L,180L,192L,192L,196L,200L,212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076345Inst : IEnumerable<long>
{
public static readonly long[] Value=A076345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076345.Bytes);
public long this[int i]=>Value[i];

public static A076345Inst Instance=new A076345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076346
{
public static readonly long[] Value={ 0L,0L,-1L,0L,1L,-1L,0L,-8L,-1L,1L,0L,1L,-1L,-1L,8L,-47L,1L,-1L,0L,1L,1L,-1L,-1L,-16L,1L,-1L,1L,0L,-1L,-1L,1L,-1L,-240L,-1L,1L,1L,1L,-1L,-1L,1L,1L,-24L,47L,-1L,0L,-1L,1L,-1L,1L,-1L,1L,-1L,-1L,24L,1L,-1L,1L,-1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,-1L,1L,-1121L,-1L,0L,1L,-1L,1L,-1L,1L,1L,-1L,32L,1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076346Inst : IEnumerable<long>
{
public static readonly long[] Value=A076346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076346.Bytes);
public long this[int i]=>Value[i];

public static A076346Inst Instance=new A076346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076347
{
public static readonly long[] Value={ 1L,2L,4L,4L,8L,8L,8L,12L,12L,16L,17L,16L,20L,31L,24L,24L,24L,28L,34L,32L,47L,32L,33L,36L,40L,49L,40L,62L,44L,48L,48L,65L,52L,49L,79L,56L,60L,60L,64L,47L,94L,68L,95L,66L,72L,72L,72L,95L,98L,80L,80L,84L,63L,88L,113L,88L,97L,127L,96L,81L,96L,100L,130L,104L,136L,104L,108L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076347Inst : IEnumerable<long>
{
public static readonly long[] Value=A076347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076347.Bytes);
public long this[int i]=>Value[i];

public static A076347Inst Instance=new A076347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076348
{
public static readonly long[] Value={ 0L,0L,-1L,1L,-2L,-1L,2L,-1L,1L,-2L,0L,1L,-1L,-12L,-2L,-1L,2L,1L,0L,-1L,-16L,2L,4L,1L,-2L,-8L,1L,-24L,-1L,-2L,-1L,-12L,1L,8L,-24L,2L,-1L,1L,-2L,16L,-32L,-1L,-28L,8L,-1L,1L,2L,-20L,-16L,-1L,2L,-1L,20L,-2L,-24L,1L,-4L,-36L,-2L,16L,1L,1L,-24L,-1L,-17L,2L,-1L,1L,16L,-32L,1L,-48L,20L,-2L,-8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076348Inst : IEnumerable<long>
{
public static readonly long[] Value=A076348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076348.Bytes);
public long this[int i]=>Value[i];

public static A076348Inst Instance=new A076348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076349
{
public static readonly long[] Value={ 1L,4L,15L,16L,15L,60L,63L,64L,161L,60L,143L,240L,143L,252L,289L,256L,255L,644L,399L,240L,817L,572L,575L,960L,161L,572L,495L,1008L,783L,1156L,1023L,1024L,1953L,1020L,1073L,2576L,1295L,1596L,2337L,960L,1599L,3268L,1935L,2288L,4335L,2300L,2303L,3840L,3713L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076349Inst : IEnumerable<long>
{
public static readonly long[] Value=A076349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076349.Bytes);
public long this[int i]=>Value[i];

public static A076349Inst Instance=new A076349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076350
{
public static readonly long[] Value={ 0L,0L,-8L,0L,8L,-32L,-16L,0L,-240L,32L,-24L,-128L,24L,-64L,0L,0L,32L,-960L,-40L,128L,-744L,-96L,-48L,-512L,240L,96L,-4888L,-256L,56L,0L,-64L,0L,-1504L,128L,264L,-3840L,72L,-160L,-784L,512L,80L,-2976L,-88L,-384L,-2312L,-192L,-96L,-2048L,-2016L,960L,-1560L,384L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076350Inst : IEnumerable<long>
{
public static readonly long[] Value=A076350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076350.Bytes);
public long this[int i]=>Value[i];

public static A076350Inst Instance=new A076350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076351
{
public static readonly long[] Value={ 1L,2L,4L,8L,15L,16L,30L,32L,60L,64L,120L,128L,143L,225L,240L,256L,286L,450L,480L,512L,572L,900L,960L,1024L,1144L,1800L,1920L,2048L,2145L,2288L,3375L,3599L,3600L,3840L,4096L,4290L,4576L,5183L,6750L,7198L,7200L,7680L,8192L,8580L,9152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076351Inst : IEnumerable<long>
{
public static readonly long[] Value=A076351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076351.Bytes);
public long this[int i]=>Value[i];

public static A076351Inst Instance=new A076351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076352
{
public static readonly long[] Value={ 1L,2L,15L,30L,143L,286L,2145L,3599L,4290L,5183L,7198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076352Inst : IEnumerable<long>
{
public static readonly long[] Value=A076352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076352.Bytes);
public long this[int i]=>Value[i];

public static A076352Inst Instance=new A076352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076353
{
public static readonly long[] Value={ 19L,24L,26L,28L,30L,32L,34L,49L,59L,67L,72L,77L,84L,94L,104L,114L,219L,226L,246L,342L,364L,455L,542L,690L,879L,903L,913L,923L,933L,943L,953L,1117L,1174L,1224L,1244L,1264L,1284L,1419L,1467L,1517L,1594L,1745L,1774L,1824L,1892L,2027L,2047L,2067L,2087L,2107L,2155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076353Inst : IEnumerable<long>
{
public static readonly long[] Value=A076353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076353.Bytes);
public long this[int i]=>Value[i];

public static A076353Inst Instance=new A076353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076354
{
public static readonly long[] Value={ 2L,4L,5L,6L,9L,10L,11L,13L,14L,16L,18L,19L,21L,24L,27L,28L,29L,30L,32L,35L,36L,41L,42L,43L,44L,48L,49L,50L,51L,55L,57L,61L,63L,65L,66L,69L,70L,73L,75L,76L,86L,87L,90L,92L,94L,95L,97L,99L,102L,104L,106L,107L,108L,110L,116L,119L,121L,125L,126L,127L,128L,130L,131L,135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076354Inst : IEnumerable<long>
{
public static readonly long[] Value=A076354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076354.Bytes);
public long this[int i]=>Value[i];

public static A076354Inst Instance=new A076354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076355
{
public static readonly long[] Value={ 0L,2L,3L,5L,7L,9L,10L,12L,13L,16L,17L,19L,20L,21L,24L,25L,26L,29L,30L,31L,34L,42L,43L,45L,48L,49L,54L,57L,59L,60L,61L,63L,64L,67L,72L,74L,75L,76L,80L,81L,82L,89L,90L,91L,93L,94L,95L,100L,101L,104L,106L,107L,108L,109L,111L,112L,113L,116L,123L,125L,127L,128L,133L,134L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076355Inst : IEnumerable<long>
{
public static readonly long[] Value=A076355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076355.Bytes);
public long this[int i]=>Value[i];

public static A076355Inst Instance=new A076355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076388
{
public static readonly long[] Value={ 1L,2L,3L,4L,1L,6L,7L,8L,3L,10L,1L,12L,5L,2L,15L,16L,7L,18L,1L,4L,9L,22L,5L,24L,11L,26L,3L,28L,1L,30L,31L,8L,15L,2L,5L,36L,17L,10L,3L,40L,1L,42L,7L,4L,21L,46L,13L,48L,23L,14L,9L,52L,25L,6L,1L,16L,27L,58L,7L,60L,29L,2L,63L,8L,5L,66L,13L,20L,3L,70L,1L,72L,35L,22L,15L,4L,7L,78L,11L,80L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076388Inst : IEnumerable<long>
{
public static readonly long[] Value=A076388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076388.Bytes);
public long this[int i]=>Value[i];

public static A076388Inst Instance=new A076388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076389
{
public static readonly long[] Value={ 0L,1L,30L,220L,950L,3045L,8036L,18480L,38340L,73425L,131890L,224796L,366730L,576485L,877800L,1300160L,1879656L,2659905L,3693030L,5040700L,6775230L,8980741L,11754380L,15207600L,19467500L,24678225L,31002426L,38622780L,47743570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076389Inst : IEnumerable<long>
{
public static readonly long[] Value=A076389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076389.Bytes);
public long this[int i]=>Value[i];

public static A076389Inst Instance=new A076389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076390
{
public static readonly long[] Value={ 5L,9L,9L,0L,7L,0L,1L,1L,7L,3L,6L,7L,7L,9L,6L,1L,0L,3L,7L,1L,9L,9L,6L,1L,2L,4L,6L,1L,4L,0L,1L,6L,1L,9L,3L,9L,1L,1L,3L,6L,0L,6L,3L,3L,1L,6L,0L,7L,8L,2L,5L,7L,7L,9L,1L,3L,1L,8L,3L,7L,4L,7L,6L,4L,7L,3L,2L,0L,2L,6L,0L,7L,0L,7L,1L,9L,5L,7L,8L,3L,5L,4L,1L,7L,9L,4L,2L,7L,7L,8L,2L,4L,4L,8L,9L,6L,6L,9L,4L,6L,8L,7L,9L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076390Inst : IEnumerable<long>
{
public static readonly long[] Value=A076390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076390.Bytes);
public long this[int i]=>Value[i];

public static A076390Inst Instance=new A076390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076391
{
public static readonly long[] Value={ 0L,1L,1L,2L,42L,1L,1L,1L,1L,1L,1L,6L,1L,4L,3L,1L,1L,32L,1L,1L,16L,18L,2L,1L,10L,1L,3L,2L,2L,1L,2L,1L,1L,4L,3L,8L,2L,1L,2L,1L,12L,6L,1L,6L,4L,1L,11L,2L,2L,12L,1L,1L,2L,1L,1L,5L,1L,4L,1L,16L,1L,1L,5L,1L,2L,5L,4L,1L,4L,1L,1L,1L,1L,2L,3L,1L,17L,1L,1L,4L,4L,3L,2L,1L,2L,5L,8L,1L,9L,15L,1L,2L,2L,1L,2L,61L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076391Inst : IEnumerable<long>
{
public static readonly long[] Value=A076391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076391.Bytes);
public long this[int i]=>Value[i];

public static A076391Inst Instance=new A076391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076392
{
public static readonly long[] Value={ 0L,1L,2L,42L,61L,88L,238L,254L,288L,347L,575L,4034L,9853L,21798L,49736L,108435L,109003L,181562L,1035352L,1955976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076392Inst : IEnumerable<long>
{
public static readonly long[] Value=A076392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076392.Bytes);
public long this[int i]=>Value[i];

public static A076392Inst Instance=new A076392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076393
{
public static readonly long[] Value={ 1L,2L,6L,4L,0L,8L,4L,7L,3L,5L,3L,0L,5L,3L,0L,1L,1L,1L,3L,0L,7L,9L,5L,9L,9L,5L,8L,4L,1L,6L,4L,6L,6L,9L,4L,9L,1L,1L,1L,4L,5L,6L,0L,1L,7L,9L,2L,0L,9L,0L,6L,5L,5L,3L,3L,1L,5L,3L,4L,5L,6L,4L,1L,9L,9L,0L,7L,7L,5L,9L,0L,1L,6L,3L,6L,2L,9L,5L,1L,6L,0L,1L,4L,2L,2L,6L,3L,9L,0L,9L,2L,6L,8L,3L,9L,8L,5L,1L,5L,0L,4L,8L,0L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076393Inst : IEnumerable<long>
{
public static readonly long[] Value=A076393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076393.Bytes);
public long this[int i]=>Value[i];

public static A076393Inst Instance=new A076393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076394
{
public static readonly long[] Value={ 1L,27L,338L,2835L,18566L,101955L,490253L,2121679L,8424520L,31120519L,108082568L,355805845L,1117485621L,3366123200L,9767105406L,27398618368L,74534264393L,197147918679L,508189847045L,1279140518117L,3149375120229L,7596463993261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076394Inst : IEnumerable<long>
{
public static readonly long[] Value=A076394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076394.Bytes);
public long this[int i]=>Value[i];

public static A076394Inst Instance=new A076394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076395
{
public static readonly long[] Value={ 225L,1296L,2025L,3136L,15876L,30976L,112896L,125316L,181476L,306916L,343396L,355216L,364816L,376996L,391876L,1179396L,1218816L,1527696L,1572516L,1679616L,1838736L,3041536L,3083536L,3189796L,3290596L,3334276L,3407716L,3701776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076395Inst : IEnumerable<long>
{
public static readonly long[] Value=A076395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076395.Bytes);
public long this[int i]=>Value[i];

public static A076395Inst Instance=new A076395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076396
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,5L,3L,2L,2L,7L,2L,3L,2L,11L,5L,2L,2L,13L,2L,2L,3L,3L,2L,17L,2L,7L,19L,2L,3L,2L,2L,23L,2L,5L,2L,3L,2L,29L,2L,31L,2L,2L,3L,2L,5L,2L,11L,37L,2L,3L,2L,41L,2L,2L,43L,2L,3L,2L,2L,3L,13L,47L,2L,7L,2L,3L,2L,2L,53L,2L,5L,5L,2L,3L,2L,3L,59L,2L,61L,2L,3L,2L,5L,2L,67L,2L,3L,2L,17L,71L,2L,73L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076396Inst : IEnumerable<long>
{
public static readonly long[] Value=A076396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076396.Bytes);
public long this[int i]=>Value[i];

public static A076396Inst Instance=new A076396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076397
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,5L,3L,2L,3L,7L,2L,3L,5L,11L,5L,2L,3L,13L,7L,3L,5L,3L,2L,17L,3L,7L,19L,5L,7L,11L,2L,23L,3L,5L,13L,3L,7L,29L,5L,31L,5L,2L,11L,17L,7L,3L,11L,37L,19L,13L,5L,41L,3L,7L,43L,11L,5L,2L,23L,3L,13L,47L,3L,7L,5L,17L,13L,7L,53L,3L,11L,5L,7L,19L,29L,5L,59L,5L,61L,31L,7L,2L,13L,11L,67L,17L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076397Inst : IEnumerable<long>
{
public static readonly long[] Value=A076397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076397.Bytes);
public long this[int i]=>Value[i];

public static A076397Inst Instance=new A076397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076398
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,2L,2L,1L,1L,1L,2L,1L,1L,2L,2L,2L,1L,1L,2L,1L,2L,1L,2L,1L,3L,1L,2L,1L,2L,2L,2L,2L,1L,1L,2L,2L,2L,1L,2L,3L,1L,2L,2L,1L,2L,1L,1L,1L,2L,1L,2L,2L,2L,2L,1L,2L,2L,1L,2L,2L,2L,2L,1L,3L,1L,2L,2L,1L,2L,3L,1L,2L,2L,3L,1L,1L,2L,1L,2L,2L,2L,2L,2L,3L,1L,2L,1L,2L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076398Inst : IEnumerable<long>
{
public static readonly long[] Value=A076398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076398.Bytes);
public long this[int i]=>Value[i];

public static A076398Inst Instance=new A076398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076399
{
public static readonly long[] Value={ 0L,2L,3L,2L,4L,2L,3L,5L,4L,2L,6L,4L,4L,2L,3L,7L,6L,2L,4L,6L,4L,5L,8L,2L,6L,3L,2L,6L,4L,4L,9L,2L,8L,4L,4L,6L,6L,2L,6L,2L,6L,10L,4L,4L,4L,8L,3L,2L,4L,4L,8L,2L,9L,6L,2L,6L,6L,11L,4L,7L,3L,2L,10L,4L,6L,4L,6L,6L,2L,8L,4L,5L,8L,4L,4L,6L,2L,8L,2L,4L,6L,12L,4L,6L,2L,6L,4L,6L,3L,2L,10L,2L,4L,6L,6L,9L,4L,6L,2L,10L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076399Inst : IEnumerable<long>
{
public static readonly long[] Value=A076399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076399.Bytes);
public long this[int i]=>Value[i];

public static A076399Inst Instance=new A076399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076400
{
public static readonly long[] Value={ 1L,3L,4L,3L,5L,3L,4L,6L,9L,3L,7L,5L,9L,3L,4L,8L,15L,3L,9L,16L,9L,6L,9L,3L,15L,4L,3L,15L,9L,9L,10L,3L,21L,5L,9L,7L,15L,3L,27L,3L,16L,11L,9L,9L,9L,25L,4L,3L,9L,9L,21L,3L,28L,27L,3L,15L,15L,12L,9L,8L,4L,3L,27L,5L,15L,9L,15L,16L,3L,21L,9L,6L,21L,9L,9L,16L,3L,45L,3L,9L,15L,13L,9L,27L,3L,15L,9L,27L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076400Inst : IEnumerable<long>
{
public static readonly long[] Value=A076400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076400.Bytes);
public long this[int i]=>Value[i];

public static A076400Inst Instance=new A076400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076401
{
public static readonly long[] Value={ 1L,7L,15L,13L,31L,31L,40L,63L,91L,57L,127L,121L,217L,133L,156L,255L,403L,183L,399L,600L,403L,364L,511L,307L,847L,400L,381L,961L,741L,931L,1023L,553L,1651L,781L,1281L,1093L,1767L,871L,2821L,993L,2340L,2047L,1729L,2149L,1767L,3751L,1464L,1407L,2667L,2379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076401Inst : IEnumerable<long>
{
public static readonly long[] Value=A076401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076401.Bytes);
public long this[int i]=>Value[i];

public static A076401Inst Instance=new A076401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076402
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,20L,18L,16L,12L,42L,32L,54L,40L,110L,100L,64L,48L,156L,84L,72L,120L,162L,128L,272L,108L,294L,342L,160L,252L,220L,256L,506L,192L,500L,312L,486L,336L,812L,240L,930L,400L,512L,660L,544L,840L,432L,1210L,1332L,684L,936L,640L,1640L,576L,504L,1806L,880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076402Inst : IEnumerable<long>
{
public static readonly long[] Value=A076402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076402.Bytes);
public long this[int i]=>Value[i];

public static A076402Inst Instance=new A076402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076403
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,5L,3L,2L,6L,7L,2L,3L,10L,11L,5L,2L,6L,13L,14L,6L,15L,3L,2L,17L,6L,7L,19L,10L,21L,22L,2L,23L,6L,5L,26L,3L,14L,29L,30L,31L,10L,2L,33L,34L,35L,6L,11L,37L,38L,39L,10L,41L,6L,42L,43L,22L,15L,2L,46L,3L,13L,47L,6L,7L,10L,51L,26L,14L,53L,6L,55L,5L,14L,57L,58L,15L,59L,30L,61L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076403Inst : IEnumerable<long>
{
public static readonly long[] Value=A076403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076403.Bytes);
public long this[int i]=>Value[i];

public static A076403Inst Instance=new A076403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076420
{
public static readonly long[] Value={ 3L,9L,2L,6L,6L,0L,2L,3L,1L,2L,0L,4L,7L,9L,1L,8L,7L,7L,8L,2L,3L,8L,5L,3L,3L,3L,4L,3L,6L,2L,7L,0L,2L,4L,8L,9L,5L,1L,6L,1L,1L,5L,2L,0L,8L,6L,9L,9L,5L,3L,3L,7L,3L,0L,7L,4L,2L,0L,6L,6L,8L,6L,5L,4L,2L,5L,5L,2L,7L,9L,7L,0L,8L,9L,0L,9L,6L,4L,6L,4L,2L,4L,7L,4L,1L,9L,4L,3L,3L,8L,0L,0L,1L,5L,6L,2L,1L,9L,4L,2L,2L,0L,5L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076420Inst : IEnumerable<long>
{
public static readonly long[] Value=A076420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076420.Bytes);
public long this[int i]=>Value[i];

public static A076420Inst Instance=new A076420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076421
{
public static readonly long[] Value={ 7L,0L,6L,8L,5L,8L,2L,7L,4L,5L,6L,2L,8L,7L,3L,2L,0L,8L,8L,5L,5L,2L,9L,5L,8L,9L,2L,7L,5L,4L,6L,6L,6L,5L,3L,7L,6L,4L,3L,7L,6L,4L,7L,5L,5L,0L,0L,6L,4L,2L,3L,5L,6L,4L,4L,0L,5L,9L,4L,3L,7L,7L,5L,4L,3L,4L,5L,0L,1L,3L,4L,3L,0L,5L,6L,6L,0L,8L,6L,9L,3L,9L,5L,4L,0L,8L,4L,7L,5L,2L,6L,1L,5L,2L,2L,3L,6L,6L,0L,8L,3L,8L,2L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076421Inst : IEnumerable<long>
{
public static readonly long[] Value=A076421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076421.Bytes);
public long this[int i]=>Value[i];

public static A076421Inst Instance=new A076421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076422
{
public static readonly long[] Value={ 1L,0L,2L,1L,0L,1L,7L,6L,1L,2L,2L,8L,1L,3L,0L,3L,0L,5L,4L,5L,4L,6L,8L,2L,0L,5L,5L,9L,4L,6L,5L,6L,5L,3L,9L,8L,2L,4L,9L,5L,3L,0L,5L,7L,9L,8L,9L,5L,5L,1L,3L,9L,1L,9L,2L,3L,3L,4L,8L,2L,1L,1L,1L,2L,5L,8L,1L,7L,5L,3L,1L,0L,7L,5L,1L,5L,7L,9L,1L,4L,0L,1L,0L,7L,6L,3L,9L,3L,0L,3L,5L,8L,5L,9L,5L,7L,6L,8L,2L,4L,2L,2L,8L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076422Inst : IEnumerable<long>
{
public static readonly long[] Value=A076422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076422.Bytes);
public long this[int i]=>Value[i];

public static A076422Inst Instance=new A076422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076423
{
public static readonly long[] Value={ 1L,2L,3L,1L,2L,1L,2L,3L,1L,1L,2L,4L,3L,1L,1L,2L,3L,2L,3L,2L,1L,1L,6L,3L,1L,1L,2L,2L,2L,2L,5L,3L,1L,1L,1L,3L,5L,1L,1L,4L,4L,3L,2L,3L,2L,1L,5L,2L,1L,6L,1L,6L,2L,2L,1L,7L,1L,1L,2L,3L,2L,1L,3L,2L,1L,2L,7L,3L,1L,2L,3L,4L,4L,1L,6L,4L,1L,2L,4L,2L,2L,1L,6L,4L,1L,1L,1L,2L,4L,2L,1L,4L,1L,1L,1L,3L,3L,2L,2L,1L,2L,8L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076423Inst : IEnumerable<long>
{
public static readonly long[] Value=A076423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076423.Bytes);
public long this[int i]=>Value[i];

public static A076423Inst Instance=new A076423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076424
{
public static readonly long[] Value={ 1L,2L,3L,12L,31L,23L,56L,102L,193L,257L,570L,1129L,4970L,3229L,11551L,11969L,24232L,20094L,24103L,35996L,100090L,222284L,116269L,231488L,388768L,1751753L,2046872L,1140163L,1149979L,2156214L,3199384L,2971734L,7018074L,10163234L,13135933L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076424Inst : IEnumerable<long>
{
public static readonly long[] Value=A076424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076424.Bytes);
public long this[int i]=>Value[i];

public static A076424Inst Instance=new A076424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076425
{
public static readonly long[] Value={ 2074L,2113L,2179L,2914L,3111L,4112L,4371L,4390L,4456L,4956L,4978L,5185L,5450L,5750L,6474L,6585L,6827L,7248L,7259L,7285L,7467L,8175L,8625L,8647L,9378L,9711L,9739L,10199L,10975L,11407L,11752L,12006L,12232L,12338L,12445L,12826L,13224L,13396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076425Inst : IEnumerable<long>
{
public static readonly long[] Value=A076425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076425.Bytes);
public long this[int i]=>Value[i];

public static A076425Inst Instance=new A076425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076426
{
public static readonly long[] Value={ 5750L,33866L,74841L,517250L,577750L,5538710L,51414250L,51454250L,51687250L,51727250L,51748250L,51858250L,52525250L,57515750L,57535750L,57575750L,57757750L,67597352L,841794296L,5120202250L,5120802250L,5121612250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076426Inst : IEnumerable<long>
{
public static readonly long[] Value=A076426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076426.Bytes);
public long this[int i]=>Value[i];

public static A076426Inst Instance=new A076426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076427
{
public static readonly long[] Value={ 1L,1L,2L,3L,2L,0L,5L,3L,4L,1L,4L,2L,3L,0L,3L,3L,7L,3L,5L,2L,2L,2L,4L,5L,2L,3L,3L,7L,1L,1L,2L,4L,2L,0L,3L,2L,3L,1L,4L,4L,3L,0L,1L,3L,4L,1L,6L,4L,3L,0L,2L,1L,2L,2L,3L,4L,3L,0L,1L,4L,2L,0L,4L,4L,4L,0L,2L,5L,2L,0L,4L,4L,6L,2L,3L,3L,2L,0L,4L,4L,4L,0L,2L,2L,2L,0L,3L,3L,6L,0L,3L,4L,4L,2L,4L,5L,3L,2L,4L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076427Inst : IEnumerable<long>
{
public static readonly long[] Value=A076427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076427.Bytes);
public long this[int i]=>Value[i];

public static A076427Inst Instance=new A076427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076428
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,10L,12L,14L,15L,20L,24L,28L,30L,36L,40L,42L,48L,50L,56L,60L,63L,70L,72L,80L,84L,90L,96L,100L,108L,110L,120L,121L,132L,144L,150L,153L,156L,168L,180L,192L,200L,204L,216L,220L,228L,231L,240L,250L,252L,264L,276L,288L,290L,291L,295L,300L,304L,305L,312L,315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076428Inst : IEnumerable<long>
{
public static readonly long[] Value=A076428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076428.Bytes);
public long this[int i]=>Value[i];

public static A076428Inst Instance=new A076428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076429
{
public static readonly long[] Value={ 1L,14L,114L,675L,2610L,6576L,14616L,27423L,65758L,121590L,200250L,354600L,481740L,636111L,972946L,1543438L,2052330L,2654850L,3609375L,4292820L,5326308L,6902883L,8780068L,12023616L,15516000L,17510850L,19669731L,22045986L,24606288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076429Inst : IEnumerable<long>
{
public static readonly long[] Value=A076429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076429.Bytes);
public long this[int i]=>Value[i];

public static A076429Inst Instance=new A076429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076430
{
public static readonly long[] Value={ 1L,70L,1610L,22715L,170170L,675376L,2224824L,5696295L,21057190L,52798270L,111385170L,261955560L,414410780L,628310711L,1187225546L,2369546790L,3631067090L,5339542890L,8459444455L,10969197540L,15154637940L,22349763995L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076430Inst : IEnumerable<long>
{
public static readonly long[] Value=A076430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076430.Bytes);
public long this[int i]=>Value[i];

public static A076430Inst Instance=new A076430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076431
{
public static readonly long[] Value={ 9L,16L,36L,128L,144L,256L,361L,529L,1024L,1369L,1764L,2209L,2809L,3136L,3481L,5041L,5929L,6889L,8281L,9409L,10816L,12321L,13924L,16900L,17689L,19881L,22201L,24649L,27225L,29929L,33124L,36100L,39601L,43264L,51076L,55225L,59536L,64009L,69169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076431Inst : IEnumerable<long>
{
public static readonly long[] Value=A076431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076431.Bytes);
public long this[int i]=>Value[i];

public static A076431Inst Instance=new A076431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076432
{
public static readonly BigInteger[] Value={ 36L,144L,2209L,6436369L,312079766881L,328081510656L,11305787558464L,62854912315881L,79723540870416L,4550858480922601L,11435943732416784L,3109406220195722500L,6258210474706101136L,7596357574791306304L,BigInteger.Parse("21016258678615763761"),BigInteger.Parse("32645304184825666489") };
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
public class A076432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076432Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A076432.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A076432.Bytes);
public BigInteger this[int i]=>Value[i];

public static A076432Inst Instance=new A076432Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076433
{
public static readonly long[] Value={ 25L,121L,2187L,6431296L,6434856L,6956883693L,27027009001L,34359738368L,42618264157L,312078649600L,312079600999L,328080365089L,11305780833649L,11305786504384L,19287643015432L,62854896459664L,79723523012809L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076433Inst : IEnumerable<long>
{
public static readonly long[] Value=A076433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076433.Bytes);
public long this[int i]=>Value[i];

public static A076433Inst Instance=new A076433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076434
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,2L,4L,16L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076434Inst : IEnumerable<long>
{
public static readonly long[] Value=A076434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076434.Bytes);
public long this[int i]=>Value[i];

public static A076434Inst Instance=new A076434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076435
{
public static readonly long[] Value={ 1L,2L,2L,4L,3L,6L,2L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076435Inst : IEnumerable<long>
{
public static readonly long[] Value=A076435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076435.Bytes);
public long this[int i]=>Value[i];

public static A076435Inst Instance=new A076435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076452
{
public static readonly long[] Value={ 0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076452Inst : IEnumerable<long>
{
public static readonly long[] Value=A076452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076452.Bytes);
public long this[int i]=>Value[i];

public static A076452Inst Instance=new A076452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076453
{
public static readonly long[] Value={ 1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076453Inst : IEnumerable<long>
{
public static readonly long[] Value=A076453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076453.Bytes);
public long this[int i]=>Value[i];

public static A076453Inst Instance=new A076453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076454
{
public static readonly long[] Value={ 1L,21L,102L,310L,735L,1491L,2716L,4572L,7245L,10945L,15906L,22386L,30667L,41055L,53880L,69496L,88281L,110637L,136990L,167790L,203511L,244651L,291732L,345300L,405925L,474201L,550746L,636202L,731235L,836535L,952816L,1080816L,1221297L,1375045L,1542870L,1725606L,1924111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076454Inst : IEnumerable<long>
{
public static readonly long[] Value=A076454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076454.Bytes);
public long this[int i]=>Value[i];

public static A076454Inst Instance=new A076454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076455
{
public static readonly long[] Value={ 5L,57L,246L,710L,1635L,3255L,5852L,9756L,15345L,23045L,33330L,46722L,63791L,85155L,111480L,143480L,181917L,227601L,281390L,344190L,416955L,500687L,596436L,705300L,828425L,967005L,1122282L,1295546L,1488135L,1701435L,1936880L,2195952L,2480181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076455Inst : IEnumerable<long>
{
public static readonly long[] Value=A076455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076455.Bytes);
public long this[int i]=>Value[i];

public static A076455Inst Instance=new A076455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076456
{
public static readonly long[] Value={ 9L,93L,390L,1110L,2535L,5019L,8988L,14940L,23445L,35145L,50754L,71058L,96915L,129255L,169080L,217464L,275553L,344565L,425790L,520590L,630399L,756723L,901140L,1065300L,1250925L,1459809L,1693818L,1954890L,2245035L,2566335L,2920944L,3311088L,3739065L,4207245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076456Inst : IEnumerable<long>
{
public static readonly long[] Value=A076456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076456.Bytes);
public long this[int i]=>Value[i];

public static A076456Inst Instance=new A076456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076457
{
public static readonly long[] Value={ 13L,129L,534L,1510L,3435L,6783L,12124L,20124L,31545L,47245L,68178L,95394L,130039L,173355L,226680L,291448L,369189L,461529L,570190L,696990L,843843L,1012759L,1205844L,1425300L,1673425L,1952613L,2265354L,2614234L,3001935L,3431235L,3905008L,4426224L,4997949L,5623345L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076457Inst : IEnumerable<long>
{
public static readonly long[] Value=A076457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076457.Bytes);
public long this[int i]=>Value[i];

public static A076457Inst Instance=new A076457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076458
{
public static readonly long[] Value={ 17L,165L,678L,1910L,4335L,8547L,15260L,25308L,39645L,59345L,85602L,119730L,163163L,217455L,284280L,365432L,462825L,578493L,714590L,873390L,1057287L,1268795L,1510548L,1785300L,2095925L,2445417L,2836890L,3273578L,3758835L,4296135L,4889072L,5541360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076458Inst : IEnumerable<long>
{
public static readonly long[] Value=A076458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076458.Bytes);
public long this[int i]=>Value[i];

public static A076458Inst Instance=new A076458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076459
{
public static readonly long[] Value={ 1L,57L,390L,1510L,4335L,10311L,21532L,40860L,72045L,119845L,190146L,290082L,428155L,614355L,860280L,1179256L,1586457L,2099025L,2736190L,3519390L,4472391L,5621407L,6995220L,8625300L,10545925L,12794301L,15410682L,18438490L,21924435L,25918635L,30474736L,35650032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076459Inst : IEnumerable<long>
{
public static readonly long[] Value=A076459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076459.Bytes);
public long this[int i]=>Value[i];

public static A076459Inst Instance=new A076459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076460
{
public static readonly long[] Value={ 1L,103L,1130L,6070L,22355L,64981L,160468L,351660L,703365L,1308835L,2297086L,3841058L,6166615L,9562385L,14390440L,21097816L,30228873L,42438495L,58506130L,79350670L,106046171L,139838413L,182162300L,234660100L,299200525L,377898651L,473136678L,587585530L,724227295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076460Inst : IEnumerable<long>
{
public static readonly long[] Value=A076460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076460.Bytes);
public long this[int i]=>Value[i];

public static A076460Inst Instance=new A076460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076461
{
public static readonly long[] Value={ 13L,571L,5306L,26470L,93455L,264313L,640276L,1383276L,2736465L,5047735L,8796238L,14621906L,23357971L,36066485L,54076840L,79027288L,112909461L,158115891L,217490530L,294382270L,392701463L,516979441L,672431036L,865020100L,1101528025L,1389625263L,1737945846L,2156164906L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076461Inst : IEnumerable<long>
{
public static readonly long[] Value=A076461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076461.Bytes);
public long this[int i]=>Value[i];

public static A076461Inst Instance=new A076461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076462
{
public static readonly long[] Value={ 41L,1471L,12938L,62870L,218555L,611821L,1471316L,3161388L,6227565L,11448635L,19895326L,32995586L,52606463L,81092585L,121411240L,177204056L,252895281L,353796663L,486218930L,657589870L,876579011L,1153228901L,1499092988L,1927380100L,2453105525L,3093248691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076462Inst : IEnumerable<long>
{
public static readonly long[] Value=A076462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076462.Bytes);
public long this[int i]=>Value[i];

public static A076462Inst Instance=new A076462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076463
{
public static readonly long[] Value={ 85L,2803L,24026L,115270L,397655L,1107505L,2653588L,5685996L,11176665L,20511535L,35594350L,58962098L,93912091L,144640685L,216393640L,315628120L,450186333L,629480811L,864691330L,1168973470L,1557678815L,2048586793L,2662148156L,3421740100L,4353933025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076463Inst : IEnumerable<long>
{
public static readonly long[] Value=A076463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076463.Bytes);
public long this[int i]=>Value[i];

public static A076463Inst Instance=new A076463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076464
{
public static readonly long[] Value={ 145L,4567L,38570L,183670L,630755L,1751365L,4187092L,8957100L,17583765L,32236435L,55893310L,92521442L,147274855L,226710785L,339024040L,494299480L,704782617L,985168335L,1352907730L,1828533070L,2436000875L,3203053117L,4161596540L,5348100100L,6804010525L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076464Inst : IEnumerable<long>
{
public static readonly long[] Value=A076464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076464.Bytes);
public long this[int i]=>Value[i];

public static A076464Inst Instance=new A076464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076465
{
public static readonly long[] Value={ 1L,571L,12938L,115270L,630755L,2543401L,8307796L,23249388L,57792165L,130790935L,274285726L,540036146L,1008233863L,1798831685L,3085968040L,5116005976L,8229746121L,12889413363L,19711057330L,29503047070L,43311380651L,62472570721L,88674907388L,124028940100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076465Inst : IEnumerable<long>
{
public static readonly long[] Value=A076465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076465.Bytes);
public long this[int i]=>Value[i];

public static A076465Inst Instance=new A076465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076466
{
public static readonly long[] Value={ 1L,2L,4L,4L,8L,10L,13L,16L,23L,30L,38L,40L,41L,42L,54L,60L,69L,72L,87L,100L,116L,122L,129L,144L,163L,182L,202L,208L,213L,240L,263L,288L,312L,318L,321L,324L,352L,362L,373L,400L,431L,462L,494L,504L,513L,552L,587L,624L,660L,670L,677L,728L,767L,810L,850L,860L,865L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076466Inst : IEnumerable<long>
{
public static readonly long[] Value=A076466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076466.Bytes);
public long this[int i]=>Value[i];

public static A076466Inst Instance=new A076466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076467
{
public static readonly long[] Value={ 1L,8L,16L,27L,32L,64L,81L,125L,128L,216L,243L,256L,343L,512L,625L,729L,1000L,1024L,1296L,1331L,1728L,2048L,2187L,2197L,2401L,2744L,3125L,3375L,4096L,4913L,5832L,6561L,6859L,7776L,8000L,8192L,9261L,10000L,10648L,12167L,13824L,14641L,15625L,16384L,16807L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076467Inst : IEnumerable<long>
{
public static readonly long[] Value=A076467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076467.Bytes);
public long this[int i]=>Value[i];

public static A076467Inst Instance=new A076467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076516
{
public static readonly long[] Value={ 5L,17L,101L,257L,577L,1297L,3137L,5477L,7057L,12101L,13457L,14401L,15377L,24337L,25601L,30977L,33857L,41617L,42437L,44101L,50177L,52901L,55697L,57601L,62501L,65537L,69697L,72901L,80657L,98597L,106277L,122501L,147457L,164837L,184901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076516Inst : IEnumerable<long>
{
public static readonly long[] Value=A076516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076516.Bytes);
public long this[int i]=>Value[i];

public static A076516Inst Instance=new A076516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076517
{
public static readonly long[] Value={ 1L,6L,8L,9L,10L,11L,12L,14L,26L,34L,36L,37L,41L,42L,43L,45L,47L,56L,62L,64L,66L,67L,92L,95L,97L,98L,99L,102L,103L,120L,123L,124L,126L,128L,130L,131L,135L,136L,137L,139L,140L,142L,144L,151L,152L,154L,155L,156L,190L,198L,203L,204L,205L,206L,260L,264L,274L,276L,278L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076517Inst : IEnumerable<long>
{
public static readonly long[] Value=A076517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076517.Bytes);
public long this[int i]=>Value[i];

public static A076517Inst Instance=new A076517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076518
{
public static readonly long[] Value={ 1L,2L,4L,11L,19L,29L,31L,41L,59L,61L,71L,79L,89L,101L,109L,120L,131L,139L,149L,151L,179L,181L,191L,199L,211L,229L,239L,241L,251L,269L,271L,281L,311L,331L,348L,349L,359L,379L,389L,401L,409L,419L,421L,431L,439L,449L,461L,479L,491L,499L,509L,521L,541L,569L,571L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076518Inst : IEnumerable<long>
{
public static readonly long[] Value=A076518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076518.Bytes);
public long this[int i]=>Value[i];

public static A076518Inst Instance=new A076518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076519
{
public static readonly long[] Value={ 1L,2L,3L,4L,68L,76L,116L,181L,357L,789L,1251L,3861L,40087L,125902L,201986L,251737L,846623L,936418L,1327269L,2003626L,3546266L,4124468L,4832054L,4866214L,5086202L,5627521L,92660777L,331915497L,339145743L,394668171L,472845243L,679387634L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076519Inst : IEnumerable<long>
{
public static readonly long[] Value=A076519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076519.Bytes);
public long this[int i]=>Value[i];

public static A076519Inst Instance=new A076519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076520
{
public static readonly long[] Value={ 2L,5L,5L,8L,10L,10L,13L,13L,17L,17L,18L,20L,20L,25L,25L,26L,26L,29L,29L,32L,34L,34L,37L,37L,40L,40L,41L,41L,45L,45L,50L,50L,50L,52L,52L,53L,53L,58L,58L,61L,61L,65L,65L,65L,65L,68L,68L,72L,73L,73L,74L,74L,80L,80L,82L,82L,85L,85L,85L,85L,89L,89L,90L,90L,97L,97L,98L,100L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076520Inst : IEnumerable<long>
{
public static readonly long[] Value=A076520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076520.Bytes);
public long this[int i]=>Value[i];

public static A076520Inst Instance=new A076520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076521
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,7L,9L,11L,13L,15L,18L,20L,22L,24L,27L,29L,32L,34L,37L,39L,42L,45L,47L,50L,53L,56L,59L,61L,64L,67L,70L,73L,76L,79L,82L,85L,88L,91L,94L,97L,100L,104L,107L,110L,113L,116L,120L,123L,126L,129L,133L,136L,139L,142L,146L,149L,152L,156L,159L,163L,166L,169L,173L,176L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076521Inst : IEnumerable<long>
{
public static readonly long[] Value=A076521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076521.Bytes);
public long this[int i]=>Value[i];

public static A076521Inst Instance=new A076521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076522
{
public static readonly long[] Value={ 0L,2L,6L,9L,13L,18L,22L,27L,32L,37L,42L,48L,53L,59L,64L,70L,76L,82L,88L,94L,100L,107L,113L,120L,126L,133L,139L,146L,152L,159L,166L,173L,180L,187L,194L,201L,208L,215L,222L,229L,236L,243L,251L,258L,265L,273L,280L,288L,295L,302L,310L,318L,325L,333L,340L,348L,356L,363L,371L,379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076522Inst : IEnumerable<long>
{
public static readonly long[] Value=A076522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076522.Bytes);
public long this[int i]=>Value[i];

public static A076522Inst Instance=new A076522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076523
{
public static readonly long[] Value={ 1L,3L,6L,9L,13L,18L,22L,27L,33L,38L,44L,51L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076523Inst : IEnumerable<long>
{
public static readonly long[] Value=A076523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076523.Bytes);
public long this[int i]=>Value[i];

public static A076523Inst Instance=new A076523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076524
{
public static readonly long[] Value={ 3L,3L,5L,7L,7L,19L,23L,31L,37L,41L,43L,43L,47L,47L,61L,67L,71L,89L,109L,109L,113L,127L,131L,131L,137L,139L,149L,151L,163L,163L,167L,167L,173L,181L,197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076524Inst : IEnumerable<long>
{
public static readonly long[] Value=A076524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076524.Bytes);
public long this[int i]=>Value[i];

public static A076524Inst Instance=new A076524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076525
{
public static readonly long[] Value={ 4L,22L,57L,900L,1551L,1920L,4194L,6279L,10857L,19648L,20384L,32016L,63656L,65703L,83271L,84119L,86241L,105570L,145237L,181844L,271328L,271741L,316710L,322953L,331976L,345185L,379659L,381430L,409915L,424503L,490255L,524476L,542565L,550271L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076525Inst : IEnumerable<long>
{
public static readonly long[] Value=A076525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076525.Bytes);
public long this[int i]=>Value[i];

public static A076525Inst Instance=new A076525Inst();

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