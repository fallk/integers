using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A074395
{
public static readonly long[] Value={ 6L,1L,0L,5L,1L,4L,0L,5L,3L,0L,3L,4L,0L,5L,3L,2L,1L,2L,5L,1L,2L,5L,3L,4L,4L,0L,5L,1L,4L,2L,5L,3L,0L,3L,0L,3L,2L,5L,3L,2L,1L,2L,1L,4L,0L,5L,5L,5L,1L,4L,2L,1L,2L,3L,2L,3L,0L,3L,4L,0L,3L,2L,5L,1L,4L,2L,3L,2L,1L,4L,2L,5L,3L,2L,5L,3L,4L,4L,4L,2L,1L,2L,1L,2L,5L,3L,4L,4L,0L,5L,5L,5L,5L,5L,5L,3L,4L,0L,3L,2L,3L,2L,3L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074395Inst : IEnumerable<long>
{
public static readonly long[] Value=A074395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074395.Bytes);
public long this[int i]=>Value[i];

public static A074395Inst Instance=new A074395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074396
{
public static readonly long[] Value={ 5L,3L,1L,9L,9L,3L,1L,3L,1L,9L,9L,9L,1L,3L,9L,1L,9L,3L,9L,1L,9L,1L,3L,1L,9L,9L,3L,9L,3L,1L,3L,9L,1L,9L,3L,1L,9L,1L,3L,1L,1L,9L,1L,3L,1L,1L,9L,3L,9L,9L,3L,1L,9L,1L,3L,3L,1L,9L,3L,9L,9L,3L,3L,1L,9L,1L,9L,3L,9L,3L,9L,3L,9L,1L,1L,3L,1L,1L,1L,1L,9L,9L,1L,1L,3L,1L,3L,3L,1L,1L,1L,3L,3L,3L,9L,1L,9L,9L,9L,3L,9L,1L,3L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074396Inst : IEnumerable<long>
{
public static readonly long[] Value=A074396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074396.Bytes);
public long this[int i]=>Value[i];

public static A074396Inst Instance=new A074396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074397
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,2L,0L,2L,1L,3L,0L,4L,0L,3L,3L,4L,0L,5L,0L,5L,3L,3L,0L,8L,1L,4L,3L,7L,0L,10L,0L,7L,4L,5L,4L,13L,0L,5L,4L,12L,0L,11L,0L,9L,7L,6L,0L,15L,1L,9L,5L,10L,0L,14L,4L,14L,6L,8L,0L,22L,0L,6L,9L,12L,5L,16L,0L,11L,5L,15L,0L,24L,0L,9L,9L,13L,3L,18L,0L,20L,8L,8L,0L,25L,5L,9L,7L,18L,0L,27L,5L,15L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074397Inst : IEnumerable<long>
{
public static readonly long[] Value=A074397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074397.Bytes);
public long this[int i]=>Value[i];

public static A074397Inst Instance=new A074397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074398
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,2L,0L,2L,1L,2L,0L,3L,0L,3L,2L,2L,0L,4L,0L,4L,3L,4L,0L,5L,1L,4L,2L,4L,0L,6L,0L,5L,3L,5L,2L,6L,0L,5L,3L,6L,0L,8L,0L,6L,5L,6L,0L,9L,2L,7L,4L,6L,0L,9L,4L,7L,5L,7L,0L,11L,0L,8L,7L,7L,3L,10L,0L,8L,5L,10L,0L,11L,0L,10L,9L,10L,4L,12L,0L,11L,6L,10L,0L,14L,5L,10L,7L,11L,0L,15L,4L,10L,7L,10L,4L,13L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074398Inst : IEnumerable<long>
{
public static readonly long[] Value=A074398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074398.Bytes);
public long this[int i]=>Value[i];

public static A074398Inst Instance=new A074398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074399
{
public static readonly long[] Value={ 2L,3L,3L,5L,5L,7L,7L,3L,5L,11L,11L,13L,13L,7L,5L,17L,17L,19L,19L,7L,11L,23L,23L,5L,13L,13L,7L,29L,29L,31L,31L,11L,17L,17L,7L,37L,37L,19L,13L,41L,41L,43L,43L,11L,23L,47L,47L,7L,7L,17L,17L,53L,53L,11L,11L,19L,29L,59L,59L,61L,61L,31L,7L,13L,13L,67L,67L,23L,23L,71L,71L,73L,73L,37L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074399Inst : IEnumerable<long>
{
public static readonly long[] Value=A074399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074399.Bytes);
public long this[int i]=>Value[i];

public static A074399Inst Instance=new A074399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074400
{
public static readonly long[] Value={ 2L,6L,8L,14L,12L,24L,16L,30L,26L,36L,24L,56L,28L,48L,48L,62L,36L,78L,40L,84L,64L,72L,48L,120L,62L,84L,80L,112L,60L,144L,64L,126L,96L,108L,96L,182L,76L,120L,112L,180L,84L,192L,88L,168L,156L,144L,96L,248L,114L,186L,144L,196L,108L,240L,144L,240L,160L,180L,120L,336L,124L,192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074400Inst : IEnumerable<long>
{
public static readonly long[] Value=A074400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074400.Bytes);
public long this[int i]=>Value[i];

public static A074400Inst Instance=new A074400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074401
{
public static readonly long[] Value={ 37L,51L,67L,89L,93L,179L,191L,373L,391L,445L,478L,479L,519L,521L,551L,581L,583L,601L,613L,619L,653L,655L,661L,673L,697L,701L,703L,713L,719L,727L,753L,759L,769L,773L,778L,851L,853L,881L,886L,889L,907L,913L,919L,923L,949L,973L,974L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074401Inst : IEnumerable<long>
{
public static readonly long[] Value=A074401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074401.Bytes);
public long this[int i]=>Value[i];

public static A074401Inst Instance=new A074401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074402
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,13L,14L,15L,16L,18L,20L,21L,22L,24L,25L,26L,27L,28L,30L,32L,33L,35L,36L,37L,39L,40L,42L,44L,45L,48L,49L,50L,52L,54L,56L,57L,58L,60L,63L,64L,65L,66L,70L,72L,74L,75L,78L,80L,81L,84L,85L,88L,90L,91L,93L,96L,98L,99L,100L,102L,104L,105L,108L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074402Inst : IEnumerable<long>
{
public static readonly long[] Value=A074402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074402.Bytes);
public long this[int i]=>Value[i];

public static A074402Inst Instance=new A074402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074403
{
public static readonly long[] Value={ 0L,0L,2L,6L,16L,45L,128L,448L,1706L,6528L,24576L,90110L,327680L,1198665L,4438966L,16646144L,62914560L,238605640L,905969664L,3442684722L,13102206738L,49977848925L,191126044672L,732649837760L,2814062572336L,10825959997440L,41705086880768L,160862477970870L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074403Inst : IEnumerable<long>
{
public static readonly long[] Value=A074403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074403.Bytes);
public long this[int i]=>Value[i];

public static A074403Inst Instance=new A074403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074420
{
public static readonly long[] Value={ 0L,1L,2L,7L,25L,107L,450L,1965L,8666L,39050L,177500L,814006L,3756250L,17439507L,81380200L,381473625L,1795156250L,8477122367L,40154687500L,190734843750L,908261160564L,4334883611534L,20732050781250L,99341076252470L,476837158203125L,2292486345026923L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074420Inst : IEnumerable<long>
{
public static readonly long[] Value=A074420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074420.Bytes);
public long this[int i]=>Value[i];

public static A074420Inst Instance=new A074420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074421
{
public static readonly long[] Value={ 0L,0L,2L,7L,25L,99L,432L,1935L,8666L,39050L,177500L,813748L,3756250L,17439507L,81380200L,381463875L,1795133272L,8477078967L,40154687500L,190734843750L,908261160564L,4334883167500L,20732050781250L,99341076252470L,476837158203125L,2292486326246875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074421Inst : IEnumerable<long>
{
public static readonly long[] Value=A074421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074421.Bytes);
public long this[int i]=>Value[i];

public static A074421Inst Instance=new A074421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074422
{
public static readonly long[] Value={ 1L,0L,0L,4L,25L,165L,1157L,6552L,33045L,167928L,894829L,4921380L,27546779L,155483424L,877515282L,4936018176L,27757515151L,156680520702L,889046473445L,5068079700940L,28988793431460L,166189019079168L,954256949236825L,5486977453011768L,31597040041716690L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074422Inst : IEnumerable<long>
{
public static readonly long[] Value=A074422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074422.Bytes);
public long this[int i]=>Value[i];

public static A074422Inst Instance=new A074422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074423
{
public static readonly long[] Value={ 0L,0L,0L,8L,60L,236L,1008L,5280L,30240L,169987L,940896L,5174688L,28304640L,155270016L,862725426L,4857268896L,27554100480L,156752186112L,892662156288L,5088174124950L,29046943180800L,166191833516125L,953309368018944L,5481528861090816L,31581437286776820L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074423Inst : IEnumerable<long>
{
public static readonly long[] Value=A074423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074423.Bytes);
public long this[int i]=>Value[i];

public static A074423Inst Instance=new A074423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074424
{
public static readonly long[] Value={ 0L,1L,2L,6L,36L,240L,1296L,6312L,31824L,165840L,883872L,4861056L,27433728L,155696585L,878719104L,4938274944L,27770211072L,156752183808L,889181991936L,5067822213734L,28987320651922L,166186204664832L,954240788994048L,5486884531697664L,31596861676172076L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074424Inst : IEnumerable<long>
{
public static readonly long[] Value=A074424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074424.Bytes);
public long this[int i]=>Value[i];

public static A074424Inst Instance=new A074424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074425
{
public static readonly long[] Value={ 0L,0L,3L,13L,42L,165L,900L,5094L,29151L,167928L,952560L,5238873L,28421280L,155483424L,863910327L,4859490672L,27541503360L,156680520702L,892526107392L,5087915629975L,29045467515255L,166189019079168L,953325512487936L,5481621691710030L,31581615565250142L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074425Inst : IEnumerable<long>
{
public static readonly long[] Value=A074425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074425.Bytes);
public long this[int i]=>Value[i];

public static A074425Inst Instance=new A074425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074426
{
public static readonly long[] Value={ 0L,0L,0L,2L,36L,236L,1296L,6792L,34272L,169987L,883872L,4861056L,27433728L,155270016L,876311654L,4933761408L,27770211072L,156752186112L,889181991936L,5068337188146L,28990266218496L,166191833516125L,954240788994048L,5486884531697664L,31596861676172076L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074426Inst : IEnumerable<long>
{
public static readonly long[] Value=A074426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074426.Bytes);
public long this[int i]=>Value[i];

public static A074426Inst Instance=new A074426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074427
{
public static readonly long[] Value={ 0L,1L,6L,18L,60L,240L,1008L,4908L,28080L,165840L,940896L,5174688L,28304640L,155696585L,865095552L,4861712448L,27554100480L,156752183808L,892662156288L,5087657135000L,29043991855542L,166186204664832L,953309368018944L,5481528861090816L,31581437286776820L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074427Inst : IEnumerable<long>
{
public static readonly long[] Value=A074427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074427.Bytes);
public long this[int i]=>Value[i];

public static A074427Inst Instance=new A074427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074428
{
public static readonly long[] Value={ 1L,2L,3L,9L,36L,162L,900L,5616L,33048L,178459L,940896L,5038848L,27546779L,153264960L,863910489L,4897760256L,27770211072L,157340548224L,892526107392L,5077739844402L,28988793435209L,166026726038016L,953309368018944L,5484237660094464L,31597040041716690L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074428Inst : IEnumerable<long>
{
public static readonly long[] Value=A074428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074428.Bytes);
public long this[int i]=>Value[i];

public static A074428Inst Instance=new A074428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074429
{
public static readonly long[] Value={ 0L,0L,1L,6L,42L,270L,1296L,5832L,29160L,159408L,894829L,5038848L,28304640L,157913897L,877515379L,4895520768L,27541503360L,156116108160L,889181991936L,5077997833419L,29045467518171L,166354131141818L,954256949236825L,5484237660094464L,31581437286776820L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074429Inst : IEnumerable<long>
{
public static readonly long[] Value=A074429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074429.Bytes);
public long this[int i]=>Value[i];

public static A074429Inst Instance=new A074429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074430
{
public static readonly long[] Value={ 0L,0L,3L,12L,36L,162L,1008L,6048L,33048L,176256L,940896L,5038848L,27433728L,152845056L,863910489L,4899999744L,27770211072L,157340548224L,892662156288L,5078255822436L,28988793435209L,166023914360832L,953309368018944L,5484237660094464L,31596861676172076L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074430Inst : IEnumerable<long>
{
public static readonly long[] Value=A074430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074430.Bytes);
public long this[int i]=>Value[i];

public static A074430Inst Instance=new A074430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074431
{
public static readonly long[] Value={ 0L,0L,1L,9L,60L,270L,1157L,5616L,29160L,157464L,883872L,5038848L,28421280L,158130514L,877515379L,4897760256L,27554100480L,156116108160L,889046473445L,5077739844402L,29045467518171L,166351313967709L,954240788994048L,5484237660094464L,31581615565250142L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074431Inst : IEnumerable<long>
{
public static readonly long[] Value=A074431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074431.Bytes);
public long this[int i]=>Value[i];

public static A074431Inst Instance=new A074431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074432
{
public static readonly long[] Value={ 0L,1L,3L,6L,25L,162L,1008L,5832L,33048L,180662L,952560L,5038848L,27433728L,153055008L,863910489L,4895520768L,27757515151L,157340548224L,892662156288L,5077997833419L,28988793435209L,166029537715200L,953325512487936L,5484237660094464L,31596861676172076L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074432Inst : IEnumerable<long>
{
public static readonly long[] Value=A074432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074432.Bytes);
public long this[int i]=>Value[i];

public static A074432Inst Instance=new A074432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074433
{
public static readonly long[] Value={ 0L,0L,1L,12L,60L,270L,1296L,6048L,29160L,155520L,883872L,5038848L,28304640L,157697280L,877515379L,4899999744L,27554100480L,156116108160L,889181991936L,5078255822436L,29045467518171L,166348496793600L,954240788994048L,5484237660094464L,31581437286776820L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074433Inst : IEnumerable<long>
{
public static readonly long[] Value=A074433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074433.Bytes);
public long this[int i]=>Value[i];

public static A074433Inst Instance=new A074433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074434
{
public static readonly long[] Value={ 1L,1L,1L,4L,36L,214L,1157L,6312L,33048L,167928L,883872L,4881168L,27546779L,155696585L,877515379L,4936018176L,27770211072L,156728297088L,889046473445L,5067822213734L,28988793435209L,166189019079168L,954240788994048L,5486915505475584L,31597040041716690L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074434Inst : IEnumerable<long>
{
public static readonly long[] Value=A074434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074434.Bytes);
public long this[int i]=>Value[i];

public static A074434Inst Instance=new A074434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074435
{
public static readonly long[] Value={ 0L,0L,3L,8L,42L,214L,1008L,5094L,29160L,169987L,952560L,5196096L,28304640L,155483424L,863910489L,4857268896L,27541503360L,156728297088L,892662156288L,5087915629975L,29045467518171L,166191833516125L,953325512487936L,5481559804635648L,31581437286776820L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074435Inst : IEnumerable<long>
{
public static readonly long[] Value=A074435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074435.Bytes);
public long this[int i]=>Value[i];

public static A074435Inst Instance=new A074435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074868
{
public static readonly long[] Value={ 295L,590L,767L,885L,1038L,1416L,1534L,1589L,1770L,2065L,2301L,2422L,3178L,3186L,3245L,3304L,3448L,3540L,4130L,4602L,4767L,5192L,5230L,5448L,5516L,5605L,6195L,6291L,6356L,6490L,6574L,6860L,7266L,7945L,7965L,8236L,8260L,8437L,8968L,9145L,9204L,9342L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074868Inst : IEnumerable<long>
{
public static readonly long[] Value=A074868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074868.Bytes);
public long this[int i]=>Value[i];

public static A074868Inst Instance=new A074868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074869
{
public static readonly long[] Value={ 707L,7843L,143591L,274211L,598787L,737807L,861749L,928421L,1515521L,1682203L,1936099L,2223143L,2709473L,2908373L,2985641L,3669919L,3689279L,3825419L,3848851L,4154297L,4429159L,5321743L,5654623L,5678131L,6548899L,8916427L,11403743L,11474267L,12191803L,13340869L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074869Inst : IEnumerable<long>
{
public static readonly long[] Value=A074869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074869.Bytes);
public long this[int i]=>Value[i];

public static A074869Inst Instance=new A074869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074870
{
public static readonly long[] Value={ 4L,6L,12L,15L,12L,21L,56L,18L,30L,473L,60L,26L,42L,30L,176L,34L,198L,4883L,60L,42L,154L,69L,72L,50L,754L,81L,56L,667L,60L,93L,64L,99L,102L,105L,72L,111L,76L,195L,120L,205L,462L,86L,1364L,225L,138L,3337L,144L,2303L,1505L,102L,260L,1537L,108L,165L,1624L,399L,754L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074870Inst : IEnumerable<long>
{
public static readonly long[] Value=A074870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074870.Bytes);
public long this[int i]=>Value[i];

public static A074870Inst Instance=new A074870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074871
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,2L,1L,0L,1L,1L,0L,1L,0L,1L,2L,1L,2L,1L,1L,1L,1L,2L,1L,1L,2L,2L,2L,1L,0L,0L,0L,1L,0L,1L,0L,1L,2L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,3L,0L,1L,2L,2L,0L,1L,3L,2L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,0L,1L,2L,2L,2L,1L,2L,1L,2L,1L,0L,0L,1L,1L,2L,3L,1L,2L,1L,1L,0L,1L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074871Inst : IEnumerable<long>
{
public static readonly long[] Value=A074871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074871.Bytes);
public long this[int i]=>Value[i];

public static A074871Inst Instance=new A074871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074872
{
public static readonly long[] Value={ 1L,1L,5L,5L,25L,25L,125L,125L,625L,625L,3125L,3125L,15625L,15625L,78125L,78125L,390625L,390625L,1953125L,1953125L,9765625L,9765625L,48828125L,48828125L,244140625L,244140625L,1220703125L,1220703125L,6103515625L,6103515625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074872Inst : IEnumerable<long>
{
public static readonly long[] Value=A074872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074872.Bytes);
public long this[int i]=>Value[i];

public static A074872Inst Instance=new A074872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074873
{
public static readonly long[] Value={ 66L,210L,282L,364L,510L,642L,930L,966L,1080L,1092L,1146L,1624L,2130L,2226L,2346L,2586L,2676L,3560L,3810L,4278L,4872L,7965L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074873Inst : IEnumerable<long>
{
public static readonly long[] Value=A074873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074873.Bytes);
public long this[int i]=>Value[i];

public static A074873Inst Instance=new A074873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074874
{
public static readonly long[] Value={ 1L,3L,5L,11L,23L,55L,87L,123L,383L,501L,957L,1015L,3565L,3777L,5667L,6141L,9069L,11033L,13827L,27347L,35119L,44693L,55645L,91915L,137037L,156919L,180251L,233935L,261989L,269395L,294679L,315605L,335995L,361645L,380103L,389809L,410201L,428399L,443267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074874Inst : IEnumerable<long>
{
public static readonly long[] Value=A074874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074874.Bytes);
public long this[int i]=>Value[i];

public static A074874Inst Instance=new A074874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074875
{
public static readonly long[] Value={ 2L,21L,51L,369L,3051L,3783L,5757L,6477L,6897L,7929L,15639L,15925L,20967L,33003L,50739L,58797L,73917L,75627L,118405L,121975L,131979L,170973L,219447L,291369L,310137L,311675L,347337L,365679L,396807L,404559L,437255L,442599L,550719L,558429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074875Inst : IEnumerable<long>
{
public static readonly long[] Value=A074875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074875.Bytes);
public long this[int i]=>Value[i];

public static A074875Inst Instance=new A074875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074876
{
public static readonly long[] Value={ 4L,16L,85L,923L,6713L,8035L,8827L,10109L,19349L,21671L,30565L,31499L,41285L,116129L,154255L,269009L,282799L,312997L,362483L,477325L,486301L,498329L,525083L,607057L,609367L,714589L,995087L,1038841L,2013187L,2084785L,2088545L,2148409L,2185937L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074876Inst : IEnumerable<long>
{
public static readonly long[] Value=A074876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074876.Bytes);
public long this[int i]=>Value[i];

public static A074876Inst Instance=new A074876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074877
{
public static readonly long[] Value={ 15L,106L,541L,2432L,10307L,42438L,172233L,693964L,2785999L,11164370L,44698325L,178875096L,715664091L,2862983902L,11452590817L,45811673828L,183249316583L,733002509034L,2932020521709L,11728103058160L,46912454175475L,187649900587766L,750599770123001L,3002399416036092L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074877Inst : IEnumerable<long>
{
public static readonly long[] Value=A074877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074877.Bytes);
public long this[int i]=>Value[i];

public static A074877Inst Instance=new A074877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074878
{
public static readonly long[] Value={ 1L,2L,6L,14L,32L,70L,150L,316L,658L,1358L,2784L,5678L,11534L,23356L,47178L,95110L,191440L,384854L,772902L,1550972L,3110306L,6234142L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074878Inst : IEnumerable<long>
{
public static readonly long[] Value=A074878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074878.Bytes);
public long this[int i]=>Value[i];

public static A074878Inst Instance=new A074878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074879
{
public static readonly long[] Value={ 1L,9L,9L,3L,1L,1L,1L,3L,3L,1L,3L,1L,3L,1L,1L,3L,1L,9L,1L,3L,1L,3L,1L,9L,1L,3L,9L,3L,9L,3L,3L,1L,9L,3L,1L,1L,3L,9L,9L,3L,3L,1L,1L,3L,9L,9L,1L,1L,3L,3L,1L,3L,3L,1L,1L,1L,9L,9L,1L,1L,9L,3L,1L,9L,1L,3L,1L,1L,9L,1L,1L,1L,3L,1L,3L,9L,9L,1L,1L,1L,1L,1L,3L,1L,1L,1L,3L,1L,9L,9L,1L,3L,9L,1L,3L,1L,9L,3L,1L,9L,9L,9L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074879Inst : IEnumerable<long>
{
public static readonly long[] Value=A074879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074879.Bytes);
public long this[int i]=>Value[i];

public static A074879Inst Instance=new A074879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074880
{
public static readonly long[] Value={ 1L,1L,1L,3L,6L,120L,120L,1260L,6720L,128520L,362880L,20041560L,39916800L,1132971840L,11721790080L,163459296000L,1307674368000L,87307501881600L,355687428096000L,19137704006453760L,205947392645030400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074880Inst : IEnumerable<long>
{
public static readonly long[] Value=A074880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074880.Bytes);
public long this[int i]=>Value[i];

public static A074880Inst Instance=new A074880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074881
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,9L,4L,3L,1L,25L,10L,15L,6L,10L,1L,75L,40L,90L,36L,120L,1L,231L,175L,420L,126L,735L,120L,126L,105L,1L,763L,616L,2730L,336L,5320L,960L,1260L,1008L,840L,336L,1L,2619L,2884L,15498L,756L,41580L,4320L,11340L,6720L,6804L,7560L,4320L,3024L,2268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074881Inst : IEnumerable<long>
{
public static readonly long[] Value=A074881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074881.Bytes);
public long this[int i]=>Value[i];

public static A074881Inst Instance=new A074881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074882
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,4L,7L,8L,9L,7L,11L,9L,13L,10L,13L,16L,17L,13L,19L,17L,19L,16L,23L,20L,25L,19L,27L,24L,29L,19L,31L,32L,29L,25L,34L,31L,37L,28L,35L,36L,41L,27L,43L,38L,42L,34L,47L,41L,49L,38L,45L,45L,53L,40L,53L,51L,51L,43L,59L,45L,61L,46L,60L,64L,63L,43L,67L,59L,61L,50L,71L,65L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074882Inst : IEnumerable<long>
{
public static readonly long[] Value=A074882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074882.Bytes);
public long this[int i]=>Value[i];

public static A074882Inst Instance=new A074882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074883
{
public static readonly long[] Value={ 1L,3L,3L,4L,6L,4L,7L,10L,10L,7L,6L,17L,20L,17L,6L,12L,23L,37L,37L,23L,12L,8L,35L,60L,74L,60L,35L,8L,15L,43L,95L,134L,134L,95L,43L,15L,13L,58L,138L,229L,268L,229L,138L,58L,13L,18L,71L,196L,367L,497L,497L,367L,196L,71L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074883Inst : IEnumerable<long>
{
public static readonly long[] Value=A074883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074883.Bytes);
public long this[int i]=>Value[i];

public static A074883Inst Instance=new A074883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074884
{
public static readonly long[] Value={ 2L,7L,17L,19L,59L,167L,197L,227L,317L,457L,521L,1637L,1861L,1997L,2053L,3833L,5227L,19891L,47303L,54973L,58603L,124567L,138163L,170167L,707467L,1637429L,1940777L,3717731L,4722079L,17886697L,27507569L,73342163L,154205101L,160561133L,186668543L,429364379L,458121431L,1459411661L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074884Inst : IEnumerable<long>
{
public static readonly long[] Value=A074884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074884.Bytes);
public long this[int i]=>Value[i];

public static A074884Inst Instance=new A074884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074885
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,11L,14L,15L,23L,30L,35L,38L,39L,42L,47L,62L,71L,78L,83L,87L,95L,110L,119L,138L,143L,155L,158L,167L,182L,195L,203L,210L,215L,222L,227L,230L,255L,263L,282L,287L,302L,318L,327L,335L,383L,390L,395L,398L,435L,447L,455L,462L,483L,503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074885Inst : IEnumerable<long>
{
public static readonly long[] Value=A074885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074885.Bytes);
public long this[int i]=>Value[i];

public static A074885Inst Instance=new A074885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074886
{
public static readonly long[] Value={ 14L,110L,274L,435L,1298L,4608L,4646L,5384L,9214L,10154L,10778L,11912L,13035L,13844L,15026L,18698L,21346L,22958L,25642L,26846L,27466L,32078L,34546L,41164L,49570L,77374L,80438L,85875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074886Inst : IEnumerable<long>
{
public static readonly long[] Value=A074886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074886.Bytes);
public long this[int i]=>Value[i];

public static A074886Inst Instance=new A074886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074887
{
public static readonly long[] Value={ 915L,12957L,20745L,26985L,54621L,97785L,111615L,188013L,191775L,197631L,231045L,258687L,428745L,565761L,726645L,793653L,807639L,829857L,941451L,1048719L,1084587L,1224111L,1233027L,1863255L,1920681L,1973805L,2043489L,2129883L,2254119L,2265417L,2300151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074887Inst : IEnumerable<long>
{
public static readonly long[] Value=A074887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074887.Bytes);
public long this[int i]=>Value[i];

public static A074887Inst Instance=new A074887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074888
{
public static readonly long[] Value={ 1029L,1312L,1635L,1755L,1918L,37562L,55743L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074888Inst : IEnumerable<long>
{
public static readonly long[] Value=A074888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074888.Bytes);
public long this[int i]=>Value[i];

public static A074888Inst Instance=new A074888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074889
{
public static readonly long[] Value={ 524L,928L,1179L,1252L,1292L,1372L,1736L,2101L,2525L,2817L,4103L,4213L,4949L,8327L,8657L,8767L,10109L,10219L,19781L,23711L,25021L,27331L,28841L,34571L,41003L,41204L,45244L,45644L,46243L,47263L,48863L,49684L,50173L,52124L,53303L,53324L,56164L,56323L,56564L,56643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074889Inst : IEnumerable<long>
{
public static readonly long[] Value=A074889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074889.Bytes);
public long this[int i]=>Value[i];

public static A074889Inst Instance=new A074889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074890
{
public static readonly long[] Value={ 1L,3L,6L,13L,25L,55L,100L,222L,401L,891L,1602L,3559L,6428L,14258L,25647L,56936L,102860L,228154L,410339L,910998L,1645813L,3650437L,6565453L,14576121L,26332935L,58407052L,105047514L,233217299L,421327294L,934513441L,1680759539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074890Inst : IEnumerable<long>
{
public static readonly long[] Value=A074890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074890.Bytes);
public long this[int i]=>Value[i];

public static A074890Inst Instance=new A074890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074891
{
public static readonly long[] Value={ 15L,35L,357L,1045L,3339L,5049L,10659L,12441L,24871L,24969L,29029L,50065L,58435L,64285L,87685L,99693L,132957L,137885L,140335L,353133L,423657L,596037L,655707L,734517L,745503L,894387L,1390753L,1406427L,1529983L,1641783L,1739507L,1823877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074891Inst : IEnumerable<long>
{
public static readonly long[] Value=A074891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074891.Bytes);
public long this[int i]=>Value[i];

public static A074891Inst Instance=new A074891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074892
{
public static readonly long[] Value={ 1L,3L,5L,11L,23L,55L,87L,123L,383L,501L,957L,1015L,3565L,3777L,5667L,6141L,9069L,11033L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074892Inst : IEnumerable<long>
{
public static readonly long[] Value=A074892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074892.Bytes);
public long this[int i]=>Value[i];

public static A074892Inst Instance=new A074892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074893
{
public static readonly long[] Value={ 3L,10L,19L,2L,1L,2L,2L,1L,6L,1L,6L,19L,17L,1L,7L,1L,2L,2L,1L,10L,2L,6L,2L,1L,3L,2L,1L,21L,5L,1L,15L,1L,1L,4L,1L,1L,1L,443L,2L,1L,4L,3L,1L,1L,6L,26L,6L,2L,39L,4L,1L,2L,6L,1L,1L,2L,4L,7L,1L,5L,1L,3L,1L,3L,5L,10L,1L,9L,5L,1L,2L,4L,10L,1L,1L,5L,1L,1L,3L,2L,2L,2L,2L,1L,4L,1L,1L,1L,1L,11L,1L,4L,1L,2L,2L,2L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074893Inst : IEnumerable<long>
{
public static readonly long[] Value=A074893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074893.Bytes);
public long this[int i]=>Value[i];

public static A074893Inst Instance=new A074893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074894
{
public static readonly long[] Value={ 3L,6L,27L,486L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074894Inst : IEnumerable<long>
{
public static readonly long[] Value=A074894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074894.Bytes);
public long this[int i]=>Value[i];

public static A074894Inst Instance=new A074894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074895
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,14L,16L,17L,31L,32L,34L,35L,37L,38L,71L,73L,74L,76L,79L,91L,92L,95L,97L,98L,101L,104L,106L,107L,112L,113L,118L,119L,124L,125L,128L,131L,133L,134L,136L,142L,145L,146L,149L,151L,152L,157L,164L,166L,167L,172L,175L,179L,181L,182L,188L,191L,194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074895Inst : IEnumerable<long>
{
public static readonly long[] Value=A074895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074895.Bytes);
public long this[int i]=>Value[i];

public static A074895Inst Instance=new A074895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074896
{
public static readonly long[] Value={ 1L,4L,9L,18L,46L,52L,61L,63L,94L,121L,144L,148L,163L,169L,423L,441L,484L,487L,522L,526L,652L,675L,676L,691L,925L,927L,961L,982L,1042L,1062L,1089L,1251L,1273L,1297L,1405L,1426L,1656L,1674L,1828L,1843L,1861L,4032L,4069L,4072L,4201L,4264L,4276L,4441L,4477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074896Inst : IEnumerable<long>
{
public static readonly long[] Value=A074896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074896.Bytes);
public long this[int i]=>Value[i];

public static A074896Inst Instance=new A074896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074897
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,8L,10L,12L,13L,14L,16L,18L,19L,22L,23L,24L,28L,30L,32L,34L,36L,39L,40L,41L,42L,46L,48L,50L,52L,54L,55L,56L,57L,58L,60L,64L,66L,70L,72L,74L,76L,78L,80L,84L,86L,88L,90L,92L,94L,96L,98L,101L,102L,104L,106L,107L,108L,110L,112L,114L,116L,118L,122L,124L,126L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074897Inst : IEnumerable<long>
{
public static readonly long[] Value=A074897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074897.Bytes);
public long this[int i]=>Value[i];

public static A074897Inst Instance=new A074897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074898
{
public static readonly long[] Value={ 1L,6L,7L,9L,11L,15L,17L,20L,21L,25L,26L,27L,29L,31L,33L,35L,37L,38L,43L,44L,45L,47L,49L,51L,53L,59L,61L,62L,63L,65L,67L,68L,69L,71L,73L,75L,77L,79L,81L,82L,83L,85L,87L,89L,91L,93L,95L,97L,99L,100L,103L,105L,109L,111L,113L,115L,117L,119L,120L,121L,123L,125L,127L,128L,129L,131L,133L,134L,135L,137L,139L,141L,143L,145L,146L,149L,151L,153L,155L,157L,158L,159L,161L,163L,165L,167L,168L,169L,170L,171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074898Inst : IEnumerable<long>
{
public static readonly long[] Value=A074898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074898.Bytes);
public long this[int i]=>Value[i];

public static A074898Inst Instance=new A074898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074899
{
public static readonly long[] Value={ 1L,3L,6L,12L,19L,21L,28L,36L,51L,54L,55L,63L,66L,82L,87L,91L,99L,102L,132L,147L,153L,165L,168L,171L,252L,307L,309L,351L,352L,379L,381L,417L,423L,451L,501L,505L,523L,534L,564L,577L,582L,594L,595L,604L,613L,627L,631L,645L,649L,654L,666L,672L,694L,753L,766L,771L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074899Inst : IEnumerable<long>
{
public static readonly long[] Value=A074899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074899.Bytes);
public long this[int i]=>Value[i];

public static A074899Inst Instance=new A074899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074900
{
public static readonly long[] Value={ 34L,194L,866L,1889L,2017L,2434L,2722L,2897L,4993L,7393L,7394L,7841L,10562L,10882L,10888L,11588L,11777L,11969L,12416L,13856L,15074L,16993L,17282L,18818L,19972L,20129L,20417L,20849L,23041L,24322L,29572L,29576L,30224L,31364L,32272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074900Inst : IEnumerable<long>
{
public static readonly long[] Value=A074900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074900.Bytes);
public long this[int i]=>Value[i];

public static A074900Inst Instance=new A074900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074901
{
public static readonly long[] Value={ 0L,2L,4L,6L,8L,9L,12L,26L,27L,34L,38L,48L,54L,60L,96L,150L,168L,180L,420L,438L,462L,468L,522L,540L,570L,828L,1320L,1782L,2130L,2142L,2280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074901Inst : IEnumerable<long>
{
public static readonly long[] Value=A074901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074901.Bytes);
public long this[int i]=>Value[i];

public static A074901Inst Instance=new A074901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074902
{
public static readonly long[] Value={ 6L,12L,24L,28L,30L,40L,42L,56L,60L,66L,78L,80L,84L,96L,102L,108L,114L,120L,132L,135L,138L,140L,150L,168L,174L,186L,200L,204L,210L,222L,224L,228L,234L,240L,246L,252L,258L,264L,270L,273L,276L,280L,282L,294L,300L,308L,312L,318L,330L,348L,354L,360L,364L,366L,372L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074902Inst : IEnumerable<long>
{
public static readonly long[] Value=A074902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074902.Bytes);
public long this[int i]=>Value[i];

public static A074902Inst Instance=new A074902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074903
{
public static readonly long[] Value={ 1L,3L,5L,1L,1L,3L,1L,5L,7L,4L,4L,9L,1L,6L,5L,9L,0L,0L,1L,7L,9L,3L,8L,6L,8L,0L,0L,5L,2L,5L,6L,5L,2L,1L,0L,6L,8L,3L,6L,0L,6L,5L,1L,5L,0L,8L,7L,4L,2L,7L,0L,1L,6L,8L,7L,3L,4L,5L,1L,4L,7L,2L,1L,1L,0L,1L,3L,7L,4L,2L,2L,7L,7L,1L,1L,9L,5L,5L,0L,1L,7L,1L,2L,8L,6L,9L,1L,3L,0L,7L,5L,1L,5L,9L,7L,8L,0L,2L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074903Inst : IEnumerable<long>
{
public static readonly long[] Value=A074903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074903.Bytes);
public long this[int i]=>Value[i];

public static A074903Inst Instance=new A074903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074904
{
public static readonly long[] Value={ 1L,4L,4L,4L,6L,2L,3L,9L,6L,2L,4L,6L,1L,6L,0L,8L,1L,5L,8L,8L,2L,4L,9L,9L,0L,9L,0L,5L,2L,5L,4L,8L,3L,2L,0L,3L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074904Inst : IEnumerable<long>
{
public static readonly long[] Value=A074904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074904.Bytes);
public long this[int i]=>Value[i];

public static A074904Inst Instance=new A074904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074905
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,2L,0L,2L,1L,0L,3L,2L,0L,1L,1L,3L,0L,2L,1L,0L,2L,1L,3L,4L,0L,0L,1L,0L,1L,5L,1L,2L,0L,5L,0L,1L,3L,1L,0L,2L,0L,3L,0L,1L,0L,7L,7L,1L,0L,0L,2L,0L,2L,2L,2L,2L,0L,1L,1L,0L,2L,7L,1L,0L,1L,7L,2L,3L,0L,0L,2L,2L,1L,1L,2L,1L,5L,1L,2L,4L,0L,2L,0L,1L,0L,3L,3L,1L,1L,1L,4L,3L,1L,2L,2L,1L,6L,0L,6L,4L,3L,2L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074905Inst : IEnumerable<long>
{
public static readonly long[] Value=A074905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074905.Bytes);
public long this[int i]=>Value[i];

public static A074905Inst Instance=new A074905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074906
{
public static readonly long[] Value={ 1521L,858L,1158L,1170L,2106L,2976L,5088L,8520L,17400L,38400L,88452L,196924L,228004L,255836L,255892L,339948L,708372L,1392748L,1392804L,2631580L,3684548L,3684604L,4502876L,4502932L,4630444L,5343604L,5343660L,13185396L,26489484L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074906Inst : IEnumerable<long>
{
public static readonly long[] Value=A074906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074906.Bytes);
public long this[int i]=>Value[i];

public static A074906Inst Instance=new A074906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074907
{
public static readonly long[] Value={ 570L,870L,1290L,1878L,1890L,3870L,6426L,10854L,13830L,19434L,20886L,21606L,25098L,26742L,26754L,40446L,63234L,77406L,110754L,171486L,253458L,295740L,647748L,1077612L,1467588L,1956812L,2109796L,1889486L,953914L,668966L,353578L,176792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074907Inst : IEnumerable<long>
{
public static readonly long[] Value=A074907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074907.Bytes);
public long this[int i]=>Value[i];

public static A074907Inst Instance=new A074907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074908
{
public static readonly long[] Value={ 2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,3L,2L,2L,2L,2L,3L,3L,2L,3L,2L,2L,2L,2L,3L,3L,2L,3L,3L,3L,2L,3L,2L,2L,3L,2L,3L,3L,3L,2L,5L,2L,3L,2L,2L,3L,2L,2L,4L,3L,2L,3L,3L,3L,3L,2L,3L,2L,3L,5L,2L,3L,2L,2L,4L,2L,3L,2L,2L,4L,3L,3L,3L,2L,3L,2L,3L,4L,4L,2L,5L,2L,5L,3L,2L,3L,2L,2L,3L,4L,3L,2L,4L,2L,3L,3L,2L,4L,2L,3L,3L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074908Inst : IEnumerable<long>
{
public static readonly long[] Value=A074908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074908.Bytes);
public long this[int i]=>Value[i];

public static A074908Inst Instance=new A074908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074909
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,3L,1L,4L,6L,4L,1L,5L,10L,10L,5L,1L,6L,15L,20L,15L,6L,1L,7L,21L,35L,35L,21L,7L,1L,8L,28L,56L,70L,56L,28L,8L,1L,9L,36L,84L,126L,126L,84L,36L,9L,1L,10L,45L,120L,210L,252L,210L,120L,45L,10L,1L,11L,55L,165L,330L,462L,462L,330L,165L,55L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074909Inst : IEnumerable<long>
{
public static readonly long[] Value=A074909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074909.Bytes);
public long this[int i]=>Value[i];

public static A074909Inst Instance=new A074909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074910
{
public static readonly long[] Value={ -1L,1L,1L,0L,0L,-1L,0L,-1L,0L,0L,1L,-1L,0L,1L,1L,0L,0L,-1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,-1L,0L,1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074910Inst : IEnumerable<long>
{
public static readonly long[] Value=A074910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074910.Bytes);
public long this[int i]=>Value[i];

public static A074910Inst Instance=new A074910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074911
{
public static readonly long[] Value={ 1L,2L,2L,6L,4L,6L,24L,10L,10L,24L,120L,34L,20L,34L,120L,720L,154L,54L,54L,154L,720L,5040L,874L,208L,108L,208L,874L,5040L,40320L,5914L,1082L,316L,316L,1082L,5914L,40320L,362880L,46234L,6996L,1398L,632L,1398L,6996L,46234L,362880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074911Inst : IEnumerable<long>
{
public static readonly long[] Value=A074911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074911.Bytes);
public long this[int i]=>Value[i];

public static A074911Inst Instance=new A074911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074912
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,2L,4L,4L,2L,4L,6L,8L,6L,4L,2L,10L,14L,14L,10L,2L,6L,12L,24L,28L,24L,12L,6L,4L,18L,36L,52L,52L,36L,18L,4L,6L,22L,54L,88L,104L,88L,54L,22L,6L,4L,28L,76L,142L,192L,192L,142L,76L,28L,4L,10L,32L,104L,218L,334L,384L,334L,218L,104L,32L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074912Inst : IEnumerable<long>
{
public static readonly long[] Value=A074912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074912.Bytes);
public long this[int i]=>Value[i];

public static A074912Inst Instance=new A074912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074913
{
public static readonly long[] Value={ 0L,1L,5L,6L,10L,11L,25L,50L,60L,64L,76L,100L,101L,110L,125L,250L,275L,376L,405L,500L,501L,502L,600L,602L,625L,640L,642L,724L,726L,760L,946L,963L,976L,996L,1000L,1001L,1005L,1006L,1010L,1021L,1025L,1050L,1060L,1100L,1171L,1201L,1205L,1250L,1258L,1421L,1465L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074913Inst : IEnumerable<long>
{
public static readonly long[] Value=A074913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074913.Bytes);
public long this[int i]=>Value[i];

public static A074913Inst Instance=new A074913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074914
{
public static readonly BigInteger[] Value={ 1L,3674160L,BigInteger.Parse("43252003274489856000"),BigInteger.Parse("31180187340244394380451751732775816935095098996162560000000000"),BigInteger.Parse("55852096265861522186773299669081144244056150466856272776458775940912440274885530047848906752000000000000000000") };
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
public class A074914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074914Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A074914.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A074914.Bytes);
public BigInteger this[int i]=>Value[i];

public static A074914Inst Instance=new A074914Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074915
{
public static readonly long[] Value={ 30L,60L,90L,84L,120L,210L,50L,150L,126L,180L,132L,168L,0L,138L,240L,144L,140L,330L,420L,130L,300L,92L,390L,234L,294L,228L,360L,222L,160L,246L,0L,336L,276L,630L,510L,450L,378L,152L,480L,280L,318L,196L,342L,660L,165L,396L,172L,546L,250L,840L,504L,408L,350L,600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074915Inst : IEnumerable<long>
{
public static readonly long[] Value=A074915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074915.Bytes);
public long this[int i]=>Value[i];

public static A074915Inst Instance=new A074915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074916
{
public static readonly long[] Value={ 2L,9L,2L,9L,9L,3L,7L,2L,4L,1L,0L,2L,4L,4L,1L,9L,2L,3L,6L,9L,1L,1L,4L,6L,5L,4L,2L,7L,3L,1L,6L,0L,8L,2L,6L,9L,0L,9L,7L,7L,2L,0L,8L,2L,4L,6L,5L,3L,7L,5L,3L,2L,6L,9L,7L,9L,7L,0L,9L,5L,6L,1L,1L,0L,0L,1L,5L,9L,4L,6L,5L,1L,8L,3L,1L,9L,8L,7L,8L,2L,9L,6L,5L,9L,9L,7L,0L,8L,5L,0L,1L,9L,3L,3L,6L,4L,1L,7L,4L,7L,7L,0L,4L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074916Inst : IEnumerable<long>
{
public static readonly long[] Value=A074916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074916.Bytes);
public long this[int i]=>Value[i];

public static A074916Inst Instance=new A074916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074917
{
public static readonly long[] Value={ 0L,0L,0L,7L,7L,-5L,5L,-1L,-2L,-4L,-3L,0L,2L,2L,-6L,2L,-6L,-3L,2L,4L,-3L,0L,-2L,4L,2L,4L,-5L,1L,2L,1L,-1L,-6L,0L,0L,3L,8L,-5L,6L,-2L,0L,-7L,0L,1L,-3L,-1L,4L,-1L,-1L,1L,0L,-3L,-4L,-2L,4L,-2L,9L,6L,-7L,2L,1L,6L,1L,0L,-1L,-4L,-6L,4L,0L,-1L,0L,4L,-6L,6L,0L,-5L,7L,-1L,2L,2L,-6L,1L,2L,1L,5L,6L,-2L,-5L,2L,0L,-6L,-6L,2L,-3L,-4L,6L,-1L,-7L,-2L,2L,3L,2L,-1L,-3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074917Inst : IEnumerable<long>
{
public static readonly long[] Value=A074917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074917.Bytes);
public long this[int i]=>Value[i];

public static A074917Inst Instance=new A074917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074918
{
public static readonly long[] Value={ 1L,3L,5L,7L,11L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,120L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,180L,191L,193L,197L,199L,211L,223L,227L,229L,233L,239L,240L,269L,271L,277L,281L,283L,293L,307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074918Inst : IEnumerable<long>
{
public static readonly long[] Value=A074918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074918.Bytes);
public long this[int i]=>Value[i];

public static A074918Inst Instance=new A074918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074919
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,1L,6L,2L,4L,2L,10L,1L,12L,3L,5L,4L,16L,2L,18L,3L,7L,5L,22L,3L,16L,6L,12L,5L,28L,2L,30L,8L,13L,8L,17L,4L,36L,9L,15L,6L,40L,3L,42L,9L,13L,11L,46L,5L,36L,8L,21L,11L,52L,6L,29L,10L,23L,14L,58L,4L,60L,15L,20L,16L,36L,6L,66L,15L,29L,8L,70L,8L,72L,18L,21L,17L,47L,7L,78L,13L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074919Inst : IEnumerable<long>
{
public static readonly long[] Value=A074919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074919.Bytes);
public long this[int i]=>Value[i];

public static A074919Inst Instance=new A074919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074920
{
public static readonly long[] Value={ 1L,2L,3L,4L,33L,39L,99L,3237L,9711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074920Inst : IEnumerable<long>
{
public static readonly long[] Value=A074920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074920.Bytes);
public long this[int i]=>Value[i];

public static A074920Inst Instance=new A074920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074921
{
public static readonly long[] Value={ 0L,0L,7L,6L,5L,4L,8L,7L,5L,7L,0L,2L,1L,4L,1L,3L,7L,2L,3L,6L,9L,8L,4L,2L,3L,5L,1L,2L,0L,8L,4L,0L,0L,3L,7L,5L,5L,7L,9L,3L,0L,0L,6L,9L,3L,8L,9L,0L,9L,6L,5L,8L,3L,8L,9L,5L,3L,2L,1L,6L,0L,9L,8L,5L,4L,3L,9L,9L,0L,3L,4L,5L,9L,5L,6L,9L,2L,1L,4L,1L,2L,1L,5L,5L,7L,5L,1L,9L,3L,4L,1L,6L,6L,5L,8L,2L,8L,2L,3L,1L,8L,6L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074921Inst : IEnumerable<long>
{
public static readonly long[] Value=A074921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074921.Bytes);
public long this[int i]=>Value[i];

public static A074921Inst Instance=new A074921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074922
{
public static readonly long[] Value={ 0L,0L,0L,3L,28L,180L,990L,5005L,24024L,111384L,503880L,2238390L,9806280L,42493880L,182530530L,778439025L,3300049200L,13919756400L,58462976880L,244639718730L,1020422356200L,4244365452600L,17610393500700L,72907029092898L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074922Inst : IEnumerable<long>
{
public static readonly long[] Value=A074922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074922.Bytes);
public long this[int i]=>Value[i];

public static A074922Inst Instance=new A074922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074923
{
public static readonly long[] Value={ 1L,6L,18L,5L,5L,7L,37L,132L,29L,63L,46L,11L,7L,212L,25L,38L,145L,136L,46L,118L,39L,37L,24L,15L,19L,85L,211L,179L,249L,266L,190L,87L,259L,216L,16L,70L,210L,56L,255L,94L,143L,244L,482L,558L,46L,327L,271L,93L,110L,8L,121L,29L,421L,329L,47L,40L,394L,376L,64L,249L,49L,390L,321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074923Inst : IEnumerable<long>
{
public static readonly long[] Value=A074923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074923.Bytes);
public long this[int i]=>Value[i];

public static A074923Inst Instance=new A074923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074924
{
public static readonly long[] Value={ 6L,10L,12L,24L,42L,48L,62L,72L,84L,90L,110L,120L,122L,174L,204L,208L,220L,232L,240L,264L,306L,326L,336L,372L,386L,408L,410L,444L,454L,456L,468L,470L,474L,522L,546L,550L,594L,600L,630L,640L,642L,686L,740L,750L,762L,766L,788L,802L,852L,876L,882L,920L,936L,970L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074924Inst : IEnumerable<long>
{
public static readonly long[] Value=A074924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074924.Bytes);
public long this[int i]=>Value[i];

public static A074924Inst Instance=new A074924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074925
{
public static readonly long[] Value={ 2L,6L,28L,42L,72L,162L,174L,220L,222L,234L,246L,252L,296L,344L,380L,390L,486L,510L,584L,594L,638L,646L,674L,702L,720L,816L,828L,882L,942L,948L,990L,1044L,1056L,1146L,1200L,1314L,1422L,1436L,1554L,1566L,1596L,1602L,1632L,1740L,1770L,1778L,1806L,1818L,1824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074925Inst : IEnumerable<long>
{
public static readonly long[] Value=A074925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074925.Bytes);
public long this[int i]=>Value[i];

public static A074925Inst Instance=new A074925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074926
{
public static readonly long[] Value={ 2L,11L,18L,40L,47L,51L,74L,76L,91L,96L,97L,105L,108L,164L,185L,203L,205L,208L,227L,238L,243L,252L,271L,291L,312L,321L,349L,351L,362L,374L,392L,396L,406L,420L,438L,449L,453L,523L,529L,541L,562L,576L,590L,602L,629L,639L,641L,668L,679L,698L,711L,720L,734L,752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074926Inst : IEnumerable<long>
{
public static readonly long[] Value=A074926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074926.Bytes);
public long this[int i]=>Value[i];

public static A074926Inst Instance=new A074926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074927
{
public static readonly long[] Value={ 3L,1L,1L,4L,1L,4L,1L,4L,9L,1L,9L,4L,1L,4L,9L,9L,1L,9L,4L,1L,9L,4L,9L,16L,4L,1L,4L,1L,4L,49L,4L,9L,1L,25L,1L,9L,9L,4L,9L,9L,1L,25L,1L,4L,1L,36L,36L,4L,1L,4L,9L,1L,25L,9L,9L,9L,1L,9L,4L,1L,25L,49L,4L,1L,4L,49L,9L,25L,1L,4L,9L,16L,9L,9L,4L,9L,16L,4L,16L,25L,1L,25L,1L,9L,4L,9L,16L,4L,1L,4L,36L,16L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074927Inst : IEnumerable<long>
{
public static readonly long[] Value=A074927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074927.Bytes);
public long this[int i]=>Value[i];

public static A074927Inst Instance=new A074927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074928
{
public static readonly long[] Value={ 1L,2L,2L,2L,6L,2L,8L,2L,6L,8L,4L,6L,14L,6L,12L,10L,8L,4L,2L,6L,12L,6L,6L,8L,6L,24L,6L,14L,6L,18L,12L,10L,8L,6L,2L,12L,10L,18L,10L,4L,2L,12L,8L,18L,6L,10L,4L,6L,8L,2L,4L,2L,2L,6L,10L,6L,2L,12L,2L,8L,20L,8L,2L,24L,2L,6L,30L,14L,20L,6L,6L,6L,6L,4L,20L,4L,6L,2L,2L,12L,2L,6L,6L,6L,2L,22L,8L,32L,6L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074928Inst : IEnumerable<long>
{
public static readonly long[] Value=A074928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074928.Bytes);
public long this[int i]=>Value[i];

public static A074928Inst Instance=new A074928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074929
{
public static readonly long[] Value={ 2L,6L,10L,13L,22L,25L,34L,37L,42L,58L,58L,73L,82L,85L,90L,102L,118L,118L,133L,142L,142L,157L,162L,169L,193L,202L,205L,214L,217L,190L,253L,258L,274L,262L,298L,298L,310L,325L,330L,342L,358L,346L,382L,385L,394L,373L,397L,445L,454L,457L,462L,478L,466L,498L,510L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074929Inst : IEnumerable<long>
{
public static readonly long[] Value=A074929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074929.Bytes);
public long this[int i]=>Value[i];

public static A074929Inst Instance=new A074929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074930
{
public static readonly long[] Value={ 1L,1L,4L,12L,96L,240L,4320L,20160L,241920L,1451520L,36288000L,159667200L,5748019200L,37362124800L,697426329600L,10461394944000L,334764638208000L,2134124568576000L,115242726703104000L,973160803270656000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074930Inst : IEnumerable<long>
{
public static readonly long[] Value=A074930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074930.Bytes);
public long this[int i]=>Value[i];

public static A074930Inst Instance=new A074930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074931
{
public static readonly long[] Value={ 3L,5L,17L,29L,41L,71L,149L,281L,317L,347L,359L,397L,647L,751L,787L,857L,907L,1093L,1279L,1381L,1511L,1531L,1663L,1783L,2447L,2683L,2803L,3271L,3323L,4019L,4153L,4513L,4567L,4639L,5557L,5647L,5801L,5923L,6599L,6659L,6911L,7013L,7573L,7883L,9187L,9257L,9431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074931Inst : IEnumerable<long>
{
public static readonly long[] Value=A074931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074931.Bytes);
public long this[int i]=>Value[i];

public static A074931Inst Instance=new A074931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074932
{
public static readonly BigInteger[] Value={ 1L,3L,18L,170L,2200L,36232L,725200L,17095248L,463936896L,14246942336L,488428297984L,18491942300416L,766293946203136L,34498781924766720L,1676731077272217600L,BigInteger.Parse("87501958444207351808"),BigInteger.Parse("4880017252828686155776") };
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
public class A074932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074932Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A074932.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A074932.Bytes);
public BigInteger this[int i]=>Value[i];

public static A074932Inst Instance=new A074932Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074933
{
public static readonly long[] Value={ 2L,2L,6L,8L,26L,21L,110L,128L,342L,410L,1862L,1365L,7562L,7022L,17477L,32768L,123362L,87381L,496694L,419430L,1198373L,1906502L,8023886L,5592405L,26843546L,30973322L,89478486L,115043767L,518358122L,286331153L,2078209982L,2147483648L,5206020966L,8084644322L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074933Inst : IEnumerable<long>
{
public static readonly long[] Value=A074933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074933.Bytes);
public long this[int i]=>Value[i];

public static A074933Inst Instance=new A074933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074934
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,3L,12L,11L,23L,22L,81L,48L,216L,162L,325L,494L,1504L,861L,3961L,2706L,6256L,8051L,27412L,15456L,60020L,56028L,130946L,136205L,496497L,221878L,1302841L,1089155L,2136108L,2683712L,6327404L,4976784L,23504904L,18515449L,38920607L,40933662L,161541601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074934Inst : IEnumerable<long>
{
public static readonly long[] Value=A074934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074934.Bytes);
public long this[int i]=>Value[i];

public static A074934Inst Instance=new A074934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074935
{
public static readonly BigInteger[] Value={ 1L,1L,2L,2L,3L,24L,200L,6675L,3045936L,46360115600L,251445391554623475L,BigInteger.Parse("23318100352452485482468409184") };
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
public class A074935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074935Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A074935.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A074935.Bytes);
public BigInteger this[int i]=>Value[i];

public static A074935Inst Instance=new A074935Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074936
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,3L,0L,0L,1L,0L,3L,0L,1L,1L,1L,1L,1L,4L,0L,3L,2L,2L,1L,0L,0L,1L,4L,2L,4L,1L,2L,2L,3L,0L,1L,6L,1L,1L,0L,6L,2L,7L,3L,1L,4L,1L,1L,2L,8L,3L,1L,0L,1L,1L,6L,1L,1L,9L,1L,5L,0L,5L,4L,1L,3L,0L,5L,1L,0L,10L,1L,3L,2L,12L,11L,2L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074936Inst : IEnumerable<long>
{
public static readonly long[] Value=A074936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074936.Bytes);
public long this[int i]=>Value[i];

public static A074936Inst Instance=new A074936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074937
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074937Inst : IEnumerable<long>
{
public static readonly long[] Value=A074937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074937.Bytes);
public long this[int i]=>Value[i];

public static A074937Inst Instance=new A074937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074938
{
public static readonly long[] Value={ 1L,3L,9L,13L,27L,31L,37L,39L,81L,85L,91L,93L,109L,111L,117L,121L,243L,247L,253L,255L,271L,273L,279L,283L,325L,327L,333L,337L,351L,355L,361L,363L,729L,733L,739L,741L,757L,759L,765L,769L,811L,813L,819L,823L,837L,841L,847L,849L,973L,975L,981L,985L,999L,1003L,1009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074938Inst : IEnumerable<long>
{
public static readonly long[] Value=A074938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074938.Bytes);
public long this[int i]=>Value[i];

public static A074938Inst Instance=new A074938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074939
{
public static readonly long[] Value={ 0L,4L,10L,12L,28L,30L,36L,40L,82L,84L,90L,94L,108L,112L,118L,120L,244L,246L,252L,256L,270L,274L,280L,282L,324L,328L,334L,336L,352L,354L,360L,364L,730L,732L,738L,742L,756L,760L,766L,768L,810L,814L,820L,822L,838L,840L,846L,850L,972L,976L,982L,984L,1000L,1002L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074939Inst : IEnumerable<long>
{
public static readonly long[] Value=A074939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074939.Bytes);
public long this[int i]=>Value[i];

public static A074939Inst Instance=new A074939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074940
{
public static readonly long[] Value={ 2L,5L,6L,7L,8L,11L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,29L,32L,33L,34L,35L,38L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,83L,86L,87L,88L,89L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074940Inst : IEnumerable<long>
{
public static readonly long[] Value=A074940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074940.Bytes);
public long this[int i]=>Value[i];

public static A074940Inst Instance=new A074940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074941
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,0L,2L,0L,1L,0L,0L,1L,2L,0L,0L,1L,0L,0L,2L,0L,2L,0L,0L,0L,1L,0L,1L,2L,0L,0L,2L,0L,0L,0L,0L,1L,2L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L,1L,0L,0L,0L,2L,0L,0L,0L,0L,2L,0L,0L,0L,2L,0L,2L,1L,0L,0L,2L,0L,0L,0L,0L,0L,2L,0L,1L,2L,0L,0L,2L,0L,1L,0L,0L,2L,0L,0L,0L,0L,0L,0L,1L,0L,2L,0L,0L,0L,2L,0L,0L,1L,0L,0L,2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074941Inst : IEnumerable<long>
{
public static readonly long[] Value=A074941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074941.Bytes);
public long this[int i]=>Value[i];

public static A074941Inst Instance=new A074941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074942
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,2L,0L,1L,0L,1L,1L,1L,0L,0L,2L,2L,1L,0L,0L,2L,0L,1L,1L,2L,2L,0L,0L,0L,1L,2L,0L,1L,2L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,2L,0L,1L,1L,1L,0L,2L,2L,0L,1L,0L,1L,0L,0L,1L,1L,1L,0L,0L,0L,2L,0L,2L,0L,2L,2L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,2L,0L,1L,1L,0L,1L,0L,2L,1L,1L,0L,0L,2L,0L,1L,0L,2L,0L,0L,0L,1L,1L,2L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074942Inst : IEnumerable<long>
{
public static readonly long[] Value=A074942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074942.Bytes);
public long this[int i]=>Value[i];

public static A074942Inst Instance=new A074942Inst();

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