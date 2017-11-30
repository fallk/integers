using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A070299
{
public static readonly long[] Value={ 19L,23L,26L,31L,34L,38L,40L,41L,49L,52L,53L,55L,61L,63L,68L,69L,73L,74L,75L,76L,80L,82L,83L,85L,91L,96L,101L,103L,104L,106L,110L,112L,113L,117L,122L,123L,126L,130L,131L,133L,136L,145L,146L,147L,148L,149L,151L,152L,155L,156L,157L,158L,160L,161L,162L,163L,164L,166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070299Inst : IEnumerable<long>
{
public static readonly long[] Value=A070299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070299.Bytes);
public long this[int i]=>Value[i];

public static A070299Inst Instance=new A070299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070300
{
public static readonly long[] Value={ 4L,7L,10L,13L,16L,19L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070300Inst : IEnumerable<long>
{
public static readonly long[] Value=A070300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070300.Bytes);
public long this[int i]=>Value[i];

public static A070300Inst Instance=new A070300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070301
{
public static readonly long[] Value={ 1L,2L,3L,6L,7L,30L,32L,48L,50L,51L,54L,57L,61L,62L,65L,66L,73L,76L,79L,81L,89L,96L,99L,102L,103L,104L,107L,108L,148L,154L,163L,164L,165L,166L,167L,171L,175L,178L,179L,213L,223L,229L,230L,232L,240L,242L,244L,256L,265L,268L,274L,284L,310L,315L,338L,340L,348L,354L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070301Inst : IEnumerable<long>
{
public static readonly long[] Value=A070301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070301.Bytes);
public long this[int i]=>Value[i];

public static A070301Inst Instance=new A070301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070302
{
public static readonly long[] Value={ 1L,19L,121L,439L,1171L,2581L,4999L,8821L,14509L,22591L,33661L,48379L,67471L,91729L,122011L,159241L,204409L,258571L,322849L,398431L,486571L,588589L,705871L,839869L,992101L,1164151L,1357669L,1574371L,1816039L,2084521L,2381731L,2709649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070302Inst : IEnumerable<long>
{
public static readonly long[] Value=A070302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070302.Bytes);
public long this[int i]=>Value[i];

public static A070302Inst Instance=new A070302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070303
{
public static readonly long[] Value={ 3L,7L,11L,13L,19L,23L,29L,31L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,199L,211L,223L,227L,229L,233L,239L,241L,251L,263L,269L,271L,277L,281L,283L,293L,307L,311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070303Inst : IEnumerable<long>
{
public static readonly long[] Value=A070303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070303.Bytes);
public long this[int i]=>Value[i];

public static A070303Inst Instance=new A070303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070304
{
public static readonly long[] Value={ 1L,2L,1L,2L,2L,2L,1L,2L,1L,6L,1L,2L,1L,2L,3L,2L,2L,2L,1L,7L,1L,2L,1L,2L,2L,4L,1L,2L,1L,8L,1L,2L,1L,3L,2L,2L,2L,2L,2L,7L,1L,2L,1L,2L,3L,2L,1L,2L,1L,7L,2L,4L,1L,2L,2L,2L,1L,4L,1L,9L,1L,2L,1L,2L,5L,2L,1L,4L,1L,7L,1L,2L,1L,3L,3L,2L,1L,5L,1L,7L,1L,3L,1L,2L,4L,2L,1L,2L,1L,8L,1L,2L,1L,2L,2L,2L,1L,2L,1L,8L,2L,4L,1L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070304Inst : IEnumerable<long>
{
public static readonly long[] Value=A070304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070304.Bytes);
public long this[int i]=>Value[i];

public static A070304Inst Instance=new A070304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070305
{
public static readonly long[] Value={ 2L,4L,8L,10L,11L,14L,16L,23L,27L,28L,29L,31L,32L,38L,47L,53L,59L,64L,67L,71L,79L,83L,86L,100L,103L,107L,114L,125L,127L,128L,131L,136L,137L,139L,147L,149L,151L,167L,170L,172L,173L,176L,179L,191L,197L,199L,202L,211L,223L,227L,229L,235L,239L,251L,256L,263L,265L,269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070305Inst : IEnumerable<long>
{
public static readonly long[] Value=A070305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070305.Bytes);
public long this[int i]=>Value[i];

public static A070305Inst Instance=new A070305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070306
{
public static readonly long[] Value={ 1L,2L,2L,4L,1L,6L,4L,6L,2L,10L,2L,12L,3L,4L,8L,16L,3L,18L,4L,6L,5L,22L,4L,20L,6L,18L,6L,28L,2L,30L,16L,10L,8L,12L,6L,36L,9L,12L,8L,40L,3L,42L,10L,12L,11L,46L,8L,42L,10L,16L,12L,52L,9L,20L,12L,18L,14L,58L,4L,60L,15L,18L,32L,24L,5L,66L,16L,22L,6L,70L,12L,72L,18L,20L,18L,30L,6L,78L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070306Inst : IEnumerable<long>
{
public static readonly long[] Value=A070306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070306.Bytes);
public long this[int i]=>Value[i];

public static A070306Inst Instance=new A070306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070307
{
public static readonly BigInteger[] Value={ 1L,16L,1000L,160000L,52521875L,30840979456L,29509034655744L,42998169600000000L,BigInteger.Parse("90647430472564453125"),BigInteger.Parse("265599227914240000000000"),BigInteger.Parse("1047192117300356121695451136"),BigInteger.Parse("5410240907043328777415185924096"),BigInteger.Parse("35821862005173382840059779052734375"),BigInteger.Parse("298285661929377847941529600000000000000") };
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
public class A070307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070307Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A070307.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A070307.Bytes);
public BigInteger this[int i]=>Value[i];

public static A070307Inst Instance=new A070307Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070308
{
public static readonly long[] Value={ 125L,581L,8549L,16999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070308Inst : IEnumerable<long>
{
public static readonly long[] Value=A070308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070308.Bytes);
public long this[int i]=>Value[i];

public static A070308Inst Instance=new A070308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070309
{
public static readonly long[] Value={ 1L,1L,3L,2L,1L,3L,1L,7L,5L,7L,2L,1L,7L,4L,1L,8L,3L,3L,15L,1L,11L,1L,2L,15L,11L,3L,2L,1L,15L,6L,9L,7L,17L,4L,7L,2L,1L,15L,1L,8L,31L,3L,7L,3L,23L,1L,4L,3L,11L,31L,26L,1L,23L,1L,7L,11L,3L,2L,1L,31L,13L,2L,39L,3L,15L,2L,1L,35L,19L,2L,15L,11L,7L,8L,1L,31L,10L,1L,3L,24L,35L,63L,2L,3L,7L,1L,8L,31L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070309Inst : IEnumerable<long>
{
public static readonly long[] Value=A070309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070309.Bytes);
public long this[int i]=>Value[i];

public static A070309Inst Instance=new A070309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070310
{
public static readonly long[] Value={ 28L,652L,10828L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070310Inst : IEnumerable<long>
{
public static readonly long[] Value=A070310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070310.Bytes);
public long this[int i]=>Value[i];

public static A070310Inst Instance=new A070310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070311
{
public static readonly long[] Value={ 338L,2496L,3520L,153280L,508096L,678592L,1162432L,1461952L,2130112L,2475712L,2595520L,2959552L,3042496L,3388096L,3443392L,3581632L,3733696L,3742912L,3744873L,5713173L,9492309L,11912896L,14767353L,15009472L,18021609L,21703125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070311Inst : IEnumerable<long>
{
public static readonly long[] Value=A070311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070311.Bytes);
public long this[int i]=>Value[i];

public static A070311Inst Instance=new A070311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070312
{
public static readonly BigInteger[] Value={ 1L,1L,12L,124L,12248L,12424496L,1224824848992L,BigInteger.Parse("124244962449649697984"),BigInteger.Parse("1224824848992248489924899299395968"),BigInteger.Parse("1242449624496496979842449649697984496979849798598791936") };
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
public class A070312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070312Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A070312.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A070312.Bytes);
public BigInteger this[int i]=>Value[i];

public static A070312Inst Instance=new A070312Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070313
{
public static readonly long[] Value={ 0L,-1L,-1L,1L,7L,21L,51L,113L,239L,493L,1003L,2025L,4071L,8165L,16355L,32737L,65503L,131037L,262107L,524249L,1048535L,2097109L,4194259L,8388561L,16777167L,33554381L,67108811L,134217673L,268435399L,536870853L,1073741763L,2147483585L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070313Inst : IEnumerable<long>
{
public static readonly long[] Value=A070313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070313.Bytes);
public long this[int i]=>Value[i];

public static A070313Inst Instance=new A070313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070314
{
public static readonly BigInteger[] Value={ -1L,-2L,4L,-12L,0L,90L,28L,404L,250L,329850L,39916118L,2834088L,75021616L,3790360374L,46271010L,993974L,956666L,123610842L,1713311273189068L,117876621366L,2703875810364L,93799610095767534L,148139754734068388L,BigInteger.Parse("765041185860961083618"),BigInteger.Parse("38681321803817920155550") };
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
public class A070314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070314Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A070314.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A070314.Bytes);
public BigInteger this[int i]=>Value[i];

public static A070314Inst Instance=new A070314Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070315
{
public static readonly long[] Value={ 1L,21L,161L,813L,3361L,12421L,42865L,141549L,453905L,1426725L,4422913L,13579309L,41408833L,125667333L,380081105L,1146795693L,3454279345L,10392196645L,31238454241L,93845384301L,281808780641L,845996765061L,2539181475121L,7620027450733L,22865249731921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070315Inst : IEnumerable<long>
{
public static readonly long[] Value=A070315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070315.Bytes);
public long this[int i]=>Value[i];

public static A070315Inst Instance=new A070315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070316
{
public static readonly long[] Value={ 1L,3L,5L,11L,18L,23L,42L,63L,69L,102L,128L,143L,226L,254L,349L,370L,590L,757L,833L,873L,1110L,1165L,5018L,14908L,49495L,87598L,106359L,185179L,269697L,558269L,1070246L,1673629L,4292936L,43957056L,148793437L,982920306L,1569443693L,4556758439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070316Inst : IEnumerable<long>
{
public static readonly long[] Value=A070316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070316.Bytes);
public long this[int i]=>Value[i];

public static A070316Inst Instance=new A070316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070317
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,12L,13L,20L,22L,23L,27L,28L,33L,37L,42L,43L,49L,52L,54L,58L,71L,108L,147L,163L,202L,225L,232L,270L,292L,328L,331L,388L,541L,613L,712L,773L,780L,868L,869L,964L,993L,1024L,1045L,1065L,1083L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070317Inst : IEnumerable<long>
{
public static readonly long[] Value=A070317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070317.Bytes);
public long this[int i]=>Value[i];

public static A070317Inst Instance=new A070317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070318
{
public static readonly long[] Value={ 0L,1L,1L,3L,3L,6L,6L,7L,7L,8L,8L,16L,16L,16L,16L,16L,16L,21L,21L,22L,22L,22L,22L,36L,36L,36L,36L,36L,36L,42L,42L,42L,42L,42L,42L,55L,55L,55L,55L,55L,55L,55L,55L,55L,55L,55L,55L,76L,76L,76L,76L,76L,76L,76L,76L,76L,76L,76L,76L,108L,108L,108L,108L,108L,108L,108L,108L,108L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070318Inst : IEnumerable<long>
{
public static readonly long[] Value=A070318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070318.Bytes);
public long this[int i]=>Value[i];

public static A070318Inst Instance=new A070318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070319
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,4L,4L,4L,4L,4L,4L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070319Inst : IEnumerable<long>
{
public static readonly long[] Value=A070319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070319.Bytes);
public long this[int i]=>Value[i];

public static A070319Inst Instance=new A070319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070320
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,4L,6L,6L,6L,6L,10L,10L,12L,12L,12L,12L,16L,16L,18L,18L,18L,18L,22L,22L,22L,22L,22L,22L,28L,28L,30L,30L,30L,30L,30L,30L,36L,36L,36L,36L,40L,40L,42L,42L,42L,42L,46L,46L,46L,46L,46L,46L,52L,52L,52L,52L,52L,52L,58L,58L,60L,60L,60L,60L,60L,60L,66L,66L,66L,66L,70L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070320Inst : IEnumerable<long>
{
public static readonly long[] Value=A070320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070320.Bytes);
public long this[int i]=>Value[i];

public static A070320Inst Instance=new A070320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070321
{
public static readonly long[] Value={ 1L,2L,3L,3L,5L,6L,7L,7L,7L,10L,11L,11L,13L,14L,15L,15L,17L,17L,19L,19L,21L,22L,23L,23L,23L,26L,26L,26L,29L,30L,31L,31L,33L,34L,35L,35L,37L,38L,39L,39L,41L,42L,43L,43L,43L,46L,47L,47L,47L,47L,51L,51L,53L,53L,55L,55L,57L,58L,59L,59L,61L,62L,62L,62L,65L,66L,67L,67L,69L,70L,71L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070321Inst : IEnumerable<long>
{
public static readonly long[] Value=A070321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070321.Bytes);
public long this[int i]=>Value[i];

public static A070321Inst Instance=new A070321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070322
{
public static readonly long[] Value={ 1L,1L,3L,139L,25575L,18077431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070322Inst : IEnumerable<long>
{
public static readonly long[] Value=A070322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070322.Bytes);
public long this[int i]=>Value[i];

public static A070322Inst Instance=new A070322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070323
{
public static readonly long[] Value={ 2L,2L,4L,8L,32L,64L,256L,512L,2048L,12288L,24576L,147456L,589824L,1179648L,4718592L,28311552L,169869312L,339738624L,2038431744L,8153726976L,16307453952L,97844723712L,391378894848L,2348273369088L,18786186952704L,75144747810816L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070323Inst : IEnumerable<long>
{
public static readonly long[] Value=A070323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070323.Bytes);
public long this[int i]=>Value[i];

public static A070323Inst Instance=new A070323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070388
{
public static readonly long[] Value={ 1L,5L,25L,41L,37L,17L,1L,5L,25L,41L,37L,17L,1L,5L,25L,41L,37L,17L,1L,5L,25L,41L,37L,17L,1L,5L,25L,41L,37L,17L,1L,5L,25L,41L,37L,17L,1L,5L,25L,41L,37L,17L,1L,5L,25L,41L,37L,17L,1L,5L,25L,41L,37L,17L,1L,5L,25L,41L,37L,17L,1L,5L,25L,41L,37L,17L,1L,5L,25L,41L,37L,17L,1L,5L,25L,41L,37L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070388Inst : IEnumerable<long>
{
public static readonly long[] Value=A070388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070388.Bytes);
public long this[int i]=>Value[i];

public static A070388Inst Instance=new A070388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070389
{
public static readonly long[] Value={ 1L,5L,25L,39L,23L,29L,16L,37L,13L,22L,24L,34L,41L,33L,36L,8L,40L,28L,11L,12L,17L,42L,38L,18L,4L,20L,14L,27L,6L,30L,21L,19L,9L,2L,10L,7L,35L,3L,15L,32L,31L,26L,1L,5L,25L,39L,23L,29L,16L,37L,13L,22L,24L,34L,41L,33L,36L,8L,40L,28L,11L,12L,17L,42L,38L,18L,4L,20L,14L,27L,6L,30L,21L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070389Inst : IEnumerable<long>
{
public static readonly long[] Value=A070389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070389.Bytes);
public long this[int i]=>Value[i];

public static A070389Inst Instance=new A070389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070390
{
public static readonly long[] Value={ 1L,5L,25L,37L,9L,1L,5L,25L,37L,9L,1L,5L,25L,37L,9L,1L,5L,25L,37L,9L,1L,5L,25L,37L,9L,1L,5L,25L,37L,9L,1L,5L,25L,37L,9L,1L,5L,25L,37L,9L,1L,5L,25L,37L,9L,1L,5L,25L,37L,9L,1L,5L,25L,37L,9L,1L,5L,25L,37L,9L,1L,5L,25L,37L,9L,1L,5L,25L,37L,9L,1L,5L,25L,37L,9L,1L,5L,25L,37L,9L,1L,5L,25L,37L,9L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070390Inst : IEnumerable<long>
{
public static readonly long[] Value=A070390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070390.Bytes);
public long this[int i]=>Value[i];

public static A070390Inst Instance=new A070390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070391
{
public static readonly long[] Value={ 1L,5L,25L,33L,27L,43L,31L,17L,39L,11L,9L,45L,41L,21L,13L,19L,3L,15L,29L,7L,35L,37L,1L,5L,25L,33L,27L,43L,31L,17L,39L,11L,9L,45L,41L,21L,13L,19L,3L,15L,29L,7L,35L,37L,1L,5L,25L,33L,27L,43L,31L,17L,39L,11L,9L,45L,41L,21L,13L,19L,3L,15L,29L,7L,35L,37L,1L,5L,25L,33L,27L,43L,31L,17L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070391Inst : IEnumerable<long>
{
public static readonly long[] Value=A070391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070391.Bytes);
public long this[int i]=>Value[i];

public static A070391Inst Instance=new A070391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070392
{
public static readonly long[] Value={ 1L,6L,3L,7L,9L,10L,5L,8L,4L,2L,1L,6L,3L,7L,9L,10L,5L,8L,4L,2L,1L,6L,3L,7L,9L,10L,5L,8L,4L,2L,1L,6L,3L,7L,9L,10L,5L,8L,4L,2L,1L,6L,3L,7L,9L,10L,5L,8L,4L,2L,1L,6L,3L,7L,9L,10L,5L,8L,4L,2L,1L,6L,3L,7L,9L,10L,5L,8L,4L,2L,1L,6L,3L,7L,9L,10L,5L,8L,4L,2L,1L,6L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070392Inst : IEnumerable<long>
{
public static readonly long[] Value=A070392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070392.Bytes);
public long this[int i]=>Value[i];

public static A070392Inst Instance=new A070392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070393
{
public static readonly long[] Value={ 1L,6L,10L,8L,9L,2L,12L,7L,3L,5L,4L,11L,1L,6L,10L,8L,9L,2L,12L,7L,3L,5L,4L,11L,1L,6L,10L,8L,9L,2L,12L,7L,3L,5L,4L,11L,1L,6L,10L,8L,9L,2L,12L,7L,3L,5L,4L,11L,1L,6L,10L,8L,9L,2L,12L,7L,3L,5L,4L,11L,1L,6L,10L,8L,9L,2L,12L,7L,3L,5L,4L,11L,1L,6L,10L,8L,9L,2L,12L,7L,3L,5L,4L,11L,1L,6L,10L,8L,9L,2L,12L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070393Inst : IEnumerable<long>
{
public static readonly long[] Value=A070393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070393.Bytes);
public long this[int i]=>Value[i];

public static A070393Inst Instance=new A070393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070394
{
public static readonly long[] Value={ 1L,6L,2L,12L,4L,7L,8L,14L,16L,11L,15L,5L,13L,10L,9L,3L,1L,6L,2L,12L,4L,7L,8L,14L,16L,11L,15L,5L,13L,10L,9L,3L,1L,6L,2L,12L,4L,7L,8L,14L,16L,11L,15L,5L,13L,10L,9L,3L,1L,6L,2L,12L,4L,7L,8L,14L,16L,11L,15L,5L,13L,10L,9L,3L,1L,6L,2L,12L,4L,7L,8L,14L,16L,11L,15L,5L,13L,10L,9L,3L,1L,6L,2L,12L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070394Inst : IEnumerable<long>
{
public static readonly long[] Value=A070394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070394.Bytes);
public long this[int i]=>Value[i];

public static A070394Inst Instance=new A070394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070395
{
public static readonly long[] Value={ 1L,6L,17L,7L,4L,5L,11L,9L,16L,1L,6L,17L,7L,4L,5L,11L,9L,16L,1L,6L,17L,7L,4L,5L,11L,9L,16L,1L,6L,17L,7L,4L,5L,11L,9L,16L,1L,6L,17L,7L,4L,5L,11L,9L,16L,1L,6L,17L,7L,4L,5L,11L,9L,16L,1L,6L,17L,7L,4L,5L,11L,9L,16L,1L,6L,17L,7L,4L,5L,11L,9L,16L,1L,6L,17L,7L,4L,5L,11L,9L,16L,1L,6L,17L,7L,4L,5L,11L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070395Inst : IEnumerable<long>
{
public static readonly long[] Value=A070395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070395.Bytes);
public long this[int i]=>Value[i];

public static A070395Inst Instance=new A070395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070396
{
public static readonly long[] Value={ 1L,6L,13L,9L,8L,2L,12L,3L,18L,16L,4L,1L,6L,13L,9L,8L,2L,12L,3L,18L,16L,4L,1L,6L,13L,9L,8L,2L,12L,3L,18L,16L,4L,1L,6L,13L,9L,8L,2L,12L,3L,18L,16L,4L,1L,6L,13L,9L,8L,2L,12L,3L,18L,16L,4L,1L,6L,13L,9L,8L,2L,12L,3L,18L,16L,4L,1L,6L,13L,9L,8L,2L,12L,3L,18L,16L,4L,1L,6L,13L,9L,8L,2L,12L,3L,18L,16L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070396Inst : IEnumerable<long>
{
public static readonly long[] Value=A070396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070396.Bytes);
public long this[int i]=>Value[i];

public static A070396Inst Instance=new A070396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070397
{
public static readonly long[] Value={ 1L,6L,11L,16L,21L,1L,6L,11L,16L,21L,1L,6L,11L,16L,21L,1L,6L,11L,16L,21L,1L,6L,11L,16L,21L,1L,6L,11L,16L,21L,1L,6L,11L,16L,21L,1L,6L,11L,16L,21L,1L,6L,11L,16L,21L,1L,6L,11L,16L,21L,1L,6L,11L,16L,21L,1L,6L,11L,16L,21L,1L,6L,11L,16L,21L,1L,6L,11L,16L,21L,1L,6L,11L,16L,21L,1L,6L,11L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070397Inst : IEnumerable<long>
{
public static readonly long[] Value=A070397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070397.Bytes);
public long this[int i]=>Value[i];

public static A070397Inst Instance=new A070397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070398
{
public static readonly long[] Value={ 1L,6L,7L,13L,20L,4L,24L,28L,23L,22L,16L,9L,25L,5L,1L,6L,7L,13L,20L,4L,24L,28L,23L,22L,16L,9L,25L,5L,1L,6L,7L,13L,20L,4L,24L,28L,23L,22L,16L,9L,25L,5L,1L,6L,7L,13L,20L,4L,24L,28L,23L,22L,16L,9L,25L,5L,1L,6L,7L,13L,20L,4L,24L,28L,23L,22L,16L,9L,25L,5L,1L,6L,7L,13L,20L,4L,24L,28L,23L,22L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070398Inst : IEnumerable<long>
{
public static readonly long[] Value=A070398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070398.Bytes);
public long this[int i]=>Value[i];

public static A070398Inst Instance=new A070398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070399
{
public static readonly long[] Value={ 1L,6L,5L,30L,25L,26L,1L,6L,5L,30L,25L,26L,1L,6L,5L,30L,25L,26L,1L,6L,5L,30L,25L,26L,1L,6L,5L,30L,25L,26L,1L,6L,5L,30L,25L,26L,1L,6L,5L,30L,25L,26L,1L,6L,5L,30L,25L,26L,1L,6L,5L,30L,25L,26L,1L,6L,5L,30L,25L,26L,1L,6L,5L,30L,25L,26L,1L,6L,5L,30L,25L,26L,1L,6L,5L,30L,25L,26L,1L,6L,5L,30L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070399Inst : IEnumerable<long>
{
public static readonly long[] Value=A070399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070399.Bytes);
public long this[int i]=>Value[i];

public static A070399Inst Instance=new A070399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070400
{
public static readonly long[] Value={ 1L,6L,36L,31L,1L,6L,36L,31L,1L,6L,36L,31L,1L,6L,36L,31L,1L,6L,36L,31L,1L,6L,36L,31L,1L,6L,36L,31L,1L,6L,36L,31L,1L,6L,36L,31L,1L,6L,36L,31L,1L,6L,36L,31L,1L,6L,36L,31L,1L,6L,36L,31L,1L,6L,36L,31L,1L,6L,36L,31L,1L,6L,36L,31L,1L,6L,36L,31L,1L,6L,36L,31L,1L,6L,36L,31L,1L,6L,36L,31L,1L,6L,36L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070400Inst : IEnumerable<long>
{
public static readonly long[] Value=A070400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070400.Bytes);
public long this[int i]=>Value[i];

public static A070400Inst Instance=new A070400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070401
{
public static readonly long[] Value={ 1L,6L,36L,28L,27L,21L,32L,4L,24L,3L,18L,14L,37L,34L,16L,2L,12L,25L,9L,7L,42L,17L,8L,1L,6L,36L,28L,27L,21L,32L,4L,24L,3L,18L,14L,37L,34L,16L,2L,12L,25L,9L,7L,42L,17L,8L,1L,6L,36L,28L,27L,21L,32L,4L,24L,3L,18L,14L,37L,34L,16L,2L,12L,25L,9L,7L,42L,17L,8L,1L,6L,36L,28L,27L,21L,32L,4L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070401Inst : IEnumerable<long>
{
public static readonly long[] Value=A070401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070401.Bytes);
public long this[int i]=>Value[i];

public static A070401Inst Instance=new A070401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070402
{
public static readonly long[] Value={ 1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070402Inst : IEnumerable<long>
{
public static readonly long[] Value=A070402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070402.Bytes);
public long this[int i]=>Value[i];

public static A070402Inst Instance=new A070402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070403
{
public static readonly long[] Value={ 1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070403Inst : IEnumerable<long>
{
public static readonly long[] Value=A070403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070403.Bytes);
public long this[int i]=>Value[i];

public static A070403Inst Instance=new A070403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070404
{
public static readonly long[] Value={ 1L,7L,5L,2L,3L,10L,4L,6L,9L,8L,1L,7L,5L,2L,3L,10L,4L,6L,9L,8L,1L,7L,5L,2L,3L,10L,4L,6L,9L,8L,1L,7L,5L,2L,3L,10L,4L,6L,9L,8L,1L,7L,5L,2L,3L,10L,4L,6L,9L,8L,1L,7L,5L,2L,3L,10L,4L,6L,9L,8L,1L,7L,5L,2L,3L,10L,4L,6L,9L,8L,1L,7L,5L,2L,3L,10L,4L,6L,9L,8L,1L,7L,5L,2L,3L,10L,4L,6L,9L,8L,1L,7L,5L,2L,3L,10L,4L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070404Inst : IEnumerable<long>
{
public static readonly long[] Value=A070404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070404.Bytes);
public long this[int i]=>Value[i];

public static A070404Inst Instance=new A070404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070405
{
public static readonly long[] Value={ 1L,7L,10L,5L,9L,11L,12L,6L,3L,8L,4L,2L,1L,7L,10L,5L,9L,11L,12L,6L,3L,8L,4L,2L,1L,7L,10L,5L,9L,11L,12L,6L,3L,8L,4L,2L,1L,7L,10L,5L,9L,11L,12L,6L,3L,8L,4L,2L,1L,7L,10L,5L,9L,11L,12L,6L,3L,8L,4L,2L,1L,7L,10L,5L,9L,11L,12L,6L,3L,8L,4L,2L,1L,7L,10L,5L,9L,11L,12L,6L,3L,8L,4L,2L,1L,7L,10L,5L,9L,11L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070405Inst : IEnumerable<long>
{
public static readonly long[] Value=A070405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070405.Bytes);
public long this[int i]=>Value[i];

public static A070405Inst Instance=new A070405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070406
{
public static readonly long[] Value={ 1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070406Inst : IEnumerable<long>
{
public static readonly long[] Value=A070406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070406.Bytes);
public long this[int i]=>Value[i];

public static A070406Inst Instance=new A070406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070407
{
public static readonly long[] Value={ 1L,7L,15L,3L,4L,11L,9L,12L,16L,10L,2L,14L,13L,6L,8L,5L,1L,7L,15L,3L,4L,11L,9L,12L,16L,10L,2L,14L,13L,6L,8L,5L,1L,7L,15L,3L,4L,11L,9L,12L,16L,10L,2L,14L,13L,6L,8L,5L,1L,7L,15L,3L,4L,11L,9L,12L,16L,10L,2L,14L,13L,6L,8L,5L,1L,7L,15L,3L,4L,11L,9L,12L,16L,10L,2L,14L,13L,6L,8L,5L,1L,7L,15L,3L,4L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070407Inst : IEnumerable<long>
{
public static readonly long[] Value=A070407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070407.Bytes);
public long this[int i]=>Value[i];

public static A070407Inst Instance=new A070407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070408
{
public static readonly long[] Value={ 1L,7L,5L,13L,3L,21L,15L,17L,9L,19L,1L,7L,5L,13L,3L,21L,15L,17L,9L,19L,1L,7L,5L,13L,3L,21L,15L,17L,9L,19L,1L,7L,5L,13L,3L,21L,15L,17L,9L,19L,1L,7L,5L,13L,3L,21L,15L,17L,9L,19L,1L,7L,5L,13L,3L,21L,15L,17L,9L,19L,1L,7L,5L,13L,3L,21L,15L,17L,9L,19L,1L,7L,5L,13L,3L,21L,15L,17L,9L,19L,1L,7L,5L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070408Inst : IEnumerable<long>
{
public static readonly long[] Value=A070408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070408.Bytes);
public long this[int i]=>Value[i];

public static A070408Inst Instance=new A070408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070409
{
public static readonly long[] Value={ 1L,7L,3L,21L,9L,17L,4L,5L,12L,15L,13L,22L,16L,20L,2L,14L,6L,19L,18L,11L,8L,10L,1L,7L,3L,21L,9L,17L,4L,5L,12L,15L,13L,22L,16L,20L,2L,14L,6L,19L,18L,11L,8L,10L,1L,7L,3L,21L,9L,17L,4L,5L,12L,15L,13L,22L,16L,20L,2L,14L,6L,19L,18L,11L,8L,10L,1L,7L,3L,21L,9L,17L,4L,5L,12L,15L,13L,22L,16L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070409Inst : IEnumerable<long>
{
public static readonly long[] Value=A070409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070409.Bytes);
public long this[int i]=>Value[i];

public static A070409Inst Instance=new A070409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070410
{
public static readonly long[] Value={ 1L,7L,24L,18L,1L,7L,24L,18L,1L,7L,24L,18L,1L,7L,24L,18L,1L,7L,24L,18L,1L,7L,24L,18L,1L,7L,24L,18L,1L,7L,24L,18L,1L,7L,24L,18L,1L,7L,24L,18L,1L,7L,24L,18L,1L,7L,24L,18L,1L,7L,24L,18L,1L,7L,24L,18L,1L,7L,24L,18L,1L,7L,24L,18L,1L,7L,24L,18L,1L,7L,24L,18L,1L,7L,24L,18L,1L,7L,24L,18L,1L,7L,24L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070410Inst : IEnumerable<long>
{
public static readonly long[] Value=A070410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070410.Bytes);
public long this[int i]=>Value[i];

public static A070410Inst Instance=new A070410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070411
{
public static readonly long[] Value={ 1L,7L,23L,5L,9L,11L,25L,19L,3L,21L,17L,15L,1L,7L,23L,5L,9L,11L,25L,19L,3L,21L,17L,15L,1L,7L,23L,5L,9L,11L,25L,19L,3L,21L,17L,15L,1L,7L,23L,5L,9L,11L,25L,19L,3L,21L,17L,15L,1L,7L,23L,5L,9L,11L,25L,19L,3L,21L,17L,15L,1L,7L,23L,5L,9L,11L,25L,19L,3L,21L,17L,15L,1L,7L,23L,5L,9L,11L,25L,19L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070411Inst : IEnumerable<long>
{
public static readonly long[] Value=A070411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070411.Bytes);
public long this[int i]=>Value[i];

public static A070411Inst Instance=new A070411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070412
{
public static readonly long[] Value={ 1L,7L,22L,19L,25L,13L,10L,16L,4L,1L,7L,22L,19L,25L,13L,10L,16L,4L,1L,7L,22L,19L,25L,13L,10L,16L,4L,1L,7L,22L,19L,25L,13L,10L,16L,4L,1L,7L,22L,19L,25L,13L,10L,16L,4L,1L,7L,22L,19L,25L,13L,10L,16L,4L,1L,7L,22L,19L,25L,13L,10L,16L,4L,1L,7L,22L,19L,25L,13L,10L,16L,4L,1L,7L,22L,19L,25L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070412Inst : IEnumerable<long>
{
public static readonly long[] Value=A070412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070412.Bytes);
public long this[int i]=>Value[i];

public static A070412Inst Instance=new A070412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070413
{
public static readonly long[] Value={ 1L,7L,20L,24L,23L,16L,25L,1L,7L,20L,24L,23L,16L,25L,1L,7L,20L,24L,23L,16L,25L,1L,7L,20L,24L,23L,16L,25L,1L,7L,20L,24L,23L,16L,25L,1L,7L,20L,24L,23L,16L,25L,1L,7L,20L,24L,23L,16L,25L,1L,7L,20L,24L,23L,16L,25L,1L,7L,20L,24L,23L,16L,25L,1L,7L,20L,24L,23L,16L,25L,1L,7L,20L,24L,23L,16L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070413Inst : IEnumerable<long>
{
public static readonly long[] Value=A070413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070413.Bytes);
public long this[int i]=>Value[i];

public static A070413Inst Instance=new A070413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070414
{
public static readonly long[] Value={ 1L,7L,19L,13L,1L,7L,19L,13L,1L,7L,19L,13L,1L,7L,19L,13L,1L,7L,19L,13L,1L,7L,19L,13L,1L,7L,19L,13L,1L,7L,19L,13L,1L,7L,19L,13L,1L,7L,19L,13L,1L,7L,19L,13L,1L,7L,19L,13L,1L,7L,19L,13L,1L,7L,19L,13L,1L,7L,19L,13L,1L,7L,19L,13L,1L,7L,19L,13L,1L,7L,19L,13L,1L,7L,19L,13L,1L,7L,19L,13L,1L,7L,19L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070414Inst : IEnumerable<long>
{
public static readonly long[] Value=A070414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070414.Bytes);
public long this[int i]=>Value[i];

public static A070414Inst Instance=new A070414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070415
{
public static readonly long[] Value={ 1L,7L,18L,2L,14L,5L,4L,28L,10L,8L,25L,20L,16L,19L,9L,1L,7L,18L,2L,14L,5L,4L,28L,10L,8L,25L,20L,16L,19L,9L,1L,7L,18L,2L,14L,5L,4L,28L,10L,8L,25L,20L,16L,19L,9L,1L,7L,18L,2L,14L,5L,4L,28L,10L,8L,25L,20L,16L,19L,9L,1L,7L,18L,2L,14L,5L,4L,28L,10L,8L,25L,20L,16L,19L,9L,1L,7L,18L,2L,14L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070415Inst : IEnumerable<long>
{
public static readonly long[] Value=A070415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070415.Bytes);
public long this[int i]=>Value[i];

public static A070415Inst Instance=new A070415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070416
{
public static readonly long[] Value={ 1L,7L,17L,23L,1L,7L,17L,23L,1L,7L,17L,23L,1L,7L,17L,23L,1L,7L,17L,23L,1L,7L,17L,23L,1L,7L,17L,23L,1L,7L,17L,23L,1L,7L,17L,23L,1L,7L,17L,23L,1L,7L,17L,23L,1L,7L,17L,23L,1L,7L,17L,23L,1L,7L,17L,23L,1L,7L,17L,23L,1L,7L,17L,23L,1L,7L,17L,23L,1L,7L,17L,23L,1L,7L,17L,23L,1L,7L,17L,23L,1L,7L,17L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070416Inst : IEnumerable<long>
{
public static readonly long[] Value=A070416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070416.Bytes);
public long this[int i]=>Value[i];

public static A070416Inst Instance=new A070416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070417
{
public static readonly long[] Value={ 1L,7L,16L,13L,25L,10L,4L,28L,31L,19L,1L,7L,16L,13L,25L,10L,4L,28L,31L,19L,1L,7L,16L,13L,25L,10L,4L,28L,31L,19L,1L,7L,16L,13L,25L,10L,4L,28L,31L,19L,1L,7L,16L,13L,25L,10L,4L,28L,31L,19L,1L,7L,16L,13L,25L,10L,4L,28L,31L,19L,1L,7L,16L,13L,25L,10L,4L,28L,31L,19L,1L,7L,16L,13L,25L,10L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070417Inst : IEnumerable<long>
{
public static readonly long[] Value=A070417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070417.Bytes);
public long this[int i]=>Value[i];

public static A070417Inst Instance=new A070417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070418
{
public static readonly long[] Value={ 1L,3L,14L,15L,22L,28L,44L,46L,50L,56L,68L,70L,78L,88L,92L,94L,110L,112L,118L,166L,174L,176L,184L,188L,198L,214L,224L,228L,230L,234L,236L,255L,260L,294L,306L,318L,332L,334L,342L,352L,358L,368L,376L,414L,428L,448L,454L,462L,470L,472L,492L,500L,526L,550L,580L,590L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070418Inst : IEnumerable<long>
{
public static readonly long[] Value=A070418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070418.Bytes);
public long this[int i]=>Value[i];

public static A070418Inst Instance=new A070418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070419
{
public static readonly long[] Value={ 1L,7L,13L,19L,25L,31L,1L,7L,13L,19L,25L,31L,1L,7L,13L,19L,25L,31L,1L,7L,13L,19L,25L,31L,1L,7L,13L,19L,25L,31L,1L,7L,13L,19L,25L,31L,1L,7L,13L,19L,25L,31L,1L,7L,13L,19L,25L,31L,1L,7L,13L,19L,25L,31L,1L,7L,13L,19L,25L,31L,1L,7L,13L,19L,25L,31L,1L,7L,13L,19L,25L,31L,1L,7L,13L,19L,25L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070419Inst : IEnumerable<long>
{
public static readonly long[] Value=A070419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070419.Bytes);
public long this[int i]=>Value[i];

public static A070419Inst Instance=new A070419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070452
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,6L,19L,4L,21L,10L,1L,24L,19L,16L,15L,16L,19L,24L,1L,10L,21L,4L,19L,6L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,6L,19L,4L,21L,10L,1L,24L,19L,16L,15L,16L,19L,24L,1L,10L,21L,4L,19L,6L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,6L,19L,4L,21L,10L,1L,24L,19L,16L,15L,16L,19L,24L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070452Inst : IEnumerable<long>
{
public static readonly long[] Value=A070452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070452.Bytes);
public long this[int i]=>Value[i];

public static A070452Inst Instance=new A070452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070453
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,5L,18L,2L,19L,7L,28L,20L,14L,10L,8L,8L,10L,14L,20L,28L,7L,19L,2L,18L,5L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,5L,18L,2L,19L,7L,28L,20L,14L,10L,8L,8L,10L,14L,20L,28L,7L,19L,2L,18L,5L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,5L,18L,2L,19L,7L,28L,20L,14L,10L,8L,8L,10L,14L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070453Inst : IEnumerable<long>
{
public static readonly long[] Value=A070453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070453.Bytes);
public long this[int i]=>Value[i];

public static A070453Inst Instance=new A070453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070454
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,4L,17L,0L,17L,4L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,4L,17L,0L,17L,4L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,4L,17L,0L,17L,4L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,4L,17L,0L,17L,4L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,4L,17L,0L,17L,4L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,4L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070454Inst : IEnumerable<long>
{
public static readonly long[] Value=A070454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070454.Bytes);
public long this[int i]=>Value[i];

public static A070454Inst Instance=new A070454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070455
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,3L,16L,31L,15L,1L,22L,12L,4L,31L,27L,25L,25L,27L,31L,4L,12L,22L,1L,15L,31L,16L,3L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,3L,16L,31L,15L,1L,22L,12L,4L,31L,27L,25L,25L,27L,31L,4L,12L,22L,1L,15L,31L,16L,3L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,3L,16L,31L,15L,1L,22L,12L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070455Inst : IEnumerable<long>
{
public static readonly long[] Value=A070455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070455.Bytes);
public long this[int i]=>Value[i];

public static A070455Inst Instance=new A070455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070456
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,2L,15L,30L,13L,32L,19L,8L,33L,26L,21L,18L,17L,18L,21L,26L,33L,8L,19L,32L,13L,30L,15L,2L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,2L,15L,30L,13L,32L,19L,8L,33L,26L,21L,18L,17L,18L,21L,26L,33L,8L,19L,32L,13L,30L,15L,2L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,2L,15L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070456Inst : IEnumerable<long>
{
public static readonly long[] Value=A070456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070456.Bytes);
public long this[int i]=>Value[i];

public static A070456Inst Instance=new A070456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070457
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,1L,14L,29L,11L,30L,16L,4L,29L,21L,15L,11L,9L,9L,11L,15L,21L,29L,4L,16L,30L,11L,29L,14L,1L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,1L,14L,29L,11L,30L,16L,4L,29L,21L,15L,11L,9L,9L,11L,15L,21L,29L,4L,16L,30L,11L,29L,14L,1L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,1L,14L,29L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070457Inst : IEnumerable<long>
{
public static readonly long[] Value=A070457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070457.Bytes);
public long this[int i]=>Value[i];

public static A070457Inst Instance=new A070457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070458
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,0L,13L,28L,9L,28L,13L,0L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,0L,13L,28L,9L,28L,13L,0L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,0L,13L,28L,9L,28L,13L,0L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,0L,13L,28L,9L,28L,13L,0L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,0L,13L,28L,9L,28L,13L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070458Inst : IEnumerable<long>
{
public static readonly long[] Value=A070458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070458.Bytes);
public long this[int i]=>Value[i];

public static A070458Inst Instance=new A070458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070459
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,36L,12L,27L,7L,26L,10L,33L,21L,11L,3L,34L,30L,28L,28L,30L,34L,3L,11L,21L,33L,10L,26L,7L,27L,12L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,36L,12L,27L,7L,26L,10L,33L,21L,11L,3L,34L,30L,28L,28L,30L,34L,3L,11L,21L,33L,10L,26L,7L,27L,12L,36L,25L,16L,9L,4L,1L,0L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070459Inst : IEnumerable<long>
{
public static readonly long[] Value=A070459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070459.Bytes);
public long this[int i]=>Value[i];

public static A070459Inst Instance=new A070459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070460
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,36L,11L,26L,5L,24L,7L,30L,17L,6L,35L,28L,23L,20L,19L,20L,23L,28L,35L,6L,17L,30L,7L,24L,5L,26L,11L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,36L,11L,26L,5L,24L,7L,30L,17L,6L,35L,28L,23L,20L,19L,20L,23L,28L,35L,6L,17L,30L,7L,24L,5L,26L,11L,36L,25L,16L,9L,4L,1L,0L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070460Inst : IEnumerable<long>
{
public static readonly long[] Value=A070460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070460.Bytes);
public long this[int i]=>Value[i];

public static A070460Inst Instance=new A070460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070461
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,36L,10L,25L,3L,22L,4L,27L,13L,1L,30L,22L,16L,12L,10L,10L,12L,16L,22L,30L,1L,13L,27L,4L,22L,3L,25L,10L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,36L,10L,25L,3L,22L,4L,27L,13L,1L,30L,22L,16L,12L,10L,10L,12L,16L,22L,30L,1L,13L,27L,4L,22L,3L,25L,10L,36L,25L,16L,9L,4L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070461Inst : IEnumerable<long>
{
public static readonly long[] Value=A070461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070461.Bytes);
public long this[int i]=>Value[i];

public static A070461Inst Instance=new A070461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070462
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,36L,9L,24L,1L,20L,1L,24L,9L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,36L,9L,24L,1L,20L,1L,24L,9L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,36L,9L,24L,1L,20L,1L,24L,9L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,36L,9L,24L,1L,20L,1L,24L,9L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070462Inst : IEnumerable<long>
{
public static readonly long[] Value=A070462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070462.Bytes);
public long this[int i]=>Value[i];

public static A070462Inst Instance=new A070462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070463
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,36L,8L,23L,40L,18L,39L,21L,5L,32L,20L,10L,2L,37L,33L,31L,31L,33L,37L,2L,10L,20L,32L,5L,21L,39L,18L,40L,23L,8L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,36L,8L,23L,40L,18L,39L,21L,5L,32L,20L,10L,2L,37L,33L,31L,31L,33L,37L,2L,10L,20L,32L,5L,21L,39L,18L,40L,23L,8L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070463Inst : IEnumerable<long>
{
public static readonly long[] Value=A070463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070463.Bytes);
public long this[int i]=>Value[i];

public static A070463Inst Instance=new A070463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070464
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,36L,7L,22L,39L,16L,37L,18L,1L,28L,15L,4L,37L,30L,25L,22L,21L,22L,25L,30L,37L,4L,15L,28L,1L,18L,37L,16L,39L,22L,7L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,36L,7L,22L,39L,16L,37L,18L,1L,28L,15L,4L,37L,30L,25L,22L,21L,22L,25L,30L,37L,4L,15L,28L,1L,18L,37L,16L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070464Inst : IEnumerable<long>
{
public static readonly long[] Value=A070464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070464.Bytes);
public long this[int i]=>Value[i];

public static A070464Inst Instance=new A070464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070465
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,36L,6L,21L,38L,14L,35L,15L,40L,24L,10L,41L,31L,23L,17L,13L,11L,11L,13L,17L,23L,31L,41L,10L,24L,40L,15L,35L,14L,38L,21L,6L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,36L,6L,21L,38L,14L,35L,15L,40L,24L,10L,41L,31L,23L,17L,13L,11L,11L,13L,17L,23L,31L,41L,10L,24L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070465Inst : IEnumerable<long>
{
public static readonly long[] Value=A070465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070465.Bytes);
public long this[int i]=>Value[i];

public static A070465Inst Instance=new A070465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070466
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,36L,5L,20L,37L,12L,33L,12L,37L,20L,5L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,36L,5L,20L,37L,12L,33L,12L,37L,20L,5L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,36L,5L,20L,37L,12L,33L,12L,37L,20L,5L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,36L,5L,20L,37L,12L,33L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070466Inst : IEnumerable<long>
{
public static readonly long[] Value=A070466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070466.Bytes);
public long this[int i]=>Value[i];

public static A070466Inst Instance=new A070466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070467
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,36L,4L,19L,36L,10L,31L,9L,34L,16L,0L,31L,19L,9L,1L,40L,36L,34L,34L,36L,40L,1L,9L,19L,31L,0L,16L,34L,9L,31L,10L,36L,19L,4L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,36L,4L,19L,36L,10L,31L,9L,34L,16L,0L,31L,19L,9L,1L,40L,36L,34L,34L,36L,40L,1L,9L,19L,31L,0L,16L,34L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070467Inst : IEnumerable<long>
{
public static readonly long[] Value=A070467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070467.Bytes);
public long this[int i]=>Value[i];

public static A070467Inst Instance=new A070467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070484
{
public static readonly long[] Value={ 0L,1L,8L,5L,20L,15L,18L,13L,6L,3L,10L,11L,12L,19L,16L,9L,4L,7L,2L,17L,14L,21L,0L,1L,8L,5L,20L,15L,18L,13L,6L,3L,10L,11L,12L,19L,16L,9L,4L,7L,2L,17L,14L,21L,0L,1L,8L,5L,20L,15L,18L,13L,6L,3L,10L,11L,12L,19L,16L,9L,4L,7L,2L,17L,14L,21L,0L,1L,8L,5L,20L,15L,18L,13L,6L,3L,10L,11L,12L,19L,16L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070484Inst : IEnumerable<long>
{
public static readonly long[] Value=A070484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070484.Bytes);
public long this[int i]=>Value[i];

public static A070484Inst Instance=new A070484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070485
{
public static readonly long[] Value={ 0L,1L,8L,4L,18L,10L,9L,21L,6L,16L,11L,20L,3L,12L,7L,17L,2L,14L,13L,5L,19L,15L,22L,0L,1L,8L,4L,18L,10L,9L,21L,6L,16L,11L,20L,3L,12L,7L,17L,2L,14L,13L,5L,19L,15L,22L,0L,1L,8L,4L,18L,10L,9L,21L,6L,16L,11L,20L,3L,12L,7L,17L,2L,14L,13L,5L,19L,15L,22L,0L,1L,8L,4L,18L,10L,9L,21L,6L,16L,11L,20L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070485Inst : IEnumerable<long>
{
public static readonly long[] Value=A070485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070485.Bytes);
public long this[int i]=>Value[i];

public static A070485Inst Instance=new A070485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070486
{
public static readonly long[] Value={ 0L,1L,8L,3L,16L,5L,0L,7L,8L,9L,16L,11L,0L,13L,8L,15L,16L,17L,0L,19L,8L,21L,16L,23L,0L,1L,8L,3L,16L,5L,0L,7L,8L,9L,16L,11L,0L,13L,8L,15L,16L,17L,0L,19L,8L,21L,16L,23L,0L,1L,8L,3L,16L,5L,0L,7L,8L,9L,16L,11L,0L,13L,8L,15L,16L,17L,0L,19L,8L,21L,16L,23L,0L,1L,8L,3L,16L,5L,0L,7L,8L,9L,16L,11L,0L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070486Inst : IEnumerable<long>
{
public static readonly long[] Value=A070486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070486.Bytes);
public long this[int i]=>Value[i];

public static A070486Inst Instance=new A070486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070487
{
public static readonly long[] Value={ 0L,1L,8L,2L,14L,0L,16L,18L,12L,4L,0L,6L,3L,22L,19L,0L,21L,13L,7L,9L,0L,11L,23L,17L,24L,0L,1L,8L,2L,14L,0L,16L,18L,12L,4L,0L,6L,3L,22L,19L,0L,21L,13L,7L,9L,0L,11L,23L,17L,24L,0L,1L,8L,2L,14L,0L,16L,18L,12L,4L,0L,6L,3L,22L,19L,0L,21L,13L,7L,9L,0L,11L,23L,17L,24L,0L,1L,8L,2L,14L,0L,16L,18L,12L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070487Inst : IEnumerable<long>
{
public static readonly long[] Value=A070487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070487.Bytes);
public long this[int i]=>Value[i];

public static A070487Inst Instance=new A070487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070488
{
public static readonly long[] Value={ 0L,1L,8L,1L,12L,21L,8L,5L,18L,1L,12L,5L,12L,13L,14L,21L,14L,25L,8L,21L,18L,5L,14L,25L,18L,25L,0L,1L,8L,1L,12L,21L,8L,5L,18L,1L,12L,5L,12L,13L,14L,21L,14L,25L,8L,21L,18L,5L,14L,25L,18L,25L,0L,1L,8L,1L,12L,21L,8L,5L,18L,1L,12L,5L,12L,13L,14L,21L,14L,25L,8L,21L,18L,5L,14L,25L,18L,25L,0L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070488Inst : IEnumerable<long>
{
public static readonly long[] Value=A070488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070488.Bytes);
public long this[int i]=>Value[i];

public static A070488Inst Instance=new A070488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070489
{
public static readonly long[] Value={ 0L,1L,8L,0L,10L,17L,0L,19L,26L,0L,1L,8L,0L,10L,17L,0L,19L,26L,0L,1L,8L,0L,10L,17L,0L,19L,26L,0L,1L,8L,0L,10L,17L,0L,19L,26L,0L,1L,8L,0L,10L,17L,0L,19L,26L,0L,1L,8L,0L,10L,17L,0L,19L,26L,0L,1L,8L,0L,10L,17L,0L,19L,26L,0L,1L,8L,0L,10L,17L,0L,19L,26L,0L,1L,8L,0L,10L,17L,0L,19L,26L,0L,1L,8L,0L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070489Inst : IEnumerable<long>
{
public static readonly long[] Value=A070489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070489.Bytes);
public long this[int i]=>Value[i];

public static A070489Inst Instance=new A070489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070490
{
public static readonly long[] Value={ 0L,1L,8L,27L,8L,13L,20L,7L,8L,1L,20L,15L,20L,13L,0L,15L,8L,13L,8L,27L,20L,21L,8L,15L,20L,1L,20L,27L,0L,1L,8L,27L,8L,13L,20L,7L,8L,1L,20L,15L,20L,13L,0L,15L,8L,13L,8L,27L,20L,21L,8L,15L,20L,1L,20L,27L,0L,1L,8L,27L,8L,13L,20L,7L,8L,1L,20L,15L,20L,13L,0L,15L,8L,13L,8L,27L,20L,21L,8L,15L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070490Inst : IEnumerable<long>
{
public static readonly long[] Value=A070490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070490.Bytes);
public long this[int i]=>Value[i];

public static A070490Inst Instance=new A070490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070491
{
public static readonly long[] Value={ 0L,1L,8L,27L,6L,9L,13L,24L,19L,4L,14L,26L,17L,22L,18L,11L,7L,12L,3L,15L,25L,10L,5L,16L,20L,23L,2L,21L,28L,0L,1L,8L,27L,6L,9L,13L,24L,19L,4L,14L,26L,17L,22L,18L,11L,7L,12L,3L,15L,25L,10L,5L,16L,20L,23L,2L,21L,28L,0L,1L,8L,27L,6L,9L,13L,24L,19L,4L,14L,26L,17L,22L,18L,11L,7L,12L,3L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070491Inst : IEnumerable<long>
{
public static readonly long[] Value=A070491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070491.Bytes);
public long this[int i]=>Value[i];

public static A070491Inst Instance=new A070491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070492
{
public static readonly long[] Value={ 0L,1L,8L,27L,4L,5L,6L,13L,2L,9L,10L,11L,18L,7L,14L,15L,16L,23L,12L,19L,20L,21L,28L,17L,24L,25L,26L,3L,22L,29L,0L,1L,8L,27L,4L,5L,6L,13L,2L,9L,10L,11L,18L,7L,14L,15L,16L,23L,12L,19L,20L,21L,28L,17L,24L,25L,26L,3L,22L,29L,0L,1L,8L,27L,4L,5L,6L,13L,2L,9L,10L,11L,18L,7L,14L,15L,16L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070492Inst : IEnumerable<long>
{
public static readonly long[] Value=A070492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070492.Bytes);
public long this[int i]=>Value[i];

public static A070492Inst Instance=new A070492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070493
{
public static readonly long[] Value={ 0L,1L,8L,27L,2L,1L,30L,2L,16L,16L,8L,29L,23L,27L,16L,27L,4L,15L,4L,8L,2L,23L,15L,15L,29L,1L,30L,29L,4L,23L,30L,0L,1L,8L,27L,2L,1L,30L,2L,16L,16L,8L,29L,23L,27L,16L,27L,4L,15L,4L,8L,2L,23L,15L,15L,29L,1L,30L,29L,4L,23L,30L,0L,1L,8L,27L,2L,1L,30L,2L,16L,16L,8L,29L,23L,27L,16L,27L,4L,15L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070493Inst : IEnumerable<long>
{
public static readonly long[] Value=A070493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070493.Bytes);
public long this[int i]=>Value[i];

public static A070493Inst Instance=new A070493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070494
{
public static readonly long[] Value={ 0L,1L,8L,27L,0L,29L,24L,23L,0L,25L,8L,19L,0L,21L,24L,15L,0L,17L,8L,11L,0L,13L,24L,7L,0L,9L,8L,3L,0L,5L,24L,31L,0L,1L,8L,27L,0L,29L,24L,23L,0L,25L,8L,19L,0L,21L,24L,15L,0L,17L,8L,11L,0L,13L,24L,7L,0L,9L,8L,3L,0L,5L,24L,31L,0L,1L,8L,27L,0L,29L,24L,23L,0L,25L,8L,19L,0L,21L,24L,15L,0L,17L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070494Inst : IEnumerable<long>
{
public static readonly long[] Value=A070494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070494.Bytes);
public long this[int i]=>Value[i];

public static A070494Inst Instance=new A070494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070495
{
public static readonly long[] Value={ 0L,1L,8L,27L,31L,26L,18L,13L,17L,3L,10L,11L,12L,19L,5L,9L,4L,29L,24L,28L,14L,21L,22L,23L,30L,16L,20L,15L,7L,2L,6L,25L,32L,0L,1L,8L,27L,31L,26L,18L,13L,17L,3L,10L,11L,12L,19L,5L,9L,4L,29L,24L,28L,14L,21L,22L,23L,30L,16L,20L,15L,7L,2L,6L,25L,32L,0L,1L,8L,27L,31L,26L,18L,13L,17L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070495Inst : IEnumerable<long>
{
public static readonly long[] Value=A070495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070495.Bytes);
public long this[int i]=>Value[i];

public static A070495Inst Instance=new A070495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070496
{
public static readonly long[] Value={ 0L,1L,8L,27L,30L,23L,12L,3L,2L,15L,14L,5L,28L,21L,24L,9L,16L,17L,18L,25L,10L,13L,6L,29L,20L,19L,32L,31L,22L,11L,4L,7L,26L,33L,0L,1L,8L,27L,30L,23L,12L,3L,2L,15L,14L,5L,28L,21L,24L,9L,16L,17L,18L,25L,10L,13L,6L,29L,20L,19L,32L,31L,22L,11L,4L,7L,26L,33L,0L,1L,8L,27L,30L,23L,12L,3L,2L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070496Inst : IEnumerable<long>
{
public static readonly long[] Value=A070496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070496.Bytes);
public long this[int i]=>Value[i];

public static A070496Inst Instance=new A070496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070497
{
public static readonly long[] Value={ 0L,1L,8L,27L,29L,20L,6L,28L,22L,29L,20L,1L,13L,27L,14L,15L,1L,13L,22L,34L,20L,21L,8L,22L,34L,15L,6L,13L,7L,29L,15L,6L,8L,27L,34L,0L,1L,8L,27L,29L,20L,6L,28L,22L,29L,20L,1L,13L,27L,14L,15L,1L,13L,22L,34L,20L,21L,8L,22L,34L,15L,6L,13L,7L,29L,15L,6L,8L,27L,34L,0L,1L,8L,27L,29L,20L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070497Inst : IEnumerable<long>
{
public static readonly long[] Value=A070497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070497.Bytes);
public long this[int i]=>Value[i];

public static A070497Inst Instance=new A070497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070498
{
public static readonly long[] Value={ 0L,1L,8L,27L,28L,17L,0L,19L,8L,9L,28L,35L,0L,1L,8L,27L,28L,17L,0L,19L,8L,9L,28L,35L,0L,1L,8L,27L,28L,17L,0L,19L,8L,9L,28L,35L,0L,1L,8L,27L,28L,17L,0L,19L,8L,9L,28L,35L,0L,1L,8L,27L,28L,17L,0L,19L,8L,9L,28L,35L,0L,1L,8L,27L,28L,17L,0L,19L,8L,9L,28L,35L,0L,1L,8L,27L,28L,17L,0L,19L,8L,9L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070498Inst : IEnumerable<long>
{
public static readonly long[] Value=A070498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070498.Bytes);
public long this[int i]=>Value[i];

public static A070498Inst Instance=new A070498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070499
{
public static readonly long[] Value={ 0L,1L,8L,27L,27L,14L,31L,10L,31L,26L,1L,36L,26L,14L,6L,8L,26L,29L,23L,14L,8L,11L,29L,31L,23L,11L,1L,36L,11L,6L,27L,6L,23L,10L,10L,29L,36L,0L,1L,8L,27L,27L,14L,31L,10L,31L,26L,1L,36L,26L,14L,6L,8L,26L,29L,23L,14L,8L,11L,29L,31L,23L,11L,1L,36L,11L,6L,27L,6L,23L,10L,10L,29L,36L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070499Inst : IEnumerable<long>
{
public static readonly long[] Value=A070499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070499.Bytes);
public long this[int i]=>Value[i];

public static A070499Inst Instance=new A070499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070580
{
public static readonly long[] Value={ 0L,1L,16L,7L,34L,33L,1L,33L,26L,12L,10L,26L,16L,34L,10L,9L,9L,12L,7L,7L,12L,9L,9L,10L,34L,16L,26L,10L,12L,26L,33L,1L,33L,34L,7L,16L,1L,0L,1L,16L,7L,34L,33L,1L,33L,26L,12L,10L,26L,16L,34L,10L,9L,9L,12L,7L,7L,12L,9L,9L,10L,34L,16L,26L,10L,12L,26L,33L,1L,33L,34L,7L,16L,1L,0L,1L,16L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070580Inst : IEnumerable<long>
{
public static readonly long[] Value=A070580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070580.Bytes);
public long this[int i]=>Value[i];

public static A070580Inst Instance=new A070580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070581
{
public static readonly long[] Value={ 0L,1L,16L,5L,28L,17L,4L,7L,30L,25L,6L,11L,26L,23L,36L,9L,24L,35L,20L,19L,20L,35L,24L,9L,36L,23L,26L,11L,6L,25L,30L,7L,4L,17L,28L,5L,16L,1L,0L,1L,16L,5L,28L,17L,4L,7L,30L,25L,6L,11L,26L,23L,36L,9L,24L,35L,20L,19L,20L,35L,24L,9L,36L,23L,26L,11L,6L,25L,30L,7L,4L,17L,28L,5L,16L,1L,0L,1L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070581Inst : IEnumerable<long>
{
public static readonly long[] Value=A070581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070581.Bytes);
public long this[int i]=>Value[i];

public static A070581Inst Instance=new A070581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070582
{
public static readonly long[] Value={ 0L,1L,16L,3L,22L,1L,9L,22L,1L,9L,16L,16L,27L,13L,1L,3L,16L,22L,27L,22L,22L,27L,22L,16L,3L,1L,13L,27L,16L,16L,9L,1L,22L,9L,1L,22L,3L,16L,1L,0L,1L,16L,3L,22L,1L,9L,22L,1L,9L,16L,16L,27L,13L,1L,3L,16L,22L,27L,22L,22L,27L,22L,16L,3L,1L,13L,27L,16L,16L,9L,1L,22L,9L,1L,22L,3L,16L,1L,0L,1L,16L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070582Inst : IEnumerable<long>
{
public static readonly long[] Value=A070582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070582.Bytes);
public long this[int i]=>Value[i];

public static A070582Inst Instance=new A070582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070583
{
public static readonly long[] Value={ 0L,1L,16L,1L,16L,25L,16L,1L,16L,1L,0L,1L,16L,1L,16L,25L,16L,1L,16L,1L,0L,1L,16L,1L,16L,25L,16L,1L,16L,1L,0L,1L,16L,1L,16L,25L,16L,1L,16L,1L,0L,1L,16L,1L,16L,25L,16L,1L,16L,1L,0L,1L,16L,1L,16L,25L,16L,1L,16L,1L,0L,1L,16L,1L,16L,25L,16L,1L,16L,1L,0L,1L,16L,1L,16L,25L,16L,1L,16L,1L,0L,1L,16L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070583Inst : IEnumerable<long>
{
public static readonly long[] Value=A070583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070583.Bytes);
public long this[int i]=>Value[i];

public static A070583Inst Instance=new A070583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070584
{
public static readonly long[] Value={ 0L,1L,16L,40L,10L,10L,25L,23L,37L,1L,37L,4L,31L,25L,40L,31L,18L,4L,16L,23L,18L,18L,23L,16L,4L,18L,31L,40L,25L,31L,4L,37L,1L,37L,23L,25L,10L,10L,40L,16L,1L,0L,1L,16L,40L,10L,10L,25L,23L,37L,1L,37L,4L,31L,25L,40L,31L,18L,4L,16L,23L,18L,18L,23L,16L,4L,18L,31L,40L,25L,31L,4L,37L,1L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070584Inst : IEnumerable<long>
{
public static readonly long[] Value=A070584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070584.Bytes);
public long this[int i]=>Value[i];

public static A070584Inst Instance=new A070584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070585
{
public static readonly long[] Value={ 0L,1L,16L,39L,4L,37L,36L,7L,22L,9L,4L,25L,30L,1L,28L,15L,16L,25L,18L,37L,22L,21L,22L,37L,18L,25L,16L,15L,28L,1L,30L,25L,4L,9L,22L,7L,36L,37L,4L,39L,16L,1L,0L,1L,16L,39L,4L,37L,36L,7L,22L,9L,4L,25L,30L,1L,28L,15L,16L,25L,18L,37L,22L,21L,22L,37L,18L,25L,16L,15L,28L,1L,30L,25L,4L,9L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070585Inst : IEnumerable<long>
{
public static readonly long[] Value=A070585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070585.Bytes);
public long this[int i]=>Value[i];

public static A070585Inst Instance=new A070585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070586
{
public static readonly long[] Value={ 0L,1L,16L,38L,41L,23L,6L,36L,11L,25L,24L,21L,10L,9L,17L,14L,4L,15L,13L,31L,40L,35L,35L,40L,31L,13L,15L,4L,14L,17L,9L,10L,21L,24L,25L,11L,36L,6L,23L,41L,38L,16L,1L,0L,1L,16L,38L,41L,23L,6L,36L,11L,25L,24L,21L,10L,9L,17L,14L,4L,15L,13L,31L,40L,35L,35L,40L,31L,13L,15L,4L,14L,17L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070586Inst : IEnumerable<long>
{
public static readonly long[] Value=A070586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070586.Bytes);
public long this[int i]=>Value[i];

public static A070586Inst Instance=new A070586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070587
{
public static readonly long[] Value={ 0L,1L,16L,37L,36L,9L,20L,25L,4L,5L,12L,33L,12L,5L,4L,25L,20L,9L,36L,37L,16L,1L,0L,1L,16L,37L,36L,9L,20L,25L,4L,5L,12L,33L,12L,5L,4L,25L,20L,9L,36L,37L,16L,1L,0L,1L,16L,37L,36L,9L,20L,25L,4L,5L,12L,33L,12L,5L,4L,25L,20L,9L,36L,37L,16L,1L,0L,1L,16L,37L,36L,9L,20L,25L,4L,5L,12L,33L,12L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070587Inst : IEnumerable<long>
{
public static readonly long[] Value=A070587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070587.Bytes);
public long this[int i]=>Value[i];

public static A070587Inst Instance=new A070587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070588
{
public static readonly long[] Value={ 0L,1L,16L,36L,31L,40L,36L,16L,1L,36L,10L,16L,36L,31L,31L,0L,16L,1L,36L,1L,25L,36L,31L,31L,36L,25L,1L,36L,1L,16L,0L,31L,31L,36L,16L,10L,36L,1L,16L,36L,40L,31L,36L,16L,1L,0L,1L,16L,36L,31L,40L,36L,16L,1L,36L,10L,16L,36L,31L,31L,0L,16L,1L,36L,1L,25L,36L,31L,31L,36L,25L,1L,36L,1L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070588Inst : IEnumerable<long>
{
public static readonly long[] Value=A070588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070588.Bytes);
public long this[int i]=>Value[i];

public static A070588Inst Instance=new A070588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070589
{
public static readonly long[] Value={ 0L,1L,16L,35L,26L,27L,8L,9L,2L,29L,18L,13L,36L,41L,6L,25L,32L,31L,4L,3L,12L,39L,24L,23L,24L,39L,12L,3L,4L,31L,32L,25L,6L,41L,36L,13L,18L,29L,2L,9L,8L,27L,26L,35L,16L,1L,0L,1L,16L,35L,26L,27L,8L,9L,2L,29L,18L,13L,36L,41L,6L,25L,32L,31L,4L,3L,12L,39L,24L,23L,24L,39L,12L,3L,4L,31L,32L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070589Inst : IEnumerable<long>
{
public static readonly long[] Value=A070589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070589.Bytes);
public long this[int i]=>Value[i];

public static A070589Inst Instance=new A070589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070590
{
public static readonly long[] Value={ 0L,1L,16L,34L,21L,14L,27L,4L,7L,28L,36L,24L,9L,32L,17L,6L,18L,2L,25L,37L,12L,42L,8L,3L,3L,8L,42L,12L,37L,25L,2L,18L,6L,17L,32L,9L,24L,36L,28L,7L,4L,27L,14L,21L,34L,16L,1L,0L,1L,16L,34L,21L,14L,27L,4L,7L,28L,36L,24L,9L,32L,17L,6L,18L,2L,25L,37L,12L,42L,8L,3L,3L,8L,42L,12L,37L,25L,2L,18L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070590Inst : IEnumerable<long>
{
public static readonly long[] Value=A070590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070590.Bytes);
public long this[int i]=>Value[i];

public static A070590Inst Instance=new A070590Inst();

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