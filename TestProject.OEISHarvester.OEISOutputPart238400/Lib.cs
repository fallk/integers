using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A020904
{
public static readonly long[] Value={ 2L,4L,7L,9L,11L,13L,16L,18L,22L,24L,27L,29L,31L,34L,37L,39L,42L,44L,46L,48L,51L,53L,56L,58L,61L,63L,65L,67L,69L,72L,74L,76L,79L,81L,84L,86L,88L,90L,92L,94L,97L,99L,101L,103L,106L,108L,111L,113L,115L,117L,121L,123L,126L,128L,130L,132L,135L,137L,139L,142L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020904Inst : IEnumerable<long>
{
public static readonly long[] Value=A020904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020904.Bytes);
public long this[int i]=>Value[i];

public static A020904Inst Instance=new A020904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020905
{
public static readonly long[] Value={ 14L,23L,76L,93L,241L,312L,373L,388L,504L,912L,956L,1117L,1528L,2088L,2064L,3564L,3744L,4092L,6022L,6816L,8664L,9664L,13281L,15632L,17364L,19199L,19717L,21183L,21913L,24630L,24720L,27429L,31954L,32517L,35881L,37784L,37669L,41947L,49704L,50868L,55439L,57313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020905Inst : IEnumerable<long>
{
public static readonly long[] Value=A020905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020905.Bytes);
public long this[int i]=>Value[i];

public static A020905Inst Instance=new A020905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020906
{
public static readonly long[] Value={ 1L,2L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020906Inst : IEnumerable<long>
{
public static readonly long[] Value=A020906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020906.Bytes);
public long this[int i]=>Value[i];

public static A020906Inst Instance=new A020906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020907
{
public static readonly long[] Value={ 2L,5L,9L,11L,14L,17L,20L,24L,27L,32L,35L,37L,41L,44L,47L,51L,54L,56L,58L,62L,65L,68L,70L,74L,77L,81L,83L,87L,90L,92L,95L,97L,101L,104L,107L,110L,112L,116L,119L,123L,126L,128L,132L,135L,137L,140L,143L,145L,149L,152L,155L,158L,161L,163L,167L,170L,174L,177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020907Inst : IEnumerable<long>
{
public static readonly long[] Value=A020907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020907.Bytes);
public long this[int i]=>Value[i];

public static A020907Inst Instance=new A020907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020908
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,3L,3L,3L,6L,3L,6L,6L,5L,6L,8L,7L,6L,7L,7L,8L,8L,11L,12L,13L,9L,9L,12L,6L,10L,14L,13L,14L,11L,15L,12L,16L,18L,17L,18L,18L,20L,18L,15L,17L,21L,19L,21L,20L,19L,18L,21L,20L,20L,19L,22L,19L,21L,24L,28L,25L,28L,28L,24L,25L,28L,29L,25L,29L,31L,30L,29L,27L,33L,31L,32L,31L,29L,32L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020908Inst : IEnumerable<long>
{
public static readonly long[] Value=A020908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020908.Bytes);
public long this[int i]=>Value[i];

public static A020908Inst Instance=new A020908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020909
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,4L,5L,6L,6L,7L,8L,8L,9L,10L,10L,11L,12L,13L,13L,14L,15L,15L,16L,17L,17L,18L,19L,19L,20L,21L,22L,22L,23L,24L,24L,25L,26L,26L,27L,28L,28L,29L,30L,31L,31L,32L,33L,33L,34L,35L,35L,36L,37L,38L,38L,39L,40L,40L,41L,42L,42L,43L,44L,44L,45L,46L,47L,47L,48L,49L,49L,50L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020909Inst : IEnumerable<long>
{
public static readonly long[] Value=A020909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020909.Bytes);
public long this[int i]=>Value[i];

public static A020909Inst Instance=new A020909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020910
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,3L,5L,6L,6L,8L,7L,6L,8L,8L,11L,9L,12L,10L,12L,13L,13L,14L,18L,13L,16L,16L,15L,19L,19L,18L,18L,15L,20L,16L,20L,25L,23L,24L,21L,22L,23L,23L,28L,28L,28L,24L,33L,28L,25L,36L,33L,34L,37L,39L,38L,30L,35L,31L,31L,33L,41L,45L,46L,39L,38L,47L,50L,47L,45L,43L,49L,51L,49L,46L,44L,50L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020910Inst : IEnumerable<long>
{
public static readonly long[] Value=A020910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020910.Bytes);
public long this[int i]=>Value[i];

public static A020910Inst Instance=new A020910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020911
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,3L,3L,4L,4L,5L,5L,5L,6L,6L,7L,7L,8L,8L,9L,9L,9L,10L,10L,11L,11L,12L,12L,12L,13L,13L,14L,14L,15L,15L,16L,16L,16L,17L,17L,18L,18L,19L,19L,19L,20L,20L,21L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020911Inst : IEnumerable<long>
{
public static readonly long[] Value=A020911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020911.Bytes);
public long this[int i]=>Value[i];

public static A020911Inst Instance=new A020911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020912
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,3L,3L,3L,4L,4L,4L,5L,5L,5L,6L,6L,7L,7L,7L,8L,8L,8L,9L,9L,9L,10L,10L,10L,11L,11L,11L,12L,12L,12L,13L,13L,13L,14L,14L,14L,15L,15L,16L,16L,16L,17L,17L,17L,18L,18L,18L,19L,19L,19L,20L,20L,20L,21L,21L,21L,22L,22L,22L,23L,23L,24L,24L,24L,25L,25L,25L,26L,26L,26L,27L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020912Inst : IEnumerable<long>
{
public static readonly long[] Value=A020912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020912.Bytes);
public long this[int i]=>Value[i];

public static A020912Inst Instance=new A020912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020913
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,3L,4L,4L,4L,4L,5L,5L,5L,6L,6L,6L,7L,7L,7L,7L,8L,8L,8L,9L,9L,9L,10L,10L,10L,10L,11L,11L,11L,12L,12L,12L,13L,13L,13L,13L,14L,14L,14L,15L,15L,15L,16L,16L,16L,16L,17L,17L,17L,18L,18L,18L,19L,19L,19L,19L,20L,20L,20L,21L,21L,21L,22L,22L,22L,22L,23L,23L,23L,24L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020913Inst : IEnumerable<long>
{
public static readonly long[] Value=A020913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020913.Bytes);
public long this[int i]=>Value[i];

public static A020913Inst Instance=new A020913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020914
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,10L,12L,13L,15L,16L,18L,20L,21L,23L,24L,26L,27L,29L,31L,32L,34L,35L,37L,39L,40L,42L,43L,45L,46L,48L,50L,51L,53L,54L,56L,58L,59L,61L,62L,64L,65L,67L,69L,70L,72L,73L,75L,77L,78L,80L,81L,83L,85L,86L,88L,89L,91L,92L,94L,96L,97L,99L,100L,102L,104L,105L,107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020914Inst : IEnumerable<long>
{
public static readonly long[] Value=A020914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020914.Bytes);
public long this[int i]=>Value[i];

public static A020914Inst Instance=new A020914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020915
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,4L,5L,6L,6L,7L,7L,8L,9L,9L,10L,11L,11L,12L,12L,13L,14L,14L,15L,16L,16L,17L,18L,18L,19L,19L,20L,21L,21L,22L,23L,23L,24L,24L,25L,26L,26L,27L,28L,28L,29L,30L,30L,31L,31L,32L,33L,33L,34L,35L,35L,36L,36L,37L,38L,38L,39L,40L,40L,41L,42L,42L,43L,43L,44L,45L,45L,46L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020915Inst : IEnumerable<long>
{
public static readonly long[] Value=A020915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020915.Bytes);
public long this[int i]=>Value[i];

public static A020915Inst Instance=new A020915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020916
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,0L,0L,24L,96L,0L,0L,10000L,60736L,0L,0L,20511168L,168661760L,0L,0L,134002359296L,1398597049856L,0L,0L,2146989255011328L,27232259080056832L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020916Inst : IEnumerable<long>
{
public static readonly long[] Value=A020916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020916.Bytes);
public long this[int i]=>Value[i];

public static A020916Inst Instance=new A020916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020917
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,5L,5L,5L,6L,6L,6L,9L,9L,9L,10L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020917Inst : IEnumerable<long>
{
public static readonly long[] Value=A020917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020917.Bytes);
public long this[int i]=>Value[i];

public static A020917Inst Instance=new A020917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020918
{
public static readonly long[] Value={ 1L,14L,126L,924L,6006L,36036L,204204L,1108536L,5819814L,29745716L,148728580L,730122120L,3528923580L,16830250920L,79342611480L,370265520240L,1712478031110L,7857252142740L,35794148650260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020918Inst : IEnumerable<long>
{
public static readonly long[] Value=A020918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020918.Bytes);
public long this[int i]=>Value[i];

public static A020918Inst Instance=new A020918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020919
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,0L,4L,0L,8L,9L,1L,0L,2L,3L,0L,0L,0L,0L,6L,0L,0L,1L,1L,2L,0L,5L,7L,0L,0L,5L,0L,0L,1L,1L,0L,3L,0L,0L,0L,4L,0L,0L,0L,1L,1L,2L,3L,5L,0L,0L,0L,0L,8L,0L,1L,0L,2L,0L,0L,7L,0L,0L,6L,0L,9L,1L,1L,2L,3L,5L,7L,0L,4L,0L,0L,9L,1L,0L,2L,3L,0L,0L,0L,0L,0L,8L,0L,1L,1L,2L,3L,5L,7L,0L,4L,0L,8L,0L,1L,1L,2L,3L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020919Inst : IEnumerable<long>
{
public static readonly long[] Value=A020919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020919.Bytes);
public long this[int i]=>Value[i];

public static A020919Inst Instance=new A020919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020920
{
public static readonly long[] Value={ 1L,18L,198L,1716L,12870L,87516L,554268L,3325608L,19122246L,106234700L,573667380L,3024791640L,15628090140L,79342611480L,396713057400L,1957117749840L,9540949030470L,46021048264620L,219878341708740L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020920Inst : IEnumerable<long>
{
public static readonly long[] Value=A020920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020920.Bytes);
public long this[int i]=>Value[i];

public static A020920Inst Instance=new A020920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020921
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,1L,0L,2L,3L,1L,0L,2L,5L,4L,1L,0L,4L,10L,10L,5L,1L,0L,2L,11L,19L,15L,6L,1L,0L,6L,21L,35L,35L,21L,7L,1L,0L,4L,22L,52L,69L,56L,28L,8L,1L,0L,6L,33L,83L,126L,126L,84L,36L,9L,1L,0L,4L,34L,110L,205L,251L,210L,120L,45L,10L,1L,0L,10L,55L,165L,330L,462L,462L,330L,165L,55L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020921Inst : IEnumerable<long>
{
public static readonly long[] Value=A020921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020921.Bytes);
public long this[int i]=>Value[i];

public static A020921Inst Instance=new A020921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020922
{
public static readonly long[] Value={ 1L,22L,286L,2860L,24310L,184756L,1293292L,8498776L,53117350L,318704100L,1848483780L,10418726760L,57302997180L,308554600200L,1630931458200L,8480843582640L,43464323361030L,219878341708740L,1099391708543700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020922Inst : IEnumerable<long>
{
public static readonly long[] Value=A020922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020922.Bytes);
public long this[int i]=>Value[i];

public static A020922Inst Instance=new A020922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020923
{
public static readonly long[] Value={ 1L,-22L,198L,-924L,2310L,-2772L,924L,264L,198L,220L,308L,504L,924L,1848L,3960L,8976L,21318L,52668L,134596L,354200L,956340L,2641320L,7443720L,21360240L,62300700L,184410072L,553230216L,1680180656L,5160554872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020923Inst : IEnumerable<long>
{
public static readonly long[] Value=A020923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020923.Bytes);
public long this[int i]=>Value[i];

public static A020923Inst Instance=new A020923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020924
{
public static readonly long[] Value={ 1L,26L,390L,4420L,41990L,352716L,2704156L,19315400L,130378950L,840219900L,5209363380L,31256180280L,182327718300L,1037865473400L,5782393351800L,31610416989840L,169905991320390L,899502306990300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020924Inst : IEnumerable<long>
{
public static readonly long[] Value=A020924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020924.Bytes);
public long this[int i]=>Value[i];

public static A020924Inst Instance=new A020924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020925
{
public static readonly long[] Value={ 1L,-26L,286L,-1716L,6006L,-12012L,12012L,-3432L,-858L,-572L,-572L,-728L,-1092L,-1848L,-3432L,-6864L,-14586L,-32604L,-76076L,-184184L,-460460L,-1184040L,-3121560L,-8414640L,-23140260L,-64792728L,-184410072L,-532740208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020925Inst : IEnumerable<long>
{
public static readonly long[] Value=A020925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020925.Bytes);
public long this[int i]=>Value[i];

public static A020925Inst Instance=new A020925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020926
{
public static readonly long[] Value={ 1L,30L,510L,6460L,67830L,624036L,5200300L,40116600L,290845350L,2003601300L,13223768580L,84151254600L,518932736700L,3113596420200L,18236779032600L,104557533120240L,588136123801350L,3252046802195700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020926Inst : IEnumerable<long>
{
public static readonly long[] Value=A020926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020926.Bytes);
public long this[int i]=>Value[i];

public static A020926Inst Instance=new A020926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020927
{
public static readonly long[] Value={ 1L,-30L,390L,-2860L,12870L,-36036L,60060L,-51480L,12870L,2860L,1716L,1560L,1820L,2520L,3960L,6864L,12870L,25740L,54340L,120120L,276276L,657800L,1614600L,4071600L,10518300L,27768312L,74760840L,204900080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020927Inst : IEnumerable<long>
{
public static readonly long[] Value=A020927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020927.Bytes);
public long this[int i]=>Value[i];

public static A020927Inst Instance=new A020927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020928
{
public static readonly long[] Value={ 1L,34L,646L,9044L,104006L,1040060L,9360540L,77558760L,601080390L,4407922860L,30855460020L,207573094680L,1349225115420L,8510496881880L,52278766560120L,313672599360720L,1842826521244230L,10623352887172620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020928Inst : IEnumerable<long>
{
public static readonly long[] Value=A020928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020928.Bytes);
public long this[int i]=>Value[i];

public static A020928Inst Instance=new A020928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020929
{
public static readonly long[] Value={ 1L,-34L,510L,-4420L,24310L,-87516L,204204L,-291720L,218790L,-48620L,-9724L,-5304L,-4420L,-4760L,-6120L,-8976L,-14586L,-25740L,-48620L,-97240L,-204204L,-447304L,-1016600L,-2386800L,-5768100L,-14304888L,-36312408L,-94143280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020929Inst : IEnumerable<long>
{
public static readonly long[] Value=A020929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020929.Bytes);
public long this[int i]=>Value[i];

public static A020929Inst Instance=new A020929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020930
{
public static readonly long[] Value={ 1L,38L,798L,12236L,152950L,1651860L,15967980L,141430680L,1166803110L,9075135300L,67156001220L,476197099560L,3254013513660L,21526550936520L,138384970306200L,867212480585520L,5311676443586310L,31870058661517860L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020930Inst : IEnumerable<long>
{
public static readonly long[] Value=A020930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020930.Bytes);
public long this[int i]=>Value[i];

public static A020930Inst Instance=new A020930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020931
{
public static readonly long[] Value={ 1L,-38L,646L,-6460L,41990L,-184756L,554268L,-1108536L,1385670L,-923780L,184756L,33592L,16796L,12920L,12920L,15504L,21318L,32604L,54340L,97240L,184756L,369512L,772616L,1679600L,3779100L,8767512L,20907144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020931Inst : IEnumerable<long>
{
public static readonly long[] Value=A020931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020931.Bytes);
public long this[int i]=>Value[i];

public static A020931Inst Instance=new A020931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020932
{
public static readonly long[] Value={ 1L,42L,966L,16100L,217350L,2521260L,26053020L,245642760L,2149374150L,17672631900L,137846528820L,1027583214840L,7364346373020L,50983936428600L,342320716020600L,2236495344667920L,14257657822257990L,88900689950549820L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020932Inst : IEnumerable<long>
{
public static readonly long[] Value=A020932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020932.Bytes);
public long this[int i]=>Value[i];

public static A020932Inst Instance=new A020932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020933
{
public static readonly long[] Value={ 1L,-42L,798L,-9044L,67830L,-352716L,1293292L,-3325608L,5819814L,-6466460L,3879876L,-705432L,-117572L,-54264L,-38760L,-36176L,-40698L,-52668L,-76076L,-120120L,-204204L,-369512L,-705432L,-1410864L,-2939300L,-6348888L,-14162904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020933Inst : IEnumerable<long>
{
public static readonly long[] Value=A020933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020933.Bytes);
public long this[int i]=>Value[i];

public static A020933Inst Instance=new A020933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020934
{
public static readonly long[] Value={ 4L,5L,8L,9L,14L,15L,19L,21L,24L,30L,30L,34L,38L,39L,42L,47L,51L,53L,56L,61L,61L,65L,67L,71L,76L,79L,80L,82L,84L,87L,96L,99L,101L,101L,108L,110L,114L,118L,121L,125L,127L,128L,135L,136L,138L,138L,146L,154L,155L,156L,158L,162L,162L,168L,172L,177L,180L,180L,185L,188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020934Inst : IEnumerable<long>
{
public static readonly long[] Value=A020934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020934.Bytes);
public long this[int i]=>Value[i];

public static A020934Inst Instance=new A020934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020935
{
public static readonly long[] Value={ 4L,6L,9L,11L,16L,18L,23L,24L,30L,34L,36L,42L,46L,47L,51L,56L,62L,62L,67L,71L,72L,77L,80L,86L,92L,96L,97L,99L,100L,103L,115L,119L,124L,125L,132L,133L,137L,141L,145L,150L,154L,154L,162L,162L,166L,167L,177L,186L,189L,189L,192L,196L,197L,204L,208L,214L,217L,217L,221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020935Inst : IEnumerable<long>
{
public static readonly long[] Value=A020935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020935.Bytes);
public long this[int i]=>Value[i];

public static A020935Inst Instance=new A020935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020936
{
public static readonly long[] Value={ 5L,7L,10L,13L,18L,21L,26L,30L,33L,40L,42L,47L,53L,55L,60L,66L,71L,72L,79L,82L,84L,91L,94L,99L,106L,110L,113L,116L,119L,123L,135L,137L,142L,145L,154L,154L,160L,165L,168L,174L,180L,180L,189L,191L,194L,196L,205L,217L,218L,220L,221L,227L,228L,239L,242L,248L,255L,257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020936Inst : IEnumerable<long>
{
public static readonly long[] Value=A020936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020936.Bytes);
public long this[int i]=>Value[i];

public static A020936Inst Instance=new A020936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020937
{
public static readonly long[] Value={ 6L,8L,11L,15L,21L,24L,30L,32L,37L,46L,47L,55L,61L,62L,66L,73L,80L,82L,91L,94L,97L,101L,106L,114L,123L,126L,128L,132L,135L,138L,154L,156L,162L,164L,175L,177L,184L,189L,192L,197L,204L,205L,217L,217L,220L,221L,233L,246L,250L,252L,258L,263L,263L,273L,278L,282L,289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020937Inst : IEnumerable<long>
{
public static readonly long[] Value=A020937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020937.Bytes);
public long this[int i]=>Value[i];

public static A020937Inst Instance=new A020937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020938
{
public static readonly long[] Value={ 6L,9L,12L,16L,23L,27L,32L,36L,42L,50L,53L,62L,66L,68L,74L,82L,91L,93L,99L,103L,106L,115L,121L,127L,137L,139L,143L,147L,150L,154L,170L,175L,183L,186L,195L,197L,204L,213L,217L,221L,226L,229L,241L,243L,248L,250L,263L,276L,280L,282L,284L,292L,293L,304L,310L,317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020938Inst : IEnumerable<long>
{
public static readonly long[] Value=A020938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020938.Bytes);
public long this[int i]=>Value[i];

public static A020938Inst Instance=new A020938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020939
{
public static readonly long[] Value={ 7L,9L,14L,18L,25L,30L,36L,39L,46L,55L,59L,67L,73L,76L,82L,91L,99L,101L,110L,115L,119L,127L,132L,139L,150L,155L,157L,162L,165L,170L,189L,193L,202L,204L,217L,217L,223L,232L,239L,245L,254L,258L,267L,270L,274L,278L,290L,304L,309L,310L,316L,324L,326L,335L,344L,350L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020939Inst : IEnumerable<long>
{
public static readonly long[] Value=A020939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020939.Bytes);
public long this[int i]=>Value[i];

public static A020939Inst Instance=new A020939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020940
{
public static readonly long[] Value={ 8L,10L,15L,19L,29L,31L,39L,42L,50L,61L,63L,73L,80L,82L,91L,99L,107L,111L,121L,127L,129L,138L,145L,154L,163L,169L,172L,180L,181L,189L,205L,214L,219L,221L,237L,239L,247L,258L,263L,269L,278L,279L,292L,293L,297L,300L,317L,331L,337L,340L,344L,355L,357L,368L,375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020940Inst : IEnumerable<long>
{
public static readonly long[] Value=A020940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020940.Bytes);
public long this[int i]=>Value[i];

public static A020940Inst Instance=new A020940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020941
{
public static readonly long[] Value={ 1L,7L,16L,39L,84L,157L,309L,555L,1042L,1919L,3338L,6011L,10713L,18321L,32228L,54730L,95320L,165177L,278208L,478807L,803383L,1374926L,2346070L,3917414L,6656320L,11284381L,18772741L,31721202L,52672252L,88750072L,149303520L,247281057L,415039507L,695705846L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020941Inst : IEnumerable<long>
{
public static readonly long[] Value=A020941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020941.Bytes);
public long this[int i]=>Value[i];

public static A020941Inst Instance=new A020941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020942
{
public static readonly long[] Value={ 1L,5L,7L,10L,14L,18L,20L,24L,26L,29L,33L,35L,38L,42L,46L,48L,51L,55L,59L,61L,65L,67L,70L,74L,78L,80L,84L,86L,89L,93L,95L,98L,102L,106L,108L,112L,114L,117L,121L,123L,126L,130L,134L,136L,139L,143L,147L,149L,153L,155L,158L,162L,164L,167L,171L,175L,177L,180L,184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020942Inst : IEnumerable<long>
{
public static readonly long[] Value=A020942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020942.Bytes);
public long this[int i]=>Value[i];

public static A020942Inst Instance=new A020942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020943
{
public static readonly long[] Value={ 0L,1L,1L,1L,0L,2L,2L,2L,0L,1L,1L,2L,1L,4L,3L,4L,1L,2L,1L,1L,0L,2L,2L,3L,1L,3L,2L,5L,3L,7L,4L,7L,3L,5L,2L,3L,1L,3L,2L,2L,0L,1L,1L,2L,1L,4L,3L,5L,2L,4L,2L,4L,2L,5L,3L,7L,4L,8L,4L,10L,6L,11L,5L,11L,6L,10L,4L,8L,4L,7L,3L,5L,2L,4L,2L,4L,2L,5L,3L,4L,1L,2L,1L,1L,0L,2L,2L,3L,1L,3L,2L,5L,3L,7L,4L,8L,4L,7L,3L,6L,3L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020943Inst : IEnumerable<long>
{
public static readonly long[] Value=A020943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020943.Bytes);
public long this[int i]=>Value[i];

public static A020943Inst Instance=new A020943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020944
{
public static readonly long[] Value={ -1L,1L,0L,1L,1L,0L,1L,1L,2L,1L,1L,0L,1L,1L,2L,1L,3L,2L,3L,1L,2L,1L,1L,0L,1L,1L,2L,1L,3L,2L,3L,1L,4L,3L,5L,2L,5L,3L,4L,1L,3L,2L,3L,1L,2L,1L,1L,0L,1L,1L,2L,1L,3L,2L,3L,1L,4L,3L,5L,2L,5L,3L,4L,1L,5L,4L,7L,3L,8L,5L,7L,2L,7L,5L,8L,3L,7L,4L,5L,1L,4L,3L,5L,2L,5L,3L,4L,1L,3L,2L,3L,1L,2L,1L,1L,0L,1L,1L,2L,1L,3L,2L,3L,1L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020944Inst : IEnumerable<long>
{
public static readonly long[] Value=A020944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020944.Bytes);
public long this[int i]=>Value[i];

public static A020944Inst Instance=new A020944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020945
{
public static readonly long[] Value={ 1L,1L,0L,2L,2L,1L,1L,2L,1L,4L,3L,3L,0L,2L,2L,3L,1L,3L,2L,5L,3L,7L,4L,6L,2L,3L,1L,2L,1L,4L,3L,5L,2L,4L,2L,4L,2L,5L,3L,7L,4L,8L,4L,10L,6L,11L,5L,10L,5L,8L,3L,5L,2L,4L,2L,3L,1L,3L,2L,5L,3L,7L,4L,8L,4L,7L,3L,6L,3L,6L,3L,6L,3L,6L,3L,7L,4L,8L,4L,10L,6L,11L,5L,12L,7L,12L,5L,14L,9L,16L,7L,17L,10L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020945Inst : IEnumerable<long>
{
public static readonly long[] Value=A020945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020945.Bytes);
public long this[int i]=>Value[i];

public static A020945Inst Instance=new A020945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020946
{
public static readonly long[] Value={ 0L,1L,3L,5L,9L,11L,33L,19L,21L,35L,39L,37L,45L,43L,69L,73L,93L,77L,75L,83L,189L,85L,141L,139L,153L,151L,147L,155L,267L,149L,165L,173L,279L,275L,171L,283L,315L,277L,537L,325L,297L,293L,579L,301L,309L,365L,333L,299L,567L,331L,339L,553L,549L,563L,1275L,341L,585L,565L,615L,629L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020946Inst : IEnumerable<long>
{
public static readonly long[] Value=A020946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020946.Bytes);
public long this[int i]=>Value[i];

public static A020946Inst Instance=new A020946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020947
{
public static readonly long[] Value={ 2L,6L,15L,14L,28L,61L,30L,58L,121L,60L,62L,116L,241L,120L,245L,122L,124L,469L,234L,806L,509L,254L,242L,248L,244L,252L,250L,466L,510L,468L,494L,482L,486L,977L,488L,484L,504L,492L,930L,490L,506L,936L,500L,932L,940L,966L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020947Inst : IEnumerable<long>
{
public static readonly long[] Value=A020947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020947.Bytes);
public long this[int i]=>Value[i];

public static A020947Inst Instance=new A020947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020948
{
public static readonly long[] Value={ 1L,8L,16L,32L,34L,128L,66L,68L,130L,134L,132L,140L,138L,260L,264L,284L,268L,266L,274L,572L,276L,524L,522L,536L,534L,530L,538L,1034L,532L,548L,556L,1046L,1042L,554L,1050L,1082L,1044L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020948Inst : IEnumerable<long>
{
public static readonly long[] Value=A020948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020948.Bytes);
public long this[int i]=>Value[i];

public static A020948Inst Instance=new A020948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020949
{
public static readonly long[] Value={ 1L,4L,11L,10L,20L,24L,22L,42L,89L,44L,46L,84L,100L,88L,96L,90L,92L,204L,170L,202L,192L,190L,178L,184L,180L,188L,186L,338L,382L,340L,366L,354L,358L,390L,360L,356L,376L,364L,674L,362L,378L,680L,372L,676L,684L,710L,812L,682L,752L,708L,810L,1346L,732L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020949Inst : IEnumerable<long>
{
public static readonly long[] Value=A020949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020949.Bytes);
public long this[int i]=>Value[i];

public static A020949Inst Instance=new A020949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020950
{
public static readonly long[] Value={ 0L,2L,4L,8L,10L,32L,18L,20L,34L,38L,36L,44L,42L,68L,72L,92L,76L,74L,82L,188L,84L,140L,138L,152L,150L,146L,154L,266L,148L,164L,172L,278L,274L,170L,282L,314L,276L,536L,324L,296L,292L,578L,300L,308L,364L,332L,298L,566L,330L,338L,552L,548L,562L,1274L,340L,584L,564L,614L,628L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020950Inst : IEnumerable<long>
{
public static readonly long[] Value=A020950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020950.Bytes);
public long this[int i]=>Value[i];

public static A020950Inst Instance=new A020950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020951
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,2L,1L,2L,1L,1L,0L,1L,1L,2L,1L,3L,2L,3L,1L,3L,2L,3L,1L,2L,1L,1L,0L,1L,1L,2L,1L,3L,2L,3L,1L,4L,3L,5L,2L,5L,3L,4L,1L,4L,3L,5L,2L,5L,3L,4L,1L,3L,2L,3L,1L,2L,1L,1L,0L,1L,1L,2L,1L,3L,2L,3L,1L,4L,3L,5L,2L,5L,3L,4L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020951Inst : IEnumerable<long>
{
public static readonly long[] Value=A020951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020951.Bytes);
public long this[int i]=>Value[i];

public static A020951Inst Instance=new A020951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020952
{
public static readonly long[] Value={ 2L,1L,3L,1L,4L,3L,4L,1L,5L,4L,7L,3L,7L,4L,5L,1L,6L,5L,9L,4L,11L,7L,10L,3L,10L,7L,11L,4L,9L,5L,6L,1L,7L,6L,11L,5L,14L,9L,13L,4L,15L,11L,18L,7L,17L,10L,13L,3L,13L,10L,17L,7L,18L,11L,15L,4L,13L,9L,14L,5L,11L,6L,7L,1L,8L,7L,13L,6L,17L,11L,16L,5L,19L,14L,23L,9L,22L,13L,17L,4L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020952Inst : IEnumerable<long>
{
public static readonly long[] Value=A020952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020952.Bytes);
public long this[int i]=>Value[i];

public static A020952Inst Instance=new A020952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020953
{
public static readonly long[] Value={ 0L,10L,20L,40L,42L,160L,82L,84L,162L,166L,164L,172L,170L,324L,328L,348L,332L,330L,338L,700L,652L,650L,664L,662L,658L,666L,1290L,660L,676L,684L,1302L,1298L,682L,1306L,1338L,1300L,1348L,1320L,1316L,1324L,1332L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020953Inst : IEnumerable<long>
{
public static readonly long[] Value=A020953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020953.Bytes);
public long this[int i]=>Value[i];

public static A020953Inst Instance=new A020953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020954
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,10L,64L,18L,22L,20L,1024L,38L,36L,40L,70L,44L,42L,72L,132L,142L,76L,74L,88L,86L,82L,90L,138L,84L,156L,152L,150L,146L,162L,154L,186L,148L,280L,278L,168L,164L,322L,172L,180L,276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020954Inst : IEnumerable<long>
{
public static readonly long[] Value=A020954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020954.Bytes);
public long this[int i]=>Value[i];

public static A020954Inst Instance=new A020954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020955
{
public static readonly BigInteger[] Value={ 1L,1L,2L,81L,4194304L,1490116119384765625L,BigInteger.Parse("226267027688376192080197927193400943822503936"),BigInteger.Parse("258086210989349276047917817413172383631691140276099547911280598425927853437317437263620645695945672001") };
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
public class A020955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020955Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A020955.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A020955.Bytes);
public BigInteger this[int i]=>Value[i];

public static A020955Inst Instance=new A020955Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020956
{
public static readonly long[] Value={ 1L,2L,4L,8L,14L,25L,42L,71L,117L,193L,315L,514L,835L,1356L,2198L,3562L,5768L,9339L,15116L,24465L,39591L,64067L,103669L,167748L,271429L,439190L,710632L,1149836L,1860482L,3010333L,4870830L,7881179L,12752025L,20633221L,33385263L,54018502L,87403783L,141422304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020956Inst : IEnumerable<long>
{
public static readonly long[] Value=A020956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020956.Bytes);
public long this[int i]=>Value[i];

public static A020956Inst Instance=new A020956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021741
{
public static readonly long[] Value={ 0L,0L,1L,3L,5L,6L,8L,5L,2L,1L,0L,3L,1L,2L,0L,7L,5L,9L,8L,3L,7L,1L,7L,7L,7L,4L,7L,6L,2L,5L,5L,0L,8L,8L,1L,9L,5L,3L,8L,6L,7L,0L,2L,8L,4L,9L,3L,8L,9L,4L,1L,6L,5L,5L,3L,5L,9L,5L,6L,5L,8L,0L,7L,3L,2L,7L,0L,0L,1L,3L,5L,6L,8L,5L,2L,1L,0L,3L,1L,2L,0L,7L,5L,9L,8L,3L,7L,1L,7L,7L,7L,4L,7L,6L,2L,5L,5L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021741Inst : IEnumerable<long>
{
public static readonly long[] Value=A021741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021741.Bytes);
public long this[int i]=>Value[i];

public static A021741Inst Instance=new A021741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021742
{
public static readonly long[] Value={ 0L,0L,1L,3L,5L,5L,0L,1L,3L,5L,5L,0L,1L,3L,5L,5L,0L,1L,3L,5L,5L,0L,1L,3L,5L,5L,0L,1L,3L,5L,5L,0L,1L,3L,5L,5L,0L,1L,3L,5L,5L,0L,1L,3L,5L,5L,0L,1L,3L,5L,5L,0L,1L,3L,5L,5L,0L,1L,3L,5L,5L,0L,1L,3L,5L,5L,0L,1L,3L,5L,5L,0L,1L,3L,5L,5L,0L,1L,3L,5L,5L,0L,1L,3L,5L,5L,0L,1L,3L,5L,5L,0L,1L,3L,5L,5L,0L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021742Inst : IEnumerable<long>
{
public static readonly long[] Value=A021742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021742.Bytes);
public long this[int i]=>Value[i];

public static A021742Inst Instance=new A021742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021743
{
public static readonly long[] Value={ 0L,0L,1L,3L,5L,3L,1L,7L,9L,9L,7L,2L,9L,3L,6L,4L,0L,0L,5L,4L,1L,2L,7L,1L,9L,8L,9L,1L,7L,4L,5L,6L,0L,2L,1L,6L,5L,0L,8L,7L,9L,5L,6L,6L,9L,8L,2L,4L,0L,8L,6L,6L,0L,3L,5L,1L,8L,2L,6L,7L,9L,2L,9L,6L,3L,4L,6L,4L,1L,4L,0L,7L,3L,0L,7L,1L,7L,1L,8L,5L,3L,8L,5L,6L,5L,6L,2L,9L,2L,2L,8L,6L,8L,7L,4L,1L,5L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021743Inst : IEnumerable<long>
{
public static readonly long[] Value=A021743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021743.Bytes);
public long this[int i]=>Value[i];

public static A021743Inst Instance=new A021743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021744
{
public static readonly long[] Value={ 1L,16L,167L,1442L,11193L,81228L,563179L,3779974L,24771725L,159439280L,1012078431L,6355276746L,39568060897L,244679845972L,1504794392723L,9213774596558L,56213415403509L,341957238034104L,2075218782238855L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021744Inst : IEnumerable<long>
{
public static readonly long[] Value=A021744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021744.Bytes);
public long this[int i]=>Value[i];

public static A021744Inst Instance=new A021744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021745
{
public static readonly long[] Value={ 0L,0L,1L,3L,4L,9L,5L,2L,7L,6L,6L,5L,3L,1L,7L,1L,3L,9L,0L,0L,1L,3L,4L,9L,5L,2L,7L,6L,6L,5L,3L,1L,7L,1L,3L,9L,0L,0L,1L,3L,4L,9L,5L,2L,7L,6L,6L,5L,3L,1L,7L,1L,3L,9L,0L,0L,1L,3L,4L,9L,5L,2L,7L,6L,6L,5L,3L,1L,7L,1L,3L,9L,0L,0L,1L,3L,4L,9L,5L,2L,7L,6L,6L,5L,3L,1L,7L,1L,3L,9L,0L,0L,1L,3L,4L,9L,5L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021745Inst : IEnumerable<long>
{
public static readonly long[] Value=A021745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021745.Bytes);
public long this[int i]=>Value[i];

public static A021745Inst Instance=new A021745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021746
{
public static readonly long[] Value={ 0L,0L,1L,3L,4L,7L,7L,0L,8L,8L,9L,4L,8L,7L,8L,7L,0L,6L,1L,9L,9L,4L,6L,0L,9L,1L,6L,4L,4L,2L,0L,4L,8L,5L,1L,7L,5L,2L,0L,2L,1L,5L,6L,3L,3L,4L,2L,3L,1L,8L,0L,5L,9L,2L,9L,9L,1L,9L,1L,3L,7L,4L,6L,6L,3L,0L,7L,2L,7L,7L,6L,2L,8L,0L,3L,2L,3L,4L,5L,0L,1L,3L,4L,7L,7L,0L,8L,8L,9L,4L,8L,7L,8L,7L,0L,6L,1L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021746Inst : IEnumerable<long>
{
public static readonly long[] Value=A021746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021746.Bytes);
public long this[int i]=>Value[i];

public static A021746Inst Instance=new A021746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021747
{
public static readonly long[] Value={ 0L,0L,1L,3L,4L,5L,8L,9L,5L,0L,2L,0L,1L,8L,8L,4L,2L,5L,3L,0L,2L,8L,2L,6L,3L,7L,9L,5L,4L,2L,3L,9L,5L,6L,9L,3L,1L,3L,5L,9L,3L,5L,3L,9L,7L,0L,3L,9L,0L,3L,0L,9L,5L,5L,5L,8L,5L,4L,6L,4L,3L,3L,3L,7L,8L,1L,9L,6L,5L,0L,0L,6L,7L,2L,9L,4L,7L,5L,1L,0L,0L,9L,4L,2L,1L,2L,6L,5L,1L,4L,1L,3L,1L,8L,9L,7L,7L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021747Inst : IEnumerable<long>
{
public static readonly long[] Value=A021747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021747.Bytes);
public long this[int i]=>Value[i];

public static A021747Inst Instance=new A021747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021748
{
public static readonly long[] Value={ 0L,0L,1L,3L,4L,4L,0L,8L,6L,0L,2L,1L,5L,0L,5L,3L,7L,6L,3L,4L,4L,0L,8L,6L,0L,2L,1L,5L,0L,5L,3L,7L,6L,3L,4L,4L,0L,8L,6L,0L,2L,1L,5L,0L,5L,3L,7L,6L,3L,4L,4L,0L,8L,6L,0L,2L,1L,5L,0L,5L,3L,7L,6L,3L,4L,4L,0L,8L,6L,0L,2L,1L,5L,0L,5L,3L,7L,6L,3L,4L,4L,0L,8L,6L,0L,2L,1L,5L,0L,5L,3L,7L,6L,3L,4L,4L,0L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021748Inst : IEnumerable<long>
{
public static readonly long[] Value=A021748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021748.Bytes);
public long this[int i]=>Value[i];

public static A021748Inst Instance=new A021748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021749
{
public static readonly long[] Value={ 0L,0L,1L,3L,4L,2L,2L,8L,1L,8L,7L,9L,1L,9L,4L,6L,3L,0L,8L,7L,2L,4L,8L,3L,2L,2L,1L,4L,7L,6L,5L,1L,0L,0L,6L,7L,1L,1L,4L,0L,9L,3L,9L,5L,9L,7L,3L,1L,5L,4L,3L,6L,2L,4L,1L,6L,1L,0L,7L,3L,8L,2L,5L,5L,0L,3L,3L,5L,5L,7L,0L,4L,6L,9L,7L,9L,8L,6L,5L,7L,7L,1L,8L,1L,2L,0L,8L,0L,5L,3L,6L,9L,1L,2L,7L,5L,1L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021749Inst : IEnumerable<long>
{
public static readonly long[] Value=A021749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021749.Bytes);
public long this[int i]=>Value[i];

public static A021749Inst Instance=new A021749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021750
{
public static readonly long[] Value={ 0L,0L,1L,3L,4L,0L,4L,8L,2L,5L,7L,3L,7L,2L,6L,5L,4L,1L,5L,5L,4L,9L,5L,9L,7L,8L,5L,5L,2L,2L,7L,8L,8L,2L,0L,3L,7L,5L,3L,3L,5L,1L,2L,0L,6L,4L,3L,4L,3L,1L,6L,3L,5L,3L,8L,8L,7L,3L,9L,9L,4L,6L,3L,8L,0L,6L,9L,7L,0L,5L,0L,9L,3L,8L,3L,3L,7L,8L,0L,1L,6L,0L,8L,5L,7L,9L,0L,8L,8L,4L,7L,1L,8L,4L,9L,8L,6L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021750Inst : IEnumerable<long>
{
public static readonly long[] Value=A021750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021750.Bytes);
public long this[int i]=>Value[i];

public static A021750Inst Instance=new A021750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021751
{
public static readonly long[] Value={ 0L,0L,1L,3L,3L,8L,6L,8L,8L,0L,8L,5L,6L,7L,6L,0L,3L,7L,4L,8L,3L,2L,6L,6L,3L,9L,8L,9L,2L,9L,0L,4L,9L,5L,3L,1L,4L,5L,9L,1L,7L,0L,0L,1L,3L,3L,8L,6L,8L,8L,0L,8L,5L,6L,7L,6L,0L,3L,7L,4L,8L,3L,2L,6L,6L,3L,9L,8L,9L,2L,9L,0L,4L,9L,5L,3L,1L,4L,5L,9L,1L,7L,0L,0L,1L,3L,3L,8L,6L,8L,8L,0L,8L,5L,6L,7L,6L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021751Inst : IEnumerable<long>
{
public static readonly long[] Value=A021751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021751.Bytes);
public long this[int i]=>Value[i];

public static A021751Inst Instance=new A021751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021752
{
public static readonly long[] Value={ 0L,0L,1L,3L,3L,6L,8L,9L,8L,3L,9L,5L,7L,2L,1L,9L,2L,5L,1L,3L,3L,6L,8L,9L,8L,3L,9L,5L,7L,2L,1L,9L,2L,5L,1L,3L,3L,6L,8L,9L,8L,3L,9L,5L,7L,2L,1L,9L,2L,5L,1L,3L,3L,6L,8L,9L,8L,3L,9L,5L,7L,2L,1L,9L,2L,5L,1L,3L,3L,6L,8L,9L,8L,3L,9L,5L,7L,2L,1L,9L,2L,5L,1L,3L,3L,6L,8L,9L,8L,3L,9L,5L,7L,2L,1L,9L,2L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021752Inst : IEnumerable<long>
{
public static readonly long[] Value=A021752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021752.Bytes);
public long this[int i]=>Value[i];

public static A021752Inst Instance=new A021752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021753
{
public static readonly long[] Value={ 0L,0L,1L,3L,3L,5L,1L,1L,3L,4L,8L,4L,6L,4L,6L,1L,9L,4L,9L,2L,6L,5L,6L,8L,7L,5L,8L,3L,4L,4L,4L,5L,9L,2L,7L,9L,0L,3L,8L,7L,1L,8L,2L,9L,1L,0L,5L,4L,7L,3L,9L,6L,5L,2L,8L,7L,0L,4L,9L,3L,9L,9L,1L,9L,8L,9L,3L,1L,9L,0L,9L,2L,1L,2L,2L,8L,3L,0L,4L,4L,0L,5L,8L,7L,4L,4L,9L,9L,3L,3L,2L,4L,4L,3L,2L,5L,7L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021753Inst : IEnumerable<long>
{
public static readonly long[] Value=A021753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021753.Bytes);
public long this[int i]=>Value[i];

public static A021753Inst Instance=new A021753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021754
{
public static readonly long[] Value={ 1L,17L,190L,1770L,14931L,118587L,905920L,6742340L,49288261L,355826757L,2546230050L,18106416510L,128181315991L,904540692527L,6368500164580L,44764509392280L,314282333570121L,2204653080603897L,15456046918261510L,108310071701877650L,758760684298882651L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021754Inst : IEnumerable<long>
{
public static readonly long[] Value=A021754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021754.Bytes);
public long this[int i]=>Value[i];

public static A021754Inst Instance=new A021754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021755
{
public static readonly long[] Value={ 0L,0L,1L,3L,3L,1L,5L,5L,7L,9L,2L,2L,7L,6L,9L,6L,4L,0L,4L,7L,9L,3L,6L,0L,8L,5L,2L,1L,9L,7L,0L,7L,0L,5L,7L,2L,5L,6L,9L,9L,0L,6L,7L,9L,0L,9L,4L,5L,4L,0L,6L,1L,2L,5L,1L,6L,6L,4L,4L,4L,7L,4L,0L,3L,4L,6L,2L,0L,5L,0L,5L,9L,9L,2L,0L,1L,0L,6L,5L,2L,4L,6L,3L,3L,8L,2L,1L,5L,7L,1L,2L,3L,8L,3L,4L,8L,8L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021755Inst : IEnumerable<long>
{
public static readonly long[] Value=A021755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021755.Bytes);
public long this[int i]=>Value[i];

public static A021755Inst Instance=new A021755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021756
{
public static readonly long[] Value={ 0L,0L,1L,3L,2L,9L,7L,8L,7L,2L,3L,4L,0L,4L,2L,5L,5L,3L,1L,9L,1L,4L,8L,9L,3L,6L,1L,7L,0L,2L,1L,2L,7L,6L,5L,9L,5L,7L,4L,4L,6L,8L,0L,8L,5L,1L,0L,6L,3L,8L,2L,9L,7L,8L,7L,2L,3L,4L,0L,4L,2L,5L,5L,3L,1L,9L,1L,4L,8L,9L,3L,6L,1L,7L,0L,2L,1L,2L,7L,6L,5L,9L,5L,7L,4L,4L,6L,8L,0L,8L,5L,1L,0L,6L,3L,8L,2L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021756Inst : IEnumerable<long>
{
public static readonly long[] Value=A021756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021756.Bytes);
public long this[int i]=>Value[i];

public static A021756Inst Instance=new A021756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021757
{
public static readonly long[] Value={ 0L,0L,1L,3L,2L,8L,0L,2L,1L,2L,4L,8L,3L,3L,9L,9L,7L,3L,4L,3L,9L,5L,7L,5L,0L,3L,3L,2L,0L,0L,5L,3L,1L,2L,0L,8L,4L,9L,9L,3L,3L,5L,9L,8L,9L,3L,7L,5L,8L,3L,0L,0L,1L,3L,2L,8L,0L,2L,1L,2L,4L,8L,3L,3L,9L,9L,7L,3L,4L,3L,9L,5L,7L,5L,0L,3L,3L,2L,0L,0L,5L,3L,1L,2L,0L,8L,4L,9L,9L,3L,3L,5L,9L,8L,9L,3L,7L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021757Inst : IEnumerable<long>
{
public static readonly long[] Value=A021757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021757.Bytes);
public long this[int i]=>Value[i];

public static A021757Inst Instance=new A021757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021758
{
public static readonly long[] Value={ 0L,0L,1L,3L,2L,6L,2L,5L,9L,9L,4L,6L,9L,4L,9L,6L,0L,2L,1L,2L,2L,0L,1L,5L,9L,1L,5L,1L,1L,9L,3L,6L,3L,3L,9L,5L,2L,2L,5L,4L,6L,4L,1L,9L,0L,9L,8L,1L,4L,3L,2L,3L,6L,0L,7L,4L,2L,7L,0L,5L,5L,7L,0L,2L,9L,1L,7L,7L,7L,1L,8L,8L,3L,2L,8L,9L,1L,2L,4L,6L,6L,8L,4L,3L,5L,0L,1L,3L,2L,6L,2L,5L,9L,9L,4L,6L,9L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021758Inst : IEnumerable<long>
{
public static readonly long[] Value=A021758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021758.Bytes);
public long this[int i]=>Value[i];

public static A021758Inst Instance=new A021758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021759
{
public static readonly long[] Value={ 0L,0L,1L,3L,2L,4L,5L,0L,3L,3L,1L,1L,2L,5L,8L,2L,7L,8L,1L,4L,5L,6L,9L,5L,3L,6L,4L,2L,3L,8L,4L,1L,0L,5L,9L,6L,0L,2L,6L,4L,9L,0L,0L,6L,6L,2L,2L,5L,1L,6L,5L,5L,6L,2L,9L,1L,3L,9L,0L,7L,2L,8L,4L,7L,6L,8L,2L,1L,1L,9L,2L,0L,5L,2L,9L,8L,0L,1L,3L,2L,4L,5L,0L,3L,3L,1L,1L,2L,5L,8L,2L,7L,8L,1L,4L,5L,6L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021759Inst : IEnumerable<long>
{
public static readonly long[] Value=A021759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021759.Bytes);
public long this[int i]=>Value[i];

public static A021759Inst Instance=new A021759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021760
{
public static readonly long[] Value={ 0L,0L,1L,3L,2L,2L,7L,5L,1L,3L,2L,2L,7L,5L,1L,3L,2L,2L,7L,5L,1L,3L,2L,2L,7L,5L,1L,3L,2L,2L,7L,5L,1L,3L,2L,2L,7L,5L,1L,3L,2L,2L,7L,5L,1L,3L,2L,2L,7L,5L,1L,3L,2L,2L,7L,5L,1L,3L,2L,2L,7L,5L,1L,3L,2L,2L,7L,5L,1L,3L,2L,2L,7L,5L,1L,3L,2L,2L,7L,5L,1L,3L,2L,2L,7L,5L,1L,3L,2L,2L,7L,5L,1L,3L,2L,2L,7L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021760Inst : IEnumerable<long>
{
public static readonly long[] Value=A021760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021760.Bytes);
public long this[int i]=>Value[i];

public static A021760Inst Instance=new A021760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021761
{
public static readonly long[] Value={ 0L,0L,1L,3L,2L,1L,0L,0L,3L,9L,6L,3L,0L,1L,1L,8L,8L,9L,0L,3L,5L,6L,6L,7L,1L,0L,7L,0L,0L,1L,3L,2L,1L,0L,0L,3L,9L,6L,3L,0L,1L,1L,8L,8L,9L,0L,3L,5L,6L,6L,7L,1L,0L,7L,0L,0L,1L,3L,2L,1L,0L,0L,3L,9L,6L,3L,0L,1L,1L,8L,8L,9L,0L,3L,5L,6L,6L,7L,1L,0L,7L,0L,0L,1L,3L,2L,1L,0L,0L,3L,9L,6L,3L,0L,1L,1L,8L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021761Inst : IEnumerable<long>
{
public static readonly long[] Value=A021761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021761.Bytes);
public long this[int i]=>Value[i];

public static A021761Inst Instance=new A021761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021762
{
public static readonly long[] Value={ 0L,0L,1L,3L,1L,9L,2L,6L,1L,2L,1L,3L,7L,2L,0L,3L,1L,6L,6L,2L,2L,6L,9L,1L,2L,9L,2L,8L,7L,5L,9L,8L,9L,4L,4L,5L,9L,1L,0L,2L,9L,0L,2L,3L,7L,4L,6L,7L,0L,1L,8L,4L,6L,9L,6L,5L,6L,9L,9L,2L,0L,8L,4L,4L,3L,2L,7L,1L,7L,6L,7L,8L,1L,0L,0L,2L,6L,3L,8L,5L,2L,2L,4L,2L,7L,4L,4L,0L,6L,3L,3L,2L,4L,5L,3L,8L,2L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021762Inst : IEnumerable<long>
{
public static readonly long[] Value=A021762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021762.Bytes);
public long this[int i]=>Value[i];

public static A021762Inst Instance=new A021762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021763
{
public static readonly long[] Value={ 0L,0L,1L,3L,1L,7L,5L,2L,3L,0L,5L,6L,6L,5L,3L,4L,9L,1L,4L,3L,6L,1L,0L,0L,1L,3L,1L,7L,5L,2L,3L,0L,5L,6L,6L,5L,3L,4L,9L,1L,4L,3L,6L,1L,0L,0L,1L,3L,1L,7L,5L,2L,3L,0L,5L,6L,6L,5L,3L,4L,9L,1L,4L,3L,6L,1L,0L,0L,1L,3L,1L,7L,5L,2L,3L,0L,5L,6L,6L,5L,3L,4L,9L,1L,4L,3L,6L,1L,0L,0L,1L,3L,1L,7L,5L,2L,3L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021763Inst : IEnumerable<long>
{
public static readonly long[] Value=A021763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021763.Bytes);
public long this[int i]=>Value[i];

public static A021763Inst Instance=new A021763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021764
{
public static readonly long[] Value={ 1L,18L,215L,2160L,19821L,172638L,1456915L,12056220L,98541641L,799142058L,6448579215L,51871439880L,416407919461L,3338534836278L,26744994007115L,214144960297140L,1714090450201281L,13717400347223298L,109762678131820615L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021764Inst : IEnumerable<long>
{
public static readonly long[] Value=A021764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021764.Bytes);
public long this[int i]=>Value[i];

public static A021764Inst Instance=new A021764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021765
{
public static readonly long[] Value={ 0L,0L,1L,3L,1L,4L,0L,6L,0L,4L,4L,6L,7L,8L,0L,5L,5L,1L,9L,0L,5L,3L,8L,7L,6L,4L,7L,8L,3L,1L,8L,0L,0L,2L,6L,2L,8L,1L,2L,0L,8L,9L,3L,5L,6L,1L,1L,0L,3L,8L,1L,0L,7L,7L,5L,2L,9L,5L,6L,6L,3L,6L,0L,0L,5L,2L,5L,6L,2L,4L,1L,7L,8L,7L,1L,2L,2L,2L,0L,7L,6L,2L,1L,5L,5L,0L,5L,9L,1L,3L,2L,7L,2L,0L,1L,0L,5L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021765Inst : IEnumerable<long>
{
public static readonly long[] Value=A021765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021765.Bytes);
public long this[int i]=>Value[i];

public static A021765Inst Instance=new A021765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021766
{
public static readonly long[] Value={ 0L,0L,1L,3L,1L,2L,3L,3L,5L,9L,5L,8L,0L,0L,5L,2L,4L,9L,3L,4L,3L,8L,3L,2L,0L,2L,0L,9L,9L,7L,3L,7L,5L,3L,2L,8L,0L,8L,3L,9L,8L,9L,5L,0L,1L,3L,1L,2L,3L,3L,5L,9L,5L,8L,0L,0L,5L,2L,4L,9L,3L,4L,3L,8L,3L,2L,0L,2L,0L,9L,9L,7L,3L,7L,5L,3L,2L,8L,0L,8L,3L,9L,8L,9L,5L,0L,1L,3L,1L,2L,3L,3L,5L,9L,5L,8L,0L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021766Inst : IEnumerable<long>
{
public static readonly long[] Value=A021766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021766.Bytes);
public long this[int i]=>Value[i];

public static A021766Inst Instance=new A021766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021767
{
public static readonly long[] Value={ 0L,0L,1L,3L,1L,0L,6L,1L,5L,9L,8L,9L,5L,1L,5L,0L,7L,2L,0L,8L,3L,8L,7L,9L,4L,2L,3L,3L,2L,8L,9L,6L,4L,6L,1L,3L,3L,6L,8L,2L,8L,3L,0L,9L,3L,0L,5L,3L,7L,3L,5L,2L,5L,5L,5L,7L,0L,1L,1L,7L,9L,5L,5L,4L,3L,9L,0L,5L,6L,3L,5L,6L,4L,8L,7L,5L,4L,9L,1L,4L,8L,0L,9L,9L,6L,0L,6L,8L,1L,5L,2L,0L,3L,1L,4L,5L,4L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021767Inst : IEnumerable<long>
{
public static readonly long[] Value=A021767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021767.Bytes);
public long this[int i]=>Value[i];

public static A021767Inst Instance=new A021767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021768
{
public static readonly long[] Value={ 0L,0L,1L,3L,0L,8L,9L,0L,0L,5L,2L,3L,5L,6L,0L,2L,0L,9L,4L,2L,4L,0L,8L,3L,7L,6L,9L,6L,3L,3L,5L,0L,7L,8L,5L,3L,4L,0L,3L,1L,4L,1L,3L,6L,1L,2L,5L,6L,5L,4L,4L,5L,0L,2L,6L,1L,7L,8L,0L,1L,0L,4L,7L,1L,2L,0L,4L,1L,8L,8L,4L,8L,1L,6L,7L,5L,3L,9L,2L,6L,7L,0L,1L,5L,7L,0L,6L,8L,0L,6L,2L,8L,2L,7L,2L,2L,5L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021768Inst : IEnumerable<long>
{
public static readonly long[] Value=A021768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021768.Bytes);
public long this[int i]=>Value[i];

public static A021768Inst Instance=new A021768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021769
{
public static readonly long[] Value={ 0L,0L,1L,3L,0L,7L,1L,8L,9L,5L,4L,2L,4L,8L,3L,6L,6L,0L,1L,3L,0L,7L,1L,8L,9L,5L,4L,2L,4L,8L,3L,6L,6L,0L,1L,3L,0L,7L,1L,8L,9L,5L,4L,2L,4L,8L,3L,6L,6L,0L,1L,3L,0L,7L,1L,8L,9L,5L,4L,2L,4L,8L,3L,6L,6L,0L,1L,3L,0L,7L,1L,8L,9L,5L,4L,2L,4L,8L,3L,6L,6L,0L,1L,3L,0L,7L,1L,8L,9L,5L,4L,2L,4L,8L,3L,6L,6L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021769Inst : IEnumerable<long>
{
public static readonly long[] Value=A021769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021769.Bytes);
public long this[int i]=>Value[i];

public static A021769Inst Instance=new A021769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021770
{
public static readonly long[] Value={ 0L,0L,1L,3L,0L,5L,4L,8L,3L,0L,2L,8L,7L,2L,0L,6L,2L,6L,6L,3L,1L,8L,5L,3L,7L,8L,5L,9L,0L,0L,7L,8L,3L,2L,8L,9L,8L,1L,7L,2L,3L,2L,3L,7L,5L,9L,7L,9L,1L,1L,2L,2L,7L,1L,5L,4L,0L,4L,6L,9L,9L,7L,3L,8L,9L,0L,3L,3L,9L,4L,2L,5L,5L,8L,7L,4L,6L,7L,3L,6L,2L,9L,2L,4L,2L,8L,1L,9L,8L,4L,3L,3L,4L,2L,0L,3L,6L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021770Inst : IEnumerable<long>
{
public static readonly long[] Value=A021770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021770.Bytes);
public long this[int i]=>Value[i];

public static A021770Inst Instance=new A021770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021771
{
public static readonly long[] Value={ 0L,0L,1L,3L,0L,3L,7L,8L,0L,9L,6L,4L,7L,9L,7L,9L,1L,3L,9L,5L,0L,4L,5L,6L,3L,2L,3L,3L,3L,7L,6L,7L,9L,2L,6L,9L,8L,8L,2L,6L,5L,9L,7L,1L,3L,1L,6L,8L,1L,8L,7L,7L,4L,4L,4L,5L,8L,9L,3L,0L,8L,9L,9L,6L,0L,8L,8L,6L,5L,7L,1L,0L,5L,6L,0L,6L,2L,5L,8L,1L,4L,8L,6L,3L,1L,0L,2L,9L,9L,8L,6L,9L,6L,2L,1L,9L,0L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021771Inst : IEnumerable<long>
{
public static readonly long[] Value=A021771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021771.Bytes);
public long this[int i]=>Value[i];

public static A021771Inst Instance=new A021771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021772
{
public static readonly long[] Value={ 1L,19L,242L,2618L,26103L,248997L,2316784L,21251956L,193359485L,1751044295L,15814841406L,142616378814L,1284983809747L,11572125768313L,104185847231708L,937857633325592L,8441649467754489L,75979521955403451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021772Inst : IEnumerable<long>
{
public static readonly long[] Value=A021772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021772.Bytes);
public long this[int i]=>Value[i];

public static A021772Inst Instance=new A021772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021773
{
public static readonly long[] Value={ 0L,0L,1L,3L,0L,0L,3L,9L,0L,1L,1L,7L,0L,3L,5L,1L,1L,0L,5L,3L,3L,1L,5L,9L,9L,4L,7L,9L,8L,4L,3L,9L,5L,3L,1L,8L,5L,9L,5L,5L,7L,8L,6L,7L,3L,6L,0L,2L,0L,8L,0L,6L,2L,4L,1L,8L,7L,2L,5L,6L,1L,7L,6L,8L,5L,3L,0L,5L,5L,9L,1L,6L,7L,7L,5L,0L,3L,2L,5L,0L,9L,7L,5L,2L,9L,2L,5L,8L,7L,7L,7L,6L,3L,3L,2L,8L,9L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021773Inst : IEnumerable<long>
{
public static readonly long[] Value=A021773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021773.Bytes);
public long this[int i]=>Value[i];

public static A021773Inst Instance=new A021773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021774
{
public static readonly long[] Value={ 1L,20L,271L,3150L,34041L,354480L,3620611L,36607010L,368161981L,3692428740L,36979730151L,370080107670L,3702237477121L,37029646251800L,370333177834891L,3703516786589130L,37036098633715461L,370365663082767660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021774Inst : IEnumerable<long>
{
public static readonly long[] Value=A021774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021774.Bytes);
public long this[int i]=>Value[i];

public static A021774Inst Instance=new A021774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021775
{
public static readonly long[] Value={ 0L,0L,1L,2L,9L,7L,0L,1L,6L,8L,6L,1L,2L,1L,9L,1L,9L,5L,8L,4L,9L,5L,4L,6L,0L,4L,4L,0L,9L,8L,5L,7L,3L,2L,8L,1L,4L,5L,2L,6L,5L,8L,8L,8L,4L,5L,6L,5L,4L,9L,9L,3L,5L,1L,4L,9L,1L,5L,6L,9L,3L,9L,0L,4L,0L,2L,0L,7L,5L,2L,2L,6L,9L,7L,7L,9L,5L,0L,7L,1L,3L,3L,5L,9L,2L,7L,3L,6L,7L,0L,5L,5L,7L,7L,1L,7L,2L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021775Inst : IEnumerable<long>
{
public static readonly long[] Value=A021775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021775.Bytes);
public long this[int i]=>Value[i];

public static A021775Inst Instance=new A021775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021776
{
public static readonly long[] Value={ 0L,0L,1L,2L,9L,5L,3L,3L,6L,7L,8L,7L,5L,6L,4L,7L,6L,6L,8L,3L,9L,3L,7L,8L,2L,3L,8L,3L,4L,1L,9L,6L,8L,9L,1L,1L,9L,1L,7L,0L,9L,8L,4L,4L,5L,5L,9L,5L,8L,5L,4L,9L,2L,2L,2L,7L,9L,7L,9L,2L,7L,4L,6L,1L,1L,3L,9L,8L,9L,6L,3L,7L,3L,0L,5L,6L,9L,9L,4L,8L,1L,8L,6L,5L,2L,8L,4L,9L,7L,4L,0L,9L,3L,2L,6L,4L,2L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021776Inst : IEnumerable<long>
{
public static readonly long[] Value=A021776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021776.Bytes);
public long this[int i]=>Value[i];

public static A021776Inst Instance=new A021776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021777
{
public static readonly long[] Value={ 0L,0L,1L,2L,9L,3L,6L,6L,1L,0L,6L,0L,8L,0L,2L,0L,6L,9L,8L,5L,7L,6L,9L,7L,2L,8L,3L,3L,1L,1L,7L,7L,2L,3L,1L,5L,6L,5L,3L,2L,9L,8L,8L,3L,5L,7L,0L,5L,0L,4L,5L,2L,7L,8L,1L,3L,7L,1L,2L,8L,0L,7L,2L,4L,4L,5L,0L,1L,9L,4L,0L,4L,9L,1L,5L,9L,1L,2L,0L,3L,1L,0L,4L,7L,8L,6L,5L,4L,5L,9L,2L,4L,9L,6L,7L,6L,5L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021777Inst : IEnumerable<long>
{
public static readonly long[] Value=A021777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021777.Bytes);
public long this[int i]=>Value[i];

public static A021777Inst Instance=new A021777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021778
{
public static readonly long[] Value={ 0L,0L,1L,2L,9L,1L,9L,8L,9L,6L,6L,4L,0L,8L,2L,6L,8L,7L,3L,3L,8L,5L,0L,1L,2L,9L,1L,9L,8L,9L,6L,6L,4L,0L,8L,2L,6L,8L,7L,3L,3L,8L,5L,0L,1L,2L,9L,1L,9L,8L,9L,6L,6L,4L,0L,8L,2L,6L,8L,7L,3L,3L,8L,5L,0L,1L,2L,9L,1L,9L,8L,9L,6L,6L,4L,0L,8L,2L,6L,8L,7L,3L,3L,8L,5L,0L,1L,2L,9L,1L,9L,8L,9L,6L,6L,4L,0L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021778Inst : IEnumerable<long>
{
public static readonly long[] Value=A021778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021778.Bytes);
public long this[int i]=>Value[i];

public static A021778Inst Instance=new A021778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021779
{
public static readonly long[] Value={ 0L,0L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021779Inst : IEnumerable<long>
{
public static readonly long[] Value=A021779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021779.Bytes);
public long this[int i]=>Value[i];

public static A021779Inst Instance=new A021779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021780
{
public static readonly long[] Value={ 0L,0L,1L,2L,8L,8L,6L,5L,9L,7L,9L,3L,8L,1L,4L,4L,3L,2L,9L,8L,9L,6L,9L,0L,7L,2L,1L,6L,4L,9L,4L,8L,4L,5L,3L,6L,0L,8L,2L,4L,7L,4L,2L,2L,6L,8L,0L,4L,1L,2L,3L,7L,1L,1L,3L,4L,0L,2L,0L,6L,1L,8L,5L,5L,6L,7L,0L,1L,0L,3L,0L,9L,2L,7L,8L,3L,5L,0L,5L,1L,5L,4L,6L,3L,9L,1L,7L,5L,2L,5L,7L,7L,3L,1L,9L,5L,8L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021780Inst : IEnumerable<long>
{
public static readonly long[] Value=A021780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021780.Bytes);
public long this[int i]=>Value[i];

public static A021780Inst Instance=new A021780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021781
{
public static readonly long[] Value={ 0L,0L,1L,2L,8L,7L,0L,0L,1L,2L,8L,7L,0L,0L,1L,2L,8L,7L,0L,0L,1L,2L,8L,7L,0L,0L,1L,2L,8L,7L,0L,0L,1L,2L,8L,7L,0L,0L,1L,2L,8L,7L,0L,0L,1L,2L,8L,7L,0L,0L,1L,2L,8L,7L,0L,0L,1L,2L,8L,7L,0L,0L,1L,2L,8L,7L,0L,0L,1L,2L,8L,7L,0L,0L,1L,2L,8L,7L,0L,0L,1L,2L,8L,7L,0L,0L,1L,2L,8L,7L,0L,0L,1L,2L,8L,7L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021781Inst : IEnumerable<long>
{
public static readonly long[] Value=A021781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021781.Bytes);
public long this[int i]=>Value[i];

public static A021781Inst Instance=new A021781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021782
{
public static readonly long[] Value={ 0L,0L,1L,2L,8L,5L,3L,4L,7L,0L,4L,3L,7L,0L,1L,7L,9L,9L,4L,8L,5L,8L,6L,1L,1L,8L,2L,5L,1L,9L,2L,8L,0L,2L,0L,5L,6L,5L,5L,5L,2L,6L,9L,9L,2L,2L,8L,7L,9L,1L,7L,7L,3L,7L,7L,8L,9L,2L,0L,3L,0L,8L,4L,8L,3L,2L,9L,0L,4L,8L,8L,4L,3L,1L,8L,7L,6L,6L,0L,6L,6L,8L,3L,8L,0L,4L,6L,2L,7L,2L,4L,9L,3L,5L,7L,3L,2L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021782Inst : IEnumerable<long>
{
public static readonly long[] Value=A021782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021782.Bytes);
public long this[int i]=>Value[i];

public static A021782Inst Instance=new A021782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021783
{
public static readonly long[] Value={ 0L,0L,1L,2L,8L,3L,6L,9L,7L,0L,4L,7L,4L,9L,6L,7L,9L,0L,7L,5L,7L,3L,8L,1L,2L,5L,8L,0L,2L,3L,1L,0L,6L,5L,4L,6L,8L,5L,4L,9L,4L,2L,2L,3L,3L,6L,3L,2L,8L,6L,2L,6L,4L,4L,4L,1L,5L,9L,1L,7L,8L,4L,3L,3L,8L,8L,9L,6L,0L,2L,0L,5L,3L,9L,1L,5L,2L,7L,5L,9L,9L,4L,8L,6L,5L,2L,1L,1L,8L,1L,0L,0L,1L,2L,8L,3L,6L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021783Inst : IEnumerable<long>
{
public static readonly long[] Value=A021783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021783.Bytes);
public long this[int i]=>Value[i];

public static A021783Inst Instance=new A021783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021784
{
public static readonly long[] Value={ 1L,21L,302L,3762L,43923L,497223L,5545264L,61398804L,677478725L,7463074905L,82149266706L,903924739926L,9944608539607L,109397965416267L,1203414334895828L,13237742692094328L,145616100380861769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021784Inst : IEnumerable<long>
{
public static readonly long[] Value=A021784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021784.Bytes);
public long this[int i]=>Value[i];

public static A021784Inst Instance=new A021784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021785
{
public static readonly long[] Value={ 0L,0L,1L,2L,8L,0L,4L,0L,9L,7L,3L,1L,1L,1L,3L,9L,5L,6L,4L,6L,6L,0L,6L,9L,1L,4L,2L,1L,2L,5L,4L,8L,0L,1L,5L,3L,6L,4L,9L,1L,6L,7L,7L,3L,3L,6L,7L,4L,7L,7L,5L,9L,2L,8L,2L,9L,7L,0L,5L,5L,0L,5L,7L,6L,1L,8L,4L,3L,7L,9L,0L,0L,1L,2L,8L,0L,4L,0L,9L,7L,3L,1L,1L,1L,3L,9L,5L,6L,4L,6L,6L,0L,6L,9L,1L,4L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021785Inst : IEnumerable<long>
{
public static readonly long[] Value=A021785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021785.Bytes);
public long this[int i]=>Value[i];

public static A021785Inst Instance=new A021785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021786
{
public static readonly long[] Value={ 0L,0L,1L,2L,7L,8L,7L,7L,2L,3L,7L,8L,5L,1L,6L,6L,2L,4L,0L,4L,0L,9L,2L,0L,7L,1L,6L,1L,1L,2L,5L,3L,1L,9L,6L,9L,3L,0L,9L,4L,6L,2L,9L,1L,5L,6L,0L,1L,0L,2L,3L,0L,1L,7L,9L,0L,2L,8L,1L,3L,2L,9L,9L,2L,3L,2L,7L,3L,6L,5L,7L,2L,8L,9L,0L,0L,2L,5L,5L,7L,5L,4L,4L,7L,5L,7L,0L,3L,3L,2L,4L,8L,0L,8L,1L,8L,4L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021786Inst : IEnumerable<long>
{
public static readonly long[] Value=A021786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021786.Bytes);
public long this[int i]=>Value[i];

public static A021786Inst Instance=new A021786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021787
{
public static readonly long[] Value={ 0L,0L,1L,2L,7L,7L,1L,3L,9L,2L,0L,8L,1L,7L,3L,6L,9L,0L,9L,3L,2L,3L,1L,1L,6L,2L,1L,9L,6L,6L,7L,9L,4L,3L,8L,0L,5L,8L,7L,4L,8L,4L,0L,3L,5L,7L,5L,9L,8L,9L,7L,8L,2L,8L,8L,6L,3L,3L,4L,6L,1L,0L,4L,7L,2L,5L,4L,1L,5L,0L,7L,0L,2L,4L,2L,6L,5L,6L,4L,4L,9L,5L,5L,3L,0L,0L,1L,2L,7L,7L,1L,3L,9L,2L,0L,8L,1L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021787Inst : IEnumerable<long>
{
public static readonly long[] Value=A021787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021787.Bytes);
public long this[int i]=>Value[i];

public static A021787Inst Instance=new A021787Inst();

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