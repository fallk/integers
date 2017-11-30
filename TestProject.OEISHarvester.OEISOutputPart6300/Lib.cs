using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A189167
{
public static readonly long[] Value={ 4L,6L,9L,10L,13L,14L,18L,19L,20L,24L,25L,26L,27L,32L,33L,34L,36L,40L,42L,43L,44L,46L,48L,51L,53L,55L,56L,58L,60L,64L,66L,68L,69L,70L,72L,74L,78L,81L,83L,84L,85L,87L,88L,90L,94L,97L,99L,100L,101L,102L,104L,105L,107L,112L,115L,117L,118L,119L,120L,121L,123L,124L,126L,132L,135L,137L,138L,139L,140L,141L,144L,145L,147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189167Inst : IEnumerable<long>
{
public static readonly long[] Value=A189167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189167.Bytes);
public long this[int i]=>Value[i];

public static A189167Inst Instance=new A189167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189166
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189166Inst : IEnumerable<long>
{
public static readonly long[] Value=A189166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189166.Bytes);
public long this[int i]=>Value[i];

public static A189166Inst Instance=new A189166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189165
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,10L,11L,15L,16L,17L,20L,22L,23L,25L,28L,31L,32L,34L,35L,38L,41L,42L,43L,45L,46L,50L,53L,54L,55L,56L,58L,59L,64L,67L,68L,69L,70L,73L,74L,79L,80L,83L,84L,85L,86L,89L,91L,96L,97L,99L,101L,102L,103L,104L,107L,109L,110L,115L,116L,118L,121L,122L,123L,124L,127L,129L,130L,132L,136L,137L,139L,142L,144L,145L,146L,149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189165Inst : IEnumerable<long>
{
public static readonly long[] Value=A189165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189165.Bytes);
public long this[int i]=>Value[i];

public static A189165Inst Instance=new A189165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189164
{
public static readonly long[] Value={ 3L,5L,8L,9L,12L,13L,14L,18L,19L,21L,24L,26L,27L,29L,30L,33L,36L,37L,39L,40L,44L,47L,48L,49L,51L,52L,57L,60L,61L,62L,63L,65L,66L,71L,72L,75L,76L,77L,78L,81L,82L,87L,88L,90L,92L,93L,94L,95L,98L,100L,105L,106L,108L,111L,112L,113L,114L,117L,119L,120L,125L,126L,128L,131L,133L,134L,135L,138L,140L,141L,143L,147L,148L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189164Inst : IEnumerable<long>
{
public static readonly long[] Value=A189164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189164.Bytes);
public long this[int i]=>Value[i];

public static A189164Inst Instance=new A189164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189147
{
public static readonly BigInteger[] Value={ 1L,16L,569L,22865L,602565L,20037184L,697391125L,23675552985L,795238713880L,26951220352400L,913977071210296L,30940515859900745L,1047262588533673413L,BigInteger.Parse("35458251391751991872"),BigInteger.Parse("1200493587874267680981"),BigInteger.Parse("40641478966775581618385") };
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
public class A189147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189147Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189147.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189147.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189147Inst Instance=new A189147Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189146
{
public static readonly long[] Value={ 1L,4L,49L,569L,4372L,42689L,412189L,3988132L,38271921L,375573977L,3665309372L,35872284105L,350949375581L,3439343559628L,33682318930233L,330021363385529L,3233215326749252L,31680809629578289L,310402921706993341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189146Inst : IEnumerable<long>
{
public static readonly long[] Value=A189146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189146.Bytes);
public long this[int i]=>Value[i];

public static A189146Inst Instance=new A189146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189145
{
public static readonly long[] Value={ 1L,1L,4L,16L,36L,81L,225L,625L,1600L,4096L,10816L,28561L,74529L,194481L,509796L,1336336L,3496900L,9150625L,23961025L,62742241L,164249856L,429981696L,1125736704L,2947295521L,7716041281L,20200652641L,52886200900L,138458410000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189145Inst : IEnumerable<long>
{
public static readonly long[] Value=A189145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189145.Bytes);
public long this[int i]=>Value[i];

public static A189145Inst Instance=new A189145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189144
{
public static readonly long[] Value={ 0L,1L,2L,6L,6L,66L,66L,858L,858L,429L,572L,9724L,2652L,50388L,3876L,3876L,42636L,245157L,28842L,48070L,32890L,296010L,296010L,780390L,33930L,525915L,841464L,712008L,1344904L,1344904L,139128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189144Inst : IEnumerable<long>
{
public static readonly long[] Value=A189144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189144.Bytes);
public long this[int i]=>Value[i];

public static A189144Inst Instance=new A189144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189143
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,10L,11L,12L,15L,19L,21L,22L,25L,26L,27L,29L,30L,31L,34L,35L,37L,40L,46L,47L,48L,51L,54L,55L,57L,58L,60L,62L,63L,67L,68L,69L,72L,73L,74L,77L,79L,81L,84L,87L,88L,90L,94L,95L,97L,100L,101L,102L,103L,105L,108L,109L,111L,112L,113L,115L,116L,119L,121L,122L,123L,126L,127L,129L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189143Inst : IEnumerable<long>
{
public static readonly long[] Value=A189143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189143.Bytes);
public long this[int i]=>Value[i];

public static A189143Inst Instance=new A189143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189142
{
public static readonly long[] Value={ 4L,6L,7L,9L,13L,14L,16L,17L,18L,20L,23L,24L,28L,32L,33L,36L,38L,39L,41L,42L,43L,44L,45L,49L,50L,52L,53L,56L,59L,61L,64L,65L,66L,70L,71L,75L,76L,78L,80L,82L,83L,85L,86L,89L,91L,92L,93L,96L,98L,99L,104L,106L,107L,110L,114L,117L,118L,120L,124L,125L,128L,131L,132L,133L,134L,135L,137L,138L,142L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189142Inst : IEnumerable<long>
{
public static readonly long[] Value=A189142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189142.Bytes);
public long this[int i]=>Value[i];

public static A189142Inst Instance=new A189142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189141
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189141Inst : IEnumerable<long>
{
public static readonly long[] Value=A189141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189141.Bytes);
public long this[int i]=>Value[i];

public static A189141Inst Instance=new A189141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189140
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,9L,13L,14L,15L,17L,20L,22L,23L,25L,26L,29L,32L,33L,35L,36L,40L,43L,44L,45L,47L,48L,53L,56L,57L,58L,59L,61L,62L,65L,68L,71L,72L,74L,75L,77L,78L,81L,82L,85L,88L,89L,92L,93L,95L,96L,99L,100L,104L,107L,108L,111L,112L,113L,115L,116L,119L,120L,125L,128L,129L,132L,133L,134L,135L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189140Inst : IEnumerable<long>
{
public static readonly long[] Value=A189140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189140.Bytes);
public long this[int i]=>Value[i];

public static A189140Inst Instance=new A189140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189139
{
public static readonly long[] Value={ 3L,6L,7L,10L,11L,12L,16L,18L,19L,21L,24L,27L,28L,30L,31L,34L,37L,38L,39L,41L,42L,46L,49L,50L,51L,52L,54L,55L,60L,63L,64L,66L,67L,69L,70L,73L,76L,79L,80L,83L,84L,86L,87L,90L,91L,94L,97L,98L,101L,102L,103L,105L,106L,109L,110L,114L,117L,118L,121L,122L,123L,124L,126L,127L,130L,131L,136L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189139Inst : IEnumerable<long>
{
public static readonly long[] Value=A189139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189139.Bytes);
public long this[int i]=>Value[i];

public static A189139Inst Instance=new A189139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189138
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189138Inst : IEnumerable<long>
{
public static readonly long[] Value=A189138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189138.Bytes);
public long this[int i]=>Value[i];

public static A189138Inst Instance=new A189138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189137
{
public static readonly long[] Value={ 2L,3L,6L,7L,8L,12L,14L,15L,17L,20L,23L,24L,26L,27L,30L,31L,34L,35L,38L,39L,42L,43L,44L,47L,48L,52L,53L,56L,57L,58L,59L,62L,63L,68L,69L,72L,74L,75L,76L,79L,80L,82L,86L,87L,90L,93L,94L,95L,98L,99L,101L,102L,106L,107L,110L,114L,115L,116L,119L,120L,122L,123L,124L,128L,129L,132L,133L,137L,138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189137Inst : IEnumerable<long>
{
public static readonly long[] Value=A189137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189137.Bytes);
public long this[int i]=>Value[i];

public static A189137Inst Instance=new A189137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189136
{
public static readonly long[] Value={ 1L,4L,5L,9L,10L,11L,13L,16L,18L,19L,21L,22L,25L,28L,29L,32L,33L,36L,37L,40L,41L,45L,46L,49L,50L,51L,54L,55L,60L,61L,64L,65L,66L,67L,70L,71L,73L,77L,78L,81L,83L,84L,85L,88L,89L,91L,92L,96L,97L,100L,103L,104L,105L,108L,109L,111L,112L,113L,117L,118L,121L,125L,126L,127L,130L,131L,134L,135L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189136Inst : IEnumerable<long>
{
public static readonly long[] Value=A189136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189136.Bytes);
public long this[int i]=>Value[i];

public static A189136Inst Instance=new A189136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189135
{
public static readonly long[] Value={ 0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189135Inst : IEnumerable<long>
{
public static readonly long[] Value=A189135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189135.Bytes);
public long this[int i]=>Value[i];

public static A189135Inst Instance=new A189135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189134
{
public static readonly long[] Value={ 2L,4L,5L,8L,9L,13L,14L,15L,19L,20L,21L,22L,27L,28L,29L,30L,31L,37L,38L,39L,40L,42L,47L,49L,50L,51L,52L,54L,60L,62L,63L,64L,65L,66L,68L,71L,75L,77L,78L,80L,81L,82L,84L,87L,89L,92L,94L,95L,97L,99L,100L,102L,105L,107L,111L,113L,114L,116L,118L,119L,120L,122L,125L,127L,132L,134L,135L,137L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189134Inst : IEnumerable<long>
{
public static readonly long[] Value=A189134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189134.Bytes);
public long this[int i]=>Value[i];

public static A189134Inst Instance=new A189134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189133
{
public static readonly long[] Value={ 1L,3L,6L,7L,10L,11L,12L,16L,17L,18L,23L,24L,25L,26L,32L,33L,34L,35L,36L,41L,43L,44L,45L,46L,48L,53L,55L,56L,57L,58L,59L,61L,67L,69L,70L,72L,73L,74L,76L,79L,83L,85L,86L,88L,90L,91L,93L,96L,98L,101L,103L,104L,106L,108L,109L,110L,112L,115L,117L,121L,123L,124L,126L,128L,129L,130L,131L,133L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189133Inst : IEnumerable<long>
{
public static readonly long[] Value=A189133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189133.Bytes);
public long this[int i]=>Value[i];

public static A189133Inst Instance=new A189133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189132
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189132Inst : IEnumerable<long>
{
public static readonly long[] Value=A189132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189132.Bytes);
public long this[int i]=>Value[i];

public static A189132Inst Instance=new A189132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189115
{
public static readonly BigInteger[] Value={ 128L,16384L,560576L,15523600L,517260800L,17821182016L,627097603968L,22130551393344L,782902797760512L,27684523288142224L,979181286315623424L,BigInteger.Parse("34633463507690629696"),BigInteger.Parse("1225144244665652118400"),BigInteger.Parse("43339688182078063297600") };
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
public class A189115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189115Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189115.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189115.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189115Inst Instance=new A189115Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189114
{
public static readonly BigInteger[] Value={ 64L,4096L,92416L,1806336L,40933920L,953574400L,22468298160L,528558080400L,12437474748000L,292662724182544L,6888092451855392L,162124220068110400L,3816130637166767376L,BigInteger.Parse("89826192310472231056"),BigInteger.Parse("2114403310781324271072") };
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
public class A189114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189114Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189114.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189114.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189114Inst Instance=new A189114Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189113
{
public static readonly long[] Value={ 32L,1024L,15200L,207936L,3179520L,49561600L,769236480L,11893211136L,184082644992L,2851396977664L,44168388925440L,684087791325184L,10595270714362880L,164105309987946496L,2541771994561622016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189113Inst : IEnumerable<long>
{
public static readonly long[] Value=A189113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189113.Bytes);
public long this[int i]=>Value[i];

public static A189113Inst Instance=new A189113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189112
{
public static readonly long[] Value={ 16L,256L,2500L,23716L,244000L,2515396L,25632120L,261145600L,2666353032L,27225000000L,277880546592L,2836273647376L,28951429945824L,295523742166416L,3016539755776512L,30791138713921600L,314299439838498016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189112Inst : IEnumerable<long>
{
public static readonly long[] Value=A189112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189112.Bytes);
public long this[int i]=>Value[i];

public static A189112Inst Instance=new A189112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189111
{
public static readonly long[] Value={ 2L,4L,4L,8L,16L,8L,16L,64L,64L,16L,32L,256L,400L,256L,32L,64L,1024L,2500L,2500L,1024L,64L,128L,4096L,16100L,23716L,15200L,4096L,128L,256L,16384L,103684L,244000L,207936L,92416L,16384L,256L,512L,65536L,665252L,2515396L,3179520L,1806336L,560576L,65536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189111Inst : IEnumerable<long>
{
public static readonly long[] Value=A189111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189111.Bytes);
public long this[int i]=>Value[i];

public static A189111Inst Instance=new A189111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189110
{
public static readonly BigInteger[] Value={ 256L,65536L,4268356L,261145600L,11893211136L,528558080400L,22130551393344L,924914073760000L,38163372856070400L,1575803798648857600L,BigInteger.Parse("64883183651376983104"),BigInteger.Parse("2672414140466223019584"),BigInteger.Parse("109997999795439724960000") };
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
public class A189110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189110Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189110.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189110.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189110Inst Instance=new A189110Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189109
{
public static readonly BigInteger[] Value={ 128L,16384L,665252L,25632120L,769236480L,22468298160L,627097603968L,17473826493152L,482087112157728L,13294185807417600L,365852404291876320L,10068572483569131520UL,BigInteger.Parse("276973418745622264384"),BigInteger.Parse("7619301201253558633344") };
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
public class A189109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189109Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189109.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189109.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189109Inst Instance=new A189109Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189108
{
public static readonly BigInteger[] Value={ 64L,4096L,103684L,2515396L,49561600L,953574400L,17821182016L,332070977536L,6138818896896L,113361334648384L,2090692589224464L,38552909380706704L,710693511096960000L,13100455249871650816UL,BigInteger.Parse("241471801824194480400") };
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
public class A189108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189108Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189108.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189108.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189108Inst Instance=new A189108Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189107
{
public static readonly long[] Value={ 32L,1024L,16100L,244000L,3179520L,40933920L,517260800L,6517280000L,81726092800L,1024109836800L,12826537035520L,160624165956800L,2011162282778880L,25180836076195200L,315273592407560960L,3947322476903728000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189107Inst : IEnumerable<long>
{
public static readonly long[] Value=A189107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189107.Bytes);
public long this[int i]=>Value[i];

public static A189107Inst Instance=new A189107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189106
{
public static readonly long[] Value={ 16L,256L,2500L,23716L,207936L,1806336L,15523600L,133079296L,1138927504L,9743269264L,83333832976L,712693900944L,6094953689616L,52123490515600L,445753532991376L,3812020725166096L,32599837915279504L,278788946325939856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189106Inst : IEnumerable<long>
{
public static readonly long[] Value=A189106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189106.Bytes);
public long this[int i]=>Value[i];

public static A189106Inst Instance=new A189106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189105
{
public static readonly long[] Value={ 8L,64L,400L,2500L,15200L,92416L,560576L,3400336L,20623296L,125081856L,758633088L,4601180224L,27906627456L,169256542464L,1026558406656L,6226182733824L,37762441850880L,229033113145600L,1389109506607360L,8425092751196416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189105Inst : IEnumerable<long>
{
public static readonly long[] Value=A189105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189105.Bytes);
public long this[int i]=>Value[i];

public static A189105Inst Instance=new A189105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189104
{
public static readonly BigInteger[] Value={ 2L,16L,400L,23716L,3179520L,953574400L,627097603968L,924914073760000L,3050440754161147200L,BigInteger.Parse("22736725050654514945600"),BigInteger.Parse("381669581712710598918922368"),BigInteger.Parse("14487934510226746411430441441536"),BigInteger.Parse("1241349850723840266193329456972217472") };
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
public class A189104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189104Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189104.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189104.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189104Inst Instance=new A189104Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189103
{
public static readonly BigInteger[] Value={ 0L,2L,30L,264L,7320L,30960L,1592640L,38183040L,394450560L,2238969600L,275106585600L,4038941491200L,689773321036800L,20996629900646400L,111964387062528000L,2210304446558208000L,BigInteger.Parse("642338416210563072000"),BigInteger.Parse("19249748121316737024000"),BigInteger.Parse("6980209591900198477824000") };
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
public class A189103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189103Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189103.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189103.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189103Inst Instance=new A189103Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189102
{
public static readonly long[] Value={ 1L,1L,1L,4L,4L,48L,48L,192L,1728L,34560L,34560L,414720L,414720L,2903040L,130636800L,2090188800L,2090188800L,25082265600L,25082265600L,501645312000L,31603654656000L,347640201216000L,347640201216000L,5562243219456000L,139056080486400000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189102Inst : IEnumerable<long>
{
public static readonly long[] Value=A189102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189102.Bytes);
public long this[int i]=>Value[i];

public static A189102Inst Instance=new A189102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189101
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,15L,30L,59L,115L,225L,441L,863L,1689L,3307L,6474L,12673L,24809L,48567L,95075L,186120L,364352L,713261L,1396290L,2733399L,5350944L,10475089L,20506194L,40143239L,78585017L,153839228L,301158021L,589551538L,1154115087L,2259313307L,4422866209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189101Inst : IEnumerable<long>
{
public static readonly long[] Value=A189101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189101.Bytes);
public long this[int i]=>Value[i];

public static A189101Inst Instance=new A189101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189100
{
public static readonly long[] Value={ 0L,2L,30L,66L,1830L,645L,33180L,198870L,228270L,64785L,7960260L,9738960L,1663226565L,7232635410L,857066210L,1057466410L,307311194190L,767464487790L,278292627277665L,306517823106495L,35302033071305L,147385363695570L,78207294248313230L,198777858520921680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189100Inst : IEnumerable<long>
{
public static readonly long[] Value=A189100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189100.Bytes);
public long this[int i]=>Value[i];

public static A189100Inst Instance=new A189100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189051
{
public static readonly long[] Value={ 9L,15L,21L,309L,441L,1611L,2955L,3081L,3879L,5529L,7209L,7755L,7875L,13761L,15015L,15729L,16659L,21561L,22155L,35595L,37059L,38199L,45291L,50049L,51429L,59619L,63855L,67215L,67941L,71331L,72891L,83061L,96459L,96909L,102795L,106959L,111495L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189051Inst : IEnumerable<long>
{
public static readonly long[] Value=A189051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189051.Bytes);
public long this[int i]=>Value[i];

public static A189051Inst Instance=new A189051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189050
{
public static readonly long[] Value={ 3L,1L,7L,3L,17L,7L,41L,17L,99L,41L,239L,99L,577L,239L,1393L,577L,3363L,1393L,8119L,3363L,19601L,8119L,47321L,19601L,114243L,47321L,275807L,114243L,665857L,275807L,1607521L,665857L,3880899L,1607521L,9369319L,3880899L,22619537L,9369319L,54608393L,22619537L,131836323L,54608393L,318281039L,131836323L,768398401L,318281039L,1855077841L,768398401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189050Inst : IEnumerable<long>
{
public static readonly long[] Value=A189050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189050.Bytes);
public long this[int i]=>Value[i];

public static A189050Inst Instance=new A189050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189049
{
public static readonly long[] Value={ 24L,24L,960L,160L,8064L,896L,30720L,4608L,337920L,22528L,67092480L,106496L,688128L,491520L,267386880L,2228224L,1882718208L,9961472L,3460300800L,44040192L,6366953472L,192937984L,549621596160L,838860800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189049Inst : IEnumerable<long>
{
public static readonly long[] Value=A189049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189049.Bytes);
public long this[int i]=>Value[i];

public static A189049Inst Instance=new A189049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189048
{
public static readonly long[] Value={ 1L,-1L,23L,-1L,-11L,-1L,143L,-1L,-2527L,-1L,1416533L,-1L,-57341L,-1L,118522111L,-1L,-5749735025L,-1L,91546452133L,-1L,-1792043646907L,-1L,1982765704676693L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189048Inst : IEnumerable<long>
{
public static readonly long[] Value=A189048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189048.Bytes);
public long this[int i]=>Value[i];

public static A189048Inst Instance=new A189048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189047
{
public static readonly long[] Value={ 9L,10L,26L,33L,65L,82L,122L,129L,145L,217L,226L,362L,485L,626L,785L,842L,901L,1157L,1226L,1522L,1765L,1937L,2026L,2049L,2117L,2305L,2402L,2501L,2602L,2705L,3365L,3482L,3601L,3722L,3845L,4097L,4226L,4762L,5042L,5777L,5833L,6085L,6242L,6401L,7226L,7397L,7745L,8193L,8465L,9026L,9217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189047Inst : IEnumerable<long>
{
public static readonly long[] Value=A189047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189047.Bytes);
public long this[int i]=>Value[i];

public static A189047Inst Instance=new A189047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189046
{
public static readonly long[] Value={ 0L,1L,7L,14L,42L,42L,462L,462L,858L,3003L,1001L,4004L,6188L,18564L,27132L,3876L,27132L,74613L,100947L,67298L,17710L,230230L,296010L,188370L,237510L,118755L,736281L,453096L,553784L,1344904L,324632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189046Inst : IEnumerable<long>
{
public static readonly long[] Value=A189046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189046.Bytes);
public long this[int i]=>Value[i];

public static A189046Inst Instance=new A189046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189045
{
public static readonly long[] Value={ 15L,26L,35L,143L,215L,323L,511L,899L,1727L,1763L,2047L,2186L,2743L,3599L,5183L,7999L,10403L,11663L,13823L,19043L,22499L,32399L,36863L,39203L,51983L,54871L,57599L,72899L,79523L,97343L,121103L,157463L,176399L,186623L,213443L,238327L,248831L,272483L,279935L,324899L,359999L,381923L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189045Inst : IEnumerable<long>
{
public static readonly long[] Value=A189045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189045.Bytes);
public long this[int i]=>Value[i];

public static A189045Inst Instance=new A189045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189044
{
public static readonly long[] Value={ 3L,5L,9L,4L,3L,3L,0L,0L,3L,8L,1L,0L,2L,7L,7L,0L,8L,9L,1L,4L,6L,5L,4L,5L,3L,8L,7L,4L,4L,8L,2L,2L,0L,0L,1L,2L,2L,5L,5L,2L,6L,2L,9L,2L,1L,6L,1L,8L,7L,6L,6L,5L,1L,6L,4L,4L,1L,0L,1L,1L,6L,0L,8L,1L,8L,9L,6L,4L,8L,4L,8L,6L,4L,4L,7L,7L,3L,9L,0L,7L,2L,1L,2L,1L,5L,9L,2L,3L,3L,2L,4L,6L,3L,0L,4L,9L,1L,8L,0L,3L,3L,9L,2L,4L,9L,3L,5L,2L,9L,4L,0L,5L,0L,2L,8L,8L,4L,0L,9L,2L,6L,2L,3L,0L,9L,2L,3L,9L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189044Inst : IEnumerable<long>
{
public static readonly long[] Value=A189044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189044.Bytes);
public long this[int i]=>Value[i];

public static A189044Inst Instance=new A189044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189043
{
public static readonly long[] Value={ 1L,2L,6L,23L,89L,232L,437L,747L,1191L,1806L,2631L,3709L,5087L,6816L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189043Inst : IEnumerable<long>
{
public static readonly long[] Value=A189043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189043.Bytes);
public long this[int i]=>Value[i];

public static A189043Inst Instance=new A189043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189042
{
public static readonly long[] Value={ 4L,3L,8L,6L,7L,1L,4L,5L,5L,3L,4L,8L,5L,3L,2L,6L,0L,8L,7L,5L,8L,2L,7L,0L,5L,9L,4L,4L,3L,6L,4L,8L,9L,1L,3L,5L,4L,5L,7L,0L,3L,8L,6L,5L,7L,4L,7L,1L,4L,3L,9L,4L,3L,6L,7L,4L,8L,8L,7L,5L,5L,6L,1L,0L,1L,7L,0L,8L,8L,7L,6L,8L,1L,7L,5L,1L,8L,0L,7L,8L,5L,4L,4L,7L,0L,4L,5L,3L,4L,2L,1L,1L,1L,8L,4L,6L,4L,8L,2L,8L,1L,0L,3L,0L,9L,6L,8L,6L,0L,0L,5L,0L,4L,3L,7L,1L,7L,4L,8L,2L,3L,1L,6L,1L,1L,2L,2L,1L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189042Inst : IEnumerable<long>
{
public static readonly long[] Value=A189042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189042.Bytes);
public long this[int i]=>Value[i];

public static A189042Inst Instance=new A189042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189041
{
public static readonly long[] Value={ 2L,3L,1L,1L,2L,1L,3L,2L,1L,1L,2L,2L,1L,3L,3L,2L,1L,1L,1L,2L,23L,1L,1L,2L,33L,1L,1L,3L,1L,1L,20L,5L,40L,1L,3L,1L,25L,1L,2L,1L,26L,1L,6L,3L,1L,5L,5L,7L,1L,24L,5L,14L,1L,1L,2L,1L,8L,2L,1L,1L,10L,1L,1L,2L,1L,2L,2L,1440L,2L,17L,1L,1L,3L,4L,1L,18L,2L,1L,1L,1L,8L,1L,5L,1L,4L,18L,1L,3L,5L,1L,24L,3L,4L,1L,1L,4L,4L,1L,137L,3L,1L,1L,1L,6L,1L,1L,7L,1L,1L,2L,6L,1L,1L,5L,1L,2L,5L,7L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189041Inst : IEnumerable<long>
{
public static readonly long[] Value=A189041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189041.Bytes);
public long this[int i]=>Value[i];

public static A189041Inst Instance=new A189041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189040
{
public static readonly long[] Value={ 2L,2L,7L,9L,6L,1L,0L,3L,7L,3L,1L,1L,0L,5L,1L,2L,6L,2L,6L,6L,0L,2L,0L,1L,6L,8L,7L,6L,9L,1L,6L,1L,7L,3L,3L,6L,2L,3L,0L,0L,2L,0L,8L,4L,3L,6L,2L,2L,8L,5L,2L,0L,1L,3L,8L,2L,1L,8L,0L,9L,2L,0L,6L,6L,7L,0L,6L,9L,8L,7L,8L,6L,2L,1L,7L,8L,3L,6L,6L,8L,0L,9L,1L,2L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189040Inst : IEnumerable<long>
{
public static readonly long[] Value=A189040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189040.Bytes);
public long this[int i]=>Value[i];

public static A189040Inst Instance=new A189040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189039
{
public static readonly long[] Value={ 2L,7L,8L,2L,1L,5L,9L,6L,4L,9L,7L,7L,9L,5L,1L,6L,1L,4L,9L,3L,1L,6L,0L,9L,7L,9L,9L,5L,8L,3L,1L,2L,8L,2L,8L,7L,1L,9L,4L,1L,9L,0L,6L,4L,7L,7L,7L,5L,6L,3L,3L,9L,3L,0L,4L,5L,3L,3L,9L,3L,2L,9L,8L,4L,1L,1L,8L,1L,6L,7L,9L,1L,9L,8L,3L,8L,4L,6L,9L,9L,2L,6L,5L,0L,6L,4L,4L,2L,4L,9L,2L,8L,7L,9L,0L,6L,7L,8L,8L,7L,6L,4L,2L,8L,9L,8L,7L,3L,3L,5L,7L,2L,7L,7L,9L,4L,2L,2L,5L,5L,4L,4L,7L,0L,7L,5L,2L,2L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189039Inst : IEnumerable<long>
{
public static readonly long[] Value=A189039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189039.Bytes);
public long this[int i]=>Value[i];

public static A189039Inst Instance=new A189039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189038
{
public static readonly long[] Value={ 1L,6L,4L,0L,3L,8L,8L,2L,0L,3L,2L,0L,2L,2L,0L,7L,5L,6L,8L,7L,2L,7L,6L,7L,6L,2L,3L,1L,9L,9L,6L,7L,5L,9L,6L,2L,8L,1L,4L,3L,3L,9L,9L,9L,0L,3L,1L,7L,1L,7L,0L,2L,5L,5L,4L,2L,9L,9L,8L,2L,9L,1L,9L,6L,6L,3L,6L,8L,6L,9L,2L,9L,3L,2L,9L,2L,2L,0L,2L,6L,9L,9L,1L,9L,8L,4L,8L,2L,9L,5L,6L,3L,5L,1L,3L,3L,5L,5L,3L,7L,0L,8L,5L,5L,6L,8L,0L,0L,5L,1L,1L,7L,4L,0L,1L,7L,6L,7L,7L,0L,1L,9L,1L,2L,6L,7L,7L,6L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189038Inst : IEnumerable<long>
{
public static readonly long[] Value=A189038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189038.Bytes);
public long this[int i]=>Value[i];

public static A189038Inst Instance=new A189038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189037
{
public static readonly long[] Value={ 6L,0L,9L,6L,1L,1L,7L,9L,6L,7L,9L,7L,7L,9L,2L,4L,3L,1L,2L,7L,2L,3L,2L,3L,7L,6L,8L,0L,0L,3L,2L,4L,0L,3L,7L,1L,8L,5L,6L,6L,0L,0L,0L,9L,6L,8L,2L,8L,2L,9L,7L,4L,4L,5L,7L,0L,0L,1L,7L,0L,8L,0L,3L,3L,6L,3L,1L,3L,0L,7L,0L,6L,7L,0L,7L,7L,9L,7L,3L,0L,0L,8L,0L,1L,5L,1L,7L,0L,4L,3L,6L,4L,8L,6L,6L,4L,4L,6L,2L,9L,1L,4L,4L,3L,1L,9L,9L,4L,8L,8L,2L,5L,9L,8L,2L,3L,2L,2L,9L,8L,0L,8L,7L,3L,2L,2L,3L,9L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189037Inst : IEnumerable<long>
{
public static readonly long[] Value=A189037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189037.Bytes);
public long this[int i]=>Value[i];

public static A189037Inst Instance=new A189037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189036
{
public static readonly long[] Value={ 0L,2L,3L,1L,5L,30L,7L,6L,6L,70L,11L,12L,13L,126L,120L,2L,17L,42L,19L,30L,210L,286L,23L,66L,10L,390L,1L,56L,29L,930L,31L,10L,462L,646L,420L,15L,37L,798L,624L,170L,41L,1722L,43L,132L,195L,1150L,47L,21L,14L,90L,1020L,182L,53L,6L,880L,322L,1254L,1798L,59L,345L,61L,2046L,357L,3L,1170L,4026L,67L,306L,1794L,4130L,71L,78L,73L,2886L,165L,380L,1386L,5538L,79L,55L,12L,3526L,83L,651L,1870L,3870L,2784L,770L,89L,1230L,1820L,552L,3162L,4606L,2280L,102L,97L,154L,825L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189036Inst : IEnumerable<long>
{
public static readonly long[] Value=A189036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189036.Bytes);
public long this[int i]=>Value[i];

public static A189036Inst Instance=new A189036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188875
{
public static readonly long[] Value={ 8L,64L,316L,1901L,11332L,65656L,385700L,2262261L,13249261L,77665756L,455194656L,2667688716L,15634970127L,91633239536L,537041598796L,3147488927460L,18446758005813L,108112489924349L,633624215112740L,3713535944800748L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188875Inst : IEnumerable<long>
{
public static readonly long[] Value=A188875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188875.Bytes);
public long this[int i]=>Value[i];

public static A188875Inst Instance=new A188875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188874
{
public static readonly long[] Value={ 2L,4L,4L,7L,16L,8L,13L,49L,64L,16L,24L,169L,316L,256L,32L,44L,576L,1901L,2032L,1024L,64L,81L,1936L,11332L,21937L,13045L,4096L,128L,149L,6561L,65656L,233756L,252932L,83737L,16384L,256L,274L,22201L,385700L,2368612L,4805140L,2915832L,537496L,65536L,512L,504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188874Inst : IEnumerable<long>
{
public static readonly long[] Value=A188874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188874.Bytes);
public long this[int i]=>Value[i];

public static A188874Inst Instance=new A188874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188873
{
public static readonly BigInteger[] Value={ 149L,22201L,2262261L,255014376L,28472229080L,3172528318064L,353870576831949L,39466951597153578L,4401980606077836328L,BigInteger.Parse("490982507284484648264"),BigInteger.Parse("54762582428023608619232"),BigInteger.Parse("6108042623254502635317933") };
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
public class A188873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188873Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188873.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188873.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188873Inst Instance=new A188873Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188872
{
public static readonly BigInteger[] Value={ 81L,6561L,385700L,24609576L,1558668181L,98523889293L,6231989402196L,394199392835388L,24934537275160193L,1577208767277367193L,BigInteger.Parse("99764749430808100292"),BigInteger.Parse("6310518350640206463960"),BigInteger.Parse("399165473341720336437009") };
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
public class A188872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188872Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188872.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188872.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188872Inst Instance=new A188872Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188871
{
public static readonly BigInteger[] Value={ 44L,1936L,65656L,2368612L,84965120L,3043939392L,109002398784L,3903192037184L,139764515932928L,5004636736643072L,179204127483438080L,6416872410001742848L,BigInteger.Parse("229772891432953663488"),BigInteger.Parse("8227619010998404489216"),BigInteger.Parse("294611405650426832932864") };
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
public class A188871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188871Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188871.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188871.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188871Inst Instance=new A188871Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188870
{
public static readonly BigInteger[] Value={ 24L,576L,11332L,233756L,4805140L,98892196L,2035428944L,41894114820L,862288002496L,17748103310980L,365301608074080L,7518846739068100L,154757206783943744L,3185301402740998148L,BigInteger.Parse("65561696535791184736") };
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
public class A188870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188870Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188870.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188870.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188870Inst Instance=new A188870Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188869
{
public static readonly long[] Value={ 13L,169L,1901L,21937L,252932L,2915832L,33617513L,387583973L,4468546833L,51518943080L,593974176396L,6848069915941L,78953031067801L,910268322443949L,10494700553747032L,120995905270195676L,1394990644771317341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188869Inst : IEnumerable<long>
{
public static readonly long[] Value=A188869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188869.Bytes);
public long this[int i]=>Value[i];

public static A188869Inst Instance=new A188869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188868
{
public static readonly long[] Value={ 7L,49L,316L,2032L,13045L,83737L,537496L,3450100L,22145617L,142149013L,912430732L,5856740200L,37593435373L,241305971377L,1548902653984L,9942146967292L,63816977822953L,409630502531629L,2629349654724052L,16877355480293296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188868Inst : IEnumerable<long>
{
public static readonly long[] Value=A188868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188868.Bytes);
public long this[int i]=>Value[i];

public static A188868Inst Instance=new A188868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188867
{
public static readonly BigInteger[] Value={ 2L,16L,316L,21937L,4805140L,3043939392L,6231989402196L,39466951597153578L,BigInteger.Parse("765738615267315132042"),BigInteger.Parse("46457365071065953602984688"),BigInteger.Parse("8729291812408997804314294504336"),BigInteger.Parse("5077761520250192263227063403337912870") };
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
public class A188867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188867Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188867.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188867.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188867Inst Instance=new A188867Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188866
{
public static readonly long[] Value={ 2L,4L,3L,8L,7L,4L,16L,17L,10L,5L,32L,41L,26L,13L,6L,64L,99L,68L,35L,16L,7L,128L,239L,178L,95L,44L,19L,8L,256L,577L,466L,259L,122L,53L,22L,9L,512L,1393L,1220L,707L,340L,149L,62L,25L,10L,1024L,3363L,3194L,1931L,950L,421L,176L,71L,28L,11L,2048L,8119L,8362L,5275L,2658L,1193L,502L,203L,80L,31L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188866Inst : IEnumerable<long>
{
public static readonly long[] Value=A188866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188866.Bytes);
public long this[int i]=>Value[i];

public static A188866Inst Instance=new A188866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188865
{
public static readonly long[] Value={ 256L,1393L,3194L,5275L,7442L,9627L,11814L,14001L,16188L,18375L,20562L,22749L,24936L,27123L,29310L,31497L,33684L,35871L,38058L,40245L,42432L,44619L,46806L,48993L,51180L,53367L,55554L,57741L,59928L,62115L,64302L,66489L,68676L,70863L,73050L,75237L,77424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188865Inst : IEnumerable<long>
{
public static readonly long[] Value=A188865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188865.Bytes);
public long this[int i]=>Value[i];

public static A188865Inst Instance=new A188865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188864
{
public static readonly long[] Value={ 128L,577L,1220L,1931L,2658L,3387L,4116L,4845L,5574L,6303L,7032L,7761L,8490L,9219L,9948L,10677L,11406L,12135L,12864L,13593L,14322L,15051L,15780L,16509L,17238L,17967L,18696L,19425L,20154L,20883L,21612L,22341L,23070L,23799L,24528L,25257L,25986L,26715L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188864Inst : IEnumerable<long>
{
public static readonly long[] Value=A188864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188864.Bytes);
public long this[int i]=>Value[i];

public static A188864Inst Instance=new A188864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188863
{
public static readonly long[] Value={ 64L,239L,466L,707L,950L,1193L,1436L,1679L,1922L,2165L,2408L,2651L,2894L,3137L,3380L,3623L,3866L,4109L,4352L,4595L,4838L,5081L,5324L,5567L,5810L,6053L,6296L,6539L,6782L,7025L,7268L,7511L,7754L,7997L,8240L,8483L,8726L,8969L,9212L,9455L,9698L,9941L,10184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188863Inst : IEnumerable<long>
{
public static readonly long[] Value=A188863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188863.Bytes);
public long this[int i]=>Value[i];

public static A188863Inst Instance=new A188863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188862
{
public static readonly long[] Value={ 32L,99L,178L,259L,340L,421L,502L,583L,664L,745L,826L,907L,988L,1069L,1150L,1231L,1312L,1393L,1474L,1555L,1636L,1717L,1798L,1879L,1960L,2041L,2122L,2203L,2284L,2365L,2446L,2527L,2608L,2689L,2770L,2851L,2932L,3013L,3094L,3175L,3256L,3337L,3418L,3499L,3580L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188862Inst : IEnumerable<long>
{
public static readonly long[] Value=A188862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188862.Bytes);
public long this[int i]=>Value[i];

public static A188862Inst Instance=new A188862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188861
{
public static readonly long[] Value={ 16L,41L,68L,95L,122L,149L,176L,203L,230L,257L,284L,311L,338L,365L,392L,419L,446L,473L,500L,527L,554L,581L,608L,635L,662L,689L,716L,743L,770L,797L,824L,851L,878L,905L,932L,959L,986L,1013L,1040L,1067L,1094L,1121L,1148L,1175L,1202L,1229L,1256L,1283L,1310L,1337L,1364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188861Inst : IEnumerable<long>
{
public static readonly long[] Value=A188861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188861.Bytes);
public long this[int i]=>Value[i];

public static A188861Inst Instance=new A188861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188860
{
public static readonly long[] Value={ 1L,2L,7L,26L,95L,340L,1193L,4116L,14001L,47064L,156629L,516844L,1693073L,5511218L,17841247L,57477542L,184377699L,589195584L,1876395357L,5957318820L,18861068265L,59563612974L,187668462027L,590039959434L,1851508693479L,5799494052414L,18135645594003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188860Inst : IEnumerable<long>
{
public static readonly long[] Value=A188860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188860.Bytes);
public long this[int i]=>Value[i];

public static A188860Inst Instance=new A188860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188843
{
public static readonly long[] Value={ 2L,4L,3L,8L,8L,4L,16L,21L,13L,5L,32L,55L,40L,19L,6L,64L,144L,121L,66L,26L,7L,128L,377L,364L,221L,100L,34L,8L,256L,987L,1093L,728L,364L,143L,43L,9L,512L,2584L,3280L,2380L,1288L,560L,196L,53L,10L,1024L,6765L,9841L,7753L,4488L,2108L,820L,260L,64L,11L,2048L,17711L,29524L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188843Inst : IEnumerable<long>
{
public static readonly long[] Value=A188843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188843.Bytes);
public long this[int i]=>Value[i];

public static A188843Inst Instance=new A188843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188842
{
public static readonly long[] Value={ 256L,2584L,9841L,25213L,53296L,100947L,177859L,297275L,476905L,740025L,1116765L,1645605L,2375100L,3365856L,4692780L,6447628L,8741876L,11709940L,15512772L,20341860L,26423661L,34024497L,43455945L,55080753L,69319315L,86656739L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188842Inst : IEnumerable<long>
{
public static readonly long[] Value=A188842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188842.Bytes);
public long this[int i]=>Value[i];

public static A188842Inst Instance=new A188842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188841
{
public static readonly long[] Value={ 128L,987L,3280L,7753L,15504L,28101L,47652L,76912L,119416L,179630L,263120L,376740L,528840L,729495L,990756L,1326924L,1754848L,2294248L,2968064L,3802832L,4829088L,6081801L,7600836L,9431448L,11624808L,14238562L,17337424L,20993804L,25288472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188841Inst : IEnumerable<long>
{
public static readonly long[] Value=A188841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188841.Bytes);
public long this[int i]=>Value[i];

public static A188841Inst Instance=new A188841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188840
{
public static readonly long[] Value={ 64L,377L,1093L,2380L,4488L,7752L,12597L,19551L,29260L,42504L,60214L,83490L,113620L,152100L,200655L,261261L,336168L,427924L,539400L,673816L,834768L,1026256L,1252713L,1519035L,1830612L,2193360L,2613754L,3098862L,3656380L,4294668L,5022787L,5850537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188840Inst : IEnumerable<long>
{
public static readonly long[] Value=A188840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188840.Bytes);
public long this[int i]=>Value[i];

public static A188840Inst Instance=new A188840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188839
{
public static readonly long[] Value={ 32L,144L,364L,728L,1288L,2108L,3264L,4845L,6954L,9709L,13244L,17710L,23276L,30130L,38480L,48555L,60606L,74907L,91756L,111476L,134416L,160952L,191488L,226457L,266322L,311577L,362748L,420394L,485108L,557518L,638288L,728119L,827750L,937959L,1059564L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188839Inst : IEnumerable<long>
{
public static readonly long[] Value=A188839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188839.Bytes);
public long this[int i]=>Value[i];

public static A188839Inst Instance=new A188839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188838
{
public static readonly long[] Value={ 16L,55L,121L,221L,364L,560L,820L,1156L,1581L,2109L,2755L,3535L,4466L,5566L,6854L,8350L,10075L,12051L,14301L,16849L,19720L,22940L,26536L,30536L,34969L,39865L,45255L,51171L,57646L,64714L,72410L,80770L,89831L,99631L,110209L,121605L,133860L,147016L,161116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188838Inst : IEnumerable<long>
{
public static readonly long[] Value=A188838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188838.Bytes);
public long this[int i]=>Value[i];

public static A188838Inst Instance=new A188838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188837
{
public static readonly long[] Value={ 106L,966L,128L,4895L,903L,270L,17608L,3442L,3190L,449L,50755L,10259L,20224L,4875L,797L,125368L,23790L,89650L,25633L,13278L,1061L,275175L,48875L,306279L,100789L,107353L,16083L,1681L,553211L,91096L,877068L,285899L,575344L,108025L,40626L,2285L,1033069L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188837Inst : IEnumerable<long>
{
public static readonly long[] Value=A188837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188837.Bytes);
public long this[int i]=>Value[i];

public static A188837Inst Instance=new A188837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188836
{
public static readonly long[] Value={ 4L,9L,25L,49L,121L,169L,289L,361L,625L,841L,961L,1369L,1681L,1849L,3721L,4489L,5041L,5329L,7921L,9409L,10201L,10609L,11881L,12769L,16129L,17161L,18769L,19321L,22201L,22801L,24649L,32761L,36481L,37249L,38809L,39601L,44521L,52441L,57121L,58081L,63001L,73441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188836Inst : IEnumerable<long>
{
public static readonly long[] Value=A188836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188836.Bytes);
public long this[int i]=>Value[i];

public static A188836Inst Instance=new A188836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188835
{
public static readonly long[] Value={ 2L,1L,0L,7L,8L,4L,0L,9L,0L,2L,6L,3L,7L,8L,5L,4L,9L,3L,8L,0L,1L,5L,7L,4L,1L,1L,8L,3L,9L,3L,5L,2L,4L,7L,0L,2L,9L,7L,1L,6L,9L,5L,8L,3L,5L,7L,4L,6L,5L,9L,3L,4L,5L,8L,2L,8L,0L,9L,4L,7L,0L,5L,3L,6L,0L,3L,2L,6L,8L,1L,3L,7L,0L,1L,0L,1L,2L,0L,1L,2L,3L,0L,5L,6L,8L,5L,9L,0L,4L,5L,5L,4L,7L,6L,9L,9L,4L,2L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188835Inst : IEnumerable<long>
{
public static readonly long[] Value=A188835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188835.Bytes);
public long this[int i]=>Value[i];

public static A188835Inst Instance=new A188835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188834
{
public static readonly long[] Value={ 3L,3L,2L,3L,3L,7L,5L,8L,9L,9L,2L,6L,7L,1L,8L,8L,2L,4L,2L,5L,9L,1L,6L,3L,7L,8L,4L,5L,4L,9L,9L,9L,0L,1L,4L,9L,9L,9L,2L,8L,8L,3L,7L,2L,7L,0L,0L,5L,0L,1L,3L,6L,4L,1L,6L,3L,7L,9L,4L,2L,2L,3L,3L,6L,0L,5L,1L,2L,1L,8L,0L,5L,9L,6L,5L,2L,7L,6L,7L,4L,5L,5L,8L,1L,6L,7L,3L,8L,3L,5L,2L,8L,2L,2L,9L,2L,2L,3L,3L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188834Inst : IEnumerable<long>
{
public static readonly long[] Value=A188834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188834.Bytes);
public long this[int i]=>Value[i];

public static A188834Inst Instance=new A188834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188833
{
public static readonly long[] Value={ 23L,47L,53L,59L,79L,83L,107L,163L,167L,173L,179L,223L,227L,233L,257L,263L,269L,277L,283L,293L,317L,347L,353L,359L,367L,373L,383L,389L,401L,431L,439L,443L,457L,467L,479L,499L,503L,509L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188833Inst : IEnumerable<long>
{
public static readonly long[] Value=A188833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188833.Bytes);
public long this[int i]=>Value[i];

public static A188833Inst Instance=new A188833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188832
{
public static readonly long[] Value={ 1L,0L,1L,3L,0L,1L,0L,12L,0L,1L,25L,0L,30L,0L,1L,0L,240L,0L,60L,0L,1L,427L,0L,1155L,0L,105L,0L,1L,0L,7616L,0L,3920L,0L,168L,0L,1L,12465L,0L,60732L,0L,10710L,0L,252L,0L,1L,0L,357120L,0L,315840L,0L,25200L,0L,360L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188832Inst : IEnumerable<long>
{
public static readonly long[] Value=A188832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188832.Bytes);
public long this[int i]=>Value[i];

public static A188832Inst Instance=new A188832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188831
{
public static readonly long[] Value={ 23L,71L,107L,263L,487L,677L,787L,1427L,1583L,2081L,3319L,5393L,8713L,10247L,11071L,12377L,18257L,20477L,24659L,26573L,29243L,29927L,33487L,34949L,37223L,37991L,41981L,51449L,60917L,64937L,66977L,71167L,83357L,85667L,99013L,100271L,109313L,110629L,118757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188831Inst : IEnumerable<long>
{
public static readonly long[] Value=A188831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188831.Bytes);
public long this[int i]=>Value[i];

public static A188831Inst Instance=new A188831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188830
{
public static readonly long[] Value={ 256L,81L,289L,1024L,3721L,13456L,49284L,179776L,660969L,2421136L,8916196L,32729841L,120604324L,443228809L,1633453056L,6007025025L,22136976225L,81441744400L,300095796100L,1104340367376L,4068797299876L,14975700324025L,55170296484241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188830Inst : IEnumerable<long>
{
public static readonly long[] Value=A188830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188830.Bytes);
public long this[int i]=>Value[i];

public static A188830Inst Instance=new A188830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188829
{
public static readonly long[] Value={ 128L,64L,224L,784L,2800L,10000L,36000L,129600L,468000L,1690000L,6110000L,22090000L,79900000L,289000000L,1045500000L,3782250000L,13683750000L,49506250000L,179112500000L,648025000000L,2344562500000L,8482656250000L,30690468750000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188829Inst : IEnumerable<long>
{
public static readonly long[] Value=A188829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188829.Bytes);
public long this[int i]=>Value[i];

public static A188829Inst Instance=new A188829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188828
{
public static readonly long[] Value={ 64L,49L,169L,576L,2025L,7056L,24964L,87616L,310249L,1092025L,3865156L,13623481L,48191364L,169989444L,601034256L,2121063025L,7496962225L,26464782400L,93519144481L,330192741376L,1166628971236L,4119600902400L,14553774833481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188828Inst : IEnumerable<long>
{
public static readonly long[] Value=A188828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188828.Bytes);
public long this[int i]=>Value[i];

public static A188828Inst Instance=new A188828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188651
{
public static readonly long[] Value={ 10L,15L,49L,121L,143L,159L,187L,235L,287L,301L,319L,329L,371L,395L,407L,471L,519L,533L,551L,565L,581L,589L,633L,679L,689L,713L,731L,749L,771L,789L,803L,817L,841L,961L,985L,1079L,1099L,1119L,1135L,1169L,1207L,1271L,1285L,1315L,1349L,1391L,1457L,1477L,1585L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188651Inst : IEnumerable<long>
{
public static readonly long[] Value=A188651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188651.Bytes);
public long this[int i]=>Value[i];

public static A188651Inst Instance=new A188651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188650
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,20L,22L,33L,40L,44L,55L,66L,77L,88L,99L,101L,110L,121L,131L,151L,181L,191L,202L,220L,242L,262L,303L,313L,353L,363L,373L,383L,393L,404L,440L,484L,505L,606L,626L,707L,727L,757L,787L,797L,808L,909L,919L,929L,939L,1010L,1111L,1331L,1441L,1661L,1991L,2020L,2222L,2662L,2882L,3333L,3443L,3883L,3993L,4040L,4444L,5555L,6666L,6886L,7777L,7997L,8888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188650Inst : IEnumerable<long>
{
public static readonly long[] Value=A188650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188650.Bytes);
public long this[int i]=>Value[i];

public static A188650Inst Instance=new A188650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188649
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,84L,31L,574L,255L,488L,71L,162L,91L,20L,84L,22L,32L,168L,260L,62L,72L,1148L,92L,510L,13L,11224L,33L,6106L,1855L,2268L,73L,15106L,93L,40L,14L,6888L,34L,44L,4590L,64L,74L,10248L,658L,260L,1065L,3100L,35L,3240L,55L,149240L,6825L,7820L,95L,7140L,16L,26L,252L,11224L,8680L,66L,76L,12212L,96L,152110L,17L,4536L,37L,6862L,251940L,2024204L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188649Inst : IEnumerable<long>
{
public static readonly long[] Value=A188649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188649.Bytes);
public long this[int i]=>Value[i];

public static A188649Inst Instance=new A188649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188648
{
public static readonly long[] Value={ 1L,2L,11L,63L,376L,2317L,14545L,92512L,594169L,3844787L,25027296L,163701327L,1075049011L,7083830648L,46812088751L,310118453573L,2058919125662L,13695571200353L,91254952276859L,608960974528058L,4069232436916151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188648Inst : IEnumerable<long>
{
public static readonly long[] Value=A188648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188648.Bytes);
public long this[int i]=>Value[i];

public static A188648Inst Instance=new A188648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188647
{
public static readonly long[] Value={ 1L,5L,1L,29L,17L,1L,169L,305L,37L,1L,985L,5473L,1405L,65L,1L,5741L,98209L,53353L,4289L,101L,1L,33461L,1762289L,2026009L,283009L,10301L,145L,1L,195025L,31622993L,76934989L,18674305L,1050601L,21169L,197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188647Inst : IEnumerable<long>
{
public static readonly long[] Value=A188647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188647.Bytes);
public long this[int i]=>Value[i];

public static A188647Inst Instance=new A188647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188646
{
public static readonly long[] Value={ 1L,1L,1L,1L,13L,1L,1L,181L,33L,1L,1L,2521L,1121L,61L,1L,1L,35113L,38081L,3781L,97L,1L,1L,489061L,1293633L,234361L,9505L,141L,1L,1L,6811741L,43945441L,14526601L,931393L,20021L,193L,1L,1L,94875313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188646Inst : IEnumerable<long>
{
public static readonly long[] Value=A188646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188646.Bytes);
public long this[int i]=>Value[i];

public static A188646Inst Instance=new A188646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188645
{
public static readonly long[] Value={ 1L,3L,1L,17L,9L,1L,99L,161L,19L,1L,577L,2889L,721L,33L,1L,3363L,51841L,27379L,2177L,51L,1L,19601L,930249L,1039681L,143649L,5201L,73L,1L,114243L,16692641L,39480499L,9478657L,530451L,10657L,99L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188645Inst : IEnumerable<long>
{
public static readonly long[] Value=A188645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188645.Bytes);
public long this[int i]=>Value[i];

public static A188645Inst Instance=new A188645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188644
{
public static readonly long[] Value={ 1L,1L,1L,1L,7L,1L,1L,97L,17L,1L,1L,1351L,577L,31L,1L,1L,18817L,19601L,1921L,49L,1L,1L,262087L,665857L,119071L,4801L,71L,1L,1L,3650401L,22619537L,7380481L,470449L,10081L,97L,1L,1L,50843527L,768398401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188644Inst : IEnumerable<long>
{
public static readonly long[] Value=A188644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188644.Bytes);
public long this[int i]=>Value[i];

public static A188644Inst Instance=new A188644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188643
{
public static readonly long[] Value={ 10L,13L,14L,16L,17L,18L,19L,20L,21L,22L,23L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,91L,92L,93L,94L,95L,96L,97L,98L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188643Inst : IEnumerable<long>
{
public static readonly long[] Value=A188643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188643.Bytes);
public long this[int i]=>Value[i];

public static A188643Inst Instance=new A188643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188642
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188642Inst : IEnumerable<long>
{
public static readonly long[] Value=A188642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188642.Bytes);
public long this[int i]=>Value[i];

public static A188642Inst Instance=new A188642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188641
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188641Inst : IEnumerable<long>
{
public static readonly long[] Value=A188641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188641.Bytes);
public long this[int i]=>Value[i];

public static A188641Inst Instance=new A188641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188640
{
public static readonly long[] Value={ 5L,6L,1L,4L,6L,6L,8L,5L,6L,0L,0L,4L,9L,0L,5L,3L,4L,3L,9L,2L,5L,4L,7L,8L,2L,8L,3L,3L,1L,8L,6L,3L,3L,7L,3L,6L,0L,2L,3L,9L,8L,2L,0L,5L,6L,4L,1L,7L,1L,1L,3L,3L,9L,9L,6L,3L,2L,0L,4L,7L,8L,1L,4L,6L,4L,7L,2L,9L,3L,9L,2L,5L,6L,4L,2L,3L,9L,0L,0L,2L,6L,5L,0L,9L,8L,0L,4L,8L,4L,2L,8L,5L,5L,3L,4L,1L,5L,3L,5L,1L,3L,3L,7L,3L,7L,6L,0L,7L,6L,8L,8L,0L,8L,7L,8L,3L,3L,6L,0L,7L,7L,0L,0L,4L,0L,1L,8L,2L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188640Inst : IEnumerable<long>
{
public static readonly long[] Value=A188640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188640.Bytes);
public long this[int i]=>Value[i];

public static A188640Inst Instance=new A188640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188639
{
public static readonly long[] Value={ 3L,0L,5L,8L,9L,5L,9L,3L,6L,6L,9L,9L,2L,8L,2L,0L,4L,5L,4L,0L,7L,0L,0L,1L,9L,2L,0L,2L,9L,0L,8L,5L,3L,2L,4L,0L,6L,5L,3L,0L,5L,0L,5L,7L,5L,2L,5L,1L,9L,5L,6L,6L,7L,8L,1L,0L,9L,7L,3L,3L,0L,8L,8L,1L,3L,8L,8L,0L,0L,6L,0L,8L,5L,7L,5L,6L,5L,5L,6L,7L,6L,4L,1L,3L,3L,3L,5L,6L,2L,4L,7L,1L,7L,5L,2L,1L,0L,8L,6L,1L,9L,5L,7L,8L,3L,3L,0L,9L,9L,1L,5L,4L,1L,6L,2L,9L,3L,8L,5L,4L,4L,6L,5L,4L,4L,7L,6L,0L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188639Inst : IEnumerable<long>
{
public static readonly long[] Value=A188639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188639.Bytes);
public long this[int i]=>Value[i];

public static A188639Inst Instance=new A188639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188638
{
public static readonly long[] Value={ 1L,8L,9L,4L,0L,0L,6L,6L,5L,3L,5L,4L,7L,6L,8L,0L,5L,9L,0L,9L,4L,2L,4L,3L,8L,0L,7L,8L,8L,8L,2L,0L,5L,6L,3L,7L,8L,1L,9L,0L,4L,9L,6L,4L,5L,8L,8L,3L,9L,4L,2L,7L,3L,9L,2L,2L,1L,6L,6L,4L,2L,2L,4L,1L,9L,3L,4L,5L,2L,8L,7L,0L,8L,7L,1L,5L,9L,9L,8L,7L,0L,4L,4L,8L,1L,9L,9L,1L,1L,9L,9L,9L,9L,8L,6L,0L,3L,0L,2L,2L,8L,9L,4L,7L,8L,0L,6L,6L,4L,1L,8L,6L,7L,6L,6L,7L,1L,8L,6L,4L,5L,1L,1L,1L,2L,9L,3L,7L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188638Inst : IEnumerable<long>
{
public static readonly long[] Value=A188638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188638.Bytes);
public long this[int i]=>Value[i];

public static A188638Inst Instance=new A188638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188637
{
public static readonly long[] Value={ 2L,1L,3L,2L,3L,2L,7L,1L,1L,114L,11L,1L,2L,1L,18L,2L,1L,1L,1L,3L,15L,3L,2L,2L,6L,1L,1L,1L,1L,1L,2L,2L,200L,5L,176L,3L,3L,2L,1L,4L,3L,2L,1L,1L,5L,3L,2L,1L,2L,225L,2L,9L,1L,34L,1L,2L,3L,29L,2L,1L,9L,1L,2L,1L,73L,4L,2L,1L,8L,1L,2L,1L,21L,4L,2L,3L,1L,5L,1L,1L,2L,8L,1L,1L,2L,2L,2L,10L,3L,1L,6L,1L,21L,4L,9L,3L,1L,1L,4L,2L,28L,4L,5L,3L,3L,1L,1L,1L,3L,1L,1L,2L,2L,1L,4L,4L,8L,15L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188637Inst : IEnumerable<long>
{
public static readonly long[] Value=A188637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188637.Bytes);
public long this[int i]=>Value[i];

public static A188637Inst Instance=new A188637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188636
{
public static readonly long[] Value={ 2L,7L,7L,4L,6L,2L,2L,8L,9L,9L,5L,0L,4L,4L,8L,9L,2L,6L,3L,1L,9L,8L,2L,4L,9L,6L,3L,7L,9L,1L,9L,4L,7L,7L,5L,5L,4L,6L,6L,5L,5L,1L,0L,3L,3L,6L,5L,2L,8L,2L,0L,8L,1L,8L,7L,3L,4L,9L,5L,1L,3L,3L,9L,2L,9L,6L,5L,9L,8L,4L,1L,0L,4L,5L,2L,8L,3L,9L,2L,6L,6L,1L,8L,6L,4L,7L,1L,2L,8L,2L,0L,8L,9L,9L,5L,0L,5L,2L,0L,5L,9L,6L,5L,7L,2L,1L,2L,9L,0L,9L,4L,9L,2L,5L,1L,3L,9L,0L,2L,4L,7L,6L,0L,8L,3L,9L,2L,3L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188636Inst : IEnumerable<long>
{
public static readonly long[] Value=A188636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188636.Bytes);
public long this[int i]=>Value[i];

public static A188636Inst Instance=new A188636Inst();

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