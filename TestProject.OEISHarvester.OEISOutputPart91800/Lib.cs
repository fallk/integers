using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A111441
{
public static readonly long[] Value={ 1L,19L,37L,455L,509L,575L,20597L,202717L,1864637L,542474231L,1139733677L,51283502951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111441Inst : IEnumerable<long>
{
public static readonly long[] Value=A111441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111441.Bytes);
public long this[int i]=>Value[i];

public static A111441Inst Instance=new A111441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111442
{
public static readonly long[] Value={ 1L,32L,243L,64L,25L,36L,16807L,32768L,729L,100L,121L,1728L,371293L,38416L,11390625L,1048576L,1419857L,1889568L,893871739L,3200000L,9261L,234256L,3404825447L,13824L,625L,208827064576L,729L,17210368L,24389L,24300000L,923521L,32768L,35937L,39304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111442Inst : IEnumerable<long>
{
public static readonly long[] Value=A111442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111442.Bytes);
public long this[int i]=>Value[i];

public static A111442Inst Instance=new A111442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111443
{
public static readonly long[] Value={ 1L,4L,9L,61009L,529L,63001L,9409L,4624L,1849L,1L,121L,441L,961L,69169L,522729L,652864L,982081L,423801L,16384L,4L,144L,484L,925444L,675684L,5262436L,676L,927369L,487204L,14884L,9L,169L,42016324L,9801L,651117289L,5221225L,692110864L,96314596L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111443Inst : IEnumerable<long>
{
public static readonly long[] Value=A111443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111443.Bytes);
public long this[int i]=>Value[i];

public static A111443Inst Instance=new A111443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111444
{
public static readonly long[] Value={ 1L,4L,64L,9L,49L,169L,16L,2116L,2916L,9216L,25L,225L,625L,1225L,2025L,36L,1936L,3136L,8836L,11236L,20736L,49L,1849L,3249L,8649L,11449L,20449L,24649L,64L,1764L,3364L,8464L,11664L,20164L,24964L,36864L,81L,1681L,3481L,8281L,11881L,19881L,25281L,36481L,43681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111444Inst : IEnumerable<long>
{
public static readonly long[] Value=A111444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111444.Bytes);
public long this[int i]=>Value[i];

public static A111444Inst Instance=new A111444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111445
{
public static readonly long[] Value={ 1L,2L,8L,3L,7L,13L,4L,46L,54L,96L,5L,15L,25L,35L,45L,6L,44L,56L,94L,106L,144L,7L,43L,57L,93L,107L,143L,157L,8L,42L,58L,92L,108L,142L,158L,192L,9L,41L,59L,91L,109L,141L,159L,191L,209L,10L,90L,110L,190L,210L,290L,310L,390L,410L,490L,11L,239L,261L,489L,511L,739L,761L,989L,1011L,1239L,1261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111445Inst : IEnumerable<long>
{
public static readonly long[] Value=A111445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111445.Bytes);
public long this[int i]=>Value[i];

public static A111445Inst Instance=new A111445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111446
{
public static readonly long[] Value={ 0L,1L,4L,25L,16L,9L,16L,121L,324L,25L,529L,36L,441L,144L,49L,256L,361L,64L,169L,576L,81L,484L,289L,196L,100L,23104L,2116L,121L,33124L,15129L,3136L,144L,1156L,14161L,20164L,169L,50176L,5184L,196L,10201L,39204L,2209L,9216L,28224L,225L,11236L,6241L,26244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111446Inst : IEnumerable<long>
{
public static readonly long[] Value=A111446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111446.Bytes);
public long this[int i]=>Value[i];

public static A111446Inst Instance=new A111446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111447
{
public static readonly long[] Value={ 0L,1L,512L,343L,64L,125L,216L,27L,8L,729L,357911L,512L,4913L,216L,389017L,59319L,68921L,103823L,13824L,125L,27L,1728L,729L,1331L,5832L,456533L,97336L,35937L,493039L,531441L,343L,2744L,250047L,10648L,117649L,132651L,21952L,50653L,46656L,804357L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111447Inst : IEnumerable<long>
{
public static readonly long[] Value=A111447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111447.Bytes);
public long this[int i]=>Value[i];

public static A111447Inst Instance=new A111447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111448
{
public static readonly long[] Value={ 0L,1L,8L,7L,4L,5L,6L,3L,2L,9L,71L,8L,17L,6L,73L,39L,41L,47L,24L,5L,3L,12L,9L,11L,18L,77L,46L,33L,79L,81L,7L,14L,63L,22L,49L,51L,28L,37L,36L,93L,19L,21L,67L,4L,23L,32L,89L,91L,38L,97L,15L,26L,53L,59L,61L,27L,44L,83L,42L,29L,31L,48L,57L,16L,13L,99L,701L,887L,134L,843L,269L,471L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111448Inst : IEnumerable<long>
{
public static readonly long[] Value=A111448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111448.Bytes);
public long this[int i]=>Value[i];

public static A111448Inst Instance=new A111448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111449
{
public static readonly long[] Value={ 0L,1L,2L,5L,4L,3L,4L,11L,18L,5L,23L,6L,21L,12L,7L,16L,19L,8L,13L,24L,9L,22L,17L,14L,10L,152L,46L,11L,182L,123L,56L,12L,34L,119L,142L,13L,224L,72L,14L,101L,198L,47L,96L,168L,15L,106L,79L,162L,57L,16L,208L,174L,91L,222L,17L,36L,48L,146L,111L,18L,73L,156L,188L,66L,19L,58L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111449Inst : IEnumerable<long>
{
public static readonly long[] Value=A111449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111449.Bytes);
public long this[int i]=>Value[i];

public static A111449Inst Instance=new A111449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111450
{
public static readonly long[] Value={ 1L,32L,243L,4L,25L,16L,27L,8L,9L,0L,357911L,512L,4913L,0L,0L,16L,389017L,0L,59319L,0L,121L,0L,103823L,324L,25L,0L,27L,128L,529L,0L,1331L,32L,456533L,0L,0L,36L,35937L,0L,493039L,0L,441L,0L,243L,144L,0L,0L,177147L,2048L,49L,0L,132651L,21952L,50653L,0L,0L,256L,804357L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111450Inst : IEnumerable<long>
{
public static readonly long[] Value=A111450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111450.Bytes);
public long this[int i]=>Value[i];

public static A111450Inst Instance=new A111450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111451
{
public static readonly long[] Value={ 1L,3L,56L,22L,792L,101L,6842L,385L,44583L,1255L,239943L,3718L,1121505L,10143L,4697205L,26015L,18004327L,63261L,64112359L,147273L,214481126L,329931L,679903203L,715220L,2056148051L,1505499L,5964539504L,3087735L,16670689208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111451Inst : IEnumerable<long>
{
public static readonly long[] Value=A111451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111451.Bytes);
public long this[int i]=>Value[i];

public static A111451Inst Instance=new A111451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111452
{
public static readonly long[] Value={ 1L,23L,25L,53L,297L,853L,10043L,11869L,117267L,222975L,241163L,339615L,3538161L,3600489L,25537223L,38576521L,95316169L,96643287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111452Inst : IEnumerable<long>
{
public static readonly long[] Value=A111452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111452.Bytes);
public long this[int i]=>Value[i];

public static A111452Inst Instance=new A111452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111453
{
public static readonly long[] Value={ 1L,5L,9L,3L,7L,11L,2L,6L,10L,4L,8L,12L,16L,20L,14L,18L,22L,13L,17L,21L,15L,19L,23L,27L,31L,25L,29L,33L,24L,28L,32L,26L,30L,34L,38L,42L,36L,40L,44L,35L,39L,43L,37L,41L,45L,49L,53L,47L,51L,55L,46L,50L,54L,48L,52L,56L,60L,64L,58L,62L,66L,57L,61L,65L,59L,63L,67L,71L,75L,69L,73L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111453Inst : IEnumerable<long>
{
public static readonly long[] Value=A111453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111453.Bytes);
public long this[int i]=>Value[i];

public static A111453Inst Instance=new A111453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111454
{
public static readonly BigInteger[] Value={ 0L,0L,0L,18L,400L,7850L,162288L,3667650L,91171008L,2486784402L,74062575400L,2395420006034L,83695120256592L,3143661612445146L,126375169532421600L,5415486851106043650L,BigInteger.Parse("246486713303685957376") };
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
public class A111454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111454Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111454.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111454.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111454Inst Instance=new A111454Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111455
{
public static readonly long[] Value={ 0L,14L,24L,32L,36L,42L,50L,62L,66L,72L,84L,86L,90L,102L,104L,116L,126L,146L,164L,192L,200L,206L,224L,230L,240L,246L,260L,270L,282L,290L,326L,330L,332L,336L,344L,350L,354L,360L,374L,396L,402L,410L,414L,422L,440L,456L,482L,492L,494L,504L,506L,510L,546L,552L,570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111455Inst : IEnumerable<long>
{
public static readonly long[] Value=A111455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111455.Bytes);
public long this[int i]=>Value[i];

public static A111455Inst Instance=new A111455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111456
{
public static readonly long[] Value={ 2L,108L,228L,13710L,44790L,6996920L,11128712L,12306056L,3816547290L,7838911147538198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111456Inst : IEnumerable<long>
{
public static readonly long[] Value=A111456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111456.Bytes);
public long this[int i]=>Value[i];

public static A111456Inst Instance=new A111456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111457
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,4L,6L,6L,8L,10L,10L,13L,15L,15L,16L,18L,21L,21L,23L,24L,24L,26L,27L,30L,34L,34L,34L,35L,35L,36L,42L,43L,45L,45L,50L,50L,51L,54L,55L,56L,58L,58L,61L,61L,62L,62L,68L,75L,76L,76L,76L,78L,78L,80L,82L,84L,86L,86L,87L,88L,88L,91L,98L,99L,99L,100L,106L,108L,111L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111457Inst : IEnumerable<long>
{
public static readonly long[] Value=A111457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111457.Bytes);
public long this[int i]=>Value[i];

public static A111457Inst Instance=new A111457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111458
{
public static readonly long[] Value={ 33L,46L,51L,53L,54L,67L,72L,74L,75L,80L,82L,83L,85L,86L,87L,88L,101L,106L,108L,109L,114L,116L,117L,119L,120L,121L,122L,127L,129L,130L,132L,133L,134L,135L,137L,138L,139L,140L,141L,142L,143L,156L,161L,163L,164L,169L,171L,172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111458Inst : IEnumerable<long>
{
public static readonly long[] Value=A111458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111458.Bytes);
public long this[int i]=>Value[i];

public static A111458Inst Instance=new A111458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111459
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,2L,3L,35L,313L,26261407L,1001689887346L,BigInteger.Parse("356879751557595054813966522072161803"),BigInteger.Parse("3221974575788016845202611315068840860244866942009716269469") };
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
public class A111459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111459Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111459.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111459.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111459Inst Instance=new A111459Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111460
{
public static readonly long[] Value={ 1L,3L,2L,1L,0L,7L,5L,5L,6L,3L,2L,1L,6L,7L,1L,1L,4L,1L,6L,4L,1L,3L,8L,5L,9L,5L,9L,6L,0L,1L,9L,0L,0L,4L,5L,5L,1L,4L,0L,6L,2L,1L,6L,3L,4L,0L,3L,3L,1L,1L,6L,1L,9L,4L,7L,2L,4L,2L,6L,7L,9L,3L,0L,0L,4L,9L,6L,9L,5L,5L,7L,0L,2L,0L,8L,3L,5L,0L,5L,5L,5L,7L,4L,0L,2L,7L,1L,3L,8L,4L,5L,7L,5L,9L,2L,6L,2L,4L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111460Inst : IEnumerable<long>
{
public static readonly long[] Value=A111460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111460.Bytes);
public long this[int i]=>Value[i];

public static A111460Inst Instance=new A111460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111461
{
public static readonly long[] Value={ 3L,6L,3L,4L,6L,6L,0L,3L,1L,8L,6L,7L,7L,2L,6L,4L,5L,3L,2L,1L,6L,2L,5L,2L,2L,2L,5L,2L,1L,9L,1L,4L,8L,0L,4L,9L,3L,6L,5L,1L,9L,5L,8L,9L,0L,8L,9L,9L,9L,4L,2L,7L,2L,2L,5L,6L,4L,0L,9L,3L,7L,7L,0L,1L,0L,7L,7L,4L,5L,2L,2L,4L,5L,3L,7L,6L,8L,9L,4L,1L,6L,7L,9L,4L,9L,0L,4L,3L,7L,4L,9L,9L,6L,5L,9L,9L,1L,9L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111461Inst : IEnumerable<long>
{
public static readonly long[] Value=A111461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111461.Bytes);
public long this[int i]=>Value[i];

public static A111461Inst Instance=new A111461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111462
{
public static readonly BigInteger[] Value={ 7L,71L,17L,719L,9173L,3719L,91733L,3371947L,7491733L,33719479L,974917337L,73371947923L,3297491733763L,367337194792327L,72329749173376301L,1036733719479232777L,BigInteger.Parse("777232974917337630173"),BigInteger.Parse("37103673371947923277727") };
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
public class A111462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111462Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111462.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111462.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111462Inst Instance=new A111462Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111463
{
public static readonly BigInteger[] Value={ 11L,113L,311L,11311L,113111L,11131111L,11113111L,1113111107L,7011113111L,111311110717L,717011113111L,111311110717L,71701111311131L,1311131111071703L,307170111131113123L,BigInteger.Parse("32131113111107170309"),BigInteger.Parse("9030717011113111312321") };
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
public class A111463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111463Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111463.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111463.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111463Inst Instance=new A111463Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111464
{
public static readonly BigInteger[] Value={ 12L,84L,336L,70896L,1649679024L,2314922791895828688L,BigInteger.Parse("36399640682124013852413819710318544"),BigInteger.Parse("77273493636380731521261660069550949170528534841641864516576194470832") };
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
public class A111464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111464Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111464.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111464.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111464Inst Instance=new A111464Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111465
{
public static readonly long[] Value={ 1L,3L,18L,180L,12L,252L,9L,324L,14580L,801900L,12150L,947700L,86240700L,821340L,98560800L,13404268800L,87609600L,14981241600L,78848640L,16558214400L,3824947526400L,967711724179200L,3506201899200L,11687339664L,3798385390800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111465Inst : IEnumerable<long>
{
public static readonly long[] Value=A111465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111465.Bytes);
public long this[int i]=>Value[i];

public static A111465Inst Instance=new A111465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111466
{
public static readonly long[] Value={ 1L,0L,2L,5L,0L,8L,21L,0L,34L,89L,0L,144L,377L,0L,610L,1597L,0L,2584L,6765L,0L,10946L,28657L,0L,46368L,121393L,0L,196418L,514229L,0L,832040L,2178309L,0L,3524578L,9227465L,0L,14930352L,39088169L,0L,63245986L,165580141L,0L,267914296L,701408733L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111466Inst : IEnumerable<long>
{
public static readonly long[] Value=A111466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111466.Bytes);
public long this[int i]=>Value[i];

public static A111466Inst Instance=new A111466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111467
{
public static readonly long[] Value={ 1L,2L,3L,6L,10L,14L,24L,40L,54L,56L,120L,168L,264L,270L,280L,720L,1008L,1200L,1584L,1620L,1872L,5040L,7920L,8400L,9360L,11088L,11340L,11760L,40320L,63360L,67200L,74880L,88704L,94080L,97920L,104832L,362880L,570240L,673920L,798336L,881280L,943488L,984960L,1192320L,1224720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111467Inst : IEnumerable<long>
{
public static readonly long[] Value=A111467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111467.Bytes);
public long this[int i]=>Value[i];

public static A111467Inst Instance=new A111467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111468
{
public static readonly long[] Value={ 1L,3L,14L,56L,280L,1872L,11760L,104832L,1224720L,12545280L,96526080L,1163289600L,13891046400L,200222668800L,2917119744000L,47259168768000L,738275586048000L,13386781384704000L,259936372452556800L,5427242941317120000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111468Inst : IEnumerable<long>
{
public static readonly long[] Value=A111468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111468.Bytes);
public long this[int i]=>Value[i];

public static A111468Inst Instance=new A111468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111469
{
public static readonly long[] Value={ 1L,5L,30L,174L,1102L,8004L,64908L,631296L,7632144L,85538304L,767957760L,10378782720L,141810600960L,2211872624640L,34073996544000L,592443113472000L,9995136528384000L,193299238895616000L,3978509063587430400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111469Inst : IEnumerable<long>
{
public static readonly long[] Value=A111469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111469.Bytes);
public long this[int i]=>Value[i];

public static A111469Inst Instance=new A111469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111470
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,18L,13L,14L,15L,16L,17L,18L,12L,19L,20L,50L,21L,22L,23L,24L,54L,25L,26L,27L,28L,98L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,250L,41L,42L,43L,44L,242L,45L,75L,46L,47L,48L,162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111470Inst : IEnumerable<long>
{
public static readonly long[] Value=A111470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111470.Bytes);
public long this[int i]=>Value[i];

public static A111470Inst Instance=new A111470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111471
{
public static readonly long[] Value={ 1L,9L,7L,3L,29L,19L,21L,121L,7L,211L,207L,11L,221L,347L,99L,123L,303L,189L,1131L,1179L,2069L,3437L,2211L,211L,3169L,1551L,3493L,7433L,6939L,1053L,1537L,9417L,4491L,1257L,19693L,9L,1653L,3329L,317L,8667L,799L,1053L,5617L,6049L,1721L,24871L,2751L,737L,3303L,29079L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111471Inst : IEnumerable<long>
{
public static readonly long[] Value=A111471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111471.Bytes);
public long this[int i]=>Value[i];

public static A111471Inst Instance=new A111471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111472
{
public static readonly BigInteger[] Value={ 199L,199777L,1997773333L,BigInteger.Parse("19977733332929292929"),BigInteger.Parse("19977733332929292929191919191919"),BigInteger.Parse("1997773333292929292919191919191921212121212121"),BigInteger.Parse("1997773333292929292919191919191921212121212121121121121121121121121121"),BigInteger.Parse("1997773333292929292919191919191921212121212121121121121121121121121121777777777") };
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
public class A111472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111472Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111472.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111472.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111472Inst Instance=new A111472Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111473
{
public static readonly long[] Value={ 3L,1L,1L,11L,113L,7L,23L,41L,37L,141L,733L,241L,3L,791L,781L,701L,239L,441L,2019L,189L,2071L,401L,851L,463L,4421L,497L,2267L,213L,1653L,1683L,1227L,667L,3261L,6673L,5799L,3579L,1907L,6483L,7813L,2443L,1923L,11439L,6657L,7861L,1847L,7521L,8277L,8459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111473Inst : IEnumerable<long>
{
public static readonly long[] Value=A111473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111473.Bytes);
public long this[int i]=>Value[i];

public static A111473Inst Instance=new A111473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111474
{
public static readonly long[] Value={ 2L,5L,9L,3L,8L,9L,1L,3L,0L,1L,7L,2L,1L,8L,2L,3L,8L,2L,9L,7L,6L,2L,0L,2L,7L,6L,9L,4L,8L,2L,1L,8L,1L,0L,7L,0L,5L,1L,9L,2L,9L,1L,1L,6L,7L,1L,0L,6L,2L,0L,8L,7L,3L,9L,4L,5L,1L,9L,5L,0L,8L,5L,5L,3L,3L,9L,0L,2L,0L,3L,5L,9L,7L,7L,6L,0L,5L,9L,1L,1L,9L,6L,3L,9L,6L,6L,9L,2L,5L,7L,4L,1L,8L,4L,4L,3L,4L,8L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111474Inst : IEnumerable<long>
{
public static readonly long[] Value=A111474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111474.Bytes);
public long this[int i]=>Value[i];

public static A111474Inst Instance=new A111474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111475
{
public static readonly long[] Value={ 7L,3L,1L,1L,1L,1L,129L,123L,97L,559L,781L,459L,253L,183L,413L,417L,657L,77L,437L,1439L,667L,1281L,3379L,979L,2763L,1953L,103L,10083L,5103L,291L,1311L,2199L,1159L,501L,5931L,483L,6171L,16301L,1781L,1229L,9519L,607L,5113L,2641L,1441L,8511L,9023L,363L,4001L,15261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111475Inst : IEnumerable<long>
{
public static readonly long[] Value=A111475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111475.Bytes);
public long this[int i]=>Value[i];

public static A111475Inst Instance=new A111475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111476
{
public static readonly BigInteger[] Value={ 7L,733L,733111L,7331111111L,733111111111111L,BigInteger.Parse("733111111111111111111"),BigInteger.Parse("733111111111111111111129129129129129129129"),BigInteger.Parse("733111111111111111111129129129129129129129123123123123123123123123") };
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
public class A111476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111476Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111476.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111476.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111476Inst Instance=new A111476Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111477
{
public static readonly long[] Value={ 11L,19L,19L,37L,21L,71L,101L,39L,61L,87L,227L,63L,437L,153L,1363L,117L,363L,861L,609L,249L,23L,1077L,3123L,771L,3717L,633L,279L,1119L,927L,107L,3843L,4313L,1729L,627L,12541L,2403L,4083L,1239L,2227L,6441L,3819L,3983L,5631L,2303L,2971L,19217L,3633L,5109L,14413L,913L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111477Inst : IEnumerable<long>
{
public static readonly long[] Value=A111477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111477.Bytes);
public long this[int i]=>Value[i];

public static A111477Inst Instance=new A111477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111478
{
public static readonly BigInteger[] Value={ 11L,111919L,111919191919L,11191919191937373737UL,BigInteger.Parse("111919191919373737372121212121"),BigInteger.Parse("111919191919373737372121212121717171717171"),BigInteger.Parse("111919191919373737372121212121717171717171101101101101101101101") };
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
public class A111478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111478Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111478.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111478.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111478Inst Instance=new A111478Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111479
{
public static readonly long[] Value={ 2L,1L,4L,11L,3L,617L,96L,1213L,1965L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111479Inst : IEnumerable<long>
{
public static readonly long[] Value=A111479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111479.Bytes);
public long this[int i]=>Value[i];

public static A111479Inst Instance=new A111479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111480
{
public static readonly BigInteger[] Value={ 211L,2113L,21137777L,2113777799999999999L,BigInteger.Parse("2113777799999999999111111") };
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
public class A111480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111480Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111480.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111480.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111480Inst Instance=new A111480Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111481
{
public static readonly long[] Value={ 4L,4L,5L,0L,1L,1L,3L,2L,5L,3L,0L,0L,9L,4L,6L,5L,4L,3L,2L,2L,2L,7L,6L,1L,2L,3L,2L,7L,0L,6L,0L,6L,2L,5L,7L,0L,9L,2L,7L,0L,2L,4L,4L,0L,8L,8L,6L,2L,9L,1L,4L,0L,8L,8L,0L,6L,2L,8L,2L,3L,9L,9L,3L,3L,3L,0L,0L,6L,5L,5L,3L,7L,8L,2L,7L,5L,9L,0L,7L,7L,2L,7L,7L,5L,8L,7L,1L,3L,5L,4L,1L,4L,6L,7L,6L,3L,1L,3L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111481Inst : IEnumerable<long>
{
public static readonly long[] Value=A111481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111481.Bytes);
public long this[int i]=>Value[i];

public static A111481Inst Instance=new A111481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111482
{
public static readonly long[] Value={ 0L,10L,120L,12403L,12403L,231540L,1053426L,10623745L,120784653L,1062489753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111482Inst : IEnumerable<long>
{
public static readonly long[] Value=A111482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111482.Bytes);
public long this[int i]=>Value[i];

public static A111482Inst Instance=new A111482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111483
{
public static readonly long[] Value={ 3L,55L,253L,325L,2775L,5253L,255255L,522753L,577275L,2235555L,2355535L,2532375L,3252525L,3352755L,7332535L,23273253L,25222753L,37372335L,55277355L,73235253L,222552253L,273253753L,325775575L,337337325L,577235253L,2373777253L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111483Inst : IEnumerable<long>
{
public static readonly long[] Value=A111483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111483.Bytes);
public long this[int i]=>Value[i];

public static A111483Inst Instance=new A111483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111484
{
public static readonly long[] Value={ 0L,1L,6L,10L,66L,91L,190L,406L,496L,666L,861L,946L,990L,1081L,1891L,4186L,6441L,8001L,8646L,8911L,9180L,10011L,10440L,14196L,16110L,19110L,19900L,40186L,41041L,41616L,49141L,64980L,66066L,69006L,80601L,81406L,81810L,84666L,88410L,90100L,91806L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111484Inst : IEnumerable<long>
{
public static readonly long[] Value=A111484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111484.Bytes);
public long this[int i]=>Value[i];

public static A111484Inst Instance=new A111484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111485
{
public static readonly long[] Value={ 1L,3L,12L,107L,951L,10923L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111485Inst : IEnumerable<long>
{
public static readonly long[] Value=A111485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111485.Bytes);
public long this[int i]=>Value[i];

public static A111485Inst Instance=new A111485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111486
{
public static readonly long[] Value={ 0L,0L,0L,3L,0L,4L,5L,8L,6L,4L,9L,0L,4L,5L,2L,1L,3L,4L,9L,9L,6L,8L,7L,8L,2L,7L,9L,9L,7L,8L,0L,3L,5L,0L,1L,7L,7L,5L,2L,3L,8L,1L,8L,4L,6L,6L,6L,5L,0L,0L,1L,6L,1L,3L,4L,4L,8L,0L,4L,9L,7L,9L,5L,9L,9L,4L,5L,2L,5L,6L,9L,0L,5L,4L,0L,8L,3L,3L,6L,7L,3L,7L,2L,5L,2L,4L,7L,7L,3L,2L,7L,6L,7L,8L,8L,8L,1L,7L,7L,8L,9L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111486Inst : IEnumerable<long>
{
public static readonly long[] Value=A111486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111486.Bytes);
public long this[int i]=>Value[i];

public static A111486Inst Instance=new A111486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111487
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,5L,3L,1L,5L,7L,6L,7L,2L,2L,6L,6L,7L,6L,4L,3L,4L,0L,3L,4L,5L,7L,6L,4L,8L,4L,9L,6L,7L,5L,3L,9L,6L,7L,1L,4L,3L,4L,9L,7L,6L,7L,4L,5L,3L,1L,3L,5L,0L,1L,8L,9L,1L,8L,3L,1L,9L,7L,5L,3L,3L,0L,4L,8L,3L,7L,6L,1L,9L,9L,2L,5L,0L,7L,4L,1L,5L,8L,1L,5L,3L,8L,5L,2L,9L,5L,3L,9L,0L,2L,9L,4L,2L,7L,5L,2L,3L,3L,3L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111487Inst : IEnumerable<long>
{
public static readonly long[] Value=A111487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111487.Bytes);
public long this[int i]=>Value[i];

public static A111487Inst Instance=new A111487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111488
{
public static readonly long[] Value={ 3L,11L,13L,31L,61L,101L,103L,113L,131L,163L,311L,313L,331L,601L,613L,631L,661L,1013L,1031L,1033L,1061L,1063L,1103L,1163L,1301L,1303L,1361L,1601L,1613L,1663L,3001L,3011L,3061L,3163L,3301L,3313L,3331L,3361L,3613L,3631L,6011L,6101L,6113L,6131L,6133L,6163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111488Inst : IEnumerable<long>
{
public static readonly long[] Value=A111488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111488.Bytes);
public long this[int i]=>Value[i];

public static A111488Inst Instance=new A111488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111489
{
public static readonly long[] Value={ 13L,31L,47L,67L,79L,89L,97L,103L,113L,149L,173L,179L,211L,223L,241L,277L,313L,349L,359L,379L,449L,457L,487L,503L,509L,631L,743L,769L,797L,809L,887L,937L,967L,1009L,1049L,1109L,1123L,1213L,1231L,1277L,1289L,1319L,1409L,1429L,1453L,1471L,1489L,1543L,1571L,1663L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111489Inst : IEnumerable<long>
{
public static readonly long[] Value=A111489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111489.Bytes);
public long this[int i]=>Value[i];

public static A111489Inst Instance=new A111489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111490
{
public static readonly long[] Value={ 1L,2L,4L,5L,9L,9L,15L,16L,21L,23L,33L,29L,41L,45L,51L,52L,68L,65L,83L,81L,91L,99L,121L,109L,128L,138L,152L,152L,180L,168L,198L,199L,217L,231L,253L,234L,270L,286L,308L,298L,338L,326L,368L,372L,384L,404L,450L,422L,463L,470L,500L,506L,558L,546L,584L,576L,610L,636L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111490Inst : IEnumerable<long>
{
public static readonly long[] Value=A111490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111490.Bytes);
public long this[int i]=>Value[i];

public static A111490Inst Instance=new A111490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111491
{
public static readonly BigInteger[] Value={ 1L,2L,5L,36L,539L,16710L,1052729L,133696584L,34092628919L,17421333377610L,17822024045295029L,BigInteger.Parse("36481683220718924364"),BigInteger.Parse("149392492788843995270579"),BigInteger.Parse("1223673908433421165261312590"),BigInteger.Parse("20047449641864738950476084161969"),BigInteger.Parse("656894782414981901190249849735238224") };
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
public class A111491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111491Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111491.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111491.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111491Inst Instance=new A111491Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111492
{
public static readonly long[] Value={ 1L,2L,1L,3L,3L,2L,4L,6L,8L,6L,5L,10L,20L,30L,24L,6L,15L,40L,90L,144L,120L,7L,21L,70L,210L,504L,840L,720L,8L,28L,112L,420L,1344L,3360L,5760L,5040L,9L,36L,168L,756L,3024L,10080L,25920L,45360L,40320L,10L,45L,240L,1260L,6048L,25200L,86400L,226800L,403200L,362880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111492Inst : IEnumerable<long>
{
public static readonly long[] Value=A111492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111492.Bytes);
public long this[int i]=>Value[i];

public static A111492Inst Instance=new A111492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111493
{
public static readonly long[] Value={ 0L,0L,0L,3L,0L,4L,6L,7L,9L,2L,9L,1L,6L,4L,8L,2L,9L,1L,5L,9L,2L,4L,9L,9L,5L,1L,4L,1L,9L,2L,2L,6L,3L,7L,0L,2L,7L,2L,6L,5L,3L,6L,6L,3L,5L,8L,5L,5L,8L,4L,3L,9L,7L,3L,7L,8L,0L,6L,8L,8L,5L,6L,2L,1L,3L,3L,9L,9L,7L,0L,7L,9L,9L,9L,7L,6L,5L,7L,6L,7L,1L,6L,5L,2L,2L,6L,6L,7L,1L,0L,9L,0L,6L,8L,8L,8L,9L,2L,3L,1L,2L,7L,2L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111493Inst : IEnumerable<long>
{
public static readonly long[] Value=A111493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111493.Bytes);
public long this[int i]=>Value[i];

public static A111493Inst Instance=new A111493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111494
{
public static readonly long[] Value={ 44L,66L,99L,494L,646L,946L,964L,969L,994L,4646L,4669L,4949L,4966L,4994L,4996L,6446L,6466L,6494L,6946L,6964L,6969L,6994L,9494L,9499L,9644L,9669L,9694L,9699L,9994L,44446L,44466L,44644L,44666L,44994L,46446L,46466L,46646L,46669L,46694L,46699L,46949L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111494Inst : IEnumerable<long>
{
public static readonly long[] Value=A111494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111494.Bytes);
public long this[int i]=>Value[i];

public static A111494Inst Instance=new A111494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111495
{
public static readonly long[] Value={ 0L,2L,4L,7L,9L,11L,14L,16L,18L,20L,23L,25L,27L,30L,32L,34L,37L,39L,41L,44L,46L,48L,50L,53L,55L,57L,60L,62L,64L,67L,69L,71L,73L,76L,78L,80L,83L,85L,87L,90L,92L,94L,97L,99L,101L,103L,106L,108L,110L,113L,115L,117L,120L,122L,124L,126L,129L,131L,133L,136L,138L,140L,143L,145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111495Inst : IEnumerable<long>
{
public static readonly long[] Value=A111495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111495.Bytes);
public long this[int i]=>Value[i];

public static A111495Inst Instance=new A111495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111496
{
public static readonly long[] Value={ 444L,644L,664L,666L,966L,996L,999L,4444L,4466L,4494L,4696L,4964L,6644L,6666L,6699L,9444L,9496L,9646L,9964L,9966L,9999L,44444L,44499L,44646L,44996L,46444L,46449L,46964L,46996L,49444L,49494L,49946L,49966L,49996L,64446L,64494L,64644L,64666L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111496Inst : IEnumerable<long>
{
public static readonly long[] Value=A111496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111496.Bytes);
public long this[int i]=>Value[i];

public static A111496Inst Instance=new A111496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111497
{
public static readonly long[] Value={ 2L,3L,2L,2L,2L,2L,3L,2L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,2L,3L,2L,2L,2L,2L,3L,2L,2L,2L,2L,3L,2L,2L,2L,2L,3L,2L,2L,2L,2L,3L,2L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,2L,3L,2L,2L,2L,2L,3L,2L,2L,2L,2L,3L,2L,2L,2L,2L,3L,2L,2L,2L,2L,3L,2L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,2L,3L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111497Inst : IEnumerable<long>
{
public static readonly long[] Value=A111497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111497.Bytes);
public long this[int i]=>Value[i];

public static A111497Inst Instance=new A111497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111498
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,5L,3L,1L,8L,1L,9L,6L,8L,1L,8L,0L,0L,4L,2L,7L,1L,7L,6L,4L,1L,4L,7L,7L,6L,1L,3L,7L,5L,7L,6L,1L,0L,0L,5L,8L,5L,9L,2L,9L,5L,6L,2L,1L,6L,8L,6L,4L,9L,6L,4L,0L,5L,9L,1L,0L,2L,1L,3L,2L,2L,9L,2L,6L,8L,1L,5L,3L,0L,4L,9L,2L,9L,7L,9L,7L,4L,4L,4L,4L,6L,3L,8L,9L,2L,8L,3L,4L,5L,0L,3L,5L,5L,6L,9L,2L,6L,6L,9L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111498Inst : IEnumerable<long>
{
public static readonly long[] Value=A111498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111498.Bytes);
public long this[int i]=>Value[i];

public static A111498Inst Instance=new A111498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111499
{
public static readonly long[] Value={ 1L,3L,4L,7L,9L,11L,14L,16L,18L,20L,23L,25L,27L,30L,32L,34L,37L,39L,41L,44L,46L,48L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111499Inst : IEnumerable<long>
{
public static readonly long[] Value=A111499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111499.Bytes);
public long this[int i]=>Value[i];

public static A111499Inst Instance=new A111499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111500
{
public static readonly long[] Value={ 1L,10L,31L,72L,137L,234L,367L,544L,769L,1050L,1391L,1800L,2281L,2842L,3487L,4224L,5057L,5994L,7039L,8200L,9481L,10890L,12431L,14112L,15937L,17914L,20047L,22344L,24809L,27450L,30271L,33280L,36481L,39882L,43487L,47304L,51337L,55594L,60079L,64800L,69761L,74970L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111500Inst : IEnumerable<long>
{
public static readonly long[] Value=A111500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111500.Bytes);
public long this[int i]=>Value[i];

public static A111500Inst Instance=new A111500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111501
{
public static readonly long[] Value={ 2L,3L,5L,6L,8L,13L,14L,21L,24L,26L,28L,29L,33L,34L,35L,36L,40L,43L,45L,48L,49L,50L,51L,55L,58L,76L,80L,83L,89L,90L,93L,96L,99L,100L,101L,104L,110L,111L,115L,118L,120L,121L,124L,133L,135L,138L,140L,148L,149L,161L,170L,173L,181L,190L,191L,194L,195L,201L,203L,204L,205L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111501Inst : IEnumerable<long>
{
public static readonly long[] Value=A111501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111501.Bytes);
public long this[int i]=>Value[i];

public static A111501Inst Instance=new A111501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111502
{
public static readonly long[] Value={ 33L,48L,203L,6648L,27048L,63293L,80288L,168348L,194298L,201178L,218888L,280103L,310828L,313668L,315448L,341893L,375298L,405958L,440643L,479668L,520058L,611868L,615893L,628068L,632533L,666973L,812888L,882728L,883643L,941143L,950983L,971158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111502Inst : IEnumerable<long>
{
public static readonly long[] Value=A111502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111502.Bytes);
public long this[int i]=>Value[i];

public static A111502Inst Instance=new A111502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111503
{
public static readonly long[] Value={ 2L,3L,6L,13L,21L,33L,48L,58L,90L,96L,99L,100L,111L,118L,120L,121L,133L,138L,195L,204L,279L,334L,348L,366L,393L,400L,465L,525L,541L,565L,594L,721L,736L,789L,855L,859L,925L,946L,1044L,1099L,1239L,1279L,1323L,1410L,1459L,1470L,1513L,1521L,1524L,1629L,1630L,1638L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111503Inst : IEnumerable<long>
{
public static readonly long[] Value=A111503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111503.Bytes);
public long this[int i]=>Value[i];

public static A111503Inst Instance=new A111503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111504
{
public static readonly long[] Value={ 5L,6L,64L,210L,265L,364L,440L,475L,625L,680L,785L,806L,839L,925L,930L,931L,951L,1044L,1105L,1224L,1226L,1559L,1636L,1651L,1699L,1835L,1850L,1966L,1995L,2295L,2309L,2511L,2541L,2655L,2984L,3100L,3501L,3680L,4159L,4444L,4474L,4580L,4606L,4755L,4779L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111504Inst : IEnumerable<long>
{
public static readonly long[] Value=A111504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111504.Bytes);
public long this[int i]=>Value[i];

public static A111504Inst Instance=new A111504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111505
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,0L,0L,3L,1L,0L,0L,6L,4L,1L,0L,0L,0L,10L,5L,1L,0L,0L,0L,20L,15L,6L,1L,0L,0L,0L,0L,35L,21L,7L,1L,0L,0L,0L,0L,70L,56L,28L,8L,1L,0L,0L,0L,0L,0L,126L,84L,36L,9L,1L,0L,0L,0L,0L,0L,252L,210L,120L,45L,10L,1L,0L,0L,0L,0L,0L,0L,462L,330L,165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111505Inst : IEnumerable<long>
{
public static readonly long[] Value=A111505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111505.Bytes);
public long this[int i]=>Value[i];

public static A111505Inst Instance=new A111505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111506
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,9L,2L,7L,7L,2L,9L,3L,0L,1L,6L,5L,9L,4L,8L,5L,2L,3L,6L,1L,5L,0L,5L,8L,5L,6L,6L,8L,9L,6L,0L,4L,8L,5L,5L,4L,0L,5L,4L,2L,1L,3L,0L,2L,9L,3L,0L,5L,4L,7L,6L,2L,9L,9L,2L,4L,7L,1L,0L,6L,8L,0L,3L,0L,8L,8L,2L,1L,7L,2L,1L,8L,9L,0L,4L,1L,1L,0L,9L,0L,8L,8L,8L,4L,2L,2L,7L,3L,2L,2L,6L,8L,2L,6L,0L,2L,5L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111506Inst : IEnumerable<long>
{
public static readonly long[] Value=A111506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111506.Bytes);
public long this[int i]=>Value[i];

public static A111506Inst Instance=new A111506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111507
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,6L,1L,9L,1L,1L,0L,8L,8L,3L,6L,3L,3L,8L,5L,3L,8L,0L,6L,7L,4L,7L,2L,0L,2L,7L,1L,1L,4L,0L,2L,8L,2L,1L,0L,6L,8L,0L,9L,5L,0L,1L,7L,1L,5L,6L,0L,6L,4L,5L,2L,0L,0L,4L,5L,9L,9L,8L,4L,4L,4L,8L,8L,4L,1L,4L,4L,5L,1L,1L,5L,1L,8L,5L,3L,9L,6L,9L,3L,5L,9L,5L,1L,3L,2L,9L,8L,5L,9L,4L,6L,3L,9L,3L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111507Inst : IEnumerable<long>
{
public static readonly long[] Value=A111507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111507.Bytes);
public long this[int i]=>Value[i];

public static A111507Inst Instance=new A111507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111508
{
public static readonly long[] Value={ 1L,0L,1L,7L,6L,0L,5L,5L,8L,9L,5L,2L,2L,7L,8L,4L,7L,1L,8L,4L,2L,7L,4L,0L,2L,1L,6L,1L,4L,7L,6L,4L,6L,4L,7L,0L,7L,5L,3L,7L,0L,9L,8L,0L,4L,1L,3L,4L,1L,6L,2L,4L,8L,4L,4L,8L,9L,5L,2L,4L,4L,9L,5L,7L,1L,0L,2L,8L,4L,9L,0L,4L,8L,7L,7L,9L,9L,8L,8L,9L,3L,7L,4L,2L,9L,9L,1L,0L,9L,9L,7L,8L,4L,6L,2L,7L,4L,4L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111508Inst : IEnumerable<long>
{
public static readonly long[] Value=A111508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111508.Bytes);
public long this[int i]=>Value[i];

public static A111508Inst Instance=new A111508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111509
{
public static readonly long[] Value={ 9L,8L,2L,6L,9L,9L,0L,0L,4L,6L,9L,8L,8L,2L,3L,4L,2L,3L,5L,5L,1L,0L,2L,4L,9L,7L,6L,6L,3L,0L,7L,3L,9L,7L,6L,0L,7L,3L,3L,7L,5L,6L,6L,6L,0L,6L,8L,3L,3L,8L,0L,5L,5L,5L,2L,1L,8L,8L,4L,8L,6L,1L,9L,7L,3L,4L,2L,7L,5L,2L,2L,7L,5L,6L,0L,1L,6L,5L,3L,3L,0L,4L,0L,8L,6L,9L,0L,9L,3L,9L,0L,6L,9L,3L,0L,0L,7L,6L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111509Inst : IEnumerable<long>
{
public static readonly long[] Value=A111509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111509.Bytes);
public long this[int i]=>Value[i];

public static A111509Inst Instance=new A111509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111510
{
public static readonly long[] Value={ 6L,19L,90L,282L,945L,2976L,9450L,29725L,93555L,294029L,924042L,2903286L,9121612L,28657229L,90030845L,282842357L,888579011L,2791558571L,8769948430L,27551618646L,86555983553L,271923674412L,854273468992L,2683779334264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111510Inst : IEnumerable<long>
{
public static readonly long[] Value=A111510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111510.Bytes);
public long this[int i]=>Value[i];

public static A111510Inst Instance=new A111510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111511
{
public static readonly long[] Value={ 4L,0L,4L,8L,2L,7L,7L,7L,3L,5L,1L,2L,6L,2L,9L,4L,4L,7L,0L,9L,8L,5L,3L,1L,6L,5L,6L,1L,6L,6L,5L,5L,5L,3L,9L,1L,8L,0L,0L,3L,5L,0L,8L,7L,5L,1L,2L,3L,6L,2L,9L,3L,9L,0L,9L,7L,7L,2L,2L,8L,6L,4L,1L,9L,7L,0L,6L,0L,4L,6L,1L,4L,2L,7L,2L,5L,8L,6L,8L,8L,8L,9L,2L,4L,5L,2L,6L,8L,4L,2L,0L,9L,9L,1L,4L,0L,8L,3L,8L,5L,0L,3L,8L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111511Inst : IEnumerable<long>
{
public static readonly long[] Value=A111511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111511.Bytes);
public long this[int i]=>Value[i];

public static A111511Inst Instance=new A111511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111512
{
public static readonly long[] Value={ 2L,4L,7L,0L,1L,8L,6L,2L,5L,0L,6L,1L,9L,9L,8L,8L,4L,3L,6L,6L,9L,8L,1L,9L,1L,5L,9L,9L,2L,1L,0L,1L,9L,1L,0L,6L,6L,6L,9L,9L,0L,1L,8L,7L,7L,5L,9L,3L,3L,7L,9L,1L,3L,8L,3L,4L,4L,6L,0L,6L,9L,4L,7L,6L,8L,9L,4L,9L,4L,9L,1L,9L,0L,5L,6L,9L,3L,0L,2L,7L,2L,6L,0L,1L,0L,6L,5L,1L,3L,0L,8L,3L,6L,6L,9L,1L,5L,2L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111512Inst : IEnumerable<long>
{
public static readonly long[] Value=A111512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111512.Bytes);
public long this[int i]=>Value[i];

public static A111512Inst Instance=new A111512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111513
{
public static readonly long[] Value={ 1L,7L,5L,8L,1L,4L,4L,6L,8L,1L,5L,7L,7L,1L,4L,3L,7L,8L,9L,8L,2L,1L,9L,3L,5L,8L,7L,6L,5L,7L,3L,6L,7L,8L,5L,6L,7L,6L,9L,2L,6L,8L,3L,9L,6L,3L,2L,0L,2L,0L,4L,6L,8L,0L,7L,2L,4L,7L,0L,6L,9L,3L,7L,1L,1L,4L,7L,5L,5L,8L,4L,0L,9L,7L,7L,4L,6L,2L,6L,8L,4L,0L,8L,0L,0L,1L,6L,0L,3L,7L,3L,9L,7L,2L,9L,5L,4L,1L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111513Inst : IEnumerable<long>
{
public static readonly long[] Value=A111513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111513.Bytes);
public long this[int i]=>Value[i];

public static A111513Inst Instance=new A111513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111514
{
public static readonly long[] Value={ 5L,6L,8L,7L,8L,1L,4L,0L,3L,7L,5L,9L,6L,4L,3L,9L,1L,1L,2L,7L,0L,3L,0L,2L,5L,7L,5L,3L,3L,2L,0L,7L,3L,8L,5L,4L,3L,9L,2L,4L,7L,5L,8L,2L,2L,6L,4L,6L,9L,2L,5L,8L,6L,7L,2L,8L,4L,9L,2L,0L,8L,9L,9L,6L,1L,5L,2L,5L,8L,7L,5L,6L,3L,6L,9L,6L,4L,2L,0L,6L,0L,2L,5L,7L,9L,8L,7L,9L,8L,1L,6L,0L,9L,5L,0L,7L,5L,5L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111514Inst : IEnumerable<long>
{
public static readonly long[] Value=A111514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111514.Bytes);
public long this[int i]=>Value[i];

public static A111514Inst Instance=new A111514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111515
{
public static readonly long[] Value={ 1L,5L,176L,56L,4565L,385L,63261L,1958L,614154L,8349L,4697205L,31185L,30167357L,105558L,169229875L,329931L,851376628L,966467L,3913864295L,2679689L,16670689208L,7089500L,66493182097L,18004327L,250438925115L,44108109L,896684817527L,104651419L,3068829878530L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111515Inst : IEnumerable<long>
{
public static readonly long[] Value=A111515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111515.Bytes);
public long this[int i]=>Value[i];

public static A111515Inst Instance=new A111515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111516
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,4L,1L,7L,12L,18L,1L,15L,32L,56L,88L,1L,31L,80L,160L,280L,450L,1L,63L,192L,432L,832L,1452L,2364L,1L,127L,448L,1120L,2352L,4244L,7700L,12642L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111516Inst : IEnumerable<long>
{
public static readonly long[] Value=A111516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111516.Bytes);
public long this[int i]=>Value[i];

public static A111516Inst Instance=new A111516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111517
{
public static readonly long[] Value={ 3L,15L,19L,31L,39L,43L,51L,55L,75L,79L,99L,111L,123L,139L,159L,163L,171L,175L,183L,195L,211L,231L,235L,259L,279L,283L,291L,295L,303L,315L,319L,339L,343L,351L,379L,411L,415L,423L,435L,451L,459L,463L,475L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111517Inst : IEnumerable<long>
{
public static readonly long[] Value=A111517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111517.Bytes);
public long this[int i]=>Value[i];

public static A111517Inst Instance=new A111517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111518
{
public static readonly long[] Value={ 1L,0L,-3L,-4L,7L,11L,-62L,-14L,581L,-1235L,-4175L,32520L,-48359L,-443625L,3136662L,-4834644L,-60319241L,506792496L,-1210299173L,-10327456109L,122982395262L,-496826354929L,-1709350378156L,39417717346686L,-259877263864213L,162788318972691L,14331409095176010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111518Inst : IEnumerable<long>
{
public static readonly long[] Value=A111518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111518.Bytes);
public long this[int i]=>Value[i];

public static A111518Inst Instance=new A111518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111519
{
public static readonly long[] Value={ 1L,1L,-2L,-6L,1L,12L,-50L,-64L,517L,-718L,-4893L,27627L,-20732L,-464357L,2672305L,-2162339L,-62481580L,444310916L,-765988257L,-11093444366L,111888950896L,-384937404033L,-2094287782189L,37323429564497L,-222553834299716L,-59765515327025L,14271643579848985L,-141966128047629231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111519Inst : IEnumerable<long>
{
public static readonly long[] Value=A111519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111519.Bytes);
public long this[int i]=>Value[i];

public static A111519Inst Instance=new A111519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111520
{
public static readonly long[] Value={ 1L,2L,0L,-6L,-5L,7L,-43L,-107L,410L,-308L,-5201L,22426L,1694L,-462663L,2209642L,47303L,-62434277L,381876639L,-384111618L,-11477555984L,100411394912L,-284526009121L,-2378813791310L,34944615773187L,-187609218526529L,-247374733853554L,14024268845995431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111520Inst : IEnumerable<long>
{
public static readonly long[] Value=A111520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111520.Bytes);
public long this[int i]=>Value[i];

public static A111520Inst Instance=new A111520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111521
{
public static readonly long[] Value={ 1L,3L,3L,-3L,-8L,-1L,-44L,-151L,259L,-49L,-5250L,17176L,18870L,-443793L,1765849L,1813152L,-60621125L,321255514L,-62856104L,-11540412088L,88870982824L,-195655026297L,-2574468817607L,32370146955580L,-155239071570949L,-402613805424503L,13621655040570928L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111521Inst : IEnumerable<long>
{
public static readonly long[] Value=A111521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111521.Bytes);
public long this[int i]=>Value[i];

public static A111521Inst Instance=new A111521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111522
{
public static readonly long[] Value={ 1L,4L,7L,4L,-4L,-5L,-49L,-200L,59L,10L,-5240L,11936L,30806L,-412987L,1352862L,3166014L,-57455111L,263800403L,200944299L,-11339467789L,77531515035L,-118123511262L,-2692592328869L,29677554626711L,-125561516944238L,-528175322368741L,13093479718202187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111522Inst : IEnumerable<long>
{
public static readonly long[] Value=A111522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111522.Bytes);
public long this[int i]=>Value[i];

public static A111522Inst Instance=new A111522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111523
{
public static readonly long[] Value={ 1L,5L,12L,16L,12L,7L,-42L,-242L,-183L,-173L,-5413L,6523L,37329L,-375658L,977204L,4143218L,-53311893L,210488510L,411432809L,-10928034980L,66603480055L,-51520031207L,-2744112360076L,26933442266635L,-98628074677603L,-626803397046344L,12466676321155843L,-88760048121704842L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111523Inst : IEnumerable<long>
{
public static readonly long[] Value=A111523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111523.Bytes);
public long this[int i]=>Value[i];

public static A111523Inst Instance=new A111523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111524
{
public static readonly long[] Value={ 10L,13L,23L,49L,111L,113L,171L,211L,293L,309L,309L,469L,639L,759L,951L,1037L,1057L,1083L,1257L,1269L,1287L,1341L,1551L,1637L,1677L,1981L,1989L,2021L,2059L,2357L,2583L,2697L,2967L,3289L,6789L,7073L,7323L,7369L,7463L,7501L,7709L,7869L,8029L,8069L,8077L,8519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111524Inst : IEnumerable<long>
{
public static readonly long[] Value=A111524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111524.Bytes);
public long this[int i]=>Value[i];

public static A111524Inst Instance=new A111524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111525
{
public static readonly long[] Value={ 10L,1L,3L,3L,3L,29L,1L,3L,3L,11L,9L,7L,23L,61L,11L,3L,91L,137L,7L,11L,31L,93L,17L,9L,273L,51L,397L,9L,99L,41L,111L,129L,111L,801L,109L,131L,297L,37L,621L,21L,807L,143L,87L,57L,231L,187L,53L,169L,77L,613L,867L,41L,199L,773L,523L,227L,27L,499L,171L,329L,67L,483L,393L,179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111525Inst : IEnumerable<long>
{
public static readonly long[] Value=A111525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111525.Bytes);
public long this[int i]=>Value[i];

public static A111525Inst Instance=new A111525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111526
{
public static readonly long[] Value={ 1L,0L,1L,3L,0L,1L,0L,4L,0L,1L,5L,0L,5L,0L,1L,0L,9L,0L,6L,0L,1L,7L,0L,14L,0L,7L,0L,1L,0L,16L,0L,20L,0L,8L,0L,1L,9L,0L,30L,0L,27L,0L,9L,0L,1L,0L,25L,0L,50L,0L,35L,0L,10L,0L,1L,11L,0L,55L,0L,77L,0L,44L,0L,11L,0L,1L,0L,36L,0L,105L,0L,112L,0L,54L,0L,12L,0L,1L,13L,0L,91L,0L,182L,0L,156L,0L,65L,0L,13L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111526Inst : IEnumerable<long>
{
public static readonly long[] Value=A111526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111526.Bytes);
public long this[int i]=>Value[i];

public static A111526Inst Instance=new A111526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111527
{
public static readonly long[] Value={ 1L,0L,1L,-3L,0L,1L,0L,-4L,0L,1L,10L,0L,-5L,0L,1L,0L,15L,0L,-6L,0L,1L,-35L,0L,21L,0L,-7L,0L,1L,0L,-56L,0L,28L,0L,-8L,0L,1L,126L,0L,-84L,0L,36L,0L,-9L,0L,1L,0L,210L,0L,-120L,0L,45L,0L,-10L,0L,1L,-462L,0L,330L,0L,-165L,0L,55L,0L,-11L,0L,1L,0L,-792L,0L,495L,0L,-220L,0L,66L,0L,-12L,0L,1L,1716L,0L,-1287L,0L,715L,0L,-286L,0L,78L,0L,-13L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111527Inst : IEnumerable<long>
{
public static readonly long[] Value=A111527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111527.Bytes);
public long this[int i]=>Value[i];

public static A111527Inst Instance=new A111527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111528
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,3L,6L,1L,1L,4L,13L,24L,1L,1L,5L,22L,71L,120L,1L,1L,6L,33L,148L,461L,720L,1L,1L,7L,46L,261L,1156L,3447L,5040L,1L,1L,8L,61L,416L,2361L,10192L,29093L,40320L,1L,1L,9L,78L,619L,4256L,23805L,99688L,273343L,362880L,1L,1L,10L,97L,876L,7045L,48096L,263313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111528Inst : IEnumerable<long>
{
public static readonly long[] Value=A111528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111528.Bytes);
public long this[int i]=>Value[i];

public static A111528Inst Instance=new A111528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111529
{
public static readonly BigInteger[] Value={ 1L,1L,4L,22L,148L,1156L,10192L,99688L,1069168L,12468208L,157071424L,2126386912L,30797423680L,475378906432L,7793485765888L,135284756985472L,2479535560687360L,47860569736036096L,970606394944476160L,BigInteger.Parse("20635652201785613824"),BigInteger.Parse("459015456156148876288"),BigInteger.Parse("10662527360021306782720") };
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
public class A111529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111529Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111529.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111529.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111529Inst Instance=new A111529Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111530
{
public static readonly long[] Value={ 1L,1L,5L,33L,261L,2361L,23805L,263313L,3161781L,40907241L,567074925L,8385483393L,131787520101L,2194406578521L,38605941817245L,715814473193073L,13956039627763221L,285509132504621001L,6116719419966460365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111530Inst : IEnumerable<long>
{
public static readonly long[] Value=A111530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111530.Bytes);
public long this[int i]=>Value[i];

public static A111530Inst Instance=new A111530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111531
{
public static readonly BigInteger[] Value={ 1L,1L,6L,46L,416L,4256L,48096L,591536L,7840576L,111226816L,1680157056L,26918720896L,455971214336L,8143926373376L,153013563734016L,3017996904928256L,62369444355076096L,1348096649995841536L,BigInteger.Parse("30426167700424728576"),BigInteger.Parse("715935203128235401216") };
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
public class A111531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111531Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111531.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111531.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111531Inst Instance=new A111531Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111532
{
public static readonly long[] Value={ 1L,1L,7L,61L,619L,7045L,87955L,1187845L,17192275L,264940405L,4326439075L,74593075525L,1353928981075L,25809901069525L,515683999204675L,10779677853137125L,235366439343773875L,5359766538695291125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111532Inst : IEnumerable<long>
{
public static readonly long[] Value=A111532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111532.Bytes);
public long this[int i]=>Value[i];

public static A111532Inst Instance=new A111532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111533
{
public static readonly BigInteger[] Value={ 1L,1L,8L,78L,876L,10956L,149472L,2195208L,34398288L,571525200L,10022997888L,184897670112L,3578224662720L,72486450479808L,1534267158087168L,33877135427154048L,779208751651730688L,BigInteger.Parse("18645519786163266816") };
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
public class A111533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111533Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111533.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111533.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111533Inst Instance=new A111533Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111534
{
public static readonly BigInteger[] Value={ 1L,1L,4L,33L,416L,7045L,149472L,3804353L,112784896L,3812791581L,144643185600L,6081135558817L,280510445260800L,14080668974435141L,763890295406672896L,BigInteger.Parse("44529851124925034625"),BigInteger.Parse("2775373003913373810688"),BigInteger.Parse("184147301185264051623181") };
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
public class A111534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111534Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111534.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111534.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111534Inst Instance=new A111534Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111535
{
public static readonly BigInteger[] Value={ 1L,2L,11L,104L,1409L,24912L,543479L,14098112L,423643509L,14464318560L,552830505347L,23375870438400L,1083128382648857L,54563592529048064L,2968656741661668975L,BigInteger.Parse("173460812744585863168"),BigInteger.Parse("10832194187368473624893") };
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
public class A111535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111535Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111535.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111535.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111535Inst Instance=new A111535Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111536
{
public static readonly long[] Value={ 1L,1L,1L,4L,2L,1L,22L,8L,3L,1L,148L,44L,14L,4L,1L,1156L,296L,84L,22L,5L,1L,10192L,2312L,600L,148L,32L,6L,1L,99688L,20384L,4908L,1156L,242L,44L,7L,1L,1069168L,199376L,44952L,10192L,2084L,372L,58L,8L,1L,12468208L,2138336L,454344L,99688L,20012L,3528L,544L,74L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111536Inst : IEnumerable<long>
{
public static readonly long[] Value=A111536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111536.Bytes);
public long this[int i]=>Value[i];

public static A111536Inst Instance=new A111536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111537
{
public static readonly BigInteger[] Value={ 1L,2L,8L,44L,296L,2312L,20384L,199376L,2138336L,24936416L,314142848L,4252773824L,61594847360L,950757812864L,15586971531776L,270569513970944L,4959071121374720L,95721139472072192L,1941212789888952320L,BigInteger.Parse("41271304403571227648"),BigInteger.Parse("918030912312297752576"),BigInteger.Parse("21325054720042613565440") };
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
public class A111537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111537Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111537.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111537.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111537Inst Instance=new A111537Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111538
{
public static readonly long[] Value={ 1L,3L,14L,84L,600L,4908L,44952L,454344L,5016768L,60062352L,775089312L,10728930912L,158638465536L,2496437377728L,41674737264000L,735831528563328L,13704461848753152L,268562085051533568L,5525005742876244480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111538Inst : IEnumerable<long>
{
public static readonly long[] Value=A111538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111538.Bytes);
public long this[int i]=>Value[i];

public static A111538Inst Instance=new A111538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111539
{
public static readonly long[] Value={ 1L,2L,7L,34L,211L,1564L,13291L,126430L,1326211L,15184744L,188348659L,2515991290L,36018842875L,550317892372L,8940695112331L,153950966471734L,2801321782936819L,53720913548093344L,1083061044893428675L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111539Inst : IEnumerable<long>
{
public static readonly long[] Value=A111539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111539.Bytes);
public long this[int i]=>Value[i];

public static A111539Inst Instance=new A111539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111540
{
public static readonly long[] Value={ 1L,-1L,1L,-2L,-2L,1L,-8L,-2L,-3L,1L,-44L,-8L,-2L,-4L,1L,-296L,-44L,-8L,-2L,-5L,1L,-2312L,-296L,-44L,-8L,-2L,-6L,1L,-20384L,-2312L,-296L,-44L,-8L,-2L,-7L,1L,-199376L,-20384L,-2312L,-296L,-44L,-8L,-2L,-8L,1L,-2138336L,-199376L,-20384L,-2312L,-296L,-44L,-8L,-2L,-9L,1L,-24936416L,-2138336L,-199376L,-20384L,-2312L,-296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111540Inst : IEnumerable<long>
{
public static readonly long[] Value=A111540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111540.Bytes);
public long this[int i]=>Value[i];

public static A111540Inst Instance=new A111540Inst();

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