using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A201257
{
public static readonly long[] Value={ 457L,3593L,56009L,384113L,681361L,1835017L,2201033L,3072841L,4770313L,7000009L,7874057L,14680073L,16842737L,30876617L,32020081L,38162441L,52706761L,61192721L,72521633L,160344137L,163755601L,170723009L,181540361L,185245153L,208537009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201257Inst : IEnumerable<long>
{
public static readonly long[] Value=A201257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201257.Bytes);
public long this[int i]=>Value[i];

public static A201257Inst Instance=new A201257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201258
{
public static readonly long[] Value={ 17L,199L,2411L,5113L,48023L,137791L,354581L,556559L,823553L,1588877L,4609531L,5275007L,14338691L,15026833L,18799343L,19622557L,27089261L,33787673L,55164203L,56844217L,71528201L,73524223L,84062933L,86284747L,93184381L,100442359L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201258Inst : IEnumerable<long>
{
public static readonly long[] Value=A201258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201258.Bytes);
public long this[int i]=>Value[i];

public static A201258Inst Instance=new A201258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201259
{
public static readonly long[] Value={ 3L,11L,67L,4099L,10651L,17579L,32771L,125003L,140611L,238331L,262147L,405227L,438979L,636059L,830587L,1000003L,1124867L,1191019L,1906627L,2744003L,2863291L,4410947L,4574299L,5451779L,6028571L,6229507L,6859003L,8242411L,9528131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201259Inst : IEnumerable<long>
{
public static readonly long[] Value=A201259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201259.Bytes);
public long this[int i]=>Value[i];

public static A201259Inst Instance=new A201259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201260
{
public static readonly long[] Value={ 5L,13L,1733L,2749L,13829L,17581L,54877L,74093L,110597L,175621L,287501L,474557L,636061L,778693L,1124869L,1560901L,2000381L,2628077L,3112141L,4410949L,6434861L,7077893L,7301389L,7762397L,11239429L,14172493L,18399749L,21024581L,25934341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201260Inst : IEnumerable<long>
{
public static readonly long[] Value=A201260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201260.Bytes);
public long this[int i]=>Value[i];

public static A201260Inst Instance=new A201260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201261
{
public static readonly long[] Value={ 7L,71L,223L,5839L,13831L,46663L,64007L,262151L,287503L,438983L,830591L,884743L,1481551L,1643039L,2985991L,3375007L,5268031L,5639759L,5832007L,8998919L,11852359L,14886943L,15625007L,18399751L,19683007L,28652623L,29791007L,76225031L,77308783L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201261Inst : IEnumerable<long>
{
public static readonly long[] Value=A201261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201261.Bytes);
public long this[int i]=>Value[i];

public static A201261Inst Instance=new A201261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201262
{
public static readonly long[] Value={ 17L,73L,521L,1009L,2753L,8009L,10657L,21961L,39313L,54881L,85193L,140617L,195121L,262153L,314441L,512009L,681481L,778697L,941201L,1404937L,3241801L,3511817L,4410953L,4913009L,6028577L,6229513L,6644681L,6859009L,8000009L,8998921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201262Inst : IEnumerable<long>
{
public static readonly long[] Value=A201262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201262.Bytes);
public long this[int i]=>Value[i];

public static A201262Inst Instance=new A201262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201263
{
public static readonly long[] Value={ 73L,577L,9001L,24697L,52489L,197569L,353737L,576001L,995329L,1125001L,1756009L,2144953L,2829889L,4270969L,5334337L,6561001L,8470729L,10123777L,11337409L,12644353L,15552001L,16342633L,17159617L,20699713L,23652649L,25769593L,30375001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201263Inst : IEnumerable<long>
{
public static readonly long[] Value=A201263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201263.Bytes);
public long this[int i]=>Value[i];

public static A201263Inst Instance=new A201263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201264
{
public static readonly long[] Value={ 2L,11L,3089L,6563L,11981L,140627L,219503L,385877L,4782971L,7716377L,23142179L,28588709L,30986561L,37559531L,40429127L,43441283L,68808359L,84545381L,91964819L,132355127L,138944243L,191285399L,221779541L,255353627L,320501603L,369572627L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201264Inst : IEnumerable<long>
{
public static readonly long[] Value=A201264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201264.Bytes);
public long this[int i]=>Value[i];

public static A201264Inst Instance=new A201264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201265
{
public static readonly long[] Value={ 13L,1129L,19777L,44221L,109507L,140629L,268123L,455881L,715567L,820129L,2471629L,3796879L,4108801L,9272713L,12308683L,13687879L,15944053L,18435451L,25228993L,26317867L,27437629L,32234197L,41917171L,45001903L,49907101L,53367673L,73085413L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201265Inst : IEnumerable<long>
{
public static readonly long[] Value=A201265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201265.Bytes);
public long this[int i]=>Value[i];

public static A201265Inst Instance=new A201265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201266
{
public static readonly long[] Value={ 9L,16L,16L,27L,49L,22L,26L,81L,32L,125L,32L,81L,32L,81L,125L,81L,32L,32L,169L,81L,37L,343L,41L,289L,43L,87L,343L,93L,47L,361L,53L,111L,529L,59L,343L,61L,123L,129L,361L,64L,141L,64L,1331L,625L,64L,625L,64L,159L,529L,64L,177L,64L,183L,625L,1331L,64L,201L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201266Inst : IEnumerable<long>
{
public static readonly long[] Value=A201266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201266.Bytes);
public long this[int i]=>Value[i];

public static A201266Inst Instance=new A201266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201267
{
public static readonly long[] Value={ 1L,2L,3L,11L,2L,16L,4L,7L,4L,12L,5L,2L,41L,3L,11L,13L,3L,4L,22L,19L,2L,12L,27L,29L,9L,18L,8L,39L,94L,14L,13L,35L,101L,44L,122L,36L,2L,4L,60L,11L,7L,129L,4L,25L,18L,27L,19L,77L,62L,35L,14L,229L,74L,7L,29L,4L,32L,88L,132L,30L,2L,154L,511L,71L,59L,9L,127L,2L,47L,20L,34L,54L,22L,34L,57L,56L,68L,16L,45L,298L,57L,169L,13L,134L,45L,39L,120L,77L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201267Inst : IEnumerable<long>
{
public static readonly long[] Value=A201267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201267.Bytes);
public long this[int i]=>Value[i];

public static A201267Inst Instance=new A201267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201268
{
public static readonly long[] Value={ 52488L,15336L,-20088L,219375L,-293625L,-474552L,1367631L,-297L,100872L,-105624L,6021000L,-6615000L,40608000L,-45360000L,-423360000L,69641775L,-72560097L,110160000L,-114912000L,-1216512L,1418946687L,-1507379625L,1450230912L,-1533752064L,2143550952L,4566375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201268Inst : IEnumerable<long>
{
public static readonly long[] Value=A201268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201268.Bytes);
public long this[int i]=>Value[i];

public static A201268Inst Instance=new A201268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201269
{
public static readonly long[] Value={ 85580L,154396L,240004L,476425L,767125L,2555956L,5518439L,28748141L,37172564L,40080716L,46823500L,54615700L,80311375L,96251275L,436925600L,1304261335L,1394880175L,1526959675L,1636213375L,1839881024L,2212438625L,2442495725L,2716194871L,2976815179L,3155294924L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201269Inst : IEnumerable<long>
{
public static readonly long[] Value=A201269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201269.Bytes);
public long this[int i]=>Value[i];

public static A201269Inst Instance=new A201269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201270
{
public static readonly long[] Value={ 3L,5L,7L,85L,556L,1260L,27008L,215577L,613916L,16442049L,152673459L,487975060L,14392411292L,144918917509L,496264541787L,15559415313705L,165127072154120L,592098075114238L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201270Inst : IEnumerable<long>
{
public static readonly long[] Value=A201270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201270.Bytes);
public long this[int i]=>Value[i];

public static A201270Inst Instance=new A201270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201271
{
public static readonly long[] Value={ 3L,5L,4L,12L,16L,9L,27L,33L,16L,48L,56L,25L,75L,85L,36L,108L,120L,49L,147L,161L,64L,192L,208L,81L,243L,261L,100L,300L,320L,121L,363L,385L,144L,432L,456L,169L,507L,533L,196L,588L,616L,225L,675L,705L,256L,768L,800L,289L,867L,901L,324L,972L,1008L,361L,1083L,1121L,400L,1200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201271Inst : IEnumerable<long>
{
public static readonly long[] Value=A201271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201271.Bytes);
public long this[int i]=>Value[i];

public static A201271Inst Instance=new A201271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201272
{
public static readonly long[] Value={ 1L,4L,7L,14L,21L,41L,54L,86L,120L,168L,218L,307L,377L,496L,621L,776L,937L,1177L,1380L,1676L,1984L,2344L,2716L,3221L,3665L,4260L,4875L,5570L,6285L,7201L,8026L,9074L,10152L,11344L,12566L,14071L,15449L,17136L,18865L,20748L,22673L,24977L,27112L,29656L,32256L,35056L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201272Inst : IEnumerable<long>
{
public static readonly long[] Value=A201272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201272.Bytes);
public long this[int i]=>Value[i];

public static A201272Inst Instance=new A201272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201273
{
public static readonly long[] Value={ 3L,12L,14L,85L,199L,143L,740L,1274L,759L,3416L,5312L,2746L,11628L,16676L,7946L,32164L,43438L,19713L,76321L,99347L,43137L,162566L,205231L,86351L,318364L,391600L,161089L,581578L,702330L,282904L,1006014L,1195239L,473473L,1662549L,1947164L,761467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201273Inst : IEnumerable<long>
{
public static readonly long[] Value=A201273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201273.Bytes);
public long this[int i]=>Value[i];

public static A201273Inst Instance=new A201273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201274
{
public static readonly long[] Value={ 3L,16L,21L,199L,556L,442L,2827L,5680L,3651L,19960L,35039L,19820L,96084L,151800L,78205L,354360L,525467L,255143L,1089594L,1531163L,707770L,2908481L,3937393L,1758805L,6976823L,9145189L,3964264L,15328243L,19618905L,8309214L,31406219L,39327693L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201274Inst : IEnumerable<long>
{
public static readonly long[] Value=A201274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201274.Bytes);
public long this[int i]=>Value[i];

public static A201274Inst Instance=new A201274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201275
{
public static readonly long[] Value={ 1L,9L,41L,143L,442L,1260L,3113L,7331L,15969L,32737L,63942L,120318L,216392L,377902L,640970L,1055829L,1699241L,2679576L,4132842L,6267048L,9345121L,13712218L,19841970L,28343579L,39963063L,55722233L,76873873L,104958237L,141966994L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201275Inst : IEnumerable<long>
{
public static readonly long[] Value=A201275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201275.Bytes);
public long this[int i]=>Value[i];

public static A201275Inst Instance=new A201275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201276
{
public static readonly long[] Value={ 3L,27L,54L,740L,2827L,3113L,27008L,71704L,59070L,408600L,894812L,621910L,3704174L,7087046L,4373879L,23558696L,41171126L,23396689L,116650532L,190010902L,101247815L,476808796L,736407602L,373431803L,1678517670L,2482516953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201276Inst : IEnumerable<long>
{
public static readonly long[] Value=A201276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201276.Bytes);
public long this[int i]=>Value[i];

public static A201276Inst Instance=new A201276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201277
{
public static readonly long[] Value={ 3L,3L,3L,1L,5L,1L,3L,4L,4L,3L,3L,12L,7L,12L,3L,1L,16L,14L,14L,16L,1L,3L,9L,21L,85L,21L,9L,3L,3L,27L,41L,199L,199L,41L,27L,3L,1L,33L,54L,143L,556L,143L,54L,33L,1L,3L,16L,86L,740L,442L,442L,740L,86L,16L,3L,3L,48L,120L,1274L,2827L,1260L,2827L,1274L,120L,48L,3L,1L,56L,168L,759L,5680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201277Inst : IEnumerable<long>
{
public static readonly long[] Value=A201277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201277.Bytes);
public long this[int i]=>Value[i];

public static A201277Inst Instance=new A201277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201278
{
public static readonly long[] Value={ 10L,2L,2L,5L,5L,130L,185L,5L,2L,2L,10L,10L,5L,5L,10L,17L,17L,5L,5L,5L,53L,53L,13L,13L,1490L,5L,2L,2L,5L,1565L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201278Inst : IEnumerable<long>
{
public static readonly long[] Value=A201278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201278.Bytes);
public long this[int i]=>Value[i];

public static A201278Inst Instance=new A201278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201279
{
public static readonly long[] Value={ 5L,21L,49L,89L,141L,205L,281L,369L,469L,581L,705L,841L,989L,1149L,1321L,1505L,1701L,1909L,2129L,2361L,2605L,2861L,3129L,3409L,3701L,4005L,4321L,4649L,4989L,5341L,5705L,6081L,6469L,6869L,7281L,7705L,8141L,8589L,9049L,9521L,10005L,10501L,11009L,11529L,12061L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201279Inst : IEnumerable<long>
{
public static readonly long[] Value=A201279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201279.Bytes);
public long this[int i]=>Value[i];

public static A201279Inst Instance=new A201279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201280
{
public static readonly long[] Value={ 6L,2L,3L,8L,9L,9L,5L,6L,0L,5L,8L,0L,9L,0L,3L,4L,4L,3L,6L,3L,9L,9L,0L,3L,2L,9L,3L,9L,4L,6L,3L,2L,4L,4L,2L,6L,4L,4L,2L,7L,6L,1L,7L,2L,0L,3L,1L,5L,6L,6L,7L,3L,6L,5L,2L,8L,8L,4L,4L,3L,7L,9L,0L,4L,7L,1L,8L,2L,8L,0L,2L,1L,3L,1L,8L,5L,4L,3L,4L,2L,6L,6L,8L,5L,9L,8L,1L,6L,4L,7L,3L,3L,4L,6L,8L,7L,9L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201280Inst : IEnumerable<long>
{
public static readonly long[] Value=A201280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201280.Bytes);
public long this[int i]=>Value[i];

public static A201280Inst Instance=new A201280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201281
{
public static readonly long[] Value={ 4L,2L,9L,3L,2L,7L,9L,4L,1L,7L,9L,4L,5L,8L,6L,4L,3L,6L,7L,9L,2L,8L,3L,2L,6L,2L,2L,9L,1L,3L,0L,2L,8L,5L,3L,1L,4L,3L,2L,5L,1L,6L,6L,6L,0L,2L,1L,0L,8L,2L,5L,6L,4L,6L,5L,8L,6L,7L,1L,6L,5L,5L,2L,6L,5L,5L,8L,6L,7L,2L,9L,9L,7L,1L,5L,1L,2L,3L,2L,6L,8L,8L,8L,8L,2L,5L,3L,6L,5L,6L,0L,9L,9L,0L,8L,3L,5L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201281Inst : IEnumerable<long>
{
public static readonly long[] Value=A201281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201281.Bytes);
public long this[int i]=>Value[i];

public static A201281Inst Instance=new A201281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201282
{
public static readonly long[] Value={ 3L,1L,2L,2L,7L,6L,3L,6L,0L,7L,5L,4L,1L,1L,1L,1L,3L,5L,8L,0L,6L,8L,5L,7L,0L,0L,2L,1L,3L,0L,5L,8L,3L,4L,2L,6L,6L,5L,2L,1L,2L,7L,9L,2L,9L,9L,9L,9L,8L,9L,3L,1L,0L,0L,0L,6L,2L,0L,5L,4L,0L,3L,2L,0L,7L,8L,4L,8L,6L,7L,3L,5L,6L,4L,0L,4L,3L,3L,2L,9L,1L,4L,4L,8L,7L,1L,6L,8L,9L,0L,2L,6L,8L,7L,8L,4L,6L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201282Inst : IEnumerable<long>
{
public static readonly long[] Value=A201282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201282.Bytes);
public long this[int i]=>Value[i];

public static A201282Inst Instance=new A201282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201283
{
public static readonly long[] Value={ 2L,4L,1L,5L,9L,1L,8L,5L,7L,4L,3L,6L,4L,5L,3L,6L,4L,5L,3L,7L,0L,5L,0L,7L,5L,8L,4L,3L,5L,7L,8L,0L,1L,5L,9L,7L,1L,9L,9L,2L,9L,0L,4L,8L,0L,0L,4L,4L,9L,4L,6L,9L,7L,2L,4L,4L,2L,7L,5L,5L,8L,7L,8L,7L,1L,7L,9L,7L,9L,1L,3L,8L,8L,1L,6L,6L,5L,4L,2L,9L,7L,0L,9L,5L,8L,5L,9L,3L,7L,4L,7L,9L,7L,5L,9L,3L,9L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201283Inst : IEnumerable<long>
{
public static readonly long[] Value=A201283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201283.Bytes);
public long this[int i]=>Value[i];

public static A201283Inst Instance=new A201283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201284
{
public static readonly long[] Value={ 1L,9L,5L,9L,2L,9L,8L,9L,9L,2L,6L,5L,4L,6L,2L,6L,3L,2L,1L,8L,1L,1L,5L,5L,3L,5L,3L,8L,3L,4L,7L,7L,4L,0L,8L,3L,6L,0L,2L,9L,6L,9L,6L,9L,5L,4L,0L,1L,3L,5L,8L,3L,3L,8L,6L,6L,5L,2L,7L,3L,8L,6L,1L,2L,6L,7L,2L,9L,6L,6L,1L,9L,1L,1L,9L,7L,4L,9L,7L,1L,4L,2L,2L,7L,4L,2L,0L,3L,9L,8L,9L,4L,6L,8L,0L,0L,5L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201284Inst : IEnumerable<long>
{
public static readonly long[] Value=A201284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201284.Bytes);
public long this[int i]=>Value[i];

public static A201284Inst Instance=new A201284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201285
{
public static readonly long[] Value={ 1L,6L,4L,4L,2L,1L,2L,0L,9L,0L,5L,0L,2L,9L,5L,4L,7L,0L,9L,4L,1L,5L,2L,9L,9L,9L,5L,0L,6L,8L,4L,2L,9L,6L,1L,7L,2L,8L,4L,9L,7L,1L,8L,1L,9L,5L,7L,2L,0L,0L,9L,7L,1L,9L,5L,2L,1L,1L,9L,3L,7L,0L,0L,4L,9L,2L,3L,5L,1L,6L,7L,5L,6L,3L,5L,5L,2L,3L,7L,7L,9L,4L,9L,4L,3L,2L,3L,2L,6L,5L,3L,0L,7L,8L,1L,3L,3L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201285Inst : IEnumerable<long>
{
public static readonly long[] Value=A201285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201285.Bytes);
public long this[int i]=>Value[i];

public static A201285Inst Instance=new A201285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201286
{
public static readonly long[] Value={ 1L,4L,1L,4L,9L,7L,7L,4L,1L,6L,9L,1L,6L,5L,7L,0L,5L,7L,1L,7L,4L,7L,2L,0L,9L,3L,9L,5L,9L,6L,4L,4L,1L,5L,4L,3L,0L,4L,1L,0L,8L,6L,7L,7L,3L,7L,8L,8L,2L,8L,6L,9L,3L,0L,1L,6L,2L,1L,6L,3L,2L,7L,8L,3L,6L,8L,8L,2L,1L,9L,8L,9L,4L,1L,4L,6L,8L,3L,0L,8L,5L,5L,6L,8L,0L,8L,4L,6L,1L,8L,0L,8L,3L,4L,0L,3L,1L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201286Inst : IEnumerable<long>
{
public static readonly long[] Value=A201286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201286.Bytes);
public long this[int i]=>Value[i];

public static A201286Inst Instance=new A201286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201287
{
public static readonly long[] Value={ 1L,2L,4L,1L,1L,8L,4L,3L,7L,1L,3L,0L,1L,3L,1L,7L,6L,5L,2L,3L,8L,5L,3L,9L,4L,2L,3L,1L,8L,7L,7L,4L,2L,1L,1L,4L,1L,4L,0L,4L,6L,1L,4L,5L,1L,4L,6L,6L,1L,9L,0L,6L,0L,0L,3L,0L,6L,0L,7L,0L,1L,1L,8L,3L,6L,3L,2L,8L,7L,3L,4L,2L,8L,2L,1L,4L,1L,6L,2L,4L,7L,0L,2L,3L,9L,3L,1L,2L,4L,4L,5L,6L,9L,2L,1L,1L,0L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201287Inst : IEnumerable<long>
{
public static readonly long[] Value=A201287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201287.Bytes);
public long this[int i]=>Value[i];

public static A201287Inst Instance=new A201287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201288
{
public static readonly long[] Value={ 1L,1L,0L,5L,0L,8L,4L,9L,2L,1L,4L,8L,6L,8L,2L,8L,6L,6L,5L,3L,0L,2L,1L,3L,2L,6L,3L,2L,6L,3L,3L,3L,0L,8L,6L,4L,1L,8L,6L,8L,4L,6L,1L,4L,4L,2L,8L,6L,2L,5L,4L,8L,4L,3L,0L,1L,4L,8L,7L,5L,2L,1L,0L,3L,3L,0L,2L,5L,9L,0L,1L,3L,2L,2L,6L,9L,2L,6L,9L,8L,9L,2L,5L,6L,9L,5L,3L,7L,1L,0L,8L,3L,0L,9L,2L,3L,5L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201288Inst : IEnumerable<long>
{
public static readonly long[] Value=A201288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201288.Bytes);
public long this[int i]=>Value[i];

public static A201288Inst Instance=new A201288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201289
{
public static readonly long[] Value={ 9L,9L,5L,7L,0L,5L,8L,7L,3L,4L,8L,9L,9L,3L,4L,7L,8L,9L,4L,3L,3L,0L,6L,5L,8L,4L,3L,4L,4L,9L,3L,3L,8L,8L,1L,3L,6L,2L,4L,3L,3L,7L,6L,6L,3L,4L,3L,9L,3L,8L,8L,9L,4L,3L,0L,4L,4L,6L,9L,5L,2L,4L,0L,8L,3L,1L,8L,2L,4L,7L,3L,3L,6L,4L,6L,2L,2L,2L,2L,7L,4L,3L,9L,1L,4L,1L,3L,6L,9L,2L,1L,1L,2L,8L,0L,8L,1L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201289Inst : IEnumerable<long>
{
public static readonly long[] Value=A201289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201289.Bytes);
public long this[int i]=>Value[i];

public static A201289Inst Instance=new A201289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201290
{
public static readonly long[] Value={ 5L,5L,4L,4L,5L,6L,9L,9L,7L,7L,4L,7L,8L,3L,1L,8L,1L,8L,2L,8L,9L,5L,9L,8L,7L,4L,8L,3L,7L,7L,3L,3L,9L,8L,6L,1L,9L,5L,6L,5L,7L,4L,5L,4L,4L,2L,1L,4L,6L,9L,5L,0L,6L,9L,4L,8L,6L,8L,8L,2L,8L,4L,0L,5L,5L,5L,6L,2L,1L,0L,4L,3L,2L,5L,3L,6L,7L,7L,2L,8L,8L,5L,2L,2L,3L,6L,7L,1L,9L,7L,3L,9L,4L,8L,8L,6L,9L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201290Inst : IEnumerable<long>
{
public static readonly long[] Value=A201290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201290.Bytes);
public long this[int i]=>Value[i];

public static A201290Inst Instance=new A201290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201291
{
public static readonly long[] Value={ 3L,0L,4L,2L,1L,6L,5L,4L,8L,8L,1L,1L,0L,0L,8L,6L,7L,8L,2L,1L,0L,7L,5L,6L,9L,6L,3L,3L,0L,1L,3L,9L,7L,8L,2L,6L,7L,2L,6L,1L,3L,0L,8L,9L,8L,1L,6L,7L,7L,5L,6L,9L,8L,4L,1L,2L,4L,0L,5L,7L,0L,6L,8L,0L,3L,1L,8L,4L,0L,7L,9L,3L,8L,5L,8L,9L,5L,5L,7L,5L,0L,7L,3L,1L,6L,0L,9L,1L,8L,6L,6L,9L,7L,8L,1L,2L,9L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201291Inst : IEnumerable<long>
{
public static readonly long[] Value=A201291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201291.Bytes);
public long this[int i]=>Value[i];

public static A201291Inst Instance=new A201291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201292
{
public static readonly long[] Value={ 5L,1L,1L,0L,2L,8L,9L,6L,8L,8L,6L,7L,1L,8L,8L,6L,5L,4L,9L,8L,9L,5L,9L,1L,1L,4L,8L,1L,1L,1L,0L,4L,9L,3L,6L,7L,2L,8L,6L,0L,7L,2L,8L,6L,6L,0L,2L,7L,8L,4L,9L,4L,5L,3L,8L,8L,1L,2L,8L,3L,1L,8L,8L,7L,6L,0L,8L,9L,4L,3L,3L,9L,7L,9L,1L,9L,1L,4L,1L,1L,7L,4L,2L,6L,6L,6L,7L,8L,0L,9L,7L,1L,3L,8L,5L,3L,2L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201292Inst : IEnumerable<long>
{
public static readonly long[] Value=A201292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201292.Bytes);
public long this[int i]=>Value[i];

public static A201292Inst Instance=new A201292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201293
{
public static readonly long[] Value={ 3L,8L,7L,4L,6L,7L,6L,2L,2L,7L,2L,7L,7L,7L,5L,3L,3L,3L,8L,3L,1L,1L,8L,8L,7L,7L,6L,4L,0L,1L,8L,8L,1L,2L,7L,0L,4L,8L,4L,0L,1L,3L,6L,7L,8L,4L,3L,2L,5L,2L,9L,1L,2L,1L,7L,8L,9L,3L,7L,9L,7L,8L,1L,8L,2L,0L,8L,9L,0L,2L,4L,0L,1L,1L,0L,8L,9L,8L,0L,2L,8L,2L,9L,7L,1L,5L,4L,2L,9L,9L,7L,4L,0L,8L,6L,2L,4L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201293Inst : IEnumerable<long>
{
public static readonly long[] Value=A201293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201293.Bytes);
public long this[int i]=>Value[i];

public static A201293Inst Instance=new A201293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201294
{
public static readonly long[] Value={ 8L,9L,5L,2L,0L,6L,0L,4L,5L,3L,8L,4L,2L,3L,1L,8L,5L,0L,0L,7L,5L,5L,5L,0L,7L,9L,9L,5L,4L,9L,1L,6L,8L,5L,9L,2L,5L,0L,2L,2L,4L,6L,2L,3L,9L,1L,1L,5L,6L,8L,3L,3L,4L,0L,9L,6L,3L,7L,4L,6L,0L,1L,9L,6L,6L,5L,4L,8L,8L,9L,1L,4L,8L,8L,3L,9L,5L,6L,9L,0L,7L,4L,6L,1L,8L,9L,0L,4L,4L,5L,3L,1L,6L,2L,9L,4L,8L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201294Inst : IEnumerable<long>
{
public static readonly long[] Value=A201294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201294.Bytes);
public long this[int i]=>Value[i];

public static A201294Inst Instance=new A201294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201295
{
public static readonly long[] Value={ 1L,1L,8L,5L,5L,4L,4L,3L,5L,0L,2L,2L,1L,5L,3L,2L,9L,2L,7L,7L,8L,4L,0L,7L,8L,9L,8L,6L,0L,7L,4L,1L,7L,8L,0L,2L,7L,5L,9L,9L,2L,7L,7L,3L,8L,0L,7L,4L,2L,2L,9L,5L,3L,7L,3L,9L,0L,4L,8L,7L,4L,4L,5L,6L,6L,4L,5L,8L,8L,6L,1L,1L,3L,4L,2L,9L,1L,0L,1L,8L,3L,0L,5L,5L,6L,1L,6L,4L,6L,1L,3L,2L,3L,7L,5L,6L,2L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201295Inst : IEnumerable<long>
{
public static readonly long[] Value=A201295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201295.Bytes);
public long this[int i]=>Value[i];

public static A201295Inst Instance=new A201295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201296
{
public static readonly long[] Value={ 1L,4L,5L,4L,8L,1L,9L,4L,6L,1L,5L,3L,6L,3L,9L,7L,1L,7L,3L,3L,8L,4L,1L,7L,3L,8L,2L,9L,8L,0L,8L,0L,9L,3L,3L,8L,9L,0L,2L,5L,7L,9L,4L,4L,1L,1L,0L,9L,7L,8L,4L,1L,0L,5L,1L,2L,5L,0L,3L,8L,2L,4L,6L,9L,2L,5L,5L,8L,7L,6L,2L,5L,0L,9L,2L,2L,9L,7L,1L,6L,3L,9L,8L,7L,8L,4L,8L,4L,7L,5L,4L,2L,9L,5L,4L,2L,4L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201296Inst : IEnumerable<long>
{
public static readonly long[] Value=A201296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201296.Bytes);
public long this[int i]=>Value[i];

public static A201296Inst Instance=new A201296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201297
{
public static readonly long[] Value={ 1L,6L,9L,5L,4L,8L,3L,1L,1L,8L,3L,6L,4L,6L,2L,3L,4L,8L,8L,6L,8L,9L,5L,6L,8L,1L,6L,5L,1L,3L,3L,5L,7L,9L,1L,8L,5L,0L,9L,3L,6L,3L,4L,4L,7L,5L,7L,1L,1L,4L,0L,3L,5L,8L,6L,6L,3L,6L,4L,9L,3L,5L,8L,3L,1L,6L,0L,7L,0L,1L,5L,2L,1L,3L,0L,2L,4L,7L,9L,3L,9L,1L,9L,7L,0L,3L,3L,4L,8L,7L,0L,2L,7L,4L,4L,5L,9L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201297Inst : IEnumerable<long>
{
public static readonly long[] Value=A201297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201297.Bytes);
public long this[int i]=>Value[i];

public static A201297Inst Instance=new A201297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201298
{
public static readonly long[] Value={ 1L,9L,0L,9L,8L,0L,9L,6L,4L,4L,9L,8L,4L,1L,3L,5L,5L,6L,1L,3L,7L,0L,6L,4L,8L,7L,2L,6L,5L,6L,3L,0L,8L,8L,0L,2L,5L,4L,6L,4L,7L,7L,1L,4L,0L,3L,0L,1L,0L,8L,4L,6L,0L,5L,2L,4L,9L,2L,9L,5L,2L,8L,7L,8L,8L,0L,3L,5L,4L,7L,8L,8L,3L,4L,6L,2L,2L,9L,8L,3L,7L,2L,6L,4L,0L,6L,8L,5L,4L,8L,4L,0L,2L,1L,5L,6L,5L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201298Inst : IEnumerable<long>
{
public static readonly long[] Value=A201298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201298.Bytes);
public long this[int i]=>Value[i];

public static A201298Inst Instance=new A201298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201299
{
public static readonly long[] Value={ 2L,1L,0L,0L,9L,2L,9L,3L,7L,7L,0L,2L,7L,2L,8L,5L,9L,4L,0L,8L,0L,0L,3L,7L,3L,7L,5L,5L,6L,7L,9L,3L,5L,5L,5L,9L,3L,6L,3L,8L,9L,4L,5L,2L,6L,3L,7L,8L,9L,2L,3L,2L,7L,2L,8L,1L,6L,4L,9L,2L,6L,2L,0L,0L,3L,1L,1L,9L,1L,5L,1L,7L,9L,5L,7L,4L,0L,9L,6L,4L,5L,6L,9L,1L,6L,5L,2L,2L,7L,4L,1L,0L,0L,2L,5L,3L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201299Inst : IEnumerable<long>
{
public static readonly long[] Value=A201299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201299.Bytes);
public long this[int i]=>Value[i];

public static A201299Inst Instance=new A201299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201300
{
public static readonly long[] Value={ 5L,1949L,158189L,197573L,493853L,1265477L,7475261L,10123781L,16342637L,17159621L,23652653L,31606277L,41168669L,47412221L,63700997L,67765829L,78676349L,80990213L,118298309L,121331453L,189221189L,252850181L,278632301L,300476237L,335337341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201300Inst : IEnumerable<long>
{
public static readonly long[] Value=A201300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201300.Bytes);
public long this[int i]=>Value[i];

public static A201300Inst Instance=new A201300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201301
{
public static readonly long[] Value={ 7L,79L,1951L,9007L,15559L,36871L,294919L,1265479L,1417183L,2359303L,3647023L,4608007L,6561007L,7475263L,10719151L,14048071L,21654943L,26873863L,28009231L,31606279L,38263759L,56065543L,72000007L,98469439L,103888591L,109503007L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201301Inst : IEnumerable<long>
{
public static readonly long[] Value=A201301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201301.Bytes);
public long this[int i]=>Value[i];

public static A201301Inst Instance=new A201301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201302
{
public static readonly long[] Value={ 17L,251L,6569L,11987L,83357L,323441L,533879L,620297L,715571L,820133L,1193867L,1339901L,2250431L,2471633L,4437359L,4782977L,5146091L,6344729L,7716383L,11655269L,12308687L,12986081L,16747811L,22143383L,27437633L,30986567L,40429133L,43441289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201302Inst : IEnumerable<long>
{
public static readonly long[] Value=A201302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201302.Bytes);
public long this[int i]=>Value[i];

public static A201302Inst Instance=new A201302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201303
{
public static readonly long[] Value={ 19L,6571L,323443L,1193869L,1339903L,3501163L,4437361L,11655271L,23142187L,24170581L,29771551L,37559539L,55156393L,60761431L,84545389L,105273757L,119808487L,125977699L,145748503L,179122609L,199692379L,212759137L,245438119L,250363153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201303Inst : IEnumerable<long>
{
public static readonly long[] Value=A201303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201303.Bytes);
public long this[int i]=>Value[i];

public static A201303Inst Instance=new A201303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201304
{
public static readonly long[] Value={ 3L,13L,83L,643L,3433L,13313L,156253L,219523L,506533L,851843L,1250003L,1951123L,3007633L,7535713L,8573753L,11910163L,24061043L,32417923L,34429513L,37238753L,39443123L,41732813L,60285683L,76453733L,86151253L,134812723L,141724883L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201304Inst : IEnumerable<long>
{
public static readonly long[] Value=A201304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201304.Bytes);
public long this[int i]=>Value[i];

public static A201304Inst Instance=new A201304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201305
{
public static readonly long[] Value={ 7L,17L,277L,647L,7297L,10007L,21977L,33757L,68597L,106487L,138247L,156257L,196837L,359377L,466567L,506537L,640007L,795077L,973367L,1574647L,1951127L,2621447L,5314417L,5513687L,6141257L,10612087L,11910167L,12950297L,14815447L,19066247L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201305Inst : IEnumerable<long>
{
public static readonly long[] Value=A201305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201305.Bytes);
public long this[int i]=>Value[i];

public static A201305Inst Instance=new A201305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201306
{
public static readonly long[] Value={ 19L,89L,1259L,10009L,27449L,49139L,156259L,219529L,327689L,428759L,640009L,689219L,795079L,1250009L,1406089L,2269819L,3007639L,3579119L,3890179L,4052249L,4389769L,6360569L,6814729L,8305849L,8573759L,11248649L,12950299L,13310009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201306Inst : IEnumerable<long>
{
public static readonly long[] Value=A201306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201306.Bytes);
public long this[int i]=>Value[i];

public static A201306Inst Instance=new A201306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201307
{
public static readonly long[] Value={ 5L,31L,347L,733L,6863L,15629L,19687L,91129L,250051L,328513L,493043L,614129L,658507L,970303L,1092731L,1295033L,1520879L,1601617L,2146693L,2352641L,3048629L,4826813L,5359379L,6128491L,7414879L,8869747L,12977879L,21253937L,21717643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201307Inst : IEnumerable<long>
{
public static readonly long[] Value=A201307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201307.Bytes);
public long this[int i]=>Value[i];

public static A201307Inst Instance=new A201307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201308
{
public static readonly long[] Value={ 7L,131L,349L,2203L,4919L,68927L,389023L,456539L,1030307L,1092733L,2352643L,2924213L,3048631L,4173287L,5177723L,5929747L,6539209L,15813257L,19902517L,22665193L,25153763L,30664303L,34328131L,59776477L,61629881L,76765631L,97972187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201308Inst : IEnumerable<long>
{
public static readonly long[] Value=A201308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201308.Bytes);
public long this[int i]=>Value[i];

public static A201308Inst Instance=new A201308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201309
{
public static readonly long[] Value={ 23L,1327L,3371L,4909L,9257L,12163L,35933L,68917L,91121L,132647L,148873L,185189L,250043L,456529L,571783L,1030297L,1157621L,1601609L,2248087L,3176519L,3723871L,4173277L,5545229L,8120597L,11697079L,16581371L,16974589L,17779577L,18191443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201309Inst : IEnumerable<long>
{
public static readonly long[] Value=A201309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201309.Bytes);
public long this[int i]=>Value[i];

public static A201309Inst Instance=new A201309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201310
{
public static readonly long[] Value={ 2L,337L,12161L,15619L,50647L,117643L,300757L,857369L,1685153L,2352631L,3723869L,8365421L,12977869L,14706119L,18191441L,20796869L,23639897L,24137563L,31855007L,40353601L,46268273L,57066619L,58863863L,65450821L,67419137L,77854477L,86938301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201310Inst : IEnumerable<long>
{
public static readonly long[] Value=A201310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201310.Bytes);
public long this[int i]=>Value[i];

public static A201310Inst Instance=new A201310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201311
{
public static readonly long[] Value={ 17L,719L,1321L,4903L,12157L,24379L,103813L,148867L,185183L,250037L,456523L,571777L,1030291L,1442887L,1860857L,3176513L,3307939L,4657453L,5000201L,5545223L,6128477L,6967861L,8120591L,8365417L,9663587L,10793851L,11697073L,13312043L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201311Inst : IEnumerable<long>
{
public static readonly long[] Value=A201311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201311.Bytes);
public long this[int i]=>Value[i];

public static A201311Inst Instance=new A201311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201312
{
public static readonly long[] Value={ 11L,37L,353L,739L,2207L,6869L,117659L,132661L,226991L,250057L,328519L,389027L,493049L,804367L,1601623L,1860877L,2685629L,3176533L,4019689L,4330757L,10218323L,11089577L,12008999L,15069233L,16194287L,17373989L,19034173L,20346427L,21253943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201312Inst : IEnumerable<long>
{
public static readonly long[] Value=A201312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201312.Bytes);
public long this[int i]=>Value[i];

public static A201312Inst Instance=new A201312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201313
{
public static readonly long[] Value={ 71L,431L,719L,1511L,2591L,4751L,6551L,7559L,9791L,13679L,16631L,21599L,23399L,29231L,31319L,33479L,42839L,47951L,61991L,68111L,95471L,110879L,123191L,131759L,149759L,154439L,159191L,184031L,194471L,199799L,210671L,221831L,227519L,233279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201313Inst : IEnumerable<long>
{
public static readonly long[] Value=A201313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201313.Bytes);
public long this[int i]=>Value[i];

public static A201313Inst Instance=new A201313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201314
{
public static readonly long[] Value={ 19L,47L,83L,127L,179L,239L,307L,383L,467L,659L,883L,1279L,1427L,1583L,1747L,2099L,2287L,2687L,3119L,3347L,3583L,4079L,4339L,5167L,6067L,7039L,7727L,8447L,8819L,9199L,9587L,10799L,12527L,12979L,13907L,14867L,15359L,15859L,16883L,17939L,19583L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201314Inst : IEnumerable<long>
{
public static readonly long[] Value=A201314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201314.Bytes);
public long this[int i]=>Value[i];

public static A201314Inst Instance=new A201314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201315
{
public static readonly long[] Value={ 2L,2L,7L,0L,9L,8L,7L,5L,8L,6L,4L,9L,4L,9L,9L,5L,3L,5L,7L,0L,5L,8L,2L,3L,3L,9L,8L,2L,9L,2L,0L,9L,1L,7L,1L,5L,7L,4L,5L,3L,0L,5L,1L,6L,5L,0L,9L,8L,1L,9L,1L,0L,4L,9L,3L,5L,6L,1L,5L,1L,4L,0L,4L,4L,9L,6L,7L,3L,6L,9L,7L,3L,0L,3L,5L,4L,6L,4L,3L,6L,3L,9L,9L,8L,7L,7L,8L,0L,2L,7L,9L,6L,2L,2L,3L,8L,4L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201315Inst : IEnumerable<long>
{
public static readonly long[] Value=A201315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201315.Bytes);
public long this[int i]=>Value[i];

public static A201315Inst Instance=new A201315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201316
{
public static readonly long[] Value={ 2L,4L,2L,0L,9L,9L,4L,1L,9L,8L,6L,5L,6L,6L,9L,2L,6L,6L,4L,5L,0L,3L,7L,5L,7L,3L,3L,7L,4L,3L,9L,8L,7L,9L,4L,0L,2L,0L,3L,7L,2L,5L,9L,0L,8L,5L,3L,4L,7L,2L,0L,0L,6L,4L,7L,7L,3L,4L,8L,0L,5L,3L,3L,4L,6L,7L,2L,0L,2L,6L,2L,1L,3L,0L,1L,4L,5L,7L,9L,7L,4L,7L,2L,2L,5L,9L,7L,9L,7L,8L,3L,8L,8L,4L,1L,8L,1L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201316Inst : IEnumerable<long>
{
public static readonly long[] Value=A201316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201316.Bytes);
public long this[int i]=>Value[i];

public static A201316Inst Instance=new A201316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201317
{
public static readonly long[] Value={ 2L,5L,5L,1L,0L,9L,4L,1L,5L,8L,8L,9L,3L,9L,1L,5L,8L,0L,0L,7L,3L,4L,6L,1L,6L,1L,9L,2L,9L,4L,0L,8L,1L,0L,2L,9L,1L,7L,6L,3L,5L,9L,2L,5L,8L,2L,9L,2L,3L,6L,5L,8L,6L,2L,3L,3L,8L,7L,4L,1L,4L,2L,5L,2L,7L,6L,4L,3L,8L,0L,7L,1L,4L,9L,5L,2L,2L,0L,1L,1L,8L,4L,9L,0L,5L,8L,5L,2L,5L,2L,0L,0L,2L,5L,0L,7L,5L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201317Inst : IEnumerable<long>
{
public static readonly long[] Value=A201317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201317.Bytes);
public long this[int i]=>Value[i];

public static A201317Inst Instance=new A201317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201318
{
public static readonly long[] Value={ 2L,6L,6L,1L,1L,0L,3L,4L,3L,8L,5L,8L,4L,5L,7L,3L,1L,3L,5L,5L,1L,7L,4L,2L,4L,4L,5L,0L,0L,6L,0L,0L,4L,6L,1L,1L,7L,9L,7L,2L,5L,4L,8L,7L,0L,2L,3L,2L,1L,9L,2L,5L,4L,2L,2L,6L,3L,2L,4L,5L,3L,5L,6L,2L,9L,5L,0L,0L,7L,0L,6L,8L,9L,3L,8L,0L,5L,6L,5L,2L,3L,1L,9L,8L,7L,2L,1L,3L,1L,2L,6L,5L,9L,9L,0L,5L,5L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201318Inst : IEnumerable<long>
{
public static readonly long[] Value=A201318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201318.Bytes);
public long this[int i]=>Value[i];

public static A201318Inst Instance=new A201318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201319
{
public static readonly long[] Value={ 2L,7L,5L,1L,2L,6L,8L,2L,9L,9L,0L,5L,8L,5L,7L,2L,8L,5L,5L,4L,3L,9L,0L,4L,8L,5L,7L,9L,5L,1L,5L,9L,4L,8L,8L,6L,0L,9L,7L,4L,4L,7L,5L,8L,6L,6L,2L,0L,9L,0L,5L,3L,8L,9L,8L,6L,3L,4L,0L,7L,4L,8L,8L,9L,1L,3L,5L,2L,7L,4L,5L,6L,9L,8L,4L,4L,3L,5L,4L,9L,9L,9L,5L,7L,7L,1L,4L,1L,2L,0L,7L,5L,9L,6L,4L,0L,4L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201319Inst : IEnumerable<long>
{
public static readonly long[] Value=A201319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201319.Bytes);
public long this[int i]=>Value[i];

public static A201319Inst Instance=new A201319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201320
{
public static readonly long[] Value={ 9L,3L,3L,0L,2L,7L,6L,7L,4L,6L,6L,6L,1L,7L,7L,2L,5L,5L,9L,0L,6L,8L,7L,9L,1L,3L,5L,6L,1L,3L,0L,5L,1L,0L,6L,5L,4L,1L,1L,9L,0L,4L,1L,2L,7L,1L,1L,1L,3L,6L,0L,9L,4L,0L,9L,5L,0L,9L,0L,2L,0L,6L,6L,2L,6L,0L,2L,2L,1L,7L,4L,7L,3L,3L,3L,4L,1L,4L,5L,0L,0L,9L,1L,1L,2L,2L,1L,6L,8L,9L,6L,9L,7L,3L,6L,3L,0L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201320Inst : IEnumerable<long>
{
public static readonly long[] Value=A201320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201320.Bytes);
public long this[int i]=>Value[i];

public static A201320Inst Instance=new A201320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201321
{
public static readonly long[] Value={ 8L,0L,7L,5L,8L,5L,2L,8L,1L,4L,4L,2L,2L,0L,1L,9L,9L,3L,9L,2L,6L,5L,8L,1L,6L,7L,9L,5L,3L,7L,2L,4L,0L,7L,5L,4L,2L,3L,7L,2L,5L,4L,0L,7L,9L,4L,3L,0L,3L,7L,3L,1L,8L,9L,3L,2L,9L,3L,4L,6L,3L,8L,9L,5L,5L,0L,1L,6L,9L,8L,7L,0L,9L,9L,8L,9L,7L,1L,7L,7L,8L,2L,9L,3L,7L,3L,8L,9L,2L,5L,6L,5L,5L,3L,0L,3L,7L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201321Inst : IEnumerable<long>
{
public static readonly long[] Value=A201321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201321.Bytes);
public long this[int i]=>Value[i];

public static A201321Inst Instance=new A201321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201322
{
public static readonly long[] Value={ 7L,2L,8L,2L,4L,6L,5L,3L,2L,3L,5L,5L,2L,8L,6L,1L,4L,2L,6L,5L,1L,8L,2L,0L,1L,9L,5L,7L,7L,8L,8L,3L,8L,8L,3L,3L,3L,2L,3L,2L,5L,6L,1L,1L,4L,0L,4L,2L,4L,4L,1L,4L,9L,5L,7L,0L,8L,4L,0L,7L,1L,2L,0L,2L,4L,6L,8L,1L,5L,9L,5L,6L,3L,0L,7L,6L,8L,7L,0L,7L,1L,1L,1L,2L,1L,3L,0L,1L,1L,6L,7L,8L,5L,9L,1L,4L,2L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201322Inst : IEnumerable<long>
{
public static readonly long[] Value=A201322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201322.Bytes);
public long this[int i]=>Value[i];

public static A201322Inst Instance=new A201322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201323
{
public static readonly long[] Value={ 6L,7L,1L,9L,0L,6L,2L,1L,8L,2L,4L,0L,8L,6L,6L,9L,9L,9L,5L,0L,8L,5L,8L,8L,8L,4L,7L,8L,1L,5L,2L,6L,7L,2L,0L,4L,4L,3L,8L,6L,6L,4L,4L,9L,9L,4L,5L,9L,4L,6L,9L,8L,1L,1L,4L,3L,7L,6L,5L,1L,0L,4L,6L,6L,8L,7L,3L,7L,2L,4L,7L,6L,7L,2L,9L,6L,2L,1L,4L,1L,8L,2L,7L,3L,2L,8L,1L,0L,3L,1L,9L,8L,1L,2L,6L,8L,0L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201323Inst : IEnumerable<long>
{
public static readonly long[] Value=A201323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201323.Bytes);
public long this[int i]=>Value[i];

public static A201323Inst Instance=new A201323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201324
{
public static readonly long[] Value={ 6L,2L,9L,0L,5L,4L,1L,6L,2L,9L,7L,8L,4L,0L,4L,2L,3L,0L,8L,6L,1L,8L,0L,6L,7L,8L,2L,6L,9L,4L,4L,1L,2L,3L,6L,8L,8L,4L,4L,6L,3L,2L,5L,8L,1L,7L,8L,5L,5L,5L,9L,3L,9L,5L,6L,2L,5L,2L,3L,4L,6L,6L,4L,6L,7L,5L,2L,7L,0L,6L,5L,7L,2L,9L,3L,2L,7L,1L,8L,1L,0L,4L,2L,3L,9L,8L,5L,4L,1L,5L,3L,7L,4L,3L,5L,5L,8L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201324Inst : IEnumerable<long>
{
public static readonly long[] Value=A201324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201324.Bytes);
public long this[int i]=>Value[i];

public static A201324Inst Instance=new A201324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201325
{
public static readonly long[] Value={ 5L,9L,4L,9L,4L,0L,8L,7L,6L,1L,7L,0L,1L,7L,0L,2L,0L,4L,0L,7L,2L,7L,0L,5L,0L,5L,7L,5L,1L,1L,4L,7L,1L,1L,0L,0L,9L,7L,7L,9L,5L,0L,4L,9L,7L,0L,0L,3L,7L,7L,7L,7L,0L,8L,7L,6L,6L,1L,6L,3L,2L,4L,5L,3L,9L,0L,1L,0L,3L,4L,2L,7L,4L,0L,2L,6L,6L,9L,4L,4L,1L,9L,1L,5L,1L,3L,9L,4L,7L,6L,1L,3L,1L,7L,9L,7L,6L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201325Inst : IEnumerable<long>
{
public static readonly long[] Value=A201325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201325.Bytes);
public long this[int i]=>Value[i];

public static A201325Inst Instance=new A201325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201326
{
public static readonly long[] Value={ 5L,6L,6L,8L,8L,6L,5L,4L,7L,9L,5L,8L,9L,4L,9L,0L,9L,1L,3L,7L,2L,1L,3L,3L,7L,9L,0L,0L,4L,6L,4L,1L,4L,5L,3L,3L,9L,0L,3L,2L,8L,2L,6L,9L,5L,1L,6L,0L,2L,2L,4L,2L,4L,0L,9L,6L,5L,3L,6L,5L,3L,4L,8L,1L,8L,4L,0L,8L,7L,3L,0L,2L,0L,7L,4L,7L,3L,7L,3L,1L,5L,5L,7L,0L,7L,9L,2L,2L,7L,6L,4L,7L,2L,1L,4L,3L,0L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201326Inst : IEnumerable<long>
{
public static readonly long[] Value=A201326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201326.Bytes);
public long this[int i]=>Value[i];

public static A201326Inst Instance=new A201326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201327
{
public static readonly long[] Value={ 5L,4L,3L,2L,4L,5L,4L,7L,2L,5L,1L,1L,0L,6L,5L,6L,3L,7L,1L,6L,1L,8L,0L,7L,4L,0L,0L,7L,2L,4L,2L,8L,7L,3L,5L,0L,6L,6L,4L,8L,7L,6L,2L,9L,5L,0L,9L,3L,4L,8L,9L,8L,1L,4L,5L,7L,8L,1L,9L,9L,4L,6L,1L,8L,9L,6L,6L,4L,8L,4L,9L,2L,2L,1L,7L,5L,4L,3L,4L,1L,5L,5L,2L,3L,0L,6L,7L,8L,7L,6L,5L,2L,8L,6L,3L,3L,0L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201327Inst : IEnumerable<long>
{
public static readonly long[] Value=A201327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201327.Bytes);
public long this[int i]=>Value[i];

public static A201327Inst Instance=new A201327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201328
{
public static readonly long[] Value={ 5L,2L,2L,9L,4L,1L,8L,3L,0L,5L,6L,4L,4L,4L,6L,6L,3L,1L,5L,9L,1L,8L,6L,1L,8L,5L,6L,1L,6L,3L,9L,6L,6L,8L,9L,0L,9L,4L,0L,6L,9L,3L,6L,3L,6L,5L,8L,7L,5L,9L,3L,0L,4L,1L,0L,8L,6L,5L,6L,6L,1L,9L,9L,0L,2L,3L,3L,3L,5L,3L,0L,5L,8L,9L,4L,2L,9L,7L,8L,5L,6L,3L,9L,7L,8L,7L,6L,1L,9L,0L,7L,2L,8L,6L,4L,5L,3L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201328Inst : IEnumerable<long>
{
public static readonly long[] Value=A201328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201328.Bytes);
public long this[int i]=>Value[i];

public static A201328Inst Instance=new A201328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201329
{
public static readonly long[] Value={ 7L,3L,9L,9L,9L,6L,6L,7L,6L,5L,4L,8L,4L,9L,3L,3L,0L,8L,3L,4L,5L,5L,4L,3L,5L,0L,3L,4L,5L,7L,9L,2L,7L,5L,6L,8L,5L,3L,7L,8L,6L,6L,5L,8L,3L,1L,9L,2L,5L,3L,8L,4L,3L,0L,8L,3L,0L,5L,8L,4L,8L,3L,3L,0L,4L,9L,3L,7L,5L,7L,9L,0L,8L,3L,8L,9L,2L,5L,2L,8L,1L,8L,6L,2L,8L,8L,0L,7L,6L,3L,6L,0L,4L,1L,9L,3L,3L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201329Inst : IEnumerable<long>
{
public static readonly long[] Value=A201329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201329.Bytes);
public long this[int i]=>Value[i];

public static A201329Inst Instance=new A201329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201330
{
public static readonly long[] Value={ 6L,5L,7L,2L,3L,4L,0L,6L,6L,2L,1L,6L,4L,9L,4L,6L,3L,5L,6L,3L,7L,7L,9L,1L,0L,9L,9L,2L,0L,6L,7L,1L,4L,7L,7L,0L,5L,7L,9L,1L,1L,3L,1L,8L,6L,8L,8L,8L,9L,7L,9L,3L,6L,2L,4L,7L,8L,9L,6L,4L,7L,3L,0L,8L,1L,7L,5L,8L,7L,4L,6L,0L,1L,5L,8L,9L,4L,7L,3L,9L,1L,2L,8L,3L,9L,3L,7L,3L,9L,4L,9L,4L,7L,6L,2L,5L,9L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201330Inst : IEnumerable<long>
{
public static readonly long[] Value=A201330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201330.Bytes);
public long this[int i]=>Value[i];

public static A201330Inst Instance=new A201330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201331
{
public static readonly long[] Value={ 6L,0L,2L,7L,3L,4L,2L,0L,3L,9L,9L,5L,6L,9L,3L,9L,9L,0L,3L,3L,0L,9L,2L,9L,2L,9L,1L,6L,5L,1L,1L,4L,3L,5L,2L,1L,4L,0L,6L,1L,2L,6L,5L,9L,2L,6L,2L,5L,6L,5L,5L,0L,4L,6L,1L,7L,2L,5L,5L,0L,8L,9L,0L,9L,3L,1L,3L,2L,8L,7L,4L,0L,9L,8L,0L,4L,6L,1L,2L,7L,1L,9L,6L,0L,0L,6L,7L,4L,3L,0L,3L,1L,1L,6L,0L,5L,2L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201331Inst : IEnumerable<long>
{
public static readonly long[] Value=A201331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201331.Bytes);
public long this[int i]=>Value[i];

public static A201331Inst Instance=new A201331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201332
{
public static readonly long[] Value={ 5L,6L,2L,9L,5L,6L,0L,1L,9L,8L,9L,2L,5L,4L,3L,7L,3L,7L,6L,6L,9L,7L,5L,3L,8L,2L,7L,3L,9L,8L,4L,9L,2L,9L,5L,9L,2L,0L,2L,4L,2L,7L,5L,2L,4L,9L,8L,2L,1L,1L,9L,8L,5L,2L,3L,6L,5L,7L,4L,7L,8L,0L,5L,7L,1L,1L,3L,3L,6L,5L,9L,9L,4L,4L,0L,8L,0L,9L,8L,5L,9L,8L,9L,2L,8L,0L,5L,5L,9L,4L,5L,7L,8L,0L,3L,8L,7L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201332Inst : IEnumerable<long>
{
public static readonly long[] Value=A201332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201332.Bytes);
public long this[int i]=>Value[i];

public static A201332Inst Instance=new A201332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201333
{
public static readonly long[] Value={ 5L,3L,2L,0L,7L,6L,2L,5L,1L,3L,5L,6L,6L,5L,0L,3L,1L,6L,8L,0L,0L,7L,3L,5L,2L,4L,8L,7L,0L,9L,5L,0L,8L,2L,9L,3L,5L,1L,1L,0L,1L,4L,9L,6L,7L,8L,7L,3L,3L,8L,4L,6L,9L,6L,8L,9L,4L,2L,2L,8L,8L,4L,4L,6L,0L,6L,3L,3L,8L,0L,9L,9L,8L,8L,6L,4L,3L,3L,0L,5L,5L,9L,0L,1L,8L,3L,9L,2L,4L,8L,7L,1L,8L,1L,5L,3L,0L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201333Inst : IEnumerable<long>
{
public static readonly long[] Value=A201333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201333.Bytes);
public long this[int i]=>Value[i];

public static A201333Inst Instance=new A201333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201334
{
public static readonly long[] Value={ 5L,0L,7L,0L,9L,4L,7L,7L,8L,2L,5L,4L,4L,5L,8L,4L,8L,8L,0L,4L,1L,0L,6L,8L,0L,5L,8L,5L,7L,6L,1L,2L,5L,8L,4L,5L,2L,7L,7L,6L,6L,2L,4L,0L,4L,6L,9L,3L,1L,9L,6L,7L,3L,7L,6L,1L,4L,2L,9L,3L,7L,2L,4L,4L,3L,5L,6L,2L,3L,9L,8L,8L,5L,2L,1L,6L,2L,7L,6L,7L,2L,7L,2L,1L,4L,6L,7L,0L,3L,8L,3L,0L,9L,7L,0L,5L,3L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201334Inst : IEnumerable<long>
{
public static readonly long[] Value=A201334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201334.Bytes);
public long this[int i]=>Value[i];

public static A201334Inst Instance=new A201334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201335
{
public static readonly long[] Value={ 4L,8L,6L,2L,7L,7L,9L,6L,7L,8L,2L,5L,0L,6L,5L,8L,6L,3L,3L,1L,3L,3L,8L,4L,3L,3L,0L,9L,6L,3L,3L,0L,0L,2L,1L,9L,9L,6L,5L,8L,9L,6L,1L,1L,8L,6L,8L,1L,0L,1L,9L,5L,6L,2L,7L,4L,4L,0L,0L,0L,8L,5L,1L,5L,1L,3L,3L,5L,1L,1L,0L,7L,2L,8L,3L,3L,0L,6L,8L,7L,9L,1L,4L,9L,0L,7L,4L,7L,8L,0L,6L,9L,0L,0L,5L,3L,6L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201335Inst : IEnumerable<long>
{
public static readonly long[] Value=A201335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201335.Bytes);
public long this[int i]=>Value[i];

public static A201335Inst Instance=new A201335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201336
{
public static readonly long[] Value={ 4L,6L,8L,5L,4L,0L,5L,4L,7L,6L,8L,9L,1L,2L,8L,6L,5L,9L,1L,2L,2L,9L,2L,7L,7L,8L,5L,7L,6L,1L,7L,4L,3L,1L,3L,1L,1L,4L,6L,0L,2L,2L,6L,7L,1L,6L,1L,4L,6L,6L,3L,0L,2L,9L,6L,7L,0L,1L,5L,9L,2L,9L,0L,6L,2L,5L,9L,5L,2L,4L,4L,9L,6L,2L,6L,5L,8L,2L,1L,2L,1L,6L,7L,2L,2L,9L,9L,2L,7L,8L,0L,1L,2L,3L,0L,1L,7L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201336Inst : IEnumerable<long>
{
public static readonly long[] Value=A201336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201336.Bytes);
public long this[int i]=>Value[i];

public static A201336Inst Instance=new A201336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201337
{
public static readonly long[] Value={ 4L,5L,3L,1L,6L,1L,6L,5L,6L,7L,7L,2L,4L,2L,4L,5L,8L,7L,6L,8L,9L,0L,6L,0L,6L,0L,1L,7L,6L,7L,4L,2L,7L,0L,6L,7L,8L,2L,0L,4L,3L,7L,5L,9L,7L,0L,7L,1L,5L,5L,4L,2L,2L,8L,6L,5L,2L,2L,3L,5L,1L,8L,5L,8L,4L,7L,5L,8L,2L,0L,9L,1L,5L,2L,6L,9L,0L,7L,5L,7L,4L,4L,4L,3L,5L,2L,4L,8L,8L,4L,2L,4L,0L,0L,8L,6L,3L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201337Inst : IEnumerable<long>
{
public static readonly long[] Value=A201337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201337.Bytes);
public long this[int i]=>Value[i];

public static A201337Inst Instance=new A201337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201338
{
public static readonly BigInteger[] Value={ 1L,4L,24L,196L,2040L,25924L,390264L,6804676L,135033720L,3007364164L,74315818104L,2018441506756L,59776933889400L,1917312391176004L,66216538949389944L,2449977966210378436L,BigInteger.Parse("96685769287005577080"),BigInteger.Parse("4053944607498740773444"),BigInteger.Parse("179973441341757042161784"),BigInteger.Parse("8433644996370680262923716") };
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
public class A201338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201338Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201338.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201338.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201338Inst Instance=new A201338Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201339
{
public static readonly BigInteger[] Value={ 1L,3L,15L,111L,1095L,13503L,199815L,3449631L,68062695L,1510769343L,37260156615L,1010843385951L,29916558512295L,959183053936383L,33118910817665415L,1225219266296167071L,BigInteger.Parse("48348200298184769895"),BigInteger.Parse("2027102674516399522623"),BigInteger.Parse("89990106205541777926215"),BigInteger.Parse("4216915299772659459872991") };
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
public class A201339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201339Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201339.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201339.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201339Inst Instance=new A201339Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201340
{
public static readonly long[] Value={ 0L,0L,15L,213L,2007L,15497L,106589L,680287L,4118949L,23981337L,135473879L,747163898L,4040984182L,21504391182L,112888169123L,585765427216L,3009175376793L,15324419276531L,77445651022458L,388752941316532L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201340Inst : IEnumerable<long>
{
public static readonly long[] Value=A201340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201340.Bytes);
public long this[int i]=>Value[i];

public static A201340Inst Instance=new A201340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201341
{
public static readonly long[] Value={ 0L,15L,295L,6304L,120750L,1977305L,28778603L,384578235L,4826582648L,57769170135L,666507302212L,7467860256482L,81701886884909L,876350926474594L,9244732890227899L,96149151282735127L,987831159810408273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201341Inst : IEnumerable<long>
{
public static readonly long[] Value=A201341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201341.Bytes);
public long this[int i]=>Value[i];

public static A201341Inst Instance=new A201341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201342
{
public static readonly long[] Value={ 0L,213L,6304L,194873L,6442039L,204185475L,6035149800L,166685904910L,4343111301270L,107811107350689L,2572353758832182L,59415299284527760L,1336167955301861214L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201342Inst : IEnumerable<long>
{
public static readonly long[] Value=A201342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201342.Bytes);
public long this[int i]=>Value[i];

public static A201342Inst Instance=new A201342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201343
{
public static readonly long[] Value={ 0L,2007L,120750L,6442039L,365946958L,21233514530L,1207482454151L,66042015070636L,3456814178223675L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201343Inst : IEnumerable<long>
{
public static readonly long[] Value=A201343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201343.Bytes);
public long this[int i]=>Value[i];

public static A201343Inst Instance=new A201343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201344
{
public static readonly long[] Value={ 0L,15497L,1977305L,204185475L,21233514530L,2272075034938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201344Inst : IEnumerable<long>
{
public static readonly long[] Value=A201344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201344.Bytes);
public long this[int i]=>Value[i];

public static A201344Inst Instance=new A201344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201345
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,15L,15L,0L,0L,213L,295L,213L,0L,0L,2007L,6304L,6304L,2007L,0L,0L,15497L,120750L,194873L,120750L,15497L,0L,0L,106589L,1977305L,6442039L,6442039L,1977305L,106589L,0L,0L,680287L,28778603L,204185475L,365946958L,204185475L,28778603L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201345Inst : IEnumerable<long>
{
public static readonly long[] Value=A201345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201345.Bytes);
public long this[int i]=>Value[i];

public static A201345Inst Instance=new A201345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201346
{
public static readonly long[] Value={ 0L,4L,18L,191L,4860L,310036L,53350918L,26097731070L,37211940860240L,157260419809121989L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201346Inst : IEnumerable<long>
{
public static readonly long[] Value=A201346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201346.Bytes);
public long this[int i]=>Value[i];

public static A201346Inst Instance=new A201346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201347
{
public static readonly long[] Value={ 2L,4L,8L,14L,23L,36L,54L,78L,109L,148L,196L,254L,323L,404L,498L,606L,729L,868L,1024L,1198L,1391L,1604L,1838L,2094L,2373L,2676L,3004L,3358L,3739L,4148L,4586L,5054L,5553L,6084L,6648L,7246L,7879L,8548L,9254L,9998L,10781L,11604L,12468L,13374L,14323L,15316L,16354L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201347Inst : IEnumerable<long>
{
public static readonly long[] Value=A201347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201347.Bytes);
public long this[int i]=>Value[i];

public static A201347Inst Instance=new A201347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201348
{
public static readonly long[] Value={ 2L,8L,18L,47L,118L,273L,585L,1174L,2228L,4030L,6992L,11697L,18950L,29839L,45807L,68736L,101044L,145796L,206830L,288899L,397830L,540701L,726037L,964026L,1266756L,1648474L,2125868L,2718373L,3448502L,4342203L,5429243L,6743620L,8324004L,10214208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201348Inst : IEnumerable<long>
{
public static readonly long[] Value=A201348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201348.Bytes);
public long this[int i]=>Value[i];

public static A201348Inst Instance=new A201348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201349
{
public static readonly long[] Value={ 3L,14L,47L,191L,752L,2732L,9111L,28011L,79918L,213153L,535318L,1274359L,2892516L,6291669L,13172108L,26642251L,52229342L,99517435L,184747946L,334871408L,593751872L,1031516926L,1758440929L,2945277335L,4852655894L,7873078897L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201349Inst : IEnumerable<long>
{
public static readonly long[] Value=A201349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201349.Bytes);
public long this[int i]=>Value[i];

public static A201349Inst Instance=new A201349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201350
{
public static readonly long[] Value={ 4L,23L,118L,752L,4860L,29540L,164704L,838248L,3906802L,16781171L,66921332L,249553233L,875898271L,2910325591L,9200601794L,27796173121L,80558496898L,224724538799L,605174810816L,1577359861541L,3988423084299L,9803571070083L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201350Inst : IEnumerable<long>
{
public static readonly long[] Value=A201350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201350.Bytes);
public long this[int i]=>Value[i];

public static A201350Inst Instance=new A201350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201351
{
public static readonly long[] Value={ 5L,36L,273L,2732L,29540L,310036L,3030673L,27104947L,220732437L,1641106829L,11206232481L,70771398891L,416197943012L,2293568841898L,11910310629163L,58569696365494L,273928804681607L,1223107208560736L,5231237485621038L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201351Inst : IEnumerable<long>
{
public static readonly long[] Value=A201351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201351.Bytes);
public long this[int i]=>Value[i];

public static A201351Inst Instance=new A201351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201352
{
public static readonly long[] Value={ 6L,54L,585L,9111L,164704L,3030673L,53350918L,867792264L,12855063828L,173064550218L,2125820442965L,23973988256341L,249906703874274L,2423485396921085L,21992456168363649L,187733722448990317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201352Inst : IEnumerable<long>
{
public static readonly long[] Value=A201352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201352.Bytes);
public long this[int i]=>Value[i];

public static A201352Inst Instance=new A201352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201353
{
public static readonly long[] Value={ 0L,2L,2L,2L,4L,2L,3L,8L,8L,3L,4L,14L,18L,14L,4L,5L,23L,47L,47L,23L,5L,6L,36L,118L,191L,118L,36L,6L,7L,54L,273L,752L,752L,273L,54L,7L,8L,78L,585L,2732L,4860L,2732L,585L,78L,8L,9L,109L,1174L,9111L,29540L,29540L,9111L,1174L,109L,9L,10L,148L,2228L,28011L,164704L,310036L,164704L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201353Inst : IEnumerable<long>
{
public static readonly long[] Value=A201353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201353.Bytes);
public long this[int i]=>Value[i];

public static A201353Inst Instance=new A201353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201354
{
public static readonly BigInteger[] Value={ 1L,4L,28L,292L,4060L,70564L,1471708L,35810212L,995827420L,31153998244L,1082931514588L,41407678132132L,1727226633730780L,78051253062575524L,3798351192214837468L,BigInteger.Parse("198049421007186054052"),BigInteger.Parse("11014905131587945490140"),BigInteger.Parse("650903915009792820650404"),BigInteger.Parse("40726453234725158535472348") };
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
public class A201354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201354Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201354.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201354.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201354Inst Instance=new A201354Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201355
{
public static readonly BigInteger[] Value={ 1L,4L,20L,132L,1140L,12324L,160020L,2424132L,41967540L,817374564L,17688328020L,421061260932L,10934334077940L,307610736087204L,9319558144624020L,302518807147502532L,10474617188712332340UL,BigInteger.Parse("385347795973248950244"),BigInteger.Parse("15010362565222418008020"),BigInteger.Parse("617178205591321673884932") };
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
public class A201355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201355Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201355.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201355.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201355Inst Instance=new A201355Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201356
{
public static readonly long[] Value={ 2L,3L,4L,5L,15L,23L,53L,57L,75L,233L,464L,671L,1431L,2021L,5861L,6056L,9063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201356Inst : IEnumerable<long>
{
public static readonly long[] Value=A201356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201356.Bytes);
public long this[int i]=>Value[i];

public static A201356Inst Instance=new A201356Inst();

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