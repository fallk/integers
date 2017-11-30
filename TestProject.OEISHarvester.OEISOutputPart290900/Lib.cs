using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A286098
{
public static readonly long[] Value={ 0L,1L,1L,3L,4L,3L,6L,6L,6L,6L,10L,11L,12L,11L,10L,15L,15L,17L,17L,15L,15L,21L,22L,21L,24L,21L,22L,21L,28L,28L,28L,28L,28L,28L,28L,28L,36L,37L,38L,37L,40L,37L,38L,37L,36L,45L,45L,47L,47L,49L,49L,47L,47L,45L,45L,55L,56L,55L,58L,59L,60L,59L,58L,55L,56L,55L,66L,66L,66L,66L,70L,70L,70L,70L,66L,66L,66L,66L,78L,79L,80L,79L,78L,83L,84L,83L,78L,79L,80L,79L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286098Inst : IEnumerable<long>
{
public static readonly long[] Value=A286098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286098.Bytes);
public long this[int i]=>Value[i];

public static A286098Inst Instance=new A286098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286099
{
public static readonly long[] Value={ 0L,2L,2L,5L,4L,5L,9L,9L,9L,9L,14L,13L,12L,13L,14L,20L,20L,18L,18L,20L,20L,27L,26L,27L,24L,27L,26L,27L,35L,35L,35L,35L,35L,35L,35L,35L,44L,43L,42L,43L,40L,43L,42L,43L,44L,54L,54L,52L,52L,50L,50L,52L,52L,54L,54L,65L,64L,65L,62L,61L,60L,61L,62L,65L,64L,65L,77L,77L,77L,77L,73L,73L,73L,73L,77L,77L,77L,77L,90L,89L,88L,89L,90L,85L,84L,85L,90L,89L,88L,89L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286099Inst : IEnumerable<long>
{
public static readonly long[] Value=A286099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286099.Bytes);
public long this[int i]=>Value[i];

public static A286099Inst Instance=new A286099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286100
{
public static readonly long[] Value={ 1L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,3L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,4L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,5L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,6L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,7L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,8L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286100Inst : IEnumerable<long>
{
public static readonly long[] Value=A286100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286100.Bytes);
public long this[int i]=>Value[i];

public static A286100Inst Instance=new A286100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286101
{
public static readonly long[] Value={ 1L,2L,2L,4L,5L,4L,7L,16L,16L,7L,11L,12L,13L,12L,11L,16L,46L,67L,67L,46L,16L,22L,23L,106L,25L,106L,23L,22L,29L,92L,31L,191L,191L,31L,92L,29L,37L,38L,211L,80L,41L,80L,211L,38L,37L,46L,154L,277L,379L,436L,436L,379L,277L,154L,46L,56L,57L,58L,59L,596L,61L,596L,59L,58L,57L,56L,67L,232L,436L,631L,781L,862L,862L,781L,631L,436L,232L,67L,79L,80L,529L,212L,991L,302L,85L,302L,991L,212L,529L,80L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286101Inst : IEnumerable<long>
{
public static readonly long[] Value=A286101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286101.Bytes);
public long this[int i]=>Value[i];

public static A286101Inst Instance=new A286101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286102
{
public static readonly long[] Value={ 1L,3L,3L,6L,5L,6L,10L,21L,21L,10L,15L,14L,13L,14L,15L,21L,55L,78L,78L,55L,21L,28L,27L,120L,25L,120L,27L,28L,36L,105L,34L,210L,210L,34L,105L,36L,45L,44L,231L,90L,41L,90L,231L,44L,45L,55L,171L,300L,406L,465L,465L,406L,300L,171L,55L,66L,65L,64L,63L,630L,61L,630L,63L,64L,65L,66L,78L,253L,465L,666L,820L,903L,903L,820L,666L,465L,253L,78L,91L,90L,561L,230L,1035L,324L,85L,324L,1035L,230L,561L,90L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286102Inst : IEnumerable<long>
{
public static readonly long[] Value=A286102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286102.Bytes);
public long this[int i]=>Value[i];

public static A286102Inst Instance=new A286102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286103
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,5L,6L,6L,6L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286103Inst : IEnumerable<long>
{
public static readonly long[] Value=A286103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286103.Bytes);
public long this[int i]=>Value[i];

public static A286103Inst Instance=new A286103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286104
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,3L,2L,3L,3L,5L,6L,6L,7L,7L,5L,6L,7L,7L,6L,10L,11L,11L,13L,13L,14L,13L,14L,14L,15L,15L,17L,17L,19L,17L,14L,19L,15L,19L,17L,19L,19L,21L,22L,22L,23L,23L,26L,26L,26L,29L,29L,26L,30L,31L,29L,30L,31L,29L,30L,30L,31L,31L,33L,33L,34L,33L,34L,34L,35L,35L,37L,37L,38L,37L,38L,38L,39L,39L,41L,41L,39L,41L,41L,42L,43L,43L,41L,46L,46L,47L,38L,46L,47L,47L,53L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286104Inst : IEnumerable<long>
{
public static readonly long[] Value=A286104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286104.Bytes);
public long this[int i]=>Value[i];

public static A286104Inst Instance=new A286104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286105
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,6L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,6L,6L,7L,6L,7L,6L,7L,7L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,7L,8L,8L,7L,7L,7L,7L,7L,8L,7L,8L,8L,8L,7L,8L,8L,7L,8L,8L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286105Inst : IEnumerable<long>
{
public static readonly long[] Value=A286105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286105.Bytes);
public long this[int i]=>Value[i];

public static A286105Inst Instance=new A286105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286106
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,2L,1L,1L,0L,0L,0L,1L,0L,1L,1L,0L,0L,2L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,-1L,-1L,0L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,-1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,-1L,0L,0L,1L,0L,0L,-1L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286106Inst : IEnumerable<long>
{
public static readonly long[] Value=A286106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286106.Bytes);
public long this[int i]=>Value[i];

public static A286106Inst Instance=new A286106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286107
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,5L,5L,6L,5L,5L,6L,7L,7L,10L,10L,7L,7L,13L,10L,10L,11L,13L,13L,14L,13L,13L,14L,14L,15L,14L,15L,19L,17L,14L,19L,15L,19L,17L,19L,19L,21L,21L,22L,23L,23L,26L,26L,23L,29L,29L,26L,23L,23L,26L,26L,26L,29L,29L,30L,30L,31L,33L,33L,31L,33L,33L,34L,34L,35L,34L,35L,38L,37L,38L,38L,38L,39L,38L,41L,39L,41L,41L,42L,42L,43L,41L,46L,46L,47L,38L,46L,46L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286107Inst : IEnumerable<long>
{
public static readonly long[] Value=A286107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286107.Bytes);
public long this[int i]=>Value[i];

public static A286107Inst Instance=new A286107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286108
{
public static readonly long[] Value={ 0L,1L,1L,3L,5L,3L,6L,6L,6L,6L,10L,12L,14L,12L,10L,15L,15L,19L,19L,15L,15L,21L,23L,21L,27L,21L,23L,21L,28L,28L,28L,28L,28L,28L,28L,28L,36L,38L,40L,38L,44L,38L,40L,38L,36L,45L,45L,49L,49L,53L,53L,49L,49L,45L,45L,55L,57L,55L,61L,63L,65L,63L,61L,55L,57L,55L,66L,66L,66L,66L,74L,74L,74L,74L,66L,66L,66L,66L,78L,80L,82L,80L,78L,88L,90L,88L,78L,80L,82L,80L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286108Inst : IEnumerable<long>
{
public static readonly long[] Value=A286108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286108.Bytes);
public long this[int i]=>Value[i];

public static A286108Inst Instance=new A286108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286109
{
public static readonly long[] Value={ 0L,2L,2L,5L,3L,5L,9L,9L,9L,9L,14L,12L,10L,12L,14L,20L,20L,16L,16L,20L,20L,27L,25L,27L,21L,27L,25L,27L,35L,35L,35L,35L,35L,35L,35L,35L,44L,42L,40L,42L,36L,42L,40L,42L,44L,54L,54L,50L,50L,46L,46L,50L,50L,54L,54L,65L,63L,65L,59L,57L,55L,57L,59L,65L,63L,65L,77L,77L,77L,77L,69L,69L,69L,69L,77L,77L,77L,77L,90L,88L,86L,88L,90L,80L,78L,80L,90L,88L,86L,88L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286109Inst : IEnumerable<long>
{
public static readonly long[] Value=A286109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286109.Bytes);
public long this[int i]=>Value[i];

public static A286109Inst Instance=new A286109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286110
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,7L,8L,17L,21L,47L,63L,132L,205L,411L,685L,1353L,2385L,4643L,8496L,16430L,30735L,59343L,112531L,217245L,415628L,803209L,1545463L,2991191L,5778267L,11201883L,21702708L,42141575L,81830748L,159140895L,309590883L,602938098L,1174779397L,2290920127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286110Inst : IEnumerable<long>
{
public static readonly long[] Value=A286110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286110.Bytes);
public long this[int i]=>Value[i];

public static A286110Inst Instance=new A286110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286111
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,5L,6L,10L,11L,21L,29L,58L,78L,144L,224L,421L,648L,1185L,1990L,3668L,6095L,11079L,19098L,34891L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286111Inst : IEnumerable<long>
{
public static readonly long[] Value=A286111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286111.Bytes);
public long this[int i]=>Value[i];

public static A286111Inst Instance=new A286111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286112
{
public static readonly BigInteger[] Value={ 1L,11L,1L,1111L,0L,111111L,11L,11111111L,1001L,1111111111L,0L,111111111111L,10011L,11111111111111L,111L,1111111111111111L,110011L,111111111111111111L,10000111L,11111111111111111111UL,110000011L,BigInteger.Parse("1111111111111111111111"),11100011L,BigInteger.Parse("111111111111111111111111") };
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
public class A286112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286112Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286112.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286112.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286112Inst Instance=new A286112Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286113
{
public static readonly BigInteger[] Value={ 1L,11L,100L,1111L,0L,111111L,1100000L,11111111L,100100000L,1111111111L,0L,111111111111L,1100100000000L,11111111111111L,111000000000000L,1111111111111111L,11001100000000000L,111111111111111111L,1110000100000000000L,11111111111111111111UL,BigInteger.Parse("110000011000000000000") };
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
public class A286113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286113Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286113.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286113.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286113Inst Instance=new A286113Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286114
{
public static readonly long[] Value={ 1L,3L,1L,15L,0L,63L,3L,255L,9L,1023L,0L,4095L,19L,16383L,7L,65535L,51L,262143L,135L,1048575L,387L,4194303L,227L,16777215L,1991L,67108863L,899L,268435455L,8135L,1073741823L,3971L,4294967295L,40903L,17179869183L,3971L,68719476735L,4039L,274877906943L,40835L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286114Inst : IEnumerable<long>
{
public static readonly long[] Value=A286114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286114.Bytes);
public long this[int i]=>Value[i];

public static A286114Inst Instance=new A286114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286115
{
public static readonly long[] Value={ 1L,3L,4L,15L,0L,63L,96L,255L,288L,1023L,0L,4095L,6400L,16383L,28672L,65535L,104448L,262143L,460800L,1048575L,1585152L,4194303L,6520832L,16777215L,29868032L,67108863L,101580800L,268435455L,478085120L,1073741823L,1626865664L,4294967295L,7649492992L,17179869183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286115Inst : IEnumerable<long>
{
public static readonly long[] Value=A286115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286115.Bytes);
public long this[int i]=>Value[i];

public static A286115Inst Instance=new A286115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286116
{
public static readonly BigInteger[] Value={ 1L,10L,0L,1110L,1L,111110L,0L,11111111L,0L,1111111110L,0L,111111111110L,1L,11111111111110L,0L,1111111111110110L,1001L,111111111111110110L,1000L,11111111111111110110UL,1001L,BigInteger.Parse("1111111111111111100110"),10000L,BigInteger.Parse("111111111111111111100110"),11001L };
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
public class A286116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286116Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286116.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286116.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286116Inst Instance=new A286116Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286117
{
public static readonly BigInteger[] Value={ 1L,1L,0L,111L,10000L,11111L,0L,11111111L,0L,111111111L,0L,11111111111L,1000000000000L,1111111111111L,0L,110111111111111L,10010000000000000L,11011111111111111L,1000000000000000L,1101111111111111111L,BigInteger.Parse("100100000000000000000"),BigInteger.Parse("110011111111111111111") };
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
public class A286117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286117Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286117.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286117.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286117Inst Instance=new A286117Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286118
{
public static readonly long[] Value={ 1L,2L,0L,14L,1L,62L,0L,255L,0L,1022L,0L,4094L,1L,16382L,0L,65526L,9L,262134L,8L,1048566L,9L,4194278L,16L,16777190L,25L,67108838L,24L,268435424L,31L,1073741696L,79L,4294967216L,72L,17179869108L,8L,68719476615L,112L,274877906447L,432L,1099511627343L,432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286118Inst : IEnumerable<long>
{
public static readonly long[] Value=A286118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286118.Bytes);
public long this[int i]=>Value[i];

public static A286118Inst Instance=new A286118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286135
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,-1L,0L,-1L,1L,0L,0L,0L,0L,0L,-1L,-1L,0L,1L,-2L,1L,1L,1L,0L,0L,0L,2L,0L,1L,1L,0L,1L,-1L,-1L,-2L,0L,1L,0L,0L,-1L,-1L,-1L,-1L,1L,-1L,-1L,-3L,1L,0L,0L,0L,1L,0L,0L,1L,3L,-2L,0L,1L,-1L,1L,1L,0L,0L,1L,-1L,1L,0L,0L,1L,1L,-1L,0L,0L,1L,3L,5L,-1L,-2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286135Inst : IEnumerable<long>
{
public static readonly long[] Value=A286135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286135.Bytes);
public long this[int i]=>Value[i];

public static A286135Inst Instance=new A286135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286136
{
public static readonly BigInteger[] Value={ 1L,10L,11L,1100L,111L,111010L,1101L,11110010L,11101L,1111101110L,110001L,111111001110L,1111101L,11111110110010L,11001101L,1111111100110010L,111111101L,111111111011000010L,1100111101L,11111111110011110010UL,11111001101L,BigInteger.Parse("1111111111101100110010"),110011111101L };
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
public class A286136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286136Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286136.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286136.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286136Inst Instance=new A286136Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286137
{
public static readonly long[] Value={ 0L,0L,1L,-1L,-2L,1L,0L,2L,1L,0L,0L,-2L,1L,-2L,-2L,0L,2L,-2L,1L,4L,-1L,2L,-2L,0L,0L,0L,0L,-1L,2L,2L,-1L,-4L,-3L,2L,4L,-2L,-2L,-6L,0L,0L,0L,8L,-2L,4L,6L,1L,0L,4L,-3L,-8L,1L,-4L,2L,-2L,0L,-2L,-2L,0L,-4L,-2L,2L,4L,4L,2L,-2L,0L,2L,8L,-6L,0L,2L,-4L,1L,4L,-4L,-1L,-4L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286137Inst : IEnumerable<long>
{
public static readonly long[] Value=A286137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286137.Bytes);
public long this[int i]=>Value[i];

public static A286137Inst Instance=new A286137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286138
{
public static readonly long[] Value={ 1010L,1101L,1121L,1131L,1141L,1151L,1161L,1171L,1181L,1191L,1201L,1211L,1212L,1231L,1241L,1251L,1261L,1271L,1281L,1291L,1301L,1311L,1313L,1321L,1341L,1351L,1361L,1371L,1381L,1391L,1401L,1411L,1414L,1421L,1431L,1451L,1461L,1471L,1481L,1491L,1501L,1511L,1515L,1521L,1531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286138Inst : IEnumerable<long>
{
public static readonly long[] Value=A286138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286138.Bytes);
public long this[int i]=>Value[i];

public static A286138Inst Instance=new A286138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286139
{
public static readonly BigInteger[] Value={ 1L,15L,388L,37196L,14765089L,24076152503L,159850328891568L,4290837646252661680L,BigInteger.Parse("463376724731585422732393"),BigInteger.Parse("200665409586497566263900755703"),BigInteger.Parse("347694350828123116321061347501951972"),BigInteger.Parse("2406781070555276417850396576804205226358828"),BigInteger.Parse("66481859567653621586313146932097075651519991887257") };
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
public class A286139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286139Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286139.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286139.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286139Inst Instance=new A286139Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286140
{
public static readonly long[] Value={ 1L,1L,110L,11L,11100L,10111L,1011000L,1001111L,101110000L,111011111L,10001100000L,11100111111L,1011111000000L,1001101111111L,101100110000000L,100110011111111L,10111111100000000L,10000110111111111L,1011110011000000000L,1001111001111111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286140Inst : IEnumerable<long>
{
public static readonly long[] Value=A286140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286140.Bytes);
public long this[int i]=>Value[i];

public static A286140Inst Instance=new A286140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286141
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,6L,9L,12L,16L,22L,30L,40L,53L,70L,92L,120L,154L,199L,254L,324L,409L,517L,648L,811L,1008L,1253L,1549L,1911L,2347L,2880L,3519L,4294L,5219L,6338L,7671L,9273L,11173L,13451L,16147L,19359L,23151L,27656L,32958L,39231L,46594L,55276L,65444L,77391L,91341L,107689L,126734L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286141Inst : IEnumerable<long>
{
public static readonly long[] Value=A286141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286141.Bytes);
public long this[int i]=>Value[i];

public static A286141Inst Instance=new A286141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286142
{
public static readonly long[] Value={ 1L,5L,2L,12L,2L,31L,2L,38L,7L,23L,2L,94L,2L,23L,16L,138L,2L,94L,2L,80L,16L,23L,2L,328L,7L,23L,29L,80L,2L,532L,2L,530L,16L,23L,16L,706L,2L,23L,16L,302L,2L,499L,2L,80L,67L,23L,2L,1228L,7L,80L,16L,80L,2L,328L,16L,302L,16L,23L,2L,1957L,2L,23L,67L,2082L,16L,499L,2L,80L,16L,467L,2L,2704L,2L,23L,67L,80L,16L,499L,2L,1178L,121L,23L,2L,1894L,16L,23L,16L,302L,2L,1957L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286142Inst : IEnumerable<long>
{
public static readonly long[] Value=A286142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286142.Bytes);
public long this[int i]=>Value[i];

public static A286142Inst Instance=new A286142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286143
{
public static readonly long[] Value={ 1L,5L,2L,12L,2L,31L,2L,38L,7L,23L,2L,94L,2L,23L,16L,138L,2L,94L,2L,80L,16L,23L,2L,355L,7L,23L,29L,80L,2L,499L,2L,530L,16L,23L,16L,706L,2L,23L,16L,302L,2L,499L,2L,80L,67L,23L,2L,1279L,7L,80L,16L,80L,2L,328L,16L,302L,16L,23L,2L,1894L,2L,23L,67L,2082L,16L,499L,2L,80L,16L,467L,2L,2779L,2L,23L,67L,80L,16L,499L,2L,1178L,121L,23L,2L,1894L,16L,23L,16L,302L,2L,1894L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286143Inst : IEnumerable<long>
{
public static readonly long[] Value=A286143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286143.Bytes);
public long this[int i]=>Value[i];

public static A286143Inst Instance=new A286143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286144
{
public static readonly long[] Value={ 1L,2L,3L,5L,10L,8L,21L,14L,21L,14L,55L,19L,78L,27L,36L,44L,136L,34L,171L,44L,78L,65L,253L,53L,210L,90L,171L,90L,406L,63L,465L,152L,210L,152L,300L,103L,666L,189L,300L,152L,820L,103L,903L,230L,300L,275L,1081L,169L,903L,230L,528L,324L,1378L,208L,820L,324L,666L,434L,1711L,187L,1830L,495L,666L,560L,1176L,251L,2211L,560L,990L,324L,2485L,349L,2628L,702L,820L,702L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286144Inst : IEnumerable<long>
{
public static readonly long[] Value=A286144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286144.Bytes);
public long this[int i]=>Value[i];

public static A286144Inst Instance=new A286144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286145
{
public static readonly long[] Value={ 0L,4L,2L,12L,1L,5L,24L,18L,13L,9L,40L,17L,3L,8L,14L,60L,50L,11L,7L,26L,20L,84L,49L,61L,6L,42L,19L,27L,112L,98L,85L,73L,62L,52L,43L,35L,144L,97L,59L,72L,10L,51L,25L,34L,44L,180L,162L,83L,71L,22L,16L,41L,33L,64L,54L,220L,161L,181L,70L,38L,15L,23L,32L,88L,53L,65L,264L,242L,221L,201L,58L,48L,39L,31L,116L,102L,89L,77L,312L,241L,179L,200L,222L,47L,21L,30L,148L,101L,63L,76L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286145Inst : IEnumerable<long>
{
public static readonly long[] Value=A286145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286145.Bytes);
public long this[int i]=>Value[i];

public static A286145Inst Instance=new A286145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286146
{
public static readonly long[] Value={ 1L,2L,5L,4L,16L,13L,7L,12L,67L,25L,11L,46L,106L,191L,41L,16L,23L,31L,80L,436L,61L,22L,92L,211L,379L,596L,862L,85L,29L,38L,277L,59L,781L,302L,1541L,113L,37L,154L,58L,631L,991L,193L,1954L,2557L,145L,46L,57L,436L,212L,96L,467L,2416L,822L,4006L,181L,56L,232L,529L,947L,1486L,2146L,2927L,3829L,4852L,5996L,221L,67L,80L,94L,109L,1771L,142L,3487L,355L,706L,1832L,8647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286146Inst : IEnumerable<long>
{
public static readonly long[] Value=A286146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286146.Bytes);
public long this[int i]=>Value[i];

public static A286146Inst Instance=new A286146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286147
{
public static readonly long[] Value={ 0L,2L,4L,5L,1L,12L,9L,13L,18L,24L,14L,8L,3L,17L,40L,20L,26L,7L,11L,50L,60L,27L,19L,42L,6L,61L,49L,84L,35L,43L,52L,62L,73L,85L,98L,112L,44L,34L,25L,51L,10L,72L,59L,97L,144L,54L,64L,33L,41L,16L,22L,71L,83L,162L,180L,65L,53L,88L,32L,23L,15L,38L,70L,181L,161L,220L,77L,89L,102L,116L,31L,39L,48L,58L,201L,221L,242L,264L,90L,76L,63L,101L,148L,30L,21L,47L,222L,200L,179L,241L,312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286147Inst : IEnumerable<long>
{
public static readonly long[] Value=A286147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286147.Bytes);
public long this[int i]=>Value[i];

public static A286147Inst Instance=new A286147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286148
{
public static readonly long[] Value={ 1L,5L,2L,13L,16L,4L,25L,67L,12L,7L,41L,191L,106L,46L,11L,61L,436L,80L,31L,23L,16L,85L,862L,596L,379L,211L,92L,22L,113L,1541L,302L,781L,59L,277L,38L,29L,145L,2557L,1954L,193L,991L,631L,58L,154L,37L,181L,4006L,822L,2416L,467L,96L,212L,436L,57L,46L,221L,5996L,4852L,3829L,2927L,2146L,1486L,947L,529L,232L,56L,265L,8647L,1832L,706L,355L,3487L,142L,1771L,109L,94L,80L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286148Inst : IEnumerable<long>
{
public static readonly long[] Value=A286148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286148.Bytes);
public long this[int i]=>Value[i];

public static A286148Inst Instance=new A286148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286149
{
public static readonly long[] Value={ 1L,5L,8L,14L,17L,34L,30L,44L,19L,51L,68L,103L,93L,72L,196L,152L,155L,103L,192L,132L,72L,126L,278L,349L,32L,159L,53L,165L,437L,976L,498L,560L,709L,237L,786L,739L,705L,282L,159L,402L,863L,660L,948L,243L,337L,384L,1130L,1273L,49L,132L,1546L,288L,1433L,349L,126L,459L,282L,567L,1772L,2761L,1893L,636L,165L,2144L,2421L,1921L,2280L,390L,2707L,2046L,2558L,2773L,2703L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286149Inst : IEnumerable<long>
{
public static readonly long[] Value=A286149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286149.Bytes);
public long this[int i]=>Value[i];

public static A286149Inst Instance=new A286149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286150
{
public static readonly long[] Value={ 0L,2L,2L,5L,1L,5L,9L,13L,13L,9L,14L,8L,3L,8L,14L,20L,26L,7L,7L,26L,20L,27L,19L,42L,6L,42L,19L,27L,35L,43L,52L,62L,62L,52L,43L,35L,44L,34L,25L,51L,10L,51L,25L,34L,44L,54L,64L,33L,41L,16L,16L,41L,33L,64L,54L,65L,53L,88L,32L,23L,15L,23L,32L,88L,53L,65L,77L,89L,102L,116L,31L,39L,39L,31L,116L,102L,89L,77L,90L,76L,63L,101L,148L,30L,21L,30L,148L,101L,63L,76L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286150Inst : IEnumerable<long>
{
public static readonly long[] Value=A286150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286150.Bytes);
public long this[int i]=>Value[i];

public static A286150Inst Instance=new A286150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286183
{
public static readonly long[] Value={ 3L,15L,60L,207L,663L,2038L,6107L,17983L,52272L,150407L,429223L,1216490L,3427635L,9609327L,26821668L,74576703L,206650167L,570877918L,1572754187L,4322192287L,11851474968L,32430381815L,88576465735L,241511251922L,657457204323L,1787147867343L,4851349002252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286183Inst : IEnumerable<long>
{
public static readonly long[] Value=A286183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286183.Bytes);
public long this[int i]=>Value[i];

public static A286183Inst Instance=new A286183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286184
{
public static readonly long[] Value={ 6L,19L,56L,157L,430L,1171L,3204L,8857L,24794L,70303L,201712L,584677L,1708998L,5028715L,14873180L,44160817L,131499442L,392401207L,1172747208L,3508804477L,10506490526L,31477528579L,94344505396L,282848966857L,848161024650L,2543677767631L,7629355581344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286184Inst : IEnumerable<long>
{
public static readonly long[] Value=A286184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286184.Bytes);
public long this[int i]=>Value[i];

public static A286184Inst Instance=new A286184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286185
{
public static readonly long[] Value={ 3L,15L,55L,173L,511L,1451L,4019L,10937L,29371L,78055L,205679L,538149L,1399607L,3621315L,9327723L,23931633L,61186163L,155949119L,396369831L,1004904733L,2541896559L,6416348251L,16165611043L,40657256617L,102090514731L,255968753175L,640899345631L,1602640560533L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286185Inst : IEnumerable<long>
{
public static readonly long[] Value=A286185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286185.Bytes);
public long this[int i]=>Value[i];

public static A286185Inst Instance=new A286185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286186
{
public static readonly long[] Value={ 7L,22L,73L,268L,1039L,4114L,16405L,65560L,262171L,1048606L,4194337L,16777252L,67108903L,268435498L,1073741869L,4294967344L,17179869235L,68719476790L,274877907001L,1099511627836L,4398046511167L,17592186044482L,70368744177733L,281474976710728L,1125899906842699L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286186Inst : IEnumerable<long>
{
public static readonly long[] Value=A286186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286186.Bytes);
public long this[int i]=>Value[i];

public static A286186Inst Instance=new A286186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286187
{
public static readonly long[] Value={ 6L,33L,188L,985L,4990L,24645L,119712L,574225L,2727218L,12847821L,60115060L,279652793L,1294441894L,5965567125L,27387631368L,125308264225L,571591760602L,2600204421405L,11799376912220L,53424388364873L,241398575303374L,1088727972172389L,4901842528232304L,22034981672761649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286187Inst : IEnumerable<long>
{
public static readonly long[] Value=A286187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286187.Bytes);
public long this[int i]=>Value[i];

public static A286187Inst Instance=new A286187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286188
{
public static readonly long[] Value={ 6L,26L,76L,218L,664L,2174L,7452L,26130L,92512L,328774L,1170052L,4166106L,14836488L,52839374L,188188396L,670240802L,2387095600L,8501764310L,30279479508L,107841961962L,384084839128L,1367938434910L,4871984975932L,17351831789874L,61799465313024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286188Inst : IEnumerable<long>
{
public static readonly long[] Value=A286188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286188.Bytes);
public long this[int i]=>Value[i];

public static A286188Inst Instance=new A286188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286189
{
public static readonly BigInteger[] Value={ 1L,13L,397L,55933L,31450861L,67253507293L,559182556492477L,18408476382988290493UL,BigInteger.Parse("2416307646576708948065581"),BigInteger.Parse("1267404418454077249779938768413"),BigInteger.Parse("2658301080374793666228695738368407037"),BigInteger.Parse("22300360304310794054520197736231374212892413") };
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
public class A286189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286189Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286189.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286189.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286189Inst Instance=new A286189Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286190
{
public static readonly long[] Value={ 3L,13L,13L,491L,1516L,12721L,12721L,109453L,1473257L,120797465L,624141002L,4044619541L,136797949237L,315400191511L,1285600699441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286190Inst : IEnumerable<long>
{
public static readonly long[] Value=A286190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286190.Bytes);
public long this[int i]=>Value[i];

public static A286190Inst Instance=new A286190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286191
{
public static readonly long[] Value={ 3L,13L,55L,233L,971L,3981L,16143L,65041L,261139L,1046549L,4190231L,16769049L,67092507L,268402717L,1073676319L,4294836257L,17179607075L,68718952485L,274876858407L,1099509530665L,4398042316843L,17592177655853L,70368727400495L,281474943156273L,1125899839733811L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286191Inst : IEnumerable<long>
{
public static readonly long[] Value=A286191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286191.Bytes);
public long this[int i]=>Value[i];

public static A286191Inst Instance=new A286191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286192
{
public static readonly long[] Value={ 27L,93L,99L,107L,111L,119L,123L,167L,183L,189L,215L,219L,223L,229L,231L,235L,237L,239L,247L,251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286192Inst : IEnumerable<long>
{
public static readonly long[] Value=A286192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286192.Bytes);
public long this[int i]=>Value[i];

public static A286192Inst Instance=new A286192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286193
{
public static readonly long[] Value={ 7L,0L,4L,1L,8L,8L,3L,4L,9L,9L,2L,3L,3L,1L,4L,7L,1L,8L,1L,7L,1L,2L,6L,2L,0L,0L,0L,4L,4L,2L,2L,1L,8L,5L,7L,8L,0L,3L,0L,4L,1L,5L,8L,5L,3L,7L,7L,2L,9L,0L,9L,4L,4L,5L,0L,7L,4L,2L,2L,2L,3L,4L,0L,3L,8L,6L,1L,3L,9L,0L,6L,9L,3L,8L,2L,4L,0L,7L,7L,6L,1L,5L,5L,9L,0L,4L,5L,6L,8L,5L,6L,2L,3L,5L,3L,0L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286193Inst : IEnumerable<long>
{
public static readonly long[] Value=A286193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286193.Bytes);
public long this[int i]=>Value[i];

public static A286193Inst Instance=new A286193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286194
{
public static readonly long[] Value={ 0L,2L,11L,60L,302L,1522L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286194Inst : IEnumerable<long>
{
public static readonly long[] Value=A286194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286194.Bytes);
public long this[int i]=>Value[i];

public static A286194Inst Instance=new A286194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286195
{
public static readonly long[] Value={ 16L,24L,36L,48L,72L,108L,120L,144L,168L,180L,216L,240L,252L,288L,324L,360L,408L,432L,504L,540L,552L,600L,612L,648L,720L,756L,768L,792L,828L,864L,900L,912L,960L,1080L,1128L,1152L,1188L,1224L,1248L,1260L,1296L,1368L,1392L,1440L,1620L,1656L,1680L,1692L,1728L,1764L,1800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286195Inst : IEnumerable<long>
{
public static readonly long[] Value=A286195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286195.Bytes);
public long this[int i]=>Value[i];

public static A286195Inst Instance=new A286195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286196
{
public static readonly BigInteger[] Value={ 1L,10L,0L,1100L,1L,111000L,0L,11110000L,111L,1111100000L,1L,111111000000L,11000L,11111110000000L,11L,1111111100001000L,1100001L,111111111000000000L,1000L,11111111110000100000UL,110000000L,BigInteger.Parse("1111111111100000000000"),110000L,BigInteger.Parse("111111111111000010000000"),11000000000L };
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
public class A286196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286196Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286196.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286196.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286196Inst Instance=new A286196Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286197
{
public static readonly long[] Value={ 1L,1L,0L,11L,10000L,111L,0L,1111L,111000000L,11111L,10000000000L,111111L,1100000000L,1111111L,110000000000000L,1000011111111L,10000110000000000L,111111111L,1000000000000000L,100001111111111L,11000000000000L,11111111111L,1100000000000000000L,10000111111111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286197Inst : IEnumerable<long>
{
public static readonly long[] Value=A286197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286197.Bytes);
public long this[int i]=>Value[i];

public static A286197Inst Instance=new A286197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286198
{
public static readonly long[] Value={ 1L,2L,0L,12L,1L,56L,0L,240L,7L,992L,1L,4032L,24L,16256L,3L,65288L,97L,261632L,8L,1047584L,384L,4192256L,48L,16773248L,1536L,67100696L,192L,268419584L,6168L,1073709120L,768L,4294903832L,24640L,17179738368L,3096L,68719222848L,98560L,274877383704L,12288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286198Inst : IEnumerable<long>
{
public static readonly long[] Value=A286198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286198.Bytes);
public long this[int i]=>Value[i];

public static A286198Inst Instance=new A286198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286631
{
public static readonly long[] Value={ 1L,2L,2L,4L,6L,2L,8L,12L,4L,6L,16L,6L,24L,12L,2L,12L,32L,8L,30L,48L,12L,36L,6L,4L,24L,64L,6L,24L,60L,16L,96L,60L,6L,72L,12L,24L,12L,48L,12L,128L,30L,2L,72L,120L,12L,48L,192L,32L,180L,30L,8L,144L,24L,30L,120L,36L,48L,96L,60L,12L,256L,60L,36L,6L,216L,6L,240L,60L,4L,144L,384L,24L,96L,360L,64L,60L,24L,6L,288L,48L,24L,210L,360L,60L,72L,240L,16L,192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286631Inst : IEnumerable<long>
{
public static readonly long[] Value=A286631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286631.Bytes);
public long this[int i]=>Value[i];

public static A286631Inst Instance=new A286631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286632
{
public static readonly long[] Value={ 0L,1L,2L,1L,3L,2L,4L,2L,4L,1L,3L,3L,5L,3L,5L,2L,5L,4L,6L,3L,4L,2L,4L,2L,6L,2L,4L,3L,6L,1L,3L,4L,6L,3L,5L,4L,7L,4L,6L,4L,5L,5L,7L,2L,5L,3L,5L,3L,7L,5L,7L,3L,5L,4L,6L,3L,7L,6L,8L,4L,4L,3L,5L,5L,7L,6L,8L,4L,6L,3L,5L,6L,8L,3L,5L,5L,7L,5L,7L,3L,6L,4L,6L,5L,8L,1L,3L,5L,6L,2L,4L,4L,6L,2L,4L,2L,8L,4L,6L,6L,8L,2L,4L,2L,6L,3L,5L,4L,7L,4L,6L,5L,8L,5L,7L,5L,9L,5L,7L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286632Inst : IEnumerable<long>
{
public static readonly long[] Value=A286632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286632.Bytes);
public long this[int i]=>Value[i];

public static A286632Inst Instance=new A286632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286633
{
public static readonly long[] Value={ 1L,2L,3L,2L,6L,4L,9L,3L,12L,2L,6L,6L,18L,8L,18L,4L,24L,12L,27L,6L,12L,3L,9L,4L,36L,4L,12L,6L,36L,2L,6L,12L,48L,6L,18L,12L,54L,16L,36L,9L,24L,24L,54L,4L,18L,8L,18L,6L,72L,24L,54L,6L,24L,12L,27L,6L,72L,36L,81L,12L,12L,6L,18L,18L,96L,36L,81L,12L,36L,6L,18L,36L,108L,8L,24L,18L,72L,24L,54L,8L,48L,12L,36L,18L,108L,2L,6L,24L,36L,4L,12L,12L,36L,3L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286633Inst : IEnumerable<long>
{
public static readonly long[] Value=A286633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286633.Bytes);
public long this[int i]=>Value[i];

public static A286633Inst Instance=new A286633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286634
{
public static readonly long[] Value={ 2L,2L,1L,1L,1L,1L,3L,1L,1L,2L,1L,1L,3L,3L,1L,1L,2L,1L,3L,2L,1L,2L,2L,1L,1L,1L,1L,7L,1L,3L,1L,5L,1L,3L,3L,2L,1L,3L,1L,5L,1L,2L,1L,3L,6L,1L,1L,1L,3L,1L,5L,3L,3L,1L,1L,1L,2L,1L,5L,7L,2L,1L,1L,7L,3L,5L,1L,2L,3L,2L,1L,3L,2L,1L,2L,2L,1L,5L,1L,1L,1L,3L,2L,1L,2L,2L,1L,1L,6L,2L,1L,1L,1L,3L,3L,1L,3L,3L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286634Inst : IEnumerable<long>
{
public static readonly long[] Value=A286634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286634.Bytes);
public long this[int i]=>Value[i];

public static A286634Inst Instance=new A286634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286635
{
public static readonly long[] Value={ 21361L,8L,4L,134L,6L,4L,57L,6L,34L,65L,14L,9L,14L,6L,4L,21L,12L,4L,26L,8L,26L,779L,102L,99L,33L,8L,4L,14L,12L,4L,9L,6L,70L,33L,169L,25L,98L,8L,4L,14L,410L,4L,458L,6L,10L,25L,6L,26L,14L,8L,4L,122L,6L,4L,231L,8L,836L,62L,18L,74L,39L,8L,4L,1101L,14L,4L,81L,8L,68L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286635Inst : IEnumerable<long>
{
public static readonly long[] Value=A286635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286635.Bytes);
public long this[int i]=>Value[i];

public static A286635Inst Instance=new A286635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286636
{
public static readonly long[] Value={ 2L,6L,10L,14L,18L,26L,30L,38L,42L,46L,50L,54L,62L,66L,74L,82L,86L,90L,98L,102L,110L,114L,118L,122L,126L,138L,146L,150L,154L,158L,170L,174L,182L,186L,194L,198L,206L,222L,226L,230L,234L,242L,246L,258L,262L,266L,270L,278L,282L,290L,294L,306L,314L,318L,326L,334L,338L,350L,354L,362L,366L,370L,374L,378L,390L,398L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286636Inst : IEnumerable<long>
{
public static readonly long[] Value=A286636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286636.Bytes);
public long this[int i]=>Value[i];

public static A286636Inst Instance=new A286636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286637
{
public static readonly long[] Value={ 3L,37L,47L,73L,107L,121L,181L,191L,239L,249L,253L,299L,337L,359L,429L,431L,433L,503L,529L,537L,541L,579L,587L,649L,659L,661L,671L,759L,767L,781L,789L,793L,851L,863L,933L,937L,971L,1067L,1069L,1079L,1081L,1093L,1191L,1199L,1237L,1249L,1257L,1261L,1307L,1319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286637Inst : IEnumerable<long>
{
public static readonly long[] Value=A286637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286637.Bytes);
public long this[int i]=>Value[i];

public static A286637Inst Instance=new A286637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286638
{
public static readonly BigInteger[] Value={ 1L,10L,1L,1100L,11L,111100L,11L,11110000L,1111L,1111110000L,1111L,111111110000L,1111L,11111111110000L,1111L,1111111100000000L,11111111L,111111111100000000L,11100001L,11111111111100011100UL,10000001L,BigInteger.Parse("1111111111111101100100"),10000001L,BigInteger.Parse("111111111111111000100100") };
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
public class A286638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286638Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286638.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286638.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286638Inst Instance=new A286638Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286639
{
public static readonly BigInteger[] Value={ 1L,1L,100L,11L,11000L,1111L,1100000L,1111L,111100000L,111111L,11110000000L,11111111L,1111000000000L,1111111111L,111100000000000L,11111111L,11111111000000000L,1111111111L,1000011100000000000L,111000111111111111L,BigInteger.Parse("100000010000000000000"),10011011111111111111UL };
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
public class A286639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286639Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286639.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286639.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286639Inst Instance=new A286639Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286640
{
public static readonly long[] Value={ 1L,2L,1L,12L,3L,60L,3L,240L,15L,1008L,15L,4080L,15L,16368L,15L,65280L,255L,261888L,225L,1048348L,129L,4194148L,129L,16776740L,475L,67108388L,1L,268435452L,3L,1073737856L,3940L,4294901897L,65124L,17179803801L,63588L,68719412105L,63588L,274877842313L,64612L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286640Inst : IEnumerable<long>
{
public static readonly long[] Value=A286640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286640.Bytes);
public long this[int i]=>Value[i];

public static A286640Inst Instance=new A286640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286641
{
public static readonly long[] Value={ 1L,1L,4L,3L,24L,15L,96L,15L,480L,63L,1920L,255L,7680L,1023L,30720L,255L,130560L,1023L,276480L,233471L,1056768L,638975L,4227072L,2392063L,28770304L,9568255L,67108864L,67108863L,402653184L,4456447L,326631424L,2432761855L,1291714560L,10267918335L,5116526592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286641Inst : IEnumerable<long>
{
public static readonly long[] Value=A286641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286641.Bytes);
public long this[int i]=>Value[i];

public static A286641Inst Instance=new A286641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286642
{
public static readonly BigInteger[] Value={ 1L,11L,1L,1111L,11L,111111L,11L,11111111L,1111L,1111111111L,1111L,111111111111L,1111L,11111111111111L,1111L,1111111111111111L,11111111L,111111111111111111L,11100001L,11111111111111111111UL,10000001L,BigInteger.Parse("1111111111111111111111"),10000001L,BigInteger.Parse("111111111111111111111111") };
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
public class A286642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286642Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286642.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286642.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286642Inst Instance=new A286642Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286643
{
public static readonly ulong[] Value={ 1L,11L,100L,1111L,11000L,111111L,1100000L,11111111L,111100000L,1111111111L,11110000000L,111111111111L,1111000000000L,11111111111111L,111100000000000L,1111111111111111L,11111111000000000L,111111111111111111L,1000011100000000000L,11111111111111111111UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286643Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A286643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286643.Bytes);
public ulong this[int i]=>Value[i];

public static A286643Inst Instance=new A286643Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286644
{
public static readonly long[] Value={ 1L,3L,1L,15L,3L,63L,3L,255L,15L,1023L,15L,4095L,15L,16383L,15L,65535L,255L,262143L,225L,1048575L,129L,4194303L,129L,16777215L,451L,67108863L,451L,268435455L,463L,1073741823L,2511L,4294967295L,63939L,17179869183L,63603L,68719476735L,52851L,274877906943L,51219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286644Inst : IEnumerable<long>
{
public static readonly long[] Value=A286644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286644.Bytes);
public long this[int i]=>Value[i];

public static A286644Inst Instance=new A286644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286645
{
public static readonly long[] Value={ 1L,3L,4L,15L,24L,63L,96L,255L,480L,1023L,1920L,4095L,7680L,16383L,30720L,65535L,130560L,262143L,276480L,1048575L,1056768L,4194303L,4227072L,16777215L,25624576L,67108863L,102498304L,268435455L,510656512L,1073741823L,2043150336L,4294967295L,6563954688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286645Inst : IEnumerable<long>
{
public static readonly long[] Value=A286645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286645.Bytes);
public long this[int i]=>Value[i];

public static A286645Inst Instance=new A286645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286646
{
public static readonly BigInteger[] Value={ 1L,10L,0L,1100L,1L,111000L,11L,11110000L,100L,1111100001L,0L,111111001001L,10100L,11111110000001L,0L,1111111100111111L,1000000L,111111111000010011L,1000L,11111111110011000011UL,100011000L,BigInteger.Parse("1111111111100001000000"),11001L,BigInteger.Parse("111111111111001111100000"),10000000001L };
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
public class A286646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286646Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286646.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286646.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286646Inst Instance=new A286646Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286663
{
public static readonly long[] Value={ 0L,2L,0L,4L,0L,4L,6L,37L,17L,21L,75L,27L,3L,20L,96L,21L,13L,90L,37L,26L,22L,20L,204L,12L,148L,23L,46L,24L,0L,71L,22L,3L,36L,41L,4L,101L,228L,31L,155L,304L,309L,392L,146L,85L,222L,346L,134L,277L,43L,7L,67L,484L,230L,152L,10L,135L,40L,256L,28L,97L,129L,90L,458L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286663Inst : IEnumerable<long>
{
public static readonly long[] Value=A286663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286663.Bytes);
public long this[int i]=>Value[i];

public static A286663Inst Instance=new A286663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286664
{
public static readonly long[] Value={ 2L,5L,2L,2L,2L,20663L,2L,229L,2L,2L,2L,11L,2L,5L,2L,2L,2L,23L,2L,3L,2L,2L,2L,101L,2L,3L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286664Inst : IEnumerable<long>
{
public static readonly long[] Value=A286664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286664.Bytes);
public long this[int i]=>Value[i];

public static A286664Inst Instance=new A286664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286665
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286665Inst : IEnumerable<long>
{
public static readonly long[] Value=A286665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286665.Bytes);
public long this[int i]=>Value[i];

public static A286665Inst Instance=new A286665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286666
{
public static readonly long[] Value={ 1L,3L,6L,8L,11L,13L,15L,18L,20L,23L,25L,27L,30L,32L,35L,37L,40L,42L,44L,47L,49L,52L,54L,56L,59L,61L,64L,66L,69L,71L,73L,76L,78L,81L,83L,85L,88L,90L,93L,95L,97L,100L,102L,105L,107L,110L,112L,114L,117L,119L,122L,124L,126L,129L,131L,134L,136L,139L,141L,143L,146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286666Inst : IEnumerable<long>
{
public static readonly long[] Value=A286666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286666.Bytes);
public long this[int i]=>Value[i];

public static A286666Inst Instance=new A286666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286667
{
public static readonly long[] Value={ 2L,4L,5L,7L,9L,10L,12L,14L,16L,17L,19L,21L,22L,24L,26L,28L,29L,31L,33L,34L,36L,38L,39L,41L,43L,45L,46L,48L,50L,51L,53L,55L,57L,58L,60L,62L,63L,65L,67L,68L,70L,72L,74L,75L,77L,79L,80L,82L,84L,86L,87L,89L,91L,92L,94L,96L,98L,99L,101L,103L,104L,106L,108L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286667Inst : IEnumerable<long>
{
public static readonly long[] Value=A286667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286667.Bytes);
public long this[int i]=>Value[i];

public static A286667Inst Instance=new A286667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286668
{
public static readonly BigInteger[] Value={ 1L,10L,1L,1100L,11L,111000L,0L,11111111L,0L,1111100001L,0L,111111110000L,1001L,11111111100100L,11L,1111111111111000L,0L,111111111000100011L,1011000L,11111111111110000111UL,1100000L,BigInteger.Parse("1111111111110010000011"),0L,BigInteger.Parse("111111111111111111000011"),0L };
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
public class A286668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286668Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286668.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286668.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286668Inst Instance=new A286668Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286669
{
public static readonly BigInteger[] Value={ 1L,1L,100L,11L,11000L,111L,0L,11111111L,0L,1000011111L,0L,11111111L,1001000000000L,100111111111L,110000000000000L,1111111111111L,0L,110001000111111111L,1101000000000000L,11100001111111111111UL,1100000000000000L,BigInteger.Parse("1100000100111111111111"),0L };
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
public class A286669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286669Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286669.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286669.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286669Inst Instance=new A286669Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286670
{
public static readonly long[] Value={ 1L,2L,1L,12L,3L,56L,0L,255L,0L,993L,0L,4080L,9L,16356L,3L,65528L,0L,261667L,88L,1048455L,96L,4193411L,0L,16777155L,0L,67107843L,28L,268431361L,1542L,1073725697L,7688L,4294951169L,48L,17179740099L,30728L,68719445888L,115L,274877808512L,60L,1099511167041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286670Inst : IEnumerable<long>
{
public static readonly long[] Value=A286670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286670.Bytes);
public long this[int i]=>Value[i];

public static A286670Inst Instance=new A286670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286671
{
public static readonly long[] Value={ 1L,1L,4L,3L,24L,7L,0L,255L,0L,543L,0L,255L,4608L,2559L,24576L,8191L,0L,201215L,53248L,925695L,49152L,3166207L,0L,12845055L,0L,50397183L,29360128L,134283263L,202113024L,539033599L,138149888L,2156134399L,402653184L,13145079807L,2163212288L,505413631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286671Inst : IEnumerable<long>
{
public static readonly long[] Value=A286671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286671.Bytes);
public long this[int i]=>Value[i];

public static A286671Inst Instance=new A286671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286672
{
public static readonly BigInteger[] Value={ 1L,11L,1L,1111L,11L,111111L,11L,11111111L,1001L,1111111111L,1001L,111111111111L,1111L,11111111111111L,1111L,1111111111111111L,11111111L,111111111111111111L,10011001L,11111111111111111111UL,10010011L,BigInteger.Parse("1111111111111111111111"),11001001L,BigInteger.Parse("111111111111111111111111") };
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
public class A286672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286672Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286672.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286672.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286672Inst Instance=new A286672Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286673
{
public static readonly ulong[] Value={ 1L,11L,100L,1111L,11000L,111111L,1100000L,11111111L,100100000L,1111111111L,10010000000L,111111111111L,1111000000000L,11111111111111L,111100000000000L,1111111111111111L,11111111000000000L,111111111111111111L,1001100100000000000L,11111111111111111111UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286673Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A286673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286673.Bytes);
public ulong this[int i]=>Value[i];

public static A286673Inst Instance=new A286673Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286674
{
public static readonly long[] Value={ 1L,3L,1L,15L,3L,63L,3L,255L,9L,1023L,9L,4095L,15L,16383L,15L,65535L,255L,262143L,153L,1048575L,147L,4194303L,201L,16777215L,9L,67108863L,227L,268435455L,227L,1073741823L,227L,4294967295L,65535L,17179869183L,65535L,68719476735L,61951L,274877906943L,58623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286674Inst : IEnumerable<long>
{
public static readonly long[] Value=A286674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286674.Bytes);
public long this[int i]=>Value[i];

public static A286674Inst Instance=new A286674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286675
{
public static readonly long[] Value={ 1L,3L,4L,15L,24L,63L,96L,255L,288L,1023L,1152L,4095L,7680L,16383L,30720L,65535L,130560L,262143L,313344L,1048575L,1646592L,4194303L,4816896L,16777215L,18874368L,67108863L,104333312L,268435455L,417333248L,1073741823L,1669332992L,4294967295L,8589803520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286675Inst : IEnumerable<long>
{
public static readonly long[] Value=A286675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286675.Bytes);
public long this[int i]=>Value[i];

public static A286675Inst Instance=new A286675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286676
{
public static readonly long[] Value={ 1L,3L,9L,2L,20L,12L,23L,27L,31L,35L,187L,1461L,485L,105L,64L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286676Inst : IEnumerable<long>
{
public static readonly long[] Value=A286676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286676.Bytes);
public long this[int i]=>Value[i];

public static A286676Inst Instance=new A286676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286677
{
public static readonly long[] Value={ 1L,2L,5L,1L,9L,5L,9L,10L,11L,12L,62L,470L,152L,32L,19L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286677Inst : IEnumerable<long>
{
public static readonly long[] Value=A286677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286677.Bytes);
public long this[int i]=>Value[i];

public static A286677Inst Instance=new A286677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286678
{
public static readonly BigInteger[] Value={ 5L,17L,257L,65537L,BigInteger.Parse("795866110996400884391941"),BigInteger.Parse("3402823669209384634633746074317682114560000000000000000000000000000000000000000000000000000000000000039") };
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
public class A286678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286678Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286678.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286678.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286678Inst Instance=new A286678Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286695
{
public static readonly BigInteger[] Value={ 1L,1L,0L,11L,10000L,111L,1000000L,1111L,100000000L,10011111L,11000000000L,1100111111L,1000000000000L,1111111L,111110000000000L,10011111111L,11100000000000000L,100000111111111L,1110000000000000000L,10000001111111111L,BigInteger.Parse("111000000000000000000"),110011111111111L };
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
public class A286695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286695Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286695.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286695.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286695Inst Instance=new A286695Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286696
{
public static readonly long[] Value={ 1L,2L,0L,12L,1L,56L,1L,240L,1L,996L,3L,4044L,1L,16256L,31L,65312L,7L,261640L,7L,1047560L,7L,4192640L,68L,16773657L,0L,67100929L,1568L,268421379L,640L,1073709319L,0L,4294905408L,0L,17179763769L,0L,68719247369L,14336L,274877382656L,78593L,1099510710272L,25081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286696Inst : IEnumerable<long>
{
public static readonly long[] Value=A286696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286696.Bytes);
public long this[int i]=>Value[i];

public static A286696Inst Instance=new A286696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286697
{
public static readonly long[] Value={ 1L,1L,0L,3L,16L,7L,64L,15L,256L,159L,1536L,831L,4096L,127L,31744L,1279L,114688L,16895L,458752L,66559L,1835008L,26623L,1114112L,9981951L,0L,33693695L,2293760L,201932799L,2621440L,941654015L,0L,40959999L,0L,10479075327L,0L,38656016383L,58720256L,524287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286697Inst : IEnumerable<long>
{
public static readonly long[] Value=A286697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286697.Bytes);
public long this[int i]=>Value[i];

public static A286697Inst Instance=new A286697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286698
{
public static readonly BigInteger[] Value={ 1L,10L,1L,1110L,1L,111100L,11L,11111100L,11L,1111110000L,1111L,111111110000L,1111L,11111111110000L,1111L,1111111111110000L,1111L,111111111100000000L,11111111L,11111111111100000000UL,11111111L,BigInteger.Parse("1111111111111100000000"),11101111L,BigInteger.Parse("111111111111111100010000") };
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
public class A286698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286698Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286698.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286698.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286698Inst Instance=new A286698Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286699
{
public static readonly BigInteger[] Value={ 1L,1L,100L,111L,10000L,1111L,1100000L,111111L,110000000L,111111L,11110000000L,11111111L,1111000000000L,1111111111L,111100000000000L,111111111111L,11110000000000000L,1111111111L,1111111100000000000L,111111111111L,BigInteger.Parse("111111110000000000000"),11111111111111L };
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
public class A286699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286699Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286699.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286699.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286699Inst Instance=new A286699Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286700
{
public static readonly long[] Value={ 1L,2L,1L,14L,1L,60L,3L,252L,3L,1008L,15L,4080L,15L,16368L,15L,65520L,15L,261888L,255L,1048320L,255L,4194048L,239L,16776976L,239L,67108352L,511L,268434944L,123L,1073740676L,1083L,4294966212L,1083L,17179810180L,58979L,68719411612L,65027L,274877841916L,65027L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286700Inst : IEnumerable<long>
{
public static readonly long[] Value=A286700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286700.Bytes);
public long this[int i]=>Value[i];

public static A286700Inst Instance=new A286700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286701
{
public static readonly long[] Value={ 1L,1L,4L,7L,16L,15L,96L,63L,384L,63L,1920L,255L,7680L,1023L,30720L,4095L,122880L,1023L,522240L,4095L,2088960L,16383L,8093696L,589823L,32374784L,131071L,133955584L,524287L,465567744L,142082047L,1846542336L,601882623L,7386169344L,2254700543L,26629111808L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286701Inst : IEnumerable<long>
{
public static readonly long[] Value=A286701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286701.Bytes);
public long this[int i]=>Value[i];

public static A286701Inst Instance=new A286701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286702
{
public static readonly BigInteger[] Value={ 1L,11L,1L,1111L,0L,111111L,0L,11111111L,1111L,1111111111L,0L,111111111111L,0L,11111111111111L,0L,1111111111111111L,11100000L,111111111111111111L,0L,11111111111111111111UL,1000000L,BigInteger.Parse("1111111111111111111111"),0L,BigInteger.Parse("111111111111111111111111"),0L };
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
public class A286702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286702Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286702.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286702.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286702Inst Instance=new A286702Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286703
{
public static readonly BigInteger[] Value={ 1L,11L,100L,1111L,0L,111111L,0L,11111111L,111100000L,1111111111L,0L,111111111111L,0L,11111111111111L,0L,1111111111111111L,111000000000L,111111111111111111L,0L,11111111111111111111UL,100000000000000L,BigInteger.Parse("1111111111111111111111"),0L,BigInteger.Parse("111111111111111111111111"),0L };
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
public class A286703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286703Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286703.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286703.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286703Inst Instance=new A286703Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286704
{
public static readonly long[] Value={ 1L,3L,1L,15L,0L,63L,0L,255L,15L,1023L,0L,4095L,0L,16383L,0L,65535L,224L,262143L,0L,1048575L,64L,4194303L,0L,16777215L,0L,67108863L,32L,268435455L,48L,1073741823L,256L,4294967295L,57348L,17179869183L,0L,68719476735L,16392L,274877906943L,7232L,1099511627775L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286704Inst : IEnumerable<long>
{
public static readonly long[] Value=A286704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286704.Bytes);
public long this[int i]=>Value[i];

public static A286704Inst Instance=new A286704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286705
{
public static readonly long[] Value={ 1L,3L,4L,15L,0L,63L,0L,255L,480L,1023L,0L,4095L,0L,16383L,0L,65535L,3584L,262143L,0L,1048575L,16384L,4194303L,0L,16777215L,0L,67108863L,2097152L,268435455L,25165824L,1073741823L,4194304L,4294967295L,1074659328L,17179869183L,0L,68719476735L,8594128896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286705Inst : IEnumerable<long>
{
public static readonly long[] Value=A286705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286705.Bytes);
public long this[int i]=>Value[i];

public static A286705Inst Instance=new A286705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286706
{
public static readonly BigInteger[] Value={ 23L,4567L,78910111213L,BigInteger.Parse("25262728293031323334353637383940414243444546474849") };
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
public class A286706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286706Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286706.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286706.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286706Inst Instance=new A286706Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286707
{
public static readonly long[] Value={ -1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,2L,2L,2L,2L,2L,3L,3L,4L,4L,4L,4L,4L,5L,5L,5L,6L,6L,6L,7L,7L,7L,7L,7L,8L,9L,9L,9L,10L,10L,10L,10L,11L,11L,11L,12L,13L,13L,13L,13L,13L,14L,14L,15L,15L,16L,16L,16L,17L,17L,17L,18L,18L,19L,19L,20L,20L,20L,21L,21L,22L,22L,22L,23L,24L,24L,24L,24L,25L,25L,26L,27L,27L,27L,28L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286707Inst : IEnumerable<long>
{
public static readonly long[] Value=A286707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286707.Bytes);
public long this[int i]=>Value[i];

public static A286707Inst Instance=new A286707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286708
{
public static readonly long[] Value={ 36L,72L,100L,108L,144L,196L,200L,216L,225L,288L,324L,392L,400L,432L,441L,484L,500L,576L,648L,675L,676L,784L,800L,864L,900L,968L,972L,1000L,1089L,1125L,1152L,1156L,1225L,1296L,1323L,1352L,1372L,1444L,1521L,1568L,1600L,1728L,1764L,1800L,1936L,1944L,2000L,2025L,2116L,2304L,2312L,2500L,2592L,2601L,2700L,2704L,2744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286708Inst : IEnumerable<long>
{
public static readonly long[] Value=A286708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286708.Bytes);
public long this[int i]=>Value[i];

public static A286708Inst Instance=new A286708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286709
{
public static readonly long[] Value={ 2L,3L,4L,10L,1L,5L,7L,14L,8L,15L,11L,19L,31L,6L,24L,28L,18L,12L,50L,32L,30L,9L,21L,38L,13L,42L,63L,20L,16L,25L,64L,61L,51L,44L,27L,35L,89L,37L,87L,39L,85L,41L,83L,17L,107L,45L,79L,29L,52L,92L,75L,22L,102L,53L,71L,40L,43L,34L,23L,103L,127L,128L,62L,188L,66L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286709Inst : IEnumerable<long>
{
public static readonly long[] Value=A286709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286709.Bytes);
public long this[int i]=>Value[i];

public static A286709Inst Instance=new A286709Inst();

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